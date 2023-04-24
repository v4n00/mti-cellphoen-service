﻿namespace Cellphone_Service
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
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reloadViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteClientBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteExtraOptionBtn = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.ExportReportBtn = new System.Windows.Forms.ToolStripButton();
            this.ViewStatisticsBtn = new System.Windows.Forms.ToolStripButton();
            this.TotalClientsStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.TotalOptionsStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ShortcutToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientsTreeView
            // 
            this.ClientsTreeView.ContextMenuStrip = this.contextMenuStrip;
            this.ClientsTreeView.Location = new System.Drawing.Point(15, 362);
            this.ClientsTreeView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ClientsTreeView.Name = "ClientsTreeView";
            this.ClientsTreeView.Size = new System.Drawing.Size(565, 598);
            this.ClientsTreeView.TabIndex = 0;
            this.ClientsTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ClientsTreeView_NodeMouseClick);
            this.ClientsTreeView.Leave += new System.EventHandler(this.ClientsTreeView_Leave);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadViewToolStripMenuItem,
            this.addClientToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(212, 76);
            // 
            // reloadViewToolStripMenuItem
            // 
            this.reloadViewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloadViewToolStripMenuItem.Image")));
            this.reloadViewToolStripMenuItem.Name = "reloadViewToolStripMenuItem";
            this.reloadViewToolStripMenuItem.Size = new System.Drawing.Size(211, 36);
            this.reloadViewToolStripMenuItem.Text = "Reload View";
            this.reloadViewToolStripMenuItem.Click += new System.EventHandler(this.reloadViewToolStripMenuItem_Click);
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addClientToolStripMenuItem.Image")));
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(211, 36);
            this.addClientToolStripMenuItem.Text = "Add Client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(610, 42);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(231, 40);
            this.serializeToolStripMenuItem.Text = "Serialize";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(231, 40);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(231, 40);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(88, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // AddClientBtn
            // 
            this.AddClientBtn.Location = new System.Drawing.Point(11, 35);
            this.AddClientBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AddClientBtn.Name = "AddClientBtn";
            this.AddClientBtn.Size = new System.Drawing.Size(167, 42);
            this.AddClientBtn.TabIndex = 2;
            this.AddClientBtn.Text = "Add Client";
            this.ShortcutToolTip.SetToolTip(this.AddClientBtn, "Alt + A");
            this.AddClientBtn.UseVisualStyleBackColor = true;
            this.AddClientBtn.Click += new System.EventHandler(this.AddClientBtn_Click);
            // 
            // AddExtraOptionBtn
            // 
            this.AddExtraOptionBtn.Enabled = false;
            this.AddExtraOptionBtn.Location = new System.Drawing.Point(11, 35);
            this.AddExtraOptionBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AddExtraOptionBtn.Name = "AddExtraOptionBtn";
            this.AddExtraOptionBtn.Size = new System.Drawing.Size(145, 96);
            this.AddExtraOptionBtn.TabIndex = 4;
            this.AddExtraOptionBtn.Text = "Add Extra Option";
            this.ShortcutToolTip.SetToolTip(this.AddExtraOptionBtn, "Ctrl + Alt + A");
            this.AddExtraOptionBtn.UseVisualStyleBackColor = true;
            this.AddExtraOptionBtn.Click += new System.EventHandler(this.AddExtraOptionBtn_Click);
            // 
            // EditClientBtn
            // 
            this.EditClientBtn.Enabled = false;
            this.EditClientBtn.Location = new System.Drawing.Point(189, 35);
            this.EditClientBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EditClientBtn.Name = "EditClientBtn";
            this.EditClientBtn.Size = new System.Drawing.Size(167, 42);
            this.EditClientBtn.TabIndex = 3;
            this.EditClientBtn.Text = "Edit Client";
            this.ShortcutToolTip.SetToolTip(this.EditClientBtn, "Alt + E");
            this.EditClientBtn.UseVisualStyleBackColor = true;
            this.EditClientBtn.Click += new System.EventHandler(this.EditClientBtn_Click);
            // 
            // EditExtraOptionBtn
            // 
            this.EditExtraOptionBtn.Enabled = false;
            this.EditExtraOptionBtn.Location = new System.Drawing.Point(167, 35);
            this.EditExtraOptionBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EditExtraOptionBtn.Name = "EditExtraOptionBtn";
            this.EditExtraOptionBtn.Size = new System.Drawing.Size(145, 96);
            this.EditExtraOptionBtn.TabIndex = 5;
            this.EditExtraOptionBtn.Text = "Edit Extra Option";
            this.ShortcutToolTip.SetToolTip(this.EditExtraOptionBtn, "Ctrl + Alt + E");
            this.EditExtraOptionBtn.UseVisualStyleBackColor = true;
            this.EditExtraOptionBtn.Click += new System.EventHandler(this.EditExtraOptionBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteClientBtn);
            this.groupBox1.Controls.Add(this.AddClientBtn);
            this.groupBox1.Controls.Add(this.EditClientBtn);
            this.groupBox1.Location = new System.Drawing.Point(11, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(572, 92);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Management";
            // 
            // DeleteClientBtn
            // 
            this.DeleteClientBtn.Enabled = false;
            this.DeleteClientBtn.Location = new System.Drawing.Point(367, 35);
            this.DeleteClientBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DeleteClientBtn.Name = "DeleteClientBtn";
            this.DeleteClientBtn.Size = new System.Drawing.Size(167, 42);
            this.DeleteClientBtn.TabIndex = 4;
            this.DeleteClientBtn.Text = "Delete Client";
            this.ShortcutToolTip.SetToolTip(this.DeleteClientBtn, "Alt + D");
            this.DeleteClientBtn.UseVisualStyleBackColor = true;
            this.DeleteClientBtn.Click += new System.EventHandler(this.DeleteClientBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteExtraOptionBtn);
            this.groupBox2.Controls.Add(this.AddExtraOptionBtn);
            this.groupBox2.Controls.Add(this.EditExtraOptionBtn);
            this.groupBox2.Location = new System.Drawing.Point(11, 199);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(572, 151);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extra Option Management";
            // 
            // DeleteExtraOptionBtn
            // 
            this.DeleteExtraOptionBtn.Enabled = false;
            this.DeleteExtraOptionBtn.Location = new System.Drawing.Point(323, 35);
            this.DeleteExtraOptionBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DeleteExtraOptionBtn.Name = "DeleteExtraOptionBtn";
            this.DeleteExtraOptionBtn.Size = new System.Drawing.Size(145, 96);
            this.DeleteExtraOptionBtn.TabIndex = 10;
            this.DeleteExtraOptionBtn.Text = "Delete Extra Option";
            this.ShortcutToolTip.SetToolTip(this.DeleteExtraOptionBtn, "Ctrl + Alt + D");
            this.DeleteExtraOptionBtn.UseVisualStyleBackColor = true;
            this.DeleteExtraOptionBtn.Click += new System.EventHandler(this.DeleteExtraOptionBtn_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.Window;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportReportBtn,
            this.ViewStatisticsBtn});
            this.toolStrip.Location = new System.Drawing.Point(0, 42);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(610, 40);
            this.toolStrip.TabIndex = 13;
            this.toolStrip.Text = "toolStrip1";
            // 
            // ExportReportBtn
            // 
            this.ExportReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExportReportBtn.Image")));
            this.ExportReportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportReportBtn.Name = "ExportReportBtn";
            this.ExportReportBtn.Size = new System.Drawing.Size(171, 34);
            this.ExportReportBtn.Text = "Export Report";
            this.ExportReportBtn.Click += new System.EventHandler(this.ExportReportBtn_Click);
            // 
            // ViewStatisticsBtn
            // 
            this.ViewStatisticsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ViewStatisticsBtn.Image")));
            this.ViewStatisticsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewStatisticsBtn.Name = "ViewStatisticsBtn";
            this.ViewStatisticsBtn.Size = new System.Drawing.Size(175, 34);
            this.ViewStatisticsBtn.Text = "View Statistics";
            this.ViewStatisticsBtn.Click += new System.EventHandler(this.ViewStatisticsBtn_Click);
            // 
            // TotalClientsStrip
            // 
            this.TotalClientsStrip.Name = "TotalClientsStrip";
            this.TotalClientsStrip.Size = new System.Drawing.Size(147, 30);
            this.TotalClientsStrip.Text = "Total Clients: 0";
            // 
            // TotalOptionsStrip
            // 
            this.TotalOptionsStrip.Name = "TotalOptionsStrip";
            this.TotalOptionsStrip.Size = new System.Drawing.Size(158, 30);
            this.TotalOptionsStrip.Text = "Total Options: 0";
            this.TotalOptionsStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TotalClientsStrip,
            this.TotalOptionsStrip});
            this.statusStrip.Location = new System.Drawing.Point(0, 1000);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 26, 0);
            this.statusStrip.Size = new System.Drawing.Size(610, 39);
            this.statusStrip.Stretch = false;
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "statusStrip1";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(610, 1039);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClientsTreeView);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Customer Management";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteClientBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteExtraOptionBtn;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton ExportReportBtn;
        private System.Windows.Forms.ToolStripButton ViewStatisticsBtn;
        private System.Windows.Forms.ToolStripStatusLabel TotalClientsStrip;
        private System.Windows.Forms.ToolStripStatusLabel TotalOptionsStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem reloadViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolTip ShortcutToolTip;
    }
}

