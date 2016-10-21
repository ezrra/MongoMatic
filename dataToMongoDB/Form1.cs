using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataToMongoDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Text = "Procesando...";
            dataToMongoDBProcess process = new dataToMongoDBProcess();

            dataObject source =  new dataObject();
            dataObject destination = new dataObject();

            source.connectionString = string.Format( textBox3.Text, textBox7.Text);
            source.database = textBox7.Text;
            source.table = textBox5.Text;
            source.key = textBox6.Text;
            source.interval = Convert.ToInt64( textBox1.Text );


            destination.connectionString = textBox2.Text;
            destination.database = textBox8.Text;
            destination.table = textBox10.Text;
            destination.key = textBox9.Text;
            destination.interval = Convert.ToInt64(textBox4.Text);
            destination.dropTable = checkBox1.Checked;

            label11.Text = "Tiempo de procesamiento: " + process.export(source, destination);

        }
    }
}
