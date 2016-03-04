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
    public partial class CaseForm : Form
    {

        public CaseForm()
        {
            InitializeComponent();
        }

        // PROPERTIES
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Preconceptions { get; set; }
        public string Description { get; set; }
        public string Exceptions { get; set; }
        public string Result { get; set; }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name = txtName.Text;
            Summary = txtSummary.Text;
            Preconceptions = txtPreconceptions.Text;
            Description = txtDescription.Text;
            Exceptions = txtExceptions.Text;
            Result = txtResults.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CaseForm_Load(object sender, EventArgs e)
        {
            txtName.Text = Name;
            txtSummary.Text = Summary;
            txtPreconceptions.Text = Preconceptions;
            txtDescription.Text = Description;
            txtExceptions.Text = Exceptions;
            txtResults.Text = Result;
        }
    }
}
