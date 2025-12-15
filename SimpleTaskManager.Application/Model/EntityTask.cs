using SimpleTaskManager.Communication.Enums;

namespace SimpleTaskManager.Application.Model
{
    public class EntityTask
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public string Priority { get; set; } = string.Empty;

        public DateTime DueDate { get; set; }
        public string Status { get; set; }
    }
}
