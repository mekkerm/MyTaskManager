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
        private TaskController taskController = TaskController.Instance;
        private OpacityController opacityController;

        private Image startImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory.ToString() + @"images\Button-Play-icon4.png");
        private Image pauseImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory.ToString() + @"images\Button-Pause-icon4.png");

        private bool startEnabled = true;

        private TaskDetails detailsForm = null;

        public MainForm()
        {
            InitializeComponent();
            OnLoad();
            AllocConsole();

            
        }



        private void OnLoad()
        {
            taskListBox.BackColor = Color.FromArgb(129, 203, 40);
            taskListBox.DataSource = taskController.taskList;
            taskListBox.DisplayMember = taskController.DisplayMember();
            taskListBox.ValueMember = taskController.ValueMember();
            taskListBox.DrawMode = DrawMode.OwnerDrawVariable;
            taskListBox.DrawItem += new DrawItemEventHandler(taskListBox_DrawItem);
            taskListBox.ItemHeight = 25;

            opacityController = new OpacityController(this);

            DBController contr = new DBController();
            contr.execute("create Table Tasks");
        }

        private void taskListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Define the default color of the brush as black.
            Brush brush = Brushes.Black;
            
            var b = new RectangleF(e.Bounds.Location, e.Bounds.Size);
            b.Location = new PointF(b.Location.X + 150, b.Location.Y);

            var font = new Font(new FontFamily("Comic Sans MS"), 12 , FontStyle.Bold);

            // Draw the current item text based on the current Font 
            // and the custom brush settings.

            e.Graphics.DrawString(((Model.Task)taskListBox.Items[e.Index]).Title,
               font, brush, e.Bounds, StringFormat.GenericDefault);

            e.Graphics.DrawString(((Model.Task)taskListBox.Items[e.Index]).EllapsedTime.TotalSeconds.ToString()+" s",
                font, brush, b, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
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

            Model.Task clickedTask = (Model.Task)taskListBox.SelectedItem;

            MessageBox.Show(clickedTask.ID);
        }

        private void opacityScrollBar_Scroll(object sender, EventArgs e)
        {
            this.Opacity = (double)opacityScrollBar.Value/ (double)100;
        }

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 1;
            opacityController.StartShowing();
        }

        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
            if (!ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                opacityController.StartHiding();
            }
            else
            {
                this.Opacity = 1;
                opacityController.StartShowing();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewTaskButton_Click(object sender, EventArgs e)
        {
            NewTaskForm newTaskForm = new NewTaskForm();
            newTaskForm.Location = this.Location;

            newTaskForm.ShowDialog(this);
        }

        private void startPauseButton_Click(object sender, EventArgs e)
        {
            Model.Task selectedTask = (Model.Task)taskListBox.SelectedItem;
            if (startEnabled) {
                startPauseButton_Click(selectedTask);
            }
            else
            {
                pauseButton_Click();
            }  
        }

        private void startPauseButton_Click(Model.Task selectedTask)
        {
            Console.WriteLine("start clicked");
            start_pause_button.Image = pauseImage;
            startEnabled = false;
            if (taskController.StartTask(selectedTask, this, RefreshTaskPanel))
            {
                RefreshTaskPanel();
            }
        }

        private void RefreshTaskPanel()
        {
            var task = taskController.ActiveTask;
            taskTitleLabel.Text = task.Title;
            taskTimeLabel.Text = task.EllapsedTime.ToString();
            taskListBox.Refresh();


            //refresh the details form if is opened.
            if (detailsForm != null && !detailsForm.IsDisposed && detailsForm.DisplayedTask.ID.Equals(task.ID))
            {
                detailsForm.RefreshUI();
            }
        }

        private void pauseButton_Click()
        {
            Console.WriteLine("pause clicked");
            start_pause_button.Image = startImage;
            startEnabled = true;
            taskController.StopTask();
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            Model.Task selectedTask = (Model.Task)taskListBox.SelectedItem;
            detailsForm = new TaskDetails(selectedTask);
            detailsForm.ShowDialog(this);


        }
    }
}
