using StudentLib.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentLib;
using StudentLib.Models;

namespace StudentSim
{
    public partial class Game : Form
    {
        private GameController gameController;
        private int counter;
        private int counter2;
        private bool direction;
        private bool proverka = true;
        private List<Point> P = new List<Point>();
        public Game(Student student, List<Student> students)
        {
            InitializeComponent();
            gameController = new GameController(student, students);
            //counter = gameController.Path.Count;
        }

        public void DrawStudent(Graphics g, Point Position, Color color, int otstup, int size)
        {
            g.FillRectangle(new SolidBrush(color), Position.X * 20 + 1 * (Position.X + 1) + 20 / 2 - size / 2, Position.Y * 20 + 1 * (Position.Y + 1) + 20 / 2 - size / 2, size, size);

        }

        private void Draw(Graphics g, int size)
        {
                int Delta = gameController.CurrentStudent.Delta;           
                if (gameController.City.VisibleNumbers)
                {
                    using (var sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;
                        var f = new Font("Arial", 10);
                        for (int y = 0; y < gameController.City.Height; y++)
                        {
                            for (int x = Delta; x < gameController.City.CameraWidth + Delta; x++)
                            {
                                g.FillRectangle(new SolidBrush(gameController.City[y, x].Color), (x * size + 1 * (x + 1)) - (Delta * size) - Delta + 1, y * size + 1 * (y + 1), size, size);

                                if (gameController.City[y, x].WaveIndex > 0)
                                {
                                    g.DrawString((gameController.City[y, x].WaveIndex).ToString(), f, Brushes.Black, new RectangleF((x * size + 1 * (x + 1)) - (Delta * size) - Delta + 1, y * size + 1 * (y + 1), size, size), sf);

                                }
                            }
                        }                        
                    }
                }
                else
                {
                    for (int y = 0; y < gameController.City.Height; y++)
                    {
                        for (int x = Delta; x < gameController.City.CameraWidth + Delta; x++)
                        {                      
                            g.FillRectangle(new SolidBrush(gameController.City[y, x].Color), (x * size + 1 * (x + 1)) - (Delta * size) - Delta + 1, y * size + 1 * (y + 1), size, size);
                        }                        
                    }
                }
           }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            var registration = (FrmRegistration)this.Owner;
            registration.Show();                                               
        }

        private void scena_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics, 20);
            DrawStudent(e.Graphics, gameController.CurrentStudent.Position, Color.Black, 1, 13);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*gameController.CurrentStudent.Delta = 0;
            gameController.Save();*/
            gameController.City.VisibleNumbers = true;
            // gameController.setWave(new Point(14, 6));
            gameController.setWave(new Point(6, 5));
            scena.Invalidate();
        }

        private void scena_MouseDown(object sender, MouseEventArgs e)
        {
            int Delta = gameController.CurrentStudent.Delta;
            int X = (e.X /*+ gameController.CurrentStudent.Delta*/) / 21;
            int Y = e.Y / 21;
            gameController.City.VisibleNumbers = true;
            if (gameController.getPath(new Point(X + Delta, Y)))
            {
                direction = gameController.CurrentStudent.Position.X < X;
                

                counter = gameController.Path.Count;
                counter2 = gameController.Path.Count;
                label1.Text = (0).ToString();
                gameController.setColorPath(Color.Red);
                button6.Enabled = true;
                TM.Enabled = true;
            }
            
            scena.Invalidate();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameController.City.VisibleNumbers = true;
            gameController.CurrentStudent.Delta++;
            gameController.CurrentStudent.setPosX(gameController.CurrentStudent.Position.X - 1);
            int Delta = gameController.CurrentStudent.Delta;
            /*for (int y = 1; y < gameController.City.Height -1; y++)
            {
                for (int x = 1; x < gameController.CurrentStudent.Delta + 1; x++)
                {
                    gameController.City[y, x].Passability = false;
                    gameController.City[y, x].Color = Color.Red;
                }

            }*/
           // gameController.City[1, 2 + Delta].WaveIndex = 1;
            scena.Invalidate();
           // MessageBox.Show(gameController.City[gameController.CurrentStudent.Position.Y, gameController.CurrentStudent.Position.X - 1 + gameController.CurrentStudent.Delta].Name);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            gameController.CurrentStudent.Delta--;
            scena.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Point last = P.Last();
            var City = gameController.City;
            if (City[last.Y, last.X].WaveIndex == gameController.City[last.Y, last.X + 1].WaveIndex + 1 && City[last.Y, last.X + 1].Passability == true)
            {
                P.Add(new Point(last.X + 1, last.Y));
                City[last.Y, last.X + 1].Color = Color.Red;
                scena.Invalidate();

            }
            else if (gameController.City[last.Y, last.X].WaveIndex == City[last.Y, last.X - 1].WaveIndex + 1 && City[last.Y, last.X - 1].Passability == true)
            {
                //MessageBox.Show("2");
                P.Add(new Point(last.X - 1, last.Y));
                City[last.Y, last.X - 1].Color = Color.Red;
                scena.Invalidate();
                //  MessageBox.Show("2");
                //City[last.Y, last.X - 1].Color = Color.Yellow;
            }
            else if (City[last.Y, last.X].WaveIndex == City[last.Y + 1, last.X].WaveIndex + 1 && City[last.Y + 1, last.X].Passability == true)
            {
                // MessageBox.Show("3");
                P.Add(new Point(last.X, last.Y + 1));
                City[last.Y + 1, last.X].Color = Color.Red;
                scena.Invalidate();
                //   MessageBox.Show("3");
                // City[last.Y + 1, last.X].Color = Color.Yellow;

            }
            else if (City[last.Y, last.X].WaveIndex == City[last.Y - 1, last.X].WaveIndex + 1 && City[last.Y - 1, last.X].Passability == true)
            {
                P.Add(new Point(last.X, last.Y - 1));
                City[last.Y - 1, last.X].Color = Color.Red;
                scena.Invalidate();
                // MessageBox.Show("4");
            }
        }
       

        private void button5_Click(object sender, EventArgs e)
        {
            //Point last = gameController.Path.Last();
            // MessageBox.Show(gameController.City[last.Y, last.X].WaveIndex.ToString());
            //gameController.setWave(new Point(7, 1));
            // P.Add(new Point(7, 1));
            gameController.CurrentStudent.Delta++;
            gameController.CurrentStudent.Move(gameController.Path[0].X - gameController.CurrentStudent.Delta, gameController.Path[0].Y);
            scena.Invalidate();
        }

        private void TM_Tick(object sender, EventArgs e)
        {
           /* int Delta = gameController.CurrentStudent.Delta;
            var Path = gameController.Path;
            counter--;
            if(counter == 0)
            {
                TM.Enabled = false;
            }
            label1.Text = counter.ToString();
            gameController.CurrentStudent.Move(Path[counter].X, Path[counter].Y);
            scena.Invalidate();  */        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            counter--;
            var Path = gameController.Path;            
            if(gameController.CurrentStudent.Position.X >= gameController.City.CameraWidth / 2)
            {
               //MessageBox.Show("Jj");
                //counter++;
                gameController.CurrentStudent.Delta++;
            }
            gameController.CurrentStudent.Move(Path[counter].X - gameController.CurrentStudent.Delta, Path[counter].Y);
            scena.Invalidate();
        }
    }
}
