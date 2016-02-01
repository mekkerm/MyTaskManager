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
using System.Timers;

namespace MyTaskManager
{
    public partial class MainForm : Form
    {
        private bool mouseIn;
        private TaskController taskController = new TaskController();
        private OpacityController opacityController;
        public MainForm()
        {
            InitializeComponent();
            OnLoad();
            AllocConsole();
        }



        private void OnLoad()
        {

            taskListBox.DataSource = taskController.taskList;
            taskListBox.DisplayMember = taskController.DisplayMember();
            taskListBox.ValueMember = taskController.ValueMember();

            opacityController = new OpacityController(this);
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

        private void opacityScrollBar_Scroll(object sender, EventArgs e)
        {
            this.Opacity = (double)opacityScrollBar.Value/ (double)100;
        }

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 1;
            opacityController.StartShowing();
            Console.WriteLine("Mouse entered..");

        }

        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
            if (!ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                mouseIn = false;
                opacityController.StartHiding();
                Console.WriteLine("MouseLeaved..");
            }
            else
            {
                this.Opacity = 1;
                opacityController.StartShowing();
                Console.WriteLine("Mouse entered..");
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
