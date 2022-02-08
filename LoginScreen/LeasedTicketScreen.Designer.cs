
namespace LeasedTicketScreen
{
    partial class frmLeasedTicket
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtOtherItems = new System.Windows.Forms.TextBox();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.txtTicketFor = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkClosed = new System.Windows.Forms.CheckBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditTicket = new System.Windows.Forms.Button();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.txtDeviceTag = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCategoryShort = new System.Windows.Forms.Label();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(148, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lease Tickets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device Tag:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Created:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ticket For:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Other Items:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description:";
            // 
            // txtOtherItems
            // 
            this.txtOtherItems.BackColor = System.Drawing.Color.White;
            this.txtOtherItems.Location = new System.Drawing.Point(188, 142);
            this.txtOtherItems.Name = "txtOtherItems";
            this.txtOtherItems.Size = new System.Drawing.Size(315, 31);
            this.txtOtherItems.TabIndex = 2;
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.BackColor = System.Drawing.Color.White;
            this.txtDateCreated.Location = new System.Drawing.Point(188, 187);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.PlaceholderText = "00/00/0000";
            this.txtDateCreated.Size = new System.Drawing.Size(121, 31);
            this.txtDateCreated.TabIndex = 3;
            this.txtDateCreated.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDateCreated_KeyPress);
            // 
            // txtTicketFor
            // 
            this.txtTicketFor.BackColor = System.Drawing.Color.White;
            this.txtTicketFor.Location = new System.Drawing.Point(188, 277);
            this.txtTicketFor.Name = "txtTicketFor";
            this.txtTicketFor.Size = new System.Drawing.Size(197, 31);
            this.txtTicketFor.TabIndex = 5;
            this.txtTicketFor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTicketFor_KeyPress);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(188, 333);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(315, 89);
            this.txtDescription.TabIndex = 6;
            // 
            // chkClosed
            // 
            this.chkClosed.AutoSize = true;
            this.chkClosed.Location = new System.Drawing.Point(82, 437);
            this.chkClosed.Name = "chkClosed";
            this.chkClosed.Size = new System.Drawing.Size(142, 29);
            this.chkClosed.TabIndex = 11;
            this.chkClosed.Text = "Ticket Closed";
            this.chkClosed.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(95, 489);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(63, 34);
            this.btnFirst.TabIndex = 12;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(174, 489);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(63, 34);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(246, 489);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(63, 34);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(332, 489);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(63, 34);
            this.btnLast.TabIndex = 15;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(125, 573);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(246, 573);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEditTicket
            // 
            this.btnEditTicket.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditTicket.ForeColor = System.Drawing.Color.White;
            this.btnEditTicket.Location = new System.Drawing.Point(118, 535);
            this.btnEditTicket.Name = "btnEditTicket";
            this.btnEditTicket.Size = new System.Drawing.Size(119, 34);
            this.btnEditTicket.TabIndex = 18;
            this.btnEditTicket.Text = "Edit Ticket";
            this.btnEditTicket.UseVisualStyleBackColor = false;
            this.btnEditTicket.Click += new System.EventHandler(this.btnEditTicket_Click);
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddTicket.ForeColor = System.Drawing.Color.White;
            this.btnAddTicket.Location = new System.Drawing.Point(246, 535);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(124, 34);
            this.btnAddTicket.TabIndex = 19;
            this.btnAddTicket.Text = "Add a Ticket";
            this.btnAddTicket.UseVisualStyleBackColor = false;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // txtDeviceTag
            // 
            this.txtDeviceTag.BackColor = System.Drawing.Color.White;
            this.txtDeviceTag.Location = new System.Drawing.Point(188, 91);
            this.txtDeviceTag.Name = "txtDeviceTag";
            this.txtDeviceTag.Size = new System.Drawing.Size(121, 31);
            this.txtDeviceTag.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Created By:";
            // 
            // lblCategoryShort
            // 
            this.lblCategoryShort.AutoSize = true;
            this.lblCategoryShort.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCategoryShort.Location = new System.Drawing.Point(460, 9);
            this.lblCategoryShort.Name = "lblCategoryShort";
            this.lblCategoryShort.Size = new System.Drawing.Size(59, 25);
            this.lblCategoryShort.TabIndex = 22;
            this.lblCategoryShort.Text = "label8";
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.Color.White;
            this.txtCreatedBy.Location = new System.Drawing.Point(188, 230);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(197, 31);
            this.txtCreatedBy.TabIndex = 23;
            this.txtCreatedBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreatedBy_KeyPress);
            // 
            // frmLeasedTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 613);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.lblCategoryShort);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDeviceTag);
            this.Controls.Add(this.btnAddTicket);
            this.Controls.Add(this.btnEditTicket);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.chkClosed);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTicketFor);
            this.Controls.Add(this.txtDateCreated);
            this.Controls.Add(this.txtOtherItems);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLeasedTicket";
            this.Text = "Lease Tickets";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLeasedTicket_FormClosing);
            this.Load += new System.EventHandler(this.frmLeasedTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOtherItems;
        private System.Windows.Forms.TextBox txtDateCreated;
        private System.Windows.Forms.TextBox txtTicketFor;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox chkClosed;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditTicket;
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.TextBox txtDeviceTag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCategoryShort;
        private System.Windows.Forms.TextBox txtCreatedBy;
    }
}

