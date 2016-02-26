using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCase_Forms
{
    public partial class Form1 : Form
    {
        private List<Actor> actorList = new List<Actor>();

        public Form1()
        {
            InitializeComponent();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            //Gets the Graphics object from the canvas
            Graphics g = canvas.CreateGraphics();
            
            //Draw all actors in actorList
            foreach (Actor a in actorList)
            {   
                a.DrawActor(g);
            }
        }

        private void canvas_Click(object sender, EventArgs e)
        {
            //Check for mode
            if (rdoCreate.Checked) // Create mode
            {
                //Check for creation mode
                if (rdoActor.Checked) //Actor
                {
                    //Add new actor to actor list
                    Point p = canvas.PointToClient(Cursor.Position);
                    actorList.Add(new Actor(p, "Bob"));

                    //Force refresh
                    canvas.Invalidate();
                }
            } else if (rdoSelect.Checked) //Select mode
            {

            }
        }
    }
}
