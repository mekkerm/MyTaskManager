using System;
using System.Windows.Forms;

namespace MyTaskManager
{
    using System.Runtime.InteropServices;
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
            this.notifIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.opacityScrollBar = new System.Windows.Forms.TrackBar();
            this.filterButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityScrollBar)).BeginInit();
            this.SuspendLayout();
            // 
            // notifIcon
            // 
            this.notifIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifIcon.Icon")));
            this.notifIcon.Text = "notifyIcon1";
            this.notifIcon.Visible = true;
            this.notifIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifIcon_MouseDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // taskListBox
            // 
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.Location = new System.Drawing.Point(17, 54);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(197, 615);
            this.taskListBox.TabIndex = 2;
            this.taskListBox.DoubleClick += new System.EventHandler(this.taskListBox_DoubleClick);
            // 
            // opacityScrollBar
            // 
            this.opacityScrollBar.Location = new System.Drawing.Point(19, 675);
            this.opacityScrollBar.Maximum = 100;
            this.opacityScrollBar.Minimum = 20;
            this.opacityScrollBar.Name = "opacityScrollBar";
            this.opacityScrollBar.Size = new System.Drawing.Size(197, 45);
            this.opacityScrollBar.TabIndex = 3;
            this.opacityScrollBar.Value = 100;
            this.opacityScrollBar.Scroll += new System.EventHandler(this.opacityScrollBar_Scroll);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(220, 28);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(27, 20);
            this.filterButton.TabIndex = 4;
            this.filterButton.Text = "F";
            this.filterButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(220, 54);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(27, 21);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "S";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 720);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.opacityScrollBar);
            this.Controls.Add(this.taskListBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MyTaskManager";
            this.TopMost = true;
            this.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MainForm_MouseLeave);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityScrollBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private NotifyIcon notifIcon;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ListBox taskListBox;
        private TrackBar opacityScrollBar;
        private Button filterButton;
        private Button settingsButton;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}

