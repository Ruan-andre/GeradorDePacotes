namespace GeradorDePacotes
{
    partial class Frm_AboutUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AboutUC));
            Pnl_ContentAbout = new Panel();
            modernGroupBox2 = new PersonalizedComponents.ModernGroupBox();
            BgLbl_Title = new ReaLTaiizor.Controls.BigLabel();
            Pnl_Portfolio = new Panel();
            Lk_Portfolio = new LinkLabel();
            Pic_Portfolio = new PictureBox();
            Pnl_Github = new Panel();
            Pic_Github = new PictureBox();
            Lk_Github = new LinkLabel();
            Lk_SourceCode = new LinkLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            Pnl_Linkedin = new Panel();
            Pic_Linkedin = new PictureBox();
            Lk_Linkedin = new LinkLabel();
            modernGroupBox1 = new PersonalizedComponents.ModernGroupBox();
            label1 = new Label();
            Pnl_ContentAbout.SuspendLayout();
            modernGroupBox2.SuspendLayout();
            Pnl_Portfolio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Portfolio).BeginInit();
            Pnl_Github.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Github).BeginInit();
            Pnl_Linkedin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Linkedin).BeginInit();
            modernGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_ContentAbout
            // 
            Pnl_ContentAbout.Controls.Add(modernGroupBox2);
            Pnl_ContentAbout.Controls.Add(modernGroupBox1);
            Pnl_ContentAbout.Location = new Point(312, 61);
            Pnl_ContentAbout.Name = "Pnl_ContentAbout";
            Pnl_ContentAbout.Size = new Size(602, 667);
            Pnl_ContentAbout.TabIndex = 0;
            Pnl_ContentAbout.Tag = "main";
            // 
            // modernGroupBox2
            // 
            modernGroupBox2.BackColor = Color.Transparent;
            modernGroupBox2.BackgroundColor = Color.FromArgb(45, 47, 49);
            modernGroupBox2.BorderColor = Color.FromArgb(28, 28, 28);
            modernGroupBox2.Controls.Add(BgLbl_Title);
            modernGroupBox2.Controls.Add(Pnl_Portfolio);
            modernGroupBox2.Controls.Add(Pnl_Github);
            modernGroupBox2.Controls.Add(Lk_SourceCode);
            modernGroupBox2.Controls.Add(bigLabel1);
            modernGroupBox2.Controls.Add(Pnl_Linkedin);
            modernGroupBox2.GroupTitle = "LINKS";
            modernGroupBox2.Location = new Point(0, 283);
            modernGroupBox2.Name = "modernGroupBox2";
            modernGroupBox2.Padding = new Padding(10, 40, 10, 10);
            modernGroupBox2.Size = new Size(605, 384);
            modernGroupBox2.TabIndex = 2;
            modernGroupBox2.TitleBackgroundColor = Color.FromArgb(30, 30, 30);
            modernGroupBox2.TitleColor = Color.WhiteSmoke;
            // 
            // BgLbl_Title
            // 
            BgLbl_Title.AutoSize = true;
            BgLbl_Title.BackColor = Color.Transparent;
            BgLbl_Title.Font = new Font("Segoe UI", 30F);
            BgLbl_Title.ForeColor = Color.WhiteSmoke;
            BgLbl_Title.Location = new Point(149, 40);
            BgLbl_Title.Name = "BgLbl_Title";
            BgLbl_Title.Size = new Size(324, 67);
            BgLbl_Title.TabIndex = 13;
            BgLbl_Title.Text = "Código-fonte";
            // 
            // Pnl_Portfolio
            // 
            Pnl_Portfolio.BackColor = Color.Transparent;
            Pnl_Portfolio.Controls.Add(Lk_Portfolio);
            Pnl_Portfolio.Controls.Add(Pic_Portfolio);
            Pnl_Portfolio.Location = new Point(244, 314);
            Pnl_Portfolio.Name = "Pnl_Portfolio";
            Pnl_Portfolio.Size = new Size(122, 39);
            Pnl_Portfolio.TabIndex = 17;
            // 
            // Lk_Portfolio
            // 
            Lk_Portfolio.AutoSize = true;
            Lk_Portfolio.Font = new Font("Segoe UI", 12F);
            Lk_Portfolio.LinkArea = new LinkArea(0, 10);
            Lk_Portfolio.LinkColor = Color.FromArgb(153, 195, 255);
            Lk_Portfolio.Location = new Point(35, 4);
            Lk_Portfolio.Name = "Lk_Portfolio";
            Lk_Portfolio.Size = new Size(85, 33);
            Lk_Portfolio.TabIndex = 7;
            Lk_Portfolio.TabStop = true;
            Lk_Portfolio.Tag = "portfolio";
            Lk_Portfolio.Text = "Portfólio";
            Lk_Portfolio.UseCompatibleTextRendering = true;
            Lk_Portfolio.VisitedLinkColor = Color.FromArgb(153, 195, 255);
            Lk_Portfolio.LinkClicked += LinkClicked;
            // 
            // Pic_Portfolio
            // 
            Pic_Portfolio.Image = Properties.Resources.portfolio;
            Pic_Portfolio.Location = new Point(1, 3);
            Pic_Portfolio.Name = "Pic_Portfolio";
            Pic_Portfolio.Size = new Size(33, 33);
            Pic_Portfolio.TabIndex = 10;
            Pic_Portfolio.TabStop = false;
            // 
            // Pnl_Github
            // 
            Pnl_Github.BackColor = Color.Transparent;
            Pnl_Github.Controls.Add(Pic_Github);
            Pnl_Github.Controls.Add(Lk_Github);
            Pnl_Github.Location = new Point(244, 223);
            Pnl_Github.Name = "Pnl_Github";
            Pnl_Github.Size = new Size(103, 39);
            Pnl_Github.TabIndex = 16;
            // 
            // Pic_Github
            // 
            Pic_Github.Image = Properties.Resources.github;
            Pic_Github.Location = new Point(2, 4);
            Pic_Github.Name = "Pic_Github";
            Pic_Github.Size = new Size(33, 33);
            Pic_Github.TabIndex = 8;
            Pic_Github.TabStop = false;
            // 
            // Lk_Github
            // 
            Lk_Github.AutoSize = true;
            Lk_Github.Font = new Font("Segoe UI", 12F);
            Lk_Github.LinkArea = new LinkArea(0, 10);
            Lk_Github.LinkColor = Color.FromArgb(153, 195, 255);
            Lk_Github.Location = new Point(36, 4);
            Lk_Github.Name = "Lk_Github";
            Lk_Github.Size = new Size(69, 33);
            Lk_Github.TabIndex = 6;
            Lk_Github.TabStop = true;
            Lk_Github.Tag = "github";
            Lk_Github.Text = "Github";
            Lk_Github.UseCompatibleTextRendering = true;
            Lk_Github.VisitedLinkColor = Color.FromArgb(153, 195, 255);
            Lk_Github.LinkClicked += LinkClicked;
            // 
            // Lk_SourceCode
            // 
            Lk_SourceCode.AutoSize = true;
            Lk_SourceCode.BackColor = Color.Transparent;
            Lk_SourceCode.Font = new Font("Segoe UI", 12F);
            Lk_SourceCode.LinkArea = new LinkArea(0, 40);
            Lk_SourceCode.LinkColor = Color.FromArgb(153, 195, 255);
            Lk_SourceCode.Location = new Point(149, 107);
            Lk_SourceCode.Name = "Lk_SourceCode";
            Lk_SourceCode.Size = new Size(337, 33);
            Lk_SourceCode.TabIndex = 14;
            Lk_SourceCode.TabStop = true;
            Lk_SourceCode.Tag = "codigofonte";
            Lk_SourceCode.Text = "Projeto Gerador de Pacotes - Github";
            Lk_SourceCode.UseCompatibleTextRendering = true;
            Lk_SourceCode.VisitedLinkColor = Color.FromArgb(153, 195, 255);
            Lk_SourceCode.LinkClicked += LinkClicked;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.WhiteSmoke;
            bigLabel1.Location = new Point(203, 142);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(205, 67);
            bigLabel1.TabIndex = 15;
            bigLabel1.Text = "Contato";
            // 
            // Pnl_Linkedin
            // 
            Pnl_Linkedin.BackColor = Color.Transparent;
            Pnl_Linkedin.Controls.Add(Pic_Linkedin);
            Pnl_Linkedin.Controls.Add(Lk_Linkedin);
            Pnl_Linkedin.Location = new Point(244, 268);
            Pnl_Linkedin.Name = "Pnl_Linkedin";
            Pnl_Linkedin.Size = new Size(122, 40);
            Pnl_Linkedin.TabIndex = 18;
            // 
            // Pic_Linkedin
            // 
            Pic_Linkedin.Image = Properties.Resources.linkedin;
            Pic_Linkedin.Location = new Point(2, 4);
            Pic_Linkedin.Name = "Pic_Linkedin";
            Pic_Linkedin.Size = new Size(33, 33);
            Pic_Linkedin.TabIndex = 9;
            Pic_Linkedin.TabStop = false;
            // 
            // Lk_Linkedin
            // 
            Lk_Linkedin.AutoSize = true;
            Lk_Linkedin.Font = new Font("Segoe UI", 12F);
            Lk_Linkedin.LinkArea = new LinkArea(0, 10);
            Lk_Linkedin.LinkColor = Color.FromArgb(153, 195, 255);
            Lk_Linkedin.Location = new Point(38, 6);
            Lk_Linkedin.Name = "Lk_Linkedin";
            Lk_Linkedin.Size = new Size(83, 33);
            Lk_Linkedin.TabIndex = 5;
            Lk_Linkedin.TabStop = true;
            Lk_Linkedin.Tag = "linkedin";
            Lk_Linkedin.Text = "Linkedin";
            Lk_Linkedin.UseCompatibleTextRendering = true;
            Lk_Linkedin.VisitedLinkColor = Color.FromArgb(153, 195, 255);
            Lk_Linkedin.LinkClicked += LinkClicked;
            // 
            // modernGroupBox1
            // 
            modernGroupBox1.BackColor = Color.Transparent;
            modernGroupBox1.BackgroundColor = Color.FromArgb(45, 47, 49);
            modernGroupBox1.BorderColor = Color.FromArgb(28, 28, 28);
            modernGroupBox1.Controls.Add(label1);
            modernGroupBox1.GroupTitle = "IDEIA";
            modernGroupBox1.Location = new Point(3, 3);
            modernGroupBox1.Name = "modernGroupBox1";
            modernGroupBox1.Padding = new Padding(10, 40, 10, 10);
            modernGroupBox1.Size = new Size(602, 263);
            modernGroupBox1.TabIndex = 1;
            modernGroupBox1.TitleBackgroundColor = Color.FromArgb(30, 30, 30);
            modernGroupBox1.TitleColor = Color.White;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(10, 40);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(582, 213);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // Frm_AboutUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 213, 202);
            Controls.Add(Pnl_ContentAbout);
            Name = "Frm_AboutUC";
            Size = new Size(1024, 866);
            Pnl_ContentAbout.ResumeLayout(false);
            modernGroupBox2.ResumeLayout(false);
            modernGroupBox2.PerformLayout();
            Pnl_Portfolio.ResumeLayout(false);
            Pnl_Portfolio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Portfolio).EndInit();
            Pnl_Github.ResumeLayout(false);
            Pnl_Github.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Github).EndInit();
            Pnl_Linkedin.ResumeLayout(false);
            Pnl_Linkedin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Linkedin).EndInit();
            modernGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_ContentAbout;
        private Label label1;
        private Panel Pnl_Portfolio;
        private LinkLabel Lk_Portfolio;
        private PictureBox Pic_Portfolio;
        private Panel Pnl_Linkedin;
        private PictureBox Pic_Linkedin;
        private LinkLabel Lk_Linkedin;
        private Panel Pnl_Github;
        private PictureBox Pic_Github;
        private LinkLabel Lk_Github;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigLabel BgLbl_Title;
        private LinkLabel Lk_SourceCode;
        private PersonalizedComponents.ModernGroupBox modernGroupBox2;
        private PersonalizedComponents.ModernGroupBox modernGroupBox1;
    }
}
