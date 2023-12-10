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
    public partial class Form5 : Form
    {
        int nota = 0;
        
        public Form5()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            lbl1.Visible = true;
            btnVer.Visible = false;
            lbl2.Visible = false;
            string txt1= textBox1.Text;
            Boolean equals1 = String.Equals(txt1, "manubriul", StringComparison.OrdinalIgnoreCase);
            Boolean equals1x = String.Equals(txt1, "manubriu", StringComparison.OrdinalIgnoreCase);
            if (equals1 == true || equals1x == true)
                textBox1.Visible = false;
            else
            {
                textBox1.Text = "MANUBRIUL";
                textBox1.BackColor = Color.Red;
                nota++;
            }

            string txt2 = textBox2.Text;
            Boolean equals2 = String.Equals(txt2, "corpul sternului", StringComparison.OrdinalIgnoreCase);
            if (equals2 == true)
                textBox2.Visible = false;
            else
            {
                textBox2.Text = "CORPUL STERNULUI";
                textBox2.BackColor = Color.Red;
                nota++;
            }

            string txt3 = textBox3.Text;
            Boolean equals3 = String.Equals(txt3, "Procesul xifoidian", StringComparison.OrdinalIgnoreCase);
            if (equals3 == true)
                textBox3.Visible = false;
            else
            {
                textBox3.Text = "PROCESUL XIFOIDIAN";
                textBox3.BackColor = Color.Red;
                nota++;
            }

            string txt4 = textBox4.Text;
            Boolean equals4 = String.Equals(txt4, "stern", StringComparison.OrdinalIgnoreCase);
            Boolean equals4x = String.Equals(txt4, "sternul", StringComparison.OrdinalIgnoreCase);
            if (equals4 == true || equals4x==true)
                textBox4.Visible = false;
            else
            {
                textBox4.Text = "STERNUL";
                textBox4.BackColor = Color.Red;
                nota++;
            }

            string txt5 = textBox5.Text;
            Boolean equals5 = String.Equals(txt5, "cartilaj costal", StringComparison.OrdinalIgnoreCase);
            if (equals5 == true)
                textBox5.Visible = false;
            else
            {
                textBox5.Text = "CARTILAJ COSTAL";
                textBox5.BackColor = Color.Red;
                nota++;
            }

            string txt6 = textBox6.Text;
            Boolean equals6 = String.Equals(txt6, "coaste adevarate", StringComparison.OrdinalIgnoreCase);
            if (equals6 == true)
                textBox6.Visible = false;
            else
            {
                textBox6.Text = "COASTE ADEVARATE";
                textBox6.BackColor = Color.Red;
                nota++;
            }

            string txt7 = textBox7.Text;
            Boolean equals7 = String.Equals(txt7, "coaste false", StringComparison.OrdinalIgnoreCase);
            if (equals7 == true)
                textBox7.Visible = false;
            else
            {
                textBox7.Text = "COASTE FALSE";
                textBox7.BackColor = Color.Red;
                nota++;
            }

            string txt9 = textBox9.Text;
            Boolean equals9 = String.Equals(txt9, "vertebre", StringComparison.OrdinalIgnoreCase);
            if (equals9 == true)
                textBox9.Visible = true;
            else
            {
                textBox9.Text = "VERTEBRE";
                textBox9.BackColor = Color.Red;
                nota++;
            }
            
            string txt8 = textBox8.Text;
            Boolean equals8 = String.Equals(txt8, "coaste plutitoare", StringComparison.OrdinalIgnoreCase);
            Boolean equals8x = String.Equals(txt8, "coaste flotante", StringComparison.OrdinalIgnoreCase);
            if (equals8 == true || equals8x==true)
                textBox8.Visible = true;
            else
            {
                textBox8.Text = "COASTE PLUTITOARE (FLOTANTE)";
                textBox8.BackColor = Color.Red;
                nota++;
            }

            
            lbl1.Text = "Ai raspuns corect la " + (9 - nota) + "/9";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
        }
    }
}
