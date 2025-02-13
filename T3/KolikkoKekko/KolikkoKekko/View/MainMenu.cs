using KolikkoKekko.Controller;

namespace KolikkoKekko
{
    public partial class MainMenu : Form
    {
        Bitcoinlogic bitcoinlogic;
        public MainMenu()
        {
            InitializeComponent();
            bitcoinlogic = new Bitcoinlogic();

            label1.DataBindings.Add(new Binding("Text", bitcoinlogic, "MaxPrice", true, DataSourceUpdateMode.OnPropertyChanged));
            label2.DataBindings.Add(new Binding("Text", bitcoinlogic, "MinPrice", true, DataSourceUpdateMode.OnPropertyChanged));

            label3.DataBindings.Add(new Binding("Text", bitcoinlogic, "MaxVolume", true, DataSourceUpdateMode.OnPropertyChanged));
            label4.DataBindings.Add(new Binding("Text", bitcoinlogic, "MinVolume", true, DataSourceUpdateMode.OnPropertyChanged));

            label5.DataBindings.Add(new Binding("Text", bitcoinlogic, "BullishStart", true, DataSourceUpdateMode.OnPropertyChanged));
            label6.DataBindings.Add(new Binding("Text", bitcoinlogic, "BullishEnd", true, DataSourceUpdateMode.OnPropertyChanged));

            label7.DataBindings.Add(new Binding("Text", bitcoinlogic, "BearishStart", true, DataSourceUpdateMode.OnPropertyChanged));
            label8.DataBindings.Add(new Binding("Text", bitcoinlogic, "BearishEnd", true, DataSourceUpdateMode.OnPropertyChanged));

            label9.DataBindings.Add(new Binding("Text", bitcoinlogic, "BestBuyDate", true, DataSourceUpdateMode.OnPropertyChanged));
            label10.DataBindings.Add(new Binding("Text", bitcoinlogic, "BestSellDate", true, DataSourceUpdateMode.OnPropertyChanged));

            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Price", "Price");
            bitcoinlogic.OnPriceDataUpdated += UpdateDataGridView;
            dateTimePicker1.Value = DateTime.Today.AddDays(-1);
            dateTimePicker2.Value = DateTime.Today;
        }
        private void UpdateDataGridView(List<Tuple<DateTime, double>> prices)
        {
            Invoke(new Action(() =>
            {
                dataGridView1.Rows.Clear();
                foreach (var priceData in prices)
                {
                    dataGridView1.Rows.Add(priceData.Item1.ToString("dd/MM/yyyy HH:mm"), priceData.Item2);
                }
            }));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bitcoinlogic.FetchBitcoinDataAsync(dateTimePicker1.Value, dateTimePicker2.Value);
        }
       



    }
}
