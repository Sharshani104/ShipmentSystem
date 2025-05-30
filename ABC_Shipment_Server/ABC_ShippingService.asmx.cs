using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.WebSockets;

namespace ABC_Shipment_Server
{
    /// <summary>
    /// Summary description for ABC_ShippingService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ABC_ShippingService : System.Web.Services.WebService
    {

        [WebMethod]
        public Boolean insertRC(int id, string type, string address)
        {
            RetailCenter rob = new RetailCenter(id, type, address);
            RetailCenterDAO dao = new RetailCenterDAO();
            Boolean res = dao.insert(rob);
            return res;
        }

        [WebMethod]
        public Boolean updateRC(int id, string type, string address)
        {
            RetailCenter rob = new RetailCenter(id, type, address);
            RetailCenterDAO dao = new RetailCenterDAO();
            Boolean res = dao.update(rob);
            return res;
        }

        [WebMethod]
        public Boolean deletetRC(int id)
        {
            RetailCenterDAO dao = new RetailCenterDAO();
            Boolean res = dao.delete(id);
            return res;
        }

        [WebMethod]
        public RetailCenter searchRC(int id)
        {
            RetailCenterDAO dao = new RetailCenterDAO();
            RetailCenter rob = dao.search(id);
            return rob;
        }

        [WebMethod]

        public Boolean insertShipItem(int siid, float wei, float dim, string ins, float amnt, string dest, DateTime deli, int rid)
        {
            ShippedItem sob = new ShippedItem(siid, wei, dim, ins, amnt, dest, deli, rid);
            ShippedItemDAO dao = new ShippedItemDAO();
            Boolean res = dao.insert(sob);
            return res;
        }

        [WebMethod]

        public Boolean deleteShipItem(int id)
        {
            ShippedItemDAO dao = new ShippedItemDAO();
            Boolean res = dao.delete(id);
            return res;

        }
    }
}
