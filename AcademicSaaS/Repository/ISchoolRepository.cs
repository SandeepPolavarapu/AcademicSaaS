namespace AcademicSaaS.Repository
{
    public interface ISchoolRepository
    {
        bool CreateSchool();

        string[] GetSchoolList();

        string GetSchool(int id);
    }
}
