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
        public int WaveIndex { get; set; }
        public bool Passability { get; set; }      
        public bool Activity { get; set; }  
        public string Name { get; set; }
        public Color Color { get; set; }
        public Partical()
        {
            WaveIndex = 0;
            Passability = true;
            Activity = false;
            Color = Color.LightGreen;
            Name = "Траваfdfdfddfdffdfd";
        }
    }
}
