using System;
using System.Collections.Generic;
using System.Drawing;
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
                    //Get information for actors
                    Point p = canvas.PointToClient(Cursor.Position);
                    string name = "Bob";
                    Actor.Gender gender = Actor.Gender.male;

                    //Creates new ActorForm and shows it
                    ActorForm form = new ActorForm();
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        name = form.ReturnName;
                        gender = form.ReturnGender;
                    }

                    //Add new actor to actor list
                    actorList.Add(new Actor(p, name, gender));

                    //Force refresh
                    canvas.Invalidate();
                }
            } else if (rdoSelect.Checked) //Select mode
            {

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure?",
                                     "Yes, Clear",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes', do something here.
                actorList.Clear();
            }

            //Force canvas refresh
            canvas.Invalidate();
        }
    }
}
