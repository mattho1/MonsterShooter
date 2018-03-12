namespace MonsterShooter
{
    partial class Result
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.labelBestResult = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelNameBestPlayer = new System.Windows.Forms.Label();
            this.buttonRemoveAllResults = new System.Windows.Forms.Button();
            this.labelSaveResult = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.buttonSaveResult = new System.Windows.Forms.Button();
            this.labelLoadResult = new System.Windows.Forms.Label();
            this.labelFileWithResult = new System.Windows.Forms.Label();
            this.textBoxFileWithResult = new System.Windows.Forms.TextBox();
            this.buttonLoadResult = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxIconAplication = new System.Windows.Forms.PictureBox();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.bunifuImageButtonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButtonMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControlMoveWindow = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.labelStatement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewResults.Location = new System.Drawing.Point(0, 145);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RowTemplate.Height = 24;
            this.dataGridViewResults.Size = new System.Drawing.Size(893, 430);
            this.dataGridViewResults.TabIndex = 0;
            // 
            // labelBestResult
            // 
            this.labelBestResult.AutoSize = true;
            this.labelBestResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBestResult.ForeColor = System.Drawing.Color.White;
            this.labelBestResult.Location = new System.Drawing.Point(8, 97);
            this.labelBestResult.Name = "labelBestResult";
            this.labelBestResult.Size = new System.Drawing.Size(253, 36);
            this.labelBestResult.TabIndex = 1;
            this.labelBestResult.Text = "Najlepszy wynik:";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoints.ForeColor = System.Drawing.Color.White;
            this.labelPoints.Location = new System.Drawing.Point(295, 97);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(77, 36);
            this.labelPoints.TabIndex = 3;
            this.labelPoints.Text = "brak";
            // 
            // labelNameBestPlayer
            // 
            this.labelNameBestPlayer.AutoSize = true;
            this.labelNameBestPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameBestPlayer.ForeColor = System.Drawing.Color.White;
            this.labelNameBestPlayer.Location = new System.Drawing.Point(498, 97);
            this.labelNameBestPlayer.Name = "labelNameBestPlayer";
            this.labelNameBestPlayer.Size = new System.Drawing.Size(77, 36);
            this.labelNameBestPlayer.TabIndex = 4;
            this.labelNameBestPlayer.Text = "brak";
            // 
            // buttonRemoveAllResults
            // 
            this.buttonRemoveAllResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonRemoveAllResults.FlatAppearance.BorderSize = 0;
            this.buttonRemoveAllResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveAllResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRemoveAllResults.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveAllResults.Location = new System.Drawing.Point(301, 581);
            this.buttonRemoveAllResults.Name = "buttonRemoveAllResults";
            this.buttonRemoveAllResults.Size = new System.Drawing.Size(262, 42);
            this.buttonRemoveAllResults.TabIndex = 5;
            this.buttonRemoveAllResults.Text = "Usuń wyniki z serwera";
            this.buttonRemoveAllResults.UseVisualStyleBackColor = false;
            this.buttonRemoveAllResults.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSaveResult
            // 
            this.labelSaveResult.AutoSize = true;
            this.labelSaveResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSaveResult.ForeColor = System.Drawing.Color.White;
            this.labelSaveResult.Location = new System.Drawing.Point(8, 652);
            this.labelSaveResult.Name = "labelSaveResult";
            this.labelSaveResult.Size = new System.Drawing.Size(261, 25);
            this.labelSaveResult.TabIndex = 6;
            this.labelSaveResult.Text = "Zapisz wyniki do pliku csv";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFileName.Location = new System.Drawing.Point(165, 687);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(146, 30);
            this.textBoxFileName.TabIndex = 7;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFileName.ForeColor = System.Drawing.Color.White;
            this.labelFileName.Location = new System.Drawing.Point(8, 687);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(135, 25);
            this.labelFileName.TabIndex = 8;
            this.labelFileName.Text = "Nazwa pliku:";
            // 
            // buttonSaveResult
            // 
            this.buttonSaveResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonSaveResult.FlatAppearance.BorderSize = 0;
            this.buttonSaveResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveResult.ForeColor = System.Drawing.Color.White;
            this.buttonSaveResult.Location = new System.Drawing.Point(317, 687);
            this.buttonSaveResult.Name = "buttonSaveResult";
            this.buttonSaveResult.Size = new System.Drawing.Size(102, 30);
            this.buttonSaveResult.TabIndex = 9;
            this.buttonSaveResult.Text = "Zapisz";
            this.buttonSaveResult.UseVisualStyleBackColor = false;
            this.buttonSaveResult.Click += new System.EventHandler(this.buttonSaveResult_Click);
            // 
            // labelLoadResult
            // 
            this.labelLoadResult.AutoSize = true;
            this.labelLoadResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoadResult.ForeColor = System.Drawing.Color.White;
            this.labelLoadResult.Location = new System.Drawing.Point(471, 652);
            this.labelLoadResult.Name = "labelLoadResult";
            this.labelLoadResult.Size = new System.Drawing.Size(222, 25);
            this.labelLoadResult.TabIndex = 10;
            this.labelLoadResult.Text = "Wczytaj wyniki z pliku";
            // 
            // labelFileWithResult
            // 
            this.labelFileWithResult.AutoSize = true;
            this.labelFileWithResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFileWithResult.ForeColor = System.Drawing.Color.White;
            this.labelFileWithResult.Location = new System.Drawing.Point(471, 690);
            this.labelFileWithResult.Name = "labelFileWithResult";
            this.labelFileWithResult.Size = new System.Drawing.Size(135, 25);
            this.labelFileWithResult.TabIndex = 11;
            this.labelFileWithResult.Text = "Nazwa pliku:";
            // 
            // textBoxFileWithResult
            // 
            this.textBoxFileWithResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFileWithResult.Location = new System.Drawing.Point(631, 687);
            this.textBoxFileWithResult.Name = "textBoxFileWithResult";
            this.textBoxFileWithResult.Size = new System.Drawing.Size(146, 30);
            this.textBoxFileWithResult.TabIndex = 12;
            // 
            // buttonLoadResult
            // 
            this.buttonLoadResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonLoadResult.FlatAppearance.BorderSize = 0;
            this.buttonLoadResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLoadResult.ForeColor = System.Drawing.Color.White;
            this.buttonLoadResult.Location = new System.Drawing.Point(783, 687);
            this.buttonLoadResult.Name = "buttonLoadResult";
            this.buttonLoadResult.Size = new System.Drawing.Size(98, 30);
            this.buttonLoadResult.TabIndex = 13;
            this.buttonLoadResult.Text = "Wczytaj";
            this.buttonLoadResult.UseVisualStyleBackColor = false;
            this.buttonLoadResult.Click += new System.EventHandler(this.buttonLoadResult_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.panelHeader.Controls.Add(this.pictureBoxIconAplication);
            this.panelHeader.Controls.Add(this.labelTitleForm);
            this.panelHeader.Controls.Add(this.bunifuImageButtonExit);
            this.panelHeader.Controls.Add(this.bunifuImageButtonMinimize);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(893, 45);
            this.panelHeader.TabIndex = 14;
            // 
            // pictureBoxIconAplication
            // 
            this.pictureBoxIconAplication.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconAplication.Image")));
            this.pictureBoxIconAplication.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxIconAplication.Name = "pictureBoxIconAplication";
            this.pictureBoxIconAplication.Size = new System.Drawing.Size(44, 41);
            this.pictureBoxIconAplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIconAplication.TabIndex = 15;
            this.pictureBoxIconAplication.TabStop = false;
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.AutoSize = true;
            this.labelTitleForm.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitleForm.ForeColor = System.Drawing.Color.White;
            this.labelTitleForm.Location = new System.Drawing.Point(53, 7);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(102, 34);
            this.labelTitleForm.TabIndex = 16;
            this.labelTitleForm.Text = "Wyniki";
            // 
            // bunifuImageButtonExit
            // 
            this.bunifuImageButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.bunifuImageButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonExit.Image")));
            this.bunifuImageButtonExit.ImageActive = null;
            this.bunifuImageButtonExit.Location = new System.Drawing.Point(833, 0);
            this.bunifuImageButtonExit.Name = "bunifuImageButtonExit";
            this.bunifuImageButtonExit.Size = new System.Drawing.Size(48, 41);
            this.bunifuImageButtonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonExit.TabIndex = 15;
            this.bunifuImageButtonExit.TabStop = false;
            this.bunifuImageButtonExit.Zoom = 10;
            this.bunifuImageButtonExit.Click += new System.EventHandler(this.bunifuImageButtonExit_Click);
            // 
            // bunifuImageButtonMinimize
            // 
            this.bunifuImageButtonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.bunifuImageButtonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonMinimize.Image")));
            this.bunifuImageButtonMinimize.ImageActive = null;
            this.bunifuImageButtonMinimize.Location = new System.Drawing.Point(779, 0);
            this.bunifuImageButtonMinimize.Name = "bunifuImageButtonMinimize";
            this.bunifuImageButtonMinimize.Size = new System.Drawing.Size(48, 41);
            this.bunifuImageButtonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonMinimize.TabIndex = 2;
            this.bunifuImageButtonMinimize.TabStop = false;
            this.bunifuImageButtonMinimize.Zoom = 10;
            this.bunifuImageButtonMinimize.Click += new System.EventHandler(this.bunifuImageButtonMinimize_Click);
            // 
            // bunifuDragControlMoveWindow
            // 
            this.bunifuDragControlMoveWindow.Fixed = true;
            this.bunifuDragControlMoveWindow.Horizontal = true;
            this.bunifuDragControlMoveWindow.TargetControl = this.panelHeader;
            this.bunifuDragControlMoveWindow.Vertical = true;
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonLoadData.FlatAppearance.BorderSize = 0;
            this.buttonLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLoadData.ForeColor = System.Drawing.Color.White;
            this.buttonLoadData.Location = new System.Drawing.Point(13, 53);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(278, 41);
            this.buttonLoadData.TabIndex = 15;
            this.buttonLoadData.Text = "Załaduj wyniki";
            this.buttonLoadData.UseVisualStyleBackColor = false;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // labelStatement
            // 
            this.labelStatement.BackColor = System.Drawing.Color.White;
            this.labelStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatement.ForeColor = System.Drawing.Color.Black;
            this.labelStatement.Location = new System.Drawing.Point(395, 53);
            this.labelStatement.Name = "labelStatement";
            this.labelStatement.Padding = new System.Windows.Forms.Padding(10, 2, 0, 0);
            this.labelStatement.Size = new System.Drawing.Size(472, 41);
            this.labelStatement.TabIndex = 16;
            this.labelStatement.Text = "Komunikat: Ładowanie danych. Aplikacja zostanie zatrzymana do momentu załadowania" +
    " danych.\r\n";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(178)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(893, 729);
            this.Controls.Add(this.labelStatement);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonLoadResult);
            this.Controls.Add(this.textBoxFileWithResult);
            this.Controls.Add(this.labelFileWithResult);
            this.Controls.Add(this.labelLoadResult);
            this.Controls.Add(this.buttonSaveResult);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.labelSaveResult);
            this.Controls.Add(this.buttonRemoveAllResults);
            this.Controls.Add(this.labelNameBestPlayer);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelBestResult);
            this.Controls.Add(this.dataGridViewResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Label labelBestResult;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelNameBestPlayer;
        private System.Windows.Forms.Button buttonRemoveAllResults;
        private System.Windows.Forms.Label labelSaveResult;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button buttonSaveResult;
        private System.Windows.Forms.Label labelLoadResult;
        private System.Windows.Forms.Label labelFileWithResult;
        private System.Windows.Forms.TextBox textBoxFileWithResult;
        private System.Windows.Forms.Button buttonLoadResult;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitleForm;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonExit;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonMinimize;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlMoveWindow;
        private System.Windows.Forms.PictureBox pictureBoxIconAplication;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Label labelStatement;
    }
}