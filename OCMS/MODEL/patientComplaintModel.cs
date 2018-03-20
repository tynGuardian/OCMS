using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCMS.MODEL
{
    public class PatientComplaintModel : Baseline
    {

        public string ConsultatonId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Complaints { get; set; }

        public bool Agree { get; set; }

        public string Company { get; set; }

    }
}
