using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Repos.DTO
{
    public class UpdateDepartmentDto
    {
        public int Id { get; set; }  // Required for EF Core tracking
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
