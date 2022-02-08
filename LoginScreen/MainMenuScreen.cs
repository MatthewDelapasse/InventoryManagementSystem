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
using LeasedTicketScreen;
using LeasedTicketSearchScreen;
using MaintenanceTicketScreen;
using SearchMaintenanceTicket;

namespace MainMenuScreen
{
    public partial class frmMainMenu : Form
    {
        // this variable is created to help create the parent-child functionality between frmLogin and frmMainMenu
        Form parentForm;

        public frmMainMenu(Form form, bool admin)
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

            // Here we establish the parameter 'form' means that it is making the frmLogin the parent form
            // of the frmMainMenu (making frmMainMenu a child form)
            this.parentForm = form;
        }



        // this button points them to a form that will allow the them to view lease tickets in the system
        private void btnViewLeaseTickets_Click(object sender, EventArgs e)
        {
            frmLeasedTicket leaseTicket = new frmLeasedTicket();
            leaseTicket.Show();
        }

        // this button points them to a form that will allow the them to search for lease tickets in the system
        private void btnSearchLeaseTicket_Click(object sender, EventArgs e)
        {
            frmSearchLeasedTicket searchLeaseTicket = new frmSearchLeasedTicket();
            searchLeaseTicket.Show();
        }


        // this button points them to a form that will allow the them to view maintenance tickets in the system
        private void btnViewMaintenanceTicket_Click(object sender, EventArgs e)
        {
            frmMainTicket mainTicket = new frmMainTicket();
            mainTicket.Show();
        }

        // this button points them to a form that will allow the them to search for maintenance tickets in the system
        private void btnSearchMaintenanceTicket_Click(object sender, EventArgs e)
        {
            frmSearchMainTicket searchMainTicket = new frmSearchMainTicket();
            searchMainTicket.Show();
        }

        // this button points managers to a form that will allow them to see a full list of devices in the system
        public void btnViewInventory_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.Show();
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // First I ask my user if they would like to go back to the login form
            if (MessageBox.Show("Would you like to go back to the Login Screen.\n (If you select 'No' you will exit the program", 
                "Exit Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                /* if User selects 'Yes', then all the forms go through there
                 * closing events and then we make the login form visible again
                 */

                // First we create a reverse array of open forms.
                Form[] forms = Application.OpenForms.Cast<Form>().Reverse<Form>().ToArray();

                /* Second we go through those forms that are not named 'frmMainMenu'.
                 * the reason for this is that we want to close all the other forms
                 * before we close the Main Menu. Once the loop has reached 'frmMainMenu'
                 * we break the loop.
                 */
                foreach (Form f in forms)
                {
                    if (f.Name != "frmMainMenu")
                    {
                        f.Close();
                    }
                    else
                    {
                        break;
                    }
                }

                // Finally we make the Login form visible again
                // and close the Main Menu
                this.parentForm.Visible = true;
            }
            else 
            {
                /* if User selects 'No', then all the forms will go through there
                 * closing event and the Login screen closes (Login Screen is the main form) 
                 */

                //First we create a reverse array of open forms.
                Form[] forms = Application.OpenForms.Cast<Form>().Reverse<Form>().ToArray();

                /* Second we go through those forms that are not named 'frmMainMenu'.
                 * the reason for this is that we want to close all the other forms
                 * before we close the Main Menu. Once the loop has reached 'frmMainMenu'
                 * we break the loop.
                 */
                foreach (Form f in forms)
                {
                    if (f.Name != "frmMainMenu")
                    {
                        f.Close();
                    }
                    else
                    {
                        break;
                    }
                }

                // Finally the Login and Main Menu Form closes, thus exiting out the application.
                parentForm.Close();
            }
        }



        // this button points managers to a form that will allow them to add a new user to the system
        // this functionality is a later feature we will work on after the second sprint

        //private void btnAddNewUser_Click(object sender, EventArgs e)
        //{
        //    /*
        //     * This button will shoot the Manager
        //     * over to the Add A New User form
        //     */
        //}
    }
}

/* MainMenuform Timeline
 * 12/2/2021 - Created the GUI
 *             Added the button Click events
 * 12/6/2021 - Manipulated the public frmMainMenu class to deal with permissions appropriately
 *             Added the BtnAddNewUser_Click Event
 * 12/8/2021 - Making the Add New User Button invisible right to everyone because that will be a feature later down the line
 * 12/9/2021 - Changing the view of the Main Menu
 * 1/11/2021 - Deleted the Add buttons off the Main Menu
 * 1/19/2022 - Added the ViewMaintenanceTicket Button event
 *             Added the SearchMaintenanceTicket Button event
 * 2/8/2022  - Adding functionality to the 'public frmMainMenu()'
 *             Adding functionality to the 'frmMainMenu_FormClosing()'
 */