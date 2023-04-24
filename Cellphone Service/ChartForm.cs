using Cellphone_Service.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cellphone_Service
{
    public partial class ChartForm : Form
    {
        private bool SeriesChartType;
        private List<Client> clients;

        public ChartForm()
        {
            InitializeComponent();
        }

        public ChartForm(List<Client> _clients) : this()
        {
            if(_clients == null)
            {
                clients = new List<Client>();
            }
            else
            {
                clients = _clients; 
            }
            SeriesChartType = true;
            ComputeChartSubscription();
        }

        private void ComputeChartSubscription()
        {
            chart.Series["Series"].Points.Clear();
            int counterFirstOption = 0;
            int counterSecondOption = 0;
            int counterThirdOption = 0;
            foreach (Client client in clients)
            {
                if (client.Subscription.SubscriptionType == _SubscriptionType.CallAndSMS)
                {
                    counterFirstOption++;
                }
                if (client.Subscription.SubscriptionType == _SubscriptionType.Internet)
                {
                    counterSecondOption++;
                }
                if (client.Subscription.SubscriptionType == _SubscriptionType.AllInclusive)
                {
                    counterThirdOption++;
                }
            }
            if (counterFirstOption > 0)
            {
                chart.Series["Series"].Points.AddXY("Calls and SMS only", counterFirstOption);
            }
            if (counterSecondOption > 0)
            {
                chart.Series["Series"].Points.AddXY("Internet only", counterSecondOption);
            }
            if (counterThirdOption > 0)
            {
                chart.Series["Series"].Points.AddXY("All inclusive", counterThirdOption);
            }
        }

        private void ComputeChartClient()
        {
            chart.Series["Series"].Points.Clear();
            int counterFirstOption = 0;
            int counterSecondOption = 0;
            int counterThirdOption = 0;
            foreach (Client client in clients)
            {
                if (client.Subscription.ClientType == _ClientType.Standard)
                {
                    counterFirstOption++;
                }
                if (client.Subscription.ClientType == _ClientType.Gold)
                {
                    counterSecondOption++;
                }
                if (client.Subscription.ClientType == _ClientType.Platinum)
                {
                    counterThirdOption++;
                }
            }
            if (counterFirstOption > 0)
            {
                chart.Series["Series"].Points.AddXY("Standard client", counterFirstOption);
            }
            if (counterSecondOption > 0)
            {
                chart.Series["Series"].Points.AddXY("Gold client", counterSecondOption);
            }
            if (counterThirdOption > 0)
            {
                chart.Series["Series"].Points.AddXY("Platinum client", counterThirdOption);
            }
        }

        private void ChangeViewBtn_Click(object sender, EventArgs e)
        {
            SeriesChartType = !SeriesChartType;
            if(SeriesChartType == true)
            {
                ComputeChartSubscription();
            }
            else
            {
                ComputeChartClient();
            }
        }
    }
}
