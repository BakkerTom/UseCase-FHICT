﻿using System;
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

            //Get click location
            Point p = canvas.PointToClient(Cursor.Position);

            //Check for mode
            if (rdoCreate.Checked) // Create mode
            {
                //Check for creation mode
                if (rdoActor.Checked) //Actor
                {
                    //Get information for actors
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
                //Check to see if clicked within the frame of an actor
                foreach (Actor a in actorList)
                {
                    //Check X-Axis
                    if (p.X >= a.locationPoint.X && p.X <= a.locationPoint.X + 64)
                    {
                        //Check Y-Axis
                        if (p.Y >= a.locationPoint.Y && p.Y <= a.locationPoint.Y +64)
                        {
                            a.IsSelected = true;
                            canvas.Invalidate();
                        }
                    }
                }
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

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Change cursors based on tool context
            if (rdoCreate.Checked)
            {
                Cursor.Current = Cursors.Hand;
                Application.DoEvents();
            }
            else
            {
                Cursor.Current = Cursors.Default;
                Application.DoEvents();
            }
        }
    }
}
