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
    public partial class Form3 : Form
    {
        int nota = 0;
        
        public Form3()
        {
            InitializeComponent();
            lbl1.Visible= false;
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            
            btnVer.Visible = false;
            lbl2.Visible= false;
            string txt1 = textBox1.Text;
            Boolean equals1 = String.Equals(txt1, "frontal", StringComparison.OrdinalIgnoreCase);
            if (equals1 == true)
                textBox1.Visible = false;
            else
            {
                textBox1.Text = "FRONTAL";
                textBox1.BackColor = Color.Red;
                nota++;
            } 
            
            string txt2 = textBox2.Text;
            Boolean equals2 = String.Equals(txt2, "parietal", StringComparison.OrdinalIgnoreCase);
            if (equals2 == true)
                textBox2.Visible = false;
            else
            {
                textBox2.Text = "PARIETAL";
                textBox2.BackColor = Color.Red;
                nota++;
            } 
            
            string txt3 = textBox3.Text;
            Boolean equals3 = String.Equals(txt3, "temporal", StringComparison.OrdinalIgnoreCase);
            if (equals3 == true)
                textBox3.Visible = false;
            else
            {
                textBox3.Text = "TEMPORAL";
                textBox3.BackColor = Color.Red;
                nota++;
            } 
            
            string txt4 = textBox4.Text;
            Boolean equals4 = String.Equals(txt4, "etmoid", StringComparison.OrdinalIgnoreCase);
            if (equals4 == true)
                textBox4.Visible = false;
            else
            {
                textBox4.Text = "ETMOID";
                textBox4.BackColor = Color.Red;
                nota++;
            }
            
            string txt5 = textBox5.Text;
            Boolean equals5 = String.Equals(txt5, "zigomatic", StringComparison.OrdinalIgnoreCase);
            if (equals5 == true)
                textBox5.Visible = false;
            else
            {
                textBox5.Text = "ZIGOMATIC";
                textBox5.BackColor = Color.Red;
                nota++;
            } 
            
            string txt6 = textBox6.Text;
            Boolean equals6 = String.Equals(txt6, "maxilar", StringComparison.OrdinalIgnoreCase);
            if (equals6 == true)
                textBox6.Visible = false;
            else
            {
                textBox6.Text = "MAXILAR";
                textBox6.BackColor = Color.Red;
                nota++;
            } 
            
            string txt7 = textBox7.Text;
            Boolean equals7 = String.Equals(txt7, "mandibula", StringComparison.OrdinalIgnoreCase);
            if (equals7 == true)
                textBox7.Visible = false;
            else
            {
                textBox7.Text = "MANDIBULA";
                textBox7.BackColor = Color.Red;
                nota++;
            } 
            
            string txt8 = textBox8.Text;
            Boolean equals8 = String.Equals(txt8, "nazal", StringComparison.OrdinalIgnoreCase);
            if (equals8 == true)
                textBox8.Visible = false;
            else
            {
                textBox8.Text = "NAZAL";
                textBox8.BackColor = Color.Red;
                nota++;
            }  
            
            string txt9 = textBox9.Text;
            Boolean equals9 = String.Equals(txt9, "sfenoid", StringComparison.OrdinalIgnoreCase);
            if (equals9 == true)
                textBox9.Visible = false;
            else
            {
                textBox9.Text = "SFENOID";
                textBox9.BackColor = Color.Red;
                nota++;
            } 
            
            string txt10 = textBox10.Text;
            Boolean equals10 = String.Equals(txt10, "lacrimal", StringComparison.OrdinalIgnoreCase);
            if (equals10 == true)
                textBox10.Visible = false;
            else
            {
                textBox10.Text = "LACRIMAL";
                textBox10.BackColor = Color.Red;
                nota++;
            } 
            
            string txt11 = textBox11.Text;
            Boolean equals11 = String.Equals(txt11, "vomer", StringComparison.OrdinalIgnoreCase);
            if (equals11 == true)
                textBox11.Visible = false;
            else
            {
                textBox11.Text = "VOMER";
                textBox11.BackColor = Color.Red;
                nota++;
            }
            lbl1.Visible = true;
            lbl1.Text = "Ai raspuns corect la " + (11 - nota) + "/11";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
        }
    }
}
