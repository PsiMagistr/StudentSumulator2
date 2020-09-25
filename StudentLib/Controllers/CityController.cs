using StudentLib.classes;
using System;
using System.Collections.Generic;
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
                CreateNewCity(width, height, camerawidth, visible);                
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

        public void CreateNewCity(int width, int height, int camerawidth, bool visible)
        {
            CurrentCity = new City(width, height, camerawidth, visible);
        }
    }
}
