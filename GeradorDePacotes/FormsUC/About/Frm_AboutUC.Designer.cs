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
            panel1 = new Panel();
            Grp_Links = new ReaLTaiizor.Controls.ThunderGroupBox();
            Pnl_Portfolio = new Panel();
            Lk_Portfolio = new LinkLabel();
            Pic_Portfolio = new PictureBox();
            Pnl_Linkedin = new Panel();
            Pic_Linkedin = new PictureBox();
            Lk_Linkedin = new LinkLabel();
            Pnl_Github = new Panel();
            Pic_Github = new PictureBox();
            Lk_Github = new LinkLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            BgLbl_Title = new ReaLTaiizor.Controls.BigLabel();
            Lk_SourceCode = new LinkLabel();
            Grp_Idea = new ReaLTaiizor.Controls.ThunderGroupBox();
            Lbl_About = new Label();
            panel1.SuspendLayout();
            Grp_Links.SuspendLayout();
            Pnl_Portfolio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Portfolio).BeginInit();
            Pnl_Linkedin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Linkedin).BeginInit();
            Pnl_Github.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Github).BeginInit();
            Grp_Idea.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Grp_Links);
            panel1.Controls.Add(Grp_Idea);
            panel1.Location = new Point(209, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 620);
            panel1.TabIndex = 0;
            // 
            // Grp_Links
            // 
            Grp_Links.BackColor = Color.Transparent;
            Grp_Links.BodyColorA = Color.FromArgb(26, 26, 26);
            Grp_Links.BodyColorB = Color.FromArgb(30, 30, 30);
            Grp_Links.BodyColorC = Color.FromArgb(46, 46, 46);
            Grp_Links.BodyColorD = Color.FromArgb(50, 55, 58);
            Grp_Links.Controls.Add(Pnl_Portfolio);
            Grp_Links.Controls.Add(Pnl_Linkedin);
            Grp_Links.Controls.Add(Pnl_Github);
            Grp_Links.Controls.Add(bigLabel1);
            Grp_Links.Controls.Add(BgLbl_Title);
            Grp_Links.Controls.Add(Lk_SourceCode);
            Grp_Links.Font = new Font("Segoe UI", 25F);
            Grp_Links.ForeColor = Color.WhiteSmoke;
            Grp_Links.Location = new Point(3, 226);
            Grp_Links.Name = "Grp_Links";
            Grp_Links.Size = new Size(596, 391);
            Grp_Links.TabIndex = 5;
            Grp_Links.Text = "LINKS";
            // 
            // Pnl_Portfolio
            // 
            Pnl_Portfolio.Controls.Add(Lk_Portfolio);
            Pnl_Portfolio.Controls.Add(Pic_Portfolio);
            Pnl_Portfolio.Location = new Point(230, 321);
            Pnl_Portfolio.Name = "Pnl_Portfolio";
            Pnl_Portfolio.Size = new Size(122, 39);
            Pnl_Portfolio.TabIndex = 12;
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
            // Pnl_Linkedin
            // 
            Pnl_Linkedin.Controls.Add(Pic_Linkedin);
            Pnl_Linkedin.Controls.Add(Lk_Linkedin);
            Pnl_Linkedin.Location = new Point(230, 275);
            Pnl_Linkedin.Name = "Pnl_Linkedin";
            Pnl_Linkedin.Size = new Size(122, 40);
            Pnl_Linkedin.TabIndex = 12;
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
            // Pnl_Github
            // 
            Pnl_Github.Controls.Add(Pic_Github);
            Pnl_Github.Controls.Add(Lk_Github);
            Pnl_Github.Location = new Point(230, 230);
            Pnl_Github.Name = "Pnl_Github";
            Pnl_Github.Size = new Size(103, 39);
            Pnl_Github.TabIndex = 11;
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
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.WhiteSmoke;
            bigLabel1.Location = new Point(189, 149);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(205, 67);
            bigLabel1.TabIndex = 4;
            bigLabel1.Text = "Contato";
            // 
            // BgLbl_Title
            // 
            BgLbl_Title.AutoSize = true;
            BgLbl_Title.BackColor = Color.Transparent;
            BgLbl_Title.Font = new Font("Segoe UI", 30F);
            BgLbl_Title.ForeColor = Color.WhiteSmoke;
            BgLbl_Title.Location = new Point(135, 47);
            BgLbl_Title.Name = "BgLbl_Title";
            BgLbl_Title.Size = new Size(324, 67);
            BgLbl_Title.TabIndex = 2;
            BgLbl_Title.Text = "Código-fonte";
            // 
            // Lk_SourceCode
            // 
            Lk_SourceCode.AutoSize = true;
            Lk_SourceCode.Font = new Font("Segoe UI", 12F);
            Lk_SourceCode.LinkArea = new LinkArea(0, 40);
            Lk_SourceCode.LinkColor = Color.FromArgb(153, 195, 255);
            Lk_SourceCode.Location = new Point(135, 114);
            Lk_SourceCode.Name = "Lk_SourceCode";
            Lk_SourceCode.Size = new Size(337, 33);
            Lk_SourceCode.TabIndex = 3;
            Lk_SourceCode.TabStop = true;
            Lk_SourceCode.Tag = "codigofonte";
            Lk_SourceCode.Text = "Projeto Gerador de Pacotes - Github";
            Lk_SourceCode.UseCompatibleTextRendering = true;
            Lk_SourceCode.VisitedLinkColor = Color.FromArgb(153, 195, 255);
            Lk_SourceCode.LinkClicked += LinkClicked;
            // 
            // Grp_Idea
            // 
            Grp_Idea.BackColor = Color.Transparent;
            Grp_Idea.BodyColorA = Color.FromArgb(26, 26, 26);
            Grp_Idea.BodyColorB = Color.FromArgb(30, 30, 30);
            Grp_Idea.BodyColorC = Color.FromArgb(46, 46, 46);
            Grp_Idea.BodyColorD = Color.FromArgb(50, 55, 58);
            Grp_Idea.Controls.Add(Lbl_About);
            Grp_Idea.Font = new Font("Segoe UI", 25F);
            Grp_Idea.ForeColor = Color.WhiteSmoke;
            Grp_Idea.Location = new Point(3, 3);
            Grp_Idea.Name = "Grp_Idea";
            Grp_Idea.Size = new Size(596, 204);
            Grp_Idea.TabIndex = 4;
            Grp_Idea.Text = "IDEIA";
            // 
            // Lbl_About
            // 
            Lbl_About.AutoSize = true;
            Lbl_About.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_About.Location = new Point(4, 48);
            Lbl_About.Name = "Lbl_About";
            Lbl_About.Size = new Size(592, 112);
            Lbl_About.TabIndex = 0;
            Lbl_About.Text = resources.GetString("Lbl_About.Text");
            // 
            // Frm_AboutUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 213, 202);
            Controls.Add(panel1);
            Name = "Frm_AboutUC";
            Size = new Size(1024, 866);
            panel1.ResumeLayout(false);
            Grp_Links.ResumeLayout(false);
            Grp_Links.PerformLayout();
            Pnl_Portfolio.ResumeLayout(false);
            Pnl_Portfolio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Portfolio).EndInit();
            Pnl_Linkedin.ResumeLayout(false);
            Pnl_Linkedin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Linkedin).EndInit();
            Pnl_Github.ResumeLayout(false);
            Pnl_Github.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Github).EndInit();
            Grp_Idea.ResumeLayout(false);
            Grp_Idea.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Lbl_About;
        private ReaLTaiizor.Controls.BigLabel BgLbl_Title;
        private ReaLTaiizor.Controls.ThunderGroupBox Grp_Idea;
        private LinkLabel Lk_SourceCode;
        private ReaLTaiizor.Controls.ThunderGroupBox Grp_Links;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private LinkLabel Lk_Portfolio;
        private LinkLabel Lk_Github;
        private LinkLabel Lk_Linkedin;
        private PictureBox Pic_Github;
        private PictureBox Pic_Portfolio;
        private PictureBox Pic_Linkedin;
        private Panel Pnl_Portfolio;
        private Panel Pnl_Linkedin;
        private Panel Pnl_Github;
    }
}
