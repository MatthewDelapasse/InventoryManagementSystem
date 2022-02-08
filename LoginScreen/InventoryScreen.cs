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

namespace InventoryScreen
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        SqlConnection inventoryConnection;
        SqlCommand inventoryCommand;
        SqlDataAdapter inventoryAdapter;
        DataTable inventoryTable;
        DataView inventoryView;
        CurrencyManager inventoryManager;

        string state;
        int b;

        // ------------------------------------------- Form Event Code ---------------------------------------
        // Making the connection to the Database
        private void frmInventory_Load(object sender, EventArgs e)
        {
            inventoryConnection = new SqlConnection("Data Source=.\\SQLEXPRESS; AttachDbFilename=" + Application.StartupPath + "InventoryManagementDB.mdf; Integrated Security=True; Connect Timeout=30; User Instance=True");
            inventoryConnection.Open();

            // Establishing the command object for the form
            inventoryCommand = new SqlCommand("SELECT * FROM Inventory", inventoryConnection);

            // Establishing the data adapter/data table
            inventoryAdapter = new SqlDataAdapter();
            inventoryAdapter.SelectCommand = inventoryCommand;
            inventoryTable = new DataTable();
            inventoryAdapter.Fill(inventoryTable);
            inventoryView = new DataView(inventoryTable);

            // Binding the Controls
            txtDeviceTag.DataBindings.Add("Text", inventoryTable, "DeviceTag");
            txtDeviceName.DataBindings.Add("Text", inventoryTable, "DeviceName");
            txtSerialNumber.DataBindings.Add("Text", inventoryTable, "SerialNumber");
            txtDescription.DataBindings.Add("Text", inventoryTable, "Description");
            chkLeasedOut.DataBindings.Add("Checked", inventoryTable, "isLeasedOut", true);
            chkActive.DataBindings.Add("Checked", inventoryTable, "isActive", true);

            // Establish Currency Manager
            inventoryManager = (CurrencyManager)this.BindingContext[inventoryTable];

            // This tells me if the connection succeeds
            // MessageBox.Show("The connection has succeeded", "Connection success");

            // Setting the application to view mode
            StateSet("View");
        }

        private void frmInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            // This checks to make sure that the user finishes his or her changes to the inventory before closing out the window.
            if (state.Equals("Add") || state.Equals("Edit"))
            {
                MessageBox.Show("You must finish what you are doing before we can close out the window.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
            else
            {
                try
                {
                    // Save the updated Inventory table
                    SqlCommandBuilder inventoryAdapterCommand = new SqlCommandBuilder(inventoryAdapter);
                    inventoryAdapter.Update(inventoryTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving the database:\r\n" + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Closing the connection
                inventoryConnection.Close();

                // Disposing the objects
                inventoryCommand.Dispose();
                inventoryAdapter.Dispose();
                inventoryTable.Dispose();
            }
        }
        // ----------------------------------------End of Form Event Code ---------------------------------------

        // ------------------------------------------- Buton Code ---------------------------------------
        private void btnFirst_Click(object sender, EventArgs e)
        {
            inventoryManager.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            inventoryManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            inventoryManager.Position++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            inventoryManager.Position = inventoryManager.Count - 1;
        }

        private void btnAddNewDevice_Click(object sender, EventArgs e)
        {
            // This tells me the click event is tied to the form
            // MessageBox.Show("You have clicked the Add New Device button");

            // System switches from View to Add mode
            // Creates a new form to add a new device
            try
            {
                b = inventoryManager.Position;
                StateSet("Add");
                inventoryManager.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("Error switching to Add mode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // This tells me the click event is tied to the form
            // MessageBox.Show("You have clicked the Save button.");
            if (state == "Edit")
            {
                inventoryManager.EndCurrentEdit();
                MessageBox.Show("Device Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StateSet("View");
            }

            if (state == "Add")
            {
                inventoryManager.EndCurrentEdit();
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // I am doing this as a test to see if the button is working
            //MessageBox.Show("I am canceling my changes.");

            // Cancels the edit in progress
            inventoryManager.CancelCurrentEdit();

            // System checks to see if the System was in Add mode and if it is the system goes back
            // to the bookmark form I was on before I clicked "Add new Device"
            if (state.Equals("Add"))
            {
                inventoryManager.Position = b;
            }

            // System switches back to View Mode
            StateSet("View");
        }

        private void btnEditDevice_Click(object sender, EventArgs e)
        {
            // Testing the click event to make sure it is tied to the form
            //MessageBox.Show("Form now entering Edit Mode");

            // System Switches to Edit mode
            StateSet("Edit");
        }
        // ---------------------------------------End of Buton Code ---------------------------------------

        // ------------------------------------------- Methods ---------------------------------------
        private void StateSet(string Stateapp)
        {
            state = Stateapp;
            switch (Stateapp)
            {
                // This is how the format should be formatted when it is in
                // View mode
                case "View":
                    btnFirst.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                    btnEditDevice.Enabled = true;
                    btnAddNewDevice.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    txtDeviceTag.BackColor = Color.Blue;
                    txtDeviceTag.ForeColor = Color.White;
                    txtDeviceTag.ReadOnly = true;
                    txtDeviceName.ReadOnly = true;
                    txtSerialNumber.ReadOnly = true;
                    txtDescription.ReadOnly = true;
                    chkLeasedOut.Enabled = false;
                    chkActive.Enabled = false;
                    break;
                default: // Edit or Add Mode
                    btnFirst.Enabled = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEditDevice.Enabled = false;
                    btnAddNewDevice.Enabled = false;
                    txtDeviceTag.BackColor = Color.Red;
                    txtDeviceTag.ForeColor = Color.White;
                    txtDeviceTag.ReadOnly = false;
                    txtDeviceName.ReadOnly = false;
                    txtSerialNumber.ReadOnly = false;
                    txtDescription.ReadOnly = false;
                    chkLeasedOut.Enabled = true;
                    chkActive.Enabled = true;
                    break;
            }
            txtDeviceTag.Focus();
        }

        // Validates the information within the form
        // in specific boxes. These pieces of data are important to the database
        // where the other bits of information can be null
        private bool ValidateData()
        {
            string message = "";
            bool good = true;

            if (txtDeviceTag.Text.Trim().Equals(""))
            {
                message += "Device needs a Tag.\n";
                txtDeviceTag.Focus();
                good = false;
            }
            
            if (txtDeviceName.Text.Trim().Equals(""))
            {
                message += "Device needs a Name.\n";
                txtDeviceName.Focus();
                good = false;
            }
            
            if (txtSerialNumber.Text.ToString().Equals(""))
            {
                message += "Device needs a Serial Number\n";
                txtSerialNumber.Focus();
                good = false;
            }

            bool isSerialNumberUsed = CheckSerialNumber(inventoryConnection);
            if (isSerialNumberUsed == true)
            {
                message += "A Device with this Serial Number is already in the system\n";
                txtSerialNumber.Focus();
                good = false;
            }

            if (!good)
            {
                MessageBox.Show(message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (good);
        }

        // Checks the database to make sure the serial numbers are already in there
        private bool CheckSerialNumber(SqlConnection stringConnection)
        {
            string commandString = "SELECT SerialNumber FROM Inventory WHERE SerialNumber = '" + txtSerialNumber.Text + "';";
            SqlCommand serialNumberCommand = null;
            SqlDataAdapter serialNumberAdapter = new SqlDataAdapter();
            DataTable serialNumberTable = new DataTable();

            using (serialNumberCommand = new SqlCommand(commandString, inventoryConnection))
            {
                SqlDataReader serialReader = serialNumberCommand.ExecuteReader();

                if (serialReader.Read())
                {
                    serialReader.Close();
                    return true;
                }
                else
                {
                    serialReader.Close();
                    return false;
                }
            }
        }
        // ---------------------------------------- End of Method ---------------------------------------
    }
}

/* Timeline for Inventory Screen
 * 12/8/21 - Created on the GUI
 *           Added the Database Connection
 *           Added the Form Load and the Form Closing events
 *           Added the Add a New Device button with some functionality
 *           Added the Save and Cancel button with some functionality
 *           Added the First, Previous, Next, and Last button with functionality
 * 12/9/21 - Added the Edit Device Button with functionality
 *           Added some Comments to separate out code functions
 *           Added Validation method for saving data
 *           Created the functionality for the Add New Device, Save, and Cancel button
 *           created the functionality for the Edit a Device Button
 * 12/16/21 - Remade the database to not have single record in the database
 *            Reworking the AddNewButton and Save Buttons
 * 1/26/22  - Working on when Serial Numbers are the same in the system
 * 1/27/22  - Refining my Inventory Screen to correct errors caused in testing
 */
