using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopware.Api.Utili
{
    public class SwDateTime
    {
        public SwDateTime(string text)
        {
            Text = text;
        }

        public SwDateTime(DateTime datetime)
        {
            DateTime = datetime;
        }

        public DateTime DateTime { get; set; }

        public string Text
        {
            get
            {
                return DateTime.ToString("o");
            }

            set
            {
                try
                {
                    DateTime = DateTime.Parse(value);
                }
                catch (Exception e)
                {
                    DateTime = DateTime.MinValue;
                }
            }
        }

        public static implicit operator DateTime(SwDateTime d)
        {
            return d.DateTime;
        }
 
        public static implicit operator SwDateTime(DateTime d)
        {
            return new SwDateTime(d);
        }

        public static implicit operator string(SwDateTime d)
        {
            return d.Text;
        }

        public static implicit operator SwDateTime(string d)
        {
            return new SwDateTime(d);
        }

    }
}
