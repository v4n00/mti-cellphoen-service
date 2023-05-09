using Cellphone_Service.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cellphone_Service
{
    public partial class PrintForm : Form
    {
        private int index = 0;
        List<Client> selectedClients = new List<Client>();
        List<Client> Clients = new List<Client>();
        private ListViewColumnSorter lvwColumnSorter;

        public PrintForm()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.ClientsListView.ListViewItemSorter = lvwColumnSorter;
        }

        public PrintForm(List<Client> clients) : this()
        {
            Clients = clients;

            ClientsListView.Items.Clear();
            foreach (Client client in Clients)
            {
                ListViewItem lvi = new ListViewItem
                {
                    Text = client.Name
                };
                lvi.SubItems.Add(client.Subscription.SubscriptionType.ToString());
                lvi.SubItems.Add(client.Subscription.ClientType.ToString());
                lvi.SubItems.Add(client.TotalBill.ToString());
                lvi.SubItems.Add(client.ExtraOptions.Count.ToString());
                lvi.Tag = client;
                ClientsListView.Items.Add(lvi);
            }
        }

        private void ClientsListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.ClientsListView.Sort();
        }

        private void PrintPreviewBtn_Click(object sender, EventArgs e)
        {
            selectedClients.Clear();
            for (int i = 0; i < ClientsListView.CheckedItems.Count; i++)
            {
                selectedClients.Add((Client)(ClientsListView.CheckedItems[i].Tag));
            }
            index = 0;
            
            printPreviewDialog.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 20);

            var pageSettings = e.PageSettings;
            var printAreaHeight = e.MarginBounds.Height;
            var printAreaWidth = e.MarginBounds.Width;
            var marginLeft = pageSettings.Margins.Left;
            var marginTop = pageSettings.Margins.Top;
            const int rowHeight = 40;
            var columnWidth = printAreaWidth;
            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit | StringFormatFlags.NoClip);

            var currentY = marginTop;
            while (index < selectedClients.Count)
            {
                var currentX = marginLeft;
                currentY += rowHeight;

                e.Graphics.DrawString(
                    "Client #" + (index+1).ToString(),
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight),
                    fmt);
                currentY += rowHeight;

                e.Graphics.DrawString(
                    "Client name: " + selectedClients[index].Name,
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight),
                    fmt);
                currentY += rowHeight;

                e.Graphics.DrawString(
                    "Client type: " + selectedClients[index].Subscription.ClientType.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentY += rowHeight;

                e.Graphics.DrawString(
                    "Subscription type: " + selectedClients[index].Subscription.Name.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentY += rowHeight;

                e.Graphics.DrawString(
                    "Total bill: " + selectedClients[index].TotalBill.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentY += rowHeight;

                int idx = 1;
                foreach(var extraOption in selectedClients[index].ExtraOptions)
                {
                    e.Graphics.DrawString(
                    "Extra option #" + idx.ToString() + ": " + extraOption.Name.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                    currentY += rowHeight;
                    idx++;
                }

                index++;

                if (index < selectedClients.Count)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        }

        private void ClientsListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if(ClientsListView.CheckedItems.Count > 0)
            {
                PrintPreviewBtn.Enabled = true;
            }
            else
            {
                PrintPreviewBtn.Enabled = false;
            }
        }

        private void SelectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(SelectAllCheckBox.Checked)
            {
                for (int i = 0; i < ClientsListView.Items.Count; i++)
                {
                    ClientsListView.Items[i].Checked = true;
                }
                PrintPreviewBtn.Enabled = true;
            }
            else
            {
                for (int i = 0; i < ClientsListView.Items.Count; i++)
                {
                    ClientsListView.Items[i].Checked = false;
                }
                PrintPreviewBtn.Enabled = false;
            }
        }
    }
}
