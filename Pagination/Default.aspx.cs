using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pagination
{
    public partial class _Default : Page
    {
        string connectionString = "server=localhost;pwd=;uid=root;port=3306;database=student_db";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void displayData(MySqlConnection con)
        {
            string query = "SELECT * FROM student";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            string  query = "SELECT * FROM student";
            MySqlConnection con = new MySqlConnection(connectionString);
            displayData(con);
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
            MySqlConnection con = new MySqlConnection(connectionString);
            displayData(con);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            
            string query = @"INSERT INTO student(id, name, age, marks) VALUES(@id, @name, @age,@marks)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", TextBox1.Text);
            cmd.Parameters.AddWithValue("@name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@age", TextBox3.Text);
            cmd.Parameters.AddWithValue("@marks", TextBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Label5.Text = "Data Inserted Successfully";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con2 = new MySqlConnection(connectionString);
            con2.Open();

            string query = @"UPDATE student SET age=@age WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(query, con2);
            cmd.Parameters.AddWithValue("@id", TextBox1.Text);
            cmd.Parameters.AddWithValue("@age", TextBox3.Text);
            cmd.ExecuteNonQuery();
            con2.Close();
            Label5.Text = "Data Updated Successfully";
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con3 = new MySqlConnection(connectionString);
            con3.Open();

            string query = @"DELETE FROM student WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(query, con3);
            cmd.Parameters.AddWithValue("@id",TextBox1.Text);
            cmd.ExecuteNonQuery();
            con3.Close();
            Label5.Text = "Data Deleted Successfully";
        }
    }
}