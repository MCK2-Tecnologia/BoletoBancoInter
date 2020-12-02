using System;
using System.Linq;
using System.Web;

namespace BoletoInter.Helpers
{
    public static class ObjectToQueryString
    {
        public static String GetQueryString(object obj) 
        {
            var properties = from p in obj.GetType().GetProperties()
                where p.GetValue(obj, null) != null
                select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());

            return String.Join("&", properties.ToArray());
        }
    }
}
