using SimpleTaskManager.Communication.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskManager.Communication.Requests
{
    public class RequestUpdateTask
    {
        public string? Name { get; set; } = string.Empty;

        public string? Description { get; set; } = string.Empty;

        [EnumDataType(typeof(TaskPriority))]
        public TaskPriority? Priority { get; set; }

        public DateTime? DueDate { get; set; }

        [EnumDataType(typeof(TaskTypeStatus))]
        public TaskTypeStatus? Status { get; set; }

    }
}
