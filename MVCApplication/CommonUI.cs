using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using IBusiness;

namespace MVCApplication
{
    public class CommonUI
    {
        BAUserMaster objUserM = new BAUserMaster();
        public DataTable getMenus( int RoleId)
        {
            
            return objUserM.GetMenulist(RoleId);
        }

        public int GetUserRole(string strEmail)
        {
            return objUserM.GetRole(strEmail);
        }
    }
}