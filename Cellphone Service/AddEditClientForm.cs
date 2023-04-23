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

namespace Cellphone_Service
{
    public partial class AddEditClientForm : Form
    {
        Client _client = new Client();

        public AddEditClientForm()
        {
            InitializeComponent();
            BoxSubscription.DataSource = Enum.GetValues(typeof(_SubscriptionType));
            BoxClientType.DataSource = Enum.GetValues(typeof(_ClientType));
        }

        public AddEditClientForm(Client client) : this()
        {
            _client = client;
        }

        private void AddEditClientForm_Load(object sender, EventArgs e)
        {
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            _client.Name = BoxName.Text;
            _client.Subscription = new Subscription((_SubscriptionType)BoxSubscription.SelectedItem, (_ClientType)BoxClientType.SelectedItem);
            _client.Update();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void BoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
