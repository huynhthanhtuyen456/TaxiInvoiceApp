using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Timers;
using TaxiInvoiceApp.Classes;

namespace TaxiInvoiceApp
{
    public partial class TaxiInvoiceApp : Form
    {
        // Regex for numbers only
        // https://stackoverflow.com/questions/273141/regex-for-numbers-only
        private Regex TotalKMPattern = new Regex("^[0-9.]+$");
        private System.Timers.Timer WaitingTimer;
        // hour, minute, second, millisecond
        int h, m, s, ms;
        Dictionary<string, Company> CompanyDictionary = new Dictionary<string, Company>();
        public TaxiInvoiceApp()
        {
            InitializeComponent();
            this.lblTotalKMMsgErr.Text = string.Empty;
            this.listViewTaxiInvoice.Columns.Add("Number");
            this.listViewTaxiInvoice.Columns.Add("Total KM");
            this.listViewTaxiInvoice.Columns.Add("Waiting Fee");
            this.listViewTaxiInvoice.Columns.Add("Sub Total");
            this.listViewTaxiInvoice.Columns.Add("Tax");
            this.listViewTaxiInvoice.Columns.Add("Total");
            this.listViewTaxiInvoice.Columns.Add("Exported Date");
            this.listViewTaxiInvoice.Font = new Font(listViewTaxiInvoice.Font, FontStyle.Bold);
            this.btnCalculate.Enabled = false;
            this.WaitingTimer = new System.Timers.Timer();
            Company companyMeLinh = new Company()
            {
                Name = "Me Linh Corporation",
                TaxiPrice = new TaxiCompanyPrice()
                {
                    OpenDoorPrice = 10000,
                    FirstKM2ThirstyPrice = 13600,
                    FromThirstyOneKMPrice = 11000,
                    WaitingFeePerHour = 45000
                }
            };
            Company companyG7 = new Company()
            {
                Name = "G7 Company",
                TaxiPrice = new TaxiCompanyPrice()
                {
                    OpenDoorPrice = 20000,
                    FirstKM2ThirstyPrice = 11500,
                    FromThirstyOneKMPrice = 9500,
                    WaitingFeePerHour = 30000
                }
            };
            this.CompanyDictionary.Add(companyMeLinh.Name, companyMeLinh);
            this.CompanyDictionary.Add(companyG7.Name, companyG7);
            this.comboBoxCompany.Items.Add(companyMeLinh.Name);
            this.comboBoxCompany.Items.Add(companyG7.Name);
            this.comboBoxCompany.SelectedItem = companyMeLinh.Name;
            this.comboBoxCompany.SelectedIndex = 0;
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
            Random randNumber = new Random();
            // To Calculate Taxi Price, Please refer this link: https://vnpay.vn/cach-tinh-gia-tien-taxi-0qun6kn1r33r
            string[] waitingTime = this.lblWaitingTimer.Text.Split(":");
            int waitingHours = int.Parse(waitingTime[0]);
            TaxiInvoice taxiInvoice = new TaxiInvoice()
            {
                TotalKM = float.Parse(this.txbTotalKM.Text),
                Company = this.CompanyDictionary[this.comboBoxCompany.Text],
                WaitingHours = waitingHours,
            };
            ListViewItem listViewItem = new ListViewItem(
                new string[]
                {
                    $"ID{randNumber.Next(1, 1000)}",
                    taxiInvoice.TotalKM.ToString("#,##0.00"),
                    taxiInvoice.WaitingFee().ToString("#,##0"),
                    $"{taxiInvoice.SubTotal().ToString("#,##0")} VND",
                    $"{taxiInvoice.Tax().ToString("#,##0")} VND",
                    $"{taxiInvoice.Total().ToString("#,##0")} VND",
                    taxiInvoice.ExportedDate.ToString("dd/MM/yyyy")
                }
            );
            listViewItem.Font = new Font(listViewTaxiInvoice.Font, FontStyle.Regular);
            this.listViewTaxiInvoice.Items.Add(listViewItem);
            this.listViewTaxiInvoice.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.listViewTaxiInvoice.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.listViewTaxiInvoice.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            this.listViewTaxiInvoice.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);
            this.listViewTaxiInvoice.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.listViewTaxiInvoice.AutoResizeColumn(6, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void TaxiInvoiceApp_Load(object sender, EventArgs e)
        {
            // Default 100ms
            this.WaitingTimer.Interval = 1;
            this.WaitingTimer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                this.ms += 1;
                if (this.ms == 100)
                {
                    this.ms = 0;
                    this.s += 1;
                }
                if (this.s == 60)
                {
                    this.s = 0;
                    this.m += 1;
                }
                if (this.m == 60)
                {
                    this.m = 0;
                    this.h += 1;
                }
                this.lblWaitingTimer.Text = $"{this.h.ToString().ToString().PadLeft(2, '0')}:{this.m.ToString().ToString().PadLeft(2, '0')}:{this.s.ToString().ToString().PadLeft(2, '0')}";
            }));
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            this.WaitingTimer.Start();
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            this.WaitingTimer.Stop();
        }

        private void btnResetTimer_Click(object sender, EventArgs e)
        {
            this.WaitingTimer.Stop();
            this.h = this.m = this.s = this.ms = 0;
            this.lblWaitingTimer.Text = "00:00:00";
        }
    }
}
