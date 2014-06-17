using CommonLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourManager.Contracts
{
    public class User
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Telephone { get; set; }

        public string Store(string _name, string _age, string _telephone)
        {
            return "user=" + _name + "&pass=" + _telephone;
        }

        public string Validate(string _user,string _pass,string securityToken)
        {
            return "user=" + LocalSecurity.EncryptData(_user, securityToken) + "&pass=" + LocalSecurity.EncryptData(_pass, securityToken);
        }
    }
}
