using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace OCMS.MODEL
{
    public class UsersModel
    {
        [DisplayName("Lastname")]
        public string lastname { get; set; }
        [DisplayName("Firstname")]
        public string firstname { get; set; }
        [DisplayName("Middlename")]
        public string middlename { get; set; }
        [DisplayName("Username")]
        public string usercode { get; set; }
        [DisplayName("Password")]
        public string userpass { get; set; }
        public string role { get; set; }
        public string licenseno { get; set; }
        public string privilege { get; set; }
        public int active { get; set; }
        [DisplayName("Active")]
        public string displayactive { get; set; }

    }
}
