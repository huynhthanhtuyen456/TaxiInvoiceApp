﻿namespace TaxiInvoiceApp
{
    partial class TaxiInvoiceApp
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
            lblTotalKM = new Label();
            txbTotalKM = new TextBox();
            lblTotalKMMsgErr = new Label();
            btnCalculate = new Button();
            listViewTaxiInvoice = new ListView();
            comboBoxCompany = new ComboBox();
            lblTaxiCompany = new Label();
            lblWaitingTime = new Label();
            lblWaitingTimer = new Label();
            btnStartTimer = new Button();
            btnStopTimer = new Button();
            btnResetTimer = new Button();
            SuspendLayout();
            // 
            // lblTotalKM
            // 
            lblTotalKM.AutoSize = true;
            lblTotalKM.Location = new Point(12, 20);
            lblTotalKM.Name = "lblTotalKM";
            lblTotalKM.Size = new Size(56, 15);
            lblTotalKM.TabIndex = 0;
            lblTotalKM.Text = "Total KM:";
            // 
            // txbTotalKM
            // 
            txbTotalKM.Location = new Point(103, 12);
            txbTotalKM.Name = "txbTotalKM";
            txbTotalKM.Size = new Size(121, 23);
            txbTotalKM.TabIndex = 1;
            txbTotalKM.TextChanged += txbTotalKM_TextChanged;
            // 
            // lblTotalKMMsgErr
            // 
            lblTotalKMMsgErr.AutoSize = true;
            lblTotalKMMsgErr.Location = new Point(230, 15);
            lblTotalKMMsgErr.Name = "lblTotalKMMsgErr";
            lblTotalKMMsgErr.Size = new Size(0, 15);
            lblTotalKMMsgErr.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(103, 70);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(121, 23);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // listViewTaxiInvoice
            // 
            listViewTaxiInvoice.Location = new Point(12, 99);
            listViewTaxiInvoice.Name = "listViewTaxiInvoice";
            listViewTaxiInvoice.Size = new Size(776, 192);
            listViewTaxiInvoice.TabIndex = 4;
            listViewTaxiInvoice.UseCompatibleStateImageBehavior = false;
            listViewTaxiInvoice.View = View.Details;
            // 
            // comboBoxCompany
            // 
            comboBoxCompany.FormattingEnabled = true;
            comboBoxCompany.Location = new Point(103, 41);
            comboBoxCompany.Name = "comboBoxCompany";
            comboBoxCompany.Size = new Size(121, 23);
            comboBoxCompany.TabIndex = 5;
            // 
            // lblTaxiCompany
            // 
            lblTaxiCompany.AutoSize = true;
            lblTaxiCompany.Location = new Point(12, 49);
            lblTaxiCompany.Name = "lblTaxiCompany";
            lblTaxiCompany.Size = new Size(85, 15);
            lblTaxiCompany.TabIndex = 6;
            lblTaxiCompany.Text = "Taxi Company:";
            // 
            // lblWaitingTime
            // 
            lblWaitingTime.AutoSize = true;
            lblWaitingTime.Location = new Point(410, 9);
            lblWaitingTime.Name = "lblWaitingTime";
            lblWaitingTime.Size = new Size(80, 15);
            lblWaitingTime.TabIndex = 7;
            lblWaitingTime.Text = "Waiting Time:";
            // 
            // lblWaitingTimer
            // 
            lblWaitingTimer.AutoSize = true;
            lblWaitingTimer.Location = new Point(496, 9);
            lblWaitingTimer.Name = "lblWaitingTimer";
            lblWaitingTimer.Size = new Size(49, 15);
            lblWaitingTimer.TabIndex = 9;
            lblWaitingTimer.Text = "00:00:00";
            // 
            // btnStartTimer
            // 
            btnStartTimer.BackColor = SystemColors.Window;
            btnStartTimer.ForeColor = SystemColors.WindowText;
            btnStartTimer.Location = new Point(410, 33);
            btnStartTimer.Name = "btnStartTimer";
            btnStartTimer.Size = new Size(75, 23);
            btnStartTimer.TabIndex = 10;
            btnStartTimer.Text = "Start";
            btnStartTimer.UseVisualStyleBackColor = false;
            btnStartTimer.Click += btnStartTimer_Click;
            // 
            // btnStopTimer
            // 
            btnStopTimer.Location = new Point(491, 33);
            btnStopTimer.Name = "btnStopTimer";
            btnStopTimer.Size = new Size(75, 23);
            btnStopTimer.TabIndex = 11;
            btnStopTimer.Text = "Stop";
            btnStopTimer.UseVisualStyleBackColor = true;
            btnStopTimer.Click += btnStopTimer_Click;
            // 
            // btnResetTimer
            // 
            btnResetTimer.Location = new Point(572, 33);
            btnResetTimer.Name = "btnResetTimer";
            btnResetTimer.Size = new Size(75, 23);
            btnResetTimer.TabIndex = 12;
            btnResetTimer.Text = "Reset";
            btnResetTimer.UseVisualStyleBackColor = true;
            btnResetTimer.Click += btnResetTimer_Click;
            // 
            // TaxiInvoiceApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 308);
            Controls.Add(btnResetTimer);
            Controls.Add(btnStopTimer);
            Controls.Add(btnStartTimer);
            Controls.Add(lblWaitingTimer);
            Controls.Add(lblWaitingTime);
            Controls.Add(lblTaxiCompany);
            Controls.Add(comboBoxCompany);
            Controls.Add(listViewTaxiInvoice);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotalKMMsgErr);
            Controls.Add(txbTotalKM);
            Controls.Add(lblTotalKM);
            Name = "TaxiInvoiceApp";
            Text = "TaxiInvoiceApp";
            Load += TaxiInvoiceApp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalKM;
        private TextBox txbTotalKM;
        private Label lblTotalKMMsgErr;
        private Button btnCalculate;
        private ListView listViewTaxiInvoice;
        private ComboBox comboBoxCompany;
        private Label lblTaxiCompany;
        private Label lblWaitingTime;
        private Label lblWaitingTimer;
        private Button btnStartTimer;
        private Button btnStopTimer;
        private Button btnResetTimer;
    }
}
