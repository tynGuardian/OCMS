using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCMS.MODEL
{
    public class OMReportModel
    {
        public string Employee_id { get; set; }
        public string Employee_Name { get; set; }
        public string created_date { get; set; }
        public DateTime? time_in { get; set; }
        public DateTime? time_out { get; set; }
        public int? Age { get; set; }
        public string BirthDate { get; set; }
        public string gender { get; set; }
        public string complaint1 { get; set; }
        public string complaint2 { get; set; }
        public string complaint3 { get; set; }
        public string Medicine1 { get; set; }
        public string Medicine2 { get; set; }
        public string Medicine3 { get; set; }
        public string quantity1 { get; set; }
        public string quantity2 { get; set; }
        public string quantity3 { get; set; }
        public string disposition { get; set; }
        public string diagnosis { get; set; }
    }
}
