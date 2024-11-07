using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnb_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;

            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;

            label5.Text = btnb.Text;
            
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogruno.Text = dogru.ToString();
                pictureBox1 .Visible = true;               
                
            }
            else
            {
                yanlis++;
                lblyanlisno.Text = yanlis.ToString();
                pictureBox2 .Visible = true;
            }



        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;

            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;

            label5.Text = btnc.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogruno.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblyanlisno.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;

            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;

            label5.Text = btnd.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogruno.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblyanlisno.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btna_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;   
            btnb.Enabled = false;
            btnc.Enabled = false;   
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label5.Text = btna.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogruno.Text = dogru.ToString();
                pictureBox1 .Visible = true;               
                
            }
            else
            {
                yanlis++;
                lblyanlisno.Text = yanlis.ToString();
                pictureBox2 .Visible = true;
            }

        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible=false;
            pictureBox2.Visible=false;
            btna.Enabled=true;
            btnb.Enabled=true;
            btnc.Enabled=true;
            btnd.Enabled=true;
            btnsonraki.Enabled=false;
            
            
            soruno++;
            lblsoruno.Text = soruno.ToString();

            string s1, s2, s3, s4, s5;
            s1 = "Python programlama dilinde bir listeyi nasıl tanımlarsınız?";
            s2 = "HTML'de metni kalın yapmak için hangi etiket kullanılır??";
            s3 = "C programlama dilinde bir değişken nasıl tanımlanır?";
            s4 = "CSS ile bir elementin rengini kırmızı yapmak için hangi ifade kullanılır?";
            s5 = "avaScript'te bir fonksiyon nasıl tanımlanır?";

            if (soruno == 1) {

                richTextBox1.Text = s1;
                btna.Text = "list = {1, 2, 3, 4}";
                btnb.Text = "list = (1, 2, 3, 4)";
                btnc.Text = "list = [1, 2, 3, 4]";
                btnd.Text = "list = <1, 2, 3, 4>";
                label4.Text = "list = [1, 2, 3, 4]";
            }
            else if (soruno == 2) {
                richTextBox1.Text = s2;
                btna.Text = "<bold>";
                btnb.Text = "<b>";
                btnc.Text = "<strong>";
                btnd.Text = "<em>";
                label4.Text = "<b>";
            }
            else if (soruno==3)
            {
                richTextBox1.Text = s3;
                btna.Text = "int number;";
                btnb.Text = "define number = 10;";
                btnc.Text = "var number = 10;";
                btnd.Text = "number := 10";
                label4.Text = "int number;";

            }
            else  if (soruno == 4)
            {
                richTextBox1.Text = s4;
                btna.Text = "color: \"red\";";
                btnb.Text = "text-color: red;";
                btnc.Text = "font-color: #ff0000;";
                btnd.Text = "color: red;";
                label4.Text = "color: red;";
            }  
            else if(soruno == 5)
            {
                richTextBox1.Text = s4;
                btna.Text = "function myFunction() {}";
                btnb.Text = "func myFunction() {}";
                btnc.Text = "define myFunction() {}";
                btnd.Text = "fn myFunction() {}";
                label4.Text = "function myFunction() {}";
                btnsonraki.Text = "SONUÇLAR";
            }

            if (soruno == 6)
            {
                btna.Visible = false;
                btnb.Visible = false;
                btnc.Visible = false;
                btnd.Visible = false;
                MessageBox.Show("Doğru " + dogru + "\n" + "Yanlış " + yanlis);

                    

            }





        }
    }
}
