namespace LabWork1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonRemoveStudent = new System.Windows.Forms.Button();
            this.listStudentView = new System.Windows.Forms.ListView();
            this.ИМЯ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.СПЕЦ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.НАПР = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(14, 26);
            this.buttonAddStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(476, 94);
            this.buttonAddStudent.TabIndex = 0;
            this.buttonAddStudent.Text = "Добавить студента";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonRemoveStudent
            // 
            this.buttonRemoveStudent.Location = new System.Drawing.Point(14, 128);
            this.buttonRemoveStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRemoveStudent.Name = "buttonRemoveStudent";
            this.buttonRemoveStudent.Size = new System.Drawing.Size(476, 94);
            this.buttonRemoveStudent.TabIndex = 1;
            this.buttonRemoveStudent.Text = "Удалить студента";
            this.buttonRemoveStudent.UseVisualStyleBackColor = true;
            this.buttonRemoveStudent.Click += new System.EventHandler(this.buttonRemoveStudent_Click);
            // 
            // listStudentView
            // 
            this.listStudentView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ИМЯ,
            this.СПЕЦ,
            this.НАПР});
            this.listStudentView.HideSelection = false;
            this.listStudentView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listStudentView.Location = new System.Drawing.Point(510, 26);
            this.listStudentView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listStudentView.Name = "listStudentView";
            this.listStudentView.Size = new System.Drawing.Size(689, 302);
            this.listStudentView.TabIndex = 4;
            this.listStudentView.UseCompatibleStateImageBehavior = false;
            this.listStudentView.View = System.Windows.Forms.View.Details;
            // 
            // ИМЯ
            // 
            this.ИМЯ.Text = "ИМЯ";
            this.ИМЯ.Width = 113;
            // 
            // СПЕЦ
            // 
            this.СПЕЦ.Text = "СПЕЦ";
            this.СПЕЦ.Width = 211;
            // 
            // НАПР
            // 
            this.НАПР.Text = "ГРУППА";
            this.НАПР.Width = 224;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(510, 348);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(688, 322);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 674);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listStudentView);
            this.Controls.Add(this.buttonRemoveStudent);
            this.Controls.Add(this.buttonAddStudent);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "ДеканатPRO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonRemoveStudent;
        private System.Windows.Forms.ColumnHeader ИМЯ;
        private System.Windows.Forms.ColumnHeader СПЕЦ;
        private System.Windows.Forms.ColumnHeader НАПР;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.ListView listStudentView;
    }
}

