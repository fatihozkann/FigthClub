namespace FigthClub
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbFighter = new System.Windows.Forms.ComboBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblHasar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxT = new System.Windows.Forms.PictureBox();
            this.lblHealtht2 = new System.Windows.Forms.Label();
            this.lblHasar2 = new System.Windows.Forms.Label();
            this.pictureBoxJ = new System.Windows.Forms.PictureBox();
            this.pictureBoxY = new System.Windows.Forms.PictureBox();
            this.pictureBoxJc = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(136, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fighter Selection";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "İsim :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dövüşçü:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sınıf:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtName.Location = new System.Drawing.Point(115, 79);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Adınızı Giriniz...";
            this.txtName.Size = new System.Drawing.Size(121, 23);
            this.txtName.TabIndex = 4;
            // 
            // cmbFighter
            // 
            this.cmbFighter.FormattingEnabled = true;
            this.cmbFighter.Items.AddRange(new object[] {
            "Turabi",
            "Yuri boyka",
            "Jet Li",
            "Jackie Chan"});
            this.cmbFighter.Location = new System.Drawing.Point(115, 127);
            this.cmbFighter.Name = "cmbFighter";
            this.cmbFighter.Size = new System.Drawing.Size(121, 23);
            this.cmbFighter.TabIndex = 5;
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Items.AddRange(new object[] {
            "Gun",
            "Sword",
            "Nunchucks"});
            this.cmbBranch.Location = new System.Drawing.Point(115, 169);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(121, 23);
            this.cmbBranch.TabIndex = 6;
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.Transparent;
            this.btnChoose.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChoose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChoose.Location = new System.Drawing.Point(86, 220);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(133, 23);
            this.btnChoose.TabIndex = 7;
            this.btnChoose.Text = "Seç";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.Transparent;
            this.btnAttack.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAttack.ForeColor = System.Drawing.Color.Brown;
            this.btnAttack.Location = new System.Drawing.Point(86, 292);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(133, 23);
            this.btnAttack.TabIndex = 8;
            this.btnAttack.Text = "Saldır";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblHealth
            // 
            this.lblHealth.BackColor = System.Drawing.Color.OrangeRed;
            this.lblHealth.Location = new System.Drawing.Point(617, 108);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(300, 31);
            this.lblHealth.TabIndex = 11;
            // 
            // lblHasar
            // 
            this.lblHasar.BackColor = System.Drawing.Color.Transparent;
            this.lblHasar.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHasar.Location = new System.Drawing.Point(617, 79);
            this.lblHasar.Name = "lblHasar";
            this.lblHasar.Size = new System.Drawing.Size(300, 23);
            this.lblHasar.TabIndex = 12;
            this.lblHasar.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FigthClub.Properties.Resources.muhammad_ali_ali;
            this.pictureBox1.Location = new System.Drawing.Point(617, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxT
            // 
            this.pictureBoxT.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxT.Image = global::FigthClub.Properties.Resources.turabi_kimdir;
            this.pictureBoxT.Location = new System.Drawing.Point(316, 158);
            this.pictureBoxT.Name = "pictureBoxT";
            this.pictureBoxT.Size = new System.Drawing.Size(217, 223);
            this.pictureBoxT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxT.TabIndex = 14;
            this.pictureBoxT.TabStop = false;
            // 
            // lblHealtht2
            // 
            this.lblHealtht2.BackColor = System.Drawing.Color.Green;
            this.lblHealtht2.Location = new System.Drawing.Point(263, 108);
            this.lblHealtht2.Name = "lblHealtht2";
            this.lblHealtht2.Size = new System.Drawing.Size(300, 31);
            this.lblHealtht2.TabIndex = 15;
            this.lblHealtht2.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblHasar2
            // 
            this.lblHasar2.BackColor = System.Drawing.Color.Transparent;
            this.lblHasar2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHasar2.Location = new System.Drawing.Point(282, 77);
            this.lblHasar2.Name = "lblHasar2";
            this.lblHasar2.Size = new System.Drawing.Size(281, 23);
            this.lblHasar2.TabIndex = 16;
            this.lblHasar2.Text = "-";
            // 
            // pictureBoxJ
            // 
            this.pictureBoxJ.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxJ.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxJ.Image")));
            this.pictureBoxJ.Location = new System.Drawing.Point(316, 158);
            this.pictureBoxJ.Name = "pictureBoxJ";
            this.pictureBoxJ.Size = new System.Drawing.Size(217, 223);
            this.pictureBoxJ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxJ.TabIndex = 17;
            this.pictureBoxJ.TabStop = false;
            // 
            // pictureBoxY
            // 
            this.pictureBoxY.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxY.Image = global::FigthClub.Properties.Resources.LljGRENU_400x400;
            this.pictureBoxY.Location = new System.Drawing.Point(316, 158);
            this.pictureBoxY.Name = "pictureBoxY";
            this.pictureBoxY.Size = new System.Drawing.Size(217, 223);
            this.pictureBoxY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxY.TabIndex = 18;
            this.pictureBoxY.TabStop = false;
            // 
            // pictureBoxJc
            // 
            this.pictureBoxJc.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxJc.Image = global::FigthClub.Properties.Resources.jac;
            this.pictureBoxJc.Location = new System.Drawing.Point(316, 158);
            this.pictureBoxJc.Name = "pictureBoxJc";
            this.pictureBoxJc.Size = new System.Drawing.Size(217, 223);
            this.pictureBoxJc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxJc.TabIndex = 19;
            this.pictureBoxJc.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnStart.Location = new System.Drawing.Point(86, 339);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 23);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "Yeni Oyun";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(263, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 34);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tebrikler kazandınız";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(481, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(407, 34);
            this.label6.TabIndex = 23;
            this.label6.Text = "Kaybettiniz Kazanan Muhammet Ali ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FigthClub.Properties.Resources.thumb2_playing_cards_neon_icon_4k_red_background_neon_symbols_playing_cards;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 596);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBoxJc);
            this.Controls.Add(this.pictureBoxY);
            this.Controls.Add(this.pictureBoxJ);
            this.Controls.Add(this.lblHasar2);
            this.Controls.Add(this.lblHealtht2);
            this.Controls.Add(this.pictureBoxT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHasar);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.cmbFighter);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private ComboBox cmbFighter;
        private ComboBox cmbBranch;
        private Button btnChoose;
        private Button btnAttack;
        private Label lblHealth;
        private Label lblHasar;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxT;
        private Label lblHealtht2;
        private Label lblHasar2;
        private PictureBox pictureBoxJ;
        private PictureBox pictureBoxY;
        private PictureBox pictureBoxJc;
        private Button btnStart;
        private Label label5;
        private Label label6;
    }
}