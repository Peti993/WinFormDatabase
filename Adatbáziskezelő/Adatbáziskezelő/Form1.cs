using System;
using System.Data.SQLite;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Adatbáziskezelő
{
    public partial class Form1 : Form
    {
        public event EventHandler ExitbuttonClicked;
        private void exitButton_Click(object sender, EventArgs e)
        {
            ExitbuttonClicked?.Invoke(this, EventArgs.Empty);
        }
        int counter = 1;
        public static string connectionString = "Data Source=adatbazis.db;Version=3;";
        public static void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS People (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    firstName TEXT,
                    lastName TEXT,
                    Address TEXT
                );";

                using (var createTableCommand = new SQLiteCommand(createTableQuery, connection))
                {
                    createTableCommand.ExecuteNonQuery();
                }
            }
        }
        // Iskolak kiolvasasa
        static List<Persons> getPeople()
        {
            List<Persons> data = new List<Persons>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT People.Id, People.firstName, People.lastName, People.Address FROM People";


                using (var selectCommand = new SQLiteCommand(selectQuery, connection))
                {

                    using (var reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id"]);
                            int id_p = Convert.ToInt32(reader["Id"]);
                            string firstName = reader["firstname"].ToString();
                            string lastname = reader["lastname"].ToString();
                            string address = reader["address"].ToString();


                            data.Add(new Persons(firstName, lastname, address, id));
                        }
                    }
                }
                return data;                
            }
        }
        private void People_id()
        {
            List<Persons> peopleList = getPeople();
            dataGridView1.DataSource = peopleList;
            comboBox1.DataSource = peopleList;
            comboBox1.ValueMember = "id";
        }
        private void ShowName()
        {
            Persons selectedItem = comboBox1.SelectedItem as Persons;
            int selectedId = selectedItem.id;
            Persons Person = getPeople().FirstOrDefault(p => p.id == selectedId); // Az alapértelmezett személy keresése az id alapján
            if (Person != null)
            {
                lastName_text.Text = Person.lastname;
                firstName_text.Text = Person.firstname;
                address_text.Text = Person.address;
            }
            else
            {
                lastName_text.Text =("Nincs ilyen személy ID");
            }
        }
        // UPDATE
        public static void updatePeople(Persons person)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE People SET firstName = @firstname, lastName = @lastname, Address = @address WHERE Id = @id";

                using (var updateCommand = new SQLiteCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@firstname", person.firstname);
                    updateCommand.Parameters.AddWithValue("@lastname", person.lastname);
                    updateCommand.Parameters.AddWithValue("@address", person.address);
                    updateCommand.Parameters.AddWithValue("@id", person.id);
                    updateCommand.ExecuteNonQuery();
                }
            }
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
        public static void DeletePeople(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM People WHERE Id = @Id";

                using (var deleteCommand = new SQLiteCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@Id", id);
                    deleteCommand.ExecuteNonQuery();
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            People_id();
            ShowName();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowName();
        }

        private void newdata_Click(object sender, EventArgs e)
        {
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter % 2 == 0)
            {
                lastName_text.ReadOnly = false;
                firstName_text.ReadOnly = false;
                address_text.ReadOnly = false;
            }
            //counter++;
            else if (counter > 1 & counter % 2 == 1)
            {
                lastName_text.ReadOnly = true;
                firstName_text.ReadOnly = true;
                address_text.ReadOnly = true;
                string lastname = lastName_text.Text;
                string firstname = firstName_text.Text;
                string address = address_text.Text;
                int id = (int)comboBox1.SelectedValue;
                updatePeople(new Persons(lastname, firstname, address, id));
                MessageBox.Show("Sikeresen frissült!");
                InitializeDatabase();
                People_id();
                ShowName();
            }
         
            else
            {
                lastName_text.ReadOnly = true;
                firstName_text.ReadOnly = true;
                address_text.ReadOnly = true;
            }

        }

        private void add_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            InitializeDatabase();
            People_id();
            ShowName();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = (int)comboBox1.SelectedValue;
            DeletePeople(id);
            MessageBox.Show($"Sikeresen törölted ezzel az ID vel rendelkező személyt: {id}");
            InitializeDatabase();
            People_id();
            ShowName();
        }
    }


}