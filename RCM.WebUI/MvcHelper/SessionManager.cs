using RCM.Model.Complex.Custom;
using RCM.Model.Complex.DashBoard.SystemManagement.User;
using RCM.Model.Domain;
using System.Collections.Generic;
using System.Web;

namespace RCM.WebUI.MvcHelper
{
    public static class SessionManager
    {
        public static User ActiveUser
        {
            get
            {
                return HttpContext.Current.Session["ActiveUser"] as User;
            }
            set
            {
                HttpContext.Current.Session.Add("ActiveUser", value);
            }
        }
        public static int ActiveUserId
        {
            get
            {
                return int.Parse(HttpContext.Current.Session["ActiveUserId"].ToString());
            }
            set
            {
                HttpContext.Current.Session.Add("ActiveUserId", value);
            }
        }
        public static string ActiveUserUserName
        {
            get
            {
                return HttpContext.Current.Session["ActiveUserUserName"].ToString();
            }
            set
            {
                HttpContext.Current.Session.Add("ActiveUserUserName", value);
            }
        }
        public static string ActiveUserEmail
        {
            get
            {
                return HttpContext.Current.Session["ActiveUserEmail"].ToString();
            }
            set
            {
                HttpContext.Current.Session.Add("ActiveUserEmail", value);
            }
        }
        public static string ActiveUserBranchName
        {
            get
            {
                return HttpContext.Current.Session["ActiveUserBranchName"].ToString();
            }
            set
            {
                HttpContext.Current.Session.Add("ActiveUserBranchName", value);
            }
        }
        public static List<short> ActiveUserBranchIds
        {
            get
            {
                return HttpContext.Current.Session["ActiveUserBranchIds"] as List<short>;
            }
            set
            {
                HttpContext.Current.Session.Add("ActiveUserBranchIds", value);
            }
        }
        public static List<byte> ActiveUserAuthorityTypeIds
        {
            get
            {
                return HttpContext.Current.Session["ActiveUserAuthorityTypeIds"] as List<byte>;
            }
            set
            {
                HttpContext.Current.Session.Add("ActiveUserAuthorityTypeIds", value);
            }
        }
        public static List<Branch> ActiveUserBranchs
        {
            get
            {
                return HttpContext.Current.Session["ActiveUserBranchs"] as List<Branch>;
            }
            set
            {
                HttpContext.Current.Session.Add("ActiveUserBranchs", value);
            }
        }
        public static List<UserBranchAuthority> UserBranchAuthorities
        {
            get
            {
                return HttpContext.Current.Session["UserBranchAuthorities"] as List<UserBranchAuthority>;
            }
            set
            {
                HttpContext.Current.Session.Add("UserBranchAuthorities", value);
            }
        }
        public static List<string> ActiveUserBranchNames
        {
            get
            {
                return HttpContext.Current.Session["ActiveUserBranchNames"] as List<string>;
            }
            set
            {
                HttpContext.Current.Session.Add("ActiveUserBranchNames", value);
            }
        }
        public static short ActiveUserBranchID
        {
            get
            {
                return short.Parse(HttpContext.Current.Session["ActiveUserBranchID"].ToString());
            }
            set
            {
                HttpContext.Current.Session.Add("ActiveUserBranchID", value);
            }
        }
        public static byte ActiveUserAuthorityTypeID
        {
            get
            {
                return byte.Parse(HttpContext.Current.Session["ActiveAuthorityTypeID"].ToString());
            }
            set
            {
                HttpContext.Current.Session.Add("ActiveAuthorityTypeID", value);
            }
        }
        public static List<Branch> AllBranchs
        {
            get
            {
                return HttpContext.Current.Session["AllBranchs"] as List<Branch>;
            }
            set
            {
                HttpContext.Current.Session.Add("AllBranchs", value);
            }
        }
        public static List<AuthorityType> AllAuthorityTypes
        {
            get
            {
                return HttpContext.Current.Session["AllAuthorityTypes"] as List<AuthorityType>;
            }
            set
            {
                HttpContext.Current.Session.Add("AllAuthorityTypes", value);
            }
        }
        public static List<UserListForDataTableVm> AllUserList
        {
            get
            {
                return HttpContext.Current.Session["AllUserList"] as List<UserListForDataTableVm>;
            }
            set
            {
                HttpContext.Current.Session.Add("AllUserList", value);
            }
        }
        public static ErrorFormatVm ErrorFormatVm
        {
            get
            {
                return HttpContext.Current.Session["ErrorFormatVm"] as ErrorFormatVm;
            }
            set
            {
                HttpContext.Current.Session.Add("ErrorFormatVm", value);
            }
        }



    }


}
