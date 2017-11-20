using Newtonsoft.Json;

namespace AcademicSaaS.Models.Request
{
    public class SectionRequest : ApiRequest
    {
        [JsonProperty("schoolId")]
        public int SchoolId { get; set; }
    }
}
