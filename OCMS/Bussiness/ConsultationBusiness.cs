using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OCMS.MODEL;
using OCMS.DAL;

namespace OCMS.Bussiness
{
    public class ConsultationBusiness
    {
        ConsultationDataAccess _dataAccess = new ConsultationDataAccess();

        public bool saveConsultation(ConsultationModel model)
        {
            try
            {

                _dataAccess.SaveConsultation(model);
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
