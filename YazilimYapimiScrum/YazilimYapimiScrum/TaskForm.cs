using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimYapimiScrum
{
    public partial class TaskForm : Form
    {

        public TheBridge bridge;

        public TaskForm()
        {
            InitializeComponent();
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < bridge.StoryBook.Count(); i++)
            {
                cbStory.Items.Add(bridge.StoryBook[i].StoryTitle.ToString());
            }
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bridge.StoryBook.Count(); i++)
            {
                if (bridge.StoryBook[i].StoryTitle==cbStory.SelectedItem.ToString())
                {
                    Task t = new Task();
                    t.TaskTitle = txtTaskTitle.Text;
                    t.TaskHandler = txtHandler.Text;
                    t.TaskDescription = txtDescription.Text;
                    t.CreationTime = DateTime.Now;
                    t.ForseenDeadline = Convert.ToDateTime(dtpFD.Value);
                    bridge.StoryBook[i].TaskCreator(t);
                }
            }
            MessageBox.Show("The Task has been succesfully added.");
        }
    }
}
