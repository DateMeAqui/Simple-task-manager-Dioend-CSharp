using SimpleTaskManager.Communication.Enums;
using System.ComponentModel.DataAnnotations;

namespace SimpleTaskManager.Communication.Requests
{
    public class RequestTaskJson
    {
        [Required(ErrorMessage = "O name é obrigatório !")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo name deve ter entre 2 e 100 caracteres !" )]
        public string Name { get; set; } = string.Empty;

        [StringLength(500, MinimumLength = 2, ErrorMessage = "O campo descrição deve ter entre 2 e 500 caracteres !")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo propriedade é obrigatório")]
        [EnumDataType(typeof(TaskPriority))]
        public TaskPriority Priority {  get; set; }

        [Required(ErrorMessage = "O campo data é obrigatório")]
        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "O campo status é obrigatório")]
        [EnumDataType(typeof(TaskTypeStatus))]
        public TaskTypeStatus Status {  get; set; }

    }
}
