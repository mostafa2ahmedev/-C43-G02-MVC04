﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Models
{
    public class Department : ModelBase
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        public string? Description { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }
    }
}
