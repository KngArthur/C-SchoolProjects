namespace CPRG200_Lab1_BrandenArthur
{
    partial class frmCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txbUseage = new System.Windows.Forms.TextBox();
            this.grbSelection = new System.Windows.Forms.GroupBox();
            this.rdbIndustrial = new System.Windows.Forms.RadioButton();
            this.rdbCommercial = new System.Windows.Forms.RadioButton();
            this.rdbResidential = new System.Windows.Forms.RadioButton();
            this.grbRegular = new System.Windows.Forms.GroupBox();
            this.grbIndustrial = new System.Windows.Forms.GroupBox();
            this.txbINonPeak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIPeak = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCost = new System.Windows.Forms.TextBox();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbAccountNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCustTotal = new System.Windows.Forms.Label();
            this.lblResCharges = new System.Windows.Forms.Label();
            this.lblComCharges = new System.Windows.Forms.Label();
            this.lblIndCharges = new System.Windows.Forms.Label();
            this.lblTotalCharge = new System.Windows.Forms.Label();
            this.grbSelection.SuspendLayout();
            this.grbRegular.SuspendLayout();
            this.grbIndustrial.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.Location = new System.Drawing.Point(23, 381);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(85, 30);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(22, 605);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 29);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(629, 612);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 29);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txbUseage
            // 
            this.txbUseage.Location = new System.Drawing.Point(0, 23);
            this.txbUseage.Margin = new System.Windows.Forms.Padding(2);
            this.txbUseage.Name = "txbUseage";
            this.txbUseage.Size = new System.Drawing.Size(83, 26);
            this.txbUseage.TabIndex = 4;
            this.txbUseage.TextChanged += new System.EventHandler(this.txbUseage_TextChanged);
            // 
            // grbSelection
            // 
            this.grbSelection.Controls.Add(this.rdbIndustrial);
            this.grbSelection.Controls.Add(this.rdbCommercial);
            this.grbSelection.Controls.Add(this.rdbResidential);
            this.grbSelection.Location = new System.Drawing.Point(23, 149);
            this.grbSelection.Margin = new System.Windows.Forms.Padding(2);
            this.grbSelection.Name = "grbSelection";
            this.grbSelection.Padding = new System.Windows.Forms.Padding(2);
            this.grbSelection.Size = new System.Drawing.Size(218, 113);
            this.grbSelection.TabIndex = 2;
            this.grbSelection.TabStop = false;
            this.grbSelection.Text = "Please Select Type of Use";
            // 
            // rdbIndustrial
            // 
            this.rdbIndustrial.AutoSize = true;
            this.rdbIndustrial.Location = new System.Drawing.Point(5, 80);
            this.rdbIndustrial.Margin = new System.Windows.Forms.Padding(2);
            this.rdbIndustrial.Name = "rdbIndustrial";
            this.rdbIndustrial.Size = new System.Drawing.Size(92, 24);
            this.rdbIndustrial.TabIndex = 2;
            this.rdbIndustrial.TabStop = true;
            this.rdbIndustrial.Text = "Industrial";
            this.rdbIndustrial.UseVisualStyleBackColor = true;
            this.rdbIndustrial.CheckedChanged += new System.EventHandler(this.rdbIndustrial_CheckedChanged);
            // 
            // rdbCommercial
            // 
            this.rdbCommercial.AutoSize = true;
            this.rdbCommercial.Location = new System.Drawing.Point(5, 52);
            this.rdbCommercial.Margin = new System.Windows.Forms.Padding(2);
            this.rdbCommercial.Name = "rdbCommercial";
            this.rdbCommercial.Size = new System.Drawing.Size(110, 24);
            this.rdbCommercial.TabIndex = 1;
            this.rdbCommercial.TabStop = true;
            this.rdbCommercial.Text = "Commercial";
            this.rdbCommercial.UseVisualStyleBackColor = true;
            this.rdbCommercial.CheckedChanged += new System.EventHandler(this.rdbCommercial_CheckedChanged);
            // 
            // rdbResidential
            // 
            this.rdbResidential.AutoSize = true;
            this.rdbResidential.Location = new System.Drawing.Point(5, 23);
            this.rdbResidential.Margin = new System.Windows.Forms.Padding(2);
            this.rdbResidential.Name = "rdbResidential";
            this.rdbResidential.Size = new System.Drawing.Size(106, 24);
            this.rdbResidential.TabIndex = 0;
            this.rdbResidential.TabStop = true;
            this.rdbResidential.Text = "Residential";
            this.rdbResidential.UseVisualStyleBackColor = true;
            this.rdbResidential.CheckedChanged += new System.EventHandler(this.rdbResidential_CheckedChanged);
            // 
            // grbRegular
            // 
            this.grbRegular.Controls.Add(this.txbUseage);
            this.grbRegular.Location = new System.Drawing.Point(23, 268);
            this.grbRegular.Margin = new System.Windows.Forms.Padding(2);
            this.grbRegular.Name = "grbRegular";
            this.grbRegular.Padding = new System.Windows.Forms.Padding(2);
            this.grbRegular.Size = new System.Drawing.Size(218, 108);
            this.grbRegular.TabIndex = 7;
            this.grbRegular.TabStop = false;
            this.grbRegular.Text = "Please Enter the Kwh Used";
            this.grbRegular.Enter += new System.EventHandler(this.grbRegular_Enter);
            // 
            // grbIndustrial
            // 
            this.grbIndustrial.Controls.Add(this.txbINonPeak);
            this.grbIndustrial.Controls.Add(this.label1);
            this.grbIndustrial.Controls.Add(this.txbIPeak);
            this.grbIndustrial.Location = new System.Drawing.Point(23, 268);
            this.grbIndustrial.Margin = new System.Windows.Forms.Padding(2);
            this.grbIndustrial.Name = "grbIndustrial";
            this.grbIndustrial.Padding = new System.Windows.Forms.Padding(2);
            this.grbIndustrial.Size = new System.Drawing.Size(326, 108);
            this.grbIndustrial.TabIndex = 3;
            this.grbIndustrial.TabStop = false;
            this.grbIndustrial.Text = "Please Enter the Peak Time Kwh Used";
            // 
            // txbINonPeak
            // 
            this.txbINonPeak.AcceptsTab = true;
            this.txbINonPeak.Location = new System.Drawing.Point(0, 76);
            this.txbINonPeak.Margin = new System.Windows.Forms.Padding(2);
            this.txbINonPeak.Name = "txbINonPeak";
            this.txbINonPeak.Size = new System.Drawing.Size(83, 26);
            this.txbINonPeak.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Enter the Non-Peak Time Kwh Used";
            // 
            // txbIPeak
            // 
            this.txbIPeak.AcceptsTab = true;
            this.txbIPeak.Location = new System.Drawing.Point(0, 23);
            this.txbIPeak.Margin = new System.Windows.Forms.Padding(2);
            this.txbIPeak.Name = "txbIPeak";
            this.txbIPeak.Size = new System.Drawing.Size(83, 26);
            this.txbIPeak.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 433);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Useage Cost";
            // 
            // txbCost
            // 
            this.txbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCost.Location = new System.Drawing.Point(23, 466);
            this.txbCost.Margin = new System.Windows.Forms.Padding(2);
            this.txbCost.Name = "txbCost";
            this.txbCost.ReadOnly = true;
            this.txbCost.Size = new System.Drawing.Size(151, 44);
            this.txbCost.TabIndex = 10;
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 20;
            this.lstCustomers.Location = new System.Drawing.Point(420, 11);
            this.lstCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(291, 364);
            this.lstCustomers.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 530);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbCustomerName
            // 
            this.txbCustomerName.AcceptsTab = true;
            this.txbCustomerName.Location = new System.Drawing.Point(23, 95);
            this.txbCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txbCustomerName.Name = "txbCustomerName";
            this.txbCustomerName.Size = new System.Drawing.Size(218, 26);
            this.txbCustomerName.TabIndex = 1;
            this.txbCustomerName.TextChanged += new System.EventHandler(this.txbCustomerName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Customer Name";
            // 
            // txbAccountNum
            // 
            this.txbAccountNum.AcceptsTab = true;
            this.txbAccountNum.Location = new System.Drawing.Point(22, 33);
            this.txbAccountNum.Margin = new System.Windows.Forms.Padding(2);
            this.txbAccountNum.Name = "txbAccountNum";
            this.txbAccountNum.Size = new System.Drawing.Size(218, 26);
            this.txbAccountNum.TabIndex = 0;
            this.txbAccountNum.TextChanged += new System.EventHandler(this.txbAccountNum_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Customer Account Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 391);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "No. Of Customers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 391);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total Charges";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 448);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Residential Charges";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 498);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Commercial Charges";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 548);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Industrial Charges";
            // 
            // lblCustTotal
            // 
            this.lblCustTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustTotal.Location = new System.Drawing.Point(418, 413);
            this.lblCustTotal.Name = "lblCustTotal";
            this.lblCustTotal.Size = new System.Drawing.Size(132, 26);
            this.lblCustTotal.TabIndex = 25;
            this.lblCustTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResCharges
            // 
            this.lblResCharges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResCharges.Location = new System.Drawing.Point(420, 472);
            this.lblResCharges.Name = "lblResCharges";
            this.lblResCharges.Size = new System.Drawing.Size(132, 26);
            this.lblResCharges.TabIndex = 26;
            this.lblResCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComCharges
            // 
            this.lblComCharges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComCharges.Location = new System.Drawing.Point(420, 522);
            this.lblComCharges.Name = "lblComCharges";
            this.lblComCharges.Size = new System.Drawing.Size(132, 26);
            this.lblComCharges.TabIndex = 27;
            this.lblComCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndCharges
            // 
            this.lblIndCharges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIndCharges.Location = new System.Drawing.Point(420, 568);
            this.lblIndCharges.Name = "lblIndCharges";
            this.lblIndCharges.Size = new System.Drawing.Size(132, 26);
            this.lblIndCharges.TabIndex = 28;
            this.lblIndCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCharge
            // 
            this.lblTotalCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCharge.Location = new System.Drawing.Point(559, 413);
            this.lblTotalCharge.Name = "lblTotalCharge";
            this.lblTotalCharge.Size = new System.Drawing.Size(132, 26);
            this.lblTotalCharge.TabIndex = 29;
            this.lblTotalCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 645);
            this.Controls.Add(this.lblTotalCharge);
            this.Controls.Add(this.lblIndCharges);
            this.Controls.Add(this.lblComCharges);
            this.Controls.Add(this.lblResCharges);
            this.Controls.Add(this.lblCustTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbAccountNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbCustomerName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.grbIndustrial);
            this.Controls.Add(this.txbCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbRegular);
            this.Controls.Add(this.grbSelection);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCustomers";
            this.grbSelection.ResumeLayout(false);
            this.grbSelection.PerformLayout();
            this.grbRegular.ResumeLayout(false);
            this.grbRegular.PerformLayout();
            this.grbIndustrial.ResumeLayout(false);
            this.grbIndustrial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txbUseage;
        private System.Windows.Forms.GroupBox grbSelection;
        private System.Windows.Forms.RadioButton rdbIndustrial;
        private System.Windows.Forms.RadioButton rdbCommercial;
        private System.Windows.Forms.RadioButton rdbResidential;
        private System.Windows.Forms.GroupBox grbRegular;
        private System.Windows.Forms.GroupBox grbIndustrial;
        private System.Windows.Forms.TextBox txbIPeak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCost;
        private System.Windows.Forms.TextBox txbINonPeak;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbAccountNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCustTotal;
        private System.Windows.Forms.Label lblResCharges;
        private System.Windows.Forms.Label lblComCharges;
        private System.Windows.Forms.Label lblIndCharges;
        private System.Windows.Forms.Label lblTotalCharge;
    }
}

