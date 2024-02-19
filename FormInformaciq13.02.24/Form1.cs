namespace FormInformaciq13._02._24
{
    public partial class Form1 : Form
    {
        bool check = false;
        bool check2 = false;
        string gender;
        string hair;
        string eyes;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                gender = checkBox1.Text;
            }
            else
            {
                gender = "Жена";
            }


            if (rdCherni.Checked)
            {
                eyes = rdCherni.Text;
                check2 = true;
            }
            else
                if (rdKafefi.Checked)
            {
                eyes = rdKafefi.Text;
                check2 = true;
            }
            else
                if (rdPastri.Checked)
            {
                eyes = rdPastri.Text;
                check2 = true;
            }
            else
                if (rdZeleni.Checked)
            {
                eyes = rdZeleni.Text;
                check2 = true;
            }
            else
                if (rdSini.Checked)
            {
                eyes = rdSini.Text;
                check2 = true;
            }
            else
                if (rdCherveni.Checked)
            {
                eyes = rdCherveni.Text;
                check2 = true;
            }



            if (rdRijav.Checked)
            {
                hair = rdRijav.Text;
                check = true;

            }
            if (rdBlondi.Checked)
            {
                hair = rdBlondi.Text;
                check = true;

            }
            if (rdBrunet.Checked)
            {
                hair = rdBrunet.Text;
                check = true;

            }


            if (check == false || check2 == false)
            {
                MessageBox.Show("Не си въвел ...");
                return;
            }
            else
            {
                MessageBox.Show($"Ти си {textBox1.Text} и си {gender}" +
      $"\n Имаш {hair} коса и {eyes} очи.");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
