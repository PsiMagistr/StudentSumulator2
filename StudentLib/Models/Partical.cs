using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLib.classes
{
    [Serializable]
    public class Partical
    {
        /// <summary>
        /// 
        /// </summary>
        /// 
        [NonSerialized]
        private int waveindex;
        public int WaveIndex
        {
            get
            {
                return waveindex;
            }
            set
            {
                waveindex = value;
            }
        }       
        public bool Passability { get; set; }      
        public bool Activity { get; set; }
        private string name;
        public string Name {
            get
            {
                return name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Имя ячейки не может быть пустым!");
                }
                else if(value.Length > 10)
                {
                    throw new Exception("Имя ячейки не может превышать 10 символов!");
                }
                name = value;
            }
        }
        public Color Color { get; set; }

        public Partical()
        {
            WaveIndex = 0;
            Passability = true;
            Activity = false;
            Color = Color.LightGreen;          
            Name = "Луг";
        }

        public Partical(string name, bool passability, bool activity, Color color)
        {
            Name = name;
            WaveIndex = 0;
            Passability = passability;
            Activity = activity;
            Color = color;           
        }
    }
}
