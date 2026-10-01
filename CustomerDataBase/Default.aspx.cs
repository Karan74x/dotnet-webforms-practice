using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomerDataBase
{
    public partial class _Default : Page
    {
        // Define the connection string to connect to the MySQL database
        string connectionString = "server=localhost;uid=root;port=3306;pwd=;database=customer_db";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //Inserting into customer table
            string insertQuery = @"INSERT INTO customer VALUES (@id, @name, @email, @mobile,@city,@reg_Date)";
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            
            MySqlCommand cmd = new MySqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@id", TextBox1.Text);
            cmd.Parameters.AddWithValue("@name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@email", TextBox3.Text);
            cmd.Parameters.AddWithValue("@mobile", TextBox4.Text);
            cmd.Parameters.AddWithValue("@city", TextBox5.Text);
            cmd.Parameters.AddWithValue("@reg_date", TextBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Label8.Text = "Data inserted successfully";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Displaying the data from customer table
            string showCustomers = "SELECT * FROM customer";
            MySqlConnection con2 = new MySqlConnection(connectionString);
            con2.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(showCustomers, con2);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
            con2.Close();
            Label8.Text = "Data is being displayed below";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Updating the data in customer table
            string updateQuery = @"UPDATE customer SET mobile=@mobile WHERE id=@id";
            MySqlConnection con3 = new MySqlConnection(connectionString);
            con3.Open();

            MySqlCommand cmd3 = new MySqlCommand(updateQuery, con3);
            cmd3.Parameters.AddWithValue("@id", TextBox1.Text);
            cmd3.Parameters.AddWithValue("@mobile", TextBox4.Text);
            cmd3.ExecuteNonQuery();
            con3.Close();
            Label8.Text = "Data updated successfully";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //Deleting the data from customer table
            string deleteQuery = @"DELETE FROM customer WHERE id = @id";
            MySqlConnection con4 = new MySqlConnection(connectionString);
            con4.Open();

            MySqlCommand cmd4 = new MySqlCommand(deleteQuery, con4);
            cmd4.Parameters.AddWithValue("@id", TextBox1.Text);
            cmd4.ExecuteNonQuery();
            con4.Close();
            Label8.Text = "Data deleted successfully";
        }
    }
}