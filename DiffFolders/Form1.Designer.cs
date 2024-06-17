namespace DiffFolders
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.btFolders = new System.Windows.Forms.Button();
            this.lblfolder1 = new System.Windows.Forms.Label();
            this.lblfolder2 = new System.Windows.Forms.Label();
            this.btVerifyFolders = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.lvlDiffFolders = new System.Windows.Forms.ListView();
            this.col1 = new System.Windows.Forms.ColumnHeader();
            this.lvlDiffFolders2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione as pastas para verificar os arquivos diferentes";
            // 
            // btFolders
            // 
            this.btFolders.Location = new System.Drawing.Point(126, 134);
            this.btFolders.Margin = new System.Windows.Forms.Padding(4);
            this.btFolders.Name = "btFolders";
            this.btFolders.Size = new System.Drawing.Size(267, 41);
            this.btFolders.TabIndex = 1;
            this.btFolders.Text = "Selecionar Pastas";
            this.btFolders.UseVisualStyleBackColor = true;
            this.btFolders.Click += new System.EventHandler(this.btFolders_Click);
            // 
            // lblfolder1
            // 
            this.lblfolder1.AutoSize = true;
            this.lblfolder1.Location = new System.Drawing.Point(29, 195);
            this.lblfolder1.Name = "lblfolder1";
            this.lblfolder1.Size = new System.Drawing.Size(0, 28);
            this.lblfolder1.TabIndex = 2;
            // 
            // lblfolder2
            // 
            this.lblfolder2.AutoSize = true;
            this.lblfolder2.Location = new System.Drawing.Point(29, 245);
            this.lblfolder2.Name = "lblfolder2";
            this.lblfolder2.Size = new System.Drawing.Size(0, 28);
            this.lblfolder2.TabIndex = 3;
            // 
            // btVerifyFolders
            // 
            this.btVerifyFolders.Location = new System.Drawing.Point(29, 302);
            this.btVerifyFolders.Name = "btVerifyFolders";
            this.btVerifyFolders.Size = new System.Drawing.Size(140, 79);
            this.btVerifyFolders.TabIndex = 4;
            this.btVerifyFolders.Text = "Verificar Diferenças";
            this.btVerifyFolders.UseVisualStyleBackColor = true;
            this.btVerifyFolders.Click += new System.EventHandler(this.btVerifyFolders_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(274, 302);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(140, 79);
            this.btClear.TabIndex = 5;
            this.btClear.Text = "Limpar";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // lvlDiffFolders
            // 
            this.lvlDiffFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1});
            this.lvlDiffFolders.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvlDiffFolders.Location = new System.Drawing.Point(477, 88);
            this.lvlDiffFolders.Name = "lvlDiffFolders";
            this.lvlDiffFolders.ShowItemToolTips = true;
            this.lvlDiffFolders.Size = new System.Drawing.Size(286, 499);
            this.lvlDiffFolders.TabIndex = 6;
            this.lvlDiffFolders.UseCompatibleStateImageBehavior = false;
            this.lvlDiffFolders.View = System.Windows.Forms.View.Details;
            // 
            // col1
            // 
            this.col1.Text = "Arquivos e pastas diff pasta 1";
            this.col1.Width = 300;
            // 
            // lvlDiffFolders2
            // 
            this.lvlDiffFolders2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvlDiffFolders2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2,
            listViewItem3});
            this.lvlDiffFolders2.Location = new System.Drawing.Point(782, 88);
            this.lvlDiffFolders2.Name = "lvlDiffFolders2";
            this.lvlDiffFolders2.ShowItemToolTips = true;
            this.lvlDiffFolders2.Size = new System.Drawing.Size(286, 499);
            this.lvlDiffFolders2.TabIndex = 7;
            this.lvlDiffFolders2.UseCompatibleStateImageBehavior = false;
            this.lvlDiffFolders2.View = System.Windows.Forms.View.Details;
            this.lvlDiffFolders2.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvlDiffFolders2_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Arquivos e pastas diff pasta 2";
            this.columnHeader1.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.lvlDiffFolders2);
            this.Controls.Add(this.lvlDiffFolders);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btVerifyFolders);
            this.Controls.Add(this.lblfolder2);
            this.Controls.Add(this.lblfolder1);
            this.Controls.Add(this.btFolders);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btFolders;
        private Label lblfolder1;
        private Label lblfolder2;
        private Button btVerifyFolders;
        private Button btClear;
        private ListView lvlDiffFolders;
        private ColumnHeader col1;
        private ListView lvlDiffFolders2;
        private ColumnHeader columnHeader1;
    }
}