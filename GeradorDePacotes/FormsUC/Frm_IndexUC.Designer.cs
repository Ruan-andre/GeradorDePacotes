namespace GeradorDePacotes
{
    partial class Frm_IndexUC
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
            _context?.Dispose();
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Pnl_Content_IndexUC = new Panel();
            Lbl_Progresso = new Label();
            Prg_Bar = new ReaLTaiizor.Controls.ParrotCircleProgressBar();
            Pnl_BtnGerar = new Panel();
            Btn_GerarPacote = new Guna.UI2.WinForms.Guna2Button();
            Chk_Inicializar = new CheckBox();
            Pnl_Content_IndexUC.SuspendLayout();
            Pnl_BtnGerar.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_Content_IndexUC
            // 
            Pnl_Content_IndexUC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Pnl_Content_IndexUC.Controls.Add(Lbl_Progresso);
            Pnl_Content_IndexUC.Controls.Add(Prg_Bar);
            Pnl_Content_IndexUC.Controls.Add(Pnl_BtnGerar);
            Pnl_Content_IndexUC.Location = new Point(403, 107);
            Pnl_Content_IndexUC.Name = "Pnl_Content_IndexUC";
            Pnl_Content_IndexUC.Size = new Size(268, 432);
            Pnl_Content_IndexUC.TabIndex = 32;
            // 
            // Lbl_Progresso
            // 
            Lbl_Progresso.Anchor = AnchorStyles.Top;
            Lbl_Progresso.AutoEllipsis = true;
            Lbl_Progresso.AutoSize = true;
            Lbl_Progresso.Font = new Font("Segoe UI", 11F);
            Lbl_Progresso.Location = new Point(23, 280);
            Lbl_Progresso.Name = "Lbl_Progresso";
            Lbl_Progresso.Size = new Size(146, 25);
            Lbl_Progresso.TabIndex = 42;
            Lbl_Progresso.Text = "Label Progresso";
            Lbl_Progresso.TextAlign = ContentAlignment.MiddleCenter;
            Lbl_Progresso.UseMnemonic = false;
            Lbl_Progresso.Visible = false;
            // 
            // Prg_Bar
            // 
            Prg_Bar.Anchor = AnchorStyles.None;
            Prg_Bar.AnimationSpeed = 5;
            Prg_Bar.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            Prg_Bar.FilledColor = Color.FromArgb(76, 149, 108);
            Prg_Bar.FilledColorAlpha = 255;
            Prg_Bar.FilledThickness = 25;
            Prg_Bar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            Prg_Bar.IsAnimated = false;
            Prg_Bar.Location = new Point(23, 36);
            Prg_Bar.Name = "Prg_Bar";
            Prg_Bar.Percentage = 50;
            Prg_Bar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            Prg_Bar.ShowText = true;
            Prg_Bar.Size = new Size(225, 234);
            Prg_Bar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Prg_Bar.TabIndex = 41;
            Prg_Bar.TextColor = Color.Gray;
            Prg_Bar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            Prg_Bar.TextSize = 25;
            Prg_Bar.UnFilledColor = Color.FromArgb(114, 114, 114);
            Prg_Bar.UnfilledThickness = 25;
            Prg_Bar.Visible = false;
            // 
            // Pnl_BtnGerar
            // 
            Pnl_BtnGerar.Controls.Add(Btn_GerarPacote);
            Pnl_BtnGerar.Controls.Add(Chk_Inicializar);
            Pnl_BtnGerar.Location = new Point(11, 317);
            Pnl_BtnGerar.Name = "Pnl_BtnGerar";
            Pnl_BtnGerar.Size = new Size(250, 87);
            Pnl_BtnGerar.TabIndex = 40;
            // 
            // Btn_GerarPacote
            // 
            Btn_GerarPacote.Anchor = AnchorStyles.Top;
            Btn_GerarPacote.Animated = true;
            Btn_GerarPacote.CustomizableEdges = customizableEdges1;
            Btn_GerarPacote.DisabledState.BorderColor = Color.DarkGray;
            Btn_GerarPacote.DisabledState.CustomBorderColor = Color.DarkGray;
            Btn_GerarPacote.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Btn_GerarPacote.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Btn_GerarPacote.FillColor = Color.FromArgb(76, 149, 108);
            Btn_GerarPacote.Font = new Font("Segoe UI", 13F);
            Btn_GerarPacote.ForeColor = Color.White;
            Btn_GerarPacote.Location = new Point(12, 3);
            Btn_GerarPacote.Name = "Btn_GerarPacote";
            Btn_GerarPacote.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Btn_GerarPacote.Size = new Size(225, 56);
            Btn_GerarPacote.TabIndex = 37;
            Btn_GerarPacote.Text = "Gerar Pacote";
            Btn_GerarPacote.Click += Btn_GerarPacote_Click;
            // 
            // Chk_Inicializar
            // 
            Chk_Inicializar.Anchor = AnchorStyles.Top;
            Chk_Inicializar.AutoSize = true;
            Chk_Inicializar.Location = new Point(51, 65);
            Chk_Inicializar.Name = "Chk_Inicializar";
            Chk_Inicializar.Size = new Size(139, 24);
            Chk_Inicializar.TabIndex = 36;
            Chk_Inicializar.Text = "Gerar ao iniciar?";
            Chk_Inicializar.UseVisualStyleBackColor = true;
            Chk_Inicializar.CheckedChanged += Chk_Inicializar_CheckedChanged;
            // 
            // Frm_IndexUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 213, 202);
            Controls.Add(Pnl_Content_IndexUC);
            Name = "Frm_IndexUC";
            Size = new Size(989, 721);
            Tag = "indexUC";
            Load += Frm_IndexUC_Load;
            Pnl_Content_IndexUC.ResumeLayout(false);
            Pnl_Content_IndexUC.PerformLayout();
            Pnl_BtnGerar.ResumeLayout(false);
            Pnl_BtnGerar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Panel Pnl_Content_IndexUC;
        private Label Lbl_Progresso;
        private ReaLTaiizor.Controls.ParrotCircleProgressBar Prg_Bar;
        private Panel Pnl_BtnGerar;
        private Guna.UI2.WinForms.Guna2Button Btn_GerarPacote;
        private CheckBox Chk_Inicializar;
    }
}
