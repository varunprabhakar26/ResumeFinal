using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume_Builder.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //public virtual ProjectTeam ProjectTeam { get; set; }

    }
}