using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aplication_State
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Application["CollegeName"] = "Vijay Malya College";

            //Create a visitor if it does not exist
            if (Application["Visitors"]==null)
            {
                Application["Visitors"] = 0;
            }

            //Read Current Visitor count
            int visitors = Convert.ToInt32(Application["Visitors"]);

            //Increase visitor count
            visitors++;

            //Store updated visitor count
            Application["Viitors"] = visitors;


            //read college name from application state
            string collegeName = Application["CollegeName"].ToString();

            //Display college name and visitor count
            Label3.Text = "College Name: " + collegeName;
            Label4.Text = "Visitor Count: " +visitors;
        }
    }
}