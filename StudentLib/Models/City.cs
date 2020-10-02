using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLib.classes
{
    [Serializable]
    public class City
    {
        public String Name { get; private set; }       
        private Partical[][] Map { get;  set; }
        [NonSerialized]
        public Boolean VisibleNumbers;
        public Partical this[int y, int x] {
            get
            {
                return Map[y][x];
            }
            set
            {
                 Map[y][x] = value;
            }
        }
        public int Width { get; set; }
        public int Height {get; set;}
        public int CameraWidth { get; set; }      
      
        public City(int width, int height, int camerawidth/*, bool visiblenumbers*/)
        {           
            Width = width;
            Height = height;
            CameraWidth = camerawidth;
           // VisibleNumbers = visiblenumbers;
            Name = "test";
            Map = new Partical[Height][];
            for(int y = 0; y < Height; y++)
            {
                Map[y] = new Partical[Width];
            }

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Map[y][x] = new Partical();
                }
            }           
        }

        public City(
            int width,
            int height,
            int camerawidth,            
            string name,
            bool passability,
            bool activity,
            Color color)
        {
            Width = width;
            Height = height;
            CameraWidth = camerawidth;
            // VisibleNumbers = visiblenumbers;
            Name = "test";
            Map = new Partical[Height][];
            for (int y = 0; y < Height; y++)
            {
                Map[y] = new Partical[Width];
            }

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Map[y][x] = new Partical(name, passability, activity, color);
                }
            }
        }     
    }
}
