using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace SimpleTaskManager.Communication.Requests
{
    public class RequestTaskJson
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public string priority {  get; set; } = string.Empty;

        public DateTime dueDate { get; set; }
        public string status {  get; set; } = string.Empty;

    }
}
