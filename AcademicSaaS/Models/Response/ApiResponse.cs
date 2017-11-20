using Newtonsoft.Json;

namespace AcademicSaaS.Models.Response
{
    public class ApiResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
