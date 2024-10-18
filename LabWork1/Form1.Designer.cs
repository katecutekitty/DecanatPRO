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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonRemoveStudent = new System.Windows.Forms.Button();
            this.listStudentView = new System.Windows.Forms.ListView();
            this.ИМЯ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.СПЕЦ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.НАПР = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(12, 21);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(423, 75);
            this.buttonAddStudent.TabIndex = 0;
            this.buttonAddStudent.Text = "Добавить студента";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonRemoveStudent
            // 
            this.buttonRemoveStudent.Location = new System.Drawing.Point(12, 102);
            this.buttonRemoveStudent.Name = "buttonRemoveStudent";
            this.buttonRemoveStudent.Size = new System.Drawing.Size(423, 75);
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
            listViewItem3});
            this.listStudentView.Location = new System.Drawing.Point(453, 21);
            this.listStudentView.Name = "listStudentView";
            this.listStudentView.Size = new System.Drawing.Size(613, 242);
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
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(453, 278);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(612, 258);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 164);
            this.button1.TabIndex = 8;
            this.button1.Text = "Переключиться на Dapper";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listStudentView);
            this.Controls.Add(this.buttonRemoveStudent);
            this.Controls.Add(this.buttonAddStudent);
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
        private System.Windows.Forms.Button button1;
    }
}

