
namespace LeasedTicketSearchScreen
{
    partial class frmSearchLeasedTicket
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
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.txtOtherItems = new System.Windows.Forms.TextBox();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFindTickets = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
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
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serial Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Person:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Other Items:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 67);
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
            // txtSerialNumber
            // 
            this.txtSerialNumber.BackColor = System.Drawing.Color.White;
            this.txtSerialNumber.Location = new System.Drawing.Point(146, 67);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(204, 31);
            this.txtSerialNumber.TabIndex = 6;
            // 
            // txtPerson
            // 
            this.txtPerson.BackColor = System.Drawing.Color.White;
            this.txtPerson.Location = new System.Drawing.Point(146, 113);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(204, 31);
            this.txtPerson.TabIndex = 7;
            // 
            // txtOtherItems
            // 
            this.txtOtherItems.BackColor = System.Drawing.Color.White;
            this.txtOtherItems.Location = new System.Drawing.Point(472, 26);
            this.txtOtherItems.Name = "txtOtherItems";
            this.txtOtherItems.Size = new System.Drawing.Size(193, 31);
            this.txtOtherItems.TabIndex = 8;
            // 
            // txtKeywords
            // 
            this.txtKeywords.BackColor = System.Drawing.Color.White;
            this.txtKeywords.Location = new System.Drawing.Point(472, 67);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(193, 31);
            this.txtKeywords.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(647, 325);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnFindTickets
            // 
            this.btnFindTickets.Location = new System.Drawing.Point(403, 110);
            this.btnFindTickets.Name = "btnFindTickets";
            this.btnFindTickets.Size = new System.Drawing.Size(226, 34);
            this.btnFindTickets.TabIndex = 11;
            this.btnFindTickets.Text = "Find Ticket(s)";
            this.btnFindTickets.UseVisualStyleBackColor = true;
            // 
            // frmSearchLeasedTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 502);
            this.Controls.Add(this.btnFindTickets);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtKeywords);
            this.Controls.Add(this.txtOtherItems);
            this.Controls.Add(this.txtPerson);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.txtDeviceTag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSearchLeasedTicket";
            this.Text = "Leased Ticket Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSearchLeasedTicket_FormClosing);
            this.Load += new System.EventHandler(this.frmSearchLeasedTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.TextBox txtOtherItems;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFindTickets;
    }
}

