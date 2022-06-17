
namespace _020_ExeCRUDWinForm_C
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNomor = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxLokasiDinas = new System.Windows.Forms.TextBox();
            this.textBoxJabatan = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonP = new System.Windows.Forms.RadioButton();
            this.radioButtonW = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonInput = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxHapus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBoxHapus);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxCari);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonInput);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.textBoxAlamat);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.radioButtonW);
            this.panel1.Controls.Add(this.radioButtonP);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBoxJabatan);
            this.panel1.Controls.Add(this.textBoxLokasiDinas);
            this.panel1.Controls.Add(this.textBoxNama);
            this.panel1.Controls.Add(this.textBoxNomor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 622);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(94, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomor anggota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(220, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama anggota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(348, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lokasi dinas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(477, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jabatan";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(607, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tanggal lahir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Location = new System.Drawing.Point(830, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Jenis kelamin";
            // 
            // textBoxNomor
            // 
            this.textBoxNomor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNomor.Location = new System.Drawing.Point(97, 471);
            this.textBoxNomor.Name = "textBoxNomor";
            this.textBoxNomor.Size = new System.Drawing.Size(100, 22);
            this.textBoxNomor.TabIndex = 6;
            // 
            // textBoxNama
            // 
            this.textBoxNama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNama.Location = new System.Drawing.Point(223, 471);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(100, 22);
            this.textBoxNama.TabIndex = 7;
            // 
            // textBoxLokasiDinas
            // 
            this.textBoxLokasiDinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxLokasiDinas.Location = new System.Drawing.Point(351, 471);
            this.textBoxLokasiDinas.Name = "textBoxLokasiDinas";
            this.textBoxLokasiDinas.Size = new System.Drawing.Size(100, 22);
            this.textBoxLokasiDinas.TabIndex = 8;
            // 
            // textBoxJabatan
            // 
            this.textBoxJabatan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxJabatan.Location = new System.Drawing.Point(480, 471);
            this.textBoxJabatan.Name = "textBoxJabatan";
            this.textBoxJabatan.Size = new System.Drawing.Size(100, 22);
            this.textBoxJabatan.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(610, 472);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // radioButtonP
            // 
            this.radioButtonP.AutoSize = true;
            this.radioButtonP.ForeColor = System.Drawing.SystemColors.Menu;
            this.radioButtonP.Location = new System.Drawing.Point(833, 471);
            this.radioButtonP.Name = "radioButtonP";
            this.radioButtonP.Size = new System.Drawing.Size(54, 21);
            this.radioButtonP.TabIndex = 13;
            this.radioButtonP.TabStop = true;
            this.radioButtonP.Text = "Pria";
            this.radioButtonP.UseVisualStyleBackColor = true;
            this.radioButtonP.CheckedChanged += new System.EventHandler(this.radioButtonP_CheckedChanged);
            // 
            // radioButtonW
            // 
            this.radioButtonW.AutoSize = true;
            this.radioButtonW.ForeColor = System.Drawing.SystemColors.Menu;
            this.radioButtonW.Location = new System.Drawing.Point(833, 499);
            this.radioButtonW.Name = "radioButtonW";
            this.radioButtonW.Size = new System.Drawing.Size(73, 21);
            this.radioButtonW.TabIndex = 14;
            this.radioButtonW.TabStop = true;
            this.radioButtonW.Text = "Wanita";
            this.radioButtonW.UseVisualStyleBackColor = true;
            this.radioButtonW.CheckedChanged += new System.EventHandler(this.radioButtonW_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Menu;
            this.label7.Location = new System.Drawing.Point(298, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Alamat";
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxAlamat.Location = new System.Drawing.Point(301, 549);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(223, 40);
            this.textBoxAlamat.TabIndex = 16;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonClear.Location = new System.Drawing.Point(646, 549);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 30);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonInput
            // 
            this.buttonInput.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInput.Location = new System.Drawing.Point(552, 528);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 32);
            this.buttonInput.TabIndex = 18;
            this.buttonInput.Text = "Input";
            this.buttonInput.UseVisualStyleBackColor = false;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(833, 335);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(110, 28);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(552, 566);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 31);
            this.buttonUpdate.TabIndex = 20;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Location = new System.Drawing.Point(833, 392);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 30);
            this.button5.TabIndex = 21;
            this.button5.Text = "Cari";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxCari
            // 
            this.textBoxCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCari.Location = new System.Drawing.Point(97, 396);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(714, 22);
            this.textBoxCari.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Menu;
            this.label8.Location = new System.Drawing.Point(97, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cari anggota:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(846, 261);
            this.dataGridView1.TabIndex = 24;
            // 
            // textBoxHapus
            // 
            this.textBoxHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxHapus.Location = new System.Drawing.Point(97, 338);
            this.textBoxHapus.Name = "textBoxHapus";
            this.textBoxHapus.Size = new System.Drawing.Size(714, 22);
            this.textBoxHapus.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Menu;
            this.label9.Location = new System.Drawing.Point(97, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Hapus anggota (Nomor)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_020_ExeCRUDWinForm_C.Properties.Resources.LOGO_KOREM_072;
            this.pictureBox1.Location = new System.Drawing.Point(7, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1042, 621);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonW;
        private System.Windows.Forms.RadioButton radioButtonP;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxJabatan;
        private System.Windows.Forms.TextBox textBoxLokasiDinas;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNomor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxHapus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

