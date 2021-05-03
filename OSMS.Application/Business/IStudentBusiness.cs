using OSMS.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSMS.Application.Business
{
    public interface IStudentBusiness
    {
        IEnumerable<StudentViewModel> GetAllStudents();
        StudentViewModel CreateStudent(StudentViewModel model);
    }
}
