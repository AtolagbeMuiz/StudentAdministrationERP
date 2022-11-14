namespace StudentAdministrationERP.Interfaces
{
    public interface IModuleRepo
    {
        bool EnrolStudentForModule(string[] arrayofModuleCodes, string studentId);
    }
}
