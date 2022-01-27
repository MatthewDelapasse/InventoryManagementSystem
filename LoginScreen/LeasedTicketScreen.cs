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

namespace LeasedTicketScreen
{
    public partial class frmLeasedTicket : Form
    {
        public frmLeasedTicket()
        {
            InitializeComponent();
        }

        SqlConnection leasedTicketConnection;
        SqlCommand leasedTicketCommand;
        SqlDataAdapter leasedTicketAdapter;
        DataTable leasedTicketTable;
        DataView leasedTicketView;
        CurrencyManager leasedTicketManager;

        string state;
        int b;

        // ------------------------------------------- Form Event Code ---------------------------------------
        // Making the connection to the Database
        private void frmLeasedTicket_Load(object sender, EventArgs e)
        {
            leasedTicketConnection = new SqlConnection("Data Source=.\\SQLEXPRESS; AttachDbFilename=" + Application.StartupPath + "InventoryManagementDB.mdf; Integrated Security=True; Connect Timeout=30; User Instance=True");
            leasedTicketConnection.Open();

            // Establishing the command object for the form
            leasedTicketCommand = new SqlCommand("SELECT * FROM Tickets WHERE CategoryShort = 'LEAS';", leasedTicketConnection);

            // Establishing the data adapter/data table
            leasedTicketAdapter = new SqlDataAdapter();
            leasedTicketAdapter.SelectCommand = leasedTicketCommand;
            leasedTicketTable = new DataTable();
            leasedTicketAdapter.Fill(leasedTicketTable);
            leasedTicketView = new DataView(leasedTicketTable);

            // Binding the Controls
            txtDeviceTag.DataBindings.Add("Text", leasedTicketTable, "DeviceTag");
            txtOtherItems.DataBindings.Add("Text", leasedTicketTable, "OtherItems");
            txtDateCreated.DataBindings.Add("Text", leasedTicketTable, "DateCreated");
            txtCreatedBy.DataBindings.Add("Text", leasedTicketTable, "EmployeeName");
            txtTicketFor.DataBindings.Add("Text", leasedTicketTable, "ForWho");
            txtDescription.DataBindings.Add("Text", leasedTicketTable, "Description");
            lblCategoryShort.DataBindings.Add("Text", leasedTicketTable, "CategoryShort");
            chkClosed.DataBindings.Add("Checked", leasedTicketTable, "isClosed", true);

            // Establish Currency Manager
            leasedTicketManager = (CurrencyManager)this.BindingContext[leasedTicketTable];

            // This tells me if the connection succeeds
            // MessageBox.Show("The connection has succeeded", "Connection success");

            // Setting the application to view mode
            StateSet("View");
        }

        private void frmLeasedTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //saving changes to the Database
                SqlCommandBuilder leaseTicketAdapterCommands = new SqlCommandBuilder(leasedTicketAdapter);
                leasedTicketAdapter.Update(leasedTicketTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving ticket: \r\n" + ex.Message, "Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Closing the connection
            leasedTicketConnection.Close();

            // Disposing the objects
            leasedTicketCommand.Dispose();
            leasedTicketAdapter.Dispose();
            leasedTicketTable.Dispose();
        }
        // ----------------------------------------End of Form Event Code ---------------------------------------
        // ------------------------------------------- Buton Code ---------------------------------------
        private void btnFirst_Click(object sender, EventArgs e)
        {
            leasedTicketManager.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            leasedTicketManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            leasedTicketManager.Position++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            leasedTicketManager.Position = leasedTicketManager.Count - 1;
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            // This tells me the click event is tied to the form
            // MessageBox.Show("You have clicked the Add New Device button");

            // System tries to switch from View to Add
            try
            {
                b = leasedTicketManager.Position;
                StateSet("Add");
                leasedTicketManager.AddNew();
                lblCategoryShort.Text = "LEAS";
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

            leasedTicketManager.EndCurrentEdit();
            
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
            leasedTicketManager.CancelCurrentEdit();

            // System checks to see if the System was in Add mode and if it is the system goes back to the bookmark
            if (state.Equals("Add"))
            {
                leasedTicketManager.Position = b;
            }

            // System switches back to View Mode
            StateSet("View");
        }
        // ---------------------------------------End of Buton Code ---------------------------------------
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
                    txtOtherItems.ReadOnly = true;
                    txtDateCreated.ReadOnly = true;
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
                    txtOtherItems.ReadOnly = false;
                    txtDateCreated.ReadOnly = false;
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

            bool deviceActive = isDeviceActive(leasedTicketConnection);
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

            using (activeCommand = new SqlCommand(commandString, leasedTicketConnection))
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
