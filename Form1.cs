using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BitcoinCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            resultlable.Visible = false;


            if (string.IsNullOrWhiteSpace(bitcoinamountinput.Text) || !float.TryParse(bitcoinamountinput.Text, out float bitcoinAmount))
            {
                resultlable.Visible = true;
                resultlable.Text = "Palun sisesta bitcoin summa!";
                return;
            }


            if (currencyselector.SelectedItem == null)
            {
                resultlable.Visible = true;
                resultlable.Text = "vali valuuta!";
                return;
            }

            if (currencyselector.SelectedItem.ToString() == "EUR")
            {
                resultlable.Visible = true;
                tulemuslable.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.EUR.rate_float;
                resultlable.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.EUR.code}";
            }
            
            if (currencyselector.SelectedItem.ToString() == "EEK")
            {
                resultlable.Visible = true;
                tulemuslable.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                const float eurToEekRate = 15.6466f;
                float resultInEur = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.EUR.rate_float;
                float resultInEek = resultInEur * eurToEekRate; 
                resultlable.Text = $"{resultInEek} Bitcoini EEK "; 
            }

            if (currencyselector.SelectedItem.ToString() == "USD")
            {
                resultlable.Visible = true;
                tulemuslable.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.USD.rate_float;
                resultlable.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.USD.code}";
            }

            if (currencyselector.SelectedItem.ToString() == "GBP")
            {
                resultlable.Visible = true;
                tulemuslable.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.GBP.rate_float;
                resultlable.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.GBP.code}";
            }

           
            /*
             Lisate juurde Dollari, naela ja eesti krooni
             */
        }

        public static BitcoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            BitcoinRates bitcoin = new BitcoinRates();
            using (var responseReader = new StreamReader(webStream))
            {
                var data = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);
            }
            return bitcoin;

            

        }

        private void bitcoinamountinput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}