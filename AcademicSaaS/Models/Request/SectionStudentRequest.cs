using Newtonsoft.Json;
using System.Collections.Generic;

namespace AcademicSaaS.Models.Request
{
    public class SectionStudentRequest
    {
        [JsonProperty("sectiondId")]
        public int SectionId { get; set; }

        [JsonProperty("studentIds")]
        public List<int> StudentIds { get; set; }
    }
}
