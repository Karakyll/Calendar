using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Calendar
{
    public class Task
    {
        public Task()
        {

        }
        public Task(DateTime dateTime, string task)
        {
            this.dateTime = dateTime;
            this.task = task;
        }
        [XmlAttribute]
        public DateTime dateTime;
        [XmlAttribute]
        public string task;
    }
}
