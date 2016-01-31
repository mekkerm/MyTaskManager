using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTaskManager.Model;
using MyTaskManager.Controller;

namespace MyTaskManager
{
    public partial class MainForm : Form
    {
        private TaskController taskController = new TaskController();
        public MainForm()
        {
            InitializeComponent();
            OnLoad();
        }



        private void OnLoad()
        {

            taskListBox.DataSource = taskController.taskList;
            taskListBox.DisplayMember = taskController.DisplayMember();
            taskListBox.ValueMember = taskController.ValueMember();
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            notifIcon.BalloonTipTitle = "Minimize to Tray App";
            notifIcon.BalloonTipText = "You have successfully minimized your form.";

            if (FormWindowState.Minimized == this.WindowState)
            {
                notifIcon.Visible = true;
                notifIcon.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifIcon.Visible = false;
            }

        }

        private void notifIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;

        }

        private void taskListBox_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
