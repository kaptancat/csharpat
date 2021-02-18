git uzaktan kaynak ekle https://github.com/kaptancat/c-.git
 git şube -M ana 
git itme -u kaynak ana
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsol, ikinciatsol, ucuncuatsol;
        int derece;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           derece = Convert.ToInt32(label7.Text);
            derece++;
            label7.Text = derece.ToString();
            int birinciatgenişliği = pictureBox1.Width;
            int ikinciatgenişliği = pictureBox2.Width;
            int ucuncuatgenişliği = pictureBox3.Width;
            int bitisuzaklığı = label5.Left; //label5 in sonu bitiş uzaklığımız


            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);



            if(pictureBox1.Left>pictureBox2.Left+5 &&pictureBox1.Left>pictureBox3.Left+5)//5 pixcel fazla olmalı ki önde diyelim
            {
                label6.Text = "1 numaralı at yarışı önde götürüyor";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "2 numaralı at iyi bir atakla öne geçti";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left+5)
            {
                label6.Text = "3 numaralı at liderliği ele geçirdi";
            }
            if (birinciatgenişliği + pictureBox1.Left >= bitisuzaklığı)
            {
                timer1.Enabled = false;
                label6.Text="1 numaralı at kazandı!!";
                button2.Enabled = true;


            }
            if (ikinciatgenişliği + pictureBox2.Left >= bitisuzaklığı)
            {
                timer1.Enabled = false;
              label6.Text= "2 numaralı at yarışı kazandı!!";
                button2.Enabled = true;

            }
            if (ucuncuatgenişliği + pictureBox3.Left >= bitisuzaklığı)
            {
                timer1.Enabled = false;
              label6.Text= "3 numaralı at yarışı kazandı!!";
                button2.Enabled = true;

            }


        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Width >= label5.Width)
            {
                pictureBox1.Left = 0;
                label6.Text = "";
                label7.Text = "";
                pictureBox1.Left = 0;
                pictureBox1.ToString();

            }
            if (pictureBox2.Width >= label5.Width)
            {
                label6.Text = "";
                label7.Text = "";
                pictureBox2.Left = 0;
                pictureBox2.ToString();

            }
            if (pictureBox3.Width >= label5.Width)
            {
                label6.Text = "";
                label7.Text = "";
                pictureBox3.Left = 0;
                pictureBox3.ToString();
            }

        }

        Random rastgele = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsol = pictureBox1.Left;
            ikinciatsol = pictureBox2.Left;
            ucuncuatsol = pictureBox3.Left;

        }
    }
}
