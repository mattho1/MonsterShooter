namespace MonsterShooter
{
    partial class TakePicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakePicture));
            this.pictureBoxCameraImage = new System.Windows.Forms.PictureBox();
            this.comboBoxCamera = new System.Windows.Forms.ComboBox();
            this.labelCamera = new System.Windows.Forms.Label();
            this.buttonTakePicture = new System.Windows.Forms.Button();
            this.pictureBoxTakePicture = new System.Windows.Forms.PictureBox();
            this.labelCameraImage = new System.Windows.Forms.Label();
            this.labelTakePicture = new System.Windows.Forms.Label();
            this.buttonSetAvatar = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxIconAplication = new System.Windows.Forms.PictureBox();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.bunifuImageButtonMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButtonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControlMoveWindow = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCameraImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakePicture)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCameraImage
            // 
            this.pictureBoxCameraImage.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxCameraImage.Location = new System.Drawing.Point(24, 83);
            this.pictureBoxCameraImage.Name = "pictureBoxCameraImage";
            this.pictureBoxCameraImage.Size = new System.Drawing.Size(593, 533);
            this.pictureBoxCameraImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCameraImage.TabIndex = 0;
            this.pictureBoxCameraImage.TabStop = false;
            // 
            // comboBoxCamera
            // 
            this.comboBoxCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxCamera.FormattingEnabled = true;
            this.comboBoxCamera.Location = new System.Drawing.Point(628, 106);
            this.comboBoxCamera.Name = "comboBoxCamera";
            this.comboBoxCamera.Size = new System.Drawing.Size(320, 33);
            this.comboBoxCamera.TabIndex = 1;
            this.comboBoxCamera.SelectedIndexChanged += new System.EventHandler(this.comboBoxCamera_SelectedIndexChanged);
            // 
            // labelCamera
            // 
            this.labelCamera.AutoSize = true;
            this.labelCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCamera.ForeColor = System.Drawing.Color.White;
            this.labelCamera.Location = new System.Drawing.Point(623, 78);
            this.labelCamera.Name = "labelCamera";
            this.labelCamera.Size = new System.Drawing.Size(255, 25);
            this.labelCamera.TabIndex = 2;
            this.labelCamera.Text = "Urządzenie nagrywające:";
            // 
            // buttonTakePicture
            // 
            this.buttonTakePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonTakePicture.FlatAppearance.BorderSize = 0;
            this.buttonTakePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTakePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTakePicture.ForeColor = System.Drawing.Color.White;
            this.buttonTakePicture.Location = new System.Drawing.Point(628, 170);
            this.buttonTakePicture.Name = "buttonTakePicture";
            this.buttonTakePicture.Size = new System.Drawing.Size(320, 40);
            this.buttonTakePicture.TabIndex = 3;
            this.buttonTakePicture.Text = "Zrób zdjęcie";
            this.buttonTakePicture.UseVisualStyleBackColor = false;
            this.buttonTakePicture.Click += new System.EventHandler(this.buttonTakePicture_Click);
            // 
            // pictureBoxTakePicture
            // 
            this.pictureBoxTakePicture.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxTakePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTakePicture.Location = new System.Drawing.Point(628, 289);
            this.pictureBoxTakePicture.Name = "pictureBoxTakePicture";
            this.pictureBoxTakePicture.Size = new System.Drawing.Size(320, 254);
            this.pictureBoxTakePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTakePicture.TabIndex = 4;
            this.pictureBoxTakePicture.TabStop = false;
            // 
            // labelCameraImage
            // 
            this.labelCameraImage.AutoSize = true;
            this.labelCameraImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCameraImage.ForeColor = System.Drawing.Color.White;
            this.labelCameraImage.Location = new System.Drawing.Point(19, 55);
            this.labelCameraImage.Name = "labelCameraImage";
            this.labelCameraImage.Size = new System.Drawing.Size(171, 25);
            this.labelCameraImage.TabIndex = 5;
            this.labelCameraImage.Text = "Obraz z kamery:";
            // 
            // labelTakePicture
            // 
            this.labelTakePicture.AutoSize = true;
            this.labelTakePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTakePicture.ForeColor = System.Drawing.Color.White;
            this.labelTakePicture.Location = new System.Drawing.Point(623, 250);
            this.labelTakePicture.Name = "labelTakePicture";
            this.labelTakePicture.Size = new System.Drawing.Size(178, 25);
            this.labelTakePicture.TabIndex = 6;
            this.labelTakePicture.Text = "Zrobione zdjęcie:";
            // 
            // buttonSetAvatar
            // 
            this.buttonSetAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonSetAvatar.FlatAppearance.BorderSize = 0;
            this.buttonSetAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSetAvatar.ForeColor = System.Drawing.Color.White;
            this.buttonSetAvatar.Location = new System.Drawing.Point(623, 576);
            this.buttonSetAvatar.Name = "buttonSetAvatar";
            this.buttonSetAvatar.Size = new System.Drawing.Size(325, 40);
            this.buttonSetAvatar.TabIndex = 7;
            this.buttonSetAvatar.Text = "Ustaw jako avatar";
            this.buttonSetAvatar.UseVisualStyleBackColor = false;
            this.buttonSetAvatar.Click += new System.EventHandler(this.buttonSetAvatar_Click);
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
            this.panelHeader.Size = new System.Drawing.Size(982, 45);
            this.panelHeader.TabIndex = 8;
            // 
            // pictureBoxIconAplication
            // 
            this.pictureBoxIconAplication.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconAplication.Image")));
            this.pictureBoxIconAplication.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxIconAplication.Name = "pictureBoxIconAplication";
            this.pictureBoxIconAplication.Size = new System.Drawing.Size(44, 41);
            this.pictureBoxIconAplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIconAplication.TabIndex = 11;
            this.pictureBoxIconAplication.TabStop = false;
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.AutoSize = true;
            this.labelTitleForm.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitleForm.ForeColor = System.Drawing.Color.White;
            this.labelTitleForm.Location = new System.Drawing.Point(50, 8);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(244, 34);
            this.labelTitleForm.TabIndex = 10;
            this.labelTitleForm.Text = "Robienie zdjęcia";
            // 
            // bunifuImageButtonMinimize
            // 
            this.bunifuImageButtonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.bunifuImageButtonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonMinimize.Image")));
            this.bunifuImageButtonMinimize.ImageActive = null;
            this.bunifuImageButtonMinimize.Location = new System.Drawing.Point(868, 1);
            this.bunifuImageButtonMinimize.Name = "bunifuImageButtonMinimize";
            this.bunifuImageButtonMinimize.Size = new System.Drawing.Size(48, 41);
            this.bunifuImageButtonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonMinimize.TabIndex = 9;
            this.bunifuImageButtonMinimize.TabStop = false;
            this.bunifuImageButtonMinimize.Zoom = 10;
            this.bunifuImageButtonMinimize.Click += new System.EventHandler(this.bunifuImageButtonMinimize_Click);
            // 
            // bunifuImageButtonExit
            // 
            this.bunifuImageButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.bunifuImageButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonExit.Image")));
            this.bunifuImageButtonExit.ImageActive = null;
            this.bunifuImageButtonExit.Location = new System.Drawing.Point(922, 1);
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
            // TakePicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(178)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(982, 643);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonSetAvatar);
            this.Controls.Add(this.labelTakePicture);
            this.Controls.Add(this.labelCameraImage);
            this.Controls.Add(this.pictureBoxTakePicture);
            this.Controls.Add(this.buttonTakePicture);
            this.Controls.Add(this.labelCamera);
            this.Controls.Add(this.comboBoxCamera);
            this.Controls.Add(this.pictureBoxCameraImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TakePicture";
            this.Text = "TakePicture";
            this.Load += new System.EventHandler(this.TakePicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCameraImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakePicture)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCameraImage;
        private System.Windows.Forms.ComboBox comboBoxCamera;
        private System.Windows.Forms.Label labelCamera;
        private System.Windows.Forms.Button buttonTakePicture;
        private System.Windows.Forms.PictureBox pictureBoxTakePicture;
        private System.Windows.Forms.Label labelCameraImage;
        private System.Windows.Forms.Label labelTakePicture;
        private System.Windows.Forms.Button buttonSetAvatar;
        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonExit;
        private System.Windows.Forms.PictureBox pictureBoxIconAplication;
        private System.Windows.Forms.Label labelTitleForm;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonMinimize;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlMoveWindow;
    }
}