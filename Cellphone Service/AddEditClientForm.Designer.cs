namespace Cellphone_Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditClientForm));
            this.label1 = new System.Windows.Forms.Label();
            this.BoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxSubscription = new System.Windows.Forms.ComboBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxClientType = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.subscriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client name:";
            // 
            // BoxName
            // 
            this.BoxName.Location = new System.Drawing.Point(152, 31);
            this.BoxName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(321, 29);
            this.BoxName.TabIndex = 1;
            this.BoxName.Validating += new System.ComponentModel.CancelEventHandler(this.BoxName_Validating);
            this.BoxName.Validated += new System.EventHandler(this.BoxName_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subscription:";
            // 
            // BoxSubscription
            // 
            this.BoxSubscription.FormattingEnabled = true;
            this.BoxSubscription.Location = new System.Drawing.Point(152, 92);
            this.BoxSubscription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BoxSubscription.Name = "BoxSubscription";
            this.BoxSubscription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoxSubscription.Size = new System.Drawing.Size(321, 32);
            this.BoxSubscription.TabIndex = 3;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.CancelBtn.Location = new System.Drawing.Point(53, 229);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(138, 42);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveBtn.Location = new System.Drawing.Point(284, 229);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(138, 42);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Client type:";
            // 
            // BoxClientType
            // 
            this.BoxClientType.FormattingEnabled = true;
            this.BoxClientType.Location = new System.Drawing.Point(152, 150);
            this.BoxClientType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BoxClientType.Name = "BoxClientType";
            this.BoxClientType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoxClientType.Size = new System.Drawing.Size(321, 32);
            this.BoxClientType.TabIndex = 7;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // subscriptionBindingSource
            // 
            this.subscriptionBindingSource.DataSource = typeof(Cellphone_Service.Classes.Subscription);
            // 
            // AddEditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 294);
            this.Controls.Add(this.BoxClientType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.BoxSubscription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditClientForm";
            this.Text = "Add / Edit Client";
            this.Load += new System.EventHandler(this.AddEditClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.BindingSource subscriptionBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BoxClientType;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}