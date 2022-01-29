using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public static class StringExtension
    {
        public static int FirstCharacterIsNumber(this string _string)
        {
            int i = 0;
            if (string.IsNullOrEmpty(_string))
                return -1;
            var arr = _string.ToCharArray();
            for (i = 0; i < arr.Length; ++i)
            {
                var _out = 0;
                var hasNumber = Int32.TryParse(arr[i].ToString(), out _out);
                if (hasNumber)
                    return i;
            }
            return -1;
        }
    }
}
