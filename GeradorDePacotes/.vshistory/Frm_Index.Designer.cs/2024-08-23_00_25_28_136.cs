﻿namespace GeradorDePacotes
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Index));
            Pnl_Top = new Panel();
            guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            Lbl_TituloPrograma = new Label();
            Pic_ExpandirMenu = new PictureBox();
            Cb_items = new Guna.UI2.WinForms.Guna2ControlBox();
            Pic_Logo = new PictureBox();
            Flp_sidebar = new FlowLayoutPanel();
            Btn_inicio = new Button();
            Btn_Configuracoes = new Button();
            Btn_Sobre = new Button();
            SidebarTransition = new System.Windows.Forms.Timer(components);
            Pnl_Principal = new Panel();
            Pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_ExpandirMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Logo).BeginInit();
            Flp_sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_Top
            // 
            Pnl_Top.AllowDrop = true;
            Pnl_Top.BackColor = Color.FromArgb(198, 172, 143);
            Pnl_Top.Controls.Add(guna2ControlBox2);
            Pnl_Top.Controls.Add(guna2ControlBox1);
            Pnl_Top.Controls.Add(Lbl_TituloPrograma);
            Pnl_Top.Controls.Add(Pic_ExpandirMenu);
            Pnl_Top.Controls.Add(Cb_items);
            Pnl_Top.Dock = DockStyle.Top;
            Pnl_Top.ForeColor = SystemColors.ButtonHighlight;
            Pnl_Top.ImeMode = ImeMode.NoControl;
            Pnl_Top.Location = new Point(0, 0);
            Pnl_Top.Name = "Pnl_Top";
            Pnl_Top.Size = new Size(963, 32);
            Pnl_Top.TabIndex = 0;
            Pnl_Top.MouseDown += Pnl_Top_MouseDown;
            // 
            // guna2ControlBox2
            // 
            guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox2.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            guna2ControlBox2.CustomizableEdges = customizableEdges1;
            guna2ControlBox2.FillColor = Color.FromArgb(198, 172, 143);
            guna2ControlBox2.HoverState.IconColor = Color.Blue;
            guna2ControlBox2.IconColor = Color.White;
            guna2ControlBox2.Location = new Point(855, -4);
            guna2ControlBox2.Name = "guna2ControlBox2";
            guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox2.Size = new Size(56, 36);
            guna2ControlBox2.TabIndex = 3;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBox1.CustomizableEdges = customizableEdges3;
            guna2ControlBox1.FillColor = Color.FromArgb(198, 172, 143);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(806, -4);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ControlBox1.Size = new Size(56, 36);
            guna2ControlBox1.TabIndex = 2;
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
            Pic_ExpandirMenu.Location = new Point(0, 4);
            Pic_ExpandirMenu.Name = "Pic_ExpandirMenu";
            Pic_ExpandirMenu.Size = new Size(44, 24);
            Pic_ExpandirMenu.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_ExpandirMenu.TabIndex = 0;
            Pic_ExpandirMenu.TabStop = false;
            Pic_ExpandirMenu.Click += Pic_ExpandirMenu_Click;
            Pic_ExpandirMenu.MouseLeave += Pic_ExpandirMenu_MouseLeave;
            Pic_ExpandirMenu.MouseHover += Pic_ExpandirMenu_MouseHover;
            // 
            // Cb_items
            // 
            Cb_items.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Cb_items.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            Cb_items.CustomizableEdges = customizableEdges5;
            Cb_items.FillColor = Color.FromArgb(198, 172, 143);
            Cb_items.HoverState.FillColor = Color.FromArgb(192, 0, 0);
            Cb_items.IconColor = Color.White;
            Cb_items.Location = new Point(907, -4);
            Cb_items.Name = "Cb_items";
            Cb_items.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Cb_items.Size = new Size(56, 36);
            Cb_items.TabIndex = 0;
            // 
            // Pic_Logo
            // 
            Pic_Logo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Pic_Logo.Image = Properties.Resources.LOGO_PRINCIPAL;
            Pic_Logo.Location = new Point(3, 3);
            Pic_Logo.Name = "Pic_Logo";
            Pic_Logo.Size = new Size(210, 140);
            Pic_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_Logo.TabIndex = 1;
            Pic_Logo.TabStop = false;
            // 
            // Flp_sidebar
            // 
            Flp_sidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Flp_sidebar.BackColor = Color.FromArgb(198, 172, 143);
            Flp_sidebar.Controls.Add(Pic_Logo);
            Flp_sidebar.Controls.Add(Btn_inicio);
            Flp_sidebar.Controls.Add(Btn_Configuracoes);
            Flp_sidebar.Controls.Add(Btn_Sobre);
            Flp_sidebar.Location = new Point(0, 32);
            Flp_sidebar.Name = "Flp_sidebar";
            Flp_sidebar.Size = new Size(232, 705);
            Flp_sidebar.TabIndex = 2;
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
            Btn_Sobre.BackColor = Color.FromArgb(198, 172, 143);
            Btn_Sobre.BackgroundImageLayout = ImageLayout.None;
            Btn_Sobre.Cursor = Cursors.Hand;
            Btn_Sobre.Dock = DockStyle.Bottom;
            Btn_Sobre.FlatAppearance.BorderSize = 0;
            Btn_Sobre.FlatStyle = FlatStyle.Flat;
            Flp_sidebar.SetFlowBreak(Btn_Sobre, true);
            Btn_Sobre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Sobre.ForeColor = Color.FromArgb(45, 40, 33);
            Btn_Sobre.Image = Properties.Resources.sobre;
            Btn_Sobre.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Sobre.Location = new Point(3, 327);
            Btn_Sobre.Name = "Btn_Sobre";
            Btn_Sobre.Size = new Size(207, 87);
            Btn_Sobre.TabIndex = 6;
            Btn_Sobre.Text = "SOBRE";
            Btn_Sobre.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Sobre.UseVisualStyleBackColor = false;
            Btn_Sobre.Click += button4_Click;
            // 
            // SidebarTransition
            // 
            SidebarTransition.Interval = 10;
            SidebarTransition.Tick += SidebarTransition_Tick;
            // 
            // Pnl_Principal
            // 
            Pnl_Principal.AllowDrop = true;
            Pnl_Principal.Dock = DockStyle.Fill;
            Pnl_Principal.ImeMode = ImeMode.NoControl;
            Pnl_Principal.Location = new Point(0, 0);
            Pnl_Principal.Name = "Pnl_Principal";
            Pnl_Principal.Size = new Size(963, 737);
            Pnl_Principal.TabIndex = 3;
            // 
            // Frm_Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 737);
            Controls.Add(Flp_sidebar);
            Controls.Add(Pnl_Top);
            Controls.Add(Pnl_Principal);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de Pacotes";
            Pnl_Top.ResumeLayout(false);
            Pnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_ExpandirMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Logo).EndInit();
            Flp_sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Top;
        private PictureBox Pic_Logo;
        private PictureBox Pic_ExpandirMenu;
        private Label Lbl_TituloPrograma;
        private FlowLayoutPanel Flp_sidebar;
        private Button Btn_inicio;
        private Button Btn_Configuracoes;
        private Button Btn_Sobre;
        private Button Btn_Gerar;
        private System.Windows.Forms.Timer SidebarTransition;
        private Panel Pnl_Principal;
        private Guna.UI2.WinForms.Guna2ControlBox Cb_items;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}