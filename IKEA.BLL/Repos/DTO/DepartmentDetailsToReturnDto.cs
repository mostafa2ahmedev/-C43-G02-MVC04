using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Repos.DTO
{
    public class DepartmentDetailsToReturnDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatedBy { get; set; }          // Added for details view
        public DateTime LastModifiedOn { get; set; }   // Added for details view
    }
}
