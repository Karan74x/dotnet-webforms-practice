using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBaseConnectivity
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Connect to MySQL Server
                // ----------------------------
                string connectionString = "server=localhost; uid=root;port=3306;pwd=;";

                MySqlConnection con = new MySqlConnection(connectionString);

                //Open the connection
                con.Open();


                // 2. Create a database
                // ---------------------

                string createDatabase = "CREATE DATABASE IF NOT EXISTS college_db";

                MySqlCommand cmd = new MySqlCommand(createDatabase, con);

                cmd.ExecuteNonQuery();

                con.Close();


                //3.Connect to College_db database
                // --------------------------------

                string dataBaseConnection = "server=localhost;uid=root;database=college_db;port=3306;pwd=;";

                MySqlConnection con2 = new MySqlConnection(dataBaseConnection);

                //Open the connection
                con2.Open();


                // 4.Create Studenst Table
                // ------------------------

                string createTable = @"CREATE TABLE IF NOT EXISTS students
                                     (
                                        id INT PRIMARY KEY AUTO_INCREMENT,
                                        name VARCHAR(100),
                                        course VARCHAR(50),
                                        marks INT
                                     )";

                MySqlCommand cmd2 = new MySqlCommand(createTable, con2);

                cmd2.ExecuteNonQuery();

                // 5. Insert Student Data
                // ------------------------
                string insertData = @"INSERT INTO students (name, course, marks) 
                                    VALUES 
                                    ('KARAN', 'MCA', 100),
                                    ('ANAS', 'BCA', 98),
                                    ('Saad', 'MCA', 80),
                                    ('Arnold', 'BCA', 30)";

                MySqlCommand cmd3 = new MySqlCommand(insertData, con2);
                cmd3.ExecuteNonQuery();


                // 6. Select Student Data
                // -----------------------
                string showData = "SELECT * FROM students";


                //create Data Adapter
                MySqlDataAdapter da = new MySqlDataAdapter(showData, con2);



                // 7. Store Data in DataTable
                // ---------------------------

                DataTable dt = new DataTable();

                //Fill DataTable with database data
                da.Fill(dt);


                // 8. Display Data in GridView
                // ----------------------------
                GridView1.DataSource = dt;
                GridView1.DataBind();

                Label2.Text = "Database, Table and Student Data Created Successfully";

                // Close database connection
                con2.Close();

            }
            catch (Exception ex)
            {
                Label2.Text = ex.Message;
            }
        }
    }
}