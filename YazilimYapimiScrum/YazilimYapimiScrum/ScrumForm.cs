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
    public partial class ScrumForm : Form
    {
        public TheBridge bridge;
        public StoryForm SF;
        public TaskForm TF;
        public DateTime ReturnBack { get; set; }
        public List<Button> Tasks;


        public ScrumForm()
        {
            Tasks = new List<Button>();
            bridge = new TheBridge();
            SF = new StoryForm();
            TF = new TaskForm();
            InitializeComponent();
            pnlToDo.AllowDrop = true;
            pnlInp.AllowDrop = true;
            pnlDone.AllowDrop = true;

        }

        public void ButtonControl()
        {
            for (int i = 0; i < Tasks.Count(); i++)
            {
                for (int j = i+1; j < Tasks.Count(); j++)
                {
                    if (Tasks[i].Text == Tasks[j].Text)
                    {
                        if (pnlDone.Controls.Contains(Tasks[i]) || pnlDone.Controls.Contains(Tasks[j]))
                        {
                            pnlToDo.Controls.Remove(Tasks[j]);
                        }
                        else if (pnlInp.Controls.Contains(Tasks[i]) || pnlInp.Controls.Contains(Tasks[j]))
                        {
                            pnlToDo.Controls.Remove(Tasks[j]);
                        }
                        else
                            continue;

                    }
                        

                }
            }
        }

        public void StoryAndTaskButtonCreator()
        {
            int top = 50;
            int top2 = 50;
            
            for (int i = 0; i < bridge.StoryBook.Count(); i++)
            {

                Button buttonStory = new Button();
                buttonStory.Text = bridge.StoryBook[i].StoryTitle;
                buttonStory.Width = 150;
                buttonStory.Height = 100;
                buttonStory.BackColor = System.Drawing.Color.White;
                buttonStory.Left = 50;
                buttonStory.Top = top;
                top += buttonStory.Height + 2;
                pnlStory.Controls.Add(buttonStory);
                buttonStory.Click += ButtonStory_Click;

                pnlToDo.DragEnter += PnlToDo_DragEnter;
                pnlInp.DragEnter += PnlInp_DragEnter;
                pnlDone.DragEnter += PnlDone_DragEnter;

                pnlToDo.DragDrop += PnlToDo_DragDrop;
                pnlInp.DragDrop += PnlInp_DragDrop;
                pnlDone.DragDrop += PnlDone_DragDrop;

                



                for (int j = 0; j < bridge.StoryBook[i].TaskJourney.Count(); j++)
                {
                    Button buttonTask = new Button();
                    buttonTask.Text = bridge.StoryBook[i].TaskJourney[j].TaskTitle;
                    buttonTask.Width = 120;
                    buttonTask.Height = (buttonStory.Height / bridge.StoryBook[i].TaskJourney.Count());
                    buttonTask.BackColor = System.Drawing.Color.White;
                    buttonTask.Left = 60;
                    buttonTask.Top = top2;
                    pnlToDo.Controls.Add(buttonTask);
                    top2 += buttonTask.Height;
                    buttonTask.Click += ButtonTask_Click;
                    buttonTask.MouseDown += ButtonTask_MouseDown;
                    Tasks.Add(buttonTask);

                }

            }
        }

        private void ButtonTask_MouseDown(object sender, MouseEventArgs e)
        {
            Button button2= (Button)sender;
            button2.DoDragDrop(button2, DragDropEffects.Move);

            if (pnlDone.Controls.Contains(button2))
            {
                for (int i = 0; i < bridge.StoryBook.Count(); i++)
                {
                    for (int j = 0; j < bridge.StoryBook[i].TaskJourney.Count(); j++)
                    {
                        if (button2.Text == bridge.StoryBook[i].TaskJourney[j].TaskTitle)
                        {
                            bridge.StoryBook[i].TaskJourney[j].EndTime = DateTime.Now;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < bridge.StoryBook.Count(); i++)
                {
                    for (int j = 0; j < bridge.StoryBook[i].TaskJourney.Count(); j++)
                    {
                        if (button2.Text == bridge.StoryBook[i].TaskJourney[j].TaskTitle)
                        {
                            bridge.StoryBook[i].TaskJourney[j].EndTime = ReturnBack;
                        }
                    }
                }
                
            }

            button2.PerformClick();
            
        }

        private void PnlDone_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;
        }

        private void PnlInp_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;
        }

        private void PnlToDo_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;
        }

        private void PnlDone_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void PnlInp_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void PnlToDo_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }


        private void ButtonTask_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string temp = "";
            for (int j = 0; j < bridge.StoryBook.Count(); j++)
            {
                for (int i = 0; i < bridge.StoryBook[j].TaskJourney.Count(); i++)
                {
                   
              if (b.Text == bridge.StoryBook[j].TaskJourney[i].TaskTitle)
                {

                    temp += "Task Title = " + bridge.StoryBook[j].TaskJourney[i].TaskTitle + Environment.NewLine + "Task Handler = " + bridge.StoryBook[j].TaskJourney[i].TaskHandler +
                            Environment.NewLine +"Task Creation Time = " + bridge.StoryBook[j].TaskJourney[i].CreationTime+Environment.NewLine+
                            "Forseen Deadline = " + bridge.StoryBook[j].TaskJourney[i].ForseenDeadline+Environment.NewLine +"End Time = "+ bridge.StoryBook[j].TaskJourney[i].EndTime+
                            Environment.NewLine+"Task Description = " + bridge.StoryBook[j].TaskJourney[i].TaskDescription;

                    break;
                }

                }
  

            }

            MessageBox.Show(temp);

        }

        private void ButtonStory_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            string temp = "";
                for (int j = 0; j < bridge.StoryBook.Count(); j++)
                {

                    if (b.Text == bridge.StoryBook[j].StoryTitle)
                    {
                        temp += "Story Title = " + bridge.StoryBook[j].StoryTitle + Environment.NewLine + "Story Author = " + bridge.StoryBook[j].StoryAuthor + Environment.NewLine +
                                "Story Creation Time = " + bridge.StoryBook[j].CreationTime + Environment.NewLine + "Story Description = " + bridge.StoryBook[j].StoryDescription;

                        break;
                    }
                    
                }

            MessageBox.Show(temp);
        }


        public void Closer()
        {
            SF.Close();
            TF.Close();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pnlStory.Visible = false;
            pnlToDo.Visible = false;
            pnlInp.Visible = false;
            pnlDone.Visible = false;
            lblStory.Visible = false;
            lblToDo.Visible = false;
            lblInp.Visible = false;
            lblDone.Visible = false;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            SF.Close();
            TF.Close();
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pnlStory.Visible = true;
            pnlToDo.Visible = true;
            pnlInp.Visible = true;
            pnlDone.Visible = true;
            lblStory.Visible = true;
            lblToDo.Visible = true;
            lblInp.Visible = true;
            lblDone.Visible = true;

            
            pnlToDo.Controls.Clear();
            StoryAndTaskButtonCreator();
            ButtonControl();


            if (pnlToDo.Visible==true)
            {
                btnShow.Enabled = false;
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Closer();
        }

        private void btnAddStory_Click(object sender, EventArgs e)
        {
            Closer();
            SF = new StoryForm();
            SF.MdiParent = this;
            SF.bridge = this.bridge;
            SF.Show();
            SF.BringToFront();
            SF.WindowState = FormWindowState.Maximized;
            btnShow.Enabled = true;


        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Closer();
            TF = new TaskForm();
            TF.MdiParent = this;
            TF.bridge = this.bridge;
            TF.Show();
            TF.BringToFront();
            TF.WindowState = FormWindowState.Maximized;
            btnShow.Enabled = true;
        }
    }
}
