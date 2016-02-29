using System;
using System.Drawing;

namespace UseCase_Forms
{
    public class Actor
    {
        public Point locationPoint;
        private bool isSelected = false;
        public enum Gender
        {
            male,
            female,
        }

        public Actor(Point locationPoint, string name, Gender gender)
        {
            this.locationPoint = locationPoint;
            Name = name;
            ActorGender = gender;
        }
        public string Name { get; private set; }
        public Gender ActorGender { get; set; }

        public bool IsSelected {
            get
            {
                return isSelected;   
            }
            set {
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

        private Image Icon {
            get
            {
                if (ActorGender == Gender.male)
                {
                    return new Bitmap(Properties.Resources.boy);
                }
                else
                {
                    return new Bitmap(Properties.Resources.girl);
                }
            }
        }

        public void DrawActor(Graphics g)
        {
            //Draws emoticon
            g.DrawImage(Icon, locationPoint);

            //Draws name
            Font drawFont = new Font("Arial", 12);
            SolidBrush brush;

            if (isSelected)
            {
                brush = new SolidBrush(Color.CornflowerBlue);
            }
            else
            {
                brush = new SolidBrush(Color.Black);
            }
            var textWidth = g.MeasureString(Name, drawFont);
            var textLocation = (locationPoint.X - (textWidth.Width/2)) + 32;
            g.DrawString(Name, drawFont, brush, textLocation, locationPoint.Y + 80);
        }

    }
}
