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
        MedicineDataAccess medicineDataAccess = new MedicineDataAccess();

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


        public List<MedicineModel> getMedicine()
        {
            try
            {
                List<MedicineModel> medList = medicineDataAccess.GetMedicine();

                return medList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<DispositionModel> getDisposition()
        {
            try
            {
                List<DispositionModel> dispoList = _dataAccess.getDisposition();

                return dispoList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<DiagnosisModel> getDiagnosis()
        {
            try
            {
                List<DiagnosisModel> diagList = _dataAccess.getDiagnosis();

                return diagList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<CompanyModel> getCompany()
        {
            try
            {

                List<CompanyModel> compList = _dataAccess.getCompany();
                return compList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
