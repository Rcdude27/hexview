namespace HexViewer
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miClose = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.nudStartParagraph = new System.Windows.Forms.NumericUpDown();
            this.dgvContent = new System.Windows.Forms.DataGridView();
            this.Paranum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASCII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.lblParagraph = new System.Windows.Forms.Label();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartParagraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(602, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpen,
            this.miClose,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "File";
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(180, 22);
            this.miOpen.Text = "Open";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miClose
            // 
            this.miClose.Name = "miClose";
            this.miClose.Size = new System.Drawing.Size(180, 22);
            this.miClose.Text = "Close";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(180, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // nudStartParagraph
            // 
            this.nudStartParagraph.Enabled = false;
            this.nudStartParagraph.Location = new System.Drawing.Point(74, 29);
            this.nudStartParagraph.Name = "nudStartParagraph";
            this.nudStartParagraph.Size = new System.Drawing.Size(80, 20);
            this.nudStartParagraph.TabIndex = 1;
            this.nudStartParagraph.ValueChanged += new System.EventHandler(this.nudStartParagraph_ValueChanged);
            // 
            // dgvContent
            // 
            this.dgvContent.AllowUserToAddRows = false;
            this.dgvContent.AllowUserToDeleteRows = false;
            this.dgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Paranum,
            this.Hex,
            this.ASCII});
            this.dgvContent.Location = new System.Drawing.Point(13, 55);
            this.dgvContent.Name = "dgvContent";
            this.dgvContent.ReadOnly = true;
            this.dgvContent.RowHeadersVisible = false;
            this.dgvContent.Size = new System.Drawing.Size(574, 150);
            this.dgvContent.TabIndex = 2;
            // 
            // Paranum
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            this.Paranum.DefaultCellStyle = dataGridViewCellStyle10;
            this.Paranum.HeaderText = "Para #";
            this.Paranum.Name = "Paranum";
            this.Paranum.ReadOnly = true;
            this.Paranum.Width = 50;
            // 
            // Hex
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hex.DefaultCellStyle = dataGridViewCellStyle11;
            this.Hex.HeaderText = "Hex";
            this.Hex.Name = "Hex";
            this.Hex.ReadOnly = true;
            this.Hex.Width = 360;
            // 
            // ASCII
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ASCII.DefaultCellStyle = dataGridViewCellStyle12;
            this.ASCII.HeaderText = "ASCII";
            this.ASCII.Name = "ASCII";
            this.ASCII.ReadOnly = true;
            this.ASCII.Width = 160;
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.AddExtension = false;
            this.ofdOpenFile.SupportMultiDottedExtensions = true;
            // 
            // lblParagraph
            // 
            this.lblParagraph.AutoSize = true;
            this.lblParagraph.Location = new System.Drawing.Point(12, 31);
            this.lblParagraph.Name = "lblParagraph";
            this.lblParagraph.Size = new System.Drawing.Size(56, 13);
            this.lblParagraph.TabIndex = 3;
            this.lblParagraph.Text = "Paragraph";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 220);
            this.Controls.Add(this.lblParagraph);
            this.Controls.Add(this.dgvContent);
            this.Controls.Add(this.nudStartParagraph);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "Form1";
            this.Text = "Hex Viewer";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartParagraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miClose;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.NumericUpDown nudStartParagraph;
        private System.Windows.Forms.DataGridView dgvContent;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paranum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASCII;
        private System.Windows.Forms.Label lblParagraph;
    }
}

