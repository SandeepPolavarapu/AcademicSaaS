namespace AcademicSaaS.Models
{
    public class School
    {
        public int Id { private set; get; }

        public string Name { private set; get; }

        public School(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
