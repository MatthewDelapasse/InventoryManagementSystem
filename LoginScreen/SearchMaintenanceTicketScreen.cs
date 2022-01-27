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

namespace SearchMaintenanceTicket
{
    public partial class frmSearchMainTicket : Form
    {
        public frmSearchMainTicket()
        {
            InitializeComponent();
        }

        SqlConnection searchMainTicketConnection;

        // The system is accessing data in this form for information that is read only
        private void frmsearchMainTicket_Load(object sender, EventArgs e)
        {
            searchMainTicketConnection = new SqlConnection("Data Source=.\\SQLEXPRESS; AttachDbFilename=" + Application.StartupPath + "InventoryManagementDB.mdf; Integrated Security=True; Connect Timeout=30; User Instance=True");
            searchMainTicketConnection.Open();
        }

        private void frmsearchMainTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            searchMainTicketConnection.Close();
            searchMainTicketConnection.Dispose();
        }

        // This button will utilize the CommandString function to produce a list of Tickets that are leased and other criteria
        private void btnFindTickets_Click(object sender, EventArgs e)
        {
            SqlCommand searchMainTicketCommand = null;
            SqlDataAdapter searchMainTicketAdapter = new SqlDataAdapter();
            DataTable searchMainTicketTable = new DataTable();

            try
            {
                // establishing command object and data adapter
                searchMainTicketCommand = new SqlCommand(CommandString(), searchMainTicketConnection);
                searchMainTicketAdapter.SelectCommand = searchMainTicketCommand;
                searchMainTicketAdapter.Fill(searchMainTicketTable);

                // Bind the Grid View to the data table
                grdResults.DataSource = searchMainTicketTable;
                lblTickets.Text = searchMainTicketTable.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Getting Tickets", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            searchMainTicketCommand.Dispose();
            searchMainTicketAdapter.Dispose();
            searchMainTicketTable.Dispose();
        }

        // This is when I have my screen back from Leased Ticket Screen
        private string CommandString()
        {
            string commandStringText = "SELECT * FROM Tickets WHERE CategoryShort = 'MAIN'";

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

            if (txtCreatedBy.Text.Length > 0)
            {
                commandStringText += " AND EmployeeName = '" + txtCreatedBy.Text.ToString() + "'";
            }

            if (txtKeywords.Text.Length > 0)
            {
                commandStringText += " AND Description LIKE '%" + txtKeywords.Text.ToString() + "%'";
            }

            return commandStringText;
        }

    }
}
