using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adatbáziskezelő
{
    
    public partial class Form2 : Form
    {
        public static string connectionString = "Data Source=adatbazis.db;Version=3;";
        public Form2()
        {
            InitializeComponent();
        }
        public static void newdata(string firstName, string lastName, string Address)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO People (firstName, lastName, Address) VALUES (@firstName, @lastName, @Address)";

                using (var insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@firstName", firstName);
                    insertCommand.Parameters.AddWithValue("@lastName", lastName);
                    insertCommand.Parameters.AddWithValue("@Address", Address);
                    insertCommand.ExecuteNonQuery();
                    
                }
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {         
                string lastname = save_firstname.Text;
                string firstname = save_lastname.Text;
                string address = save_address.Text;
            if (firstname=="" || lastname=="" || address=="")
            {
                MessageBox.Show("Nem lehet üres mező!");
            }
            else
            {
                newdata(firstname, lastname, address);
                this.Hide();

            }    
            
        }
    }
}
