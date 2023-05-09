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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/v4n00/mti-cellphone-service");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if(label6.BackColor == Color.Red)
            {
                label6.Text = "ᗜ_ᗜ";
                label6.BackColor = Color.Black;
                label6.ForeColor = Color.White;
            }
            else
            {
                label6.Text = "ᗜˬᗜ";
                label6.BackColor = Color.Red;
                label6.ForeColor = Color.Black;
            }
        }
    }
}
