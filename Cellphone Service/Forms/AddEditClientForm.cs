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
            if(_client == null)
                _client = new Client();
            BoxName.Text = _client.Name;
            BoxSubscription.SelectedIndex = (int)_client.Subscription.SubscriptionType;
            BoxClientType.SelectedIndex = (int)_client.Subscription.ClientType;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Error: One or more fields is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                return;
            }
            else
            {
                _client.Name = BoxName.Text;
                _client.Subscription = new Subscription((_SubscriptionType)BoxSubscription.SelectedItem, (_ClientType)BoxClientType.SelectedItem);
            }
        }

        private void BoxName_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(BoxName, String.Empty);
        }

        private void BoxName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(BoxName.Text))
            {
                errorProvider.SetError(BoxName, "Please enter a description!");
                e.Cancel = true;
            }
        }
    }
}
