using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSMS.Infrastructure.DataEntities
{
    public class Student : BaseEntity
    {
        public int StudentId { get; set; }
        public string EnrollmentNo { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
        public string Address { get; set; }
    }
}
