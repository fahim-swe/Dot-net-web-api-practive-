using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Task.Controllers
{
    public class Student
    {
        private static int idCounter = 0;

        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Institution {get; set;}
        public string dept {get; set;}

        public Student(string fn, string ln, string ins, string _dept)
        {
            idCounter++;
            Id = idCounter;
            FirstName = fn;
            LastName = ln;
            Institution = ins;
            dept = _dept;
        }
    }

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController: ControllerBase
    {
        
        public static List<Student> students = new List<Student>();
        static UsersController()
        {
            students.Add(new Student("Himel", "Ahmed", "SUST", "SWE"));
            students.Add(new Student("Sabit", "Islam", "SUST", "SWE"));
            students.Add(new Student("Muhammad", "Fahim", "SUST", "SWE"));
            students.Add(new Student("Apu", "Ahmed", "SUST", "EEE"));
            students.Add(new Student("Rafi", "Islam", "SUST", "CSE"));
            students.Add(new Student("Niloy", "Ahmed", "SUST", "CSE"));
        }

        [HttpGet]
        public IEnumerable<Student> GetUser()
        {
            return students;
        }

        
    }
}