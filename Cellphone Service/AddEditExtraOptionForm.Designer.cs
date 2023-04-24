namespace Cellphone_Service
{
    partial class AddEditExtraOptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditExtraOptionForm));
            this.label3 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxDescription = new System.Windows.Forms.TextBox();
            this.BoxPrice = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BoxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Description:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveBtn.Location = new System.Drawing.Point(288, 275);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(138, 42);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.CancelBtn.Location = new System.Drawing.Point(57, 275);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(138, 42);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Price:";
            // 
            // BoxName
            // 
            this.BoxName.Location = new System.Drawing.Point(154, 20);
            this.BoxName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(321, 29);
            this.BoxName.TabIndex = 9;
            this.BoxName.Validating += new System.ComponentModel.CancelEventHandler(this.BoxName_Validating);
            this.BoxName.Validated += new System.EventHandler(this.BoxName_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // BoxDescription
            // 
            this.BoxDescription.Location = new System.Drawing.Point(154, 138);
            this.BoxDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BoxDescription.Multiline = true;
            this.BoxDescription.Name = "BoxDescription";
            this.BoxDescription.Size = new System.Drawing.Size(321, 104);
            this.BoxDescription.TabIndex = 15;
            this.BoxDescription.Validating += new System.ComponentModel.CancelEventHandler(this.BoxDescription_Validating);
            this.BoxDescription.Validated += new System.EventHandler(this.BoxDescription_Validated);
            // 
            // BoxPrice
            // 
            this.BoxPrice.DecimalPlaces = 2;
            this.BoxPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.BoxPrice.Location = new System.Drawing.Point(154, 83);
            this.BoxPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BoxPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.BoxPrice.Name = "BoxPrice";
            this.BoxPrice.Size = new System.Drawing.Size(324, 29);
            this.BoxPrice.TabIndex = 16;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // AddEditExtraOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 340);
            this.Controls.Add(this.BoxPrice);
            this.Controls.Add(this.BoxDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditExtraOptionForm";
            this.Text = "Add / Edit Extra Option";
            this.Load += new System.EventHandler(this.AddEditExtraOptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxDescription;
        private System.Windows.Forms.NumericUpDown BoxPrice;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}