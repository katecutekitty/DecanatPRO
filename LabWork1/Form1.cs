using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LabWork1
{
    public partial class Form1 : Form
    {
        Logic Log0;
        public Form1()
        {
            Program.form1 = this;
            InitializeComponent();
            Log0 = new Logic();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listStudentView.Items.Clear();
            foreach (var stud in Log0.GetStudents()) {

                ListViewItem item = new ListViewItem(stud[0]);

                item.SubItems.Add(stud[1]);
                item.SubItems.Add(stud[2]);

                listStudentView.Items.Add(item);
            }
            ReloadChart();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            Form_add form_add = new Form_add(this, this.Log0);
            form_add.Show();
        }

        private void buttonRemoveStudent_Click(object sender, EventArgs e)
        {
            Log0.DeleteStudent(listStudentView.SelectedItems[0].Index + 1);
            this.listStudentView.Items.Remove(listStudentView.SelectedItems[0]);
            ReloadChart();
        }

        public void ReloadChart()
        {
            chart1.Series.Clear();

            Series series1 = new Series("Количество студентов по направлениям") { ChartType = SeriesChartType.Bar };

            foreach (var stud in Log0.Get_gist_Form())
            {
                DataPoint point = new DataPoint();
                point.AxisLabel = stud.Key;
                point.YValues = new double[] { stud.Value };
                point.IsValueShownAsLabel = true;
                series1.Points.Add(point);
            }

            chart1.Series.Add(series1);
        }
    }
}
