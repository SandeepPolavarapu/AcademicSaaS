using Newtonsoft.Json;

namespace AcademicSaaS.Models.Request
{
    public class ClassRequest : ApiRequest
    {
        [JsonProperty("schoolId")]
        public int SchoolId { get; set; }
    }
}
