namespace LabWork1
{
    partial class Form_add
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
            this.buttonForm_add_Add = new System.Windows.Forms.Button();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.textAddBox2 = new System.Windows.Forms.TextBox();
            this.textAddBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonForm_add_Add
            // 
            this.buttonForm_add_Add.Location = new System.Drawing.Point(335, 84);
            this.buttonForm_add_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonForm_add_Add.Name = "buttonForm_add_Add";
            this.buttonForm_add_Add.Size = new System.Drawing.Size(287, 180);
            this.buttonForm_add_Add.TabIndex = 0;
            this.buttonForm_add_Add.Text = "Добавить";
            this.buttonForm_add_Add.UseVisualStyleBackColor = true;
            this.buttonForm_add_Add.Click += new System.EventHandler(this.buttonForm_add_Add_Click);
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(14, 64);
            this.textBoxStudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(296, 26);
            this.textBoxStudentName.TabIndex = 1;
            // 
            // textAddBox2
            // 
            this.textAddBox2.Location = new System.Drawing.Point(14, 140);
            this.textAddBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textAddBox2.Name = "textAddBox2";
            this.textAddBox2.Size = new System.Drawing.Size(296, 26);
            this.textAddBox2.TabIndex = 2;
            // 
            // textAddBox3
            // 
            this.textAddBox3.Location = new System.Drawing.Point(14, 214);
            this.textAddBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textAddBox3.Name = "textAddBox3";
            this.textAddBox3.Size = new System.Drawing.Size(296, 26);
            this.textAddBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Специальность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Группа";
            // 
            // Form_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAddBox3);
            this.Controls.Add(this.textAddBox2);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.buttonForm_add_Add);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_add";
            this.Text = "Form_add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonForm_add_Add;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.TextBox textAddBox2;
        private System.Windows.Forms.TextBox textAddBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}