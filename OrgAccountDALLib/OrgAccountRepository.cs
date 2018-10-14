using System;
using System.Collections.Generic;
using OrgAccount.Domain;
using OrgAccount.Repository;
using System.Data;
using System.Linq;

namespace OrgAccountDALLib
{
    public class OrgAccountRepository : IOrgAccountRepository
    {
        public List<OrgReportFee> OrgReportFeeList(string ID)
        {
            throw new NotImplementedException();
        }

        public List<OrgReport> OrgReportList(string ID)
        {
            using (var db = new OrgContext())
            {
                db.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
                db.reports
                    .Where(r=>r.Org.ID == ID)
                    .ToList();
            }
            return null;
        }
    }
}
