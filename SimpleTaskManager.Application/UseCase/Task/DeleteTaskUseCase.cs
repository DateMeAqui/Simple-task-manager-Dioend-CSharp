using SimpleTaskManager.Application.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskManager.Application.UseCase.Task
{
    public class DeleteTaskUseCase : DatabaseTableTask
    {
        public void Execute(Guid id) 
        {

            var task = Tasks.Find(task => task.Id == id);
            if (task == null)
                throw new Exception("Tarefa nao encontrada !");

            Tasks.Remove(task);
        }
    }
}
