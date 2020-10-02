using StudentLib.classes;
using StudentLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLib.Controllers
{
    [Serializable]
    public class StudentController:Saver
    {
        public List<Student> Students { get; private set; }
        public StudentController()
        {
            Load();           
        }

        public void Load()
        {
            Students = Load<List<Student>>("students.dat");
            if (Students == null)
            {
                Students = new List<Student>();
            }
        }

        private void Save()
        {
            Save("students.dat", Students);
        }

        public void Add(Student student)
        {
            if (Students.SingleOrDefault(s => s.Name == student.Name) == null)
            {
                Students.Add(student);
                Save();
            }
            else
            {
                throw new Exception("Такой студент уже есть!");
            }
           
        }

        public void Remove(String studentname)
        {
            Student student = Students.SingleOrDefault(s => s.Name == studentname);
            if (student != null)
            {
                Students.Remove(student);
                Save();
            }           
        }
    }
}
