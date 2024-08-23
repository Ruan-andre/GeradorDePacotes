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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Index));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            Lbl_TituloPrograma = new Label();
            Pic_ExpandirMenu = new PictureBox();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Btn_Inicio = new Button();
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
            panel1.Size = new Size(886, 32);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 161, 160);
            nightControlBox1.Location = new Point(747, 0);
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
            pictureBox1.Size = new Size(234, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(198, 172, 143);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(Btn_Inicio);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 32);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(232, 541);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(198, 172, 143);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(45, 40, 33);
            button1.Image = Properties.Resources.botao_de_inicio;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 162);
            button1.Name = "button1";
            button1.Size = new Size(247, 67);
            button1.TabIndex = 3;
            button1.Text = "Inicio";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(198, 172, 143);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = Color.FromArgb(45, 40, 33);
            button2.Image = Properties.Resources.botao_de_inicio;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 235);
            button2.Name = "button2";
            button2.Size = new Size(247, 67);
            button2.TabIndex = 3;
            button2.Text = "Inicio";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(198, 172, 143);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F);
            button3.ForeColor = Color.FromArgb(45, 40, 33);
            button3.Image = Properties.Resources.botao_de_inicio;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 308);
            button3.Name = "button3";
            button3.Size = new Size(247, 67);
            button3.TabIndex = 3;
            button3.Text = "Inicio";
            button3.UseVisualStyleBackColor = false;
            // 
            // Btn_Inicio
            // 
            Btn_Inicio.BackColor = Color.FromArgb(198, 172, 143);
            Btn_Inicio.BackgroundImageLayout = ImageLayout.None;
            Btn_Inicio.FlatAppearance.BorderSize = 0;
            Btn_Inicio.FlatStyle = FlatStyle.Flat;
            Btn_Inicio.Font = new Font("Segoe UI", 12F);
            Btn_Inicio.ForeColor = Color.FromArgb(45, 40, 33);
            Btn_Inicio.Image = Properties.Resources.botao_de_inicio;
            Btn_Inicio.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Inicio.Location = new Point(3, 381);
            Btn_Inicio.Name = "Btn_Inicio";
            Btn_Inicio.Size = new Size(247, 67);
            Btn_Inicio.TabIndex = 3;
            Btn_Inicio.Text = "Inicio";
            Btn_Inicio.UseVisualStyleBackColor = false;
            // 
            // Frm_Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 573);
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
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox Pic_ExpandirMenu;
        private Label Lbl_TituloPrograma;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Btn_Inicio;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}