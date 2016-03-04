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
        Font drawFont = new Font("Arial", 14);
        SizeF frame = new SizeF();
        private bool isSelected = false;

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
        public SizeF Frame {
            get { return frame; }
        }

        public bool IsSelected
        {
            get
            {
                return isSelected;
            }
            set
            {
                if (isSelected)
                {
                    isSelected = false;
                }
                else
                {
                    isSelected = true;
                }
            }
        }

        public void drawCase(Graphics g)
        {
            //Draw the text

            SolidBrush brush;
            SolidBrush backBrush;

            if (IsSelected)
            {
                backBrush = new SolidBrush(Color.DeepPink);
                brush = new SolidBrush(Color.White);
            }
            else
            {
                backBrush = new SolidBrush(Color.LightSkyBlue);
                brush = new SolidBrush(Color.Black);
            }

            var textFrame = g.MeasureString(Name, drawFont);

            frame.Width = textFrame.Width + 64;
            frame.Height = textFrame.Height + 64;

            g.FillEllipse(backBrush, Location.X - 32, Location.Y - 32, Frame.Width, Frame.Height);

            g.DrawString(Name, drawFont, brush, Location);
        }
    }
}
