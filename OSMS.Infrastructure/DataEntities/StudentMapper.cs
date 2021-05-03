using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSMS.Infrastructure.DataEntities
{
    public class StudentMapper
    {
        public StudentMapper(EntityTypeBuilder<Student> entityBuilder)
        {
            entityBuilder.HasKey(c => c.StudentId);
            entityBuilder.Property(c => c.FirstName).IsRequired();
            entityBuilder.Property(c => c.LastName).IsRequired();



        }
    }
}
