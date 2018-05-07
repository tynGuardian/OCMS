using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace OCMS.MODEL
{
    public class MedicineModel
    {

        public int genericId { get; set; }

        [DisplayName("Medicine")]
        public string genericName { get; set; }

    }
}
