using OSMS.Infrastructure.DataRepository;

namespace OSMS.Domain.Services.Student
{
    public interface IStudentManager : IDataRepository<Infrastructure.DataEntities.Student>
    {
    }
}
