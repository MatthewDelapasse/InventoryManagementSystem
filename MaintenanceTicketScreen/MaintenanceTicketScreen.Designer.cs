
namespace MaintenanceTicketScreen
{
    partial class frmMainTicket
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
            this.label6 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(118, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maintenance Tickets";
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
            this.label3.Location = new System.Drawing.Point(55, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Created:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ticket For:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description:";
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.BackColor = System.Drawing.Color.White;
            this.txtDateCreated.Location = new System.Drawing.Point(188, 142);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.Size = new System.Drawing.Size(121, 31);
            this.txtDateCreated.TabIndex = 8;
            // 
            // txtTicketFor
            // 
            this.txtTicketFor.BackColor = System.Drawing.Color.White;
            this.txtTicketFor.Location = new System.Drawing.Point(188, 196);
            this.txtTicketFor.Name = "txtTicketFor";
            this.txtTicketFor.Size = new System.Drawing.Size(197, 31);
            this.txtTicketFor.TabIndex = 9;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(188, 252);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(315, 89);
            this.txtDescription.TabIndex = 10;
            // 
            // chkClosed
            // 
            this.chkClosed.AutoSize = true;
            this.chkClosed.Location = new System.Drawing.Point(82, 356);
            this.chkClosed.Name = "chkClosed";
            this.chkClosed.Size = new System.Drawing.Size(142, 29);
            this.chkClosed.TabIndex = 11;
            this.chkClosed.Text = "Ticket Closed";
            this.chkClosed.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(95, 408);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(63, 34);
            this.btnFirst.TabIndex = 12;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(174, 408);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(63, 34);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(246, 408);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(63, 34);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(332, 408);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(63, 34);
            this.btnLast.TabIndex = 15;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(246, 494);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnEditTicket
            // 
            this.btnEditTicket.Location = new System.Drawing.Point(118, 454);
            this.btnEditTicket.Name = "btnEditTicket";
            this.btnEditTicket.Size = new System.Drawing.Size(119, 34);
            this.btnEditTicket.TabIndex = 18;
            this.btnEditTicket.Text = "Edit Ticket";
            this.btnEditTicket.UseVisualStyleBackColor = true;
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Location = new System.Drawing.Point(246, 454);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(124, 34);
            this.btnAddTicket.TabIndex = 19;
            this.btnAddTicket.Text = "Add a Ticket";
            this.btnAddTicket.UseVisualStyleBackColor = true;
            // 
            // txtDeviceTag
            // 
            this.txtDeviceTag.BackColor = System.Drawing.Color.White;
            this.txtDeviceTag.Location = new System.Drawing.Point(188, 91);
            this.txtDeviceTag.Name = "txtDeviceTag";
            this.txtDeviceTag.Size = new System.Drawing.Size(121, 31);
            this.txtDeviceTag.TabIndex = 20;
            // 
            // frmMainTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 559);
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMainTicket";
            this.Text = "Maintenance Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
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
    }
}

