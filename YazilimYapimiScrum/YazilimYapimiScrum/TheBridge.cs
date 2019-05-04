using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimYapimiScrum
{
   public class TheBridge
    {
        public List<Story> StoryBook = new List<Story>();


        public void StoryCreator(Story story)
        {
            StoryBook.Add(story);
        }

    }
}
