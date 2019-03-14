﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Resume_Builder.Models
{
    public class ProjectTeam
    {
        [Key]
        public int TeamId { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        //[System.ComponentModel.DataAnnotations.Schema.InverseProperty("Employee")]
        
        public Employee Employee { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        //[System.ComponentModel.DataAnnotations.Schema.InverseProperty("Project")]
        public Project Project { get; set; }
        public string Role { get; set; }
        public string EmployeeTech { get; set; }
    }
}