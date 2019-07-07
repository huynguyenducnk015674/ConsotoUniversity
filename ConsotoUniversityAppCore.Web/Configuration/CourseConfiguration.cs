using ConsotoUniversityAppCore.Web.Extensions;
using ConsotoUniversityAppCore.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsotoUniversityAppCore.Web.Configuration
{
    public class CourseConfiguration : DbEntityConfiguration<Course>
    {
        public override void Configure(EntityTypeBuilder<Course> entity)
        {
            entity.Property(c => c.Crt_User).HasMaxLength(10);
            entity.ToTable("Course");
        }
    }
}
