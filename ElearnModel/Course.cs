﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Elearn_StaffJWT.ElearnModel
{
    public partial class Course
    {
        public Course()
        {
            Usercourses = new HashSet<Usercourse>();
        }

        public int Courseid { get; set; }
        public string Coursename { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double? Amount { get; set; }

        public virtual ICollection<Usercourse> Usercourses { get; set; }
    }
}
