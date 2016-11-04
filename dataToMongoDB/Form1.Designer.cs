namespace dataToMongoDB
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSQLScript = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonMySQL = new System.Windows.Forms.RadioButton();
            this.radioButtonSqlServer = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSQLDatabase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSQLKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSQLTable = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSQLConnection = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxTranformationTable = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMongoDatabase = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMongoKey = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMongoTable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMongoConnection = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.checkListaArchivos = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxSQLScript);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxSQLDatabase);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxSQLKey);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxSQLTable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSQLConnection);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(463, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 319);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros de SQL";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Script";
            // 
            // textBoxSQLScript
            // 
            this.textBoxSQLScript.Location = new System.Drawing.Point(21, 233);
            this.textBoxSQLScript.Multiline = true;
            this.textBoxSQLScript.Name = "textBoxSQLScript";
            this.textBoxSQLScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSQLScript.Size = new System.Drawing.Size(653, 80);
            this.textBoxSQLScript.TabIndex = 32;
            this.textBoxSQLScript.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonMySQL);
            this.groupBox3.Controls.Add(this.radioButtonSqlServer);
            this.groupBox3.Location = new System.Drawing.Point(21, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 36);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo ";
            // 
            // radioButtonMySQL
            // 
            this.radioButtonMySQL.AutoSize = true;
            this.radioButtonMySQL.Checked = true;
            this.radioButtonMySQL.Location = new System.Drawing.Point(104, 13);
            this.radioButtonMySQL.Name = "radioButtonMySQL";
            this.radioButtonMySQL.Size = new System.Drawing.Size(59, 17);
            this.radioButtonMySQL.TabIndex = 32;
            this.radioButtonMySQL.TabStop = true;
            this.radioButtonMySQL.Text = "mySQL";
            this.radioButtonMySQL.UseVisualStyleBackColor = true;
            this.radioButtonMySQL.CheckedChanged += new System.EventHandler(this.radioButtonSqlServer_CheckedChanged);
            // 
            // radioButtonSqlServer
            // 
            this.radioButtonSqlServer.AutoSize = true;
            this.radioButtonSqlServer.Location = new System.Drawing.Point(13, 13);
            this.radioButtonSqlServer.Name = "radioButtonSqlServer";
            this.radioButtonSqlServer.Size = new System.Drawing.Size(69, 17);
            this.radioButtonSqlServer.TabIndex = 31;
            this.radioButtonSqlServer.Text = "sqlServer";
            this.radioButtonSqlServer.UseVisualStyleBackColor = true;
            this.radioButtonSqlServer.CheckedChanged += new System.EventHandler(this.radioButtonSqlServer_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "DB";
            // 
            // textBoxSQLDatabase
            // 
            this.textBoxSQLDatabase.Location = new System.Drawing.Point(50, 155);
            this.textBoxSQLDatabase.Name = "textBoxSQLDatabase";
            this.textBoxSQLDatabase.Size = new System.Drawing.Size(100, 20);
            this.textBoxSQLDatabase.TabIndex = 27;
            this.textBoxSQLDatabase.Text = "transacciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Llave";
            // 
            // textBoxSQLKey
            // 
            this.textBoxSQLKey.Location = new System.Drawing.Point(196, 183);
            this.textBoxSQLKey.Name = "textBoxSQLKey";
            this.textBoxSQLKey.Size = new System.Drawing.Size(100, 20);
            this.textBoxSQLKey.TabIndex = 25;
            this.textBoxSQLKey.Text = "id_transaccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tabla";
            // 
            // textBoxSQLTable
            // 
            this.textBoxSQLTable.Location = new System.Drawing.Point(196, 157);
            this.textBoxSQLTable.Name = "textBoxSQLTable";
            this.textBoxSQLTable.Size = new System.Drawing.Size(100, 20);
            this.textBoxSQLTable.TabIndex = 23;
            this.textBoxSQLTable.Text = "id_transaccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Conexión a SQL";
            // 
            // textBoxSQLConnection
            // 
            this.textBoxSQLConnection.Location = new System.Drawing.Point(21, 114);
            this.textBoxSQLConnection.Multiline = true;
            this.textBoxSQLConnection.Name = "textBoxSQLConnection";
            this.textBoxSQLConnection.Size = new System.Drawing.Size(653, 37);
            this.textBoxSQLConnection.TabIndex = 21;
            this.textBoxSQLConnection.Text = "Server=DESKTOP-CIE264M;Database=gaslight;Uid=root;Pwd=root;";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Bloque de registros de SQL";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "1000000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBoxTranformationTable);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxMongoDatabase);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxMongoKey);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxMongoTable);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxMongoConnection);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(463, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 191);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parámetros de MongoDB";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(332, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Tabla Transformacion";
            // 
            // textBoxTranformationTable
            // 
            this.textBoxTranformationTable.Location = new System.Drawing.Point(448, 115);
            this.textBoxTranformationTable.Name = "textBoxTranformationTable";
            this.textBoxTranformationTable.Size = new System.Drawing.Size(100, 20);
            this.textBoxTranformationTable.TabIndex = 36;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 168);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "Borrar tabla";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "DB";
            // 
            // textBoxMongoDatabase
            // 
            this.textBoxMongoDatabase.Location = new System.Drawing.Point(42, 112);
            this.textBoxMongoDatabase.Name = "textBoxMongoDatabase";
            this.textBoxMongoDatabase.Size = new System.Drawing.Size(100, 20);
            this.textBoxMongoDatabase.TabIndex = 33;
            this.textBoxMongoDatabase.Text = "V_CistemGas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Llave";
            // 
            // textBoxMongoKey
            // 
            this.textBoxMongoKey.Location = new System.Drawing.Point(196, 138);
            this.textBoxMongoKey.Name = "textBoxMongoKey";
            this.textBoxMongoKey.Size = new System.Drawing.Size(100, 20);
            this.textBoxMongoKey.TabIndex = 31;
            this.textBoxMongoKey.Text = "TRAMAID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(156, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Tabla";
            // 
            // textBoxMongoTable
            // 
            this.textBoxMongoTable.Location = new System.Drawing.Point(196, 112);
            this.textBoxMongoTable.Name = "textBoxMongoTable";
            this.textBoxMongoTable.Size = new System.Drawing.Size(100, 20);
            this.textBoxMongoTable.TabIndex = 29;
            this.textBoxMongoTable.Text = "TRAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Conexión a SQL";
            // 
            // textBoxMongoConnection
            // 
            this.textBoxMongoConnection.Location = new System.Drawing.Point(21, 69);
            this.textBoxMongoConnection.Multiline = true;
            this.textBoxMongoConnection.Name = "textBoxMongoConnection";
            this.textBoxMongoConnection.Size = new System.Drawing.Size(653, 37);
            this.textBoxMongoConnection.TabIndex = 23;
            this.textBoxMongoConnection.Text = "mongodb://localhost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Bloque de registros para MongoDB";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(196, 27);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = "200000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1077, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Migrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(459, 565);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "sdfsdfs";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(984, 562);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Transformar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 562);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Cargar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(368, 565);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "sdfsdfs";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 562);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 23);
            this.button4.TabIndex = 29;
            this.button4.Text = "Guardar cambios";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.ForestGreen;
            this.label14.Location = new System.Drawing.Point(134, 563);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "sdfsdfs";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkListaArchivos
            // 
            this.checkListaArchivos.FormattingEnabled = true;
            this.checkListaArchivos.Location = new System.Drawing.Point(12, 18);
            this.checkListaArchivos.Name = "checkListaArchivos";
            this.checkListaArchivos.Size = new System.Drawing.Size(423, 529);
            this.checkListaArchivos.TabIndex = 31;
            this.checkListaArchivos.SelectedIndexChanged += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 601);
            this.Controls.Add(this.checkListaArchivos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSQLConnection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMongoConnection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSQLDatabase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMongoDatabase;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMongoKey;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxMongoTable;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonMySQL;
        private System.Windows.Forms.RadioButton radioButtonSqlServer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSQLScript;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSQLKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSQLTable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxTranformationTable;
        private System.Windows.Forms.CheckedListBox checkListaArchivos;

    }
}

