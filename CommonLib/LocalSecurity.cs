using CommonLib.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib
{
    public class LocalSecurity
    {
        public AuthenticationObject AuthObject { get; set; }
        public static string GetSecurityToken()
        {
            return "";
        }
        public static string EncryptData(string data, string securityToken)
        {
            return "";
        }

        public static string DecryptData(string data, string securityToken)
        {
            return "";
        }
    }
}
