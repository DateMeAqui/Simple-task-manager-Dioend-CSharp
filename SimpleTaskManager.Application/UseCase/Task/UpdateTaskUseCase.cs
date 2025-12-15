using SimpleTaskManager.Application.Database;
using SimpleTaskManager.Communication.Requests;

namespace SimpleTaskManager.Application.UseCase.Task
{
    public class UpdateTaskUseCase : DatabaseTableTask
    {
        public void Execute(Guid id, RequestUpdateTask request)
        {
            var task = Tasks.Find(task => task.Id == id);
            if (task == null)
                throw new Exception("Task não encontrada");

            if (!string.IsNullOrWhiteSpace(request.Name))
                task.Name = request.Name;

            if (!string.IsNullOrWhiteSpace(request.Description))
                task.Description = request.Description;

            if (request.DueDate.HasValue)
                task.DueDate = request.DueDate.Value;

            if (request.Priority.HasValue)
                task.Priority = request.Priority.Value.ToString();

            if (request.Status.HasValue)
                task.Status = request.Status.Value.ToString();

        }
    }
}
