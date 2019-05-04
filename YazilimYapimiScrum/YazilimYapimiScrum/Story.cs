using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimYapimiScrum
{
   public class Story
    {
        public List<Task> TaskJourney = new List<Task>();

        public string StoryTitle { get; set; }

        public string StoryAuthor { get; set; }

        public string StoryDescription { get; set; }

        public DateTime CreationTime { get; set; }

        public Story()
        {

        }

        public void TaskCreator(Task task)
        {
            TaskJourney.Add(task);
        }

    }
}
