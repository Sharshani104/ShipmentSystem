using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABC_Shipment_Server
{
    public class ShippedItem
    {
        private int item_number;
        private float weight;
        private float dimension;
        private string insurance;
        private float amount;
        private string destination;
        private DateTime deliverydate;
        private int RC_id;

        public ShippedItem()
        {

        }

        public ShippedItem(int id, float w, float d, string ins,float amnt, string dest,DateTime deli,int rid)
        {
            item_number = id;
            weight = w;
            dimension = d;
            insurance = ins;
            amount = amnt;
            destination = dest;
            deliverydate = deli;
            RC_id = rid;
        }

        public int getitem_id()
        {
            return item_number;
        }

        public float getweight()
        {
            return weight;
        }

        public float getdimention()
        {
            return dimension;
        }

        public string getinsurence()
        {
            return insurance;
        }

        public float getamount()
        {
            return amount;
        }

        public string getdestination()
        {
            return destination;
        }

        public DateTime getdiliverydate()
        {
            return deliverydate;
        }

        public int getrid()
        {
            return RC_id;
        }
    }
}