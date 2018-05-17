﻿using System;
using System.Collections.Generic;

namespace HuddersfieldUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //If a navigation property can hold multiple entities (as in many-to-many or one-to-many relationships),
        //its type must be a list in which entries can be added, deleted, and updated, such as ICollection<T>.
        //You can specify ICollection<T> or a type such as List<T> or HashSet<T>.
        //If you specify ICollection<T>, EF creates a HashSet<T> collection by default.
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
