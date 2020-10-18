using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLib.Models
{
    [Serializable]
    public class Student
    {
        public String Name { get;  set; }
        public int Delta { get; set; }
        public Point Position { get; set; }        
        public Student(String name)
        {            
            if (String.IsNullOrEmpty(name))
            {
                throw new Exception("Имя студента не может быть пустым.");            
            }
            Name = name;
            Delta = 0;
            Position = new Point(5, 1);
        }
        public void setPosX(int x)
        {
            Position = new Point(x, Position.Y);
        }
        public void setPosY(int y)
        {
            Position = new Point(Position.X, y);
        }
    }
}
