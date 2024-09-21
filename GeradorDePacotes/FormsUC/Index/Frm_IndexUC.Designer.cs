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
            Chk_AutoInitialize = new CheckBox();
            Btn_Start = new ReaLTaiizor.Controls.ForeverButton();
            Btn_Stop = new ReaLTaiizor.Controls.ForeverButton();
            Lbl_ProgressMsg = new Label();
            Tlp_Content = new TableLayoutPanel();
            Pnl_ContentUC = new Panel();
            Pic_LoadingGIF = new PictureBox();
            Pnl_BtnGerar.SuspendLayout();
            Tlp_Content.SuspendLayout();
            Pnl_ContentUC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_LoadingGIF).BeginInit();
            SuspendLayout();
            // 
            // Prg_Bar
            // 
            Prg_Bar.AnimationSpeed = 5;
            Prg_Bar.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            Prg_Bar.Dock = DockStyle.Fill;
            Prg_Bar.FilledColor = Color.FromArgb(76, 149, 108);
            Prg_Bar.FilledColorAlpha = 255;
            Prg_Bar.FilledThickness = 25;
            Prg_Bar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            Prg_Bar.IsAnimated = false;
            Prg_Bar.Location = new Point(3, 3);
            Prg_Bar.Name = "Prg_Bar";
            Prg_Bar.Percentage = 0;
            Prg_Bar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            Prg_Bar.ShowText = true;
            Prg_Bar.Size = new Size(244, 242);
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
            Pnl_BtnGerar.Controls.Add(Chk_AutoInitialize);
            Pnl_BtnGerar.Controls.Add(Btn_Start);
            Pnl_BtnGerar.Controls.Add(Btn_Stop);
            Pnl_BtnGerar.Location = new Point(3, 251);
            Pnl_BtnGerar.Name = "Pnl_BtnGerar";
            Pnl_BtnGerar.Size = new Size(244, 110);
            Pnl_BtnGerar.TabIndex = 40;
            // 
            // Chk_AutoInitialize
            // 
            Chk_AutoInitialize.Anchor = AnchorStyles.Top;
            Chk_AutoInitialize.AutoSize = true;
            Chk_AutoInitialize.Location = new Point(52, 86);
            Chk_AutoInitialize.Name = "Chk_AutoInitialize";
            Chk_AutoInitialize.Size = new Size(139, 24);
            Chk_AutoInitialize.TabIndex = 36;
            Chk_AutoInitialize.Text = "Gerar ao iniciar?";
            Chk_AutoInitialize.UseVisualStyleBackColor = true;
            Chk_AutoInitialize.CheckedChanged += Chk_Inicializar_CheckedChanged;
            // 
            // Btn_Start
            // 
            Btn_Start.BackColor = Color.Transparent;
            Btn_Start.BaseColor = Color.FromArgb(76, 149, 108);
            Btn_Start.Font = new Font("Segoe UI", 12F);
            Btn_Start.Location = new Point(9, 24);
            Btn_Start.Name = "Btn_Start";
            Btn_Start.Rounded = false;
            Btn_Start.Size = new Size(225, 56);
            Btn_Start.TabIndex = 39;
            Btn_Start.Text = "Gerar Pacote";
            Btn_Start.TextColor = Color.FromArgb(243, 243, 243);
            Btn_Start.Click += Btn_GerarPacote_Click;
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
            Btn_Stop.Click += Btn_Stop_Click;
            // 
            // Lbl_ProgressMsg
            // 
            Lbl_ProgressMsg.Anchor = AnchorStyles.Top;
            Lbl_ProgressMsg.Font = new Font("Segoe UI", 11F);
            Lbl_ProgressMsg.Location = new Point(0, 389);
            Lbl_ProgressMsg.Name = "Lbl_ProgressMsg";
            Lbl_ProgressMsg.Size = new Size(408, 26);
            Lbl_ProgressMsg.TabIndex = 42;
            Lbl_ProgressMsg.Text = "Label Progresso";
            Lbl_ProgressMsg.TextAlign = ContentAlignment.MiddleCenter;
            Lbl_ProgressMsg.UseMnemonic = false;
            Lbl_ProgressMsg.Visible = false;
            Lbl_ProgressMsg.TextChanged += Lbl_ProgressMsg_TextChanged;
            // 
            // Tlp_Content
            // 
            Tlp_Content.ColumnCount = 1;
            Tlp_Content.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp_Content.Controls.Add(Prg_Bar, 0, 0);
            Tlp_Content.Controls.Add(Pnl_BtnGerar, 0, 1);
            Tlp_Content.Location = new Point(84, 22);
            Tlp_Content.Name = "Tlp_Content";
            Tlp_Content.RowCount = 2;
            Tlp_Content.RowStyles.Add(new RowStyle(SizeType.Percent, 68.31531F));
            Tlp_Content.RowStyles.Add(new RowStyle(SizeType.Percent, 31.6847F));
            Tlp_Content.Size = new Size(250, 364);
            Tlp_Content.TabIndex = 43;
            Tlp_Content.Tag = "main";
            // 
            // Pnl_ContentUC
            // 
            Pnl_ContentUC.Controls.Add(Pic_LoadingGIF);
            Pnl_ContentUC.Controls.Add(Tlp_Content);
            Pnl_ContentUC.Controls.Add(Lbl_ProgressMsg);
            Pnl_ContentUC.Location = new Point(260, 100);
            Pnl_ContentUC.Name = "Pnl_ContentUC";
            Pnl_ContentUC.Size = new Size(411, 472);
            Pnl_ContentUC.TabIndex = 44;
            Pnl_ContentUC.Tag = "main";
            // 
            // Pic_LoadingGIF
            // 
            Pic_LoadingGIF.Image = Properties.Resources.loading;
            Pic_LoadingGIF.Location = new Point(139, 418);
            Pic_LoadingGIF.Name = "Pic_LoadingGIF";
            Pic_LoadingGIF.Size = new Size(128, 43);
            Pic_LoadingGIF.SizeMode = PictureBoxSizeMode.AutoSize;
            Pic_LoadingGIF.TabIndex = 45;
            Pic_LoadingGIF.TabStop = false;
            Pic_LoadingGIF.Visible = false;
            // 
            // Frm_IndexUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 213, 202);
            Controls.Add(Pnl_ContentUC);
            Name = "Frm_IndexUC";
            Size = new Size(989, 734);
            Tag = "indexUC";
            Load += Frm_IndexUC_Load;
            Pnl_BtnGerar.ResumeLayout(false);
            Pnl_BtnGerar.PerformLayout();
            Tlp_Content.ResumeLayout(false);
            Pnl_ContentUC.ResumeLayout(false);
            Pnl_ContentUC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_LoadingGIF).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.ParrotCircleProgressBar Prg_Bar;
        private Panel Pnl_BtnGerar;
        private CheckBox Chk_AutoInitialize;
        private ReaLTaiizor.Controls.ForeverButton Btn_Start;
        private ReaLTaiizor.Controls.ForeverButton Btn_Stop;
        private TableLayoutPanel Tlp_Content;
        public Label Lbl_ProgressMsg;
        private Panel Pnl_ContentUC;
        private PictureBox Pic_LoadingGIF;
    }
}
