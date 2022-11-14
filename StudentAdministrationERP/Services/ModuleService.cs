using StudentAdministrationERP.Interfaces;

namespace StudentAdministrationERP.Services
{
    public class ModuleService : IModuleService
    {
        private IModuleRepo _moduleRepo;
        public ModuleService(IModuleRepo moduleRepo)
        {
            _moduleRepo = moduleRepo;
        }

        public bool EnrolStudentForModule(string[] arrayofModuleCodes, string studentId)
        {
            var isEnrolled = _moduleRepo.EnrolStudentForModule(arrayofModuleCodes, studentId);

            if (isEnrolled)
            {
                return true;
            }
            return false;

        }
    }
}
