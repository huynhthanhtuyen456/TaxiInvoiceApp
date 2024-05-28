using System.Text.RegularExpressions;
using TaxiInvoiceApp.Classes;

namespace TaxiInvoiceApp
{
    public partial class TaxiInvoiceApp : Form
    {
        // Regex for numbers only
        // https://stackoverflow.com/questions/273141/regex-for-numbers-only
        private Regex TotalKMPattern = new Regex("^[0-9.]+$");
        public TaxiInvoiceApp()
        {
            InitializeComponent();
            this.lblTotalKMMsgErr.Text = string.Empty;
            this.listViewTaxiInvoice.Columns.Add("Number");
            this.listViewTaxiInvoice.Columns.Add("Total KM");
            this.listViewTaxiInvoice.Columns.Add("Sub Total");
            this.listViewTaxiInvoice.Columns.Add("Tax");
            this.listViewTaxiInvoice.Columns.Add("Total");
            this.listViewTaxiInvoice.Font = new Font(listViewTaxiInvoice.Font, FontStyle.Bold);
            this.btnCalculate.Enabled = false;
        }

        private void txbTotalKM_TextChanged(object sender, EventArgs e)
        {
            this.lblTotalKMMsgErr.Text = string.Empty;
            this.btnCalculate.Enabled = true;
            if (!this.TotalKMPattern.IsMatch(this.txbTotalKM.Text))
            {
                this.lblTotalKMMsgErr.Text = "Only accepting numbers!";
                this.lblTotalKMMsgErr.ForeColor = System.Drawing.Color.Red;
                this.btnCalculate.Enabled = false;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!this.TotalKMPattern.IsMatch(this.txbTotalKM.Text))
            {
                MessageBox.Show("Invalid Total KM value!");
                return;
            }
            Random randNumber = new Random();
            // To Calculate Taxi Price, Please refer this link: https://vnpay.vn/cach-tinh-gia-tien-taxi-0qun6kn1r33r
            TaxiInvoice taxiInvoice = new TaxiInvoice()
            {
                FirstKM2ThirstyPrice = 11000,
                TotalKM = float.Parse(this.txbTotalKM.Text),
                OpenDoorPrice = 9000,
                FromThirstyOneKMPrice = 9500,
                WaitingFee = 20000,
            };
            ListViewItem listViewItem = new ListViewItem(
                new string[]
                {
                    $"ID{randNumber.Next(1, 1000)}",
                    taxiInvoice.TotalKM.ToString("#,##0.00"),
                    $"{taxiInvoice.SubTotal().ToString("#,##0")} VND",
                    $"{taxiInvoice.Tax().ToString("#,##0")} VND",
                    $"{taxiInvoice.Total().ToString("#,##0")} VND"
                }
            );
            listViewItem.Font = new Font(listViewTaxiInvoice.Font, FontStyle.Regular);
            this.listViewTaxiInvoice.Items.Add(listViewItem);
            this.listViewTaxiInvoice.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.listViewTaxiInvoice.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.listViewTaxiInvoice.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            this.listViewTaxiInvoice.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
