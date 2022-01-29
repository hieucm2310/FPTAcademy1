using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public static class UrlUtil
    {
        public static void BuildUrlParams(this string url, Dictionary<string, string> dctParams)
        {
            int index = 0;
            if (dctParams != null && dctParams.Count > 0)
            {
                foreach (var item in dctParams)
                {
                    if (index == 0)
                    {
                        url += "?" + item.Key + "=" + item.Value;
                    }
                    else
                    {
                        url += "&" + item.Key + "=" + item.Value;
                    }
                    index += 1;
                }
            }

        }
    }
}
