﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Contracts
{
    public class AuthenticationObject
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string GUUserID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string CompanyID { get; set; }
    }
}
