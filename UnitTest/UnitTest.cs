using System;
using OCMS.MODEL;
using OCMS.Bussiness;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void saveConsultation()
        {
            ConsultationBusiness _bll = new ConsultationBusiness();
            var db = new ConsultationModel();

            db.ConsultatonId = "123GG";
            db.MemberCOde = "12345678";
            db.TimeIn = DateTime.Now;
            db.TimeOut = DateTime.Now;
            db.Complaints = "head ache";
            db.Medicine = "biogesic";
            db.Quantity = 1;
            db.Disposition = "n/a";
            db.DiagCode = "Dx8252"; //head ache due to sleep deprivation
            db.CreatedBy = "knguardian";
            db.CreatedDate = DateTime.Now;

            _bll.saveConsultation(db);

            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void getMember()
        {
            MemberBussiness _bll = new MemberBussiness();

            List<MemberModel> listMember = _bll.GetMember();

            Assert.IsNotNull(listMember);
        }

        [TestMethod]
        public void GetMeberExcel()
        {
            MemberBussiness _bll = new MemberBussiness();

            string filePath = "D:\\OCMS\\OH_MasterList\\CITIBANK SAVINGS, INC..xlsx";
            string fileName = "CITIBANK SAVINGS, INC.";

            List<MemberModel> listMemModel = _bll.GetMemberExcel(filePath, fileName);

            Assert.IsNotNull(listMemModel);
        }
    }
}
