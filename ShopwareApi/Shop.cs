using Shopware.Api.Entities.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using Shopware.Api.Entities;
using System.Collections;
using System.Reflection;
using Shopware.Api.Entities.Responses;

namespace Shopware.Api
{
    public class Shop
    {
        public Shop()
        {

        }

        public Shop(string shopHost, string user, string apiKey, bool useSSL = true)
        {
            ShopHost= shopHost;
            User = user;
            ApiKey = apiKey;
            UseSSl = useSSL;
        }

        public string ShopHost{ get; set; }
        public string User { get; set; }
        public string ApiKey { get; set; }
        public bool UseSSl { get; set; } = true;
        public IReadOnlyList<string> ErrorList
        {
            get
            {
                return m_errorList;
            }

        }

        private List<string> m_errorList = new List<string>();

        private CredentialCache credCache = new CredentialCache();

        private static Hashtable typeAttributeTable = new Hashtable();
        private static Hashtable typeSerializerTable = new Hashtable();

        #region type
        private CustomAttributeData getCustomAttributeData<T>()
        {
            var t = typeof(T);
            if (typeAttributeTable.Contains(t))
            {
                return typeAttributeTable[t] as CustomAttributeData;
            }
            else
            {
                CustomAttributeData attr = t.CustomAttributes.Where(a => a.AttributeType == typeof(ShopwareEntityAttribute)).FirstOrDefault();
                typeAttributeTable.Add(t, attr);
                if(attr == null)
                {
                    throw new NotSupportedException(t.Name + " isn't supported, it must have the ShopwareEntityAttribute!");
                }
                return attr;
            }
        }

        private DataContractJsonSerializer getSerializer<T>()
        {
            var t = typeof(T);
            if (typeSerializerTable.Contains(t))
            {
                return typeSerializerTable[t] as DataContractJsonSerializer;
            }
            else
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                typeSerializerTable.Add(t, serializer);
                return serializer;
            }
        }

        private void checkType<T>(OperationTypes operation)
        {
            var attr = getCustomAttributeData<T>();
            int? support = attr?.NamedArguments.Where(arg => arg.MemberName == "AllowedOperation")?.FirstOrDefault().TypedValue.Value as int?;
            if (support == null || !support.HasValue || (support != null && support.HasValue && ((support & (int)operation) != (int)operation)))
            {
                throw new NotSupportedException(typeof(T).Name + " doesn't support operation: " + operation + "!");
            }
        }
        #endregion

        #region request

        private string getEntityName<T>()
        {
            
            CustomAttributeData attr = getCustomAttributeData<T>();
            var entityName = attr?.NamedArguments.Where(arg => arg.MemberName == "EntityName")?.FirstOrDefault().TypedValue.Value as string;
            //var entityName = attr.ConstructorArguments.FirstOrDefault().Value as string;
            if (entityName == null)
            {
                throw new NotSupportedException("No entityname found on given class");
            }
            return entityName;
        }

        private Uri buildUri<T>(string condition)
        {
            if (ShopHost == null)
            {
                throw new NullReferenceException("ShopHostProperty is null");
            }
            string entityName = getEntityName<T>();
            var addressBuidler = new UriBuilder();
            addressBuidler.Host = ShopHost;
            addressBuidler.Path = "api/" + entityName + "/" + condition;
            addressBuidler.Scheme = UseSSl ? "hhtps" : "http";
            return addressBuidler.Uri;
        }

        private HttpWebRequest getRequest<T>(string method, string condition = "")
        {
            var uri = buildUri<T>(condition);
            var cred = credCache.GetCredential(uri, "Digest");
            if(cred == null)
            {
                if (User == null)
                {
                    throw new NullReferenceException("User is null");
                }
                if (ApiKey == null)
                {
                    throw new NullReferenceException("ApiKey is null");
                }
                cred = new NetworkCredential(User, ApiKey);
                credCache.Add(uri, "Digest", cred);
            }          
            var request = WebRequest.CreateHttp(uri);
            request.PreAuthenticate = true;
            request.Method = method;
            request.Credentials = credCache;
            return request;
        }

        private string buildQueryString(Dictionary<string, string> condition)
        {
            if(condition != null && condition?.Count > 0)
            {
                var queryString = string.Empty;
                foreach(var pair in condition)
                {
                    if (pair.Key == condition.First().Key)
                    {
                        queryString += "?";
                    }
                    else
                        queryString += "&";
                    queryString += pair.Key + "=" + pair.Value;
                }
                return queryString;
            }
            return string.Empty;
        }

        #endregion

        public IList<T> GetList<T>(Dictionary<string, string> condition = null) 
        {
            checkType<T>(OperationTypes.GetList);
            var request = getRequest<T>("GET", buildQueryString(condition));
            try
            {
                using (var response = request.GetResponse())
                {
                    var stream = response.GetResponseStream();
                    var serializer = getSerializer<ListResponse<T>>();
                    List<T> entitys = new List<T>();
                    ListResponse<T> responseObj = serializer.ReadObject(stream) as ListResponse<T>;
                    if (responseObj?.success == true)
                    {
                        return responseObj.data.ToList();
                    }
                    else
                    {
                        m_errorList.Add(responseObj?.message);
                    }
                }
                return null;
            }
            catch(WebException e)
            {
                m_errorList.Add(e?.Message + "\r\n" + e?.StackTrace);
                return null;
            }
        }

        public T Get<T>(int id, Dictionary<string, string> condition = null)
        {
            checkType<T>(OperationTypes.Get);
            var request = getRequest<T>("GET", id.ToString() + buildQueryString(condition));
            try
            {
                using (var response = request.GetResponse())
                {
                    var stream = response.GetResponseStream();
                    var serializer = getSerializer<SingelResponse<T>>();
                    SingelResponse<T> responseObj = serializer.ReadObject(stream) as SingelResponse<T>;
                    if (responseObj?.success == true)
                    {
                        return responseObj.data;
                    }
                    else
                    {
                        m_errorList.Add(responseObj?.message);
                    }
                }
                return default(T);
            }
            catch (WebException e)
            {
                m_errorList.Add(e?.Message + "\r\n" + e?.StackTrace);
                return default(T);
            }
        }

        public int Post<T>(T entity)
        {
            checkType<T>(OperationTypes.Post);
            var request = getRequest<T>("POST");
            try
            {
                getSerializer<T>().WriteObject(request.GetRequestStream(), entity);
                using (var response = request.GetResponse())
                {
                    var stream = response.GetResponseStream();
                    PostResponse responseObj = getSerializer<PostResponse>().ReadObject(stream) as PostResponse;
                    if (responseObj?.success == true)
                    {
                        int? id = responseObj.data?.id;
                        if(id != null && id.HasValue)
                        {
                            return id.Value;
                        }
                    }
                    else
                    {
                        m_errorList.Add(responseObj?.message);
                    }
                }
                return 0;
            }
            catch (WebException e)
            {
                m_errorList.Add(e?.Message + "\r\n" + e?.StackTrace);
                return 0;
            }
        }

        public int Put<T>(T entity, string id, Dictionary<string, string> condition = null)
        {
            checkType<T>(OperationTypes.Put);
            var request = getRequest<T>("PUT", id + buildQueryString(condition));
            try
            {
                getSerializer<T>().WriteObject(request.GetRequestStream(), entity);
                using (var response = request.GetResponse())
                {
                    var stream = response.GetResponseStream();
                    PostResponse responseObj = getSerializer<PostResponse>().ReadObject(stream) as PostResponse;
                    if (responseObj?.success == true)
                    {
                        int? rid = responseObj.data?.id;
                        if (rid != null && rid.HasValue)
                        {
                            return rid.Value;
                        }
                    }
                    else
                    {
                        m_errorList.Add(responseObj?.message);
                    }
                }
                return 0;
            }
            catch (WebException e)
            {
                m_errorList.Add(e?.Message + "\r\n" + e?.StackTrace);
                return 0;
            }
        }

        public int Put<T>(T[] entitys)
        {
            checkType<T>(OperationTypes.PutBatch);
            var request = getRequest<T>("PUT");
            try
            {
                getSerializer<T[]>().WriteObject(request.GetRequestStream(), entitys);
                using (var response = request.GetResponse())
                {
                    var stream = response.GetResponseStream();
                    PostResponse responseObj = getSerializer<PostResponse>().ReadObject(stream) as PostResponse;
                    if (responseObj?.success == true)
                    {
                        int? rid = responseObj.data?.id;
                        if (rid != null && rid.HasValue)
                        {
                            return rid.Value;
                        }
                    }
                    else
                    {
                        m_errorList.Add(responseObj?.message);
                    }
                }
                return 0;
            }
            catch (WebException e)
            {
                m_errorList.Add(e?.Message + "\r\n" + e?.StackTrace);
                return 0;
            }
        }

        public bool Delete<T>(int id)
        {
            checkType<T>(OperationTypes.Delete);
            var request = getRequest<T>("DELETE", id.ToString());
            try
            {
                using (var response = request.GetResponse())
                {
                    var stream = response.GetResponseStream();
                    BaseResponse responseObj = getSerializer<BaseResponse>().ReadObject(stream) as BaseResponse;
                    if (responseObj?.success == true)
                    {
                        return true;
                    }
                    else
                    {
                        m_errorList.Add(responseObj?.message);
                    }
                }
                return false;
            }
            catch (WebException e)
            {
                m_errorList.Add(e?.Message + "\r\n" + e?.StackTrace);
                return false;
            }
        }

        public bool Delete<T>(int[] ids)
        {
            checkType<T>(OperationTypes.PutBatch);
            var request = getRequest<T>("DELETE");
            try
            {
                getSerializer<int[]>().WriteObject(request.GetRequestStream(), ids);
                using (var response = request.GetResponse())
                {
                    var stream = response.GetResponseStream();
                    BaseResponse responseObj = getSerializer<BaseResponse>().ReadObject(stream) as BaseResponse;
                    if (responseObj?.success == true)
                    {
                        return true;
                    }
                    else
                    {
                        m_errorList.Add(responseObj?.message);
                    }
                }
                return false;
            }
            catch (WebException e)
            {
                m_errorList.Add(e?.Message + "\r\n" + e?.StackTrace);
                return false;
            }
        }

    }
}
