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
        CurrencyManager inventoryManager;

        string state;
        int b;

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

            // Binding the Controls
            txtDeviceTag.DataBindings.Add("Text", inventoryTable, "DeviceTag");
            txtDeviceName.DataBindings.Add("Text", inventoryTable, "DeviceName");
            txtSerialNumber.DataBindings.Add("Text", inventoryTable, "SerialNumber");
            txtDescription.DataBindings.Add("Text", inventoryTable, "Description");
            chkLeasedOut.DataBindings.Add("Checked", inventoryTable, "isLeasedOut");
            chkActive.DataBindings.Add("Checked", inventoryTable, "isActive");

            // Establish Currency Manager
            inventoryManager = (CurrencyManager)this.BindingContext[inventoryTable];

            // Database Connection Succeeds
            //MessageBox.Show("The connection has succeeded", "Connection success");

            // Setting the application to view mode
            StateSet("View");
        }

        private void frmInventory_FormClosing(object sender, FormClosingEventArgs e)
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
            StateSet("Add");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (state.Equals("Add"))
            {
                b = inventoryManager.Position;
                inventoryManager.AddNew();
            }
            else
            {
                MessageBox.Show("This means I am saving changes made when I clicked the edit button");
            }

            //inventoryManager.EndCurrentEdit();
            StateSet("View");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // I am doing this as a test to see if the button is working
            MessageBox.Show("I am canceling my changes.");

            inventoryManager.CancelCurrentEdit();
            StateSet("View");
        }

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
                default:
                    btnFirst.Enabled = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
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
    }
}

/* Timeline for Inventory Screen
 * 12/8/21 - Created on the GUI
 *           Added the Database Connection
 *           Added the Form Load and the Form Closing events
 *           Added the Add a New Device button with functionality
 *           Added the Save and Cancel button with functionality
 *           Added the First, Previous, Next, and Last button with functionality
 */
