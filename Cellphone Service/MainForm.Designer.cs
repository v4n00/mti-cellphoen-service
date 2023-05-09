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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ClientsTreeView = new System.Windows.Forms.TreeView();
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reloadViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddClientBtn = new System.Windows.Forms.Button();
            this.AddExtraOptionBtn = new System.Windows.Forms.Button();
            this.EditClientBtn = new System.Windows.Forms.Button();
            this.EditExtraOptionBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteClientBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteExtraOptionBtn = new System.Windows.Forms.Button();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ExportReportBtn = new System.Windows.Forms.ToolStripButton();
            this.ViewStatisticsBtn = new System.Windows.Forms.ToolStripButton();
            this.PrintBtn = new System.Windows.Forms.ToolStripButton();
            this.TotalClientsStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.TotalOptionsStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ShortcutToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.editClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExtraOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteExtraOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editExtraOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientsTreeView
            // 
            this.ClientsTreeView.ContextMenuStrip = this.ContextMenuStrip;
            this.ClientsTreeView.Location = new System.Drawing.Point(6, 192);
            this.ClientsTreeView.Name = "ClientsTreeView";
            this.ClientsTreeView.Size = new System.Drawing.Size(297, 366);
            this.ClientsTreeView.TabIndex = 0;
            this.ClientsTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ClientsTreeView_NodeMouseClick);
            this.ClientsTreeView.Leave += new System.EventHandler(this.ClientsTreeView_Leave);
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadViewToolStripMenuItem,
            this.addClientToolStripMenuItem,
            this.editClientToolStripMenuItem,
            this.deleteClientToolStripMenuItem,
            this.addExtraOptionToolStripMenuItem,
            this.editExtraOptionToolStripMenuItem,
            this.deleteExtraOptionToolStripMenuItem});
            this.ContextMenuStrip.Name = "contextMenuStrip";
            this.ContextMenuStrip.Size = new System.Drawing.Size(189, 242);
            this.ContextMenuStrip.Opened += new System.EventHandler(this.ContextMenuStrip_Opened);
            // 
            // reloadViewToolStripMenuItem
            // 
            this.reloadViewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloadViewToolStripMenuItem.Image")));
            this.reloadViewToolStripMenuItem.Name = "reloadViewToolStripMenuItem";
            this.reloadViewToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.reloadViewToolStripMenuItem.Text = "Reload View";
            this.reloadViewToolStripMenuItem.Click += new System.EventHandler(this.reloadViewToolStripMenuItem_Click);
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addClientToolStripMenuItem.Image")));
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.addClientToolStripMenuItem.Text = "Add Client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(307, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
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
            this.serializeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serializeToolStripMenuItem.Image")));
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.serializeToolStripMenuItem.Text = "Save";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deserializeToolStripMenuItem.Image")));
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.deserializeToolStripMenuItem.Text = "Load";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // AddClientBtn
            // 
            this.AddClientBtn.BackColor = System.Drawing.Color.Lime;
            this.AddClientBtn.Location = new System.Drawing.Point(6, 19);
            this.AddClientBtn.Name = "AddClientBtn";
            this.AddClientBtn.Size = new System.Drawing.Size(91, 23);
            this.AddClientBtn.TabIndex = 2;
            this.AddClientBtn.Text = "Add Client";
            this.ShortcutToolTip.SetToolTip(this.AddClientBtn, "Alt + A");
            this.AddClientBtn.UseVisualStyleBackColor = false;
            this.AddClientBtn.Click += new System.EventHandler(this.AddClientBtn_Click);
            // 
            // AddExtraOptionBtn
            // 
            this.AddExtraOptionBtn.BackColor = System.Drawing.Color.White;
            this.AddExtraOptionBtn.Enabled = false;
            this.AddExtraOptionBtn.Location = new System.Drawing.Point(6, 19);
            this.AddExtraOptionBtn.Name = "AddExtraOptionBtn";
            this.AddExtraOptionBtn.Size = new System.Drawing.Size(91, 40);
            this.AddExtraOptionBtn.TabIndex = 4;
            this.AddExtraOptionBtn.Text = "Add Extra Option";
            this.ShortcutToolTip.SetToolTip(this.AddExtraOptionBtn, "Ctrl + Alt + A");
            this.AddExtraOptionBtn.UseVisualStyleBackColor = false;
            this.AddExtraOptionBtn.Click += new System.EventHandler(this.AddExtraOptionBtn_Click);
            // 
            // EditClientBtn
            // 
            this.EditClientBtn.BackColor = System.Drawing.Color.White;
            this.EditClientBtn.Enabled = false;
            this.EditClientBtn.Location = new System.Drawing.Point(103, 19);
            this.EditClientBtn.Name = "EditClientBtn";
            this.EditClientBtn.Size = new System.Drawing.Size(91, 23);
            this.EditClientBtn.TabIndex = 3;
            this.EditClientBtn.Text = "Edit Client";
            this.ShortcutToolTip.SetToolTip(this.EditClientBtn, "Alt + E");
            this.EditClientBtn.UseVisualStyleBackColor = false;
            this.EditClientBtn.Click += new System.EventHandler(this.EditClientBtn_Click);
            // 
            // EditExtraOptionBtn
            // 
            this.EditExtraOptionBtn.BackColor = System.Drawing.Color.White;
            this.EditExtraOptionBtn.Enabled = false;
            this.EditExtraOptionBtn.Location = new System.Drawing.Point(103, 19);
            this.EditExtraOptionBtn.Name = "EditExtraOptionBtn";
            this.EditExtraOptionBtn.Size = new System.Drawing.Size(91, 40);
            this.EditExtraOptionBtn.TabIndex = 5;
            this.EditExtraOptionBtn.Text = "Edit Extra Option";
            this.ShortcutToolTip.SetToolTip(this.EditExtraOptionBtn, "Ctrl + Alt + E");
            this.EditExtraOptionBtn.UseVisualStyleBackColor = false;
            this.EditExtraOptionBtn.Click += new System.EventHandler(this.EditExtraOptionBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteClientBtn);
            this.groupBox1.Controls.Add(this.AddClientBtn);
            this.groupBox1.Controls.Add(this.EditClientBtn);
            this.groupBox1.Location = new System.Drawing.Point(6, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 50);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Management";
            // 
            // DeleteClientBtn
            // 
            this.DeleteClientBtn.BackColor = System.Drawing.Color.White;
            this.DeleteClientBtn.Enabled = false;
            this.DeleteClientBtn.Location = new System.Drawing.Point(200, 19);
            this.DeleteClientBtn.Name = "DeleteClientBtn";
            this.DeleteClientBtn.Size = new System.Drawing.Size(91, 23);
            this.DeleteClientBtn.TabIndex = 4;
            this.DeleteClientBtn.Text = "Delete Client";
            this.ShortcutToolTip.SetToolTip(this.DeleteClientBtn, "Alt + D");
            this.DeleteClientBtn.UseVisualStyleBackColor = false;
            this.DeleteClientBtn.Click += new System.EventHandler(this.DeleteClientBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteExtraOptionBtn);
            this.groupBox2.Controls.Add(this.AddExtraOptionBtn);
            this.groupBox2.Controls.Add(this.EditExtraOptionBtn);
            this.groupBox2.Location = new System.Drawing.Point(6, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 68);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extra Option Management";
            // 
            // DeleteExtraOptionBtn
            // 
            this.DeleteExtraOptionBtn.BackColor = System.Drawing.Color.White;
            this.DeleteExtraOptionBtn.Enabled = false;
            this.DeleteExtraOptionBtn.Location = new System.Drawing.Point(200, 19);
            this.DeleteExtraOptionBtn.Name = "DeleteExtraOptionBtn";
            this.DeleteExtraOptionBtn.Size = new System.Drawing.Size(91, 40);
            this.DeleteExtraOptionBtn.TabIndex = 10;
            this.DeleteExtraOptionBtn.Text = "Delete Extra Option";
            this.ShortcutToolTip.SetToolTip(this.DeleteExtraOptionBtn, "Ctrl + Alt + D");
            this.DeleteExtraOptionBtn.UseVisualStyleBackColor = false;
            this.DeleteExtraOptionBtn.Click += new System.EventHandler(this.DeleteExtraOptionBtn_Click);
            // 
            // ToolStrip
            // 
            this.ToolStrip.BackColor = System.Drawing.SystemColors.Window;
            this.ToolStrip.CanOverflow = false;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportReportBtn,
            this.ViewStatisticsBtn,
            this.PrintBtn});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolStrip.Size = new System.Drawing.Size(307, 35);
            this.ToolStrip.Stretch = true;
            this.ToolStrip.TabIndex = 13;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // ExportReportBtn
            // 
            this.ExportReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExportReportBtn.Image")));
            this.ExportReportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportReportBtn.Name = "ExportReportBtn";
            this.ExportReportBtn.Size = new System.Drawing.Size(111, 32);
            this.ExportReportBtn.Text = "Export Report";
            this.ExportReportBtn.Click += new System.EventHandler(this.ExportReportBtn_Click);
            // 
            // ViewStatisticsBtn
            // 
            this.ViewStatisticsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ViewStatisticsBtn.Image")));
            this.ViewStatisticsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewStatisticsBtn.Name = "ViewStatisticsBtn";
            this.ViewStatisticsBtn.Size = new System.Drawing.Size(113, 32);
            this.ViewStatisticsBtn.Text = "View Statistics";
            this.ViewStatisticsBtn.Click += new System.EventHandler(this.ViewStatisticsBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrintBtn.Image")));
            this.PrintBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(64, 32);
            this.PrintBtn.Text = "Print";
            this.PrintBtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // TotalClientsStrip
            // 
            this.TotalClientsStrip.Name = "TotalClientsStrip";
            this.TotalClientsStrip.Size = new System.Drawing.Size(83, 17);
            this.TotalClientsStrip.Text = "Total Clients: 0";
            // 
            // TotalOptionsStrip
            // 
            this.TotalOptionsStrip.Name = "TotalOptionsStrip";
            this.TotalOptionsStrip.Size = new System.Drawing.Size(89, 17);
            this.TotalOptionsStrip.Text = "Total Options: 0";
            this.TotalOptionsStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TotalClientsStrip,
            this.TotalOptionsStrip});
            this.StatusStrip.Location = new System.Drawing.Point(0, 561);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(307, 22);
            this.StatusStrip.Stretch = false;
            this.StatusStrip.TabIndex = 12;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "report";
            this.saveFileDialog.Filter = "Text Files|*.txt";
            // 
            // ShortcutToolTip
            // 
            this.ShortcutToolTip.ToolTipTitle = "Shortcut";
            // 
            // editClientToolStripMenuItem
            // 
            this.editClientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editClientToolStripMenuItem.Image")));
            this.editClientToolStripMenuItem.Name = "editClientToolStripMenuItem";
            this.editClientToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.editClientToolStripMenuItem.Text = "Edit Client";
            this.editClientToolStripMenuItem.Click += new System.EventHandler(this.editClientToolStripMenuItem_Click);
            // 
            // addExtraOptionToolStripMenuItem
            // 
            this.addExtraOptionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addExtraOptionToolStripMenuItem.Image")));
            this.addExtraOptionToolStripMenuItem.Name = "addExtraOptionToolStripMenuItem";
            this.addExtraOptionToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.addExtraOptionToolStripMenuItem.Text = "Add Extra Option";
            this.addExtraOptionToolStripMenuItem.Click += new System.EventHandler(this.addExtraOptionToolStripMenuItem_Click);
            // 
            // deleteExtraOptionToolStripMenuItem
            // 
            this.deleteExtraOptionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteExtraOptionToolStripMenuItem.Image")));
            this.deleteExtraOptionToolStripMenuItem.Name = "deleteExtraOptionToolStripMenuItem";
            this.deleteExtraOptionToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.deleteExtraOptionToolStripMenuItem.Text = "Delete Extra Option";
            this.deleteExtraOptionToolStripMenuItem.Click += new System.EventHandler(this.deleteExtraOptionToolStripMenuItem_Click);
            // 
            // editExtraOptionToolStripMenuItem
            // 
            this.editExtraOptionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editExtraOptionToolStripMenuItem.Image")));
            this.editExtraOptionToolStripMenuItem.Name = "editExtraOptionToolStripMenuItem";
            this.editExtraOptionToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.editExtraOptionToolStripMenuItem.Text = "Edit Extra Option";
            this.editExtraOptionToolStripMenuItem.Click += new System.EventHandler(this.editExtraOptionToolStripMenuItem_Click);
            // 
            // deleteClientToolStripMenuItem
            // 
            this.deleteClientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteClientToolStripMenuItem.Image")));
            this.deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            this.deleteClientToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.deleteClientToolStripMenuItem.Text = "Delete Client";
            this.deleteClientToolStripMenuItem.Click += new System.EventHandler(this.deleteClientToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(307, 583);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClientsTreeView);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Management";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ContextMenuStrip.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView ClientsTreeView;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button AddClientBtn;
        private System.Windows.Forms.Button AddExtraOptionBtn;
        private System.Windows.Forms.Button EditClientBtn;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button EditExtraOptionBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteClientBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteExtraOptionBtn;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton ExportReportBtn;
        private System.Windows.Forms.ToolStripButton ViewStatisticsBtn;
        private System.Windows.Forms.ToolStripStatusLabel TotalClientsStrip;
        private System.Windows.Forms.ToolStripStatusLabel TotalOptionsStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem reloadViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolTip ShortcutToolTip;
        private System.Windows.Forms.ToolStripButton PrintBtn;
        private System.Windows.Forms.ToolStripMenuItem editClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExtraOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editExtraOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteExtraOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem;
    }
}

