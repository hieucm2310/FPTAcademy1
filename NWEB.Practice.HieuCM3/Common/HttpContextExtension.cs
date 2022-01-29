using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Common
{
    public static class HttpContextExtension
    {
        public static bool IsAjaxRequest(this HttpContext context)
        {
            try
            {
                var type = context.Request.Headers["x-requested-with"].ToString();
                if (string.IsNullOrEmpty(type))
                    return false;
                return type.Equals("XmlHttpRequest", StringComparison.OrdinalIgnoreCase);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static string GetFileName(this HttpContent httpContent)
        {
            var header = httpContent.Headers;
            if (header != null&&header.ContentDisposition!=null)
            {
                return httpContent.Headers.ContentDisposition.FileNameStar;
            }
            return null;
        }

        public static T GetObjFromJson<T>(this HttpContext context, string key)
        {
            T t = Activator.CreateInstance<T>();
            try
            {
                var stringData = context.Request.Form[key][0];
                t = JsonConvert.DeserializeObject<T>(stringData);
            }
            catch (Exception ex)
            {

            }
            return t;

        }
    }
}
