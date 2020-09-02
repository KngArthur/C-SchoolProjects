namespace CPRG200_Lab1_BrandenArthur
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbIPeak = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCost = new System.Windows.Forms.TextBox();
            this.txbINonPeak = new System.Windows.Forms.TextBox();
            this.grbSelection.SuspendLayout();
            this.grbRegular.SuspendLayout();
            this.grbIndustrial.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 290);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 35);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 442);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 546);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txbUseage
            // 
            this.txbUseage.Location = new System.Drawing.Point(0, 28);
            this.txbUseage.Name = "txbUseage";
            this.txbUseage.Size = new System.Drawing.Size(100, 29);
            this.txbUseage.TabIndex = 4;
            this.txbUseage.TextChanged += new System.EventHandler(this.txbUseage_TextChanged);
            // 
            // grbSelection
            // 
            this.grbSelection.Controls.Add(this.rdbIndustrial);
            this.grbSelection.Controls.Add(this.rdbCommercial);
            this.grbSelection.Controls.Add(this.rdbResidential);
            this.grbSelection.Location = new System.Drawing.Point(12, 12);
            this.grbSelection.Name = "grbSelection";
            this.grbSelection.Size = new System.Drawing.Size(266, 136);
            this.grbSelection.TabIndex = 0;
            this.grbSelection.TabStop = false;
            this.grbSelection.Text = "Please Select Type of Use";
            // 
            // rdbIndustrial
            // 
            this.rdbIndustrial.AutoSize = true;
            this.rdbIndustrial.Location = new System.Drawing.Point(6, 96);
            this.rdbIndustrial.Name = "rdbIndustrial";
            this.rdbIndustrial.Size = new System.Drawing.Size(102, 28);
            this.rdbIndustrial.TabIndex = 2;
            this.rdbIndustrial.TabStop = true;
            this.rdbIndustrial.Text = "Industrial";
            this.rdbIndustrial.UseVisualStyleBackColor = true;
            this.rdbIndustrial.CheckedChanged += new System.EventHandler(this.rdbIndustrial_CheckedChanged);
            // 
            // rdbCommercial
            // 
            this.rdbCommercial.AutoSize = true;
            this.rdbCommercial.Location = new System.Drawing.Point(6, 62);
            this.rdbCommercial.Name = "rdbCommercial";
            this.rdbCommercial.Size = new System.Drawing.Size(129, 28);
            this.rdbCommercial.TabIndex = 1;
            this.rdbCommercial.TabStop = true;
            this.rdbCommercial.Text = "Commercial";
            this.rdbCommercial.UseVisualStyleBackColor = true;
            this.rdbCommercial.CheckedChanged += new System.EventHandler(this.rdbCommercial_CheckedChanged);
            // 
            // rdbResidential
            // 
            this.rdbResidential.AutoSize = true;
            this.rdbResidential.Location = new System.Drawing.Point(6, 28);
            this.rdbResidential.Name = "rdbResidential";
            this.rdbResidential.Size = new System.Drawing.Size(120, 28);
            this.rdbResidential.TabIndex = 0;
            this.rdbResidential.TabStop = true;
            this.rdbResidential.Text = "Residential";
            this.rdbResidential.UseVisualStyleBackColor = true;
            this.rdbResidential.CheckedChanged += new System.EventHandler(this.rdbResidential_CheckedChanged);
            // 
            // grbRegular
            // 
            this.grbRegular.Controls.Add(this.txbUseage);
            this.grbRegular.Location = new System.Drawing.Point(12, 154);
            this.grbRegular.Name = "grbRegular";
            this.grbRegular.Size = new System.Drawing.Size(266, 130);
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
            this.grbIndustrial.Location = new System.Drawing.Point(12, 154);
            this.grbIndustrial.Name = "grbIndustrial";
            this.grbIndustrial.Size = new System.Drawing.Size(399, 130);
            this.grbIndustrial.TabIndex = 1;
            this.grbIndustrial.TabStop = false;
            this.grbIndustrial.Text = "Please Enter the Peak Time Kwh Used";
            this.grbIndustrial.Enter += new System.EventHandler(this.grbIndustrial_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Enter the Non-Peak Time Kwh Used";
            // 
            // txbIPeak
            // 
            this.txbIPeak.Location = new System.Drawing.Point(0, 28);
            this.txbIPeak.Name = "txbIPeak";
            this.txbIPeak.Size = new System.Drawing.Size(100, 29);
            this.txbIPeak.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Useage Cost";
            // 
            // txbCost
            // 
            this.txbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCost.Location = new System.Drawing.Point(12, 392);
            this.txbCost.Name = "txbCost";
            this.txbCost.ReadOnly = true;
            this.txbCost.Size = new System.Drawing.Size(184, 44);
            this.txbCost.TabIndex = 10;
            // 
            // txbINonPeak
            // 
            this.txbINonPeak.Location = new System.Drawing.Point(0, 91);
            this.txbINonPeak.Name = "txbINonPeak";
            this.txbINonPeak.Size = new System.Drawing.Size(100, 29);
            this.txbINonPeak.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 593);
            this.Controls.Add(this.grbIndustrial);
            this.Controls.Add(this.txbCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbRegular);
            this.Controls.Add(this.grbSelection);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Energy Cost";
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
    }
}

