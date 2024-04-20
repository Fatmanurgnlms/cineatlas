using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cineatlass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | .png | JPG-JPEG |.jpg;.jpeg | All Files |";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlemini bu alanda ya da bu kısımda gerçekleştrieceğizz.
                pictureBox6.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | .png | JPG-JPEG |.jpg;.jpeg | All Files |";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlemini bu alanda ya da bu kısımda gerçekleştrieceğizz.
                pictureBox8.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | .png | JPG-JPEG |.jpg;.jpeg | All Files |";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlemini bu alanda ya da bu kısımda gerçekleştrieceğizz.
                pictureBox5.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | .png | JPG-JPEG |.jpg;.jpeg | All Files |";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlemini bu alanda ya da bu kısımda gerçekleştrieceğizz.
                pictureBox7.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | .png | JPG-JPEG |.jpg;.jpeg | All Files |";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlemini bu alanda ya da bu kısımda gerçekleştrieceğizz.
                pictureBox9.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | .png | JPG-JPEG |.jpg;.jpeg | All Files |";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlemini bu alanda ya da bu kısımda gerçekleştrieceğizz.
                pictureBox6.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | .png | JPG-JPEG |.jpg;.jpeg | All Files |";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlemini bu alanda ya da bu kısımda gerçekleştrieceğizz.
                pictureBox11.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | .png | JPG-JPEG |.jpg;.jpeg | All Files |";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlemini bu alanda ya da bu kısımda gerçekleştrieceğizz.
                pictureBox12.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | .png | JPG-JPEG |.jpg;.jpeg | All Files |";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlemini bu alanda ya da bu kısımda gerçekleştrieceğizz.
                pictureBox10.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
