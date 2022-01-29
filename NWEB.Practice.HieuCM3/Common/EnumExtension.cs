using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Common
{
    public static class EnumExtension
    {
        public static string ToDescriptionString<T>(T val)
        {
            try
            {
                DescriptionAttribute[] attributes = (DescriptionAttribute[])val
                               .GetType()
                               .GetField(val.ToString())
                               .GetCustomAttributes(typeof(DescriptionAttribute), false);
                return attributes.Length > 0 ? attributes[0].Description : string.Empty;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
