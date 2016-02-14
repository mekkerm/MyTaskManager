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
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.opacityScrollBar = new System.Windows.Forms.TrackBar();
            this.addNewTaskButton = new System.Windows.Forms.Button();
            this.activeItemPanel = new System.Windows.Forms.Panel();
            this.taskTimeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taskTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.start_pause_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.opacityScrollBar)).BeginInit();
            this.activeItemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifIcon
            // 
            this.notifIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifIcon.BalloonTipText = "4324";
            this.notifIcon.BalloonTipTitle = "fds";
            this.notifIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifIcon.Icon")));
            this.notifIcon.Text = "notifyIcon1";
            this.notifIcon.Visible = true;
            this.notifIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifIcon_MouseDoubleClick);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(17, 122);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(243, 20);
            this.filterTextBox.TabIndex = 0;
            // 
            // taskListBox
            // 
            this.taskListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(204)))), ((int)(((byte)(40)))));
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.Location = new System.Drawing.Point(17, 146);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(243, 511);
            this.taskListBox.TabIndex = 2;
            this.taskListBox.DoubleClick += new System.EventHandler(this.taskListBox_DoubleClick);
            // 
            // opacityScrollBar
            // 
            this.opacityScrollBar.Location = new System.Drawing.Point(19, 658);
            this.opacityScrollBar.Maximum = 100;
            this.opacityScrollBar.Minimum = 20;
            this.opacityScrollBar.Name = "opacityScrollBar";
            this.opacityScrollBar.Size = new System.Drawing.Size(197, 45);
            this.opacityScrollBar.TabIndex = 3;
            this.opacityScrollBar.Value = 100;
            this.opacityScrollBar.Scroll += new System.EventHandler(this.opacityScrollBar_Scroll);
            // 
            // addNewTaskButton
            // 
            this.addNewTaskButton.FlatAppearance.BorderSize = 0;
            this.addNewTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewTaskButton.Image")));
            this.addNewTaskButton.Location = new System.Drawing.Point(17, 1);
            this.addNewTaskButton.Name = "addNewTaskButton";
            this.addNewTaskButton.Size = new System.Drawing.Size(34, 34);
            this.addNewTaskButton.TabIndex = 7;
            this.addNewTaskButton.UseVisualStyleBackColor = true;
            this.addNewTaskButton.Click += new System.EventHandler(this.addNewTaskButton_Click);
            // 
            // activeItemPanel
            // 
            this.activeItemPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.activeItemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activeItemPanel.Controls.Add(this.taskTimeLabel);
            this.activeItemPanel.Controls.Add(this.label2);
            this.activeItemPanel.Controls.Add(this.taskTitleLabel);
            this.activeItemPanel.Controls.Add(this.label1);
            this.activeItemPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeItemPanel.ForeColor = System.Drawing.Color.Black;
            this.activeItemPanel.Location = new System.Drawing.Point(17, 43);
            this.activeItemPanel.Name = "activeItemPanel";
            this.activeItemPanel.Padding = new System.Windows.Forms.Padding(2);
            this.activeItemPanel.Size = new System.Drawing.Size(243, 72);
            this.activeItemPanel.TabIndex = 8;
            // 
            // taskTimeLabel
            // 
            this.taskTimeLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTimeLabel.Location = new System.Drawing.Point(65, 40);
            this.taskTimeLabel.Name = "taskTimeLabel";
            this.taskTimeLabel.Size = new System.Drawing.Size(100, 23);
            this.taskTimeLabel.TabIndex = 11;
            this.taskTimeLabel.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Time:";
            // 
            // taskTitleLabel
            // 
            this.taskTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTitleLabel.Location = new System.Drawing.Point(65, 6);
            this.taskTitleLabel.Name = "taskTitleLabel";
            this.taskTitleLabel.Size = new System.Drawing.Size(100, 23);
            this.taskTitleLabel.TabIndex = 1;
            this.taskTitleLabel.Text = "TaskTitle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(216, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // start_pause_button
            // 
            this.start_pause_button.FlatAppearance.BorderSize = 0;
            this.start_pause_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_pause_button.Image = ((System.Drawing.Image)(resources.GetObject("start_pause_button.Image")));
            this.start_pause_button.Location = new System.Drawing.Point(86, 2);
            this.start_pause_button.Name = "start_pause_button";
            this.start_pause_button.Size = new System.Drawing.Size(34, 34);
            this.start_pause_button.TabIndex = 10;
            this.start_pause_button.UseVisualStyleBackColor = true;
            this.start_pause_button.Click += new System.EventHandler(this.startPauseButton_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(51, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 34);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // detailsButton
            // 
            this.detailsButton.FlatAppearance.BorderSize = 0;
            this.detailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailsButton.Image = ((System.Drawing.Image)(resources.GetObject("detailsButton.Image")));
            this.detailsButton.Location = new System.Drawing.Point(122, 2);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(34, 34);
            this.detailsButton.TabIndex = 11;
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 696);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.start_pause_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.activeItemPanel);
            this.Controls.Add(this.addNewTaskButton);
            this.Controls.Add(this.opacityScrollBar);
            this.Controls.Add(this.taskListBox);
            this.Controls.Add(this.filterTextBox);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MyTaskManager";
            this.TopMost = true;
            this.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MainForm_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.opacityScrollBar)).EndInit();
            this.activeItemPanel.ResumeLayout(false);
            this.activeItemPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        private TextBox filterTextBox;
        private ListBox taskListBox;
        private TrackBar opacityScrollBar;
        private Button addNewTaskButton;
        private Panel activeItemPanel;
        private Label label1;
        private Label taskTitleLabel;
        private Label label2;
        private Label taskTimeLabel;
        private Button button1;
        private Button start_pause_button;
        private Button button2;
        private Button detailsButton;
        private NotifyIcon notifIcon;
    }
}

