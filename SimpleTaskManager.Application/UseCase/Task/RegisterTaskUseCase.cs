using SimpleTaskManager.Application.Database;
using SimpleTaskManager.Application.Model;
using SimpleTaskManager.Communication.Requests;
using SimpleTaskManager.Communication.Response;

namespace SimpleTaskManager.Application.UseCase.Task
{
    public class RegisterTaskUseCase : DatabaseTableTask
    {
        public ResponseTaskJson Execute(RequestTaskJson request) 
        {
            var nowUtc = DateTime.UtcNow.Date;

            if (request.DueDate.ToUniversalTime().Date > nowUtc)
                throw new ArgumentException("A data de vencimento não pode ser maior que a data de hoje.");

            Console.WriteLine(request);
            var newTask = new EntityTask
            {
                Name = request.Name,
                Description = request.Description,
                Priority = request.Priority.ToString(),
                DueDate = request.DueDate,
                Status = request.Status.ToString(),
            };

            Tasks.Add(newTask);

            var response = new ResponseTaskJson
            {
                Id = newTask.Id,
                Name = request.Name,
            };
            return response;
        }
    }
}
