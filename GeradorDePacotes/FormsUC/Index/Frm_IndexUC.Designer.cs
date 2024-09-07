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
            Prg_Bar = new ReaLTaiizor.Controls.ParrotCircleProgressBar();
            Pnl_BtnGerar = new Panel();
            Lbl_Progress = new Label();
            Chk_Inicializar = new CheckBox();
            Btn_GerarPacote = new ReaLTaiizor.Controls.ForeverButton();
            Btn_Stop = new ReaLTaiizor.Controls.ForeverButton();
            Tlp_Content = new TableLayoutPanel();
            Pnl_BtnGerar.SuspendLayout();
            Tlp_Content.SuspendLayout();
            SuspendLayout();
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
            Prg_Bar.Location = new Point(12, 5);
            Prg_Bar.Name = "Prg_Bar";
            Prg_Bar.Percentage = 0;
            Prg_Bar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            Prg_Bar.ShowText = true;
            Prg_Bar.Size = new Size(225, 210);
            Prg_Bar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Prg_Bar.TabIndex = 41;
            Prg_Bar.TextColor = Color.Gray;
            Prg_Bar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            Prg_Bar.TextSize = 25;
            Prg_Bar.UnFilledColor = Color.FromArgb(114, 114, 114);
            Prg_Bar.UnfilledThickness = 25;
            // 
            // Pnl_BtnGerar
            // 
            Pnl_BtnGerar.Controls.Add(Lbl_Progress);
            Pnl_BtnGerar.Controls.Add(Chk_Inicializar);
            Pnl_BtnGerar.Controls.Add(Btn_GerarPacote);
            Pnl_BtnGerar.Controls.Add(Btn_Stop);
            Pnl_BtnGerar.Location = new Point(3, 224);
            Pnl_BtnGerar.Name = "Pnl_BtnGerar";
            Pnl_BtnGerar.Size = new Size(244, 183);
            Pnl_BtnGerar.TabIndex = 40;
            // 
            // Lbl_Progress
            // 
            Lbl_Progress.Anchor = AnchorStyles.Top;
            Lbl_Progress.AutoEllipsis = true;
            Lbl_Progress.AutoSize = true;
            Lbl_Progress.Font = new Font("Segoe UI", 11F);
            Lbl_Progress.Location = new Point(0, 135);
            Lbl_Progress.Name = "Lbl_Progress";
            Lbl_Progress.Size = new Size(146, 25);
            Lbl_Progress.TabIndex = 42;
            Lbl_Progress.Text = "Label Progresso";
            Lbl_Progress.TextAlign = ContentAlignment.MiddleCenter;
            Lbl_Progress.UseMnemonic = false;
            Lbl_Progress.Visible = false;
            // 
            // Chk_Inicializar
            // 
            Chk_Inicializar.Anchor = AnchorStyles.Top;
            Chk_Inicializar.AutoSize = true;
            Chk_Inicializar.Location = new Point(52, 86);
            Chk_Inicializar.Name = "Chk_Inicializar";
            Chk_Inicializar.Size = new Size(139, 24);
            Chk_Inicializar.TabIndex = 36;
            Chk_Inicializar.Text = "Gerar ao iniciar?";
            Chk_Inicializar.UseVisualStyleBackColor = true;
            Chk_Inicializar.CheckedChanged += Chk_Inicializar_CheckedChanged;
            // 
            // Btn_GerarPacote
            // 
            Btn_GerarPacote.BackColor = Color.Transparent;
            Btn_GerarPacote.BaseColor = Color.FromArgb(76, 149, 108);
            Btn_GerarPacote.Font = new Font("Segoe UI", 12F);
            Btn_GerarPacote.Location = new Point(9, 24);
            Btn_GerarPacote.Name = "Btn_GerarPacote";
            Btn_GerarPacote.Rounded = false;
            Btn_GerarPacote.Size = new Size(225, 56);
            Btn_GerarPacote.TabIndex = 39;
            Btn_GerarPacote.Text = "Gerar Pacote";
            Btn_GerarPacote.TextColor = Color.FromArgb(243, 243, 243);
            Btn_GerarPacote.Click += Btn_GerarPacote_Click;
            // 
            // Btn_Stop
            // 
            Btn_Stop.BackColor = Color.Transparent;
            Btn_Stop.BaseColor = Color.FromArgb(170, 0, 0);
            Btn_Stop.Font = new Font("Segoe UI", 12F);
            Btn_Stop.Location = new Point(9, 24);
            Btn_Stop.Name = "Btn_Stop";
            Btn_Stop.Rounded = false;
            Btn_Stop.Size = new Size(225, 56);
            Btn_Stop.TabIndex = 40;
            Btn_Stop.Text = "PARAR";
            Btn_Stop.TextColor = Color.FromArgb(243, 243, 243);
            Btn_Stop.Visible = false;
            // 
            // Tlp_Content
            // 
            Tlp_Content.ColumnCount = 1;
            Tlp_Content.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_Content.Controls.Add(Prg_Bar, 0, 0);
            Tlp_Content.Controls.Add(Pnl_BtnGerar, 0, 1);
            Tlp_Content.Location = new Point(388, 104);
            Tlp_Content.Name = "Tlp_Content";
            Tlp_Content.RowCount = 2;
            Tlp_Content.RowStyles.Add(new RowStyle(SizeType.Percent, 53.90244F));
            Tlp_Content.RowStyles.Add(new RowStyle(SizeType.Percent, 46.09756F));
            Tlp_Content.Size = new Size(250, 410);
            Tlp_Content.TabIndex = 43;
            Tlp_Content.Tag = "main";
            // 
            // Frm_IndexUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 213, 202);
            Controls.Add(Tlp_Content);
            Name = "Frm_IndexUC";
            Size = new Size(989, 721);
            Tag = "indexUC";
            Load += Frm_IndexUC_Load;
            Pnl_BtnGerar.ResumeLayout(false);
            Pnl_BtnGerar.PerformLayout();
            Tlp_Content.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.ParrotCircleProgressBar Prg_Bar;
        private Panel Pnl_BtnGerar;
        private CheckBox Chk_Inicializar;
        private ReaLTaiizor.Controls.ForeverButton Btn_GerarPacote;
        private ReaLTaiizor.Controls.ForeverButton Btn_Stop;
        private TableLayoutPanel Tlp_Content;
        private Label Lbl_Progress;
    }
}
