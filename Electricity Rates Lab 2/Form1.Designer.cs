namespace Electricity_Rates_Lab_2
{
    partial class frmPowerBill
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
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustType = new System.Windows.Forms.Label();
            this.lblKwhUsed = new System.Windows.Forms.Label();
            this.lblPeakHours = new System.Windows.Forms.Label();
            this.lblOffPeakHours = new System.Windows.Forms.Label();
            this.lblTtlCust = new System.Windows.Forms.Label();
            this.lblRCharges = new System.Windows.Forms.Label();
            this.lblCCharges = new System.Windows.Forms.Label();
            this.lblICharges = new System.Windows.Forms.Label();
            this.lblTtlCharges = new System.Windows.Forms.Label();
            this.cmbCustomerType = new System.Windows.Forms.ComboBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtChargeAmount = new System.Windows.Forms.TextBox();
            this.txtKwh = new System.Windows.Forms.TextBox();
            this.txtPeak = new System.Windows.Forms.TextBox();
            this.txtOffPeak = new System.Windows.Forms.TextBox();
            this.txtTtlCust = new System.Windows.Forms.TextBox();
            this.txtRCharges = new System.Windows.Forms.TextBox();
            this.txtCCharges = new System.Windows.Forms.TextBox();
            this.txtICharges = new System.Windows.Forms.TextBox();
            this.txtTtlCharges = new System.Windows.Forms.TextBox();
            this.gbxSums = new System.Windows.Forms.GroupBox();
            this.gbxPHours = new System.Windows.Forms.GroupBox();
            this.btnAdd2List = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.clmAccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChargeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.gbxSums.SuspendLayout();
            this.gbxPHours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(278, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lucky You Power Bill";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(85, 199);
            this.lblAccountNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(96, 18);
            this.lblAccountNo.TabIndex = 1;
            this.lblAccountNo.Text = "Account No.:";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(62, 260);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(119, 18);
            this.lblCustName.TabIndex = 2;
            this.lblCustName.Text = "Customer Name:";
            // 
            // lblCustType
            // 
            this.lblCustType.AutoSize = true;
            this.lblCustType.Location = new System.Drawing.Point(70, 140);
            this.lblCustType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustType.Name = "lblCustType";
            this.lblCustType.Size = new System.Drawing.Size(114, 18);
            this.lblCustType.TabIndex = 3;
            this.lblCustType.Text = "Customer Type:";
            // 
            // lblKwhUsed
            // 
            this.lblKwhUsed.AutoSize = true;
            this.lblKwhUsed.Location = new System.Drawing.Point(387, 140);
            this.lblKwhUsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKwhUsed.Name = "lblKwhUsed";
            this.lblKwhUsed.Size = new System.Drawing.Size(125, 18);
            this.lblKwhUsed.TabIndex = 5;
            this.lblKwhUsed.Text = "Enter kWh Used:";
            // 
            // lblPeakHours
            // 
            this.lblPeakHours.AutoSize = true;
            this.lblPeakHours.Location = new System.Drawing.Point(25, 26);
            this.lblPeakHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeakHours.Name = "lblPeakHours";
            this.lblPeakHours.Size = new System.Drawing.Size(125, 18);
            this.lblPeakHours.TabIndex = 6;
            this.lblPeakHours.Text = "Peak Hours kWh:";
            // 
            // lblOffPeakHours
            // 
            this.lblOffPeakHours.AutoSize = true;
            this.lblOffPeakHours.Location = new System.Drawing.Point(39, 83);
            this.lblOffPeakHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOffPeakHours.Name = "lblOffPeakHours";
            this.lblOffPeakHours.Size = new System.Drawing.Size(114, 18);
            this.lblOffPeakHours.TabIndex = 7;
            this.lblOffPeakHours.Text = "Off Peak Hours:";
            // 
            // lblTtlCust
            // 
            this.lblTtlCust.AutoSize = true;
            this.lblTtlCust.Location = new System.Drawing.Point(3, 41);
            this.lblTtlCust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTtlCust.Name = "lblTtlCust";
            this.lblTtlCust.Size = new System.Drawing.Size(167, 18);
            this.lblTtlCust.TabIndex = 8;
            this.lblTtlCust.Text = "Total No. of Customers:";
            // 
            // lblRCharges
            // 
            this.lblRCharges.AutoSize = true;
            this.lblRCharges.Location = new System.Drawing.Point(27, 76);
            this.lblRCharges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRCharges.Name = "lblRCharges";
            this.lblRCharges.Size = new System.Drawing.Size(143, 18);
            this.lblRCharges.TabIndex = 9;
            this.lblRCharges.Text = "Residential Charges:";
            // 
            // lblCCharges
            // 
            this.lblCCharges.AutoSize = true;
            this.lblCCharges.Location = new System.Drawing.Point(21, 107);
            this.lblCCharges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCCharges.Name = "lblCCharges";
            this.lblCCharges.Size = new System.Drawing.Size(149, 18);
            this.lblCCharges.TabIndex = 10;
            this.lblCCharges.Text = "Commercial Charges:";
            // 
            // lblICharges
            // 
            this.lblICharges.AutoSize = true;
            this.lblICharges.Location = new System.Drawing.Point(36, 140);
            this.lblICharges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblICharges.Name = "lblICharges";
            this.lblICharges.Size = new System.Drawing.Size(134, 18);
            this.lblICharges.TabIndex = 11;
            this.lblICharges.Text = "Industrial Charges:";
            // 
            // lblTtlCharges
            // 
            this.lblTtlCharges.AutoSize = true;
            this.lblTtlCharges.Location = new System.Drawing.Point(64, 197);
            this.lblTtlCharges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTtlCharges.Name = "lblTtlCharges";
            this.lblTtlCharges.Size = new System.Drawing.Size(106, 18);
            this.lblTtlCharges.TabIndex = 12;
            this.lblTtlCharges.Text = "Total Charges:";
            // 
            // cmbCustomerType
            // 
            this.cmbCustomerType.FormattingEnabled = true;
            this.cmbCustomerType.Items.AddRange(new object[] {
            "Residential",
            "Commerical",
            "Industrial"});
            this.cmbCustomerType.Location = new System.Drawing.Point(188, 132);
            this.cmbCustomerType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCustomerType.Name = "cmbCustomerType";
            this.cmbCustomerType.Size = new System.Drawing.Size(154, 26);
            this.cmbCustomerType.TabIndex = 13;
            this.cmbCustomerType.SelectedIndexChanged += new System.EventHandler(this.CmbCustomerType_SelectedIndexChanged);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(188, 253);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(154, 25);
            this.txtCustomerName.TabIndex = 14;
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPresstxtCustomerName_KeyPress);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(188, 192);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(154, 25);
            this.txtAccountNumber.TabIndex = 15;
            this.txtAccountNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNumber_KeyPress);
            // 
            // txtChargeAmount
            // 
            this.txtChargeAmount.Location = new System.Drawing.Point(188, 311);
            this.txtChargeAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtChargeAmount.Name = "txtChargeAmount";
            this.txtChargeAmount.ReadOnly = true;
            this.txtChargeAmount.Size = new System.Drawing.Size(154, 25);
            this.txtChargeAmount.TabIndex = 16;
            this.txtChargeAmount.Visible = false;
            this.txtChargeAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChargeAmount_KeyPresstxtChargeAmount_KeyPress);
            // 
            // txtKwh
            // 
            this.txtKwh.Location = new System.Drawing.Point(520, 132);
            this.txtKwh.Margin = new System.Windows.Forms.Padding(4);
            this.txtKwh.Name = "txtKwh";
            this.txtKwh.Size = new System.Drawing.Size(246, 25);
            this.txtKwh.TabIndex = 17;
            // 
            // txtPeak
            // 
            this.txtPeak.Location = new System.Drawing.Point(158, 19);
            this.txtPeak.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeak.Name = "txtPeak";
            this.txtPeak.Size = new System.Drawing.Size(127, 25);
            this.txtPeak.TabIndex = 18;
            // 
            // txtOffPeak
            // 
            this.txtOffPeak.Location = new System.Drawing.Point(158, 76);
            this.txtOffPeak.Margin = new System.Windows.Forms.Padding(4);
            this.txtOffPeak.Name = "txtOffPeak";
            this.txtOffPeak.Size = new System.Drawing.Size(127, 25);
            this.txtOffPeak.TabIndex = 19;
            // 
            // txtTtlCust
            // 
            this.txtTtlCust.Location = new System.Drawing.Point(175, 34);
            this.txtTtlCust.Margin = new System.Windows.Forms.Padding(4);
            this.txtTtlCust.Name = "txtTtlCust";
            this.txtTtlCust.Size = new System.Drawing.Size(127, 25);
            this.txtTtlCust.TabIndex = 20;
            // 
            // txtRCharges
            // 
            this.txtRCharges.Location = new System.Drawing.Point(175, 69);
            this.txtRCharges.Margin = new System.Windows.Forms.Padding(4);
            this.txtRCharges.Name = "txtRCharges";
            this.txtRCharges.Size = new System.Drawing.Size(127, 25);
            this.txtRCharges.TabIndex = 21;
            // 
            // txtCCharges
            // 
            this.txtCCharges.Location = new System.Drawing.Point(175, 100);
            this.txtCCharges.Margin = new System.Windows.Forms.Padding(4);
            this.txtCCharges.Name = "txtCCharges";
            this.txtCCharges.Size = new System.Drawing.Size(127, 25);
            this.txtCCharges.TabIndex = 22;
            // 
            // txtICharges
            // 
            this.txtICharges.Location = new System.Drawing.Point(175, 133);
            this.txtICharges.Margin = new System.Windows.Forms.Padding(4);
            this.txtICharges.Name = "txtICharges";
            this.txtICharges.Size = new System.Drawing.Size(127, 25);
            this.txtICharges.TabIndex = 23;
            // 
            // txtTtlCharges
            // 
            this.txtTtlCharges.Location = new System.Drawing.Point(175, 190);
            this.txtTtlCharges.Margin = new System.Windows.Forms.Padding(4);
            this.txtTtlCharges.Name = "txtTtlCharges";
            this.txtTtlCharges.Size = new System.Drawing.Size(127, 25);
            this.txtTtlCharges.TabIndex = 24;
            // 
            // gbxSums
            // 
            this.gbxSums.Controls.Add(this.txtTtlCharges);
            this.gbxSums.Controls.Add(this.txtICharges);
            this.gbxSums.Controls.Add(this.txtCCharges);
            this.gbxSums.Controls.Add(this.txtRCharges);
            this.gbxSums.Controls.Add(this.txtTtlCust);
            this.gbxSums.Controls.Add(this.lblTtlCharges);
            this.gbxSums.Controls.Add(this.lblICharges);
            this.gbxSums.Controls.Add(this.lblCCharges);
            this.gbxSums.Controls.Add(this.lblRCharges);
            this.gbxSums.Controls.Add(this.lblTtlCust);
            this.gbxSums.Location = new System.Drawing.Point(40, 436);
            this.gbxSums.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSums.Name = "gbxSums";
            this.gbxSums.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSums.Size = new System.Drawing.Size(310, 242);
            this.gbxSums.TabIndex = 25;
            this.gbxSums.TabStop = false;
            // 
            // gbxPHours
            // 
            this.gbxPHours.Controls.Add(this.txtOffPeak);
            this.gbxPHours.Controls.Add(this.txtPeak);
            this.gbxPHours.Controls.Add(this.lblOffPeakHours);
            this.gbxPHours.Controls.Add(this.lblPeakHours);
            this.gbxPHours.Location = new System.Drawing.Point(473, 199);
            this.gbxPHours.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPHours.Name = "gbxPHours";
            this.gbxPHours.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPHours.Size = new System.Drawing.Size(293, 128);
            this.gbxPHours.TabIndex = 26;
            this.gbxPHours.TabStop = false;
            // 
            // btnAdd2List
            // 
            this.btnAdd2List.Location = new System.Drawing.Point(335, 363);
            this.btnAdd2List.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd2List.Name = "btnAdd2List";
            this.btnAdd2List.Size = new System.Drawing.Size(145, 28);
            this.btnAdd2List.TabIndex = 27;
            this.btnAdd2List.Text = "Calulate and Add ";
            this.btnAdd2List.UseVisualStyleBackColor = true;
            this.btnAdd2List.Click += new System.EventHandler(this.btnAdd2List_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(620, 700);
            this.Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(96, 28);
            this.Clear.TabIndex = 29;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(733, 700);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 28);
            this.button4.TabIndex = 30;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // clmAccountNo
            // 
            this.clmAccountNo.HeaderText = "Account No.";
            this.clmAccountNo.Name = "clmAccountNo";
            // 
            // clmCustomerName
            // 
            this.clmCustomerName.HeaderText = "Customer Name";
            this.clmCustomerName.Name = "clmCustomerName";
            // 
            // clmCustomerType
            // 
            this.clmCustomerType.HeaderText = "Customer Type";
            this.clmCustomerType.Name = "clmCustomerType";
            // 
            // clmChargeAmount
            // 
            this.clmChargeAmount.HeaderText = "Charge Amount";
            this.clmChargeAmount.Name = "clmChargeAmount";
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAccountNo,
            this.clmCustomerName,
            this.clmCustomerType,
            this.clmChargeAmount});
            this.dgvMain.Location = new System.Drawing.Point(383, 460);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(446, 200);
            this.dgvMain.TabIndex = 31;
            this.dgvMain.Text = "dataGridView1";
            // 
            // frmPowerBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(853, 741);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.btnAdd2List);
            this.Controls.Add(this.gbxPHours);
            this.Controls.Add(this.gbxSums);
            this.Controls.Add(this.txtKwh);
            this.Controls.Add(this.txtChargeAmount);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.cmbCustomerType);
            this.Controls.Add(this.lblKwhUsed);
            this.Controls.Add(this.lblCustType);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblAccountNo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPowerBill";
            this.Text = "Lucky You Power Bill";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPowerBill_FormClosed);
            this.Load += new System.EventHandler(this.frmPowerBill_Load);
            this.gbxSums.ResumeLayout(false);
            this.gbxSums.PerformLayout();
            this.gbxPHours.ResumeLayout(false);
            this.gbxPHours.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustType;
        private System.Windows.Forms.Label lblKwhUsed;
        private System.Windows.Forms.Label lblPeakHours;
        private System.Windows.Forms.Label lblOffPeakHours;
        private System.Windows.Forms.Label lblTtlCust;
        private System.Windows.Forms.Label lblRCharges;
        private System.Windows.Forms.Label lblCCharges;
        private System.Windows.Forms.Label lblICharges;
        private System.Windows.Forms.Label lblTtlCharges;
        private System.Windows.Forms.ComboBox cmbCustomerType;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtChargeAmount;
        private System.Windows.Forms.TextBox txtKwh;
        private System.Windows.Forms.TextBox txtPeak;
        private System.Windows.Forms.TextBox txtOffPeak;
        private System.Windows.Forms.TextBox txtTtlCust;
        private System.Windows.Forms.TextBox txtRCharges;
        private System.Windows.Forms.TextBox txtCCharges;
        private System.Windows.Forms.TextBox txtICharges;
        private System.Windows.Forms.TextBox txtTtlCharges;
        private System.Windows.Forms.GroupBox gbxSums;
        private System.Windows.Forms.GroupBox gbxPHours;
        private System.Windows.Forms.Button btnAdd2List;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChargeAmount;
    }
}

