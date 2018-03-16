using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCMS.MODEL
{
    public class DiagnosisModel
    {
        public string diag_code { get; set; }

        public string icd10_code { get; set; }

        public string icd10_4c { get; set; }

        public string diag_desc { get; set; }
    }
}
