using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTaskManager
{
    public partial class TaskDetails : Form
    {
        public Model.Task DisplayedTask { get { return task; } }

        private Model.Task task;
        public TaskDetails(Model.Task task)
        {
            InitializeComponent();
            creationDatePicker.Format = DateTimePickerFormat.Custom;
            creationDatePicker.CustomFormat = "MM'/'dd'/'yyyy hh':'mm tt";
            this.task = task;

            titleTextBox.Text = task.Title;
            descriptionTextBox.Text = task.Description;
            creationDatePicker.Value = task.CreationDate;
            elapsedTimeTextBox.Text = task.EllapsedTime.ToString();
        }

        public void RefreshUI()
        {
            elapsedTimeTextBox.Text = task.EllapsedTime.ToString();
        }
    }
}
