namespace MonsterShooter
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonPlayGame = new System.Windows.Forms.Button();
            this.buttonResults = new System.Windows.Forms.Button();
            this.buttonInformation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxIconAplication = new System.Windows.Forms.PictureBox();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.bunifuImageButtonMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButtonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControlMoveWindow = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlayGame
            // 
            this.buttonPlayGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonPlayGame.FlatAppearance.BorderSize = 0;
            this.buttonPlayGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlayGame.ForeColor = System.Drawing.Color.White;
            this.buttonPlayGame.Location = new System.Drawing.Point(163, 175);
            this.buttonPlayGame.Name = "buttonPlayGame";
            this.buttonPlayGame.Size = new System.Drawing.Size(210, 55);
            this.buttonPlayGame.TabIndex = 0;
            this.buttonPlayGame.Text = "Graj";
            this.buttonPlayGame.UseVisualStyleBackColor = false;
            this.buttonPlayGame.Click += new System.EventHandler(this.buttonPlayGame_Click);
            // 
            // buttonResults
            // 
            this.buttonResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonResults.FlatAppearance.BorderSize = 0;
            this.buttonResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonResults.ForeColor = System.Drawing.Color.White;
            this.buttonResults.Location = new System.Drawing.Point(163, 280);
            this.buttonResults.Name = "buttonResults";
            this.buttonResults.Size = new System.Drawing.Size(210, 60);
            this.buttonResults.TabIndex = 1;
            this.buttonResults.Text = "Wyniki";
            this.buttonResults.UseVisualStyleBackColor = false;
            this.buttonResults.Click += new System.EventHandler(this.buttonResults_Click);
            // 
            // buttonInformation
            // 
            this.buttonInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonInformation.FlatAppearance.BorderSize = 0;
            this.buttonInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInformation.ForeColor = System.Drawing.Color.White;
            this.buttonInformation.Location = new System.Drawing.Point(163, 388);
            this.buttonInformation.Name = "buttonInformation";
            this.buttonInformation.Size = new System.Drawing.Size(210, 58);
            this.buttonInformation.TabIndex = 2;
            this.buttonInformation.Text = "O grze";
            this.buttonInformation.UseVisualStyleBackColor = false;
            this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 0);
            this.label1.Size = new System.Drawing.Size(472, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Komunikat: Ze wzgledu na łączenie się z internetową bazą \r\n                 danyc" +
    "h aplikacja może działać wolniej.";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.panelHeader.Controls.Add(this.pictureBoxIconAplication);
            this.panelHeader.Controls.Add(this.labelTitleForm);
            this.panelHeader.Controls.Add(this.bunifuImageButtonMinimize);
            this.panelHeader.Controls.Add(this.bunifuImageButtonExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(542, 45);
            this.panelHeader.TabIndex = 4;
            // 
            // pictureBoxIconAplication
            // 
            this.pictureBoxIconAplication.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconAplication.Image")));
            this.pictureBoxIconAplication.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIconAplication.Name = "pictureBoxIconAplication";
            this.pictureBoxIconAplication.Size = new System.Drawing.Size(44, 41);
            this.pictureBoxIconAplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIconAplication.TabIndex = 7;
            this.pictureBoxIconAplication.TabStop = false;
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.AutoSize = true;
            this.labelTitleForm.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitleForm.ForeColor = System.Drawing.Color.White;
            this.labelTitleForm.Location = new System.Drawing.Point(50, 7);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(92, 34);
            this.labelTitleForm.TabIndex = 6;
            this.labelTitleForm.Text = "Menu";
            // 
            // bunifuImageButtonMinimize
            // 
            this.bunifuImageButtonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.bunifuImageButtonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonMinimize.Image")));
            this.bunifuImageButtonMinimize.ImageActive = null;
            this.bunifuImageButtonMinimize.Location = new System.Drawing.Point(428, 0);
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
            this.bunifuImageButtonExit.Location = new System.Drawing.Point(482, 0);
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(178)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(542, 571);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInformation);
            this.Controls.Add(this.buttonResults);
            this.Controls.Add(this.buttonPlayGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlayGame;
        private System.Windows.Forms.Button buttonResults;
        private System.Windows.Forms.Button buttonInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxIconAplication;
        private System.Windows.Forms.Label labelTitleForm;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonMinimize;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlMoveWindow;
    }
}