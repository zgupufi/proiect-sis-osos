using proiect_bio.Properties;
using System.Xml;

namespace proiect_bio
{
    public partial class Form1 : Form
    {
        int nota = 0;
        public Form1()
        {
            
            InitializeComponent();
            btnm.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            lbl2.Visible = false;
            btnVer.Visible = false;
            label4.Visible = false;
            
        }
        

            private void btnStart_Click(object sender, EventArgs e)
        {
            btnm.Visible = true;
            btni.Visible = false;
            btnt.Visible = false;
            btnc.Visible = false;
            btnv.Visible = false;

            btnVer.Visible = true;
            btnStart.Visible = false;
            lbl1.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            lbl2.Visible = true;
            picBox.Image = Resources.POZA1;
            ///verific daca e raspunsul corect
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            ///verificam daca sunt corecte raspunsurile
            ///txtbox4
            string txt4 = textBox4.Text;
           /// Boolean equals = String.Equals(txt4, "omoplat", StringComparison.OrdinalIgnoreCase);
            Boolean equals4 = String.Equals(txt4, "scapula", StringComparison.OrdinalIgnoreCase);
            if (equals4 == true)
                textBox4.Visible = false;
            else
            {
                textBox4.Text = "SCAPULA";
                textBox4.BackColor = Color.Red;
                nota++;
            }
            

            ///txtbox3
            string txt3 = textBox3.Text;
            Boolean equals3 = String.Equals(txt3, "clavicula", StringComparison.OrdinalIgnoreCase);
            if (equals3 == true)
                textBox3.Visible = false;
            else
            {
                textBox3.Text = "CLAVICULA";
                textBox3.BackColor = Color.Red;
                nota++;
            }

            ///txtbox5
            string txt5 = textBox5.Text;
            Boolean equals5 = String.Equals(txt5, "humerus", StringComparison.OrdinalIgnoreCase);
            if (equals5 == true)
                textBox5.Visible = false;
            else
            {
                textBox5.Text = "HUMERUS";
                textBox5.BackColor = Color.Red;
                nota++;
            }
            ///txtbox6
            string txt6 = textBox6.Text;
            Boolean equals6 = String.Equals(txt6, "radius", StringComparison.OrdinalIgnoreCase);
            if (equals6 == true)
                textBox6.Visible = false;
            else
            {
                textBox6.Text = "RADIUS";
                textBox6.BackColor = Color.Red;
                nota++;
            }

            ///txtbox2
            string txt2 = textBox2.Text;
            Boolean equals2 = String.Equals(txt2, "ulna", StringComparison.OrdinalIgnoreCase);
            if (equals2 == true)
                textBox2.Visible = false;
            else
            {
                textBox2.Text = "ULNA";
                textBox2.BackColor = Color.Red;
                nota++;
            }
            ///txtbox7
            string txt7 = textBox7.Text;
            Boolean equals7 = String.Equals(txt7, "carpiene", StringComparison.OrdinalIgnoreCase);
            if (equals7 == true)
                textBox7.Visible = false;
            else
            {
                textBox7.Text = "CARPIENE";
                textBox7.BackColor = Color.Red;
                nota++;
            }
            ///txtbox1
            string txt1 = textBox1.Text;
            Boolean equals1 = String.Equals(txt1, "metacarpiene", StringComparison.OrdinalIgnoreCase);
            if (equals1 == true)
                textBox1.Visible = false;
            else
            {
                textBox1.Text = "METACARPIENE";
                textBox1.BackColor = Color.Red;
                nota++;
            }
            ///txtbox8
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
            label4.Visible = true;
            btnVer.Visible = false;
            lbl2.Text = "Ai rãspuns corect la";
            label4.Text = "" + (8-nota) +"/8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void btnt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void btnv_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void btnm_Click(object sender, EventArgs e)
        {
            btnm.Visible = false;
            btni.Visible = true;
            btnt.Visible = true;
            btnc.Visible = true;
            btnv.Visible = true;
            label4.Visible = false;
            btnVer.Visible = false;
            btnStart.Visible = true;
            lbl1.Visible = true;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            lbl2.Visible = false;
            picBox.Image = Resources.human_skeleton_diagram_3_350;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}