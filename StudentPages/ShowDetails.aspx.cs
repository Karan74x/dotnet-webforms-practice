using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentPages
{
    public partial class ShowDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null || Session["Course"] == null || Session["Password"] == null || Session["Course"] == null)

            {
                Response.Redirect("Registration.aspx");
            }
            else
            {
                Label1.Text = "<br> Student ID: " + Session["ID"].ToString()+
                    "<br> Student Name: " + Session["Name"].ToString() +
                    "<br> Student Course: " + Session["Course"].ToString();   
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Hobbies.aspx");
        }
    }
}