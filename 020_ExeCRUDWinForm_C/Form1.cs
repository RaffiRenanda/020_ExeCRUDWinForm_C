using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;

namespace _020_ExeCRUDWinForm_C
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4S8UKI2A\RAFFIRENANDA;Initial Catalog=Korim;User ID=sa;Password=12345678");
        public Form1()
        {
            InitializeComponent();
            display();
        }
        string Jenis_Kelamin;
        SqlCommand cmd;
        
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Anggota_Korim] (Nomor_Anggota,Nama_Anggota,Lokasi_Dinas,Jabatan,Tanggal_Lahir,Jenis_Kelamin,Alamat) values ('" + textBoxNomor.Text + "','" + textBoxNama.Text + "','" + textBoxLokasiDinas.Text + "','" + textBoxJabatan.Text + "','" + dateTimePicker1.Text + "','" + Jenis_Kelamin + "','" + textBoxAlamat.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            textBoxNomor.Text = "";
            textBoxNama.Text = "";
            textBoxLokasiDinas.Text = "";
            textBoxJabatan.Text = "";
            textBoxAlamat.Text = "";
            radioButtonP.Checked = false;
            radioButtonW.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            MessageBox.Show("Data berhasil ditambah!");
            display();
        }

        private void radioButtonP_CheckedChanged(object sender, EventArgs e)
        {
            Jenis_Kelamin = "Pria";
        }

        private void radioButtonW_CheckedChanged(object sender, EventArgs e)
        {
            Jenis_Kelamin = "Wanita";
        }

        public void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Anggota_Korim]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dtadp = new SqlDataAdapter(cmd);
            dtadp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Anggota_Korim] where Nomor_Anggota = '" + textBoxHapus.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            textBoxHapus.Text = "";
            MessageBox.Show("Data berhasil dihapus!");
            display();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [Anggota_Korim] set Nomor_Anggota='" + this.textBoxNomor.Text + "',Nama_Anggota='" + this.textBoxNama.Text + "',Lokasi_Dinas='" + this.textBoxLokasiDinas.Text + "',Jabatan='" + this.textBoxJabatan.Text + "', Tanggal_Lahir='" + dateTimePicker1.Text + "', Jenis_Kelamin='" + Jenis_Kelamin + "', Alamat='" + this.textBoxAlamat.Text + "' where Nomor_Anggota='"+this.textBoxNomor.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            textBoxNomor.Text = "";
            textBoxNama.Text = "";
            textBoxLokasiDinas.Text = "";
            textBoxJabatan.Text = "";
            textBoxAlamat.Text = "";
            radioButtonP.Checked = false;
            radioButtonW.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            MessageBox.Show("Data berhasil diupdate!");
            display();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Anggota_Korim] where Nama_Anggota = '" + textBoxCari.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter datAdp = new SqlDataAdapter(cmd);
            datAdp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            textBoxCari.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNomor.Text = "";
            textBoxNama.Text = "";
            textBoxLokasiDinas.Text = "";
            textBoxJabatan.Text = "";
            textBoxAlamat.Text = "";
            radioButtonP.Checked = false;
            radioButtonW.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
        }

    }
}
