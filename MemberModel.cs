using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace OCMS.MODEL
{
    public class MemberModel
    {

        [DisplayName("Employee Id")]
        public string EmpID { get; set; }

        public string MemberCode { get; set; }

        [DisplayName("Last Name")]
        public string LName { get; set; }

        [DisplayName("First Name")]
        public string FName { get; set; }

        [DisplayName("Middle Name")]
        public string MName { get; set; }

        [DisplayName("Birthday")]
        public string BDate { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }

        [DisplayName("Company Name")]
        public string CompanyName { get; set; }

        //public static implicit operator List<object>(MemberModel v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
