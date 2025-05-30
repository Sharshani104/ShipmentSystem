using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;

namespace ABC_Shipment_Server
{
    public class RetailCenterDAO
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I01IBJR\SQLEXPRESS;Initial Catalog=ABC_Shipments;Integrated Security=True");
        RetailCenter ob;
        public Boolean insert(RetailCenter ob)
        {
            try
            {
                con.Open();
                string sqlQ = "insert into RetailCenter(RC_id,RC_type,RC_address) values (" + ob.getrid() + ",'" + ob.getrtype() + "','" + ob.getraddress() + "')";
                SqlCommand cmd = new SqlCommand(sqlQ,con);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean update(RetailCenter ob)
        {
            try
            {
                con.Open();
                string sqlQ = "update RetailCenter set RC_type='" + ob.getrtype() + "',  RC_address='" + ob.getraddress() + "' where RC_id=" + ob.getrid() + "";
                SqlCommand cmd = new SqlCommand(sqlQ, con);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public RetailCenter search(int id)
        {
            try
            {
                con.Open();
                string sqlQ = "select * RetailCenter where RC_id=" +id+ "";
                SqlCommand cmd = new SqlCommand(sqlQ, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    ob = new RetailCenter(Convert.ToInt32(sdr["RC_id"]), sdr["RC_type"].ToString(), sdr["RC_address"].ToString());
                }

                sdr.Close();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                con.Close();
            }

            return ob;
        }

        public Boolean delete(int id)
        {
            try
            {
                con.Open();
                string sqlQ = "delete RetailCenter where RC_id="+id +"";
                SqlCommand cmd = new SqlCommand(sqlQ, con);
                cmd.ExecuteReader();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }

        }
    }
}