using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCMS.MODEL
{
    public class patientComplaintModel :  Baseline
    {

        public string ConsultatonId { get; set; }

        public DateTime? TimeIn { get; set; }

        public DateTime? TimeOut { get; set; }

        public string Complaints { get; set; }
        
    }
}
