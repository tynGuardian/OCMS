using System;
using OCMS.MODEL;
using OCMS.Bussiness;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

            var model = new MemberModel();

            model = _bll.GetMember();

            Assert.IsNotNull(model);
        }
    }
}
