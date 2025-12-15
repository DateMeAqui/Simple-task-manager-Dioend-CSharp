using SimpleTaskManager.Application.Database;
using SimpleTaskManager.Communication.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskManager.Application.UseCase.Task
{
    public class GetAllTaskUseCase : DatabaseTableTask
    {
        public List<ResponseTaskJson> Execute()
        {
            List<ResponseTaskJson> responseTasks = new List<ResponseTaskJson>();
            var responseTaskJson = new ResponseTaskJson(); 

            foreach(var task in Tasks){
                responseTasks.Add(new ResponseTaskJson
                {
                    Id = task.Id,
                    Name = task.Name,
                });
            }
            return responseTasks;
        }
    }
}
