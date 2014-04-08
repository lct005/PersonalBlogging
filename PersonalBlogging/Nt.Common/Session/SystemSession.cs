using System;
using System.Net;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nt.Common.Constant;

namespace Nt.Common.Session
{
    public class SystemSession
    {
        public static string BaseUrl
        {
            get
            {
                var baseUrl = HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Authority + HttpContext.Current.Request.ApplicationPath;
                return baseUrl;
            }
        }

        public static SystemCachingObject SystemCaching
        {
            get
            {
                return HttpContext.Current.Session[ConstParam.SystemCachingObject] as SystemCachingObject;
            }
            set
            {
                HttpContext.Current.Session[ConstParam.SystemCachingObject] = value;
            }
        }

        #region Users - Roles

        public static long RoleId
        {
            get
            {
                if (HttpContext.Current.Session[ConstParam.RoleId] != null)
                    return Int64.Parse(HttpContext.Current.Session[ConstParam.RoleId].ToString());
                if (SystemCaching != null)
                    return SystemCaching.RoleId;
                return SystemCaching == null ? 0 : SystemCaching.RoleId;
            }
            set
            {
                HttpContext.Current.Session[ConstParam.RoleId] = value;
            }
        }

        public static string RoleName
        {
            get
            {
                if (HttpContext.Current.Session[ConstParam.RoleName] != null)
                    return HttpContext.Current.Session[ConstParam.RoleName].ToString();
                return SystemCaching == null ? string.Empty : SystemCaching.RoleName;
            }
            set
            {
                HttpContext.Current.Session[ConstParam.RoleName] = value;
            }
        }

        public static long UserId
        {
            get
            {
                return SystemCaching == null ? 0 : SystemCaching.UserId;
            }
        }

        public static string FullName
        {
            get
            {
                return SystemCaching == null ? string.Empty : SystemCaching.FullName;
            }
        }

        public static string LoginName
        {
            get
            {
                return SystemCaching == null ? string.Empty : SystemCaching.UserName;
            }
            set
            {
                HttpContext.Current.Session[ConstParam.LoginName] = value;
            }
        }

        public static bool IsAdministrator
        {
            get
            {
                return RoleName.Equals(Roles.Administrator, StringComparison.OrdinalIgnoreCase);
            }
        }

        #endregion
    }
}
