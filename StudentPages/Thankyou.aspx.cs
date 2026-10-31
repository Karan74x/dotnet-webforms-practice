using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentPages
{
    public partial class Thankyou : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null || Session["Name"] == null || Session["Password"] == null || Session["Course"] == null || Session["Hobbies"] == null)
            {
                Response.Redirect("Registration.aspx");
            }
            else
            {
                
                Label1.Text = "<br> Student ID: " + Session["ID"].ToString() +
                     "<br> Name: " + Session["Name"].ToString() +
                     "<br> Course: " + Session["Course"].ToString() +
                     "<br> Hobbies: " + Session["Hobbies"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}