using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Constants
{
    public class LoginConstant
    {
        public const string PERSON_INFO_SESSION = "PERSON_INFO_SESSION";
        public const string CONFIG = "CONFIG";
        public const string USER_ACTION = "USER_ACTION";
        //For login Section
        public const string SESSION_IP_REMOTE = "IP Remote";
        public const string SESSION_IP_REMOTE_COUNT = "Count IP remote Login";
        public const string SESSION_IMPORT = "IMPORT_SESSION";

        public const int LOGIN_SUCCESS = 0;
        public const int LOGIN_FAILED = -1;
        public const int LOGIN_LOCKED = -2;
        public const string P_AD_DEFAUL = "Vinfast@2021";
    }
}
