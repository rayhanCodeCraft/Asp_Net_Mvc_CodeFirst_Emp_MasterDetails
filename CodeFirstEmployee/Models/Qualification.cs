﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstEmployee.Models
{
    public partial class Qualification
    {
        public int QualificationId { get; set; }
        public string QualifcationName { get; set; }
        public virtual ICollection<QualificationEntry>QualificationEntries { get; set; } 

    }
}