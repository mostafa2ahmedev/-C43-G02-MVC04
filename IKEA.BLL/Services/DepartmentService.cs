using IKEA.BLL.Repos.DTO;
using IKEA.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepo;

        public DepartmentService(IDepartmentRepository departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }

        // 1. Get all departments (manual mapping)
        public IEnumerable<DepartmentToReturnDto> GetAllDepartments()
        {
            var departments = _departmentRepo.GetAllAsQueryable();
            return departments.Select(dept => new DepartmentToReturnDto
            {
                Id = dept.Id,
                Code = dept.Code,
                Name = dept.Name,
                Description = dept.Description,
                CreationDate = dept.CreatedOn
            }).ToList();
        }

        // 2. Get department by ID (manual mapping)
        public DepartmentDetailsToReturnDto GetDepartmentById(int id)
        {
            var department = _departmentRepo.GetById(id);
            if (department == null) return null;

            return new DepartmentDetailsToReturnDto
            {
                Id = department.Id,
                Code = department.Code,
                Name = department.Name,
                Description = department.Description,
                CreationDate = department.CreatedOn,
                CreatedBy = department.CreatedBy,
                LastModifiedOn = department.LastModifiedOn
            };
        }

        // 3. Create department (manual mapping)
        public int CreateDepartment(CreateDepartmentDto dto)
        {
            var department = new Department
            {
                Code = dto.Code,
                Name = dto.Name,
                Description = dto.Description,
                CreatedOn = DateTime.UtcNow,
                CreatedBy = "System"  // Hardcoded for now
            };

            _departmentRepo.Add(department);
            return _departmentRepo.SaveChanges();  // Returns affected rows
        }

        // 5. Delete department
        public bool DeleteDepartment(int id)
        {
            var department = _departmentRepo.GetById(id);
            if (department == null) return false;

            _departmentRepo.Delete(department);
            return _departmentRepo.SaveChanges() > 0;
        }
    }
}
