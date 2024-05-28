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
            lblTotalKM = new Label();
            txbTotalKM = new TextBox();
            lblTotalKMMsgErr = new Label();
            btnCalculate = new Button();
            listViewTaxiInvoice = new ListView();
            SuspendLayout();
            // 
            // lblTotalKM
            // 
            lblTotalKM.AutoSize = true;
            lblTotalKM.Location = new Point(12, 15);
            lblTotalKM.Name = "lblTotalKM";
            lblTotalKM.Size = new Size(56, 15);
            lblTotalKM.TabIndex = 0;
            lblTotalKM.Text = "Total KM:";
            // 
            // txbTotalKM
            // 
            txbTotalKM.Location = new Point(74, 12);
            txbTotalKM.Name = "txbTotalKM";
            txbTotalKM.Size = new Size(100, 23);
            txbTotalKM.TabIndex = 1;
            txbTotalKM.TextChanged += txbTotalKM_TextChanged;
            // 
            // lblTotalKMMsgErr
            // 
            lblTotalKMMsgErr.AutoSize = true;
            lblTotalKMMsgErr.Location = new Point(180, 15);
            lblTotalKMMsgErr.Name = "lblTotalKMMsgErr";
            lblTotalKMMsgErr.Size = new Size(0, 15);
            lblTotalKMMsgErr.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(74, 41);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 23);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // listViewTaxiInvoice
            // 
            listViewTaxiInvoice.Location = new Point(12, 70);
            listViewTaxiInvoice.Name = "listViewTaxiInvoice";
            listViewTaxiInvoice.Size = new Size(776, 192);
            listViewTaxiInvoice.TabIndex = 4;
            listViewTaxiInvoice.UseCompatibleStateImageBehavior = false;
            listViewTaxiInvoice.View = View.Details;
            // 
            // TaxiInvoiceApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewTaxiInvoice);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotalKMMsgErr);
            Controls.Add(txbTotalKM);
            Controls.Add(lblTotalKM);
            Name = "TaxiInvoiceApp";
            Text = "TaxiInvoiceApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalKM;
        private TextBox txbTotalKM;
        private Label lblTotalKMMsgErr;
        private Button btnCalculate;
        private ListView listViewTaxiInvoice;
    }
}
