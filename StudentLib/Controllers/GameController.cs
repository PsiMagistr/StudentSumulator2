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
        public List<Point> Path { get; private set; } = new List<Point>();
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
                    if (City[y, x].Passability == true)
                    {
                        City[y, x].Color = Color.LimeGreen;
                    }
                    
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
                    if(satellites[i].X + 1 < City.CameraWidth /*+ Delta*/ && City[delta.Y, delta.X + 1].Passability == true && City[delta.Y, delta.X + 1].WaveIndex == 0)
                    {
                        temp.Add(new Point(satellites[i].X + 1, satellites[i].Y));
                        City[delta.Y, delta.X + 1].WaveIndex = counter /*- Delta*/;
                        if (delta.X + 1 == finish.X && delta.Y == finish.Y)
                        {
                            //City[delta.Y, delta.X].WaveIndex = 0;
                            City[CurrentStudent.Position.Y, CurrentStudent.Position.X + Delta].WaveIndex = 0;
                           // MessageBox.Show("Выход из волны. Х1");
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
                            // City[delta.Y, delta.X].WaveIndex = 0;
                            City[CurrentStudent.Position.Y, CurrentStudent.Position.X + Delta].WaveIndex = 0;
                            return true;
                        }
                    }

                    if (satellites[i].Y + 1 < City.Height && City[delta.Y + 1, delta.X].WaveIndex == 0 && City[delta.Y + 1, delta.X].Passability == true)
                    {
                        temp.Add(new Point(satellites[i].X, satellites[i].Y + 1));
                        City[delta.Y + 1, delta.X].WaveIndex = counter;
                        if (delta.X == finish.X && delta.Y + 1 == finish.Y)
                        {
                            City[CurrentStudent.Position.Y, CurrentStudent.Position.X + Delta].WaveIndex = 0;
                            return true;
                        }
                    }

                    if (satellites[i].Y - 1 > -1 && City[delta.Y - 1, delta.X].WaveIndex == 0 && City[delta.Y - 1, delta.X].Passability == true)
                    {
                        temp.Add(new Point(satellites[i].X, satellites[i].Y - 1));
                        City[delta.Y - 1, delta.X].WaveIndex = counter;
                        if (delta.X == finish.X && delta.Y - 1 == finish.Y)
                        {
                            City[CurrentStudent.Position.Y, CurrentStudent.Position.X + Delta].WaveIndex = 0;                          
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
        
        public bool getPath(Point finish)
        {
            Path.Clear();
            if (setWave(finish))
            {
               Path.Add(finish);
               // MessageBox.Show(City[finish.Y, finish.X].WaveIndex.ToString());
                 // City[Path.Last().Y, Path.Last().X].Color = Color.Yellow;
             while (City[Path.Last().Y, Path.Last().X].WaveIndex > 1)
             {
               Point last = Path.Last();
               if (City[last.Y, last.X].WaveIndex == City[last.Y, last.X + 1].WaveIndex + 1 && City[last.Y, last.X + 1].Passability == true)
               {
                    Path.Add(new Point(last.X + 1, last.Y));
                      //  MessageBox.Show("1");

               }
               else if (City[last.Y, last.X].WaveIndex == City[last.Y, last.X - 1].WaveIndex + 1 && City[last.Y, last.X - 1].Passability == true)
               {
                        //MessageBox.Show("2");
                        Path.Add(new Point(last.X - 1, last.Y));
                      //  MessageBox.Show("2");
                        //City[last.Y, last.X - 1].Color = Color.Yellow;
               }
               else if (City[last.Y, last.X].WaveIndex == City[last.Y + 1, last.X].WaveIndex + 1 && City[last.Y + 1, last.X].Passability == true)
               {
                        // MessageBox.Show("3");
                        Path.Add(new Point(last.X, last.Y + 1));
                     //   MessageBox.Show("3");
                        // City[last.Y + 1, last.X].Color = Color.Yellow;

                    }
               else if (City[last.Y, last.X].WaveIndex == City[last.Y - 1, last.X].WaveIndex + 1 && City[last.Y - 1, last.X].Passability == true)
               {                       
                        Path.Add(new Point(last.X, last.Y - 1));
                       // MessageBox.Show("4");
                    }
             }
                // Path.Remove(Path.Last());               
                return true;
            }
            return false;
        }

       public void setColorPath(Color color)
       {
            foreach (var item in Path)
            {
                City[item.Y, item.X].Color = color; 
            }
       }
        
    }
}
