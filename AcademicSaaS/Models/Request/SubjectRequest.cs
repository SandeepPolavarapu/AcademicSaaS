using Newtonsoft.Json;

namespace AcademicSaaS.Models.Request
{
    public class SubjectRequest : ApiRequest
    {
        [JsonProperty("schoolId")]
        public int SchoolId { get; set; }
    }
}
