
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
            this.idMakananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makananBeratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makananRinganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makananBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.daftarmenuuDataSet = new ExeCRUD.daftarmenuuDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.daftarmenuDataSet = new ExeCRUD.daftarmenuDataSet();
            this.makananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makananTableAdapter = new ExeCRUD.daftarmenuDataSetTableAdapters.MakananTableAdapter();
            this.makananTableAdapter1 = new ExeCRUD.daftarmenuuDataSetTableAdapters.MakananTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.makananBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.makananBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.makananBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makananBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makananBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makananBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makananBindingSource4)).BeginInit();
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
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makananBindingSource3, "Snack", true));
            this.textBox1.Location = new System.Drawing.Point(232, 274);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makananBindingSource3, "Makanan_Ringan", true));
            this.textBox2.Location = new System.Drawing.Point(232, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makananBindingSource3, "Makanan_Berat", true));
            this.textBox3.Location = new System.Drawing.Point(232, 223);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 22);
            this.textBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Keluar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(285, 365);
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
            this.dataGridView1.DataSource = this.makananBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(495, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 201);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // makananBindingSource1
            // 
            this.makananBindingSource1.DataMember = "Makanan";
            this.makananBindingSource1.DataSource = this.daftarmenuuDataSet;
            // 
            // daftarmenuuDataSet
            // 
            this.daftarmenuuDataSet.DataSetName = "daftarmenuuDataSet";
            this.daftarmenuuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // makananTableAdapter1
            // 
            this.makananTableAdapter1.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(453, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Menu Minuman";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(626, 50);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Menu Dessert";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // makananBindingSource2
            // 
            this.makananBindingSource2.DataMember = "Makanan";
            this.makananBindingSource2.DataSource = this.daftarmenuDataSet;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makananBindingSource3, "Id_Makanan", true));
            this.textBox4.Location = new System.Drawing.Point(232, 322);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 22);
            this.textBox4.TabIndex = 19;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Id Makanan";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // makananBindingSource3
            // 
            this.makananBindingSource3.DataMember = "Makanan";
            this.makananBindingSource3.DataSource = this.daftarmenuDataSet;
            // 
            // makananBindingSource4
            // 
            this.makananBindingSource4.DataMember = "Makanan";
            this.makananBindingSource4.DataSource = this.daftarmenuuDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1129, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
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
            ((System.ComponentModel.ISupportInitialize)(this.makananBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarmenuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makananBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makananBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makananBindingSource4)).EndInit();
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.BindingSource makananBindingSource2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource makananBindingSource3;
        private System.Windows.Forms.BindingSource makananBindingSource4;
    }
}

