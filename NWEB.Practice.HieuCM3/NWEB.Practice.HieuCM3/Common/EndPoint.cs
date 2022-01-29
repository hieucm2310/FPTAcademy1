using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NWEB.Practice.HieuCM3.Common
{
    public class Path
    {
        //Account
        public static string ACCOUNT_LOGIN = "api/Account/Login";
        public static string ACCOUNT_CREATE = "api/account/create";
        public static string ACCOUNT_UPDATE = "api/account/update";
        public static string ACCOUNT_DELETE = "api/account/delete";
        public static string ACCOUNT_TABLE = "api/account/userTable";
        public static string AUTHENCATE_LOGIN = "api/Account/Authencate";
        public static string AUTHENCATEAZUREAD_LOGIN = "api/Account/AuthencateAzureAD";
        public static string CONFIG = "api/Account/getConfig";

        //UserInfo
        public static string USER_DATATABLE = "api/UserInfo/GetListUser";
        public static string USER_CREATE = "api/UserInfo/CreateUser";
        public static string USER_BYID = "api/UserInfo/GetUserById";
        public static string USER_UPDATE = "api/UserInfo/UpdateUser";
        public static string USER_DELETE = "api/UserInfo/DeleteUser";
        public static string USER_BYUSERNAME = "api/UserInfo/GetUserByUserName";
        public static string USER_CHANGEPASSWORD = "api/UserInfo/SaveChangePassword";
        public static string USERORG_BYID = "api/UserInfo/GetUserOrganizationById";
        public static string USER_FORCOMBO = "api/UserInfo/GetListUserForCombo";
        public static string USER_GETALL = "api/UserInfo/GetAllUser";
        public static string USER_EXPORT = "api/UserInfo/GetDataExportUserInfo";

        //Role
        public static string ROLE_FORCOMBO = "api/Role/GetListRoleForCombo";

        //Company
        public static string COMPANY_FORCOMBO = "api/Company/GetListCompanyForCombo";
        public static string COMPANY_DATATABLE = "api/Company/GetListCompany";
        public static string COMPANY_BYID = "api/Company/GetCompanyById";
        public static string COMPANY_CREATE = "api/Company/CreateCompany";
        public static string COMPANY_UPDATE = "api/Company/UpdateCompany";
        public static string COMPANY_DELETE = "api/Company/DeleteCompany";
        public static string COMPANY_ACTIVATE = "api/Company/ActivateCompany";
        public static string COMPANY_DEACTIVATE = "api/Company/DeactivateCompany";

        //Department
        public static string DEPARTMENT_FORCOMBO = "api/Department/GetListDepartmentForCombo";
        public static string DEPARTMENT_BYCOMPANYCODE = "api/Department/GetDepartmentByCompanyCode";
        public static string DEPARTMENT_FORUSERID = "api/Department/GetDepartmentByUserId";
        public static string DEPARTMENT_DATATABLE = "api/Department/GetListDepartment";
        public static string DEPARTMENT_BYID = "api/Department/GetDepartmentById";
        public static string DEPARTMENT_CREATE = "api/Department/CreateDepartment";
        public static string DEPARTMENT_UPDATE = "api/Department/UpdateDepartment";
        public static string DEPARTMENT_DELETE = "api/Department/DeleteDepartment";
        public static string DEPARTMENT_ACTIVATE = "api/Department/ActivateDepartment";
        public static string DEPARTMENT_DEACTIVATE = "api/Department/DeactivateDepartment";

        //Unit
        public static string UNIT_FORCOMBO = "api/Unit/GetListUnitForCombo";
        public static string UNIT_FORDEPARTMENTID = "api/Unit/GetUnitByDepartmentId";
        public static string UNIT_FORUSERID = "api/Unit/GetUnitByUserId";
        public static string UNIT_DATATABLE = "api/Unit/GetListUnit";
        public static string UNIT_CREATE = "api/Unit/CreateUnit";
        public static string UNIT_UPDATE = "api/Unit/UpdateUnit";
        public static string UNIT_DELETE = "api/Unit/DeleteUnit";
        public static string UNIT_BYID = "api/Unit/GetUnitById";
        public static string UNIT_ACTIVATE = "api/Unit/ActivateUnit";
        public static string UNIT_DEACTIVATE = "api/Unit/DeactivateUnit";

        //Project
        public static string PROJECT_DATATABLE = "api/Project/GetListProject";
        public static string PROJECT_BYID = "api/Project/GetProjectById";
        public static string PROJECT_CREATE = "api/Project/CreateProject";
        public static string PROJECT_UPDATE = "api/Project/UpdateProject";
        public static string PROJECT_DELETE = "api/Project/DeleteProject";
        public static string PROJECT_ACTIVATE = "api/Project/ActivateProject";
        public static string PROJECT_DEACTIVATE = "api/Project/DeactivateProject";

        //Currency
        public static string CURRENCY_DATATABLE = "api/Currency/GetListCurrency";
        public static string CURRENCY_BYID = "api/Currency/GetCurrencyById";
        public static string CURRENCY_CREATE = "api/Currency/CreateCurrency";
        public static string CURRENCY_UPDATE = "api/Currency/UpdateCurrency";
        public static string CURRENCY_DELETE = "api/Currency/DeleteCurrency";

        //Supplier
        public static string SUPPLIER_DATATABLE = "api/Supplier/GetListSupplier";
        public static string SUPPLIER_BYID = "api/Supplier/GetSupplierById";
        public static string SUPPLIER_CREATE = "api/Supplier/CreateSupplier";
        public static string SUPPLIER_UPDATE = "api/Supplier/UpdateSupplier";
        public static string SUPPLIER_DELETE = "api/Supplier/DeleteSupplier";
        public static string SUPPLIER_ACTIVATE = "api/Supplier/ActivateSupplier";
        public static string SUPPLIER_DEACTIVATE = "api/Supplier/DeactivateSupplier";

        //Cost
        public static string COST_DATATABLE = "api/Cost/GetListCost";
        public static string COST_BYID = "api/Cost/GetCostById";
        public static string COST_CREATE = "api/Cost/CreateCost";
        public static string COST_UPDATE = "api/Cost/UpdateCost";
        public static string COST_DELETE = "api/Cost/DeleteCost";
        public static string COST_ACTIVATE = "api/Cost/ActivateCost";
        public static string COST_DEACTIVATE = "api/Cost/DeactivateCost";

        //CostType
        public static string COSTTYPE_DATATABLE = "api/CostType/GetListCostType";
        public static string COSTTYPE_BYID = "api/CostType/GetCostTypeById";
        public static string COSTTYPE_CREATE = "api/CostType/CreateCostType";
        public static string COSTTYPE_UPDATE = "api/CostType/UpdateCostType";
        public static string COSTTYPE_DELETE = "api/CostType/DeleteCostType";
        public static string COSTTYPE_ACTIVATE = "api/CostType/ActivateCostType";
        public static string COSTTYPE_DEACTIVATE = "api/CostType/DeactivateCostType";

        //CostType
        public static string CONTRACT_STATUS_DATATABLE = "api/ContractStatus/GetListContractStatus";
        public static string CONTRACT_STATUS_BYID = "api/ContractStatus/GetContractStatusById";
        public static string CONTRACT_STATUS_CREATE = "api/ContractStatus/CreateContractStatus";
        public static string CONTRACT_STATUS_UPDATE = "api/ContractStatus/UpdateContractStatus";
        public static string CONTRACT_STATUS_DELETE = "api/ContractStatus/DeleteContractStatus";
        public static string CONTRACT_STATUS_ACTIVATE = "api/ContractStatus/ActivateContractStatus";
        public static string CONTRACT_STATUS_DEACTIVATE = "api/ContractStatus/DeactivateContractStatus";

        //ReportCategory
        public static string REPORTCATEGORY_DATATABLE = "api/ReportCategory/GetListReportCategory";
        public static string REPORTCATEGORY_CREATE = "api/ReportCategory/CreateReportCategory";
        public static string REPORTCATEGORY_BYID = "api/ReportCategory/GetReportCategoryById";
        public static string REPORTCATEGORY_UPDATE = "api/ReportCategory/UpdateReportCategory";
        public static string REPORTCATEGORY_DELETE = "api/ReportCategory/DeleteReportCategory";
        public static string REPORTCATEGORY_ACTIVATE = "api/ReportCategory/ActivateReportCategory";
        public static string REPORTCATEGORY_DEACTIVATE = "api/ReportCategory/DeactivateReportCategory";
        public static string REPORTCATEGORY_FORCOMBO = "api/ReportCategory/GetListReportCategoryForCombo";

        //Budget
        public static string BUDGET_DATATABLE = "api/Budget/GetListBudget";
        public static string BUDGET_CREATE = "api/Budget/CreateBudget";
        public static string BUDGET_UPDATE = "api/Budget/UpdateBudget";
        public static string BUDGET_BYID = "api/Budget/GetBudgetById";
        public static string BUDGET_DELETE = "api/Budget/DeleteBudget";
        public static string REPORTBUDGET_DATATABLE = "api/Budget/GetListReportBudget";
        public static string REPORTCATEGORY_GETALL = "api/Budget/GetAllReportCategory";
        public static string EXPORT_REPORTCATEGORY = "api/Budget/ExportReportAllCategory";

        //Role
        public static string ROLE_DATATABLE = "api/Role/GetListRole";
        public static string ROLE_CREATE = "api/Role/CreateRole";
        public static string ROLE_DELETE = "api/Role/DeleteRole";
        public static string ROLE_BYID = "api/Role/GetRoleById";
        public static string ROLE_UPDATE = "api/Role/UpdateRole";

        //City
        public static string CITY_DATATABLE = "api/City/GetListCity";
        public static string CITY_CREATE = "api/City/CreateCity";
        public static string CITY_DELETE = "api/City/DeleteCity";
        public static string CITY_BYID = "api/City/GetCityById";
        public static string CITY_UPDATE = "api/City/UpdateCity";
    }
}
