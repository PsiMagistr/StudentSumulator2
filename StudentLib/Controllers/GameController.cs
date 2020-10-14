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
            if (City[finish.Y, finish.X].WaveIndex > 0)
            {
                return false;
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
                    if(satellites[i].X + 1 < City.CameraWidth && City[satellites[i].Y, satellites[i].X + 1].Passability == true && City[satellites[i].Y, satellites[i].X + 1].WaveIndex == 0)
                    {
                        temp.Add(new Point(satellites[i].X + 1, satellites[i].Y));
                        City[satellites[i].Y, satellites[i].X + 1].WaveIndex = counter;
                        if (satellites[i].X + 1 == finish.X && satellites[i].Y == finish.Y)
                        {
                            City[CurrentStudent.Position.Y, CurrentStudent.Position.X].WaveIndex = 0;
                            return true;
                        }
                    }

                    if (satellites[i].X - 1 > -1 && City[satellites[i].Y, satellites[i].X - 1].WaveIndex == 0 && City[satellites[i].Y, satellites[i].X - 1].Passability == true)
                    {
                        temp.Add(new Point(satellites[i].X - 1, satellites[i].Y));
                        City[satellites[i].Y, satellites[i].X - 1].WaveIndex = counter;
                        if (satellites[i].X - 1 == finish.X && satellites[i].Y == finish.Y)
                        {
                            City[CurrentStudent.Position.Y, CurrentStudent.Position.X].WaveIndex = 0;
                            return true;
                        }
                    }

                    if (satellites[i].Y + 1 < City.Height && City[satellites[i].Y + 1, satellites[i].X].WaveIndex == 0 && City[satellites[i].Y + 1, satellites[i].X].Passability == true)
                    {
                        temp.Add(new Point(satellites[i].X, satellites[i].Y + 1));
                        City[satellites[i].Y + 1, satellites[i].X].WaveIndex = counter;
                        if (satellites[i].X == finish.X && satellites[i].Y + 1 == finish.Y)
                        {
                            City[CurrentStudent.Position.Y, CurrentStudent.Position.X].WaveIndex = 0;
                            return true;
                        }
                    }

                    if (satellites[i].Y - 1 > -1 && City[satellites[i].Y - 1, satellites[i].X].WaveIndex == 0 && City[satellites[i].Y - 1, satellites[i].X].Passability == true)
                    {
                        temp.Add(new Point(satellites[i].X, satellites[i].Y - 1));
                        City[satellites[i].Y - 1, satellites[i].X].WaveIndex = counter;
                        if (satellites[i].X == finish.X && satellites[i].Y - 1 == finish.Y)
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
            MessageBox.Show("g");
            return false;
        }        
        
    }
}
