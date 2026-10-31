using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentPages
{
    public partial class Hobbies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string hobbies = "";

            foreach (ListItem items in ListBox1.Items)
            {
                if (items.Selected && items.Text != "Select the Hobbies")
                {
                    hobbies += items.Text + ", ";
                }
            }

            if (hobbies == "")
            {
                Label2.Text = "Please select at least one hobby.";
            }
            else
            {
                Session["Hobbies"] = hobbies;
                Response.Redirect("~/Thankyou.aspx");
            }
        }
    }
}