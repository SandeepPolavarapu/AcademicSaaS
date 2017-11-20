using Newtonsoft.Json;

namespace AcademicSaaS.Models.Request
{
    public class PersonRequest : ApiRequest
    {
        [JsonProperty("schoolId")]
        public int SchoolId { get; set; }

        [JsonProperty("role")]
        public Role Role { get; set; }
    }
}
