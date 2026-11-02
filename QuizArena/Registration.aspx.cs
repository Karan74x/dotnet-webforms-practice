using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizArena
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text=="" || TextBox2.Text==""||DropDownList1.SelectedIndex==0)
            {
                Label4.Text = "All Fields must be filled";
            }
            else
            {
                Session["Name"] = TextBox1.Text;
                Session["Email"] = TextBox2.Text;
                Session["Category"] = DropDownList1.SelectedItem.Text;

                Response.Redirect("Quiz.aspx");
            }
        }
    }
}