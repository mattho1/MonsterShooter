namespace MonsterShooter
{
    partial class PropertiesPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertiesPlayer));
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.comboBoxPlayerNames = new System.Windows.Forms.ComboBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelAvatar = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonTakePicture = new System.Windows.Forms.Button();
            this.buttonDefaultPicture = new System.Windows.Forms.Button();
            this.buttonPainting = new System.Windows.Forms.Button();
            this.groupBoxPropertiesPlayer = new System.Windows.Forms.GroupBox();
            this.buttonLoadPlayerNames = new System.Windows.Forms.Button();
            this.labelEarlierAvatar = new System.Windows.Forms.Label();
            this.comboBoxPictureName = new System.Windows.Forms.ComboBox();
            this.labelMap = new System.Windows.Forms.Label();
            this.labelMonster = new System.Windows.Forms.Label();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.pictureBoxMonster = new System.Windows.Forms.PictureBox();
            this.comboBoxMonsters = new System.Windows.Forms.ComboBox();
            this.comboBoxMaps = new System.Windows.Forms.ComboBox();
            this.imageListMonsters = new System.Windows.Forms.ImageList(this.components);
            this.imageListMaps = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxPropertiesGame = new System.Windows.Forms.GroupBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxIconAplication = new System.Windows.Forms.PictureBox();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.bunifuImageButtonMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButtonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControlMoveWindow = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.groupBoxPropertiesPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster)).BeginInit();
            this.groupBoxPropertiesGame.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.BackColor = System.Drawing.Color.White;
            this.pictureBoxAvatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar.InitialImage")));
            this.pictureBoxAvatar.Location = new System.Drawing.Point(18, 51);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(447, 465);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 0;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // comboBoxPlayerNames
            // 
            this.comboBoxPlayerNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPlayerNames.FormattingEnabled = true;
            this.comboBoxPlayerNames.Location = new System.Drawing.Point(17, 637);
            this.comboBoxPlayerNames.Name = "comboBoxPlayerNames";
            this.comboBoxPlayerNames.Size = new System.Drawing.Size(448, 33);
            this.comboBoxPlayerNames.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.Location = new System.Drawing.Point(12, 609);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(72, 25);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Login:";
            // 
            // labelAvatar
            // 
            this.labelAvatar.AutoSize = true;
            this.labelAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAvatar.ForeColor = System.Drawing.Color.White;
            this.labelAvatar.Location = new System.Drawing.Point(13, 22);
            this.labelAvatar.Name = "labelAvatar";
            this.labelAvatar.Size = new System.Drawing.Size(82, 25);
            this.labelAvatar.TabIndex = 3;
            this.labelAvatar.Text = "Avatar:";
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.White;
            this.buttonPlay.Location = new System.Drawing.Point(328, 803);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(447, 95);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.Text = "Graj";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonTakePicture
            // 
            this.buttonTakePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonTakePicture.FlatAppearance.BorderSize = 0;
            this.buttonTakePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTakePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTakePicture.ForeColor = System.Drawing.Color.White;
            this.buttonTakePicture.Location = new System.Drawing.Point(18, 522);
            this.buttonTakePicture.Name = "buttonTakePicture";
            this.buttonTakePicture.Size = new System.Drawing.Size(145, 40);
            this.buttonTakePicture.TabIndex = 5;
            this.buttonTakePicture.Text = "Zrób zdjęcie";
            this.buttonTakePicture.UseVisualStyleBackColor = false;
            this.buttonTakePicture.Click += new System.EventHandler(this.buttonTakePicture_Click);
            // 
            // buttonDefaultPicture
            // 
            this.buttonDefaultPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonDefaultPicture.FlatAppearance.BorderSize = 0;
            this.buttonDefaultPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefaultPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDefaultPicture.Location = new System.Drawing.Point(169, 522);
            this.buttonDefaultPicture.Name = "buttonDefaultPicture";
            this.buttonDefaultPicture.Size = new System.Drawing.Size(145, 40);
            this.buttonDefaultPicture.TabIndex = 6;
            this.buttonDefaultPicture.Text = "Domyślny";
            this.buttonDefaultPicture.UseVisualStyleBackColor = false;
            this.buttonDefaultPicture.Click += new System.EventHandler(this.buttonDefaultPicture_Click);
            // 
            // buttonPainting
            // 
            this.buttonPainting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonPainting.FlatAppearance.BorderSize = 0;
            this.buttonPainting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPainting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPainting.Location = new System.Drawing.Point(320, 522);
            this.buttonPainting.Name = "buttonPainting";
            this.buttonPainting.Size = new System.Drawing.Size(145, 40);
            this.buttonPainting.TabIndex = 7;
            this.buttonPainting.Text = "Rysuj";
            this.buttonPainting.UseVisualStyleBackColor = false;
            this.buttonPainting.Click += new System.EventHandler(this.buttonPainting_Click);
            // 
            // groupBoxPropertiesPlayer
            // 
            this.groupBoxPropertiesPlayer.Controls.Add(this.buttonLoadPlayerNames);
            this.groupBoxPropertiesPlayer.Controls.Add(this.labelEarlierAvatar);
            this.groupBoxPropertiesPlayer.Controls.Add(this.comboBoxPictureName);
            this.groupBoxPropertiesPlayer.Controls.Add(this.buttonPainting);
            this.groupBoxPropertiesPlayer.Controls.Add(this.buttonDefaultPicture);
            this.groupBoxPropertiesPlayer.Controls.Add(this.buttonTakePicture);
            this.groupBoxPropertiesPlayer.Controls.Add(this.labelAvatar);
            this.groupBoxPropertiesPlayer.Controls.Add(this.labelLogin);
            this.groupBoxPropertiesPlayer.Controls.Add(this.comboBoxPlayerNames);
            this.groupBoxPropertiesPlayer.Controls.Add(this.pictureBoxAvatar);
            this.groupBoxPropertiesPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxPropertiesPlayer.ForeColor = System.Drawing.Color.White;
            this.groupBoxPropertiesPlayer.Location = new System.Drawing.Point(35, 67);
            this.groupBoxPropertiesPlayer.Name = "groupBoxPropertiesPlayer";
            this.groupBoxPropertiesPlayer.Size = new System.Drawing.Size(480, 730);
            this.groupBoxPropertiesPlayer.TabIndex = 8;
            this.groupBoxPropertiesPlayer.TabStop = false;
            this.groupBoxPropertiesPlayer.Text = "Ustawienia gracza";
            // 
            // buttonLoadPlayerNames
            // 
            this.buttonLoadPlayerNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonLoadPlayerNames.FlatAppearance.BorderSize = 0;
            this.buttonLoadPlayerNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadPlayerNames.Location = new System.Drawing.Point(17, 681);
            this.buttonLoadPlayerNames.Name = "buttonLoadPlayerNames";
            this.buttonLoadPlayerNames.Size = new System.Drawing.Size(448, 40);
            this.buttonLoadPlayerNames.TabIndex = 10;
            this.buttonLoadPlayerNames.Text = "Załaduj zapamietane nazwy użytkowników";
            this.buttonLoadPlayerNames.UseVisualStyleBackColor = false;
            this.buttonLoadPlayerNames.Click += new System.EventHandler(this.buttonLoadPlayerNames_Click);
            // 
            // labelEarlierAvatar
            // 
            this.labelEarlierAvatar.AutoSize = true;
            this.labelEarlierAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEarlierAvatar.Location = new System.Drawing.Point(13, 568);
            this.labelEarlierAvatar.Name = "labelEarlierAvatar";
            this.labelEarlierAvatar.Size = new System.Drawing.Size(175, 25);
            this.labelEarlierAvatar.TabIndex = 9;
            this.labelEarlierAvatar.Text = "Zdjęcia i rysunki:";
            // 
            // comboBoxPictureName
            // 
            this.comboBoxPictureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPictureName.FormattingEnabled = true;
            this.comboBoxPictureName.Location = new System.Drawing.Point(223, 565);
            this.comboBoxPictureName.Name = "comboBoxPictureName";
            this.comboBoxPictureName.Size = new System.Drawing.Size(242, 33);
            this.comboBoxPictureName.TabIndex = 8;
            this.comboBoxPictureName.SelectedIndexChanged += new System.EventHandler(this.comboBoxPictureName_SelectedIndexChanged);
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMap.Location = new System.Drawing.Point(7, 22);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(73, 25);
            this.labelMap.TabIndex = 8;
            this.labelMap.Text = "Mapa:";
            // 
            // labelMonster
            // 
            this.labelMonster.AutoSize = true;
            this.labelMonster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMonster.Location = new System.Drawing.Point(7, 437);
            this.labelMonster.Name = "labelMonster";
            this.labelMonster.Size = new System.Drawing.Size(108, 25);
            this.labelMonster.TabIndex = 9;
            this.labelMonster.Text = "Potworek:";
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.BackColor = System.Drawing.Color.White;
            this.pictureBoxMap.Location = new System.Drawing.Point(12, 51);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(498, 316);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMap.TabIndex = 10;
            this.pictureBoxMap.TabStop = false;
            // 
            // pictureBoxMonster
            // 
            this.pictureBoxMonster.BackColor = System.Drawing.Color.White;
            this.pictureBoxMonster.Location = new System.Drawing.Point(12, 478);
            this.pictureBoxMonster.Name = "pictureBoxMonster";
            this.pictureBoxMonster.Size = new System.Drawing.Size(192, 192);
            this.pictureBoxMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMonster.TabIndex = 11;
            this.pictureBoxMonster.TabStop = false;
            // 
            // comboBoxMonsters
            // 
            this.comboBoxMonsters.FormattingEnabled = true;
            this.comboBoxMonsters.Location = new System.Drawing.Point(220, 478);
            this.comboBoxMonsters.Name = "comboBoxMonsters";
            this.comboBoxMonsters.Size = new System.Drawing.Size(291, 28);
            this.comboBoxMonsters.TabIndex = 12;
            this.comboBoxMonsters.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonsters_SelectedIndexChanged);
            // 
            // comboBoxMaps
            // 
            this.comboBoxMaps.FormattingEnabled = true;
            this.comboBoxMaps.Location = new System.Drawing.Point(12, 383);
            this.comboBoxMaps.Name = "comboBoxMaps";
            this.comboBoxMaps.Size = new System.Drawing.Size(499, 28);
            this.comboBoxMaps.TabIndex = 13;
            this.comboBoxMaps.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaps_SelectedIndexChanged);
            // 
            // imageListMonsters
            // 
            this.imageListMonsters.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMonsters.ImageStream")));
            this.imageListMonsters.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMonsters.Images.SetKeyName(0, "monster0.png");
            this.imageListMonsters.Images.SetKeyName(1, "monster1.png");
            this.imageListMonsters.Images.SetKeyName(2, "monster2.png");
            this.imageListMonsters.Images.SetKeyName(3, "monster3.png");
            this.imageListMonsters.Images.SetKeyName(4, "monster4.png");
            // 
            // imageListMaps
            // 
            this.imageListMaps.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMaps.ImageStream")));
            this.imageListMaps.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMaps.Images.SetKeyName(0, "map0.jpg");
            this.imageListMaps.Images.SetKeyName(1, "map1.jpg");
            this.imageListMaps.Images.SetKeyName(2, "map2.jpg");
            this.imageListMaps.Images.SetKeyName(3, "map3.jpg");
            this.imageListMaps.Images.SetKeyName(4, "map4.jpg");
            // 
            // groupBoxPropertiesGame
            // 
            this.groupBoxPropertiesGame.Controls.Add(this.comboBoxMaps);
            this.groupBoxPropertiesGame.Controls.Add(this.comboBoxMonsters);
            this.groupBoxPropertiesGame.Controls.Add(this.pictureBoxMonster);
            this.groupBoxPropertiesGame.Controls.Add(this.pictureBoxMap);
            this.groupBoxPropertiesGame.Controls.Add(this.labelMonster);
            this.groupBoxPropertiesGame.Controls.Add(this.labelMap);
            this.groupBoxPropertiesGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxPropertiesGame.ForeColor = System.Drawing.Color.White;
            this.groupBoxPropertiesGame.Location = new System.Drawing.Point(542, 67);
            this.groupBoxPropertiesGame.Name = "groupBoxPropertiesGame";
            this.groupBoxPropertiesGame.Size = new System.Drawing.Size(529, 730);
            this.groupBoxPropertiesGame.TabIndex = 14;
            this.groupBoxPropertiesGame.TabStop = false;
            this.groupBoxPropertiesGame.Text = "Ustawienia rozgrywki";
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
            this.panelHeader.Size = new System.Drawing.Size(1139, 45);
            this.panelHeader.TabIndex = 15;
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
            // labelTitleForm
            // 
            this.labelTitleForm.AutoSize = true;
            this.labelTitleForm.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitleForm.ForeColor = System.Drawing.Color.White;
            this.labelTitleForm.Location = new System.Drawing.Point(53, 8);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(164, 34);
            this.labelTitleForm.TabIndex = 3;
            this.labelTitleForm.Text = "Ustawienia";
            // 
            // bunifuImageButtonMinimize
            // 
            this.bunifuImageButtonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.bunifuImageButtonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonMinimize.Image")));
            this.bunifuImageButtonMinimize.ImageActive = null;
            this.bunifuImageButtonMinimize.Location = new System.Drawing.Point(1023, 1);
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
            this.bunifuImageButtonExit.Location = new System.Drawing.Point(1079, 1);
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
            // PropertiesPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(178)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(1139, 925);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.groupBoxPropertiesGame);
            this.Controls.Add(this.groupBoxPropertiesPlayer);
            this.Controls.Add(this.buttonPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PropertiesPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ustawienia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.groupBoxPropertiesPlayer.ResumeLayout(false);
            this.groupBoxPropertiesPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster)).EndInit();
            this.groupBoxPropertiesGame.ResumeLayout(false);
            this.groupBoxPropertiesGame.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.ComboBox comboBoxPlayerNames;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelAvatar;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonTakePicture;
        private System.Windows.Forms.Button buttonDefaultPicture;
        private System.Windows.Forms.Button buttonPainting;
        private System.Windows.Forms.GroupBox groupBoxPropertiesPlayer;
        private System.Windows.Forms.Label labelMap;
        private System.Windows.Forms.Label labelMonster;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.PictureBox pictureBoxMonster;
        private System.Windows.Forms.ComboBox comboBoxMonsters;
        private System.Windows.Forms.ComboBox comboBoxMaps;
        private System.Windows.Forms.ImageList imageListMonsters;
        private System.Windows.Forms.ImageList imageListMaps;
        private System.Windows.Forms.GroupBox groupBoxPropertiesGame;
        private System.Windows.Forms.ComboBox comboBoxPictureName;
        private System.Windows.Forms.Label labelEarlierAvatar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxIconAplication;
        private System.Windows.Forms.Label labelTitleForm;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonMinimize;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlMoveWindow;
        private System.Windows.Forms.Button buttonLoadPlayerNames;
    }
}

