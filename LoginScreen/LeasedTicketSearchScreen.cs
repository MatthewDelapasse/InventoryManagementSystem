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

        // This is when I have my screen back from Leased Ticket Screen
        private string CommandString(string dt, string sn, string p, string ot, string k)
        {
            string commandStringText = "SELECT * FROM Ticket WHERE CategoryShort = 'LEASED'";





            return commandStringText;
        }
    }
}

/* TimeLine frmSearchLeasedTicket
 * 1/10/2022 - Established GUI
 *             Made the Form Load and Closing Events
 *             Finished the GUI
 */
