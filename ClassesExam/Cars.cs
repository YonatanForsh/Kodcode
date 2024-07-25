using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExam
{
    enum Color
    {
        Green,
        Red,
        Blue
    }

    internal class Cars
    {
        private Color _carColor;
        public Color CarColor
        {
            get { return _carColor; }
            set { _carColor = value; }
        }

        public Cars(Color color)
        {
            _carColor = color;
        }

        public void DisplayColor()
        { 
            Console.WriteLine(_carColor.ToString());
        }
        
    }
}
