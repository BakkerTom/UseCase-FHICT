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
    class Actor
    {
        private Point locationPoint;
        private readonly Image image = new Bitmap(UseCase_Forms.Properties.Resources.boy);

        public Actor(Point locationPoint, string name)
        {
            this.locationPoint = locationPoint;
            Name = name;
        }
        public string Name { get; private set; }

        public void DrawActor(Graphics g)
        {
            g.DrawImage(image, locationPoint);
        }

    }
}
