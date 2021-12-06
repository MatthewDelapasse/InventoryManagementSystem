using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginScreen;

namespace MainMenuScreen
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu(bool admin)
        {
            bool userIsAdmin = admin;

            if (userIsAdmin == false)
            {
                InitializeComponent();
                this.btnViewInventory.Visible = false;
            }
            else
            {
                InitializeComponent();
            }
        }

        private void btnAddLeaseTicket_Click(object sender, EventArgs e)
        {
            /*
             * This button will shoot the user
             * over to the Add A Lease Ticket Screen
             */
        }

        private void btnViewLeaseTickets_Click(object sender, EventArgs e)
        {
            /*
             * This button will shoot the user
             * over to the View Lease Tickets Screen
             */
        }

        private void btnSearchLeaseTicket_Click(object sender, EventArgs e)
        {
            /*
             * This button will shoot the user
             * over to the Search for Lease Tickets Screen
             */
        }

        private void btnAddMaintenanceTicket_Click(object sender, EventArgs e)
        {
            /*
             * This button will shoot the user
             * over to the Add A Maintenance Ticket Screen
             */
        }

        private void btnViewMaintenanceTicket_Click(object sender, EventArgs e)
        {
            /*
             * This button will shoot the user
             * over to the View Maintenance Tickets Screen
             */
        }

        private void btnSearchMaintenanceTicket_Click(object sender, EventArgs e)
        {
            /*
             * This button will shoot the user
             * over to the Search for Maintenance Tickets Screen
             */
        }

        public void btnViewInventory_Click(object sender, EventArgs e)
        {
            /*
             * This button will shoot the user
             * over to the View Inventory Screen
             */
        }
    }
}

/* MainMenuScreen Timeline
 * 12/2/2021 - Created the GUI
 *             Added the button Click events
 *             
 */