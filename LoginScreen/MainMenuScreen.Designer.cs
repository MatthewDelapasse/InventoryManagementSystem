
namespace MainMenuScreen
{
    partial class frmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewLeaseTickets = new System.Windows.Forms.Button();
            this.btnSearchLeaseTicket = new System.Windows.Forms.Button();
            this.btnViewMaintenanceTicket = new System.Windows.Forms.Button();
            this.btnSearchMaintenanceTicket = new System.Windows.Forms.Button();
            this.btnViewInventory = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(263, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tasks";
            // 
            // btnViewLeaseTickets
            // 
            this.btnViewLeaseTickets.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewLeaseTickets.Location = new System.Drawing.Point(92, 141);
            this.btnViewLeaseTickets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewLeaseTickets.Name = "btnViewLeaseTickets";
            this.btnViewLeaseTickets.Size = new System.Drawing.Size(216, 85);
            this.btnViewLeaseTickets.TabIndex = 2;
            this.btnViewLeaseTickets.Text = "View Lease Tickets";
            this.btnViewLeaseTickets.UseVisualStyleBackColor = true;
            this.btnViewLeaseTickets.Click += new System.EventHandler(this.btnViewLeaseTickets_Click);
            // 
            // btnSearchLeaseTicket
            // 
            this.btnSearchLeaseTicket.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchLeaseTicket.Location = new System.Drawing.Point(92, 236);
            this.btnSearchLeaseTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchLeaseTicket.Name = "btnSearchLeaseTicket";
            this.btnSearchLeaseTicket.Size = new System.Drawing.Size(216, 83);
            this.btnSearchLeaseTicket.TabIndex = 3;
            this.btnSearchLeaseTicket.Text = "Search For Lease Tickets";
            this.btnSearchLeaseTicket.UseVisualStyleBackColor = true;
            this.btnSearchLeaseTicket.Click += new System.EventHandler(this.btnSearchLeaseTicket_Click);
            // 
            // btnViewMaintenanceTicket
            // 
            this.btnViewMaintenanceTicket.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewMaintenanceTicket.Location = new System.Drawing.Point(316, 144);
            this.btnViewMaintenanceTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewMaintenanceTicket.Name = "btnViewMaintenanceTicket";
            this.btnViewMaintenanceTicket.Size = new System.Drawing.Size(216, 82);
            this.btnViewMaintenanceTicket.TabIndex = 5;
            this.btnViewMaintenanceTicket.Text = "View Maintenance Tickets";
            this.btnViewMaintenanceTicket.UseVisualStyleBackColor = true;
            this.btnViewMaintenanceTicket.Click += new System.EventHandler(this.btnViewMaintenanceTicket_Click);
            // 
            // btnSearchMaintenanceTicket
            // 
            this.btnSearchMaintenanceTicket.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchMaintenanceTicket.Location = new System.Drawing.Point(316, 238);
            this.btnSearchMaintenanceTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchMaintenanceTicket.Name = "btnSearchMaintenanceTicket";
            this.btnSearchMaintenanceTicket.Size = new System.Drawing.Size(216, 82);
            this.btnSearchMaintenanceTicket.TabIndex = 6;
            this.btnSearchMaintenanceTicket.Text = "Search For Maintenance Ticket";
            this.btnSearchMaintenanceTicket.UseVisualStyleBackColor = true;
            this.btnSearchMaintenanceTicket.Click += new System.EventHandler(this.btnSearchMaintenanceTicket_Click);
            // 
            // btnViewInventory
            // 
            this.btnViewInventory.AccessibleName = "";
            this.btnViewInventory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewInventory.Location = new System.Drawing.Point(123, 344);
            this.btnViewInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewInventory.Name = "btnViewInventory";
            this.btnViewInventory.Size = new System.Drawing.Size(184, 72);
            this.btnViewInventory.TabIndex = 7;
            this.btnViewInventory.Text = "View Inventory";
            this.btnViewInventory.UseVisualStyleBackColor = true;
            this.btnViewInventory.Click += new System.EventHandler(this.btnViewInventory_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.AccessibleName = "";
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewUser.Location = new System.Drawing.Point(316, 344);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(184, 72);
            this.btnAddNewUser.TabIndex = 8;
            this.btnAddNewUser.Text = "Add A New User";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 488);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.btnViewInventory);
            this.Controls.Add(this.btnSearchMaintenanceTicket);
            this.Controls.Add(this.btnViewMaintenanceTicket);
            this.Controls.Add(this.btnSearchLeaseTicket);
            this.Controls.Add(this.btnViewLeaseTickets);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matt\'s Inventory Management Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewLeaseTickets;
        private System.Windows.Forms.Button btnSearchLeaseTicket;
        private System.Windows.Forms.Button btnViewMaintenanceTicket;
        private System.Windows.Forms.Button btnSearchMaintenanceTicket;
        private System.Windows.Forms.Button btnViewInventory;
        private System.Windows.Forms.Button btnAddNewUser;
    }
}

