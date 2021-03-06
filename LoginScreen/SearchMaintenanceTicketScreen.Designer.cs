
namespace SearchMaintenanceTicket
{
    partial class frmSearchMainTicket
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeviceTag = new System.Windows.Forms.TextBox();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.txtTicketsFor = new System.Windows.Forms.TextBox();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.grdResults = new System.Windows.Forms.DataGridView();
            this.btnFindTickets = new System.Windows.Forms.Button();
            this.lblTickets = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device Tag:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Created:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tickets For:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Created By:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Keywords:";
            // 
            // txtDeviceTag
            // 
            this.txtDeviceTag.BackColor = System.Drawing.Color.White;
            this.txtDeviceTag.Location = new System.Drawing.Point(146, 23);
            this.txtDeviceTag.Name = "txtDeviceTag";
            this.txtDeviceTag.Size = new System.Drawing.Size(204, 31);
            this.txtDeviceTag.TabIndex = 5;
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.BackColor = System.Drawing.Color.White;
            this.txtDateCreated.Location = new System.Drawing.Point(146, 67);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.PlaceholderText = "00/00/0000";
            this.txtDateCreated.Size = new System.Drawing.Size(204, 31);
            this.txtDateCreated.TabIndex = 6;
            this.txtDateCreated.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDateCreated_KeyPress);
            // 
            // txtTicketsFor
            // 
            this.txtTicketsFor.BackColor = System.Drawing.Color.White;
            this.txtTicketsFor.Location = new System.Drawing.Point(146, 113);
            this.txtTicketsFor.Name = "txtTicketsFor";
            this.txtTicketsFor.Size = new System.Drawing.Size(204, 31);
            this.txtTicketsFor.TabIndex = 7;
            this.txtTicketsFor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTicketsFor_KeyPress);
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.Color.White;
            this.txtCreatedBy.Location = new System.Drawing.Point(472, 20);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(193, 31);
            this.txtCreatedBy.TabIndex = 8;
            this.txtCreatedBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreatedBy_KeyPress);
            // 
            // txtKeywords
            // 
            this.txtKeywords.BackColor = System.Drawing.Color.White;
            this.txtKeywords.Location = new System.Drawing.Point(373, 101);
            this.txtKeywords.Multiline = true;
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(292, 49);
            this.txtKeywords.TabIndex = 9;
            // 
            // grdResults
            // 
            this.grdResults.AllowUserToAddRows = false;
            this.grdResults.AllowUserToDeleteRows = false;
            this.grdResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResults.Location = new System.Drawing.Point(18, 214);
            this.grdResults.Name = "grdResults";
            this.grdResults.ReadOnly = true;
            this.grdResults.RowHeadersWidth = 62;
            this.grdResults.RowTemplate.Height = 33;
            this.grdResults.Size = new System.Drawing.Size(647, 325);
            this.grdResults.TabIndex = 10;
            // 
            // btnFindTickets
            // 
            this.btnFindTickets.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFindTickets.ForeColor = System.Drawing.Color.White;
            this.btnFindTickets.Location = new System.Drawing.Point(70, 164);
            this.btnFindTickets.Name = "btnFindTickets";
            this.btnFindTickets.Size = new System.Drawing.Size(233, 34);
            this.btnFindTickets.TabIndex = 11;
            this.btnFindTickets.Text = "Find Ticket(s)";
            this.btnFindTickets.UseVisualStyleBackColor = false;
            this.btnFindTickets.Click += new System.EventHandler(this.btnFindTickets_Click);
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.BackColor = System.Drawing.Color.Black;
            this.lblTickets.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTickets.ForeColor = System.Drawing.Color.White;
            this.lblTickets.Location = new System.Drawing.Point(534, 167);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(0, 32);
            this.lblTickets.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tickets Found:";
            // 
            // frmSearchMainTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 567);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.btnFindTickets);
            this.Controls.Add(this.grdResults);
            this.Controls.Add(this.txtKeywords);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.txtTicketsFor);
            this.Controls.Add(this.txtDateCreated);
            this.Controls.Add(this.txtDeviceTag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSearchMainTicket";
            this.Text = "Search Maintenance Tickets";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmsearchMainTicket_FormClosing);
            this.Load += new System.EventHandler(this.frmsearchMainTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeviceTag;
        private System.Windows.Forms.TextBox txtDateCreated;
        private System.Windows.Forms.TextBox txtTicketsFor;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.DataGridView grdResults;
        private System.Windows.Forms.Button btnFindTickets;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Label label7;
    }
}

