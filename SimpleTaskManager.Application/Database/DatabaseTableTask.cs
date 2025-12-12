using SimpleTaskManager.Communication.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskManager.Application.Database
{
    public class DatabaseTableTask
    {
        protected static List<RequestTaskJson> Tasks { get; set; } = [];

        public DatabaseTableTask() 
        {
            Tasks = new List<RequestTaskJson>();
        }
    }
}
