using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABC_Shipment_Server
{
    public class RetailCenter
    {
        private int RC_id;
        private string RC_type;
        private string RC_address;

        public RetailCenter()
        {

        }

        public RetailCenter(int rid, string rtype, string raddress)
        {
            RC_id = rid;
            RC_type = rtype;
            RC_address = raddress;

        }

        public void setrid(int rid)
        {
            RC_id = rid;
        }

        public void setrtype(string rtype)
        {
            RC_type = rtype;
        }

        public void setraddress(string raddress)
        {
            RC_address = raddress;
        }

        public int getrid()
        {
            return RC_id;
        }

        public string getrtype()
        {
            return RC_type;
        }

        public string getraddress()
        {
            return RC_address;
         
        }
    }
}