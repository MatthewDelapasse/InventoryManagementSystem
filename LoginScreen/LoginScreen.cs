using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MainMenuScreen;

namespace LoginScreen
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection loginConnection;
        SqlCommand loginCommand;

        // Processes happening upon form load
        private void frmLogin_Load(object sender, EventArgs e)
        {
            loginConnection = new SqlConnection("Data Source=.\\SQLEXPRESS; AttachDbFilename=" + Application.StartupPath + "InventoryManagementDB.mdf; Integrated Security=True; Connect Timeout=30; User Instance=True");

            //This tests to see what th startup path is and if it hits the net5.0 - windows folder.
            //MessageBox.Show(Application.StartupPath);


            loginConnection.Open();
        }

        // Whenever the User is logging in to the system
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            string getUser;
            string getUserPermissions;

            /* Testing to make that when the user is clicking the button the system is getting the Username and password
            MessageBox.Show("Username: " + txtUsername.Text + "\nPassword: " + txtPassword.Text);
            */

            getUser = "SELECT Firstname, LastName FROM Employees WHERE Username='" + txtUsername.Text + "' AND Password='" + txtPassword.Text + "';";
            loginCommand = new SqlCommand(getUser, loginConnection);

            // Data validation for the system
            try
            {
                // Checking the fields to make sure none of them are blank other wise the system searches for user.
                // If User is not found then it will display a message telling the user that either the password or the Username is incorrect
                if (txtUsername.Text == string.Empty)
                {
                    MessageBox.Show("I need a Username in order to continue.");
                }
                else if (txtPassword.Text == string.Empty)
                {
                    MessageBox.Show("I need a Password in order to continue.");
                }
                else
                {
                    using (SqlDataReader userReader = loginCommand.ExecuteReader())
                    {
                        if (userReader.Read())
                        {
                            //Message.Box("User was found");
                            userReader.Close();
                            getUserPermissions = "SELECT IsAdmin FROM Employees WHERE Username ='" + txtUsername.Text + "' AND Password ='" + txtPassword.Text + "';";
                            bool isUserAdmin = CheckUserPermissions(getUserPermissions, loginConnection);

                            txtUsername.Clear();
                            txtPassword.Clear();

                            Employees user = new Employees(txtUsername.Text, txtPassword.Text, isUserAdmin);

                            // Here is the new way we check to see if the user is an Admin.
                            frmMainMenu menu = new frmMainMenu(isUserAdmin);
                            menu.Show();


                            // This was the old way of checking if user is admin back on 12/1/2021
                            //// Now the system has figured out if the user is an Admin, it can make its adjustments for the rest of the system
                            //if (user.isAdmin == true)
                            //{
                            //    MessageBox.Show("User is an Admin and will have admin access");
                            //    txtUsername.Controls.Clear();
                            //    txtPassword.Controls.Clear();

                            //    frmMainMenu adminMainMenu = new frmMainMenu(isUserAdmin);

                            //    adminMainMenu.Show();
                            //}
                            //else
                            //{
                            //    MessageBox.Show("User is not an Admin and will be limited on his ablities.");
                            //    txtUsername.Controls.Clear();
                            //    txtPassword.Controls.Clear();

                            //    frmMainMenu nonAdminMainMenu = new frmMainMenu(isUserAdmin);

                            //    nonAdminMainMenu.Show();
                            //}
                        }
                        else
                        {
                            MessageBox.Show("Username/Password is inccorect!", "Incorrect Username/Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Logging into the system.\n" + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // This method checks if the user has admin rights
        public bool CheckUserPermissions(string strcommand, SqlConnection strconnection)
        {
            using (SqlCommand loginAdminCommand = new SqlCommand(strcommand, strconnection))
            {
                bool a = (bool)loginAdminCommand.ExecuteScalar();

                if (a == true)
                {
                    //MessageBox.Show("User is an Admin."); //Testing Purposes
                    return true;
                }
                else
                {
                    //MessageBox.Show("User is not an Admin."); //Testing Purposes
                    return false;
                }
            }
        }
    }
}

/* Login Screen Timeline
   12/1/2021 -  Created the GUI
                Created the Employees table (Login Screen will use data from the Employees table)
                Created the Employees Class
                Developed Main Functionality
   12/2/2021 -  Instaniated the Employees Class
                Placing comments on where I will manipulate the next form openning
   12/6/2021 -  Getting the Login form to show the Main Menu form
                Setting the appropriate permissions so that the Main Menu forms look different based on the user
                Creating Data Validation for the process that checks the database for user
                Completed the login setup 
*/
