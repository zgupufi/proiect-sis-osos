using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proiect_bio
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            lbl1.Visible = false;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int nota = 0;
            lbl2.Visible = false;
            lbl1.Visible = true;
            btnVer.Visible = false;
            string txt1 = textBox1.Text;
            Boolean equals1 = String.Equals(txt1, "atlas(c1)", StringComparison.OrdinalIgnoreCase);
            if (equals1 == true)
                textBox1.Visible = false;
            else
            {
                textBox1.Text = "ATLAS(C1)";
                textBox1.BackColor = Color.Red;
                nota++;
            }

            string txt2 = textBox2.Text;
            Boolean equals2 = String.Equals(txt2, "axis(c2)", StringComparison.OrdinalIgnoreCase);
            if (equals2 == true)
                textBox2.Visible = false;
            else
            {
                textBox2.Text = "AXIS(C2)";
                textBox2.BackColor = Color.Red;
                nota++;
            }

            string txt3 = textBox3.Text;
            Boolean equals3 = String.Equals(txt3, "cervicale 3-7", StringComparison.OrdinalIgnoreCase);
            if (equals3 == true)
                textBox3.Visible = false;
            else
            {
                textBox3.Text = "CERVICALE 3-7";
                textBox3.BackColor = Color.Red;
                nota++;
            }

            string txt4 = textBox4.Text;
            Boolean equals4 = String.Equals(txt4, "toracale 1-12", StringComparison.OrdinalIgnoreCase);
            if (equals4 == true)
                textBox4.Visible = false;
            else
            {
                textBox4.Text = "TORACALE 1-12";
                textBox4.BackColor = Color.Red;
                nota++;
            }

            string txt5 = textBox5.Text;
            Boolean equals5 = String.Equals(txt5, "lombare 1-5", StringComparison.OrdinalIgnoreCase);
            if (equals5 == true)
                textBox5.Visible = false;
            else
            {
                textBox5.Text = "LOMBARE 1-5";
                textBox5.BackColor = Color.Red;
                nota++;
            }

            string txt6 = textBox6.Text;
            Boolean equals6 = String.Equals(txt6, "sacrum", StringComparison.OrdinalIgnoreCase);
            if (equals6 == true)
                textBox6.Visible = false;
            else
            {
                textBox6.Text = "SACRUM";
                textBox6.BackColor = Color.Red;
                nota++;
            }

            string txt7 = textBox7.Text;
            Boolean equals7 = String.Equals(txt7, "coccis", StringComparison.OrdinalIgnoreCase);
            if (equals7 == true)
                textBox7.Visible = false;
            else
            {
                textBox7.Text = "COCCIS";
                textBox7.BackColor = Color.Red;
                nota++;
            }
            lbl1.Text = "Ai raspuns corect la " + (7 - nota) + "/7";
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
        }
    }
}
