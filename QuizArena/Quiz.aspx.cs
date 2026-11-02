using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizArena
{
    public partial class Quiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string category = Session["category"].ToString();
                Label1.Text = "Welcome" + Session["Name"].ToString();

                if (category == ".NET")
                {
                    Label2.Text = "Which language is commonly used to develop ASP.NET Web Forms applications?";
                    RadioButtonList1.Items.Add("C#");
                    RadioButtonList1.Items.Add("VB.NET");
                    RadioButtonList1.Items.Add("Python");
                    RadioButtonList1.Items.Add("Java");

                    Label3.Text = "Which control is used to display a button in ASP.NET Web Forms?";
                    RadioButtonList2.Items.Add("TextBox");
                    RadioButtonList2.Items.Add("Button");
                    RadioButtonList2.Items.Add("Label");
                    RadioButtonList2.Items.Add("DropDownList");

                    Label5.Text = "Which control is used to display a list of items in ASP.NET Web Forms?";
                    RadioButtonList3.Items.Add("ListBox");
                    RadioButtonList3.Items.Add("DropDownList");
                    RadioButtonList3.Items.Add("CheckBoxList");
                    RadioButtonList3.Items.Add("RadioButtonList");
                }
                if(category == "Machine Learning")
                {
                    Label2.Text = "Which algorithm is commonly used for classification tasks in machine learning?";
                    RadioButtonList1.Items.Add("Linear Regression");
                    RadioButtonList1.Items.Add("Decision Trees");
                    RadioButtonList1.Items.Add("K-Means Clustering");
                    RadioButtonList1.Items.Add("Principal Component Analysis (PCA)");
                   
                    Label3.Text = "Which technique is used to prevent overfitting in machine learning models?";
                    RadioButtonList2.Items.Add("Cross-Validation");
                    RadioButtonList2.Items.Add("Regularization");
                    RadioButtonList2.Items.Add("Feature Scaling");
                    RadioButtonList2.Items.Add("Data Augmentation");

                    Label5.Text = "Which evaluation metric is commonly used for regression tasks in machine learning?";
                    RadioButtonList3.Items.Add("Mean Squared Error (MSE)");
                    RadioButtonList3.Items.Add("Root Mean Squared Error (RMSE)");
                    RadioButtonList3.Items.Add("Mean Absolute Error (MAE)");
                    RadioButtonList3.Items.Add("R-Squared");
                }

                if(category == "Data Science")
                {
                    Label2.Text = "Which programming language is commonly used for data analysis and visualization?";
                    RadioButtonList1.Items.Add("Python");
                    RadioButtonList1.Items.Add("R");
                    RadioButtonList1.Items.Add("Java");
                    RadioButtonList1.Items.Add("C++");

                    Label3.Text = "Which technique is used to handle missing data in a dataset?";
                    RadioButtonList2.Items.Add("Imputation");
                    RadioButtonList2.Items.Add("Normalization");
                    RadioButtonList2.Items.Add("Standardization");
                    RadioButtonList2.Items.Add("Feature Selection");

                    Label5.Text = "Which statistical measure is used to describe the spread of a dataset?";
                    RadioButtonList3.Items.Add("Variance");
                    RadioButtonList3.Items.Add("Standard Deviation");
                    RadioButtonList3.Items.Add("Range");
                    RadioButtonList3.Items.Add("Interquartile Range");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int score = 0;
            float percentage = 0;
            string result = "";

            string category = Session["category"].ToString();

            if(RadioButtonList1.SelectedIndex==-1 || RadioButtonList2.SelectedIndex == -1 || RadioButtonList3.SelectedIndex == -1)
            {
                Label4.Text = "Please answer all questions";
            }
            else
            {
                if (category == ".NET")
                {
                    if (RadioButtonList1.SelectedItem.Text == "C#")
                    {
                        score++;
                    }
                    if (RadioButtonList2.SelectedItem.Text == "Button")
                    {
                        score++;
                    }
                    if (RadioButtonList3.SelectedItem.Text == "DropDownList")
                    {
                        score++;
                    }
                }
                if (category == "Machine Learning")
                {
                    if (RadioButtonList1.SelectedItem.Text == "Decision Trees")
                    {
                        score++;
                    }
                    if (RadioButtonList2.SelectedItem.Text == "Regularization")
                    {
                        score++;
                    }
                    if (RadioButtonList3.SelectedItem.Text == "Mean Squared Error (MSE)")
                    {
                        score++;
                    }
                }
                if (category == "Data Science")
                {
                    if (RadioButtonList1.SelectedItem.Text == "Python")
                    {
                        score++;
                    }
                    if (RadioButtonList2.SelectedItem.Text == "Imputation")
                    {
                        score++;
                    }
                    if (RadioButtonList3.SelectedItem.Text == "Variance")
                    {
                        score++;
                    }
                }
                percentage = score/ 3.0f * 100;
                string passFail = percentage >= 50 ? "Pass" : "Fail";
                result = passFail;

                Session["Score"] = score;
                Session["Percentage"] = percentage;
                Session["Result"] = result;
               

                Response.Redirect("Review.aspx");
            }
        }
    }
}