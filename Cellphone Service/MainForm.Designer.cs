namespace Cellphone_Service
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ClientsTreeView = new System.Windows.Forms.TreeView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddClientBtn = new System.Windows.Forms.Button();
            this.AddExtraOptionBtn = new System.Windows.Forms.Button();
            this.EditClientBtn = new System.Windows.Forms.Button();
            this.EditExtraOptionBtn = new System.Windows.Forms.Button();
            this.ViewStatisticsBtn = new System.Windows.Forms.Button();
            this.ExportReportBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteClientBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteExtraOptionBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientsTreeView
            // 
            this.ClientsTreeView.Location = new System.Drawing.Point(8, 183);
            this.ClientsTreeView.Name = "ClientsTreeView";
            this.ClientsTreeView.Size = new System.Drawing.Size(531, 456);
            this.ClientsTreeView.TabIndex = 0;
            this.ClientsTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ClientsTreeView_NodeMouseClick);
            this.ClientsTreeView.Leave += new System.EventHandler(this.ClientsTreeView_Leave);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(551, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.serializeToolStripMenuItem.Text = "Serialize";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // AddClientBtn
            // 
            this.AddClientBtn.Location = new System.Drawing.Point(6, 19);
            this.AddClientBtn.Name = "AddClientBtn";
            this.AddClientBtn.Size = new System.Drawing.Size(91, 23);
            this.AddClientBtn.TabIndex = 2;
            this.AddClientBtn.Text = "Add Client";
            this.AddClientBtn.UseVisualStyleBackColor = true;
            this.AddClientBtn.Click += new System.EventHandler(this.AddClientBtn_Click);
            // 
            // AddExtraOptionBtn
            // 
            this.AddExtraOptionBtn.Enabled = false;
            this.AddExtraOptionBtn.Location = new System.Drawing.Point(6, 19);
            this.AddExtraOptionBtn.Name = "AddExtraOptionBtn";
            this.AddExtraOptionBtn.Size = new System.Drawing.Size(79, 52);
            this.AddExtraOptionBtn.TabIndex = 4;
            this.AddExtraOptionBtn.Text = "Add Extra Option";
            this.AddExtraOptionBtn.UseVisualStyleBackColor = true;
            this.AddExtraOptionBtn.Click += new System.EventHandler(this.AddExtraOptionBtn_Click);
            // 
            // EditClientBtn
            // 
            this.EditClientBtn.Enabled = false;
            this.EditClientBtn.Location = new System.Drawing.Point(103, 19);
            this.EditClientBtn.Name = "EditClientBtn";
            this.EditClientBtn.Size = new System.Drawing.Size(91, 23);
            this.EditClientBtn.TabIndex = 3;
            this.EditClientBtn.Text = "Edit Client";
            this.EditClientBtn.UseVisualStyleBackColor = true;
            this.EditClientBtn.Click += new System.EventHandler(this.EditClientBtn_Click);
            // 
            // EditExtraOptionBtn
            // 
            this.EditExtraOptionBtn.Enabled = false;
            this.EditExtraOptionBtn.Location = new System.Drawing.Point(91, 19);
            this.EditExtraOptionBtn.Name = "EditExtraOptionBtn";
            this.EditExtraOptionBtn.Size = new System.Drawing.Size(79, 52);
            this.EditExtraOptionBtn.TabIndex = 5;
            this.EditExtraOptionBtn.Text = "Edit Extra Option";
            this.EditExtraOptionBtn.UseVisualStyleBackColor = true;
            this.EditExtraOptionBtn.Click += new System.EventHandler(this.EditExtraOptionBtn_Click);
            // 
            // ViewStatisticsBtn
            // 
            this.ViewStatisticsBtn.Enabled = false;
            this.ViewStatisticsBtn.Location = new System.Drawing.Point(100, 19);
            this.ViewStatisticsBtn.Name = "ViewStatisticsBtn";
            this.ViewStatisticsBtn.Size = new System.Drawing.Size(86, 23);
            this.ViewStatisticsBtn.TabIndex = 6;
            this.ViewStatisticsBtn.Text = "View Statistics";
            this.ViewStatisticsBtn.UseVisualStyleBackColor = true;
            // 
            // ExportReportBtn
            // 
            this.ExportReportBtn.Enabled = false;
            this.ExportReportBtn.Location = new System.Drawing.Point(6, 19);
            this.ExportReportBtn.Name = "ExportReportBtn";
            this.ExportReportBtn.Size = new System.Drawing.Size(88, 23);
            this.ExportReportBtn.TabIndex = 7;
            this.ExportReportBtn.Text = "Export Report";
            this.ExportReportBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteClientBtn);
            this.groupBox1.Controls.Add(this.AddClientBtn);
            this.groupBox1.Controls.Add(this.EditClientBtn);
            this.groupBox1.Location = new System.Drawing.Point(8, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 50);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Management";
            // 
            // DeleteClientBtn
            // 
            this.DeleteClientBtn.Enabled = false;
            this.DeleteClientBtn.Location = new System.Drawing.Point(200, 19);
            this.DeleteClientBtn.Name = "DeleteClientBtn";
            this.DeleteClientBtn.Size = new System.Drawing.Size(91, 23);
            this.DeleteClientBtn.TabIndex = 4;
            this.DeleteClientBtn.Text = "Delete Client";
            this.DeleteClientBtn.UseVisualStyleBackColor = true;
            this.DeleteClientBtn.Click += new System.EventHandler(this.DeleteClientBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteExtraOptionBtn);
            this.groupBox2.Controls.Add(this.AddExtraOptionBtn);
            this.groupBox2.Controls.Add(this.EditExtraOptionBtn);
            this.groupBox2.Location = new System.Drawing.Point(8, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 82);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extra Option Management";
            // 
            // DeleteExtraOptionBtn
            // 
            this.DeleteExtraOptionBtn.Enabled = false;
            this.DeleteExtraOptionBtn.Location = new System.Drawing.Point(176, 19);
            this.DeleteExtraOptionBtn.Name = "DeleteExtraOptionBtn";
            this.DeleteExtraOptionBtn.Size = new System.Drawing.Size(79, 52);
            this.DeleteExtraOptionBtn.TabIndex = 10;
            this.DeleteExtraOptionBtn.Text = "Delete Extra Option";
            this.DeleteExtraOptionBtn.UseVisualStyleBackColor = true;
            this.DeleteExtraOptionBtn.Click += new System.EventHandler(this.DeleteExtraOptionBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ExportReportBtn);
            this.groupBox3.Controls.Add(this.ViewStatisticsBtn);
            this.groupBox3.Location = new System.Drawing.Point(330, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 138);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extras";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(551, 651);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClientsTreeView);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Cellphone Service Customer Management";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView ClientsTreeView;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button AddClientBtn;
        private System.Windows.Forms.Button AddExtraOptionBtn;
        private System.Windows.Forms.Button EditClientBtn;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button EditExtraOptionBtn;
        private System.Windows.Forms.Button ViewStatisticsBtn;
        private System.Windows.Forms.Button ExportReportBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteClientBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteExtraOptionBtn;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

