using OSMS.Application.Entities;
using OSMS.Domain.Services.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSMS.Application.Business
{
    public class StudentBusiness : IStudentBusiness
    {
        private readonly IStudentManager studentManager;
        public StudentBusiness(IStudentManager studentManager)
        {
            this.studentManager = studentManager;
        }

        public StudentViewModel CreateStudent(StudentViewModel model)
        {
            studentManager.Create(new Infrastructure.DataEntities.Student
            {
                Address = model.Address,
                CreatedBy = model.CreatedBy,
                CreatedDate = DateTime.Now,
                EmailID = model.EmailID,
                EnrollmentNo = model.EnrollmentNo,
                FirstName = model.FirstName,
                LastName = model.LastName,
                MiddleName = model.MiddleName,
                ModifiedBy = model.ModifiedBy,
            });
            studentManager.SaveChanges();
            return model;
        }

        public IEnumerable<StudentViewModel> GetAllStudents()
        {
            List<StudentViewModel> studentViewModels = new List<StudentViewModel>();
            var result = studentManager.GetAll();
            foreach (var item in result)
            {
                studentViewModels.Add(new StudentViewModel
                {
                    StudentId = item.StudentId,
                    EmailID = item.EmailID,
                    MiddleName = item.MiddleName,
                    LastName = item.LastName,
                    FirstName = item.FirstName,
                    CreatedDate = item.CreatedDate,
                    CreatedBy = item.CreatedBy,
                    Address = item.Address,
                    EnrollmentNo = item.EnrollmentNo
                });

            }
            return studentViewModels;
        }
    }
}
