namespace MonsterShooter
{
    partial class DrawingAvatar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingAvatar));
            this.panelAvatar = new System.Windows.Forms.Panel();
            this.labelColorDrawing = new System.Windows.Forms.Label();
            this.radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonGray = new System.Windows.Forms.RadioButton();
            this.radioButtonOrange = new System.Windows.Forms.RadioButton();
            this.radioButtonWhite = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonYellow = new System.Windows.Forms.RadioButton();
            this.labelAvatar = new System.Windows.Forms.Label();
            this.buttonSetAvatar = new System.Windows.Forms.Button();
            this.buttonClearPanel = new System.Windows.Forms.Button();
            this.radioButtonTransparentColor = new System.Windows.Forms.RadioButton();
            this.trackBarSizePen = new System.Windows.Forms.TrackBar();
            this.labelSizePen = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxIconAplication = new System.Windows.Forms.PictureBox();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.bunifuImageButtonExit = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizePen)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAvatar
            // 
            this.panelAvatar.BackColor = System.Drawing.Color.White;
            this.panelAvatar.Location = new System.Drawing.Point(33, 77);
            this.panelAvatar.Name = "panelAvatar";
            this.panelAvatar.Size = new System.Drawing.Size(443, 533);
            this.panelAvatar.TabIndex = 0;
            this.panelAvatar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAvatar_MouseDown);
            this.panelAvatar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelAvatar_MouseMove);
            this.panelAvatar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelAvatar_MouseUp);
            // 
            // labelColorDrawing
            // 
            this.labelColorDrawing.AutoSize = true;
            this.labelColorDrawing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelColorDrawing.ForeColor = System.Drawing.Color.White;
            this.labelColorDrawing.Location = new System.Drawing.Point(487, 77);
            this.labelColorDrawing.Name = "labelColorDrawing";
            this.labelColorDrawing.Size = new System.Drawing.Size(173, 25);
            this.labelColorDrawing.TabIndex = 1;
            this.labelColorDrawing.Text = "Kolor rysowania:";
            // 
            // radioButtonBlack
            // 
            this.radioButtonBlack.BackColor = System.Drawing.Color.Black;
            this.radioButtonBlack.Location = new System.Drawing.Point(495, 116);
            this.radioButtonBlack.Name = "radioButtonBlack";
            this.radioButtonBlack.Size = new System.Drawing.Size(100, 25);
            this.radioButtonBlack.TabIndex = 2;
            this.radioButtonBlack.TabStop = true;
            this.radioButtonBlack.UseVisualStyleBackColor = false;
            this.radioButtonBlack.CheckedChanged += new System.EventHandler(this.radioButtonBlack_CheckedChanged);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.BackColor = System.Drawing.Color.Red;
            this.radioButtonRed.Location = new System.Drawing.Point(495, 143);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(100, 25);
            this.radioButtonRed.TabIndex = 3;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.UseVisualStyleBackColor = false;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.BackColor = System.Drawing.Color.Blue;
            this.radioButtonBlue.Location = new System.Drawing.Point(495, 170);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(100, 25);
            this.radioButtonBlue.TabIndex = 4;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.UseVisualStyleBackColor = false;
            this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButtonBlue_CheckedChanged);
            // 
            // radioButtonGray
            // 
            this.radioButtonGray.BackColor = System.Drawing.Color.Silver;
            this.radioButtonGray.Location = new System.Drawing.Point(495, 197);
            this.radioButtonGray.Name = "radioButtonGray";
            this.radioButtonGray.Size = new System.Drawing.Size(100, 25);
            this.radioButtonGray.TabIndex = 5;
            this.radioButtonGray.TabStop = true;
            this.radioButtonGray.UseVisualStyleBackColor = false;
            this.radioButtonGray.CheckedChanged += new System.EventHandler(this.radioButtonGray_CheckedChanged);
            // 
            // radioButtonOrange
            // 
            this.radioButtonOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButtonOrange.Location = new System.Drawing.Point(495, 224);
            this.radioButtonOrange.Name = "radioButtonOrange";
            this.radioButtonOrange.Size = new System.Drawing.Size(100, 25);
            this.radioButtonOrange.TabIndex = 6;
            this.radioButtonOrange.TabStop = true;
            this.radioButtonOrange.UseVisualStyleBackColor = false;
            this.radioButtonOrange.CheckedChanged += new System.EventHandler(this.radioButtonOrange_CheckedChanged);
            // 
            // radioButtonWhite
            // 
            this.radioButtonWhite.BackColor = System.Drawing.Color.White;
            this.radioButtonWhite.Location = new System.Drawing.Point(495, 251);
            this.radioButtonWhite.Name = "radioButtonWhite";
            this.radioButtonWhite.Size = new System.Drawing.Size(100, 25);
            this.radioButtonWhite.TabIndex = 7;
            this.radioButtonWhite.TabStop = true;
            this.radioButtonWhite.UseVisualStyleBackColor = false;
            this.radioButtonWhite.CheckedChanged += new System.EventHandler(this.radioButtonWhite_CheckedChanged);
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.BackColor = System.Drawing.Color.Lime;
            this.radioButtonGreen.Location = new System.Drawing.Point(495, 278);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(100, 25);
            this.radioButtonGreen.TabIndex = 8;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.UseVisualStyleBackColor = false;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
            // 
            // radioButtonYellow
            // 
            this.radioButtonYellow.BackColor = System.Drawing.Color.Yellow;
            this.radioButtonYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonYellow.Location = new System.Drawing.Point(495, 305);
            this.radioButtonYellow.Name = "radioButtonYellow";
            this.radioButtonYellow.Size = new System.Drawing.Size(100, 25);
            this.radioButtonYellow.TabIndex = 9;
            this.radioButtonYellow.TabStop = true;
            this.radioButtonYellow.UseVisualStyleBackColor = false;
            this.radioButtonYellow.CheckedChanged += new System.EventHandler(this.radioButtonYellow_CheckedChanged);
            // 
            // labelAvatar
            // 
            this.labelAvatar.AutoSize = true;
            this.labelAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAvatar.ForeColor = System.Drawing.Color.White;
            this.labelAvatar.Location = new System.Drawing.Point(28, 48);
            this.labelAvatar.Name = "labelAvatar";
            this.labelAvatar.Size = new System.Drawing.Size(82, 25);
            this.labelAvatar.TabIndex = 10;
            this.labelAvatar.Text = "Avatar:";
            // 
            // buttonSetAvatar
            // 
            this.buttonSetAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonSetAvatar.FlatAppearance.BorderSize = 0;
            this.buttonSetAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSetAvatar.ForeColor = System.Drawing.Color.White;
            this.buttonSetAvatar.Location = new System.Drawing.Point(492, 575);
            this.buttonSetAvatar.Name = "buttonSetAvatar";
            this.buttonSetAvatar.Size = new System.Drawing.Size(168, 35);
            this.buttonSetAvatar.TabIndex = 11;
            this.buttonSetAvatar.Text = "Ustaw avatar";
            this.buttonSetAvatar.UseVisualStyleBackColor = false;
            this.buttonSetAvatar.Click += new System.EventHandler(this.buttonSetAvatar_Click);
            // 
            // buttonClearPanel
            // 
            this.buttonClearPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonClearPanel.FlatAppearance.BorderSize = 0;
            this.buttonClearPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClearPanel.ForeColor = System.Drawing.Color.White;
            this.buttonClearPanel.Location = new System.Drawing.Point(492, 534);
            this.buttonClearPanel.Name = "buttonClearPanel";
            this.buttonClearPanel.Size = new System.Drawing.Size(168, 35);
            this.buttonClearPanel.TabIndex = 12;
            this.buttonClearPanel.Text = "Wyczyść okno";
            this.buttonClearPanel.UseVisualStyleBackColor = false;
            this.buttonClearPanel.Click += new System.EventHandler(this.buttonClearPanel_Click);
            // 
            // radioButtonTransparentColor
            // 
            this.radioButtonTransparentColor.AutoSize = true;
            this.radioButtonTransparentColor.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTransparentColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonTransparentColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonTransparentColor.Location = new System.Drawing.Point(495, 332);
            this.radioButtonTransparentColor.Name = "radioButtonTransparentColor";
            this.radioButtonTransparentColor.Size = new System.Drawing.Size(130, 21);
            this.radioButtonTransparentColor.TabIndex = 13;
            this.radioButtonTransparentColor.TabStop = true;
            this.radioButtonTransparentColor.Text = "Przeźroczysty";
            this.radioButtonTransparentColor.UseVisualStyleBackColor = false;
            this.radioButtonTransparentColor.CheckedChanged += new System.EventHandler(this.radioButtonTransparentColor_CheckedChanged);
            // 
            // trackBarSizePen
            // 
            this.trackBarSizePen.Location = new System.Drawing.Point(492, 411);
            this.trackBarSizePen.Maximum = 50;
            this.trackBarSizePen.Minimum = 5;
            this.trackBarSizePen.Name = "trackBarSizePen";
            this.trackBarSizePen.Size = new System.Drawing.Size(168, 56);
            this.trackBarSizePen.SmallChange = 5;
            this.trackBarSizePen.TabIndex = 14;
            this.trackBarSizePen.TickFrequency = 5;
            this.trackBarSizePen.Value = 5;
            this.trackBarSizePen.Scroll += new System.EventHandler(this.trackBarSizePen_Scroll);
            // 
            // labelSizePen
            // 
            this.labelSizePen.AutoSize = true;
            this.labelSizePen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSizePen.ForeColor = System.Drawing.Color.White;
            this.labelSizePen.Location = new System.Drawing.Point(487, 369);
            this.labelSizePen.Name = "labelSizePen";
            this.labelSizePen.Size = new System.Drawing.Size(177, 25);
            this.labelSizePen.TabIndex = 16;
            this.labelSizePen.Text = "Wielkość pędzla:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.panelHeader.Controls.Add(this.pictureBoxIconAplication);
            this.panelHeader.Controls.Add(this.labelTitleForm);
            this.panelHeader.Controls.Add(this.bunifuImageButtonExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(677, 45);
            this.panelHeader.TabIndex = 17;
            // 
            // pictureBoxIconAplication
            // 
            this.pictureBoxIconAplication.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconAplication.Image")));
            this.pictureBoxIconAplication.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxIconAplication.Name = "pictureBoxIconAplication";
            this.pictureBoxIconAplication.Size = new System.Drawing.Size(44, 41);
            this.pictureBoxIconAplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIconAplication.TabIndex = 5;
            this.pictureBoxIconAplication.TabStop = false;
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.AutoSize = true;
            this.labelTitleForm.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitleForm.ForeColor = System.Drawing.Color.White;
            this.labelTitleForm.Location = new System.Drawing.Point(50, 3);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(161, 34);
            this.labelTitleForm.TabIndex = 4;
            this.labelTitleForm.Text = "Rysowanie";
            // 
            // bunifuImageButtonExit
            // 
            this.bunifuImageButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.bunifuImageButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonExit.Image")));
            this.bunifuImageButtonExit.ImageActive = null;
            this.bunifuImageButtonExit.Location = new System.Drawing.Point(617, 1);
            this.bunifuImageButtonExit.Name = "bunifuImageButtonExit";
            this.bunifuImageButtonExit.Size = new System.Drawing.Size(48, 41);
            this.bunifuImageButtonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonExit.TabIndex = 3;
            this.bunifuImageButtonExit.TabStop = false;
            this.bunifuImageButtonExit.Zoom = 10;
            this.bunifuImageButtonExit.Click += new System.EventHandler(this.bunifuImageButtonExit_Click);
            // 
            // DrawingAvatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(178)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(677, 632);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.labelSizePen);
            this.Controls.Add(this.trackBarSizePen);
            this.Controls.Add(this.radioButtonTransparentColor);
            this.Controls.Add(this.buttonClearPanel);
            this.Controls.Add(this.buttonSetAvatar);
            this.Controls.Add(this.labelAvatar);
            this.Controls.Add(this.radioButtonYellow);
            this.Controls.Add(this.radioButtonGreen);
            this.Controls.Add(this.radioButtonWhite);
            this.Controls.Add(this.radioButtonOrange);
            this.Controls.Add(this.radioButtonGray);
            this.Controls.Add(this.radioButtonBlue);
            this.Controls.Add(this.radioButtonRed);
            this.Controls.Add(this.radioButtonBlack);
            this.Controls.Add(this.labelColorDrawing);
            this.Controls.Add(this.panelAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrawingAvatar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DrawingAvatar";
            this.TransparencyKey = System.Drawing.Color.LavenderBlush;
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizePen)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAvatar;
        private System.Windows.Forms.Label labelColorDrawing;
        private System.Windows.Forms.RadioButton radioButtonBlack;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonGray;
        private System.Windows.Forms.RadioButton radioButtonOrange;
        private System.Windows.Forms.RadioButton radioButtonWhite;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonYellow;
        private System.Windows.Forms.Label labelAvatar;
        private System.Windows.Forms.Button buttonSetAvatar;
        private System.Windows.Forms.Button buttonClearPanel;
        private System.Windows.Forms.RadioButton radioButtonTransparentColor;
        private System.Windows.Forms.TrackBar trackBarSizePen;
        private System.Windows.Forms.Label labelSizePen;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxIconAplication;
        private System.Windows.Forms.Label labelTitleForm;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonExit;
    }
}