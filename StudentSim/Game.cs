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
        public Game(Student student, List<Student> students)
        {
            InitializeComponent();
            gameController = new GameController(student, students);        
           
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
            gameController.City[Y, X + Delta].Color = Color.Red;
            gameController.setWave(new Point(X + Delta, Y));
            scena.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameController.City.VisibleNumbers = true;
            gameController.CurrentStudent.Delta++;
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
    }
}
