using IKEA.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Repos
{
    public interface IDepartmentRepository
    {
        IQueryable<Department> GetAllAsQueryable();  // For optimized queries
        Department GetById(int id);
        void Add(Department department);
        void Update(Department department);
        void Delete(Department department);
        int SaveChanges();
    }
}
