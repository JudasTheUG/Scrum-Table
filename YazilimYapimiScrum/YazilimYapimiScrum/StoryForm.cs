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
    public partial class StoryForm : Form
    {
        
        public TheBridge bridge;

        public StoryForm()
        {
            InitializeComponent();
        }

        private void btnCreateStory_Click(object sender, EventArgs e)
        {
            Story s = new Story();
            s.StoryTitle = txtStoryTitle.Text;
            s.StoryAuthor = txtAuthor.Text;
            s.StoryDescription = txtDescription.Text;
            s.CreationTime = DateTime.Now;
            bridge.StoryCreator(s);

            MessageBox.Show("The Story has been succesfully added");
        }
    }
}
