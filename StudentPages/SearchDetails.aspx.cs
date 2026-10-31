using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentPages
{
    public partial class SearchDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text == "")
            {
                Label2.Text = "Please enter the student ID.";
            }
            else
            {
                if (Session["ID"]==null || Session["Name"] == null || Session["Password"] == null || Session["Course"] == null )
                {
                    Response.Redirect("Registeration.aspx");
                }
                else
                {
                    if(TextBox1.Text == Session["ID"].ToString())
                    {
                        Response.Redirect("ShowDetails.aspx");
                    }
                    else
                    {
                        Label2.Text = "No details found for the entered student ID.";
                    }
                }
            }
        }
    }
}