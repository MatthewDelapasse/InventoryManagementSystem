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

            /* This tests to see what th startup path is and if it hits the net5.0-windows folder.
            MessageBox.Show(Application.StartupPath);
            MessageBox.Show("The Startup path hits the database in net5.0-windows folder");
            */

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

            // Checking the fields to make sure none of them are blank other wise the system searches for user
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

                        // Now the system has figured out if the user is an Admin, it can make its adjustments for the rest of the system
                        if (isUserAdmin == true)
                        {
                            MessageBox.Show("User is an Admin and will have admin access");
                        }
                        else
                        {
                            MessageBox.Show("User is not an Admin and will be limited on his ablities.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username/Password is inccorect!", "Incorrect Username/Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

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
*/
