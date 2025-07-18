﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStudentSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [MaxLength(80)]
        public string Name { get; set; }

        public string? Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public decimal Price { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        public ICollection<Resource> Resources { get; set; } = new List<Resource>();
        public ICollection<Homework> Homeworks { get; set; } = new List<Homework>();
    }
}
