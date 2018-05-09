using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OCMS.MODEL;
using OCMS.DAL;

namespace OCMS.Bussiness
{
    public class PatientComplainBusiness
    {

        PatientConsultationDataAccess _dataAccess = new PatientConsultationDataAccess();

        public bool SavePatientComplaint(PatientComplaintModel model)
        {
            
            try
            {
                 _dataAccess.SavePatientComp(model);
                return true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ComplaintModel> getComplaint()
        {
            try
            {
                List<ComplaintModel> complaintList = _dataAccess.getComplaint();

                return complaintList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<PatientComplaintModel> getPatientList(int search)
        {
            try
            {
                List<PatientComplaintModel> complaintList = _dataAccess.getPatientComplaint(search);

                return complaintList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<PatientComplaintModel> getPatientList(string search)
        {
            try
            {
                List<PatientComplaintModel> complaintList = _dataAccess.getPatientComplaint(search);

                return complaintList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
