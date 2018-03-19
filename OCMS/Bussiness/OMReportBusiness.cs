using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using OCMS.DAL;
using OCMS.MODEL;

namespace OCMS.Bussiness
{

    public class OMReportBusiness
    {
        OMReportDataAccess ReportAccess = new OMReportDataAccess();

        public List<OMReportModel> getreport(string datefrom, string dateto)
        {

            List<OMReportModel> _reportaccess = ReportAccess.RetrieveReport(datefrom, dateto);
            return _reportaccess;

        }

        
    }
}