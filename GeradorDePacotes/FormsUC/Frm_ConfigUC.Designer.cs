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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Txt_OutputFile = new TextBox();
            Txt_TargetFolder = new TextBox();
            Chb_AddDateHourToName = new CheckBox();
            Chb_SameOutputFolder = new CheckBox();
            Grp_OutputFile = new Guna.UI2.WinForms.Guna2GroupBox();
            pictureBox2 = new PictureBox();
            Cmb_Formatos = new ComboBox();
            Grp_TargetFolder = new Guna.UI2.WinForms.Guna2GroupBox();
            Btn_ExploreOutputFolder = new ReaLTaiizor.Controls.ChatButtonLeft();
            Txt_OutputFolder = new TextBox();
            pictureBox1 = new PictureBox();
            Btn_ExploreTargetFolder = new ReaLTaiizor.Controls.ChatButtonLeft();
            Pnl_ContentConfig = new Panel();
            Grp_FilesToVerify = new Guna.UI2.WinForms.Guna2GroupBox();
            pictureBox6 = new PictureBox();
            dataGridView3 = new DataGridView();
            Grp_FoldersToVerify = new Guna.UI2.WinForms.Guna2GroupBox();
            pictureBox5 = new PictureBox();
            dataGridView4 = new DataGridView();
            Grp_FilesToDelete = new Guna.UI2.WinForms.Guna2GroupBox();
            pictureBox4 = new PictureBox();
            dataGridView2 = new DataGridView();
            Grp_FoldersToDelete = new Guna.UI2.WinForms.Guna2GroupBox();
            pictureBox3 = new PictureBox();
            dataGridView1 = new DataGridView();
            Fbd_TargetFolder = new FolderBrowserDialog();
            Fbd_OutputFolder = new FolderBrowserDialog();
            Grp_OutputFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Grp_TargetFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Pnl_ContentConfig.SuspendLayout();
            Grp_FilesToVerify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            Grp_FoldersToVerify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            Grp_FilesToDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            Grp_FoldersToDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Txt_OutputFile
            // 
            Txt_OutputFile.AutoCompleteMode = AutoCompleteMode.Suggest;
            Txt_OutputFile.Font = new Font("Segoe UI", 10F);
            Txt_OutputFile.ImeMode = ImeMode.Off;
            Txt_OutputFile.Location = new Point(13, 49);
            Txt_OutputFile.MaxLength = 100;
            Txt_OutputFile.Name = "Txt_OutputFile";
            Txt_OutputFile.PlaceholderText = "Nome Do Seu Arquivo";
            Txt_OutputFile.Size = new Size(316, 30);
            Txt_OutputFile.TabIndex = 1;
            Txt_OutputFile.WordWrap = false;
            Txt_OutputFile.Leave += Txt_OutputFile_Leave;
            // 
            // Txt_TargetFolder
            // 
            Txt_TargetFolder.AllowDrop = true;
            Txt_TargetFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_TargetFolder.Font = new Font("Segoe UI", 10F);
            Txt_TargetFolder.Location = new Point(8, 54);
            Txt_TargetFolder.MaxLength = 255;
            Txt_TargetFolder.Name = "Txt_TargetFolder";
            Txt_TargetFolder.PlaceholderText = "Caminho da pasta ALVO";
            Txt_TargetFolder.Size = new Size(292, 30);
            Txt_TargetFolder.TabIndex = 3;
            Txt_TargetFolder.WordWrap = false;
            Txt_TargetFolder.Leave += Txt_TargetFolder_Leave;
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
            Chb_AddDateHourToName.CheckedChanged += Chb_AddDateHourToName_CheckedChanged;
            // 
            // Chb_SameOutputFolder
            // 
            Chb_SameOutputFolder.AccessibleDescription = "Se esta checkbox for marcada, o nome do arquivo terá o texto digitado mais a data e hora atual no formato ANO-MES-DIA-H-M-S";
            Chb_SameOutputFolder.AutoSize = true;
            Chb_SameOutputFolder.Checked = true;
            Chb_SameOutputFolder.CheckState = CheckState.Checked;
            Chb_SameOutputFolder.Font = new Font("Segoe UI", 9F);
            Chb_SameOutputFolder.Location = new Point(8, 90);
            Chb_SameOutputFolder.Name = "Chb_SameOutputFolder";
            Chb_SameOutputFolder.Size = new Size(188, 24);
            Chb_SameOutputFolder.TabIndex = 10;
            Chb_SameOutputFolder.Text = "Mesma pasta de Saída?";
            Chb_SameOutputFolder.UseVisualStyleBackColor = true;
            Chb_SameOutputFolder.CheckedChanged += Chb_SameOutputFolder_CheckedChanged;
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
            Grp_OutputFile.Location = new Point(0, 9);
            Grp_OutputFile.Name = "Grp_OutputFile";
            Grp_OutputFile.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Grp_OutputFile.Size = new Size(340, 130);
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
            Cmb_Formatos.Location = new Point(249, 88);
            Cmb_Formatos.Name = "Cmb_Formatos";
            Cmb_Formatos.Size = new Size(74, 33);
            Cmb_Formatos.Sorted = true;
            Cmb_Formatos.TabIndex = 10;
            Cmb_Formatos.SelectedIndexChanged += Cmb_Formatos_SelectedIndexChanged;
            // 
            // Grp_TargetFolder
            // 
            Grp_TargetFolder.AllowDrop = true;
            Grp_TargetFolder.BorderColor = Color.FromArgb(198, 172, 143);
            Grp_TargetFolder.Controls.Add(Btn_ExploreOutputFolder);
            Grp_TargetFolder.Controls.Add(Txt_OutputFolder);
            Grp_TargetFolder.Controls.Add(pictureBox1);
            Grp_TargetFolder.Controls.Add(Btn_ExploreTargetFolder);
            Grp_TargetFolder.Controls.Add(Txt_TargetFolder);
            Grp_TargetFolder.Controls.Add(Chb_SameOutputFolder);
            Grp_TargetFolder.CustomBorderColor = Color.FromArgb(198, 172, 143);
            Grp_TargetFolder.CustomizableEdges = customizableEdges3;
            Grp_TargetFolder.FillColor = Color.FromArgb(227, 213, 202);
            Grp_TargetFolder.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Grp_TargetFolder.ForeColor = Color.Black;
            Grp_TargetFolder.Location = new Point(346, 9);
            Grp_TargetFolder.Name = "Grp_TargetFolder";
            Grp_TargetFolder.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Grp_TargetFolder.Size = new Size(340, 130);
            Grp_TargetFolder.TabIndex = 12;
            Grp_TargetFolder.Text = "     NOME DA PASTA ALVO";
            // 
            // Btn_ExploreOutputFolder
            // 
            Btn_ExploreOutputFolder.BackColor = Color.Transparent;
            Btn_ExploreOutputFolder.Font = new Font("Segoe UI", 12F);
            Btn_ExploreOutputFolder.Image = Properties.Resources.abrir_pasta;
            Btn_ExploreOutputFolder.ImageAlign = ContentAlignment.MiddleCenter;
            Btn_ExploreOutputFolder.ImeMode = ImeMode.Off;
            Btn_ExploreOutputFolder.InactiveColorA = Color.FromArgb(251, 251, 251);
            Btn_ExploreOutputFolder.InactiveColorB = Color.FromArgb(225, 225, 225);
            Btn_ExploreOutputFolder.Location = new Point(303, 139);
            Btn_ExploreOutputFolder.Name = "Btn_ExploreOutputFolder";
            Btn_ExploreOutputFolder.PressedColorA = Color.FromArgb(235, 235, 235);
            Btn_ExploreOutputFolder.PressedColorB = Color.FromArgb(223, 223, 223);
            Btn_ExploreOutputFolder.PressedContourColorA = Color.FromArgb(167, 167, 167);
            Btn_ExploreOutputFolder.PressedContourColorB = Color.FromArgb(167, 167, 167);
            Btn_ExploreOutputFolder.Size = new Size(29, 30);
            Btn_ExploreOutputFolder.TabIndex = 18;
            Btn_ExploreOutputFolder.TextAlignment = StringAlignment.Center;
            Btn_ExploreOutputFolder.Visible = false;
            Btn_ExploreOutputFolder.Click += Btn_ExploreOutputFolder_Click;
            // 
            // Txt_OutputFolder
            // 
            Txt_OutputFolder.AllowDrop = true;
            Txt_OutputFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_OutputFolder.Font = new Font("Segoe UI", 10F);
            Txt_OutputFolder.Location = new Point(8, 139);
            Txt_OutputFolder.MaxLength = 255;
            Txt_OutputFolder.Name = "Txt_OutputFolder";
            Txt_OutputFolder.PlaceholderText = "Caminho da pasta de SAÍDA";
            Txt_OutputFolder.Size = new Size(292, 30);
            Txt_OutputFolder.TabIndex = 17;
            Txt_OutputFolder.Visible = false;
            Txt_OutputFolder.WordWrap = false;
            Txt_OutputFolder.Leave += Txt_OutputFolder_Leave;
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
            // Btn_ExploreTargetFolder
            // 
            Btn_ExploreTargetFolder.BackColor = Color.Transparent;
            Btn_ExploreTargetFolder.Font = new Font("Segoe UI", 12F);
            Btn_ExploreTargetFolder.Image = Properties.Resources.abrir_pasta;
            Btn_ExploreTargetFolder.ImageAlign = ContentAlignment.MiddleCenter;
            Btn_ExploreTargetFolder.ImeMode = ImeMode.Off;
            Btn_ExploreTargetFolder.InactiveColorA = Color.FromArgb(251, 251, 251);
            Btn_ExploreTargetFolder.InactiveColorB = Color.FromArgb(225, 225, 225);
            Btn_ExploreTargetFolder.Location = new Point(303, 54);
            Btn_ExploreTargetFolder.Name = "Btn_ExploreTargetFolder";
            Btn_ExploreTargetFolder.PressedColorA = Color.FromArgb(235, 235, 235);
            Btn_ExploreTargetFolder.PressedColorB = Color.FromArgb(223, 223, 223);
            Btn_ExploreTargetFolder.PressedContourColorA = Color.FromArgb(167, 167, 167);
            Btn_ExploreTargetFolder.PressedContourColorB = Color.FromArgb(167, 167, 167);
            Btn_ExploreTargetFolder.Size = new Size(29, 30);
            Btn_ExploreTargetFolder.TabIndex = 16;
            Btn_ExploreTargetFolder.TextAlignment = StringAlignment.Center;
            Btn_ExploreTargetFolder.Click += Btn_ExploreTargetFolders_Click;
            // 
            // Pnl_ContentConfig
            // 
            Pnl_ContentConfig.Controls.Add(Grp_FilesToVerify);
            Pnl_ContentConfig.Controls.Add(Grp_FoldersToVerify);
            Pnl_ContentConfig.Controls.Add(Grp_FilesToDelete);
            Pnl_ContentConfig.Controls.Add(Grp_FoldersToDelete);
            Pnl_ContentConfig.Controls.Add(Grp_OutputFile);
            Pnl_ContentConfig.Controls.Add(Grp_TargetFolder);
            Pnl_ContentConfig.Location = new Point(233, 63);
            Pnl_ContentConfig.Name = "Pnl_ContentConfig";
            Pnl_ContentConfig.Size = new Size(686, 655);
            Pnl_ContentConfig.TabIndex = 13;
            // 
            // Grp_FilesToVerify
            // 
            Grp_FilesToVerify.BorderColor = Color.FromArgb(198, 172, 143);
            Grp_FilesToVerify.Controls.Add(pictureBox6);
            Grp_FilesToVerify.Controls.Add(dataGridView3);
            Grp_FilesToVerify.CustomBorderColor = Color.FromArgb(198, 172, 143);
            Grp_FilesToVerify.CustomizableEdges = customizableEdges5;
            Grp_FilesToVerify.FillColor = Color.FromArgb(227, 213, 202);
            Grp_FilesToVerify.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Grp_FilesToVerify.ForeColor = Color.Black;
            Grp_FilesToVerify.Location = new Point(346, 405);
            Grp_FilesToVerify.Name = "Grp_FilesToVerify";
            Grp_FilesToVerify.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Grp_FilesToVerify.Size = new Size(340, 231);
            Grp_FilesToVerify.TabIndex = 17;
            Grp_FilesToVerify.Text = "      ARQUIVOS PARA VERIFICAR";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(198, 172, 143);
            pictureBox6.Image = Properties.Resources.verificar_arquivo;
            pictureBox6.Location = new Point(3, 7);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
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
            // Grp_FoldersToVerify
            // 
            Grp_FoldersToVerify.BorderColor = Color.FromArgb(198, 172, 143);
            Grp_FoldersToVerify.Controls.Add(pictureBox5);
            Grp_FoldersToVerify.Controls.Add(dataGridView4);
            Grp_FoldersToVerify.CustomBorderColor = Color.FromArgb(198, 172, 143);
            Grp_FoldersToVerify.CustomizableEdges = customizableEdges7;
            Grp_FoldersToVerify.FillColor = Color.FromArgb(227, 213, 202);
            Grp_FoldersToVerify.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Grp_FoldersToVerify.ForeColor = Color.Black;
            Grp_FoldersToVerify.Location = new Point(0, 405);
            Grp_FoldersToVerify.Name = "Grp_FoldersToVerify";
            Grp_FoldersToVerify.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Grp_FoldersToVerify.Size = new Size(340, 231);
            Grp_FoldersToVerify.TabIndex = 16;
            Grp_FoldersToVerify.Text = "      PASTAS PARA VERIFICAR";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(198, 172, 143);
            pictureBox5.Image = Properties.Resources.verificar_pasta;
            pictureBox5.Location = new Point(3, 7);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
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
            // Grp_FilesToDelete
            // 
            Grp_FilesToDelete.BorderColor = Color.FromArgb(198, 172, 143);
            Grp_FilesToDelete.Controls.Add(pictureBox4);
            Grp_FilesToDelete.Controls.Add(dataGridView2);
            Grp_FilesToDelete.CustomBorderColor = Color.FromArgb(198, 172, 143);
            Grp_FilesToDelete.CustomizableEdges = customizableEdges9;
            Grp_FilesToDelete.FillColor = Color.FromArgb(227, 213, 202);
            Grp_FilesToDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Grp_FilesToDelete.ForeColor = Color.Black;
            Grp_FilesToDelete.Location = new Point(346, 156);
            Grp_FilesToDelete.Name = "Grp_FilesToDelete";
            Grp_FilesToDelete.ShadowDecoration.CustomizableEdges = customizableEdges10;
            Grp_FilesToDelete.Size = new Size(340, 231);
            Grp_FilesToDelete.TabIndex = 15;
            Grp_FilesToDelete.Text = "      ARQUIVOS PARA EXCLUIR";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(198, 172, 143);
            pictureBox4.Image = Properties.Resources.excluir_arquivo;
            pictureBox4.Location = new Point(3, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
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
            Grp_FoldersToDelete.Controls.Add(pictureBox3);
            Grp_FoldersToDelete.Controls.Add(dataGridView1);
            Grp_FoldersToDelete.CustomBorderColor = Color.FromArgb(198, 172, 143);
            Grp_FoldersToDelete.CustomizableEdges = customizableEdges11;
            Grp_FoldersToDelete.FillColor = Color.FromArgb(227, 213, 202);
            Grp_FoldersToDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Grp_FoldersToDelete.ForeColor = Color.Black;
            Grp_FoldersToDelete.Location = new Point(0, 156);
            Grp_FoldersToDelete.Name = "Grp_FoldersToDelete";
            Grp_FoldersToDelete.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Grp_FoldersToDelete.Size = new Size(340, 231);
            Grp_FoldersToDelete.TabIndex = 14;
            Grp_FoldersToDelete.Text = "      PASTAS PARA EXCLUIR";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(198, 172, 143);
            pictureBox3.Image = Properties.Resources.excluir_pasta;
            pictureBox3.Location = new Point(3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
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
            // Fbd_TargetFolder
            // 
            Fbd_TargetFolder.Description = "Escolha a pasta onde estão os arquivos do seu projeto";
            Fbd_TargetFolder.UseDescriptionForTitle = true;
            // 
            // Fbd_OutputFolder
            // 
            Fbd_OutputFolder.Description = "Escolha a pasta onde será salvo o pacote";
            Fbd_OutputFolder.UseDescriptionForTitle = true;
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
            Load += Frm_ConfigUC_Load;
            Grp_OutputFile.ResumeLayout(false);
            Grp_OutputFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Grp_TargetFolder.ResumeLayout(false);
            Grp_TargetFolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Pnl_ContentConfig.ResumeLayout(false);
            Grp_FilesToVerify.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            Grp_FoldersToVerify.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            Grp_FilesToDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            Grp_FoldersToDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private ReaLTaiizor.Controls.ChatButtonLeft Btn_ExploreTargetFolder;
        private FolderBrowserDialog Fbd_TargetFolder;
        private Guna.UI2.WinForms.Guna2GroupBox Grp_FilesToDelete;
        private DataGridView dataGridView2;
        private Guna.UI2.WinForms.Guna2GroupBox Grp_FoldersToDelete;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2GroupBox Grp_FilesToVerify;
        private DataGridView dataGridView3;
        private Guna.UI2.WinForms.Guna2GroupBox Grp_FoldersToVerify;
        private DataGridView dataGridView4;
        private ReaLTaiizor.Controls.ChatButtonLeft Btn_ExploreOutputFolder;
        private TextBox Txt_OutputFolder;
        private FolderBrowserDialog Fbd_OutputFolder;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}
