namespace GeradorDePacotes
{
    partial class Frm_Index
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Index));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            Lbl_TituloPrograma = new Label();
            Pic_ExpandirMenu = new PictureBox();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Btn_inicio = new Button();
            Btn_Configuracoes = new Button();
            Btn_Sobre = new Button();
            Chk_Inicializar = new CheckBox();
            Btn_GerarPacote = new Guna.UI2.WinForms.Guna2Button();
            Prg_Bar = new ReaLTaiizor.Controls.ParrotCircleProgressBar();
            Lbl_Progresso = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_ExpandirMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(198, 172, 143);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(Lbl_TituloPrograma);
            panel1.Controls.Add(Pic_ExpandirMenu);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 32);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.DimGray;
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.Dock = DockStyle.Right;
            nightControlBox1.EnableCloseColor = Color.Black;
            nightControlBox1.EnableMaximizeButton = false;
            nightControlBox1.EnableMaximizeColor = Color.DarkGray;
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.Black;
            nightControlBox1.Location = new Point(824, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(50, 102, 155, 188);
            nightControlBox1.MaximizeHoverForeColor = Color.RoyalBlue;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(50, 102, 155, 188);
            nightControlBox1.MinimizeHoverForeColor = Color.RoyalBlue;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 2;
            // 
            // Lbl_TituloPrograma
            // 
            Lbl_TituloPrograma.AutoSize = true;
            Lbl_TituloPrograma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_TituloPrograma.ForeColor = SystemColors.ActiveCaptionText;
            Lbl_TituloPrograma.Location = new Point(50, 0);
            Lbl_TituloPrograma.Name = "Lbl_TituloPrograma";
            Lbl_TituloPrograma.Size = new Size(182, 28);
            Lbl_TituloPrograma.TabIndex = 1;
            Lbl_TituloPrograma.Text = "Gerador de Pacotes";
            // 
            // Pic_ExpandirMenu
            // 
            Pic_ExpandirMenu.AccessibleDescription = "Clique para expandir o menu";
            Pic_ExpandirMenu.AccessibleName = "Expandir";
            Pic_ExpandirMenu.AccessibleRole = AccessibleRole.Cursor;
            Pic_ExpandirMenu.Image = Properties.Resources.seta;
            Pic_ExpandirMenu.Location = new Point(0, 4);
            Pic_ExpandirMenu.Name = "Pic_ExpandirMenu";
            Pic_ExpandirMenu.Size = new Size(44, 24);
            Pic_ExpandirMenu.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_ExpandirMenu.TabIndex = 0;
            Pic_ExpandirMenu.TabStop = false;
            Pic_ExpandirMenu.Click += Pic_ExpandirMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.LOGO_PRINCIPAL;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.BackColor = Color.FromArgb(198, 172, 143);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(Btn_inicio);
            flowLayoutPanel1.Controls.Add(Btn_Configuracoes);
            flowLayoutPanel1.Controls.Add(Btn_Sobre);
            flowLayoutPanel1.Location = new Point(0, 32);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(216, 705);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // Btn_inicio
            // 
            Btn_inicio.Anchor = AnchorStyles.Left;
            Btn_inicio.BackColor = Color.FromArgb(198, 172, 143);
            Btn_inicio.BackgroundImageLayout = ImageLayout.None;
            Btn_inicio.Cursor = Cursors.Hand;
            Btn_inicio.FlatAppearance.BorderSize = 0;
            Btn_inicio.FlatStyle = FlatStyle.Flat;
            Btn_inicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_inicio.ForeColor = Color.FromArgb(45, 40, 33);
            Btn_inicio.Image = Properties.Resources.botao_de_inicio;
            Btn_inicio.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_inicio.Location = new Point(3, 181);
            Btn_inicio.Margin = new Padding(3, 35, 3, 3);
            Btn_inicio.Name = "Btn_inicio";
            Btn_inicio.Size = new Size(212, 67);
            Btn_inicio.TabIndex = 3;
            Btn_inicio.Text = "INÍCIO";
            Btn_inicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_inicio.UseVisualStyleBackColor = false;
            // 
            // Btn_Configuracoes
            // 
            Btn_Configuracoes.Anchor = AnchorStyles.Left;
            Btn_Configuracoes.BackColor = Color.FromArgb(198, 172, 143);
            Btn_Configuracoes.BackgroundImageLayout = ImageLayout.None;
            Btn_Configuracoes.Cursor = Cursors.Hand;
            Btn_Configuracoes.FlatAppearance.BorderSize = 0;
            Btn_Configuracoes.FlatStyle = FlatStyle.Flat;
            Btn_Configuracoes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Configuracoes.ForeColor = Color.FromArgb(45, 40, 33);
            Btn_Configuracoes.Image = Properties.Resources.configuracao;
            Btn_Configuracoes.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Configuracoes.Location = new Point(3, 254);
            Btn_Configuracoes.Name = "Btn_Configuracoes";
            Btn_Configuracoes.Size = new Size(212, 67);
            Btn_Configuracoes.TabIndex = 4;
            Btn_Configuracoes.Text = "CONFIGURAÇÕES";
            Btn_Configuracoes.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Configuracoes.UseVisualStyleBackColor = false;
            // 
            // Btn_Sobre
            // 
            Btn_Sobre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Btn_Sobre.BackColor = Color.FromArgb(198, 172, 143);
            Btn_Sobre.BackgroundImageLayout = ImageLayout.None;
            Btn_Sobre.Cursor = Cursors.Hand;
            Btn_Sobre.FlatAppearance.BorderSize = 0;
            Btn_Sobre.FlatStyle = FlatStyle.Flat;
            flowLayoutPanel1.SetFlowBreak(Btn_Sobre, true);
            Btn_Sobre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Sobre.ForeColor = Color.FromArgb(45, 40, 33);
            Btn_Sobre.Image = Properties.Resources.sobre;
            Btn_Sobre.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Sobre.Location = new Point(3, 434);
            Btn_Sobre.Margin = new Padding(3, 110, 3, 3);
            Btn_Sobre.Name = "Btn_Sobre";
            Btn_Sobre.Size = new Size(207, 87);
            Btn_Sobre.TabIndex = 6;
            Btn_Sobre.Text = "SOBRE";
            Btn_Sobre.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Sobre.UseVisualStyleBackColor = false;
            Btn_Sobre.Click += button4_Click;
            // 
            // Chk_Inicializar
            // 
            Chk_Inicializar.AutoSize = true;
            Chk_Inicializar.Location = new Point(437, 498);
            Chk_Inicializar.Name = "Chk_Inicializar";
            Chk_Inicializar.Size = new Size(139, 24);
            Chk_Inicializar.TabIndex = 4;
            Chk_Inicializar.Text = "Gerar ao iniciar?";
            Chk_Inicializar.UseVisualStyleBackColor = true;
            // 
            // Btn_GerarPacote
            // 
            Btn_GerarPacote.Animated = true;
            Btn_GerarPacote.CustomizableEdges = customizableEdges1;
            Btn_GerarPacote.DisabledState.BorderColor = Color.DarkGray;
            Btn_GerarPacote.DisabledState.CustomBorderColor = Color.DarkGray;
            Btn_GerarPacote.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Btn_GerarPacote.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Btn_GerarPacote.FillColor = Color.FromArgb(76, 149, 108);
            Btn_GerarPacote.Font = new Font("Segoe UI", 13F);
            Btn_GerarPacote.ForeColor = Color.White;
            Btn_GerarPacote.Location = new Point(396, 436);
            Btn_GerarPacote.Name = "Btn_GerarPacote";
            Btn_GerarPacote.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Btn_GerarPacote.Size = new Size(225, 56);
            Btn_GerarPacote.TabIndex = 6;
            Btn_GerarPacote.Text = "Gerar Pacote";
            // 
            // Prg_Bar
            // 
            Prg_Bar.AnimationSpeed = 5;
            Prg_Bar.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            Prg_Bar.FilledColor = Color.FromArgb(76, 149, 108);
            Prg_Bar.FilledColorAlpha = 255;
            Prg_Bar.FilledThickness = 25;
            Prg_Bar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            Prg_Bar.IsAnimated = false;
            Prg_Bar.Location = new Point(396, 120);
            Prg_Bar.Name = "Prg_Bar";
            Prg_Bar.Percentage = 50;
            Prg_Bar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            Prg_Bar.ShowText = true;
            Prg_Bar.Size = new Size(250, 250);
            Prg_Bar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Prg_Bar.TabIndex = 26;
            Prg_Bar.TextColor = Color.Gray;
            Prg_Bar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            Prg_Bar.TextSize = 25;
            Prg_Bar.UnFilledColor = Color.FromArgb(114, 114, 114);
            Prg_Bar.UnfilledThickness = 25;
            Prg_Bar.Visible = false;
            // 
            // Lbl_Progresso
            // 
            Lbl_Progresso.AutoSize = true;
            Lbl_Progresso.Location = new Point(463, 373);
            Lbl_Progresso.Name = "Lbl_Progresso";
            Lbl_Progresso.Size = new Size(114, 20);
            Lbl_Progresso.TabIndex = 27;
            Lbl_Progresso.Text = "Label Progresso";
            Lbl_Progresso.Visible = false;
            // 
            // Frm_Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 213, 202);
            ClientSize = new Size(963, 737);
            Controls.Add(Lbl_Progresso);
            Controls.Add(Prg_Bar);
            Controls.Add(Btn_GerarPacote);
            Controls.Add(Chk_Inicializar);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de Pacotes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_ExpandirMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox Pic_ExpandirMenu;
        private Label Lbl_TituloPrograma;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Btn_inicio;
        private Button Btn_Configuracoes;
        private Button Btn_Sobre;
        private Button Btn_Gerar;
        private CheckBox Chk_Inicializar;
        private Guna.UI2.WinForms.Guna2Button Btn_GerarPacote;
        private ReaLTaiizor.Controls.ParrotCircleProgressBar Prg_Bar;
        private Label Lbl_Progresso;
    }
}