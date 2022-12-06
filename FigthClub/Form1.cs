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
        /*burada alacaðýmýz hasarý ve verilen hasar kodlarýný metod þeklinde aþaðýdaki gibi yazdýk 
              */
        public void Hasar ()
        {
            lblHasar.Text = "Muhammed Aliye hasar verildi";
            lblHasar2.Text= "Hasar alýndý";
        }
        public void Hasar (int saldiriTuru)
        {
            lblHasar.Text = "Muhammed Aliye " + saldiriTuru + " ile hasar verildi.";
            lblHasar2.Text= "Düþmandan " + saldiriTuru + " ile hasar alýndý.";
        }
        /*burada formun baþlangýcýnda görünmeyecek bilgileri veriyoruz
         - Seç butonuna basana kadar ekranda, seçim kýsmý dýþýnda bir tool gözükmeyecek.
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
        /*burada Seç butonuna basýldýðý anda butonlar ve ilgili resimler can barý ve alýnacak hasar labeli
         ekrana gelecek ve Seç butonuna bastýktan sonra artýk textboxlar deðiþtirelemez , seç butonu
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
        /*burada butona her týklandýðýnda alýnan hasar ve miktarý verilen hasar ve miktarý oyun sounucu kimin kazanýp
         * kimin kaybettiði gösterilmektedir*/

        private void btnAttack_Click(object sender, EventArgs e)
        {
            
            character.Attack();
            
            
            lblHealth.Width = lblHealth.Width - character.Damage;
            lblHealtht2.Width=lblHealtht2.Width - character.Damage2;
            int sonuc = Convert.ToInt32(lblHealth.Width);
            Hasar(sonuc);
            int sonuc2 = Convert.ToInt32(lblHealtht2.Width);
            Hasar(sonuc2);

            /*burada oyun sonunda kimin kazandýðý kimin hayatta kaldýðýnýn resmi gösteriliyor 
             */

            if (lblHealth.Width <= 0)
            {
                
                MessageBox.Show("Tebrikler Kazandýn: "+"  "+txtName.Text);
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
        /*aþaðýda btnStart diye bir buton var .Her basýldýðýnda her þey eski haline döner kullanýcý yeni oyuna baþlar*/
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