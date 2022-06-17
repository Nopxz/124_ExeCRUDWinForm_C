
namespace ExeCRUD
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
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
            this.dessertBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dessertTableAdapter = new ExeCRUD.daftarmenuDataSetTableAdapters.DessertTableAdapter();
            this.idDessertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iceCreamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daftarmenuDataSet1 = new ExeCRUD.daftarmenuDataSet();
            this.dessertBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.daftarmenuuDataSet = new ExeCRUD.daftarmenuuDataSet();
            this.dessertBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dessertTableAdapter1 = new ExeCRUD.daftarmenuuDataSetTableAdapters.DessertTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minumanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(397, 60);
            this.label5.TabIndex = 24;
            this.label5.Text = "Menu Dessert";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDessertDataGridViewTextBoxColumn,
            this.kueDataGridViewTextBoxColumn,
            this.buahDataGridViewTextBoxColumn,
            this.iceCreamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dessertBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(520, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(556, 203);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(276, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(177, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Keluar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dessertBindingSource2, "Buah", true));
            this.textBox3.Location = new System.Drawing.Point(223, 215);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 22);
            this.textBox3.TabIndex = 18;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dessertBindingSource2, "Kue", true));
            this.textBox2.Location = new System.Drawing.Point(223, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 22);
            this.textBox2.TabIndex = 17;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dessertBindingSource2, "Ice_Cream", true));
            this.textBox1.Location = new System.Drawing.Point(223, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Es Krim";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Buah";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kue";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 135);
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
            // dessertBindingSource
            // 
            this.dessertBindingSource.DataMember = "Dessert";
            this.dessertBindingSource.DataSource = this.daftarmenuDataSet;
            // 
            // dessertTableAdapter
            // 
            this.dessertTableAdapter.ClearBeforeFill = true;
            // 
            // idDessertDataGridViewTextBoxColumn
            // 
            this.idDessertDataGridViewTextBoxColumn.DataPropertyName = "Id_Dessert";
            this.idDessertDataGridViewTextBoxColumn.HeaderText = "Id_Dessert";
            this.idDessertDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDessertDataGridViewTextBoxColumn.Name = "idDessertDataGridViewTextBoxColumn";
            this.idDessertDataGridViewTextBoxColumn.Width = 125;
            // 
            // kueDataGridViewTextBoxColumn
            // 
            this.kueDataGridViewTextBoxColumn.DataPropertyName = "Kue";
            this.kueDataGridViewTextBoxColumn.HeaderText = "Kue";
            this.kueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kueDataGridViewTextBoxColumn.Name = "kueDataGridViewTextBoxColumn";
            this.kueDataGridViewTextBoxColumn.Width = 125;
            // 
            // buahDataGridViewTextBoxColumn
            // 
            this.buahDataGridViewTextBoxColumn.DataPropertyName = "Buah";
            this.buahDataGridViewTextBoxColumn.HeaderText = "Buah";
            this.buahDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buahDataGridViewTextBoxColumn.Name = "buahDataGridViewTextBoxColumn";
            this.buahDataGridViewTextBoxColumn.Width = 125;
            // 
            // iceCreamDataGridViewTextBoxColumn
            // 
            this.iceCreamDataGridViewTextBoxColumn.DataPropertyName = "Ice_Cream";
            this.iceCreamDataGridViewTextBoxColumn.HeaderText = "Ice_Cream";
            this.iceCreamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iceCreamDataGridViewTextBoxColumn.Name = "iceCreamDataGridViewTextBoxColumn";
            this.iceCreamDataGridViewTextBoxColumn.Width = 125;
            // 
            // daftarmenuDataSet1
            // 
            this.daftarmenuDataSet1.DataSetName = "daftarmenuDataSet";
            this.daftarmenuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dessertBindingSource1
            // 
            this.dessertBindingSource1.DataMember = "Dessert";
            this.dessertBindingSource1.DataSource = this.daftarmenuDataSet1;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dessertBindingSource2, "Id_Dessert", true));
            this.textBox4.Location = new System.Drawing.Point(223, 307);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 22);
            this.textBox4.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Id Dessert";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // daftarmenuuDataSet
            // 
            this.daftarmenuuDataSet.DataSetName = "daftarmenuuDataSet";
            this.daftarmenuuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dessertBindingSource2
            // 
            this.dessertBindingSource2.DataMember = "Dessert";
            this.dessertBindingSource2.DataSource = this.daftarmenuuDataSet;
            // 
            // dessertTableAdapter1
            // 
            this.dessertTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1135, 450);
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
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minumanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertBindingSource2)).EndInit();
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
        private System.Windows.Forms.BindingSource dessertBindingSource;
        private daftarmenuDataSetTableAdapters.DessertTableAdapter dessertTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDessertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iceCreamDataGridViewTextBoxColumn;
        private daftarmenuDataSet daftarmenuDataSet1;
        private System.Windows.Forms.BindingSource dessertBindingSource1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private daftarmenuuDataSet daftarmenuuDataSet;
        private System.Windows.Forms.BindingSource dessertBindingSource2;
        private daftarmenuuDataSetTableAdapters.DessertTableAdapter dessertTableAdapter1;
    }
}