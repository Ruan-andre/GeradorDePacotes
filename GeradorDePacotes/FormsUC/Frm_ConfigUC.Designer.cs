namespace GeradorDePacotes
{
    partial class Frm_ConfigUC
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Txt_OutputFile = new TextBox();
            Txt_TargetFolder = new TextBox();
            Chk_AddDateHour = new CheckBox();
            checkBox1 = new CheckBox();
            Grp_OutputFile = new Guna.UI2.WinForms.Guna2GroupBox();
            Grp_TargetFolder = new Guna.UI2.WinForms.Guna2GroupBox();
            Grp_OutputFile.SuspendLayout();
            Grp_TargetFolder.SuspendLayout();
            SuspendLayout();
            // 
            // Txt_OutputFile
            // 
            Txt_OutputFile.Font = new Font("Segoe UI", 10F);
            Txt_OutputFile.Location = new Point(13, 49);
            Txt_OutputFile.MaxLength = 100;
            Txt_OutputFile.Name = "Txt_OutputFile";
            Txt_OutputFile.PlaceholderText = "Nome Do Seu Arquivo";
            Txt_OutputFile.Size = new Size(316, 30);
            Txt_OutputFile.TabIndex = 1;
            Txt_OutputFile.WordWrap = false;
            // 
            // Txt_TargetFolder
            // 
            Txt_TargetFolder.AllowDrop = true;
            Txt_TargetFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_TargetFolder.Font = new Font("Segoe UI", 10F);
            Txt_TargetFolder.Location = new Point(13, 54);
            Txt_TargetFolder.Name = "Txt_TargetFolder";
            Txt_TargetFolder.PlaceholderText = "Caminho da pasta alvo";
            Txt_TargetFolder.Size = new Size(314, 30);
            Txt_TargetFolder.TabIndex = 3;
            // 
            // Chk_AddDateHour
            // 
            Chk_AddDateHour.AccessibleDescription = "Se esta checkbox for marcada, o nome do arquivo terá o texto digitado mais a data e hora atual no formato ANO-MES-DIA-H-M-S";
            Chk_AddDateHour.AutoSize = true;
            Chk_AddDateHour.Checked = true;
            Chk_AddDateHour.CheckState = CheckState.Checked;
            Chk_AddDateHour.Font = new Font("Segoe UI", 9F);
            Chk_AddDateHour.Location = new Point(13, 85);
            Chk_AddDateHour.Name = "Chk_AddDateHour";
            Chk_AddDateHour.Size = new Size(230, 24);
            Chk_AddDateHour.TabIndex = 9;
            Chk_AddDateHour.Text = "Concatenar data e hora atual?";
            Chk_AddDateHour.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AccessibleDescription = "Se esta checkbox for marcada, o nome do arquivo terá o texto digitado mais a data e hora atual no formato ANO-MES-DIA-H-M-S";
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Segoe UI", 9F);
            checkBox1.Location = new Point(13, 87);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(188, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Mesma pasta de Saída?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Grp_OutputFile
            // 
            Grp_OutputFile.BorderColor = Color.FromArgb(198, 172, 143);
            Grp_OutputFile.Controls.Add(Txt_OutputFile);
            Grp_OutputFile.Controls.Add(Chk_AddDateHour);
            Grp_OutputFile.CustomBorderColor = Color.FromArgb(198, 172, 143);
            Grp_OutputFile.CustomizableEdges = customizableEdges1;
            Grp_OutputFile.FillColor = Color.FromArgb(227, 213, 202);
            Grp_OutputFile.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Grp_OutputFile.ForeColor = Color.Black;
            Grp_OutputFile.Location = new Point(238, 56);
            Grp_OutputFile.Name = "Grp_OutputFile";
            Grp_OutputFile.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Grp_OutputFile.Size = new Size(340, 117);
            Grp_OutputFile.TabIndex = 11;
            Grp_OutputFile.Text = "NOME DO ARQUIVO DE SAÍDA";
            // 
            // Grp_TargetFolder
            // 
            Grp_TargetFolder.AllowDrop = true;
            Grp_TargetFolder.BorderColor = Color.FromArgb(198, 172, 143);
            Grp_TargetFolder.Controls.Add(Txt_TargetFolder);
            Grp_TargetFolder.Controls.Add(checkBox1);
            Grp_TargetFolder.CustomBorderColor = Color.FromArgb(198, 172, 143);
            Grp_TargetFolder.CustomizableEdges = customizableEdges3;
            Grp_TargetFolder.FillColor = Color.FromArgb(227, 213, 202);
            Grp_TargetFolder.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Grp_TargetFolder.ForeColor = Color.Black;
            Grp_TargetFolder.Location = new Point(584, 56);
            Grp_TargetFolder.Name = "Grp_TargetFolder";
            Grp_TargetFolder.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Grp_TargetFolder.Size = new Size(340, 117);
            Grp_TargetFolder.TabIndex = 12;
            Grp_TargetFolder.Text = "NOME DA PASTA ALVO";
            // 
            // Frm_ConfigUC
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 213, 202);
            Controls.Add(Grp_TargetFolder);
            Controls.Add(Grp_OutputFile);
            Name = "Frm_ConfigUC";
            Size = new Size(989, 721);
            Grp_OutputFile.ResumeLayout(false);
            Grp_OutputFile.PerformLayout();
            Grp_TargetFolder.ResumeLayout(false);
            Grp_TargetFolder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox Txt_OutputFile;
        private TextBox Txt_TargetFolder;
        private CheckBox Chk_AddDateHour;
        private CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2GroupBox Grp_OutputFile;
        private Guna.UI2.WinForms.Guna2GroupBox Grp_TargetFolder;
    }
}
