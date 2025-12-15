using SimpleTaskManager.Application.Database;
using SimpleTaskManager.Communication.Response;

namespace SimpleTaskManager.Application.UseCase.Task
{
    public class GetByIdTaskUseCase : DatabaseTableTask
    {
        public ResponseFullTaskJson Execute(Guid id)
        {
            var responseTask = Tasks.Find(task => task.Id == id);

            if (responseTask == null)
                return null;

            var response = new ResponseFullTaskJson
            {
                Id = responseTask.Id,
                Name = responseTask.Name,
                Description = responseTask.Description,
                DueDate = responseTask.DueDate,
                Priority = responseTask.Priority,
                Status = responseTask.Status
            };
            return response;
        }
    }
}
