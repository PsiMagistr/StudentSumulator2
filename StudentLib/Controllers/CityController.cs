using StudentLib.classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLib.Controllers
{
    public class CityController:Saver
    {
        public City CurrentCity { get; set; }
        public CityController(int width, int height, int camerawidth, bool visible)
        {
            Load("test.dat");
            if(CurrentCity == null)
            {
                CreateNewCity(width, height, camerawidth/*, visible*/);                
            }
        }

        public void Load(string filename)
        {
            CurrentCity = Load<City>(filename);                   
        }

        public void Save(string filename)
        {
            Save(filename, CurrentCity);
        }

        public void JsonSave(string filename)
        {
            JsonSave(filename, CurrentCity);
        }

        public void setValues(Point coords, string name, string colorname, bool passability, bool activity)
        {
            CurrentCity[coords.Y, coords.X].Name = name;
            CurrentCity[coords.Y, coords.X].Color = Color.FromName(colorname);           
            CurrentCity[coords.Y, coords.X].Passability = passability;
            CurrentCity[coords.Y, coords.X].Activity = activity;
        }        

        public void CreateNewCity(int width, int height, int camerawidth/*, bool visible*/)
        {
            CurrentCity = new City(width, height, camerawidth/*, visible*/);
        }

        public void CreateNewCity(int width, int height, int camerawidth, string name, bool passability, bool activity, Color color/*, bool visible*/)
        {
            CurrentCity = new City(width, height, camerawidth, name, passability, activity, color);
        }
    }
}
