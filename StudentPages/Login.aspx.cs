using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentPages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text == "" || TextBox2.Text == "")
            {
                Label1.Text = "Please enter both username and password.";
            }
            else
            {

                if (Session["ID"] == null || Session["Password"] == null)
                {
                    Response.Redirect("Registration.aspx");
                }
                else
                {
                    if(TextBox1.Text == Session["ID"].ToString() && TextBox2.Text == Session["Password"].ToString())
                    {
                        Response.Redirect("SearchDetails.aspx");
                    }
                    else
                    {
                        Label3.Text = "Invalid username or password.";
                    }
                }
            
            }

        }
    }
}