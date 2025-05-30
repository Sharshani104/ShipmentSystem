using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ABC_Shipment_Client
{
    public partial class ShippedItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtDelete_Click(object sender, EventArgs e)
        {
            ShippingService.ABC_ShippingServiceSoapClient client = new ShippingService.ABC_ShippingServiceSoapClient();
            Boolean res = client.deleteShipItem(Int32.Parse(txtsiid.Text));
            if (res == true)
            {
                lblres.Text = "Delete Successfully!";
            }
            else
            {
                lblres.Text = "Error Try again !";
            }
        }

        protected void txtAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtsiid.Text);
            float w = float.Parse(txtweight.Text);
            float d = float.Parse(txtdimen.Text);
            string ins = txtinsu.Text;
            float amnt = float.Parse(txtamnt.Text);
            string dest = txtdesti.Text;
            DateTime deli = Calendar1.SelectedDate;
            int rid = Int32.Parse(DropDownList1.SelectedValue);

            ShippingService.ABC_ShippingServiceSoapClient client = new ShippingService.ABC_ShippingServiceSoapClient();
            Boolean res = client.insertShipItem(id,w,d,ins,amnt,dest,deli,rid);
            if (res == true)
            {
                lblres.Text = "Insert Successfully!";
            }
            else
            {
                lblres.Text = "Error Try again !";
            }
        }
    }
}