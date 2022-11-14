namespace StudentAdministrationERP.Interfaces
{
    public interface IModuleService
    {
        bool EnrolStudentForModule(string[] arrayofModuleCodes, string studentId);
    }
}
