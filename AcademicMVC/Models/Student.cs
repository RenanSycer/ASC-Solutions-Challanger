using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AcademicMVC.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; internal set; }
        
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }
        
        [Required]
        public string GradesId { get; set; }
        
        
        public string Situation { get; set; }

        
        public Student()
        {
            
        }

        public Student(int studentId, string name, string gradesId, string situation)
        {
            StudentId = studentId;
            Name = name;
            GradesId = gradesId;
            Situation = situation;
        }
    }
}