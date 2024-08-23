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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Index));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            Lbl_TituloPrograma = new Label();
            Pic_ExpandirMenu = new PictureBox();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            checkBox1 = new CheckBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            circleProgressBar1 = new ReaLTaiizor.Controls.CircleProgressBar();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_ExpandirMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(Lbl_TituloPrograma);
            panel1.Controls.Add(Pic_ExpandirMenu);
            panel1.Dock = DockStyle.Top;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1157, 32);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.DarkGray;
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.Dock = DockStyle.Right;
            nightControlBox1.EnableCloseColor = Color.Black;
            nightControlBox1.EnableMaximizeButton = false;
            nightControlBox1.EnableMaximizeColor = Color.DarkGray;
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.Black;
            nightControlBox1.Location = new Point(1018, 0);
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
            pictureBox1.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.BackColor = Color.FromArgb(198, 172, 143);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Location = new Point(0, 32);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(44, 705);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(198, 172, 143);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(45, 40, 33);
            button1.Image = Properties.Resources.botao_de_inicio;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 181);
            button1.Margin = new Padding(3, 35, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(212, 67);
            button1.TabIndex = 3;
            button1.Text = "INÍCIO";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.BackColor = Color.FromArgb(198, 172, 143);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(45, 40, 33);
            button2.Image = Properties.Resources.configuracao;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 254);
            button2.Name = "button2";
            button2.Size = new Size(212, 67);
            button2.TabIndex = 4;
            button2.Text = "CONFIGURAÇÕES";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.BackColor = Color.FromArgb(198, 172, 143);
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            flowLayoutPanel1.SetFlowBreak(button4, true);
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(45, 40, 33);
            button4.Image = Properties.Resources.sobre;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 434);
            button4.Margin = new Padding(3, 110, 3, 3);
            button4.Name = "button4";
            button4.Size = new Size(207, 87);
            button4.TabIndex = 6;
            button4.Text = "SOBRE";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(447, 498);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(139, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Gerar ao iniciar?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(76, 149, 108);
            guna2Button1.Font = new Font("Segoe UI", 13F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(406, 436);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(225, 56);
            guna2Button1.TabIndex = 6;
            guna2Button1.Text = "Gerar Pacote";
            // 
            // guna2CircleProgressBar1
            // 
            guna2CircleProgressBar1.FillColor = Color.FromArgb(200, 213, 218, 223);
            guna2CircleProgressBar1.Font = new Font("Segoe UI", 12F);
            guna2CircleProgressBar1.ForeColor = Color.White;
            guna2CircleProgressBar1.Location = new Point(642, 240);
            guna2CircleProgressBar1.Minimum = 0;
            guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            guna2CircleProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleProgressBar1.Size = new Size(162, 162);
            guna2CircleProgressBar1.TabIndex = 7;
            guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            // 
            // circleProgressBar1
            // 
            circleProgressBar1.Font = new Font("Segoe UI", 15F);
            circleProgressBar1.Location = new Point(334, 261);
            circleProgressBar1.Maximum = 100L;
            circleProgressBar1.MinimumSize = new Size(100, 100);
            circleProgressBar1.Name = "circleProgressBar1";
            circleProgressBar1.PercentColor = Color.White;
            circleProgressBar1.ProgressColor1 = Color.FromArgb(92, 92, 92);
            circleProgressBar1.ProgressColor2 = Color.FromArgb(92, 92, 92);
            circleProgressBar1.ProgressShape = ReaLTaiizor.Controls.CircleProgressBar._ProgressShape.Round;
            circleProgressBar1.Size = new Size(162, 162);
            circleProgressBar1.TabIndex = 8;
            circleProgressBar1.Text = "circleProgressBar1";
            circleProgressBar1.Value = 0L;
            // 
            // Frm_Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 213, 202);
            ClientSize = new Size(1157, 737);
            Controls.Add(circleProgressBar1);
            Controls.Add(guna2CircleProgressBar1);
            Controls.Add(guna2Button1);
            Controls.Add(checkBox1);
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
        private Button button1;
        private Button button2;
        private Button button4;
        private Button Btn_Gerar;
        private CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private ReaLTaiizor.Controls.CircleProgressBar circleProgressBar1;
    }
}