using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace OCMS.MODEL
{
    public class PatientComplaintModel : Baseline
    {

        public string ConsultatonId { get; set; }
        public string geid { get; set; }
        public string membercode { get; set; }
        [DisplayName("EMPLOYEE NAME")]
        public string EmpName { get; set; }
        [DisplayName("COMPLAINTS")]
        public string Complaints { get; set; }
        [DisplayName("MEDICINES")]
        public string Medicine { get; set; }
        public bool Agree { get; set; }
        [DisplayName("LEGAL VEHICLE")]
        public string Company { get; set; }
        [DisplayName("DIAGNOSIS")]
        public string diagnosis { get; set; }
        [DisplayName("DISPOSITION")]
        public string disposition { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MedicineValue { get; set; }
    }
}
