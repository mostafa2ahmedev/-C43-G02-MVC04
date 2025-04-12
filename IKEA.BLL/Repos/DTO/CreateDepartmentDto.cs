using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Repos.DTO
{
    public class CreateDepartmentDto
    {
        [Required(ErrorMessage = "Code is required.")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        public string Description { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;  // Default to UTC
    }
}
