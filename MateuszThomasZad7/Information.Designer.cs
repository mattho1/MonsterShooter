namespace MonsterShooter
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.textBoxInformationaAboutGame = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.pictureBoxIconAplication = new System.Windows.Forms.PictureBox();
            this.bunifuImageButtonMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButtonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControlMoveWindow = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInformationaAboutGame
            // 
            this.textBoxInformationaAboutGame.Enabled = false;
            this.textBoxInformationaAboutGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxInformationaAboutGame.Location = new System.Drawing.Point(23, 63);
            this.textBoxInformationaAboutGame.Multiline = true;
            this.textBoxInformationaAboutGame.Name = "textBoxInformationaAboutGame";
            this.textBoxInformationaAboutGame.Size = new System.Drawing.Size(497, 431);
            this.textBoxInformationaAboutGame.TabIndex = 0;
            this.textBoxInformationaAboutGame.Text = resources.GetString("textBoxInformationaAboutGame.Text");
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.panelHeader.Controls.Add(this.labelTitleForm);
            this.panelHeader.Controls.Add(this.pictureBoxIconAplication);
            this.panelHeader.Controls.Add(this.bunifuImageButtonMinimize);
            this.panelHeader.Controls.Add(this.bunifuImageButtonExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(541, 45);
            this.panelHeader.TabIndex = 1;
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.AutoSize = true;
            this.labelTitleForm.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitleForm.ForeColor = System.Drawing.Color.White;
            this.labelTitleForm.Location = new System.Drawing.Point(53, 7);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(161, 34);
            this.labelTitleForm.TabIndex = 5;
            this.labelTitleForm.Text = "Informacje";
            // 
            // pictureBoxIconAplication
            // 
            this.pictureBoxIconAplication.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconAplication.Image")));
            this.pictureBoxIconAplication.Location = new System.Drawing.Point(3, 1);
            this.pictureBoxIconAplication.Name = "pictureBoxIconAplication";
            this.pictureBoxIconAplication.Size = new System.Drawing.Size(44, 41);
            this.pictureBoxIconAplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIconAplication.TabIndex = 4;
            this.pictureBoxIconAplication.TabStop = false;
            // 
            // bunifuImageButtonMinimize
            // 
            this.bunifuImageButtonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.bunifuImageButtonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonMinimize.Image")));
            this.bunifuImageButtonMinimize.ImageActive = null;
            this.bunifuImageButtonMinimize.Location = new System.Drawing.Point(436, 0);
            this.bunifuImageButtonMinimize.Name = "bunifuImageButtonMinimize";
            this.bunifuImageButtonMinimize.Size = new System.Drawing.Size(48, 41);
            this.bunifuImageButtonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonMinimize.TabIndex = 2;
            this.bunifuImageButtonMinimize.TabStop = false;
            this.bunifuImageButtonMinimize.Zoom = 10;
            this.bunifuImageButtonMinimize.Click += new System.EventHandler(this.bunifuImageButtonMinimize_Click);
            // 
            // bunifuImageButtonExit
            // 
            this.bunifuImageButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.bunifuImageButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonExit.Image")));
            this.bunifuImageButtonExit.ImageActive = null;
            this.bunifuImageButtonExit.Location = new System.Drawing.Point(490, 0);
            this.bunifuImageButtonExit.Name = "bunifuImageButtonExit";
            this.bunifuImageButtonExit.Size = new System.Drawing.Size(48, 41);
            this.bunifuImageButtonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonExit.TabIndex = 1;
            this.bunifuImageButtonExit.TabStop = false;
            this.bunifuImageButtonExit.Zoom = 10;
            this.bunifuImageButtonExit.Click += new System.EventHandler(this.bunifuImageButtonExit_Click);
            // 
            // bunifuDragControlMoveWindow
            // 
            this.bunifuDragControlMoveWindow.Fixed = true;
            this.bunifuDragControlMoveWindow.Horizontal = true;
            this.bunifuDragControlMoveWindow.TargetControl = this.panelHeader;
            this.bunifuDragControlMoveWindow.Vertical = true;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(178)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(541, 539);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.textBoxInformationaAboutGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInformationaAboutGame;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitleForm;
        private System.Windows.Forms.PictureBox pictureBoxIconAplication;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonMinimize;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlMoveWindow;
    }
}