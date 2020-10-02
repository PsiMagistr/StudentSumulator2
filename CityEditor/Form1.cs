using StudentLib.classes;
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

namespace CityEditor
{
    public partial class Form1 : Form
    {
        private CityController cityController;        
        private int Count = 0;
        private Boolean StartDrawing = false;
        private bool Border = false;
        private Point coords;
        private void getCoords(int mouseX, int mouseY)
        {
            int X = Count * cityController.CurrentCity.CameraWidth + (mouseX / 21);
            int Y = mouseY / 21;
            if (X > cityController.CurrentCity.CameraWidth * (Count + 1) - 1)
            {
                X = cityController.CurrentCity.CameraWidth - 1;
            }
            else if (X < 0)
            {
                X = 0;
            }
            if (Y > cityController.CurrentCity.Height - 1)
            {
                Y = cityController.CurrentCity.Height - 1;
            }
            else if (Y < 0)
            {
                Y = 0;
            }            
            coords = new Point(X,Y);
        }

        private void Draw(Graphics g, int size)
        {
            int start;
            int finish;            
            if (cityController.CurrentCity != null)
            {
                start = Count * cityController.CurrentCity.CameraWidth;
                finish = (Count + 1) * cityController.CurrentCity.CameraWidth;
               // MessageBox.Show(cityController.CurrentCity.VisibleNumbers.ToString());
                if (cityController.CurrentCity.VisibleNumbers)
                {                   
                    using (var sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;
                        var f = new Font("Arial", 10);
                        for (int y = 0; y < cityController.CurrentCity.Height; y++)
                        {
                            for (int x = start; x < finish; x++)
                            {                                
                                g.FillRectangle(new SolidBrush(cityController.CurrentCity[y, x].Color), (x * size + 1 * (x + 1)) - (start * size) - start + 1, y * size + 1 * (y + 1), size, size);
                                                             
                                if (cityController.CurrentCity[y, x].WaveIndex > 0)
                                {                                    
                                    g.DrawString((cityController.CurrentCity[y, x].WaveIndex).ToString(), f, Brushes.Black, new RectangleF((x * size + 1 * (x + 1)) - (start * size) - start + 1, y * size + 1 * (y + 1), size, size), sf);
                                }                                
                            }
                        }
                        if (Border)
                        {
                            g.DrawRectangle(new Pen(Color.Black), (coords.X * size + 1 * (coords.X + 1)) - (start * size) - start + 1, coords.Y * size + 1 * (coords.Y + 1), size, size);
                        }
                    }
                }
                else
                {                  
                        for (int y = 0; y < cityController.CurrentCity.Height; y++)
                        {
                            for (int x = start; x < finish; x++)
                            {                           
                            g.FillRectangle(new SolidBrush(cityController.CurrentCity[y, x].Color), (x * size + 1 * (x + 1)) - (start * size) - start + 1, y * size + 1 * (y + 1), size, size);                                                  
                        }
                        if (Border)
                        {
                            g.DrawRectangle(new Pen(Color.Black), (coords.X * size + 1 * (coords.X + 1)) - (start * size) - start + 1, coords.Y * size + 1 * (coords.Y + 1), size, size);                          // Border = false;
                            
                        }
                    }
                }

                

               /* for (int y = 0; y < city.Height; y++)
                {
                    for (int x = start; x < finish; x++)
                    {
                        g.FillRectangle(new SolidBrush(city[y, x].Color), (x * size + 1 * (x + 1)) - (start * size) - start + 1, y * size + 1 * (y + 1), size, size);
                        if (city.VisibleNumbers)
                        {
                            var f = new Font("Arial", 20);
                            g.DrawString((city[y,x].WaveIndex).ToString(), f, new SolidBrush(Color.Red), 0, 0,  ); 
                        }
                    }
                }*/
            }          
       }


            
        public Form1()
        {
            InitializeComponent();
            //cityController.Load("test.dat");

        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            try
            {
                int width = (int)nwidth.Value * (int)nfactor.Value;
                int height = (int)nheight.Value;
                int camerawidth = (int)nwidth.Value;
                //cityController.CreateNewCity(width, height, camerawidth/*, true*/);
                string name = txtParticalName.Text;
                bool passability = chpassability.Checked;
                bool activity = chactivity.Checked;
                Color color = Color.FromName(ListColors.SelectedItem.ToString());               
                cityController.CreateNewCity(width, height, camerawidth, name, passability, activity, color);
                lblmessage.Text = cityController.CurrentCity.Width.ToString();
                scena.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void scena_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics, 20);
            if(cityController.CurrentCity != null)
            {
                lblmessage.Text = (Count + 1).ToString() + " из " + (cityController.CurrentCity.Width / cityController.CurrentCity.CameraWidth).ToString();

            }
            //label1.Text = (Count + 1).ToString() + " из " + (city.Width / 47).ToString();
        }

        private void scena_MouseDown(object sender, MouseEventArgs e)
        {            
            StartDrawing = true;
            if(ListColors.SelectedIndex == 0)
            {                
                Border = true;               
                getCoords(e.X, e.Y);
                txtParticalName.Text = cityController.CurrentCity[coords.Y, coords.X].Name;
                chpassability.Checked = cityController.CurrentCity[coords.Y, coords.X].Passability;
                chactivity.Checked = cityController.CurrentCity[coords.Y, coords.X].Activity;
                scena.Invalidate();
            }
            else
            {
                Border = false;
            }            
        }

        private void scena_MouseUp(object sender, MouseEventArgs e)
        {
            StartDrawing = false;         
        }

        private void scena_MouseMove(object sender, MouseEventArgs e)
        {

            if (StartDrawing)
            {                              
                getCoords(e.X, e.Y);              
                if (ListColors.SelectedIndex > 0)
                {
                    try
                    {
                        cityController.setValues(coords, txtParticalName.Text, ListColors.SelectedItem.ToString(), chpassability.Checked, chactivity.Checked);
                    }
                    catch (Exception ex)
                    {
                        StartDrawing = false;
                        MessageBox.Show(ex.Message);
                    }
                }               
                scena.Invalidate();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {            
            if(Count < cityController.CurrentCity.Width / cityController.CurrentCity.CameraWidth -1)
            {
                Count++;
            }
            
            scena.Invalidate();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(Count > 0)
            {
                Count--;
            }      
            scena.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // city[1, 1].WaveIndex = 1;
            cityController.Save("test.dat");
            //scena.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int width = (int)nwidth.Value * (int)nfactor.Value;
            int height = (int)nheight.Value;
            int camerawidth = (int)nwidth.Value;
            cityController = new CityController(width, height, camerawidth);
            ListColors.Items.Add("Выделение");
            foreach (var color in Enum.GetNames(typeof(KnownColor)))
            {
               // if(color.ToString().Compare("AliceBlue"))
                ListColors.Items.Add(color);                
            }
            ListColors.SelectedIndex = 0;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cityController.JsonSave("test.json");
            cityController.CurrentCity.VisibleNumbers = true;
            cityController.CurrentCity[1, 1].WaveIndex = 1;
            scena.Invalidate();
        }

        private void btnchangecata_Click(object sender, EventArgs e)
        {
            try
            {
                cityController.CurrentCity[coords.Y, coords.X].Name = txtParticalName.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
