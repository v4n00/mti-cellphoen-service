namespace Cellphone_Service
{
    partial class PrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.ClientsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrintPreviewBtn = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.SelectAllCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ClientsListView
            // 
            this.ClientsListView.CheckBoxes = true;
            this.ClientsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ClientsListView.HideSelection = false;
            this.ClientsListView.Location = new System.Drawing.Point(12, 12);
            this.ClientsListView.Name = "ClientsListView";
            this.ClientsListView.Size = new System.Drawing.Size(462, 244);
            this.ClientsListView.TabIndex = 0;
            this.ClientsListView.UseCompatibleStateImageBehavior = false;
            this.ClientsListView.View = System.Windows.Forms.View.Details;
            this.ClientsListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ClientsListView_ColumnClick);
            this.ClientsListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ClientsListView_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 119;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Subscription";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Client type";
            this.columnHeader3.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total bill";
            this.columnHeader4.Width = 51;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "No. options";
            this.columnHeader5.Width = 68;
            // 
            // PrintPreviewBtn
            // 
            this.PrintPreviewBtn.Enabled = false;
            this.PrintPreviewBtn.Location = new System.Drawing.Point(15, 262);
            this.PrintPreviewBtn.Name = "PrintPreviewBtn";
            this.PrintPreviewBtn.Size = new System.Drawing.Size(383, 23);
            this.PrintPreviewBtn.TabIndex = 1;
            this.PrintPreviewBtn.Text = "Print preview";
            this.PrintPreviewBtn.UseVisualStyleBackColor = true;
            this.PrintPreviewBtn.Click += new System.EventHandler(this.PrintPreviewBtn_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.ShowIcon = false;
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.DocumentName = "clients";
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // SelectAllCheckBox
            // 
            this.SelectAllCheckBox.AutoSize = true;
            this.SelectAllCheckBox.Location = new System.Drawing.Point(404, 266);
            this.SelectAllCheckBox.Name = "SelectAllCheckBox";
            this.SelectAllCheckBox.Size = new System.Drawing.Size(70, 17);
            this.SelectAllCheckBox.TabIndex = 2;
            this.SelectAllCheckBox.Text = "Select All";
            this.SelectAllCheckBox.UseVisualStyleBackColor = true;
            this.SelectAllCheckBox.CheckedChanged += new System.EventHandler(this.SelectAllCheckBox_CheckedChanged);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 292);
            this.Controls.Add(this.SelectAllCheckBox);
            this.Controls.Add(this.PrintPreviewBtn);
            this.Controls.Add(this.ClientsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ClientsListView;
        private System.Windows.Forms.Button PrintPreviewBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.CheckBox SelectAllCheckBox;
    }
}