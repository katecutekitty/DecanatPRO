using System;
using BusinessLogic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LabWork1
{
    public partial class Form_add : Form
    {
        Form1 form1;
        Logic Log0;
        public Form_add(Form1 f1, Logic log0)
        {
            InitializeComponent();
            form1 = f1;
            Log0 = log0;
        }
        private void buttonForm_add_Add_Click(object sender, EventArgs e)
        {
            string[] data = { this.textBoxStudentName.Text, this.textAddBox2.Text, this.textAddBox3.Text };
            var ls = new ListViewItem(data);

            if (data[0] == String.Empty || data[1] == String.Empty || data[2] == String.Empty)
            {
                MessageBox.Show("Заполнены не все поля!");
            }
            else
            {
                form1.listStudentView.Items.Add(ls);
                Log0.AddStudent(data[0], data[1], data[2]);
                form1.ReloadChart();
            }
        }
    }
    
}
