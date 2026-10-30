using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookie1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["Name"] != null)
                {
                    TextBox1.Text = Request.Cookies["Name"].Value;
                    CheckBox1.Checked = true;
                    Label4.Text = "Cookie Saved";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            if(TextBox1.Text == "" || TextBox2.Text == "")
            {
                Label4.Text = "Fill all the details";
            }
            else
            {
                if(CheckBox1.Checked)
                {
                    Response.Cookies["Name"].Value = name;
                    Response.Cookies["Name"].Expires = DateTime.Now.AddDays(30);
                    Label4.Text = "Login Successfull & Cookie Saved";
                }
                else
                {
                    Response.Cookies["Name"].Expires = DateTime.Now.AddDays(-1);
                    Label4.Text = "Login Successfull";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            CheckBox1.Checked = false;
            Response.Cookies["Name"].Expires = DateTime.Now.AddDays(-1);
            Label4.Text = "Successfully Logged Out";
        }

       

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Welcome.aspx");
        }
    }
}