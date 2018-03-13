﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCMS.MODEL
{
    public class ConsultationModel : Baseline
    {

        public string ConsultatonId { get; set; }

        public string MemberCOde { get; set; }

        public DateTime? TimeIn { get; set; }

        public DateTime? TimeOut { get; set; }

        public string Complaints { get; set; }

        public string Medicine { get; set; }

        public int Quantity { get; set; }

        public string Disposition { get; set; }

        public string DiagCode { get; set; }
     
    }
}
