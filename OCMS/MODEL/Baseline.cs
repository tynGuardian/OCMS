using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace OCMS.MODEL
{
    public class Baseline
    {
        [DisplayName("CREATED BY")]
        public string CreatedBy { get; set; }

        [DisplayName ("CREATED DATE")]
        public DateTime? CreatedDate { get; set;  }
    }
}
