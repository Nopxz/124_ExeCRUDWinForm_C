
namespace ExeCRUD
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.daftarmenuDataSet = new ExeCRUD.daftarmenuDataSet();
            this.makananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makananTableAdapter = new ExeCRUD.daftarmenuDataSetTableAdapters.MakananTableAdapter();
            this.idMakananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makananBeratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makananRinganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daftarmenuuDataSet = new ExeCRUD.daftarmenuuDataSet();
            this.makananBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.makananTableAdapter1 = new ExeCRUD.daftarmenuuDataSetTableAdapters.MakananTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makananBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Makanan Ringan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Makanan Berat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Snack";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 274);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(232, 223);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 22);
            this.textBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Keluar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(285, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMakananDataGridViewTextBoxColumn,
            this.makananBeratDataGridViewTextBoxColumn,
            this.makananRinganDataGridViewTextBoxColumn,
            this.snackDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.makananBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(411, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(387, 201);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(397, 60);
            this.label5.TabIndex = 12;
            this.label5.Text = "Menu Makanan";
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(87, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // daftarmenuDataSet
            // 
            this.daftarmenuDataSet.DataSetName = "daftarmenuDataSet";
            this.daftarmenuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // makananBindingSource
            // 
            this.makananBindingSource.DataMember = "Makanan";
            this.makananBindingSource.DataSource = this.daftarmenuDataSet;
            // 
            // makananTableAdapter
            // 
            this.makananTableAdapter.ClearBeforeFill = true;
            // 
            // idMakananDataGridViewTextBoxColumn
            // 
            this.idMakananDataGridViewTextBoxColumn.DataPropertyName = "Id_Makanan";
            this.idMakananDataGridViewTextBoxColumn.HeaderText = "Id_Makanan";
            this.idMakananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMakananDataGridViewTextBoxColumn.Name = "idMakananDataGridViewTextBoxColumn";
            this.idMakananDataGridViewTextBoxColumn.Width = 125;
            // 
            // makananBeratDataGridViewTextBoxColumn
            // 
            this.makananBeratDataGridViewTextBoxColumn.DataPropertyName = "Makanan_Berat";
            this.makananBeratDataGridViewTextBoxColumn.HeaderText = "Makanan_Berat";
            this.makananBeratDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.makananBeratDataGridViewTextBoxColumn.Name = "makananBeratDataGridViewTextBoxColumn";
            this.makananBeratDataGridViewTextBoxColumn.Width = 125;
            // 
            // makananRinganDataGridViewTextBoxColumn
            // 
            this.makananRinganDataGridViewTextBoxColumn.DataPropertyName = "Makanan_Ringan";
            this.makananRinganDataGridViewTextBoxColumn.HeaderText = "Makanan_Ringan";
            this.makananRinganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.makananRinganDataGridViewTextBoxColumn.Name = "makananRinganDataGridViewTextBoxColumn";
            this.makananRinganDataGridViewTextBoxColumn.Width = 125;
            // 
            // snackDataGridViewTextBoxColumn
            // 
            this.snackDataGridViewTextBoxColumn.DataPropertyName = "Snack";
            this.snackDataGridViewTextBoxColumn.HeaderText = "Snack";
            this.snackDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snackDataGridViewTextBoxColumn.Name = "snackDataGridViewTextBoxColumn";
            this.snackDataGridViewTextBoxColumn.Width = 125;
            // 
            // daftarmenuuDataSet
            // 
            this.daftarmenuuDataSet.DataSetName = "daftarmenuuDataSet";
            this.daftarmenuuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // makananBindingSource1
            // 
            this.makananBindingSource1.DataMember = "Makanan";
            this.makananBindingSource1.DataSource = this.daftarmenuuDataSet;
            // 
            // makananTableAdapter1
            // 
            this.makananTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makananBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private daftarmenuDataSet daftarmenuDataSet;
        private System.Windows.Forms.BindingSource makananBindingSource;
        private daftarmenuDataSetTableAdapters.MakananTableAdapter makananTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMakananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makananBeratDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makananRinganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snackDataGridViewTextBoxColumn;
        private daftarmenuuDataSet daftarmenuuDataSet;
        private System.Windows.Forms.BindingSource makananBindingSource1;
        private daftarmenuuDataSetTableAdapters.MakananTableAdapter makananTableAdapter1;
    }
}

