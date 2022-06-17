
namespace ExeCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.daftarmenuDataSet = new ExeCRUD.daftarmenuDataSet();
            this.minumanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minumanTableAdapter = new ExeCRUD.daftarmenuDataSetTableAdapters.MinumanTableAdapter();
            this.idMinumanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kopiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alkoholDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daftarmenuDataSet1 = new ExeCRUD.daftarmenuDataSet();
            this.minumanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.daftarmenuuDataSet = new ExeCRUD.daftarmenuuDataSet();
            this.minumanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.minumanTableAdapter1 = new ExeCRUD.daftarmenuuDataSetTableAdapters.MinumanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minumanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minumanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minumanBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(397, 60);
            this.label5.TabIndex = 24;
            this.label5.Text = "Menu Minuman";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMinumanDataGridViewTextBoxColumn,
            this.jusDataGridViewTextBoxColumn,
            this.kopiDataGridViewTextBoxColumn,
            this.alkoholDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.minumanBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(526, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 201);
            this.dataGridView1.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 372);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(177, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Keluar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.minumanBindingSource2, "Kopi", true));
            this.textBox3.Location = new System.Drawing.Point(223, 215);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 22);
            this.textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.minumanBindingSource2, "Jus", true));
            this.textBox2.Location = new System.Drawing.Point(223, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 22);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.minumanBindingSource2, "Alkohol", true));
            this.textBox1.Location = new System.Drawing.Point(223, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Alkohol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kopi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Jus";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // daftarmenuDataSet
            // 
            this.daftarmenuDataSet.DataSetName = "daftarmenuDataSet";
            this.daftarmenuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // minumanBindingSource
            // 
            this.minumanBindingSource.DataMember = "Minuman";
            this.minumanBindingSource.DataSource = this.daftarmenuDataSet;
            // 
            // minumanTableAdapter
            // 
            this.minumanTableAdapter.ClearBeforeFill = true;
            // 
            // idMinumanDataGridViewTextBoxColumn
            // 
            this.idMinumanDataGridViewTextBoxColumn.DataPropertyName = "Id_Minuman";
            this.idMinumanDataGridViewTextBoxColumn.HeaderText = "Id_Minuman";
            this.idMinumanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMinumanDataGridViewTextBoxColumn.Name = "idMinumanDataGridViewTextBoxColumn";
            this.idMinumanDataGridViewTextBoxColumn.Width = 125;
            // 
            // jusDataGridViewTextBoxColumn
            // 
            this.jusDataGridViewTextBoxColumn.DataPropertyName = "Jus";
            this.jusDataGridViewTextBoxColumn.HeaderText = "Jus";
            this.jusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jusDataGridViewTextBoxColumn.Name = "jusDataGridViewTextBoxColumn";
            this.jusDataGridViewTextBoxColumn.Width = 125;
            // 
            // kopiDataGridViewTextBoxColumn
            // 
            this.kopiDataGridViewTextBoxColumn.DataPropertyName = "Kopi";
            this.kopiDataGridViewTextBoxColumn.HeaderText = "Kopi";
            this.kopiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kopiDataGridViewTextBoxColumn.Name = "kopiDataGridViewTextBoxColumn";
            this.kopiDataGridViewTextBoxColumn.Width = 125;
            // 
            // alkoholDataGridViewTextBoxColumn
            // 
            this.alkoholDataGridViewTextBoxColumn.DataPropertyName = "Alkohol";
            this.alkoholDataGridViewTextBoxColumn.HeaderText = "Alkohol";
            this.alkoholDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alkoholDataGridViewTextBoxColumn.Name = "alkoholDataGridViewTextBoxColumn";
            this.alkoholDataGridViewTextBoxColumn.Width = 125;
            // 
            // daftarmenuDataSet1
            // 
            this.daftarmenuDataSet1.DataSetName = "daftarmenuDataSet";
            this.daftarmenuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // minumanBindingSource1
            // 
            this.minumanBindingSource1.DataMember = "Minuman";
            this.minumanBindingSource1.DataSource = this.daftarmenuDataSet1;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.minumanBindingSource2, "Id_Minuman", true));
            this.textBox4.Location = new System.Drawing.Point(223, 313);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 22);
            this.textBox4.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Id Minuman";
            // 
            // daftarmenuuDataSet
            // 
            this.daftarmenuuDataSet.DataSetName = "daftarmenuuDataSet";
            this.daftarmenuuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // minumanBindingSource2
            // 
            this.minumanBindingSource2.DataMember = "Minuman";
            this.minumanBindingSource2.DataSource = this.daftarmenuuDataSet;
            // 
            // minumanTableAdapter1
            // 
            this.minumanTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1137, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minumanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minumanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minumanBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private daftarmenuDataSet daftarmenuDataSet;
        private System.Windows.Forms.BindingSource minumanBindingSource;
        private daftarmenuDataSetTableAdapters.MinumanTableAdapter minumanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMinumanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kopiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alkoholDataGridViewTextBoxColumn;
        private daftarmenuDataSet daftarmenuDataSet1;
        private System.Windows.Forms.BindingSource minumanBindingSource1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private daftarmenuuDataSet daftarmenuuDataSet;
        private System.Windows.Forms.BindingSource minumanBindingSource2;
        private daftarmenuuDataSetTableAdapters.MinumanTableAdapter minumanTableAdapter1;
    }
}