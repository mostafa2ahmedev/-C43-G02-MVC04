using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Repos.DTO
{
    public interface IDepartmentService
    {
        // 1. Get all departments (returns IEnumerable<DepartmentToReturnDto>)
        IEnumerable<DepartmentToReturnDto> GetAllDepartments();

        // 2. Get department by ID (returns DepartmentDetailsToReturnDto or null)
        DepartmentDetailsToReturnDto GetDepartmentById(int id);

        // 3. Create department (returns number of affected rows)
        int CreateDepartment(CreateDepartmentDto departmentDto);

        // 4. Update department (returns number of affected rows)
        int UpdateDepartment(UpdateDepartmentDto departmentDto);

        // 5. Delete department (returns boolean)
        bool DeleteDepartment(int id);
    }
}
