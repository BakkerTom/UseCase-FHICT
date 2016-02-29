using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase_Forms
{
    class Case
    {
        public Case(string name, Point location)
        {
            Name = name;
            Location = location;
        }

        // PROPERTIES
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Preconceptions { get; set; }
        public string Description { get; set; }
        public string Exceptions { get; set; }
        public string Result { get; set; }
        public Point Location { get; private set; }

        public void drawCase(Graphics g)
        {
            Font drawFont = new Font("Arial", 14);
            SolidBrush brush = new SolidBrush(Color.Black);

            g.DrawString(Name, drawFont, brush, Location);
        }
    }
}
