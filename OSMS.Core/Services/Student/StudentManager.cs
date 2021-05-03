using OSMS.Infrastructure;
using OSMS.Infrastructure.DataRepository;

namespace OSMS.Domain.Services.Student
{
    public class StudentManager : EFGenericDataRepository<OSMS.Infrastructure.DataEntities.Student>, IStudentManager
    {
        public StudentManager(ApplicationDbContext context) : base(context)
        {

        }

    }
}
