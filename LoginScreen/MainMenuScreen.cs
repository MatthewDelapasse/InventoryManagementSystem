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
using InventoryScreen;

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
                this.btnAddNewUser.Visible = false;
            }
            else
            {
                InitializeComponent();
                this.btnAddNewUser.Visible = false;
            }
        }


        // this button points users to a screen that will allow them to add lease tickets to the system
        private void btnAddLeaseTicket_Click(object sender, EventArgs e)
        {
            /*
             * This button will shoot the user
             * over to the Add A Lease Ticket Screen
             */
        }

        // this button points them to a screen that will allow the them to view lease tickets in the system
        private void btnViewLeaseTickets_Click(object sender, EventArgs e)
        {
            /*
             * This button will shoot the user
             * over to the View Lease Tickets Screen
             */
        }

        // this button points them to a screen that will allow the them to search for lease tickets in the system
        private void btnSearchLeaseTicket_Click(object sender, EventArgs e)
        {
            /*
             * This button will shoot the user
             * over to the Search for Lease Tickets Screen
             */
        }

        // this button points them to a screen that will allow the them to add maintenance tickets to the system
        private void btnAddMaintenanceTicket_Click(object sender, EventArgs e)
        {
            /*
             * This button will shoot the user
             * over to the Add A Maintenance Ticket Screen
             */
        }

        // this button points them to a screen that will allow the them to view maintenance tickets in the system
        private void btnViewMaintenanceTicket_Click(object sender, EventArgs e)
        {
            /*
             * This button will shoot the user
             * over to the View Maintenance Tickets Screen
             */
        }

        // this button points them to a screen that will allow the them to search for maintenance tickets in the system
        private void btnSearchMaintenanceTicket_Click(object sender, EventArgs e)
        {
            /*
             * This button will shoot the user
             * over to the Search for Maintenance Tickets Screen
             */
        }

        // this button points managers to a screen that will allow them to see a full list of devices in the system
        public void btnViewInventory_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.Show();
        }

        // this button points managers to a screen that will allow them to add a new user to the system
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            /*
             * This button will shoot the Manager
             * over to the Add A New User Screen
             */
        }
    }
}

/* MainMenuScreen Timeline
 * 12/2/2021 - Created the GUI
 *             Added the button Click events
 * 12/6/2021 - Manipulated the public frmMainMenu class to deal with permissions appropriately
 *             Added the BtnAddNewUser_Click Event
 * 12/8/2021 - Making the Add New User Button invisible right to everyone because that will be a feature later down the line
 */