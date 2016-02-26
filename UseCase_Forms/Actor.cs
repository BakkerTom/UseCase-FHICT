using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCase_Forms
{
    public class Actor
    {
        private Point locationPoint;

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
            SolidBrush brush = new SolidBrush(Color.Black);
            g.DrawString(Name, drawFont, brush, locationPoint.X, locationPoint.Y + 80);
        }

    }
}
