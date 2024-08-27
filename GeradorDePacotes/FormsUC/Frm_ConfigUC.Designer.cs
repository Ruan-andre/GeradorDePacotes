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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Txt_OutputFile = new TextBox();
            Txt_TargetFolder = new TextBox();
            Chb_AddDateHourToName = new CheckBox();
            Chb_SameOutputFolder = new CheckBox();
            Grp_OutputFile = new Guna.UI2.WinForms.Guna2GroupBox();
            pictureBox2 = new PictureBox();
            Cmb_Formatos = new ComboBox();
            Grp_TargetFolder = new Guna.UI2.WinForms.Guna2GroupBox();
            pictureBox1 = new PictureBox();
            Btn_ExploreFolders = new ReaLTaiizor.Controls.ChatButtonLeft();
            Pnl_ContentConfig = new Panel();
            guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            dataGridView2 = new DataGridView();
            Grp_FoldersToDelete = new Guna.UI2.WinForms.Guna2GroupBox();
            dataGridView1 = new DataGridView();
            Fbd_Config = new FolderBrowserDialog();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            dataGridView3 = new DataGridView();
            guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            dataGridView4 = new DataGridView();
            Grp_OutputFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Grp_TargetFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Pnl_ContentConfig.SuspendLayout();
            guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            Grp_FoldersToDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // Txt_OutputFile
            // 
            Txt_OutputFile.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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
            Txt_TargetFolder.MaxLength = 255;
            Txt_TargetFolder.Name = "Txt_TargetFolder";
            Txt_TargetFolder.PlaceholderText = "Caminho da pasta alvo";
            Txt_TargetFolder.Size = new Size(292, 30);
            Txt_TargetFolder.TabIndex = 3;
            Txt_TargetFolder.WordWrap = false;
            // 
            // Chb_AddDateHourToName
            // 
            Chb_AddDateHourToName.AccessibleDescription = "Se esta checkbox for marcada, o nome do arquivo terá o texto digitado mais a data e hora atual no formato ANO-MES-DIA-H-M-S";
            Chb_AddDateHourToName.AutoSize = true;
            Chb_AddDateHourToName.Checked = true;
            Chb_AddDateHourToName.CheckState = CheckState.Checked;
            Chb_AddDateHourToName.Font = new Font("Segoe UI", 9F);
            Chb_AddDateHourToName.Location = new Point(13, 90);
            Chb_AddDateHourToName.Name = "Chb_AddDateHourToName";
            Chb_AddDateHourToName.Size = new Size(230, 24);
            Chb_AddDateHourToName.TabIndex = 9;
            Chb_AddDateHourToName.Text = "Concatenar data e hora atual?";
            Chb_AddDateHourToName.UseVisualStyleBackColor = true;
            // 
            // Chb_SameOutputFolder
            // 
            Chb_SameOutputFolder.AccessibleDescription = "Se esta checkbox for marcada, o nome do arquivo terá o texto digitado mais a data e hora atual no formato ANO-MES-DIA-H-M-S";
            Chb_SameOutputFolder.AutoSize = true;
            Chb_SameOutputFolder.Checked = true;
            Chb_SameOutputFolder.CheckState = CheckState.Checked;
            Chb_SameOutputFolder.Font = new Font("Segoe UI", 9F);
            Chb_SameOutputFolder.Location = new Point(13, 99);
            Chb_SameOutputFolder.Name = "Chb_SameOutputFolder";
            Chb_SameOutputFolder.Size = new Size(188, 24);
            Chb_SameOutputFolder.TabIndex = 10;
            Chb_SameOutputFolder.Text = "Mesma pasta de Saída?";
            Chb_SameOutputFolder.UseVisualStyleBackColor = true;
            // 
            // Grp_OutputFile
            // 
            Grp_OutputFile.BorderColor = Color.FromArgb(198, 172, 143);
            Grp_OutputFile.Controls.Add(pictureBox2);
            Grp_OutputFile.Controls.Add(Cmb_Formatos);
            Grp_OutputFile.Controls.Add(Txt_OutputFile);
            Grp_OutputFile.Controls.Add(Chb_AddDateHourToName);
            Grp_OutputFile.CustomBorderColor = Color.FromArgb(198, 172, 143);
            Grp_OutputFile.CustomizableEdges = customizableEdges1;
            Grp_OutputFile.FillColor = Color.FromArgb(227, 213, 202);
            Grp_OutputFile.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Grp_OutputFile.ForeColor = Color.Black;
            Grp_OutputFile.Location = new Point(0, 3);
            Grp_OutputFile.Name = "Grp_OutputFile";
            Grp_OutputFile.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Grp_OutputFile.Size = new Size(340, 126);
            Grp_OutputFile.TabIndex = 11;
            Grp_OutputFile.Text = "      NOME DO ARQUIVO DE SAÍDA";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(198, 172, 143);
            pictureBox2.Image = Properties.Resources.arquivo;
            pictureBox2.Location = new Point(3, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // Cmb_Formatos
            // 
            Cmb_Formatos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Cmb_Formatos.DisplayMember = "1";
            Cmb_Formatos.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_Formatos.FormattingEnabled = true;
            Cmb_Formatos.Items.AddRange(new object[] { "RAR", "ZIP" });
            Cmb_Formatos.Location = new Point(255, 84);
            Cmb_Formatos.Name = "Cmb_Formatos";
            Cmb_Formatos.Size = new Size(74, 33);
            Cmb_Formatos.Sorted = true;
            Cmb_Formatos.TabIndex = 10;
            // 
            // Grp_TargetFolder
            // 
            Grp_TargetFolder.AllowDrop = true;
            Grp_TargetFolder.BorderColor = Color.FromArgb(198, 172, 143);
            Grp_TargetFolder.Controls.Add(pictureBox1);
            Grp_TargetFolder.Controls.Add(Btn_ExploreFolders);
            Grp_TargetFolder.Controls.Add(Txt_TargetFolder);
            Grp_TargetFolder.Controls.Add(Chb_SameOutputFolder);
            Grp_TargetFolder.CustomBorderColor = Color.FromArgb(198, 172, 143);
            Grp_TargetFolder.CustomizableEdges = customizableEdges3;
            Grp_TargetFolder.FillColor = Color.FromArgb(227, 213, 202);
            Grp_TargetFolder.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Grp_TargetFolder.ForeColor = Color.Black;
            Grp_TargetFolder.Location = new Point(346, 3);
            Grp_TargetFolder.Name = "Grp_TargetFolder";
            Grp_TargetFolder.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Grp_TargetFolder.Size = new Size(340, 126);
            Grp_TargetFolder.TabIndex = 12;
            Grp_TargetFolder.Text = "     NOME DA PASTA ALVO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(198, 172, 143);
            pictureBox1.Image = Properties.Resources.pasta;
            pictureBox1.Location = new Point(3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Btn_ExploreFolders
            // 
            Btn_ExploreFolders.BackColor = Color.Transparent;
            Btn_ExploreFolders.Font = new Font("Segoe UI", 12F);
            Btn_ExploreFolders.Image = Properties.Resources.abrir_pasta;
            Btn_ExploreFolders.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_ExploreFolders.InactiveColorA = Color.FromArgb(251, 251, 251);
            Btn_ExploreFolders.InactiveColorB = Color.FromArgb(225, 225, 225);
            Btn_ExploreFolders.Location = new Point(306, 54);
            Btn_ExploreFolders.Name = "Btn_ExploreFolders";
            Btn_ExploreFolders.PressedColorA = Color.FromArgb(235, 235, 235);
            Btn_ExploreFolders.PressedColorB = Color.FromArgb(223, 223, 223);
            Btn_ExploreFolders.PressedContourColorA = Color.FromArgb(167, 167, 167);
            Btn_ExploreFolders.PressedContourColorB = Color.FromArgb(167, 167, 167);
            Btn_ExploreFolders.Size = new Size(34, 30);
            Btn_ExploreFolders.TabIndex = 16;
            Btn_ExploreFolders.TextAlignment = StringAlignment.Center;
            Btn_ExploreFolders.Click += Btn_ExploreFolders_Click;
            // 
            // Pnl_ContentConfig
            // 
            Pnl_ContentConfig.Controls.Add(guna2GroupBox1);
            Pnl_ContentConfig.Controls.Add(guna2GroupBox3);
            Pnl_ContentConfig.Controls.Add(guna2GroupBox2);
            Pnl_ContentConfig.Controls.Add(Grp_FoldersToDelete);
            Pnl_ContentConfig.Controls.Add(Grp_OutputFile);
            Pnl_ContentConfig.Controls.Add(Grp_TargetFolder);
            Pnl_ContentConfig.Location = new Point(233, 63);
            Pnl_ContentConfig.Name = "Pnl_ContentConfig";
            Pnl_ContentConfig.Size = new Size(686, 655);
            Pnl_ContentConfig.TabIndex = 13;
            // 
            // guna2GroupBox2
            // 
            guna2GroupBox2.BorderColor = Color.FromArgb(198, 172, 143);
            guna2GroupBox2.Controls.Add(dataGridView2);
            guna2GroupBox2.CustomBorderColor = Color.FromArgb(198, 172, 143);
            guna2GroupBox2.CustomizableEdges = customizableEdges9;
            guna2GroupBox2.FillColor = Color.FromArgb(227, 213, 202);
            guna2GroupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            guna2GroupBox2.ForeColor = Color.Black;
            guna2GroupBox2.Location = new Point(346, 158);
            guna2GroupBox2.Name = "guna2GroupBox2";
            guna2GroupBox2.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2GroupBox2.Size = new Size(340, 235);
            guna2GroupBox2.TabIndex = 15;
            guna2GroupBox2.Text = "ARQUIVOS PARA EXCLUIR";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 43);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(334, 188);
            dataGridView2.TabIndex = 13;
            // 
            // Grp_FoldersToDelete
            // 
            Grp_FoldersToDelete.BorderColor = Color.FromArgb(198, 172, 143);
            Grp_FoldersToDelete.Controls.Add(dataGridView1);
            Grp_FoldersToDelete.CustomBorderColor = Color.FromArgb(198, 172, 143);
            Grp_FoldersToDelete.CustomizableEdges = customizableEdges11;
            Grp_FoldersToDelete.FillColor = Color.FromArgb(227, 213, 202);
            Grp_FoldersToDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Grp_FoldersToDelete.ForeColor = Color.Black;
            Grp_FoldersToDelete.Location = new Point(0, 158);
            Grp_FoldersToDelete.Name = "Grp_FoldersToDelete";
            Grp_FoldersToDelete.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Grp_FoldersToDelete.Size = new Size(340, 235);
            Grp_FoldersToDelete.TabIndex = 14;
            Grp_FoldersToDelete.Text = "PASTAS PARA EXCLUIR";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(334, 188);
            dataGridView1.TabIndex = 13;
            // 
            // Fbd_Config
            // 
            Fbd_Config.Description = "Escolha a pasta onde estão os arquivos do seu projeto";
            Fbd_Config.UseDescriptionForTitle = true;
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.BorderColor = Color.FromArgb(198, 172, 143);
            guna2GroupBox1.Controls.Add(dataGridView3);
            guna2GroupBox1.CustomBorderColor = Color.FromArgb(198, 172, 143);
            guna2GroupBox1.CustomizableEdges = customizableEdges5;
            guna2GroupBox1.FillColor = Color.FromArgb(227, 213, 202);
            guna2GroupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            guna2GroupBox1.ForeColor = Color.Black;
            guna2GroupBox1.Location = new Point(346, 423);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GroupBox1.Size = new Size(340, 235);
            guna2GroupBox1.TabIndex = 17;
            guna2GroupBox1.Text = "ARQUIVOS PARA EXCLUIR";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(3, 43);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(334, 188);
            dataGridView3.TabIndex = 13;
            // 
            // guna2GroupBox3
            // 
            guna2GroupBox3.BorderColor = Color.FromArgb(198, 172, 143);
            guna2GroupBox3.Controls.Add(dataGridView4);
            guna2GroupBox3.CustomBorderColor = Color.FromArgb(198, 172, 143);
            guna2GroupBox3.CustomizableEdges = customizableEdges7;
            guna2GroupBox3.FillColor = Color.FromArgb(227, 213, 202);
            guna2GroupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            guna2GroupBox3.ForeColor = Color.Black;
            guna2GroupBox3.Location = new Point(0, 423);
            guna2GroupBox3.Name = "guna2GroupBox3";
            guna2GroupBox3.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2GroupBox3.Size = new Size(340, 235);
            guna2GroupBox3.TabIndex = 16;
            guna2GroupBox3.Text = "PASTAS PARA EXCLUIR";
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(3, 43);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(334, 188);
            dataGridView4.TabIndex = 13;
            // 
            // Frm_ConfigUC
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 213, 202);
            Controls.Add(Pnl_ContentConfig);
            Name = "Frm_ConfigUC";
            Size = new Size(989, 721);
            Grp_OutputFile.ResumeLayout(false);
            Grp_OutputFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Grp_TargetFolder.ResumeLayout(false);
            Grp_TargetFolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Pnl_ContentConfig.ResumeLayout(false);
            guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            Grp_FoldersToDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            guna2GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox Txt_OutputFile;
        private TextBox Txt_TargetFolder;
        private CheckBox Chb_AddDateHourToName;
        private CheckBox Chb_SameOutputFolder;
        private Guna.UI2.WinForms.Guna2GroupBox Grp_OutputFile;
        private Guna.UI2.WinForms.Guna2GroupBox Grp_TargetFolder;
        private Panel Pnl_ContentConfig;
        private ComboBox Cmb_Formatos;
        private ReaLTaiizor.Controls.ChatButtonLeft Btn_ExploreFolders;
        private FolderBrowserDialog Fbd_Config;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private DataGridView dataGridView2;
        private BindingSource databaseBindingSource2;
        private Guna.UI2.WinForms.Guna2GroupBox Grp_FoldersToDelete;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private DataGridView dataGridView3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private DataGridView dataGridView4;
    }
}
