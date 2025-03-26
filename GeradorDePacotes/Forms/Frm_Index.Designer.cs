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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Index));
            Pnl_Top = new Panel();
            Btn_MinimizeApplication = new Button();
            button1 = new Button();
            Lbl_TituloPrograma = new Label();
            Pic_ExpandirMenu = new PictureBox();
            SidebarTransition = new System.Windows.Forms.Timer(components);
            Flp_Sidebar = new FlowLayoutPanel();
            Pic_Logo = new PictureBox();
            Btn_inicio = new Button();
            Btn_Configuracoes = new Button();
            Btn_Sobre = new Button();
            Pnl_Principal = new Panel();
            Pnl_Exit = new Panel();
            Btn_Exit = new Button();
            Pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_ExpandirMenu).BeginInit();
            Flp_Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Logo).BeginInit();
            Pnl_Exit.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_Top
            // 
            Pnl_Top.AllowDrop = true;
            Pnl_Top.BackColor = Color.FromArgb(198, 172, 143);
            Pnl_Top.Controls.Add(Btn_MinimizeApplication);
            Pnl_Top.Controls.Add(button1);
            Pnl_Top.Controls.Add(Lbl_TituloPrograma);
            Pnl_Top.Controls.Add(Pic_ExpandirMenu);
            Pnl_Top.Dock = DockStyle.Top;
            Pnl_Top.ForeColor = SystemColors.ButtonHighlight;
            Pnl_Top.ImeMode = ImeMode.NoControl;
            Pnl_Top.Location = new Point(0, 0);
            Pnl_Top.Margin = new Padding(3, 2, 3, 2);
            Pnl_Top.Name = "Pnl_Top";
            Pnl_Top.Size = new Size(1024, 29);
            Pnl_Top.TabIndex = 0;
            Pnl_Top.MouseDown += Pnl_Top_MouseDown;
            // 
            // Btn_MinimizeApplication
            // 
            Btn_MinimizeApplication.BackColor = Color.FromArgb(198, 172, 143);
            Btn_MinimizeApplication.FlatAppearance.BorderSize = 0;
            Btn_MinimizeApplication.FlatStyle = FlatStyle.Flat;
            Btn_MinimizeApplication.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_MinimizeApplication.ForeColor = Color.White;
            Btn_MinimizeApplication.Location = new Point(919, 0);
            Btn_MinimizeApplication.Margin = new Padding(3, 2, 3, 2);
            Btn_MinimizeApplication.Name = "Btn_MinimizeApplication";
            Btn_MinimizeApplication.Padding = new Padding(0, 0, 0, 4);
            Btn_MinimizeApplication.Size = new Size(49, 29);
            Btn_MinimizeApplication.TabIndex = 5;
            Btn_MinimizeApplication.Text = "-";
            Btn_MinimizeApplication.UseCompatibleTextRendering = true;
            Btn_MinimizeApplication.UseVisualStyleBackColor = false;
            Btn_MinimizeApplication.Click += Btn_MinimizeApplication_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(198, 172, 143);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(973, 0);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 0, 0, 4);
            button1.Size = new Size(49, 29);
            button1.TabIndex = 6;
            button1.Text = "x";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = false;
            button1.Click += Btn_CloseApplication_Click;
            // 
            // Lbl_TituloPrograma
            // 
            Lbl_TituloPrograma.AutoSize = true;
            Lbl_TituloPrograma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_TituloPrograma.ForeColor = SystemColors.ActiveCaptionText;
            Lbl_TituloPrograma.Location = new Point(44, 0);
            Lbl_TituloPrograma.Name = "Lbl_TituloPrograma";
            Lbl_TituloPrograma.Size = new Size(144, 21);
            Lbl_TituloPrograma.TabIndex = 1;
            Lbl_TituloPrograma.Text = "Gerador de Pacotes";
            Lbl_TituloPrograma.MouseDown += Pnl_Top_MouseDown;
            // 
            // Pic_ExpandirMenu
            // 
            Pic_ExpandirMenu.AccessibleDescription = "Clique para expandir o menu";
            Pic_ExpandirMenu.AccessibleName = "Expandir";
            Pic_ExpandirMenu.AccessibleRole = AccessibleRole.Cursor;
            Pic_ExpandirMenu.BackColor = Color.FromArgb(198, 172, 143);
            Pic_ExpandirMenu.Cursor = Cursors.Hand;
            Pic_ExpandirMenu.Image = Properties.Resources.seta;
            Pic_ExpandirMenu.Location = new Point(0, 3);
            Pic_ExpandirMenu.Margin = new Padding(3, 2, 3, 2);
            Pic_ExpandirMenu.Name = "Pic_ExpandirMenu";
            Pic_ExpandirMenu.Size = new Size(38, 18);
            Pic_ExpandirMenu.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_ExpandirMenu.TabIndex = 0;
            Pic_ExpandirMenu.TabStop = false;
            Pic_ExpandirMenu.Click += Pic_ExpandirMenu_Click;
            Pic_ExpandirMenu.MouseLeave += Pic_ExpandirMenu_MouseLeave;
            Pic_ExpandirMenu.MouseHover += Pic_ExpandirMenu_MouseHover;
            // 
            // SidebarTransition
            // 
            SidebarTransition.Interval = 10;
            SidebarTransition.Tick += SidebarTransition_Tick;
            // 
            // Flp_Sidebar
            // 
            Flp_Sidebar.BackColor = Color.FromArgb(198, 172, 143);
            Flp_Sidebar.Controls.Add(Pic_Logo);
            Flp_Sidebar.Controls.Add(Btn_inicio);
            Flp_Sidebar.Controls.Add(Btn_Configuracoes);
            Flp_Sidebar.Controls.Add(Btn_Sobre);
            Flp_Sidebar.Location = new Point(0, 23);
            Flp_Sidebar.Margin = new Padding(3, 2, 3, 2);
            Flp_Sidebar.Name = "Flp_Sidebar";
            Flp_Sidebar.Size = new Size(166, 470);
            Flp_Sidebar.TabIndex = 2;
            // 
            // Pic_Logo
            // 
            Pic_Logo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Pic_Logo.Image = Properties.Resources.LOGO_PRINCIPAL;
            Pic_Logo.Location = new Point(3, 2);
            Pic_Logo.Margin = new Padding(3, 2, 3, 2);
            Pic_Logo.Name = "Pic_Logo";
            Pic_Logo.Size = new Size(164, 105);
            Pic_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_Logo.TabIndex = 1;
            Pic_Logo.TabStop = false;
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
            Btn_inicio.Location = new Point(3, 139);
            Btn_inicio.Margin = new Padding(3, 30, 3, 2);
            Btn_inicio.Name = "Btn_inicio";
            Btn_inicio.Size = new Size(164, 50);
            Btn_inicio.TabIndex = 3;
            Btn_inicio.Tag = "temp";
            Btn_inicio.Text = "INÍCIO";
            Btn_inicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_inicio.UseVisualStyleBackColor = false;
            Btn_inicio.Click += Btn_inicio_Click;
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
            Btn_Configuracoes.Location = new Point(3, 193);
            Btn_Configuracoes.Margin = new Padding(3, 2, 3, 2);
            Btn_Configuracoes.Name = "Btn_Configuracoes";
            Btn_Configuracoes.Size = new Size(164, 50);
            Btn_Configuracoes.TabIndex = 4;
            Btn_Configuracoes.Tag = "temp";
            Btn_Configuracoes.Text = "CONFIGURAÇÕES";
            Btn_Configuracoes.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Configuracoes.UseVisualStyleBackColor = false;
            Btn_Configuracoes.Click += Btn_Configuracoes_Click;
            // 
            // Btn_Sobre
            // 
            Btn_Sobre.BackColor = Color.FromArgb(198, 172, 143);
            Btn_Sobre.BackgroundImageLayout = ImageLayout.None;
            Btn_Sobre.Cursor = Cursors.Hand;
            Btn_Sobre.FlatAppearance.BorderSize = 0;
            Btn_Sobre.FlatStyle = FlatStyle.Flat;
            Flp_Sidebar.SetFlowBreak(Btn_Sobre, true);
            Btn_Sobre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Sobre.ForeColor = Color.FromArgb(45, 40, 33);
            Btn_Sobre.Image = Properties.Resources.sobre;
            Btn_Sobre.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Sobre.Location = new Point(3, 247);
            Btn_Sobre.Margin = new Padding(3, 2, 3, 2);
            Btn_Sobre.Name = "Btn_Sobre";
            Btn_Sobre.Size = new Size(164, 50);
            Btn_Sobre.TabIndex = 6;
            Btn_Sobre.Tag = "temp";
            Btn_Sobre.Text = "SOBRE";
            Btn_Sobre.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Sobre.UseVisualStyleBackColor = false;
            Btn_Sobre.Click += Btn_Sobre_Click;
            // 
            // Pnl_Principal
            // 
            Pnl_Principal.AllowDrop = true;
            Pnl_Principal.Dock = DockStyle.Fill;
            Pnl_Principal.ImeMode = ImeMode.NoControl;
            Pnl_Principal.Location = new Point(0, 0);
            Pnl_Principal.Margin = new Padding(3, 2, 3, 2);
            Pnl_Principal.Name = "Pnl_Principal";
            Pnl_Principal.Size = new Size(1024, 760);
            Pnl_Principal.TabIndex = 3;
            // 
            // Pnl_Exit
            // 
            Pnl_Exit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Pnl_Exit.BackColor = Color.FromArgb(198, 172, 143);
            Pnl_Exit.Controls.Add(Btn_Exit);
            Pnl_Exit.Location = new Point(0, 493);
            Pnl_Exit.Margin = new Padding(3, 2, 3, 2);
            Pnl_Exit.Name = "Pnl_Exit";
            Pnl_Exit.Size = new Size(166, 266);
            Pnl_Exit.TabIndex = 4;
            // 
            // Btn_Exit
            // 
            Btn_Exit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Btn_Exit.BackColor = Color.FromArgb(198, 172, 143);
            Btn_Exit.BackgroundImageLayout = ImageLayout.None;
            Btn_Exit.Cursor = Cursors.Hand;
            Btn_Exit.FlatAppearance.BorderSize = 0;
            Btn_Exit.FlatStyle = FlatStyle.Flat;
            Btn_Exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Exit.ForeColor = Color.FromArgb(45, 40, 33);
            Btn_Exit.Image = Properties.Resources.sair;
            Btn_Exit.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Exit.Location = new Point(0, 207);
            Btn_Exit.Margin = new Padding(3, 2, 3, 2);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(203, 59);
            Btn_Exit.TabIndex = 8;
            Btn_Exit.Tag = "temp";
            Btn_Exit.Text = "SAIR";
            Btn_Exit.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Exit.UseVisualStyleBackColor = false;
            Btn_Exit.Click += Btn_Exit_Click;
            // 
            // Frm_Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 760);
            Controls.Add(Pnl_Exit);
            Controls.Add(Flp_Sidebar);
            Controls.Add(Pnl_Top);
            Controls.Add(Pnl_Principal);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Frm_Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de Pacotes";
            FormClosing += Frm_Index_FormClosing;
            Pnl_Top.ResumeLayout(false);
            Pnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_ExpandirMenu).EndInit();
            Flp_Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pic_Logo).EndInit();
            Pnl_Exit.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Top;
        private PictureBox Pic_ExpandirMenu;
        private Label Lbl_TituloPrograma;
        private Button Btn_Gerar;
        private System.Windows.Forms.Timer SidebarTransition;
        private FlowLayoutPanel Flp_Sidebar;
        private PictureBox Pic_Logo;
        private Button Btn_Configuracoes;
        private Button Btn_Sobre;
        private Panel Pnl_Principal;
        private Panel Pnl_Exit;
        private Button Btn_Exit;
        internal Button Btn_inicio;
        private Button Btn_MinimizeApplication;
        private Button button1;
    }
}