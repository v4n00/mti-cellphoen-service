using Cellphone_Service.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cellphone_Service
{
    public partial class MainForm : Form
    {
        public List<Client> Clients;

        public MainForm()
        {
            InitializeComponent();
            Clients = new List<Client>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisplayClients ()
        {
            ClientsTreeView.Nodes.Clear();
            Clients.Sort();
            for(int i = 0; i < Clients.Count; i++)
            {
                TreeNode node = new TreeNode(Clients[i].Name);
                node.Tag = Clients[i];
                TreeNode totalBillNode = new TreeNode("Total Bill: " + Clients[i].TotalBill.ToString());
                node.Nodes.Add(totalBillNode);
                TreeNode subscriptionName = new TreeNode("Package: " + Clients[i].Subscription.Name);
                node.Nodes.Add(subscriptionName);
                TreeNode subscriptionPrice = new TreeNode("Subscription Price: " + Clients[i].Subscription.Price.ToString());
                node.Nodes.Add(subscriptionPrice);
                TreeNode _clientType = new TreeNode("Type: " + Clients[i].Subscription.ClientType.ToString());
                node.Nodes.Add(_clientType);
                ClientsTreeView.Nodes.Add(node);
            }
        }

        private void AddClientBtn_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            AddEditClientForm form = new AddEditClientForm(client);
            if (DialogResult.OK == form.ShowDialog())
            {
                Clients.Add(client);
                DisplayClients();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream f = File.OpenWrite("data.bin"))
            {
                formatter.Serialize(f, Clients);
            }
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream f = null;
            try
            {
                f = File.OpenRead("data.bin");
                Clients = (List<Client>)formatter.Deserialize(f);
                DisplayClients();
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            finally
            {
                if (f != null)
                    f.Close();
            }
        }

        private void ClientsTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            EditClientBtn.Enabled = true;
            AddExtraOptionBtn.Enabled = true;
        }
    }
}
