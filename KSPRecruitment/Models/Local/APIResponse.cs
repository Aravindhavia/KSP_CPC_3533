using System.Collections.Generic;

namespace KSPRecruitment.Models
{
    public class APIResponse
    {
        public bool Succeed { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public object Data { get; set; }
    }
}
