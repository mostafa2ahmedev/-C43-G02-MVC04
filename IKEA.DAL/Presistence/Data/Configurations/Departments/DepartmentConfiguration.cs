using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKEA.DAL.Models;

namespace IKEA.DAL.Presistence.Data.Configurations.Departments
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            // Table name
            builder.ToTable("Departments");

            // Primary Key
            builder.HasKey(d => d.Id);

            // Properties
            builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(d => d.Code)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(d => d.CreationDate)
                .IsRequired();

            // Computed column for "LastModifiedOn"
            builder.Property(d => d.LastModifiedOn)
                .HasComputedColumnSql("GETDATE()");

            // Default value for "CreatedOn"
            builder.Property(d => d.CreatedOn)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
