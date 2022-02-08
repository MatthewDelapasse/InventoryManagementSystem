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

namespace MaintenanceTicketScreen
{
    public partial class frmMainTicket : Form
    {
        public frmMainTicket()
        {
            InitializeComponent();
        }

        SqlConnection mainTicketConnection;
        SqlCommand mainTicketCommand;
        SqlDataAdapter mainTicketAdapter;
        DataTable mainTicketTable;
        DataView mainTicketView;
        CurrencyManager mainTicketManager;

        string state;
        int b;

        // ------------------------------------------- Form Event Code ---------------------------------------
        // Making the connection to the Database
        private void frmMainTicket_Load(object sender, EventArgs e)
        {
            mainTicketConnection = new SqlConnection("Data Source=.\\SQLEXPRESS; AttachDbFilename=" + Application.StartupPath + "InventoryManagementDB.mdf; Integrated Security=True; Connect Timeout=30; User Instance=True");
            mainTicketConnection.Open();

            // Establishing the command object for the form
            mainTicketCommand = new SqlCommand("SELECT * FROM Tickets WHERE CategoryShort = 'MAIN';", mainTicketConnection);

            // Establishing the data adapter/data table
            mainTicketAdapter = new SqlDataAdapter();
            mainTicketAdapter.SelectCommand = mainTicketCommand;
            mainTicketTable = new DataTable();
            mainTicketAdapter.Fill(mainTicketTable);
            mainTicketView = new DataView(mainTicketTable);

            // Binding the Controls
            txtDeviceTag.DataBindings.Add("Text", mainTicketTable, "DeviceTag");
            txtDateCreated.DataBindings.Add("Text", mainTicketTable, "DateCreated");
            txtCreatedBy.DataBindings.Add("Text", mainTicketTable, "EmployeeName");
            txtTicketFor.DataBindings.Add("Text", mainTicketTable, "ForWho");
            txtDescription.DataBindings.Add("Text", mainTicketTable, "Description");
            lblCategoryShort.DataBindings.Add("Text", mainTicketTable, "CategoryShort");
            chkClosed.DataBindings.Add("Checked", mainTicketTable, "isClosed", true);

            // Establish Currency Manager
            mainTicketManager = (CurrencyManager)this.BindingContext[mainTicketTable];

            // This tells me if the connection succeeds
            // MessageBox.Show("The connection has succeeded", "Connection success");

            // Setting the application to view mode
            StateSet("View");
        }

        private void frmMainTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //saving changes to the Database
                SqlCommandBuilder leaseTicketAdapterCommands = new SqlCommandBuilder(mainTicketAdapter);
                mainTicketAdapter.Update(mainTicketTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving ticket: \r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Closing the connection
            mainTicketConnection.Close();

            // Disposing the objects
            mainTicketCommand.Dispose();
            mainTicketAdapter.Dispose();
            mainTicketTable.Dispose();
        }
        // ----------------------------------------End of Form Event Code ---------------------------------------
        // ------------------------------------------- Buton Code ---------------------------------------
        private void btnFirst_Click(object sender, EventArgs e)
        {
            mainTicketManager.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            mainTicketManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            mainTicketManager.Position++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            mainTicketManager.Position = mainTicketManager.Count - 1;
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            // This tells me the click event is tied to the form
            // MessageBox.Show("You have clicked the Add New Device button");

            // System tries to switch from View to Add
            try
            {
                b = mainTicketManager.Position;
                StateSet("Add");
                mainTicketManager.AddNew();
                lblCategoryShort.Text = "MAIN";
            }
            catch (Exception)
            {
                MessageBox.Show("Error switching to Add mode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditTicket_Click(object sender, EventArgs e)
        {
            // Testing the click event to make sure it is tied to the form
            //MessageBox.Show("Form now entering Edit Mode");

            StateSet("Edit");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // This tells me the click event is tied to the form
            // MessageBox.Show("You have clicked the Save button.");

            mainTicketManager.EndCurrentEdit();

            // If data is missing from any of the text boxes then it will return back to the form what is missing
            if (!ValidateData())
            {
                return;
            }
            else
            {
                // This will tell me that all the information is givien
                MessageBox.Show("Ticket Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StateSet("View");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // I am doing this as a test to see if the button is working
            //MessageBox.Show("I am canceling my changes.");

            // Cancels the edit in progress
            mainTicketManager.CancelCurrentEdit();

            // System checks to see if the System was in Add mode and if it is the system goes back to the bookmark
            if (state.Equals("Add"))
            {
                mainTicketManager.Position = b;
            }

            // System switches back to View Mode
            StateSet("View");
        }
        // ---------------------------------------End of Buton Code ---------------------------------------


        // --------------------------------------- TextBox Code ---------------------------------------
        private void txtDateCreated_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }
        private void txtCreatedBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        private void txtTicketFor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        // ---------------------------------------End of TextBox Code ---------------------------------------


        // ------------------------------------------- Methods ---------------------------------------
        private void StateSet(string Stateapp)
        {
            state = Stateapp;
            switch (Stateapp)
            {
                case "View":
                    btnFirst.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                    btnEditTicket.Enabled = true;
                    btnAddTicket.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    txtDeviceTag.BackColor = Color.Blue;
                    txtDeviceTag.ForeColor = Color.White;
                    txtDeviceTag.ReadOnly = true;
                    txtDateCreated.ReadOnly = true;
                    txtCreatedBy.ReadOnly = true;
                    txtTicketFor.ReadOnly = true;
                    txtDescription.ReadOnly = true;
                    chkClosed.Enabled = false;
                    break;
                default:
                    btnFirst.Enabled = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                    btnEditTicket.Enabled = false;
                    btnAddTicket.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    txtDeviceTag.BackColor = Color.Red;
                    txtDeviceTag.ForeColor = Color.White;
                    txtDeviceTag.ReadOnly = false;
                    txtDateCreated.ReadOnly = false;
                    txtCreatedBy.ReadOnly = false;
                    txtTicketFor.ReadOnly = false;
                    txtDescription.ReadOnly = false;
                    chkClosed.Enabled = true;
                    break;
            }
            txtDeviceTag.Focus();
        }

        private bool ValidateData()
        {
            string message = "";
            bool good = true;

            if (txtDeviceTag.Text.Trim().Equals(""))
            {
                message += "Ticket needs A Device Tag.\n";
                txtDeviceTag.Focus();
                good = false;
            }

            bool deviceActive = isDeviceActive(mainTicketConnection);
            if (deviceActive == false)
            {
                message += "This Device cannot be used because it is not active in the system.\n";
                txtDeviceTag.Focus();
                good = false;
            }

            if (txtDateCreated.Text.ToString().Equals(""))
            {
                message += "Ticket needs the date it was created.\n";
                txtDateCreated.Focus();
                good = false;
            }

            if (txtCreatedBy.Text.ToString().Equals(""))
            {
                message += "System needs whom made this ticket.\n";
                txtCreatedBy.Focus();
                good = false;
            }

            if (txtTicketFor.Text.ToString().Equals(""))
            {
                message += "Ticket needs the user whom this is being leased out to.\n";
                txtDateCreated.Focus();
                good = false;
            }

            if (!good)
            {
                MessageBox.Show(message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (good);
        }

        private bool isDeviceActive(SqlConnection stringConnection)
        {
            string commandString = "SELECT isActive FROM Inventory WHERE DeviceTag = '" + txtDeviceTag.Text + "';";
            SqlCommand activeCommand = null;
            SqlDataAdapter activeAdapter = new SqlDataAdapter();
            DataTable serialNumberTable = new DataTable();

            using (activeCommand = new SqlCommand(commandString, mainTicketConnection))
            {
                SqlDataReader activeReader = activeCommand.ExecuteReader();

                if (activeReader.Read() && activeReader.GetBoolean("isActive") == true)
                {
                    //MessageBox.Show("This device is active");
                    activeReader.Close();
                    return true;
                }
                else
                {
                    //MessageBox.Show("This device is not active");
                    activeReader.Close();
                    return false;
                }
            }

        }
    }
    // ---------------------------------------- End of Method ---------------------------------------
}
