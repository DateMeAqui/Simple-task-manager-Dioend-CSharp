using System.Reflection.Metadata;

namespace SimpleTaskManager.Communication.Response
{
    public class ResponseTaskJson
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
