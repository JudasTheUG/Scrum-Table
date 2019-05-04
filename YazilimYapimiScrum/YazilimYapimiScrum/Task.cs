using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimYapimiScrum
{
    public class Task
    {
        public string TaskTitle { get; set; }

        public string TaskHandler { get; set; }

        public string TaskDescription { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime ForseenDeadline { get; set; }

        public DateTime EndTime { get; set; }

        public Task()
        {
        
        }
    }
}
