using StudentLib.classes;
using StudentLib.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentLib.Controllers
{
    public class GameController:StudentController
    {
        
        public Student CurrentStudent { get; set; }
        public City City { get; set; }
        public GameController(Student student, List<Student> students)
        {
            CurrentStudent = student;
            Students = students;
            City = Load<City>("test.dat");
        }
        
        public bool setWave(Point finish)
        {
            int Delta = CurrentStudent.Delta;
            for (int y = 0; y < City.Height; y++)
            {
                for (int x = 0; x < City.Width; x++)
                {
                    City[y, x].WaveIndex = 0; 
                }
            }
            List<Point> satellites = new List<Point>();
            List<Point> temp = new List<Point>();
            int counter = 0;
            satellites.Add(CurrentStudent.Position);           
            while (satellites.Count > 0)
            {
                counter++;                
                temp.Clear();
                for (int i = 0; i < satellites.Count; i++)
                {
                    Point delta = new Point(satellites[i].X + Delta, satellites[i].Y);
                    if(satellites[i].X + 1 < City.CameraWidth + Delta && City[delta.Y, delta.X + 1].Passability == true && City[delta.Y, delta.X + 1].WaveIndex == 0)
                    {
                        temp.Add(new Point(satellites[i].X + 1, satellites[i].Y));
                        City[delta.Y, delta.X + 1].WaveIndex = counter /*- Delta*/;
                        if (delta.X + 1 == finish.X && delta.Y == finish.Y)
                        {
                            City[CurrentStudent.Position.Y, CurrentStudent.Position.X].WaveIndex = 0;
                            return true;
                        }
                    }

                    if (satellites[i].X - 1 + Delta > (Delta - 1) && City[delta.Y, delta.X - 1].WaveIndex == 0 && City[delta.Y, delta.X - 1].Passability == true)
                    {
                        //MessageBox.Show((satellites[0].X).ToString());
                        temp.Add(new Point(satellites[i].X - 1, satellites[i].Y));
                        City[delta.Y, delta.X - 1].WaveIndex = counter;
                        if (delta.X - 1 == finish.X && delta.Y == finish.Y)
                        {
                            City[CurrentStudent.Position.Y, CurrentStudent.Position.X].WaveIndex = 0;
                            return true;
                        }
                    }

                    if (satellites[i].Y + 1 < City.Height && City[delta.Y + 1, delta.X].WaveIndex == 0 && City[delta.Y + 1, delta.X].Passability == true)
                    {
                        temp.Add(new Point(satellites[i].X, satellites[i].Y + 1));
                        City[delta.Y + 1, delta.X].WaveIndex = counter;
                        if (delta.X == finish.X && delta.Y + 1 == finish.Y)
                        {
                            City[CurrentStudent.Position.Y, CurrentStudent.Position.X].WaveIndex = 0;
                            return true;
                        }
                    }

                    if (satellites[i].Y - 1 > -1 && City[delta.Y - 1, delta.X].WaveIndex == 0 && City[delta.Y - 1, delta.X].Passability == true)
                    {
                        temp.Add(new Point(satellites[i].X, satellites[i].Y - 1));
                        City[delta.Y - 1, delta.X].WaveIndex = counter;
                        if (delta.X == finish.X && delta.Y - 1 == finish.Y)
                        {
                            City[CurrentStudent.Position.Y, CurrentStudent.Position.X].WaveIndex = 0;
                            return true;
                        }
                    }
                }
                  satellites.Clear();
                  for (int j = 0; j < temp.Count; j++)
                  {
                      satellites.Add(temp[j]);
                  }                
            }           
            return false;
        }        
        
    }
}
