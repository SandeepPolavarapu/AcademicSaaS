namespace AcademicSaaS.Models
{
    public class Subject
    {
        public int Id { private set; get; }

        public string Name { private set; get; }

        public int SchoolId { private set; get; }

        Subject(int id, string name, int schoolId)
        {
            this.Id = id;
            this.Name = name;
            this.SchoolId = schoolId;
        }
    }
}
