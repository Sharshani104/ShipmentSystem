using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ABC_Shipment_Client
{
    public partial class RetailCenter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ShippingService.ABC_ShippingServiceSoapClient client = new ShippingService.ABC_ShippingServiceSoapClient();
            Boolean respons = client.insertRC(Int32.Parse(txtrcid.Text), txttype.Text, txtAddress.Text);
            if(respons == true)
            {
                lblres.Text = "Insert Successfully!";
            }
            else
            {
                lblres.Text = "Error Try again !";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            ShippingService.ABC_ShippingServiceSoapClient client = new ShippingService.ABC_ShippingServiceSoapClient();
            Boolean respons = client.updateRC(Int32.Parse(txtrcid.Text), txttype.Text, txtAddress.Text);
            if (respons == true)
            {
                lblres.Text = "Update Successfully!";
            }
            else
            {
                lblres.Text = "Error Try again !";
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            RetailCenter1 rob1 = new RetailCenter1();
            ShippingService.ABC_ShippingServiceSoapClient client = new ShippingService.ABC_ShippingServiceSoapClient();
            client.searchRC(Int32.Parse(txtrcid.Text));
            txttype.Text = rob1.getrtype();
            txttype.Text = rob1.getraddress();

        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            ShippingService.ABC_ShippingServiceSoapClient client = new ShippingService.ABC_ShippingServiceSoapClient();
            Boolean respons = client.deletetRC(Int32.Parse(txtrcid.Text));
            if (respons == true)
            {
                lblres.Text = "Delete Successfully!";
            }
            else
            {
                lblres.Text = "Error Try again !";
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtrcid.Text = "";
            txttype.Text = "";
            txtAddress.Text = "";
        }
    }
   
}