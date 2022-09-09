﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureManagement.Core.Entities
{
    public class Account : BaseEntity
    {
        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(100)]
        public string? FullName { get; set; }

        [StringLength(50)]
        public string? Email { get; set; }

        public string? Role { get; set; }
    }
}
