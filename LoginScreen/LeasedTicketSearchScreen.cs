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

namespace LeasedTicketSearchScreen
{
    public partial class frmSearchLeasedTicket : Form
    {
        public frmSearchLeasedTicket()
        {
            InitializeComponent();
        }

        SqlConnection searchedLeasedTicketConnection;

        // The system is accessing data in this form for information that is read only
        private void frmSearchLeasedTicket_Load(object sender, EventArgs e)
        {
            searchedLeasedTicketConnection = new SqlConnection("Data Source=.\\SQLEXPRESS; AttachDbFilename=" + Application.StartupPath + "InventoryManagementDB.mdf; Integrated Security=True; Connect Timeout=30; User Instance=True");
            searchedLeasedTicketConnection.Open();
        }

        private void frmSearchLeasedTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            searchedLeasedTicketConnection.Close();
            searchedLeasedTicketConnection.Dispose();
        }

        // This button will utilize the CommandString function to produce a list of Tickets that are leased and other criteria
        private void btnFindTickets_Click(object sender, EventArgs e)
        {
            SqlCommand searchedLeasedTicketCommand = null;
            SqlDataAdapter searchedLeasedTicketAdapter = new SqlDataAdapter();
            DataTable searchedLeasedTicketTable = new DataTable();

            try
            {
                // establishing command object and data adapter
                searchedLeasedTicketCommand = new SqlCommand(CommandString(), searchedLeasedTicketConnection);
                searchedLeasedTicketAdapter.SelectCommand = searchedLeasedTicketCommand;
                searchedLeasedTicketAdapter.Fill(searchedLeasedTicketTable);

                // Bind the Grid View to the data table
                grdResults.DataSource = searchedLeasedTicketTable;
                lblTickets.Text = searchedLeasedTicketTable.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Getting Tickets", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            searchedLeasedTicketCommand.Dispose();
            searchedLeasedTicketAdapter.Dispose();
            searchedLeasedTicketTable.Dispose();
        }

        private void txtDateCreated_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        private void txtTicketsFor_KeyPress(object sender, KeyPressEventArgs e)
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

        // This is when I have my screen back from Leased Ticket Screen
        private string CommandString()
        {
            string commandStringText = "SELECT * FROM Tickets WHERE CategoryShort = 'LEAS'";

            if (txtDeviceTag.Text.Length > 0)
            {
                commandStringText += " AND DeviceTag = '" + txtDeviceTag.Text.ToString() + "'";
            }

            if (txtDateCreated.Text.Length > 0)
            {
                commandStringText += " AND DateCreated = '" + txtDateCreated.Text.ToString() + "'";
            }

            if (txtTicketsFor.Text.Length > 0)
            {
                commandStringText += " AND ForWho = '" + txtTicketsFor.Text.ToString() + "'";
            }

            if (txtOtherItems.Text.Length > 0)
            {
                commandStringText += " AND OtherItems LIKE '%" + txtOtherItems.Text.ToString() + "%'";
            }

            if (txtKeywords.Text.Length > 0)
            {
                commandStringText += " AND Description LIKE '%" + txtKeywords.Text.ToString() + "&'";
            }

            return commandStringText;
        }
    }
}

/* TimeLine frmSearchLeasedTicket
 * 1/10/2022 - Established GUI
 *             Made the Form Load and Closing Events
 *             Finished the GUI
 * 1/11/2022 - Adding Button Functionality
 *             Altering Interface
 *             DONE
 */
