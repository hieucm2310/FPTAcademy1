using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NWEB.Practice.HieuCM3.Common
{
    public class Config
    {
        public Config()
        {
            IsShowDashBoard = true;
            //cms
            IsViewAndUpdateRole = false;
            IsViewAndUpdateUserRole = false;
            IsUViewAndpdateUserPlace = false;
            IsViewFileSAP = false;
            IsViewSessions = false;
            IsUpdateSessionDetail = false;
            IsUpdateSessionStatus = false;
            IsExportSession = false;
            IsApprovalReport = false;
            IsExplainReport = false;
            IsImportUserRole = false;
            IsViewPlace = false;
            IsViewPart = false;
            IsStandardSetup = false;

            //app
            IsCRUSessionApp = false;
            IsScanOrUpdateAssetsApp = false;
            IsUpdateAssetImageApp = false;
            IsUpdateAssetStatusApp = false;
            IsViewSessionApp = false;
        }
        //CMS
        public bool IsShowDashBoard { get; set; }
        public bool IsViewAndUpdateRole { get; set; }
        public bool IsViewAndUpdateUserRole { get; set; }
        public bool IsUViewAndpdateUserPlace { get; set; }
        public bool IsViewFileSAP { get; set; }
        public bool IsViewSessions { get; set; }
        public bool IsUpdateSessionDetail { get; set; }
        public bool IsUpdateSessionStatus { get; set; }
        public bool IsExportSession { get; set; }
        public bool IsApprovalReport { get; set; }
        public bool IsExplainReport { get; set; }
        public bool IsImportUserRole { get; set; }
        public bool IsViewPlace { get; set; }
        public bool IsViewPart { get; set; }
        public bool IsStandardSetup { get; set; }

        //App
        public bool IsCRUSessionApp { get; set; }
        public bool IsScanOrUpdateAssetsApp { get; set; }
        public bool IsUpdateAssetImageApp { get; set; }
        public bool IsUpdateAssetStatusApp { get; set; }
        public bool IsViewSessionApp { get; set; }
        public void setConfigByRole(string role)
        {
            //if (role == RoleConstants.BASIC_SIMPLE)
            //{
            //    //cms
            //    IsViewSessions = true;
            //    IsExportSession = true;
            //    IsApprovalReport = true;
            //    IsExplainReport = true;
            //    //app
            //    IsUpdateAssetImageApp = true;
            //    IsUpdateAssetStatusApp = false;
            //    IsViewSessionApp = true;
            //}
            //if (role == RoleConstants.SIMPLE)
            //{
            //    //cms
            //    IsViewFileSAP = true;
            //    IsViewSessions = true;
            //    IsUpdateSessionDetail = true;
            //    IsUpdateSessionStatus = true;
            //    IsExportSession = true;
            //    IsApprovalReport = true;
            //    IsExplainReport = true;
            //    //app
            //    IsCRUSessionApp = true;
            //    IsScanOrUpdateAssetsApp = true;
            //    IsUpdateAssetImageApp = true;
            //    IsUpdateAssetStatusApp = false;
            //    IsViewSessionApp = true;
            //    IsViewPlace = true;
            //    IsViewPart = true;
            //}
            //if (role == RoleConstants.ADMIN)
            //{
            //    //cms
            //    IsViewAndUpdateRole = true;
            //    IsViewAndUpdateUserRole = true;
            //    IsUViewAndpdateUserPlace = true;
            //    IsViewFileSAP = true;
            //    IsViewSessions = true;
            //    IsUpdateSessionDetail = true;
            //    IsUpdateSessionStatus = true;
            //    IsExportSession = true;
            //    IsApprovalReport = true;
            //    IsExplainReport = true;
            //    IsImportUserRole = true;
            //    IsViewPlace = true;
            //    IsViewPart = true;
            //    IsStandardSetup = true;

            //    //app
            //    IsCRUSessionApp = true;
            //    IsScanOrUpdateAssetsApp = true;
            //    IsUpdateAssetImageApp = true;
            //    IsUpdateAssetStatusApp = true;
            //    IsViewSessionApp = true;
            //}
            //if (role == RoleConstants.SYSTEM)
            //{
            //    //cms
            //    IsViewAndUpdateRole = true;
            //    IsViewAndUpdateUserRole = true;
            //    IsUViewAndpdateUserPlace = true;
            //    IsViewFileSAP = true;
            //    IsViewSessions = true;
            //    IsUpdateSessionDetail = true;
            //    IsUpdateSessionStatus = true;
            //    IsExportSession = true;
            //    IsExplainReport = true;
            //    IsImportUserRole = true;
            //    IsViewPlace = true;
            //    IsViewPart = true;
            //    IsStandardSetup = true;

            //    //app
            //    IsCRUSessionApp = true;
            //    IsScanOrUpdateAssetsApp = true;
            //    IsUpdateAssetImageApp = true;
            //    IsUpdateAssetStatusApp = true;
            //    IsViewSessionApp = true;
            //}
        }
    }
}
