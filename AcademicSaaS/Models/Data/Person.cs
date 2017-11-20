namespace AcademicSaaS.Models
{
    public enum Role { Admin, Principal, Teacher, Student };

    public class Person
    {
        public int Id { private set; get; }

        public string Name { private set; get; }

        public Role Role { private set; get; }

        public int SchoolId { private set; get; }

        public Person(int id, string name, Role role, int schoolId)
        {
            this.Id = id;
            this.Name = name;
            this.Role = role;
            this.SchoolId = schoolId;
        }
    }
}
