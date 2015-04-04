using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.UserTableAdapter user = new DataSet1TableAdapters.UserTableAdapter();

            DBSample.DataSet1.UserDataTable table = user.GetData();
            
            user.Insert(table.Rows.Count + 1, textBox1.Text, textBox2.Text, double.Parse(textBox3.Text));

            this.userTableAdapter.Fill(this.dataSet1.User);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.dataSet1.User);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userBindingSource.EndEdit();
            this.userTableAdapter.Update(this.dataSet1.User);
        }
    }
}
