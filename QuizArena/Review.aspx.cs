using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizArena
{
    public partial class Review : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Personal Details: "
                + "<br />Name: " + Session["Name"].ToString()
                + "<br />Email: " + Session["Email"].ToString()
                + "<br />Category: " + Session["Category"].ToString();
            
            Label2.Text = "Quiz Result: "
                + "<br />Score: " + Session["Score"].ToString()
                + "<br />Percentage: " + Session["Percentage"].ToString() + "%"
                + "<br />Result: " + Session["Result"].ToString();
        }
    }
}