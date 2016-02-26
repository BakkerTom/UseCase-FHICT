namespace UseCase_Forms
{
    partial class Form1
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
            this.elementsGroup = new System.Windows.Forms.GroupBox();
            this.rdoLine = new System.Windows.Forms.RadioButton();
            this.rdoCase = new System.Windows.Forms.RadioButton();
            this.rdoActor = new System.Windows.Forms.RadioButton();
            this.modesGroup = new System.Windows.Forms.GroupBox();
            this.rdoCreate = new System.Windows.Forms.RadioButton();
            this.rdoSelect = new System.Windows.Forms.RadioButton();
            this.canvas = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.elementsGroup.SuspendLayout();
            this.modesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // elementsGroup
            // 
            this.elementsGroup.Controls.Add(this.rdoLine);
            this.elementsGroup.Controls.Add(this.rdoCase);
            this.elementsGroup.Controls.Add(this.rdoActor);
            this.elementsGroup.Location = new System.Drawing.Point(12, 12);
            this.elementsGroup.Name = "elementsGroup";
            this.elementsGroup.Size = new System.Drawing.Size(200, 145);
            this.elementsGroup.TabIndex = 0;
            this.elementsGroup.TabStop = false;
            this.elementsGroup.Text = "Elements";
            // 
            // rdoLine
            // 
            this.rdoLine.AutoSize = true;
            this.rdoLine.Location = new System.Drawing.Point(6, 100);
            this.rdoLine.Name = "rdoLine";
            this.rdoLine.Size = new System.Drawing.Size(84, 29);
            this.rdoLine.TabIndex = 2;
            this.rdoLine.Text = "Line";
            this.rdoLine.UseVisualStyleBackColor = true;
            // 
            // rdoCase
            // 
            this.rdoCase.AutoSize = true;
            this.rdoCase.Location = new System.Drawing.Point(6, 65);
            this.rdoCase.Name = "rdoCase";
            this.rdoCase.Size = new System.Drawing.Size(93, 29);
            this.rdoCase.TabIndex = 1;
            this.rdoCase.Text = "Case";
            this.rdoCase.UseVisualStyleBackColor = true;
            // 
            // rdoActor
            // 
            this.rdoActor.AutoSize = true;
            this.rdoActor.Checked = true;
            this.rdoActor.Location = new System.Drawing.Point(6, 30);
            this.rdoActor.Name = "rdoActor";
            this.rdoActor.Size = new System.Drawing.Size(93, 29);
            this.rdoActor.TabIndex = 0;
            this.rdoActor.TabStop = true;
            this.rdoActor.Text = "Actor";
            this.rdoActor.UseVisualStyleBackColor = true;
            // 
            // modesGroup
            // 
            this.modesGroup.Controls.Add(this.rdoCreate);
            this.modesGroup.Controls.Add(this.rdoSelect);
            this.modesGroup.Location = new System.Drawing.Point(218, 12);
            this.modesGroup.Name = "modesGroup";
            this.modesGroup.Size = new System.Drawing.Size(200, 145);
            this.modesGroup.TabIndex = 3;
            this.modesGroup.TabStop = false;
            this.modesGroup.Text = "Mode";
            // 
            // rdoCreate
            // 
            this.rdoCreate.AutoSize = true;
            this.rdoCreate.Location = new System.Drawing.Point(6, 65);
            this.rdoCreate.Name = "rdoCreate";
            this.rdoCreate.Size = new System.Drawing.Size(107, 29);
            this.rdoCreate.TabIndex = 1;
            this.rdoCreate.Text = "Create";
            this.rdoCreate.UseVisualStyleBackColor = true;
            // 
            // rdoSelect
            // 
            this.rdoSelect.AutoSize = true;
            this.rdoSelect.Checked = true;
            this.rdoSelect.Location = new System.Drawing.Point(6, 30);
            this.rdoSelect.Name = "rdoSelect";
            this.rdoSelect.Size = new System.Drawing.Size(103, 29);
            this.rdoSelect.TabIndex = 0;
            this.rdoSelect.TabStop = true;
            this.rdoSelect.Text = "Select";
            this.rdoSelect.UseVisualStyleBackColor = true;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(12, 163);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1944, 1091);
            this.canvas.TabIndex = 4;
            this.canvas.Click += new System.EventHandler(this.canvas_Click);
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1824, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 49);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1968, 1266);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.modesGroup);
            this.Controls.Add(this.elementsGroup);
            this.Name = "Form1";
            this.Text = "Use Case Helper";
            this.elementsGroup.ResumeLayout(false);
            this.elementsGroup.PerformLayout();
            this.modesGroup.ResumeLayout(false);
            this.modesGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox elementsGroup;
        private System.Windows.Forms.RadioButton rdoLine;
        private System.Windows.Forms.RadioButton rdoCase;
        private System.Windows.Forms.RadioButton rdoActor;
        private System.Windows.Forms.GroupBox modesGroup;
        private System.Windows.Forms.RadioButton rdoCreate;
        private System.Windows.Forms.RadioButton rdoSelect;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button btnClear;
    }
}

