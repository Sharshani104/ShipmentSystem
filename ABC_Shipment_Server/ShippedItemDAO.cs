using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ABC_Shipment_Server
{
    public class ShippedItemDAO
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I01IBJR\SQLEXPRESS;Initial Catalog=ABC_Shipments;Integrated Security=True");
       
        public Boolean insert(ShippedItem ob)
        {
            try
            {
                con.Open();
                string sqlQ = "insert into ShippedItem(item_number, weight, dimension, insurance, amount, destination, deliverydate,RC_id) values (" + ob.getitem_id()+ "," + ob.getweight()+ "," + ob.getdimention()+ ", '"+ob.getinsurence()+"', "+ob.getamount()+", '"+ob.getdestination()+"', '"+ob.getdiliverydate().ToShortDateString()+"', "+ob.getrid()+")";
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

        public Boolean delete(int id)
        {
            try
            {
                con.Open();
                string sqlQ = "delete ShippedItem where item_number=" +id+ "";
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