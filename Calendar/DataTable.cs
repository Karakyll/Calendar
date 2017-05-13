using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Calendar
{
    [Serializable]
    public class DataTable
    {
        private Dictionary<DateTime, string> _dataTable = new Dictionary<DateTime, string>();

        private XmlSerializer formatter = new XmlSerializer(typeof(Task[]), new XmlRootAttribute() { ElementName = "Tasks" });

        private string fileName;

        public DataTable()
        {
            
        }

        public void Assemble(string fileName)
        {
            this.fileName = fileName;
            Deserialize(fileName);
        }

        public void AddTask(DateTime dateTime, string task)
        {
            _dataTable.Add(dateTime, task);
        }
        
        public void DeleteTask(DateTime dateTime)
        {
            _dataTable.Remove(dateTime);
        }

        public Dictionary<DateTime, string> GetTasks()
        {
            return _dataTable;
        }

        public void Serialize()
        {
            FileStream fs = new FileStream(fileName, FileMode.Truncate);
            formatter.Serialize(fs, _dataTable.Select(kv => new Task() { dateTime = kv.Key, task = kv.Value }).ToArray());
            fs.Close();
        }

        private void Deserialize(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            if (fs.Length == 0)
            {
                fs.Close();
                return;
            }
            var orgDict = ((Task[])formatter.Deserialize(fs))
               .ToDictionary(i => i.dateTime, i => i.task);
            _dataTable = orgDict;
            fs.Close();
        }
    }
}
