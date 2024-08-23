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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Index));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            Lbl_TituloPrograma = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(Lbl_TituloPrograma);
            panel1.Controls.Add(pictureBox2);
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
            Lbl_TituloPrograma.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_TituloPrograma.Location = new Point(78, 4);
            Lbl_TituloPrograma.Name = "Lbl_TituloPrograma";
            Lbl_TituloPrograma.Size = new Size(159, 23);
            Lbl_TituloPrograma.TabIndex = 1;
            Lbl_TituloPrograma.Text = "Gerador de Pacotes";
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleDescription = "Clique para expandir o menu";
            pictureBox2.AccessibleName = "Expandir";
            pictureBox2.Image = Properties.Resources.seta;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.LOGO_PRINCIPAL1;
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
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 32);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(44, 541);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(51, 15);
            button1.Name = "button1";
            button1.Size = new Size(159, 41);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(447, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 364);
            panel2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(51, 73);
            button2.Name = "button2";
            button2.Size = new Size(159, 50);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(51, 129);
            button3.Name = "button3";
            button3.Size = new Size(159, 53);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Frm_Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 573);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de Pacotes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label Lbl_TituloPrograma;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Panel panel2;
        private Button button3;
        private Button button2;
    }
}