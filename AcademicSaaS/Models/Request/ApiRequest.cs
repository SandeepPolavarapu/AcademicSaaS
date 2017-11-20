using Newtonsoft.Json;

namespace AcademicSaaS.Models.Request
{
    public class ApiRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
