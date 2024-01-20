using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using IEntity;
using DataAccess;

namespace IBusiness
{
    public class BAUserMaster
    {
        public DataTable GetLoginDetails(UserDetails userDetails)
        {
            try
            {
                DAUserMaster um = new DAUserMaster();
                return um.GetUserData(userDetails);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public DataTable GetUserMaster()
        {
            try
            {
                DAUserMaster UserM = new DAUserMaster();
                return UserM.GetUserMaster();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public DataTable GetMenulist(int RoleId)
        {
            try
            {
                DAUserMaster Menulst = new DAUserMaster();
                return Menulst.GetMenulist(RoleId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int GetRole(string strEmail)
        {
            try
            {
                DAUserMaster Menulst = new DAUserMaster();
                return Menulst.GetRole(strEmail);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
