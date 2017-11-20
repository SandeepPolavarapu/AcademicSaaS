namespace AcademicSaaS.Repository
{
    public class SchoolRepository : ISchoolRepository
    {
        public bool CreateSchool()
        {
            return true;
        }

        public string[] GetSchoolList()
        {
            return new string[] { "name1", "name2" };
        }

        public string GetSchool(int id)
        {
            return "name1";
        }
    }
}
