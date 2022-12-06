using FigthClub.Models;

namespace FigthClub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        /*burada alaca��m�z hasar� ve verilen hasar kodlar�n� metod �eklinde a�a��daki gibi yazd�k 
              */
        public void Hasar ()
        {
            lblHasar.Text = "Muhammed Aliye hasar verildi";
            lblHasar2.Text= "Hasar al�nd�";
        }
        public void Hasar (int saldiriTuru)
        {
            lblHasar.Text = "Muhammed Aliye " + saldiriTuru + " ile hasar verildi.";
            lblHasar2.Text= "D��mandan " + saldiriTuru + " ile hasar al�nd�.";
        }
        /*burada formun ba�lang�c�nda g�r�nmeyecek bilgileri veriyoruz
         - Se� butonuna basana kadar ekranda, se�im k�sm� d���nda bir tool g�z�kmeyecek.
              */


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Figth Club Game";
            pictureBox1.Visible = false;
            pictureBoxJ.Visible = false;
            pictureBoxJc.Visible = false;
            pictureBoxT.Visible = false;
            pictureBoxY.Visible = false;
            lblHealth.Visible = false;
            lblHealtht2.Visible = false;
            lblHasar.Visible = false;
            lblHasar2.Visible=false;
            btnAttack.Visible = false;
            btnStart.Visible=false;
            label5.Visible = false;
            label6.Visible = false;
            
           

        }
        Character character = new Character();
        /*burada Se� butonuna bas�ld��� anda butonlar ve ilgili resimler can bar� ve al�nacak hasar labeli
         ekrana gelecek ve Se� butonuna bast�ktan sonra art�k textboxlar de�i�tirelemez , se� butonu
             pasif olacak.
           */

        private void btnChoose_Click(object sender, EventArgs e)
        {
            btnAttack.Visible = true;
            btnStart.Visible = true;
            character.Name = txtName.Text;
            character.Figther = cmbFighter.SelectedItem.ToString();
            character.Branch = cmbBranch.SelectedItem.ToString();
            pictureBox1.Visible = true;
            lblHealth.Visible = true;
            btnChoose.Enabled = false;
            txtName.Enabled = false;
            cmbBranch.Enabled = false;
            cmbFighter.Enabled = false;
            if (cmbFighter.SelectedItem.ToString()== "Turabi")
            {
                pictureBoxT.Visible = true;
                lblHealtht2.Visible = true;
            }
            if (cmbFighter.SelectedItem.ToString() == "Yuri boyka")
            {
                pictureBoxY.Visible = true;
                lblHealtht2.Visible = true;
            }
            if (cmbFighter.SelectedItem.ToString() == "Jet Li")
            {
                pictureBoxJ.Visible = true;
                lblHealtht2.Visible = true;
            }
            if (cmbFighter.SelectedItem.ToString() == "Jackie Chan")
            {
                pictureBoxJc.Visible = true;
                lblHealtht2.Visible = true;
            }
            lblHasar.Visible = true;
            lblHasar2.Visible = true;

        }
        /*burada butona her t�kland���nda al�nan hasar ve miktar� verilen hasar ve miktar� oyun sounucu kimin kazan�p
         * kimin kaybetti�i g�sterilmektedir*/

        private void btnAttack_Click(object sender, EventArgs e)
        {
            
            character.Attack();
            
            
            lblHealth.Width = lblHealth.Width - character.Damage;
            lblHealtht2.Width=lblHealtht2.Width - character.Damage2;
            int sonuc = Convert.ToInt32(lblHealth.Width);
            Hasar(sonuc);
            int sonuc2 = Convert.ToInt32(lblHealtht2.Width);
            Hasar(sonuc2);

            /*burada oyun sonunda kimin kazand��� kimin hayatta kald���n�n resmi g�steriliyor 
             */

            if (lblHealth.Width <= 0)
            {
                
                MessageBox.Show("Tebrikler Kazand�n: "+"  "+txtName.Text);
                pictureBox1.Visible = false;
                lblHasar.Visible=false;
                label5.Visible = true;
             
            }
            if (lblHealtht2.Width<=0)
            {
                MessageBox.Show(txtName.Text+"  "+"Kaybettiniz");

                label6.Visible = true;
                if (cmbFighter.SelectedItem.ToString() == "Turabi")
                {
                    pictureBoxT.Visible = false;
                    lblHealtht2.Visible = false;
                }
                if (cmbFighter.SelectedItem.ToString() == "Yuri boyka")
                {
                    pictureBoxY.Visible = false;
                    lblHealtht2.Visible = false;
                }
                if (cmbFighter.SelectedItem.ToString() == "Jet Li")
                {
                    pictureBoxJ.Visible = false;
                    lblHealtht2.Visible = false;
                }
                if (cmbFighter.SelectedItem.ToString() == "Jackie Chan")
                {
                    pictureBoxJc.Visible = false;
                    lblHealtht2.Visible = false;
                }
                lblHasar.Visible = false;
                lblHasar2.Visible = false;

            }

        }
        /*a�a��da btnStart diye bir buton var .Her bas�ld���nda her �ey eski haline d�ner kullan�c� yeni oyuna ba�lar*/
        private void btnStart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}