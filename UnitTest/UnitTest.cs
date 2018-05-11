﻿using System;
using OCMS.MODEL;
using OCMS.Class;
using OCMS.Bussiness;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Security.Cryptography;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        //    [TestMethod]
        //    public void saveConsultation()
        //    {
        //        ConsultationBusiness _bll = new ConsultationBusiness();
        //        var db = new ConsultationModel();

        //        db.ConsultatonId = "123GG";
        //        db.MemberCode = "12345678";
        //        db.TimeIn = DateTime.Now;
        //        db.TimeOut = DateTime.Now;
        //        db.Complaints = "head ache";
        //        db.Medicine = "biogesic";
        //        db.Disposition = "n/a";
        //        db.DiagCode = "Dx8252"; //head ache due to sleep deprivation
        //        db.CreatedBy = "knguardian";
        //        db.CreatedDate = DateTime.Now;

        //        _bll.saveConsultation(db);

        //        Assert.AreEqual(true, true);
        //    }

        //[TestMethod]
        //public void getMember()
        //{
        //    MemberBussiness _bll = new MemberBussiness();

        //    List<MemberModel> listMember = _bll.GetMember();

        //    Assert.IsNotNull(listMember);
        //}

        //[TestMethod]
        //public void GetMeberExcel()
        //{
        //    MemberBussiness _bll = new MemberBussiness();

        //    string filePath = "D:\\OCMS\\OH_MasterList\\CITIBANK SAVINGS, INC..xlsx";
        //    string fileName = "CITIBANK SAVINGS, INC.";

        //    List<MemberModel> listMemModel = _bll.GetMemberExcel(filePath, fileName);

        //    Assert.IsNotNull(listMemModel);
        //}

        [TestMethod]
        public void savePatientComp()
        {
            PatientComplainBusiness _bll = new PatientComplainBusiness();

            var ds = new  PatientComplaintModel();

            ds.ConsultatonId = Guid.NewGuid().ToString();
            ds.LastName = "Guardian";
            ds.FirstName = "Kristine";
            ds.Complaints = "Head Ache,Migraine";
            ds.CreatedDate = DateTime.Now;
            ds.CreatedBy = "Patient";
            ds.Agree = true;

            _bll.SavePatientComplaint(ds);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void DecryptPassword(string encrypt)
        {
            string  password = clsUtility.Decrypt("6+ZFa85kU8GXl7B+QT1P2IqCyv+ag5z16LLICCSrwA4=");

            Assert.IsNotNull(password);
        }

        [TestMethod]
        public void encrypt()
        {
            //DateTime d = DateTime.Now.Date.ToString("MM-dd-yyyy");
            string field = DateTime.Now.Date.ToString("1000243153");

            string toEncrypt = field.Replace(" ", string.Empty);

            string result = clsUtility.Encrypt(toEncrypt);

            Assert.IsNotNull(result);

        }
    }
}
