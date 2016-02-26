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
    public partial class ActorForm : Form
    {
        public ActorForm()
        {
            InitializeComponent();
        }

        public string ReturnName { get; set; }
        public Actor.Gender ReturnGender { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnName = txtName.Text;
            if (rdoBoy.Checked) //Boy
            {
                ReturnGender = Actor.Gender.male;
            }
            else
            {
                ReturnGender = Actor.Gender.female;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
