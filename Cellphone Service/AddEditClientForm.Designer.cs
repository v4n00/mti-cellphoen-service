﻿namespace Cellphone_Service
{
    partial class AddEditClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxSubscription = new System.Windows.Forms.ComboBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.subscriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.BoxClientType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client name:";
            // 
            // BoxName
            // 
            this.BoxName.Location = new System.Drawing.Point(83, 17);
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(177, 20);
            this.BoxName.TabIndex = 1;
            this.BoxName.TextChanged += new System.EventHandler(this.BoxName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subscription:";
            // 
            // BoxSubscription
            // 
            this.BoxSubscription.FormattingEnabled = true;
            this.BoxSubscription.Location = new System.Drawing.Point(83, 50);
            this.BoxSubscription.Name = "BoxSubscription";
            this.BoxSubscription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoxSubscription.Size = new System.Drawing.Size(177, 21);
            this.BoxSubscription.TabIndex = 3;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.CancelBtn.Location = new System.Drawing.Point(29, 124);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddBtn.Location = new System.Drawing.Point(155, 124);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // subscriptionBindingSource
            // 
            this.subscriptionBindingSource.DataSource = typeof(Cellphone_Service.Classes.Subscription);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Client type:";
            // 
            // BoxClientType
            // 
            this.BoxClientType.FormattingEnabled = true;
            this.BoxClientType.Location = new System.Drawing.Point(83, 81);
            this.BoxClientType.Name = "BoxClientType";
            this.BoxClientType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoxClientType.Size = new System.Drawing.Size(177, 21);
            this.BoxClientType.TabIndex = 7;
            // 
            // AddEditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 159);
            this.Controls.Add(this.BoxClientType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.BoxSubscription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxName);
            this.Controls.Add(this.label1);
            this.Name = "AddEditClientForm";
            this.Text = "AddEditClientForm";
            this.Load += new System.EventHandler(this.AddEditClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BoxSubscription;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.BindingSource subscriptionBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BoxClientType;
    }
}