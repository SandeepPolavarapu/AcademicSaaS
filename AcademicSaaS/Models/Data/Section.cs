namespace AcademicSaaS.Models
{
    public class Section
    {
        public int Id { private set; get; }

        public string Name { private set; get; }

        public int SchoolId { private set; get; }

        Section(int id, string name, int schoolId)
        {
            this.Id = id;
            this.Name = name;
            this.SchoolId = schoolId;
        }
    }
}
