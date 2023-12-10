using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_bio
{
    public partial class Form2 : Form
    {int nota = 0;
        public Form2()
        {
            InitializeComponent();
            lbl1.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Form1"].Close();//sa inchid formu unu

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            lbl2.Visible = false;
            lbl1.Visible = true;
            btnVer.Visible = false;
            int nota = 0;
            string txt1 = textBox1.Text;
            Boolean equals1 = String.Equals(txt1, "iliac", StringComparison.OrdinalIgnoreCase);
            if (equals1 == true)
                textBox1.Visible = false;
            else
            {
                textBox1.Text = "ILIAC";
                textBox1.BackColor = Color.Red;
                nota++;
            }

            string txt2 = textBox2.Text;
            Boolean equals2 = String.Equals(txt2, "sacral", StringComparison.OrdinalIgnoreCase);
            if (equals2 == true)
                textBox2.Visible = false;
            else
            {
                textBox2.Text = "SACRAL";
                textBox2.BackColor = Color.Red;
                nota++;
            }

            string txt3 = textBox3.Text;
            Boolean equals3 = String.Equals(txt3, "femur", StringComparison.OrdinalIgnoreCase);
            if (equals3 == true)
                textBox3.Visible = false;
            else
            {
                textBox3.Text = "FEMUR";
                textBox3.BackColor = Color.Red;
                nota++;
            }


            string txt4 = textBox4.Text;
            Boolean equals4 = String.Equals(txt4, "patela", StringComparison.OrdinalIgnoreCase);
            if (equals4 == true)
                textBox4.Visible = false;
            else
            {
                textBox4.Text = "PATELA";
                textBox4.BackColor = Color.Red;
                nota++;
            }


            string txt5 = textBox5.Text;
            Boolean equals5 = String.Equals(txt5, "tibie", StringComparison.OrdinalIgnoreCase);
            if (equals5 == true)
                textBox5.Visible = false;
            else
            {
                textBox5.Text = "TIBIA";
                textBox5.BackColor = Color.Red;
                nota++;
            }


            string txt6 = textBox6.Text;
            Boolean equals6 = String.Equals(txt6, "tarsiene", StringComparison.OrdinalIgnoreCase);
            if (equals6 == true)
                textBox6.Visible = false;
            else
            {
                textBox6.Text = "TARSIENE";
                textBox6.BackColor = Color.Red;
                nota++;
            }


            string txt7 = textBox7.Text;
            Boolean equals7 = String.Equals(txt7, "metatarsiene", StringComparison.OrdinalIgnoreCase);
            if (equals7 == true)
                textBox7.Visible = false;
            else
            {
                textBox7.Text = "METATARSIENE";
                textBox7.BackColor = Color.Red;
                nota++;
            }


            string txt8 = textBox8.Text;
            Boolean equals8 = String.Equals(txt8, "falange", StringComparison.OrdinalIgnoreCase);
            if (equals8 == true)
                textBox8.Visible = false;
            else
            {
                textBox8.Text = "FALANGE";
                textBox8.BackColor = Color.Red;
                nota++;
            }
            lbl1.Text = "Ai raspuns corect la " + (8 - nota) + "/8";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ///Form1 frm1 =new Form1();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
        }
    }
}
