using IKEA.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Repos.Depatment
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _context;

        public DepartmentRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Department> GetAllAsQueryable()
            => _context.Departments.AsQueryable();

        public Department GetById(int id)
            => _context.Departments.FirstOrDefault(dept => dept.Id == id);

        public void Add(Department department)
            => _context.Departments.Add(department);

        public int SaveChanges()
            => _context.SaveChanges();

        // Other methods...
    }
}
