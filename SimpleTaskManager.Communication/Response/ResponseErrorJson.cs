using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskManager.Communication.Response
{
    public class ResponseErrorJson
    {
        public List<string> Errors { get; set; }

        public ResponseErrorJson(string error)
        {
            Errors = new List<string> { error };
        }

        public ResponseErrorJson(List<string> errors)
        {
            Errors = errors;
        }
    }
}
