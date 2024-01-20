using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using IEntity;
using System.Data;

namespace DataAccess
{
    public class DAUserMaster
    {
        SqlConnection conn;
        GetConnection getConnection = new GetConnection();
        //SqlCommand cmd;
        public DataTable GetUserData(UserDetails UDetails)
        {
            try
            {
                DataSet ds = new DataSet();

                conn = new SqlConnection(getConnection.GetConnectionString());
                conn.Open();
                //cmd = new SqlCommand("USP_GetLoginDetails", conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] sqlParameters = new SqlParameter[3];
                sqlParameters[0] = new SqlParameter("@Command", SqlDbType.VarChar, 100);
                sqlParameters[0].Value ="Select"; 

                sqlParameters[1] = new SqlParameter("@Email", SqlDbType.VarChar,100);
                sqlParameters[1].Value = UDetails.EmailId;

                sqlParameters[2] = new SqlParameter("@Password", SqlDbType.VarChar, 100);
                sqlParameters[2].Value = UDetails.Password;

                ds = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "USP_GetLoginDetails", sqlParameters);
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //if (ds != null && ds.Tables[0].Rows.Count > 0)
                //{
                    return ds.Tables[0];
                //}
                //else
                //{
                //    return null;
                //}
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                
                //cmd = null;
                conn.Close();
            }

        }

        public DataTable GetUserMaster()
        {
            try
            {
                DataSet ds = new DataSet();

                conn = new SqlConnection(getConnection.GetConnectionString());
                conn.Open();
                
                SqlParameter[] sqlParameters = new SqlParameter[3];
                sqlParameters[0] = new SqlParameter("@Command", SqlDbType.VarChar, 100);
                sqlParameters[0].Value = "GetUserDetails";
                
                ds = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "USP_GetLoginDetails", sqlParameters);
                
                if (ds != null && ds.Tables.Count > 0)
                {
                    return ds.Tables[0];
                }
                else
                {
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        public DataTable GetMenulist(int RoleId)
        {
            try
            {
                DataSet ds = new DataSet();

                conn = new SqlConnection(getConnection.GetConnectionString());
                conn.Open();

                SqlParameter[] sqlParameters = new SqlParameter[3];
                sqlParameters[0] = new SqlParameter("@Command", SqlDbType.VarChar, 100);
                sqlParameters[0].Value = "GetMenuList";
                sqlParameters[1] = new SqlParameter("@Role", SqlDbType.VarChar, 100);
                sqlParameters[1].Value = RoleId;

                ds = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "USP_GetMenus", sqlParameters);
             
                return ds.Tables[0];
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        public int GetRole(string strEmail)
        {
            try
            {
                DataSet ds = new DataSet();

                conn = new SqlConnection(getConnection.GetConnectionString());
                conn.Open();

                SqlParameter[] sqlParameters = new SqlParameter[3];
                sqlParameters[0] = new SqlParameter("@Email", SqlDbType.VarChar, 100);
                sqlParameters[0].Value = strEmail;

                ds = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "USP_GetRole" , sqlParameters);

                if (ds != null && ds.Tables[0].Rows.Count>0)
                {
                    return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

    }
}
