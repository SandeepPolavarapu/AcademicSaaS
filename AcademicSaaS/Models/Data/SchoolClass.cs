using System.Collections.Generic;

namespace AcademicSaaS.Models
{
    public class SchoolClass
    {
        public int Id { private set; get; }

        public int ClassId { private set; get; }

        public List<int> SectionIds { private set; get; }

        public List<int> SubjectIds { private set; get; }

        public int ClassTeacherId { private set; get; }

        SchoolClass(int id, int classId, List<int> sectionIds, List<int> subjectIds, int classTeacherId)
        {
            this.Id = id;
            this.ClassId = classId;
            this.SectionIds = sectionIds;
            this.SubjectIds = subjectIds;
            this.ClassTeacherId = classTeacherId;
        }
    }
}
