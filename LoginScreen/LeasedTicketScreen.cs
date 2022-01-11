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
            txtTicketFor.DataBindings.Add("Text", leasedTicketTable, "ForWho");
            txtDescription.DataBindings.Add("Text", leasedTicketTable, "Description");
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
                try
                {
                    // This will tell me that all the information is givien
                    MessageBox.Show("Device Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StateSet("View");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error saving Device.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                    txtDeviceTag.AllowDrop = false;
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
                    txtDeviceTag.AllowDrop = true;
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
                message = "Ticket needs A Device Tag.";
                txtDeviceTag.Focus();
                good = false;
            }

            if (txtDateCreated.Text.ToString().Equals(""))
            {
                message = "Ticket needs the date it was created.";
                txtDateCreated.Focus();
                good = false;
            }

            if (txtTicketFor.Text.ToString().Equals(""))
            {
                message = "Ticket needs the user whom this is being leased out to.";
                txtDateCreated.Focus();
                good = false;
            }

            if (!good)
            {
                MessageBox.Show(message, "No text fields should be left empty.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (good);
        }
    }
    // ---------------------------------------- End of Method ---------------------------------------
}
