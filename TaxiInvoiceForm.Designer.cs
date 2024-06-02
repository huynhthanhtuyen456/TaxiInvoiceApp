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
            ListViewTaxiPrice = new ListView();
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
            TxbTotalKM.TextChanged += TxbTotalKM_TextChanged;
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
            BtnCalculate.Location = new Point(103, 75);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(121, 23);
            BtnCalculate.TabIndex = 3;
            BtnCalculate.Text = "Calculate";
            BtnCalculate.UseVisualStyleBackColor = true;
            BtnCalculate.Click += BtnCalculate_Click;
            // 
            // ListViewTaxiInvoice
            // 
            ListViewTaxiInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListViewTaxiInvoice.Location = new Point(12, 242);
            ListViewTaxiInvoice.Name = "ListViewTaxiInvoice";
            ListViewTaxiInvoice.Size = new Size(606, 105);
            ListViewTaxiInvoice.TabIndex = 4;
            ListViewTaxiInvoice.UseCompatibleStateImageBehavior = false;
            ListViewTaxiInvoice.View = View.Details;
            // 
            // ComboBoxCompany
            // 
            ComboBoxCompany.DropDownStyle = ComboBoxStyle.DropDownList;
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
            LblWaitingTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LblWaitingTime.AutoSize = true;
            LblWaitingTime.Location = new Point(240, 9);
            LblWaitingTime.Name = "LblWaitingTime";
            LblWaitingTime.Size = new Size(80, 15);
            LblWaitingTime.TabIndex = 7;
            LblWaitingTime.Text = "Waiting Time:";
            // 
            // LblWaitingTimer
            // 
            LblWaitingTimer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LblWaitingTimer.AutoSize = true;
            LblWaitingTimer.Location = new Point(326, 9);
            LblWaitingTimer.Name = "LblWaitingTimer";
            LblWaitingTimer.Size = new Size(49, 15);
            LblWaitingTimer.TabIndex = 9;
            LblWaitingTimer.Text = "00:00:00";
            // 
            // BtnStartTimer
            // 
            BtnStartTimer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnStartTimer.BackColor = SystemColors.Window;
            BtnStartTimer.ForeColor = SystemColors.WindowText;
            BtnStartTimer.Location = new Point(240, 33);
            BtnStartTimer.Name = "BtnStartTimer";
            BtnStartTimer.Size = new Size(75, 23);
            BtnStartTimer.TabIndex = 10;
            BtnStartTimer.Text = "Start";
            BtnStartTimer.UseVisualStyleBackColor = false;
            BtnStartTimer.Click += BtnStartTimer_Click;
            // 
            // BtnStopTimer
            // 
            BtnStopTimer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnStopTimer.Location = new Point(321, 33);
            BtnStopTimer.Name = "BtnStopTimer";
            BtnStopTimer.Size = new Size(75, 23);
            BtnStopTimer.TabIndex = 11;
            BtnStopTimer.Text = "Stop";
            BtnStopTimer.UseVisualStyleBackColor = true;
            BtnStopTimer.Click += BtnStopTimer_Click;
            // 
            // BtnResetTimer
            // 
            BtnResetTimer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnResetTimer.Location = new Point(402, 33);
            BtnResetTimer.Name = "BtnResetTimer";
            BtnResetTimer.Size = new Size(75, 23);
            BtnResetTimer.TabIndex = 12;
            BtnResetTimer.Text = "Reset";
            BtnResetTimer.UseVisualStyleBackColor = true;
            BtnResetTimer.Click += BtnResetTimer_Click;
            // 
            // ListViewTaxiPrice
            // 
            ListViewTaxiPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ListViewTaxiPrice.Location = new Point(12, 104);
            ListViewTaxiPrice.Name = "ListViewTaxiPrice";
            ListViewTaxiPrice.Size = new Size(606, 118);
            ListViewTaxiPrice.TabIndex = 14;
            ListViewTaxiPrice.UseCompatibleStateImageBehavior = false;
            ListViewTaxiPrice.View = View.Details;
            // 
            // TaxiInvoiceApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 359);
            Controls.Add(ListViewTaxiPrice);
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
            MinimumSize = new Size(646, 398);
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
        private ListView ListViewTaxiPrice;
    }
}
