using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UseCase_Forms
{
    public partial class Form1 : Form
    {
        private List<Actor> actorList = new List<Actor>();
        private List<Case> caseList = new List<Case>();
        private List<Line> lineList = new List<Line>();

        private Point startPoint;
        private Point releasePoint;

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

            //Draw all cases in caseList
            foreach (Case c in caseList)
            {
                c.drawCase(g);
            }

            //Draw all lines in lineList
            foreach (var l in lineList)
            {
                l.drawLine(g);
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

                        //Add new actor to actor list
                        actorList.Add(new Actor(p, name, gender));
                    }

                    //Force refresh
                    canvas.Invalidate();

                    //Enable selection mode
                    rdoSelect.Checked = true;
                }
                else if (rdoCase.Checked) //Case
                {


                    CaseForm form = new CaseForm();
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Case c = new Case("Case", p);

                        c.Name = form.Name;
                        c.Summary = form.Summary;
                        c.Preconceptions = form.Preconceptions;
                        c.Description = form.Description;
                        c.Exceptions = form.Exceptions;
                        c.Result = form.Result;

                        caseList.Add(c);
                    }

                    canvas.Invalidate();

                    //Enable selection mode
                    rdoSelect.Checked = true;
                }
                
                else if (rdoSelect.Checked) //Select mode
                {
                    //Check to see if clicked within the frame of an actor
                    foreach (Actor a in actorList)
                    {
                        //Check X-Axis
                        if ((p.X >= a.locationPoint.X && p.X <= a.locationPoint.X + 64) &&
                            (p.Y >= a.locationPoint.Y && p.Y <= a.locationPoint.Y + 64))
                        {

                            a.IsSelected = true;
                            canvas.Invalidate();

                        }

                    }

                    //Check to see if clicked within the frame of a Case
                    foreach (Case c in caseList)
                    {
                        if ((p.X >= c.Location.X && p.X <= c.Location.X + c.Frame.Width) &&
                            (p.Y >= c.Location.Y && p.Y <= c.Location.Y + c.Frame.Height))
                        {
                            c.IsSelected = true;
                            canvas.Invalidate();

                            CaseForm form = new CaseForm();

                            form.Name = c.Name;
                            form.Description = c.Description;
                            form.Exceptions = c.Exceptions;
                            form.Preconceptions = c.Preconceptions;
                            form.Summary = c.Summary;
                            form.Result = c.Result;

                            var result = form.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                c.Name = form.Name;
                                c.Summary = form.Summary;
                                c.Preconceptions = form.Preconceptions;
                                c.Description = form.Description;
                                c.Exceptions = form.Exceptions;
                                c.Result = form.Result;

                                c.IsSelected = false;
                                canvas.Invalidate();
                            }


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
                caseList.Clear();
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

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = canvas.PointToClient(Cursor.Position);

            if (rdoCreate.Checked && rdoLine.Checked)
            {
                startPoint = p;
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            Point p = canvas.PointToClient(Cursor.Position);

            if (rdoCreate.Checked && rdoLine.Checked)
            {
                releasePoint = p;

                lineList.Add(new Line(startPoint, releasePoint));
                canvas.Invalidate();
            }
        }
    }
}
