using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentPages
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void CustomValidator1_ServerValidate(object sourse, ServerValidateEventArgs args)
        {
            if (args.Value.StartsWith("STD"))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                if(DropDownList1.SelectedIndex == 0 || TextBox2.Text == "")
                {
                    Label6.Text = "Please fill all the fields";
                }
                else
                {
                    Session["ID"] = TextBox1.Text;
                    Session["Name"] = TextBox2.Text;
                    Session["Password"] = TextBox4.Text;
                    Session["Course"] = DropDownList1.SelectedItem.Text;

                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}