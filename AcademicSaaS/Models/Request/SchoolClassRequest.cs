using Newtonsoft.Json;
using System.Collections.Generic;

namespace AcademicSaaS.Models.Request
{
    public class SchoolClassRequest
    {
        [JsonProperty("classId")]
        public int ClassId { get; set; }

        [JsonProperty("sectiondIds")]
        public List<int> SectiondIds { get; set; }

        [JsonProperty("subjectIds")]
        public List<int> SubjectIds { get; set; }

        [JsonProperty("classTeacherId")]
        public int ClassTeacherId { get; set; }
    }
}
