using StudentLib.classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLib.Controllers
{
    public class CameraController:Saver
    {
        public Camera CurrentCamera { get; set; }
        public CameraController()
        {
            CurrentCamera = new Camera();
            Load("test.dat");
        }

        private void Load(string filename)
        {
            CurrentCamera.City = Load<City>(filename);
            if(CurrentCamera.City == null)
            {
                throw new Exception("Не удалось загрузить файл карты!");
            }
        }

        public void Draw(Graphics g)
        {
            for (int y = 0; y < CurrentCamera.City.Height; y++)
            {
                for (int x = CurrentCamera.Delta; x < CurrentCamera.City.Width - CurrentCamera.Delta; x++)
                {
                    g.FillRectangle(new SolidBrush(CurrentCamera.City[y, x].Color), (x * 20 + 1 * (x + 1)) - (CurrentCamera.Delta * 20) - CurrentCamera.Delta + 1, y * 20 + 1 * (y + 1), 20, 20);
                   // g.FillRectangle(new SolidBrush(CurrentCamera.City[y, x].Color), (x * 20 + 1 * (x + 1)) - (0 * 20) - 0 + 1, y * 20 + 1 * (y + 1), 20, 20);

                }
            }            
        }        
    }
     
}
