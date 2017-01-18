using Shopware.Api;
using Shopware.Api.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace TestConsole
{
    class Program
    {
        private static StreamWriter file;

        static void Main(string[] args)
        {

            var shop = new Shop("shopwaredemo.viosys.com", "api", "mnkml70eSevcMog4u9RbNX5ftu821UuPA1JtX5XT", false);

            File.Delete("./output.txt");            
            file = new StreamWriter(File.Create("./output.txt"));

            GetListTest(shop);

            file.Dispose();
            Console.WriteLine("DONE");
            Console.ReadLine();            
        }


        private static void GetListTest(Shop shop)
        {
            outputList(
                shop.GetList<Address>()
                );

            outputList(
                shop.GetList<Article>()
                );

            outputList(
                shop.GetList<Cache>()
                );

            outputList(
                shop.GetList<Category>()
                );

            outputList(
                shop.GetList<Country>()
                );

            outputList(
                shop.GetList<CustomerGroup>()
                );


            outputList(
                shop.GetList<Customer>()
                );
        
            //outputList(
            //    shop.GetList<GenerateArticleImage>()
            //    );

            outputList(
                shop.GetList<Media>()
                );

            outputList(
                shop.GetList<Manufactur>()
                );

            outputList(
                shop.GetList<Order>()
                );

            outputList(
                shop.GetList<PropertyGroup>()
                );

            //outputList(
            //    shop.GetList<Shop>()
            //    );

            //outputList(
            //    shop.GetList<Translation>()
            //    );

            //outputList(
            //    shop.GetList<Variant>()
            //    );

            //outputList(
            //    shop.GetList<Version>()
            //    );
        }

        static void outputList<T>(IEnumerable<T> list)
        {
            foreach(var o in list)
            {
                outputObject(o);
            }
        }

        static void outputObject<T>(T o)
        {
            var type = typeof(T);
            var ser = new DataContractSerializer(type);
            var t = new XmlTextWriter(file);
            ser.WriteObject(t, o);
            /*
            var properties = type.GetProperties();
            foreach(var prop in properties)
            {
                try
                {
                    var value = prop.GetValue(o);
                    string text = value != null ? value.ToString() : "null";
                    file.WriteLine(prop.Name + "\r\n\t=>\t" + text);
                }
                catch(Exception e)
                {}
            }*/

        }
    }
}
