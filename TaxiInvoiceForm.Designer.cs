namespace TaxiInvoiceApp
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
            LblTotalKM = new Label();
            TxbTotalKM = new TextBox();
            LblTotalKMMsgErr = new Label();
            BtnCalculate = new Button();
            ListViewTaxiInvoice = new ListView();
            ComboBoxCompany = new ComboBox();
            LblTaxiCompany = new Label();
            LblWaitingTime = new Label();
            LblWaitingTimer = new Label();
            BtnStartTimer = new Button();
            BtnStopTimer = new Button();
            BtnResetTimer = new Button();
            SuspendLayout();
            // 
            // LblTotalKM
            // 
            LblTotalKM.AutoSize = true;
            LblTotalKM.Location = new Point(12, 20);
            LblTotalKM.Name = "LblTotalKM";
            LblTotalKM.Size = new Size(56, 15);
            LblTotalKM.TabIndex = 0;
            LblTotalKM.Text = "Total KM:";
            // 
            // TxbTotalKM
            // 
            TxbTotalKM.Location = new Point(103, 12);
            TxbTotalKM.Name = "TxbTotalKM";
            TxbTotalKM.Size = new Size(121, 23);
            TxbTotalKM.TabIndex = 1;
            TxbTotalKM.TextChanged += txbTotalKM_TextChanged;
            // 
            // LblTotalKMMsgErr
            // 
            LblTotalKMMsgErr.AutoSize = true;
            LblTotalKMMsgErr.Location = new Point(230, 15);
            LblTotalKMMsgErr.Name = "LblTotalKMMsgErr";
            LblTotalKMMsgErr.Size = new Size(0, 15);
            LblTotalKMMsgErr.TabIndex = 2;
            // 
            // BtnCalculate
            // 
            BtnCalculate.Location = new Point(103, 70);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(121, 23);
            BtnCalculate.TabIndex = 3;
            BtnCalculate.Text = "Calculate";
            BtnCalculate.UseVisualStyleBackColor = true;
            BtnCalculate.Click += BtnCalculate_Click;
            // 
            // ListViewTaxiInvoice
            // 
            ListViewTaxiInvoice.Location = new Point(12, 99);
            ListViewTaxiInvoice.Name = "ListViewTaxiInvoice";
            ListViewTaxiInvoice.Size = new Size(776, 192);
            ListViewTaxiInvoice.TabIndex = 4;
            ListViewTaxiInvoice.UseCompatibleStateImageBehavior = false;
            ListViewTaxiInvoice.View = View.Details;
            // 
            // ComboBoxCompany
            // 
            ComboBoxCompany.FormattingEnabled = true;
            ComboBoxCompany.Location = new Point(103, 41);
            ComboBoxCompany.Name = "ComboBoxCompany";
            ComboBoxCompany.Size = new Size(121, 23);
            ComboBoxCompany.TabIndex = 5;
            // 
            // LblTaxiCompany
            // 
            LblTaxiCompany.AutoSize = true;
            LblTaxiCompany.Location = new Point(12, 49);
            LblTaxiCompany.Name = "LblTaxiCompany";
            LblTaxiCompany.Size = new Size(85, 15);
            LblTaxiCompany.TabIndex = 6;
            LblTaxiCompany.Text = "Taxi Company:";
            // 
            // LblWaitingTime
            // 
            LblWaitingTime.AutoSize = true;
            LblWaitingTime.Location = new Point(410, 9);
            LblWaitingTime.Name = "LblWaitingTime";
            LblWaitingTime.Size = new Size(80, 15);
            LblWaitingTime.TabIndex = 7;
            LblWaitingTime.Text = "Waiting Time:";
            // 
            // LblWaitingTimer
            // 
            LblWaitingTimer.AutoSize = true;
            LblWaitingTimer.Location = new Point(496, 9);
            LblWaitingTimer.Name = "LblWaitingTimer";
            LblWaitingTimer.Size = new Size(49, 15);
            LblWaitingTimer.TabIndex = 9;
            LblWaitingTimer.Text = "00:00:00";
            // 
            // BtnStartTimer
            // 
            BtnStartTimer.BackColor = SystemColors.Window;
            BtnStartTimer.ForeColor = SystemColors.WindowText;
            BtnStartTimer.Location = new Point(410, 33);
            BtnStartTimer.Name = "BtnStartTimer";
            BtnStartTimer.Size = new Size(75, 23);
            BtnStartTimer.TabIndex = 10;
            BtnStartTimer.Text = "Start";
            BtnStartTimer.UseVisualStyleBackColor = false;
            BtnStartTimer.Click += BtnStartTimer_Click;
            // 
            // BtnStopTimer
            // 
            BtnStopTimer.Location = new Point(491, 33);
            BtnStopTimer.Name = "BtnStopTimer";
            BtnStopTimer.Size = new Size(75, 23);
            BtnStopTimer.TabIndex = 11;
            BtnStopTimer.Text = "Stop";
            BtnStopTimer.UseVisualStyleBackColor = true;
            BtnStopTimer.Click += BtnStopTimer_Click;
            // 
            // BtnResetTimer
            // 
            BtnResetTimer.Location = new Point(572, 33);
            BtnResetTimer.Name = "BtnResetTimer";
            BtnResetTimer.Size = new Size(75, 23);
            BtnResetTimer.TabIndex = 12;
            BtnResetTimer.Text = "Reset";
            BtnResetTimer.UseVisualStyleBackColor = true;
            BtnResetTimer.Click += BtnResetTimer_Click;
            // 
            // TaxiInvoiceApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 308);
            Controls.Add(BtnResetTimer);
            Controls.Add(BtnStopTimer);
            Controls.Add(BtnStartTimer);
            Controls.Add(LblWaitingTimer);
            Controls.Add(LblWaitingTime);
            Controls.Add(LblTaxiCompany);
            Controls.Add(ComboBoxCompany);
            Controls.Add(ListViewTaxiInvoice);
            Controls.Add(BtnCalculate);
            Controls.Add(LblTotalKMMsgErr);
            Controls.Add(TxbTotalKM);
            Controls.Add(LblTotalKM);
            Name = "TaxiInvoiceApp";
            Text = "TaxiInvoiceApp";
            Load += TaxiInvoiceApp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTotalKM;
        private TextBox TxbTotalKM;
        private Label LblTotalKMMsgErr;
        private Button BtnCalculate;
        private ListView ListViewTaxiInvoice;
        private ComboBox ComboBoxCompany;
        private Label LblTaxiCompany;
        private Label LblWaitingTime;
        private Label LblWaitingTimer;
        private Button BtnStartTimer;
        private Button BtnStopTimer;
        private Button BtnResetTimer;
    }
}
