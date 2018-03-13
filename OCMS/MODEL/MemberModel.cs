using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace OCMS.MODEL
{
    public class MemberModel
    {

        public string memberCode { get; set; }

        public string Name { get; set; }

        public int? Age { get; set; }

        public string Gender { get; set; }

        [DisplayName("Company Name")]
        public string CompanyName { get; set; }
    }
}
