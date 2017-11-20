using System.Collections.Generic;

namespace AcademicSaaS.Models
{
    public class SectionStudent
    {
        public int Id { private set; get; }

        public int SectionId { private set; get; }

        public List<int> StudentIds { private set; get; }

        SectionStudent(int id, int sectionId, List<int> studentIds)
        {
            this.Id = id;
            this.SectionId = sectionId;
            this.StudentIds = studentIds;
        }
    }
}
