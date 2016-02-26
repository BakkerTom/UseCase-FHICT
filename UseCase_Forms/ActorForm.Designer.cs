namespace UseCase_Forms
{
    partial class ActorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdoBoy = new System.Windows.Forms.RadioButton();
            this.rdoGirl = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoBoy
            // 
            this.rdoBoy.AutoSize = true;
            this.rdoBoy.Checked = true;
            this.rdoBoy.Location = new System.Drawing.Point(145, 89);
            this.rdoBoy.Name = "rdoBoy";
            this.rdoBoy.Size = new System.Drawing.Size(27, 26);
            this.rdoBoy.TabIndex = 1;
            this.rdoBoy.TabStop = true;
            this.rdoBoy.UseVisualStyleBackColor = true;
            // 
            // rdoGirl
            // 
            this.rdoGirl.AutoSize = true;
            this.rdoGirl.Location = new System.Drawing.Point(236, 89);
            this.rdoGirl.Name = "rdoGirl";
            this.rdoGirl.Size = new System.Drawing.Size(27, 26);
            this.rdoGirl.TabIndex = 3;
            this.rdoGirl.TabStop = true;
            this.rdoGirl.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 139);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(400, 31);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UseCase_Forms.Properties.Resources.girl;
            this.pictureBox2.Location = new System.Drawing.Point(218, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 71);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UseCase_Forms.Properties.Resources.boy;
            this.pictureBox1.Location = new System.Drawing.Point(126, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 71);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ActorForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.rdoGirl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rdoBoy);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(450, 325);
            this.MinimumSize = new System.Drawing.Size(450, 325);
            this.Name = "ActorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Actor";
            this.Load += new System.EventHandler(this.ActorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdoBoy;
        private System.Windows.Forms.RadioButton rdoGirl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button1;
    }
}