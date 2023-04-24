﻿using Cellphone_Service.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cellphone_Service
{
    public partial class AddEditExtraOptionForm : Form
    {
        ExtraOption _extraOption = new ExtraOption();

        public AddEditExtraOptionForm()
        {
            InitializeComponent();
        }

        public AddEditExtraOptionForm(ExtraOption extraOption) : this()
        {
            _extraOption = extraOption;
        }

        private void AddEditExtraOptionForm_Load(object sender, EventArgs e)
        {
            if(_extraOption == null)
            {
                _extraOption = new ExtraOption();
            }

            BoxName.Text = _extraOption.Name;
            BoxPrice.Value = (decimal)_extraOption.Price;
            BoxDescription.Text = _extraOption.Description;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _extraOption.Name = BoxName.Text;
            _extraOption.Price = (double)BoxPrice.Value;
            _extraOption.Description = BoxDescription.Text;
        }

        private void BoxName_Validated(object sender, EventArgs e)
        {
            //errorProvider.SetError(BoxName, String.Empty);
            //errorProvider.SetError(BoxDescription, String.Empty);
            //errorProvider.SetError(BoxPrice, String.Empty);
        }

        private void BoxName_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(BoxName.Text))
            //{
            //    errorProvider.SetError(BoxName, "Please enter a name!");
            //    e.Cancel = true;
            //}
            //if (string.IsNullOrEmpty(BoxDescription.Text))
            //{
            //    errorProvider.SetError(BoxDescription, "Please enter a description!");
            //    e.Cancel = true;
            //}
            //if (BoxPrice.Value == 0)
            //{
            //    errorProvider.SetError(BoxPrice, "Please enter a valid price!");
            //    e.Cancel = true;
            //}
        }
    }
}
