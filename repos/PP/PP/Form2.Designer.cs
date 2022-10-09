
namespace PP
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.zaivBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cspnDataSet = new PP.cspnDataSet();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.zaivTableAdapter = new PP.cspnDataSetTableAdapters.zaivTableAdapter();
            this.tvoiDataSet1 = new PP.tvoiDataSet1();
            this.bronBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bronTableAdapter = new PP.tvoiDataSet1TableAdapters.bronTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bronIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vezdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viezdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.zaivBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cspnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvoiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(413, 177);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(739, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // zaivBindingSource
            // 
            this.zaivBindingSource.DataMember = "zaiv";
            this.zaivBindingSource.DataSource = this.cspnDataSet;
            // 
            // cspnDataSet
            // 
            this.cspnDataSet.DataSetName = "cspnDataSet";
            this.cspnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(458, 234);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(352, 234);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(246, 234);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 234);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 234);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(295, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Select";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zaivTableAdapter
            // 
            this.zaivTableAdapter.ClearBeforeFill = true;
            // 
            // tvoiDataSet1
            // 
            this.tvoiDataSet1.DataSetName = "tvoiDataSet1";
            this.tvoiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bronBindingSource
            // 
            this.bronBindingSource.DataMember = "bron";
            this.bronBindingSource.DataSource = this.tvoiDataSet1;
            // 
            // bronTableAdapter
            // 
            this.bronTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bronIDDataGridViewTextBoxColumn,
            this.klientIDDataGridViewTextBoxColumn,
            this.numberroomDataGridViewTextBoxColumn,
            this.vezdDataGridViewTextBoxColumn,
            this.viezdDataGridViewTextBoxColumn,
            this.cutkiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bronBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 24;
            // 
            // bronIDDataGridViewTextBoxColumn
            // 
            this.bronIDDataGridViewTextBoxColumn.DataPropertyName = "bronID";
            this.bronIDDataGridViewTextBoxColumn.HeaderText = "bronID";
            this.bronIDDataGridViewTextBoxColumn.Name = "bronIDDataGridViewTextBoxColumn";
            // 
            // klientIDDataGridViewTextBoxColumn
            // 
            this.klientIDDataGridViewTextBoxColumn.DataPropertyName = "klientID";
            this.klientIDDataGridViewTextBoxColumn.HeaderText = "klientID";
            this.klientIDDataGridViewTextBoxColumn.Name = "klientIDDataGridViewTextBoxColumn";
            // 
            // numberroomDataGridViewTextBoxColumn
            // 
            this.numberroomDataGridViewTextBoxColumn.DataPropertyName = "numberroom";
            this.numberroomDataGridViewTextBoxColumn.HeaderText = "numberroom";
            this.numberroomDataGridViewTextBoxColumn.Name = "numberroomDataGridViewTextBoxColumn";
            // 
            // vezdDataGridViewTextBoxColumn
            // 
            this.vezdDataGridViewTextBoxColumn.DataPropertyName = "vezd";
            this.vezdDataGridViewTextBoxColumn.HeaderText = "vezd";
            this.vezdDataGridViewTextBoxColumn.Name = "vezdDataGridViewTextBoxColumn";
            // 
            // viezdDataGridViewTextBoxColumn
            // 
            this.viezdDataGridViewTextBoxColumn.DataPropertyName = "viezd";
            this.viezdDataGridViewTextBoxColumn.HeaderText = "viezd";
            this.viezdDataGridViewTextBoxColumn.Name = "viezdDataGridViewTextBoxColumn";
            // 
            // cutkiDataGridViewTextBoxColumn
            // 
            this.cutkiDataGridViewTextBoxColumn.DataPropertyName = "cutki";
            this.cutkiDataGridViewTextBoxColumn.HeaderText = "cutki";
            this.cutkiDataGridViewTextBoxColumn.Name = "cutkiDataGridViewTextBoxColumn";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(581, 234);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 25;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zaivBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cspnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvoiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private cspnDataSet cspnDataSet;
        private System.Windows.Forms.BindingSource zaivBindingSource;
        private cspnDataSetTableAdapters.zaivTableAdapter zaivTableAdapter;
        private tvoiDataSet1 tvoiDataSet1;
        private System.Windows.Forms.BindingSource bronBindingSource;
        private tvoiDataSet1TableAdapters.bronTableAdapter bronTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bronIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vezdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viezdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox6;
    }
}