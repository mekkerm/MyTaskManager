using MyTaskManager.Controller;
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
    public partial class NewTaskForm : Form
    {
        private TaskController controller = TaskController.Instance;
        private const string FIELD_REQUIRED = "This field is required!";
        public NewTaskForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleTextBox.Text.ToString()))
            {
                ShowError(titleTextBox, FIELD_REQUIRED);
                return;
            }
            
            HideError();
            string title = titleTextBox.Text.ToString();
            string description = descriptionTextBox.Text.ToString();

            var success = controller.Add(new Model.Task(title, description));
            if (!success)
            {
                MessageBox.Show("Add new task failed!");
                return;
            }

            this.Close();
            this.Dispose();
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            string str = titleTextBox.Text.ToString();
            if (string.IsNullOrEmpty(str))
            {
                ShowError(titleTextBox, FIELD_REQUIRED);
            }
            else
            {
                HideError();
            }
        }

        private void ShowError(Control ctr, string text)
        {
            errorProvider1.SetError(ctr, text);
        }

        private void HideError()
        {
            errorProvider1.Clear();
        }
    }
}
