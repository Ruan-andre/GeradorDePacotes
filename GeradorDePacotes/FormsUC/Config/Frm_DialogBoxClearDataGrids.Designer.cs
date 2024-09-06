namespace GeradorDePacotes.FormsUC.Config
{
    partial class Frm_DialogBoxClearDataGrids
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DialogBoxClearDataGrids));
            Lbl_DtName = new ReaLTaiizor.Controls.BigLabel();
            Btn_ClearCurrentDt = new Button();
            Btn_NextDt = new Button();
            Btn_ClearAllDt = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Btn_PreviousDt = new Button();
            Lbl_Message = new Label();
            Pnl_Labels = new Panel();
            flowLayoutPanel1.SuspendLayout();
            Pnl_Labels.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_DtName
            // 
            Lbl_DtName.AutoSize = true;
            Lbl_DtName.BackColor = Color.Transparent;
            Lbl_DtName.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_DtName.ForeColor = Color.FromArgb(80, 80, 80);
            Lbl_DtName.Location = new Point(3, 12);
            Lbl_DtName.Name = "Lbl_DtName";
            Lbl_DtName.Size = new Size(395, 50);
            Lbl_DtName.TabIndex = 0;
            Lbl_DtName.Text = "PASTAS PARA DELETAR";
            // 
            // Btn_ClearCurrentDt
            // 
            Btn_ClearCurrentDt.BackColor = Color.FromArgb(33, 136, 56);
            Btn_ClearCurrentDt.Cursor = Cursors.Hand;
            Btn_ClearCurrentDt.FlatStyle = FlatStyle.Flat;
            Btn_ClearCurrentDt.ForeColor = Color.White;
            Btn_ClearCurrentDt.Location = new Point(110, 3);
            Btn_ClearCurrentDt.Margin = new Padding(3, 3, 10, 3);
            Btn_ClearCurrentDt.Name = "Btn_ClearCurrentDt";
            Btn_ClearCurrentDt.Size = new Size(123, 29);
            Btn_ClearCurrentDt.TabIndex = 1;
            Btn_ClearCurrentDt.Text = "Limpar tabela";
            Btn_ClearCurrentDt.UseVisualStyleBackColor = false;
            Btn_ClearCurrentDt.Click += Btn_ClearCurrentDt_Click;
            // 
            // Btn_NextDt
            // 
            Btn_NextDt.BackColor = Color.FromArgb(85, 155, 229);
            Btn_NextDt.Cursor = Cursors.Hand;
            Btn_NextDt.FlatAppearance.BorderSize = 0;
            Btn_NextDt.FlatStyle = FlatStyle.Flat;
            Btn_NextDt.ForeColor = SystemColors.ButtonHighlight;
            Btn_NextDt.Location = new Point(384, 3);
            Btn_NextDt.Name = "Btn_NextDt";
            Btn_NextDt.Size = new Size(94, 29);
            Btn_NextDt.TabIndex = 2;
            Btn_NextDt.Tag = "next";
            Btn_NextDt.Text = "Próxima";
            Btn_NextDt.UseVisualStyleBackColor = false;
            Btn_NextDt.Click += Btn_PreviousOrNextDt_Click;
            // 
            // Btn_ClearAllDt
            // 
            Btn_ClearAllDt.BackColor = Color.FromArgb(200, 35, 51);
            Btn_ClearAllDt.Cursor = Cursors.Hand;
            Btn_ClearAllDt.FlatStyle = FlatStyle.Flat;
            Btn_ClearAllDt.ForeColor = Color.White;
            Btn_ClearAllDt.Location = new Point(246, 3);
            Btn_ClearAllDt.Name = "Btn_ClearAllDt";
            Btn_ClearAllDt.Size = new Size(132, 29);
            Btn_ClearAllDt.TabIndex = 3;
            Btn_ClearAllDt.Text = "Limpar todas";
            Btn_ClearAllDt.UseVisualStyleBackColor = false;
            Btn_ClearAllDt.Click += Btn_ClearAllDt_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Btn_PreviousDt);
            flowLayoutPanel1.Controls.Add(Btn_ClearCurrentDt);
            flowLayoutPanel1.Controls.Add(Btn_ClearAllDt);
            flowLayoutPanel1.Controls.Add(Btn_NextDt);
            flowLayoutPanel1.Location = new Point(0, 120);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(481, 34);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // Btn_PreviousDt
            // 
            Btn_PreviousDt.BackColor = Color.DarkGray;
            Btn_PreviousDt.Cursor = Cursors.Hand;
            Btn_PreviousDt.Enabled = false;
            Btn_PreviousDt.FlatAppearance.BorderSize = 0;
            Btn_PreviousDt.FlatStyle = FlatStyle.Flat;
            Btn_PreviousDt.ForeColor = Color.Black;
            Btn_PreviousDt.Location = new Point(3, 3);
            Btn_PreviousDt.Margin = new Padding(3, 3, 10, 3);
            Btn_PreviousDt.Name = "Btn_PreviousDt";
            Btn_PreviousDt.Size = new Size(94, 29);
            Btn_PreviousDt.TabIndex = 4;
            Btn_PreviousDt.Tag = "previous";
            Btn_PreviousDt.Text = "Anterior";
            Btn_PreviousDt.UseVisualStyleBackColor = false;
            Btn_PreviousDt.Click += Btn_PreviousOrNextDt_Click;
            // 
            // Lbl_Message
            // 
            Lbl_Message.AutoSize = true;
            Lbl_Message.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Message.ForeColor = Color.FromArgb(33, 136, 56);
            Lbl_Message.Location = new Point(13, 62);
            Lbl_Message.Name = "Lbl_Message";
            Lbl_Message.Size = new Size(211, 23);
            Lbl_Message.TabIndex = 5;
            Lbl_Message.Text = "Tabela limpa com sucesso!";
            Lbl_Message.Visible = false;
            // 
            // Pnl_Labels
            // 
            Pnl_Labels.Controls.Add(Lbl_DtName);
            Pnl_Labels.Controls.Add(flowLayoutPanel1);
            Pnl_Labels.Controls.Add(Lbl_Message);
            Pnl_Labels.Location = new Point(35, 12);
            Pnl_Labels.Name = "Pnl_Labels";
            Pnl_Labels.Size = new Size(483, 157);
            Pnl_Labels.TabIndex = 6;
            // 
            // Frm_DialogBoxClearDataGrids
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 193);
            Controls.Add(Pnl_Labels);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_DialogBoxClearDataGrids";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Deseja limpar a tabela abaixo?";
            FormClosing += Frm_DialogBoxClearDataGrids_FormClosing;
            Load += Frm_DialogBoxClearDataGrids_Load;
            flowLayoutPanel1.ResumeLayout(false);
            Pnl_Labels.ResumeLayout(false);
            Pnl_Labels.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel Lbl_DtName;
        private Button Btn_ClearCurrentDt;
        private Button Btn_NextDt;
        private Button Btn_ClearAllDt;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label Lbl_Message;
        private Panel Pnl_Labels;
        private Button Btn_PreviousDt;
    }
}