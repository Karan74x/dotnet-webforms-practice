using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //if Data Table

            //DataTable dt = new DataTable();

            ////Columns
            //dt.Columns.Add("Name");
            //dt.Columns.Add("Department");
            //dt.Columns.Add("Marks");

            ////Rows
            //dt.Rows.Add("Karan", "MCA", 74);
            //dt.Rows.Add("Anas", "MCA", 84);
            //dt.Rows.Add("Saad", "BBA", 91);
            //dt.Rows.Add("Mayank", "BCA", 54);
            //dt.Rows.Add("Manav", "BCA", 54);


            List<Student> students = new List<Student>
            {
                new Student{name = "Karan", department="MCA", marks=74},
                new Student{name="Anas", department="MCA", marks=84},
                new Student{name = "Saad", department="BBA", marks=91},
                new Student{name = "Mayank", department="BCA", marks=99},
                new Student{name = "Manav", department="BCA", marks=98},
            };

            //Display all
            var result = students.ToList();
            
            GridView1.DataSource = result;
            GridView1.DataBind();

            //MCA students
            var resMCA = students.Where(s => s.department == "MCA").ToList();

            GridView2.DataSource = resMCA;
            GridView2.DataBind();

            //BCA
            var resBCA = students.Where(s => s.department == "BCA").ToList();

            GridView3.DataSource = resBCA;
            GridView3.DataBind();



            //Marks greater than 75
            var resMarks = students.Where(s => s.marks > 75).ToList();

            GridView4.DataSource = resMarks;
            GridView4.DataBind();


            //Search Student by name
            var resName = students.Where(s => s.name == "Karan").ToList();
            GridView5.DataSource = resName;
            GridView5.DataBind();


            // Find MCA students whose marks are greater than 75 (use || for OR operator)
            var output = students.Where(s => s.department == "MCA" && s.marks > 70).ToList();

            GridView6.DataSource = output;
            GridView6.DataBind();



            // Sort students by name in ascending order
            var resOrder = students.OrderBy(s => s.name).ToList();

            GridView7.DataSource = resOrder;
            GridView7.DataBind();

            // Sort students by marks in descending order
            var resDesOrder = students.OrderByDescending(s => s.marks).ToList();

            GridView8.DataSource = resDesOrder;
            GridView8.DataBind();



        }

        public class Student
        {
            public string name { get; set; }
            public string department { get; set; }
            public int marks { get; set; }

        }
    }
}