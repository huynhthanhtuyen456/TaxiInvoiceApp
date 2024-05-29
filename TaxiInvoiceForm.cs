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
        private readonly string TotalKMPattern = @"^[0-9.]+$";
        private readonly System.Timers.Timer WaitingTimer;
        // hour, minute, second, millisecond
        int h, m, s, ms;
        public Dictionary<string, Company> CompanyDictionary = new Dictionary<string, Company>();
        public TaxiInvoiceApp()
        {
            InitializeComponent();
            this.LblTotalKMMsgErr.Text = string.Empty;
            this.ListViewTaxiInvoice.Columns.Add("Number");
            this.ListViewTaxiInvoice.Columns.Add("Total KM");
            this.ListViewTaxiInvoice.Columns.Add("Waiting Fee");
            this.ListViewTaxiInvoice.Columns.Add("Sub Total");
            this.ListViewTaxiInvoice.Columns.Add("Tax");
            this.ListViewTaxiInvoice.Columns.Add("Total");
            this.ListViewTaxiInvoice.Columns.Add("Exported Date");
            this.ListViewTaxiInvoice.Font = new Font(ListViewTaxiInvoice.Font, FontStyle.Bold);
            this.BtnCalculate.Enabled = false;
            this.WaitingTimer = new System.Timers.Timer();
            Company companyMeLinh = new()
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
            Company companyG7 = new()
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
            this.ComboBoxCompany.Items.Add(companyMeLinh.Name);
            this.ComboBoxCompany.Items.Add(companyG7.Name);
            this.ComboBoxCompany.SelectedItem = companyMeLinh.Name;
            this.ComboBoxCompany.SelectedIndex = 0;
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
                this.LblWaitingTimer.Text = $"{this.h.ToString().ToString().PadLeft(2, '0')}:{this.m.ToString().ToString().PadLeft(2, '0')}:{this.s.ToString().ToString().PadLeft(2, '0')}";
            }));
        }

        private void BtnStopTimer_Click(object sender, EventArgs e)
        {
            this.WaitingTimer.Stop();
        }

        private void BtnStartTimer_Click(object sender, EventArgs e)
        {
            this.WaitingTimer.Start();
        }

        private void BtnResetTimer_Click(object sender, EventArgs e)
        {
            this.WaitingTimer.Stop();
            this.h = this.m = this.s = this.ms = 0;
            this.LblWaitingTimer.Text = "00:00:00";
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            Random randNumber = new();
            // To Calculate Taxi Price, Please refer this link: https://vnpay.vn/cach-tinh-gia-tien-taxi-0qun6kn1r33r
            string[] waitingTime = this.LblWaitingTimer.Text.Split(":");
            int waitingHours = int.Parse(waitingTime[0]);
            TaxiInvoice taxiInvoice = new()
            {
                TotalKM = float.Parse(this.TxbTotalKM.Text),
                Company = this.CompanyDictionary[this.ComboBoxCompany.Text],
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
            listViewItem.Font = new Font(ListViewTaxiInvoice.Font, FontStyle.Regular);
            this.ListViewTaxiInvoice.Items.Add(listViewItem);
            this.ListViewTaxiInvoice.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.ListViewTaxiInvoice.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.ListViewTaxiInvoice.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            this.ListViewTaxiInvoice.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);
            this.ListViewTaxiInvoice.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.ListViewTaxiInvoice.AutoResizeColumn(6, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void TxbTotalKM_TextChanged(object sender, EventArgs e)
        {
            this.LblTotalKMMsgErr.Text = string.Empty;
            this.BtnCalculate.Enabled = true;
            Regex totalKMRegex = new(this.TotalKMPattern);
            if (!totalKMRegex.IsMatch(this.TxbTotalKM.Text))
            {
                this.LblTotalKMMsgErr.Text = "Only accepting numbers!";
                this.LblTotalKMMsgErr.ForeColor = System.Drawing.Color.Red;
                this.BtnCalculate.Enabled = false;
            }
        }
    }
}
