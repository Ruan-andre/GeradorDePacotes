namespace GeradorDePacotes.Forms
{
    partial class Frm_Report
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Report));
            Dt_DeletedFolders = new DataGridView();
            Col_FolderDeletedName = new DataGridViewTextBoxColumn();
            Col_FolderDeletedDate = new DataGridViewTextBoxColumn();
            Col_FolderDeletedId = new DataGridViewTextBoxColumn();
            deletedFoldersBindingSource = new BindingSource(components);
            Lbl_FoldersDeleted = new Label();
            Dt_DeletedFiles = new DataGridView();
            Col_DeletedFileName = new DataGridViewTextBoxColumn();
            Col_FileDateDeleted = new DataGridViewTextBoxColumn();
            Col_FileIdDeleted = new DataGridViewTextBoxColumn();
            deletedFilesBindingSource = new BindingSource(components);
            label1 = new Label();
            Btn_Close = new Button();
            Pnl_Main = new Panel();
            Lbl_MessageAttetion = new Label();
            Lbl_ItemsDeletedCount = new Label();
            Lbl_ItemsAddedCount = new Label();
            Lbl_ElapsedTime = new Label();
            ((System.ComponentModel.ISupportInitialize)Dt_DeletedFolders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deletedFoldersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dt_DeletedFiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deletedFilesBindingSource).BeginInit();
            Pnl_Main.SuspendLayout();
            SuspendLayout();
            // 
            // Dt_DeletedFolders
            // 
            Dt_DeletedFolders.AllowUserToAddRows = false;
            Dt_DeletedFolders.AllowUserToDeleteRows = false;
            Dt_DeletedFolders.AllowUserToOrderColumns = true;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(233, 235, 251);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            Dt_DeletedFolders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            Dt_DeletedFolders.AutoGenerateColumns = false;
            Dt_DeletedFolders.BackgroundColor = SystemColors.Control;
            Dt_DeletedFolders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(111, 125, 230);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            Dt_DeletedFolders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            Dt_DeletedFolders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dt_DeletedFolders.Columns.AddRange(new DataGridViewColumn[] { Col_FolderDeletedName, Col_FolderDeletedDate, Col_FolderDeletedId });
            Dt_DeletedFolders.DataSource = deletedFoldersBindingSource;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Window;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            Dt_DeletedFolders.DefaultCellStyle = dataGridViewCellStyle15;
            Dt_DeletedFolders.EnableHeadersVisualStyles = false;
            Dt_DeletedFolders.GridColor = Color.Black;
            Dt_DeletedFolders.ImeMode = ImeMode.Off;
            Dt_DeletedFolders.Location = new Point(3, 50);
            Dt_DeletedFolders.Name = "Dt_DeletedFolders";
            Dt_DeletedFolders.ReadOnly = true;
            Dt_DeletedFolders.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            Dt_DeletedFolders.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            Dt_DeletedFolders.RowHeadersVisible = false;
            Dt_DeletedFolders.RowHeadersWidth = 100;
            Dt_DeletedFolders.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dt_DeletedFolders.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Dt_DeletedFolders.ScrollBars = ScrollBars.Vertical;
            Dt_DeletedFolders.SelectionMode = DataGridViewSelectionMode.CellSelect;
            Dt_DeletedFolders.Size = new Size(344, 204);
            Dt_DeletedFolders.TabIndex = 46;
            Dt_DeletedFolders.Tag = "PASTAS PARA VERIFICAR";
            // 
            // Col_FolderDeletedName
            // 
            Col_FolderDeletedName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_FolderDeletedName.DataPropertyName = "FolderName";
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            Col_FolderDeletedName.DefaultCellStyle = dataGridViewCellStyle14;
            Col_FolderDeletedName.HeaderText = "Nome";
            Col_FolderDeletedName.MinimumWidth = 6;
            Col_FolderDeletedName.Name = "Col_FolderDeletedName";
            Col_FolderDeletedName.ReadOnly = true;
            // 
            // Col_FolderDeletedDate
            // 
            Col_FolderDeletedDate.DataPropertyName = "DateTime";
            Col_FolderDeletedDate.HeaderText = "Data";
            Col_FolderDeletedDate.MinimumWidth = 6;
            Col_FolderDeletedDate.Name = "Col_FolderDeletedDate";
            Col_FolderDeletedDate.ReadOnly = true;
            Col_FolderDeletedDate.Width = 125;
            // 
            // Col_FolderDeletedId
            // 
            Col_FolderDeletedId.DataPropertyName = "Id";
            Col_FolderDeletedId.HeaderText = "Id";
            Col_FolderDeletedId.MinimumWidth = 6;
            Col_FolderDeletedId.Name = "Col_FolderDeletedId";
            Col_FolderDeletedId.ReadOnly = true;
            Col_FolderDeletedId.Visible = false;
            Col_FolderDeletedId.Width = 125;
            // 
            // deletedFoldersBindingSource
            // 
            deletedFoldersBindingSource.DataSource = typeof(Database.Entities.DeletedFolders);
            // 
            // Lbl_FoldersDeleted
            // 
            Lbl_FoldersDeleted.BackColor = Color.FromArgb(112, 48, 160);
            Lbl_FoldersDeleted.BorderStyle = BorderStyle.FixedSingle;
            Lbl_FoldersDeleted.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Lbl_FoldersDeleted.ForeColor = Color.White;
            Lbl_FoldersDeleted.Location = new Point(3, 0);
            Lbl_FoldersDeleted.Name = "Lbl_FoldersDeleted";
            Lbl_FoldersDeleted.Size = new Size(344, 51);
            Lbl_FoldersDeleted.TabIndex = 45;
            Lbl_FoldersDeleted.Text = "PASTAS EXCLUÍDAS";
            Lbl_FoldersDeleted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Dt_DeletedFiles
            // 
            Dt_DeletedFiles.AllowUserToAddRows = false;
            Dt_DeletedFiles.AllowUserToDeleteRows = false;
            Dt_DeletedFiles.AllowUserToOrderColumns = true;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(233, 235, 251);
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            Dt_DeletedFiles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            Dt_DeletedFiles.AutoGenerateColumns = false;
            Dt_DeletedFiles.BackgroundColor = SystemColors.Control;
            Dt_DeletedFiles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(111, 125, 230);
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = Color.White;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            Dt_DeletedFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            Dt_DeletedFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dt_DeletedFiles.Columns.AddRange(new DataGridViewColumn[] { Col_DeletedFileName, Col_FileDateDeleted, Col_FileIdDeleted });
            Dt_DeletedFiles.DataSource = deletedFilesBindingSource;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = SystemColors.Window;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            Dt_DeletedFiles.DefaultCellStyle = dataGridViewCellStyle20;
            Dt_DeletedFiles.EnableHeadersVisualStyles = false;
            Dt_DeletedFiles.GridColor = Color.Black;
            Dt_DeletedFiles.ImeMode = ImeMode.Off;
            Dt_DeletedFiles.Location = new Point(353, 50);
            Dt_DeletedFiles.Name = "Dt_DeletedFiles";
            Dt_DeletedFiles.ReadOnly = true;
            Dt_DeletedFiles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle21.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle21.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            Dt_DeletedFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            Dt_DeletedFiles.RowHeadersVisible = false;
            Dt_DeletedFiles.RowHeadersWidth = 100;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            Dt_DeletedFiles.RowsDefaultCellStyle = dataGridViewCellStyle22;
            Dt_DeletedFiles.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dt_DeletedFiles.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Dt_DeletedFiles.ScrollBars = ScrollBars.Vertical;
            Dt_DeletedFiles.SelectionMode = DataGridViewSelectionMode.CellSelect;
            Dt_DeletedFiles.Size = new Size(344, 204);
            Dt_DeletedFiles.TabIndex = 48;
            Dt_DeletedFiles.Tag = "PASTAS PARA VERIFICAR";
            // 
            // Col_DeletedFileName
            // 
            Col_DeletedFileName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_DeletedFileName.DataPropertyName = "FileName";
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            Col_DeletedFileName.DefaultCellStyle = dataGridViewCellStyle19;
            Col_DeletedFileName.HeaderText = "Nome";
            Col_DeletedFileName.MinimumWidth = 6;
            Col_DeletedFileName.Name = "Col_DeletedFileName";
            Col_DeletedFileName.ReadOnly = true;
            // 
            // Col_FileDateDeleted
            // 
            Col_FileDateDeleted.DataPropertyName = "DateTime";
            Col_FileDateDeleted.HeaderText = "Data";
            Col_FileDateDeleted.MinimumWidth = 6;
            Col_FileDateDeleted.Name = "Col_FileDateDeleted";
            Col_FileDateDeleted.ReadOnly = true;
            Col_FileDateDeleted.Width = 125;
            // 
            // Col_FileIdDeleted
            // 
            Col_FileIdDeleted.DataPropertyName = "Id";
            Col_FileIdDeleted.HeaderText = "Id";
            Col_FileIdDeleted.MinimumWidth = 6;
            Col_FileIdDeleted.Name = "Col_FileIdDeleted";
            Col_FileIdDeleted.ReadOnly = true;
            Col_FileIdDeleted.Visible = false;
            Col_FileIdDeleted.Width = 125;
            // 
            // deletedFilesBindingSource
            // 
            deletedFilesBindingSource.DataSource = typeof(Database.Entities.DeletedFiles);
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(112, 48, 160);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(353, 0);
            label1.Name = "label1";
            label1.Size = new Size(344, 51);
            label1.TabIndex = 47;
            label1.Text = "ARQUIVOS EXCLUÍDOS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Btn_Close
            // 
            Btn_Close.BackColor = Color.FromArgb(196, 43, 28);
            Btn_Close.FlatStyle = FlatStyle.Popup;
            Btn_Close.ForeColor = Color.White;
            Btn_Close.Location = new Point(281, 369);
            Btn_Close.Name = "Btn_Close";
            Btn_Close.Size = new Size(94, 29);
            Btn_Close.TabIndex = 49;
            Btn_Close.Text = "FECHAR";
            Btn_Close.UseVisualStyleBackColor = false;
            Btn_Close.Click += Btn_Close_Click;
            // 
            // Pnl_Main
            // 
            Pnl_Main.Controls.Add(Lbl_ElapsedTime);
            Pnl_Main.Controls.Add(Lbl_MessageAttetion);
            Pnl_Main.Controls.Add(Lbl_ItemsDeletedCount);
            Pnl_Main.Controls.Add(Lbl_ItemsAddedCount);
            Pnl_Main.Controls.Add(Lbl_FoldersDeleted);
            Pnl_Main.Controls.Add(Btn_Close);
            Pnl_Main.Controls.Add(Dt_DeletedFolders);
            Pnl_Main.Controls.Add(Dt_DeletedFiles);
            Pnl_Main.Controls.Add(label1);
            Pnl_Main.Location = new Point(43, 37);
            Pnl_Main.Name = "Pnl_Main";
            Pnl_Main.Size = new Size(700, 401);
            Pnl_Main.TabIndex = 50;
            // 
            // Lbl_MessageAttetion
            // 
            Lbl_MessageAttetion.AutoSize = true;
            Lbl_MessageAttetion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Lbl_MessageAttetion.ForeColor = Color.Orange;
            Lbl_MessageAttetion.Location = new Point(63, 346);
            Lbl_MessageAttetion.Name = "Lbl_MessageAttetion";
            Lbl_MessageAttetion.Size = new Size(567, 20);
            Lbl_MessageAttetion.TabIndex = 52;
            Lbl_MessageAttetion.Text = "Verifique se o pacote está correto, caso os dados acima não sejam os esperados.";
            // 
            // Lbl_ItemsDeletedCount
            // 
            Lbl_ItemsDeletedCount.AutoSize = true;
            Lbl_ItemsDeletedCount.Location = new Point(3, 292);
            Lbl_ItemsDeletedCount.Name = "Lbl_ItemsDeletedCount";
            Lbl_ItemsDeletedCount.Size = new Size(171, 20);
            Lbl_ItemsDeletedCount.TabIndex = 51;
            Lbl_ItemsDeletedCount.Text = "Total de itens excluídos: ";
            // 
            // Lbl_ItemsAddedCount
            // 
            Lbl_ItemsAddedCount.AutoSize = true;
            Lbl_ItemsAddedCount.Location = new Point(3, 319);
            Lbl_ItemsAddedCount.Name = "Lbl_ItemsAddedCount";
            Lbl_ItemsAddedCount.Size = new Size(190, 20);
            Lbl_ItemsAddedCount.TabIndex = 50;
            Lbl_ItemsAddedCount.Text = "Total de itens adicionados: ";
            // 
            // Lbl_ElapsedTime
            // 
            Lbl_ElapsedTime.AutoSize = true;
            Lbl_ElapsedTime.Location = new Point(3, 266);
            Lbl_ElapsedTime.Name = "Lbl_ElapsedTime";
            Lbl_ElapsedTime.Size = new Size(131, 20);
            Lbl_ElapsedTime.TabIndex = 53;
            Lbl_ElapsedTime.Text = "Tempo decorrido: ";
            // 
            // Frm_Report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(Pnl_Main);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Report";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Frm_Report";
            Load += Frm_Report_Load;
            ((System.ComponentModel.ISupportInitialize)Dt_DeletedFolders).EndInit();
            ((System.ComponentModel.ISupportInitialize)deletedFoldersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dt_DeletedFiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)deletedFilesBindingSource).EndInit();
            Pnl_Main.ResumeLayout(false);
            Pnl_Main.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView Dt_DeletedFolders;
        private Label Lbl_FoldersDeleted;
        private DataGridView Dt_DeletedFiles;
        private Label label1;
        private Button Btn_Close;
        private Panel Pnl_Main;
        private Label Lbl_MessageAttetion;
        private Label label3;
        private Label label2;
        private BindingSource deletedFoldersBindingSource;
        private DataGridViewTextBoxColumn Col_FileNameDeleted;
        private BindingSource deletedFilesBindingSource;
        private DataGridViewTextBoxColumn Col_FolderDeletedName;
        private DataGridViewTextBoxColumn Col_FolderDeletedDate;
        private DataGridViewTextBoxColumn Col_FolderDeletedId;
        private DataGridViewTextBoxColumn Col_DeletedFileName;
        private DataGridViewTextBoxColumn Col_FileDateDeleted;
        private DataGridViewTextBoxColumn Col_FileIdDeleted;
        private Label Lbl_ItemsDeletedCount;
        private Label Lbl_ItemsAddedCount;
        private Label Lbl_ElapsedTime;
    }
}