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
        private appSettings appSettings { get { return new appSettings(); } }
        private connectionType _connectionType {get { return radioButtonSqlServer.Checked ? connectionType.sqlServer : connectionType.mySQL; } }

    
    public Form1()
        {
            InitializeComponent();
            label11.Text = "";
            radioButtonSqlServer.Checked = true;

            textBoxMongoConnection.Text = appSettings.mongoDBServerConnection;
            textBoxMongoDatabase.Text = appSettings.mongoDBServerDatabase;
            textBoxMongoTable.Text = appSettings.mongoDBServerTable;
            textBoxMongoKey.Text = appSettings.mongoDBServerKey;
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
            dataToMongoDBProcess process;

            
            if ( _connectionType  == connectionType.sqlServer)
                process = new dataToMongoDBProcessSQLServer();
            else
                process = new dataToMongoDBProcessMySQL();

            dataObject source = new dataObject();
            dataObject destination = new dataObject();

            source.connectionString = string.Format(textBoxSQLConnection.Text, textBoxSQLDatabase.Text);
            source.database = textBoxSQLDatabase.Text;
            source.table = textBoxSQLTable.Text;
            source.key = textBoxSQLKey.Text;
            source.script = textBoxSQLScript.Text;
            source.interval = Convert.ToInt64(textBox1.Text);

            destination.connectionString = textBoxMongoConnection.Text;
            destination.database = textBoxMongoDatabase.Text;
            destination.table = textBoxMongoTable.Text;
            destination.key = textBoxMongoKey.Text;
            destination.interval = Convert.ToInt64(textBox4.Text);
            destination.dropTable = checkBox1.Checked;

            label11.Text = "Tiempo de procesamiento: " + process.export(source, destination);

        }

     
        private void radioButtonSqlServer_CheckedChanged(object sender, EventArgs e)
        {
            if (_connectionType == connectionType.sqlServer)
            {
                textBoxSQLConnection.Text = appSettings.sqlServerConnection;
                textBoxSQLDatabase.Text = appSettings.sqlServerDatabase;
                textBoxSQLTable.Text = appSettings.sqlServerTable;
                textBoxSQLKey.Text = appSettings.sqlServerKey;
                textBoxSQLScript.Text = appSettings.sqlServerScript;

            }
            else
            {
                textBoxSQLConnection.Text = appSettings.mysqlServerConnection;
                textBoxSQLDatabase.Text = appSettings.mysqlServerDatabase;
                textBoxSQLTable.Text = appSettings.mysqlServerTable;
                textBoxSQLKey.Text = appSettings.mysqlServerKey;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
