using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace OCMS.MODEL
{
    public class UsersModel
    {
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string usercode { get; set; }
        public string userpass { get; set; }
        public string role { get; set; }
        public string licenseno { get; set; }
        public int active { get; set; }

    }
}
