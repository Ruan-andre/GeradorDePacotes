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
            Lbl_Progresso = new Label();
            Prg_Bar = new ReaLTaiizor.Controls.ParrotCircleProgressBar();
            Btn_GerarPacote = new Guna.UI2.WinForms.Guna2Button();
            Chk_Inicializar = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_Progresso
            // 
            Lbl_Progresso.Anchor = AnchorStyles.Top;
            Lbl_Progresso.AutoSize = true;
            Lbl_Progresso.Location = new Point(463, 430);
            Lbl_Progresso.Name = "Lbl_Progresso";
            Lbl_Progresso.Size = new Size(114, 20);
            Lbl_Progresso.TabIndex = 31;
            Lbl_Progresso.Text = "Label Progresso";
            Lbl_Progresso.Visible = false;
            // 
            // Prg_Bar
            // 
            Prg_Bar.Anchor = AnchorStyles.Top;
            Prg_Bar.AnimationSpeed = 5;
            Prg_Bar.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            Prg_Bar.FilledColor = Color.FromArgb(76, 149, 108);
            Prg_Bar.FilledColorAlpha = 255;
            Prg_Bar.FilledThickness = 25;
            Prg_Bar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            Prg_Bar.IsAnimated = false;
            Prg_Bar.Location = new Point(396, 177);
            Prg_Bar.Name = "Prg_Bar";
            Prg_Bar.Percentage = 50;
            Prg_Bar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            Prg_Bar.ShowText = true;
            Prg_Bar.Size = new Size(250, 250);
            Prg_Bar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Prg_Bar.TabIndex = 30;
            Prg_Bar.TextColor = Color.Gray;
            Prg_Bar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            Prg_Bar.TextSize = 25;
            Prg_Bar.UnFilledColor = Color.FromArgb(114, 114, 114);
            Prg_Bar.UnfilledThickness = 25;
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
            Btn_GerarPacote.Location = new Point(396, 493);
            Btn_GerarPacote.Name = "Btn_GerarPacote";
            Btn_GerarPacote.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Btn_GerarPacote.Size = new Size(225, 56);
            Btn_GerarPacote.TabIndex = 29;
            Btn_GerarPacote.Text = "Gerar Pacote";
            // 
            // Chk_Inicializar
            // 
            Chk_Inicializar.Anchor = AnchorStyles.Top;
            Chk_Inicializar.AutoSize = true;
            Chk_Inicializar.Location = new Point(437, 555);
            Chk_Inicializar.Name = "Chk_Inicializar";
            Chk_Inicializar.Size = new Size(139, 24);
            Chk_Inicializar.TabIndex = 28;
            Chk_Inicializar.Text = "Gerar ao iniciar?";
            Chk_Inicializar.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Left;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Location = new Point(129, 477);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 125);
            flowLayoutPanel1.TabIndex = 32;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(198, 172, 143);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            flowLayoutPanel1.SetFlowBreak(button1, true);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(45, 40, 33);
            button1.Image = Properties.Resources.sobre;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(207, 87);
            button1.TabIndex = 7;
            button1.Text = "SOBRE";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // Frm_IndexUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 213, 202);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Lbl_Progresso);
            Controls.Add(Prg_Bar);
            Controls.Add(Btn_GerarPacote);
            Controls.Add(Chk_Inicializar);
            Name = "Frm_IndexUC";
            Size = new Size(989, 721);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Progresso;
        private ReaLTaiizor.Controls.ParrotCircleProgressBar Prg_Bar;
        private Guna.UI2.WinForms.Guna2Button Btn_GerarPacote;
        private CheckBox Chk_Inicializar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
    }
}
