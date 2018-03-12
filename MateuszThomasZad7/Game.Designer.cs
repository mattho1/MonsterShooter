namespace MonsterShooter
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelGameTime = new System.Windows.Forms.Label();
            this.timerGameTime = new System.Windows.Forms.Timer(this.components);
            this.labelShotResult = new System.Windows.Forms.Label();
            this.labelResultText = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.pictureBoxMonster = new System.Windows.Forms.PictureBox();
            this.timerLocationMonster = new System.Windows.Forms.Timer(this.components);
            this.labelNumberShotText = new System.Windows.Forms.Label();
            this.labelNumberShot = new System.Windows.Forms.Label();
            this.labelBonusText = new System.Windows.Forms.Label();
            this.progressBarBonus = new System.Windows.Forms.ProgressBar();
            this.labelBonus = new System.Windows.Forms.Label();
            this.timerBonus = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxMonsterSecond = new System.Windows.Forms.PictureBox();
            this.timerSecondMonster = new System.Windows.Forms.Timer(this.components);
            this.buttonMute = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.imageListSound = new System.Windows.Forms.ImageList(this.components);
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelPauseText = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.bunifuImageButtonMiximizedWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButtonMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.bunifuImageButtonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControlMoveWindow = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.imageListIconSizeWindow = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxIconAplication = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonsterSecond)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMiximizedWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).BeginInit();
            this.groupBoxInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(12, 87);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(186, 215);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 0;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.Location = new System.Drawing.Point(6, 308);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(91, 32);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Login";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPlayer.Location = new System.Drawing.Point(6, 52);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(104, 32);
            this.labelPlayer.TabIndex = 2;
            this.labelPlayer.Text = "Gracz:";
            // 
            // labelGameTime
            // 
            this.labelGameTime.BackColor = System.Drawing.Color.Transparent;
            this.labelGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGameTime.Location = new System.Drawing.Point(411, 57);
            this.labelGameTime.Name = "labelGameTime";
            this.labelGameTime.Size = new System.Drawing.Size(255, 86);
            this.labelGameTime.TabIndex = 3;
            this.labelGameTime.Text = "0,0";
            this.labelGameTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerGameTime
            // 
            this.timerGameTime.Tick += new System.EventHandler(this.timerGameTime_Tick);
            // 
            // labelShotResult
            // 
            this.labelShotResult.AutoSize = true;
            this.labelShotResult.BackColor = System.Drawing.Color.Transparent;
            this.labelShotResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelShotResult.Location = new System.Drawing.Point(388, 166);
            this.labelShotResult.Name = "labelShotResult";
            this.labelShotResult.Size = new System.Drawing.Size(0, 91);
            this.labelShotResult.TabIndex = 5;
            this.labelShotResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResultText
            // 
            this.labelResultText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResultText.AutoSize = true;
            this.labelResultText.BackColor = System.Drawing.Color.Transparent;
            this.labelResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResultText.Location = new System.Drawing.Point(209, 11);
            this.labelResultText.Name = "labelResultText";
            this.labelResultText.Size = new System.Drawing.Size(173, 55);
            this.labelResultText.TabIndex = 6;
            this.labelResultText.Text = "Wynik:";
            // 
            // labelResult
            // 
            this.labelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.Color.Transparent;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResult.Location = new System.Drawing.Point(436, 11);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(52, 55);
            this.labelResult.TabIndex = 8;
            this.labelResult.Text = "0";
            // 
            // pictureBoxMonster
            // 
            this.pictureBoxMonster.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMonster.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMonster.Image")));
            this.pictureBoxMonster.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMonster.InitialImage")));
            this.pictureBoxMonster.Location = new System.Drawing.Point(269, 373);
            this.pictureBoxMonster.Name = "pictureBoxMonster";
            this.pictureBoxMonster.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMonster.TabIndex = 9;
            this.pictureBoxMonster.TabStop = false;
            this.pictureBoxMonster.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMonster_MouseDown);
            // 
            // timerLocationMonster
            // 
            this.timerLocationMonster.Interval = 2500;
            this.timerLocationMonster.Tick += new System.EventHandler(this.timerLocationMonster_Tick);
            // 
            // labelNumberShotText
            // 
            this.labelNumberShotText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumberShotText.AutoSize = true;
            this.labelNumberShotText.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberShotText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumberShotText.Location = new System.Drawing.Point(1, 72);
            this.labelNumberShotText.Name = "labelNumberShotText";
            this.labelNumberShotText.Size = new System.Drawing.Size(381, 55);
            this.labelNumberShotText.TabIndex = 10;
            this.labelNumberShotText.Text = "Liczba strzałów:";
            // 
            // labelNumberShot
            // 
            this.labelNumberShot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumberShot.AutoSize = true;
            this.labelNumberShot.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberShot.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumberShot.Location = new System.Drawing.Point(436, 72);
            this.labelNumberShot.Name = "labelNumberShot";
            this.labelNumberShot.Size = new System.Drawing.Size(52, 55);
            this.labelNumberShot.TabIndex = 11;
            this.labelNumberShot.Text = "0";
            // 
            // labelBonusText
            // 
            this.labelBonusText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBonusText.AutoSize = true;
            this.labelBonusText.BackColor = System.Drawing.Color.Transparent;
            this.labelBonusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBonusText.Location = new System.Drawing.Point(202, 127);
            this.labelBonusText.Name = "labelBonusText";
            this.labelBonusText.Size = new System.Drawing.Size(180, 55);
            this.labelBonusText.TabIndex = 12;
            this.labelBonusText.Text = "Bonus:";
            // 
            // progressBarBonus
            // 
            this.progressBarBonus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarBonus.Location = new System.Drawing.Point(75, 187);
            this.progressBarBonus.Maximum = 20;
            this.progressBarBonus.Name = "progressBarBonus";
            this.progressBarBonus.Size = new System.Drawing.Size(425, 36);
            this.progressBarBonus.Step = 1;
            this.progressBarBonus.TabIndex = 13;
            // 
            // labelBonus
            // 
            this.labelBonus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBonus.AutoSize = true;
            this.labelBonus.BackColor = System.Drawing.Color.Transparent;
            this.labelBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBonus.Location = new System.Drawing.Point(417, 127);
            this.labelBonus.Name = "labelBonus";
            this.labelBonus.Size = new System.Drawing.Size(77, 55);
            this.labelBonus.TabIndex = 14;
            this.labelBonus.Text = "x1";
            // 
            // timerBonus
            // 
            this.timerBonus.Tick += new System.EventHandler(this.timerBonus_Tick);
            // 
            // pictureBoxMonsterSecond
            // 
            this.pictureBoxMonsterSecond.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMonsterSecond.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMonsterSecond.Image")));
            this.pictureBoxMonsterSecond.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMonsterSecond.InitialImage")));
            this.pictureBoxMonsterSecond.Location = new System.Drawing.Point(674, 322);
            this.pictureBoxMonsterSecond.Name = "pictureBoxMonsterSecond";
            this.pictureBoxMonsterSecond.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxMonsterSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMonsterSecond.TabIndex = 15;
            this.pictureBoxMonsterSecond.TabStop = false;
            this.pictureBoxMonsterSecond.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMonsterSecond_MouseDown);
            // 
            // timerSecondMonster
            // 
            this.timerSecondMonster.Interval = 23500;
            this.timerSecondMonster.Tick += new System.EventHandler(this.timerSecondMonster_Tick);
            // 
            // buttonMute
            // 
            this.buttonMute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonMute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMute.BackgroundImage")));
            this.buttonMute.FlatAppearance.BorderSize = 0;
            this.buttonMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMute.ForeColor = System.Drawing.Color.White;
            this.buttonMute.Location = new System.Drawing.Point(451, 229);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(49, 42);
            this.buttonMute.TabIndex = 16;
            this.buttonMute.UseVisualStyleBackColor = false;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStop.ForeColor = System.Drawing.Color.White;
            this.buttonStop.Location = new System.Drawing.Point(219, 229);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(84, 42);
            this.buttonStop.TabIndex = 17;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonPause.FlatAppearance.BorderSize = 0;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPause.ForeColor = System.Drawing.Color.White;
            this.buttonPause.Location = new System.Drawing.Point(75, 229);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(138, 42);
            this.buttonPause.TabIndex = 18;
            this.buttonPause.Text = "PAUSE";
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // imageListSound
            // 
            this.imageListSound.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSound.ImageStream")));
            this.imageListSound.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSound.Images.SetKeyName(0, "Mute.png");
            this.imageListSound.Images.SetKeyName(1, "Sound2.png");
            // 
            // buttonRestart
            // 
            this.buttonRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.buttonRestart.FlatAppearance.BorderSize = 0;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRestart.ForeColor = System.Drawing.Color.White;
            this.buttonRestart.Location = new System.Drawing.Point(309, 229);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(136, 42);
            this.buttonRestart.TabIndex = 19;
            this.buttonRestart.Text = "RESTART";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // labelPauseText
            // 
            this.labelPauseText.AutoSize = true;
            this.labelPauseText.BackColor = System.Drawing.Color.Transparent;
            this.labelPauseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPauseText.ForeColor = System.Drawing.Color.Red;
            this.labelPauseText.Location = new System.Drawing.Point(321, 340);
            this.labelPauseText.Name = "labelPauseText";
            this.labelPauseText.Size = new System.Drawing.Size(469, 135);
            this.labelPauseText.TabIndex = 20;
            this.labelPauseText.Text = "PAUSE";
            this.labelPauseText.Visible = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.panelHeader.Controls.Add(this.pictureBoxIconAplication);
            this.panelHeader.Controls.Add(this.bunifuImageButtonMiximizedWindow);
            this.panelHeader.Controls.Add(this.bunifuImageButtonMinimize);
            this.panelHeader.Controls.Add(this.labelTitleForm);
            this.panelHeader.Controls.Add(this.bunifuImageButtonExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1300, 45);
            this.panelHeader.TabIndex = 21;
            // 
            // bunifuImageButtonMiximizedWindow
            // 
            this.bunifuImageButtonMiximizedWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonMiximizedWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.bunifuImageButtonMiximizedWindow.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonMiximizedWindow.Image")));
            this.bunifuImageButtonMiximizedWindow.ImageActive = null;
            this.bunifuImageButtonMiximizedWindow.Location = new System.Drawing.Point(1186, 0);
            this.bunifuImageButtonMiximizedWindow.Name = "bunifuImageButtonMiximizedWindow";
            this.bunifuImageButtonMiximizedWindow.Size = new System.Drawing.Size(48, 41);
            this.bunifuImageButtonMiximizedWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonMiximizedWindow.TabIndex = 5;
            this.bunifuImageButtonMiximizedWindow.TabStop = false;
            this.bunifuImageButtonMiximizedWindow.Zoom = 10;
            this.bunifuImageButtonMiximizedWindow.Click += new System.EventHandler(this.bunifuImageButtonMiximizedWindow_Click);
            // 
            // bunifuImageButtonMinimize
            // 
            this.bunifuImageButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.bunifuImageButtonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonMinimize.Image")));
            this.bunifuImageButtonMinimize.ImageActive = null;
            this.bunifuImageButtonMinimize.Location = new System.Drawing.Point(1132, 0);
            this.bunifuImageButtonMinimize.Name = "bunifuImageButtonMinimize";
            this.bunifuImageButtonMinimize.Size = new System.Drawing.Size(48, 41);
            this.bunifuImageButtonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonMinimize.TabIndex = 4;
            this.bunifuImageButtonMinimize.TabStop = false;
            this.bunifuImageButtonMinimize.Zoom = 10;
            this.bunifuImageButtonMinimize.Click += new System.EventHandler(this.bunifuImageButtonMinimize_Click);
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.AutoSize = true;
            this.labelTitleForm.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitleForm.ForeColor = System.Drawing.Color.White;
            this.labelTitleForm.Location = new System.Drawing.Point(53, 7);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(233, 34);
            this.labelTitleForm.TabIndex = 3;
            this.labelTitleForm.Text = "Monster Shooter";
            // 
            // bunifuImageButtonExit
            // 
            this.bunifuImageButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(2)))));
            this.bunifuImageButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonExit.Image")));
            this.bunifuImageButtonExit.ImageActive = null;
            this.bunifuImageButtonExit.Location = new System.Drawing.Point(1240, 0);
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
            // groupBoxInformation
            // 
            this.groupBoxInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInformation.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxInformation.Controls.Add(this.buttonRestart);
            this.groupBoxInformation.Controls.Add(this.buttonPause);
            this.groupBoxInformation.Controls.Add(this.buttonStop);
            this.groupBoxInformation.Controls.Add(this.buttonMute);
            this.groupBoxInformation.Controls.Add(this.labelBonus);
            this.groupBoxInformation.Controls.Add(this.progressBarBonus);
            this.groupBoxInformation.Controls.Add(this.labelBonusText);
            this.groupBoxInformation.Controls.Add(this.labelNumberShot);
            this.groupBoxInformation.Controls.Add(this.labelNumberShotText);
            this.groupBoxInformation.Controls.Add(this.labelResult);
            this.groupBoxInformation.Controls.Add(this.labelResultText);
            this.groupBoxInformation.Location = new System.Drawing.Point(740, 57);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(547, 283);
            this.groupBoxInformation.TabIndex = 22;
            this.groupBoxInformation.TabStop = false;
            // 
            // imageListIconSizeWindow
            // 
            this.imageListIconSizeWindow.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIconSizeWindow.ImageStream")));
            this.imageListIconSizeWindow.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIconSizeWindow.Images.SetKeyName(0, "Maximize Window_32px.png");
            this.imageListIconSizeWindow.Images.SetKeyName(1, "Restore Window_32px.png");
            // 
            // pictureBoxIconAplication
            // 
            this.pictureBoxIconAplication.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconAplication.Image")));
            this.pictureBoxIconAplication.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxIconAplication.Name = "pictureBoxIconAplication";
            this.pictureBoxIconAplication.Size = new System.Drawing.Size(44, 41);
            this.pictureBoxIconAplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIconAplication.TabIndex = 16;
            this.pictureBoxIconAplication.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.labelPauseText);
            this.Controls.Add(this.pictureBoxMonsterSecond);
            this.Controls.Add(this.pictureBoxMonster);
            this.Controls.Add(this.labelShotResult);
            this.Controls.Add(this.labelGameTime);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.pictureBoxAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Game_MouseDown);
            this.MouseHover += new System.EventHandler(this.Game_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonsterSecond)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMiximizedWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonExit)).EndInit();
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconAplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelGameTime;
        private System.Windows.Forms.Timer timerGameTime;
        private System.Windows.Forms.Label labelShotResult;
        private System.Windows.Forms.Label labelResultText;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.PictureBox pictureBoxMonster;
        private System.Windows.Forms.Timer timerLocationMonster;
        private System.Windows.Forms.Label labelNumberShotText;
        private System.Windows.Forms.Label labelNumberShot;
        private System.Windows.Forms.Label labelBonusText;
        private System.Windows.Forms.ProgressBar progressBarBonus;
        private System.Windows.Forms.Label labelBonus;
        private System.Windows.Forms.Timer timerBonus;
        private System.Windows.Forms.PictureBox pictureBoxMonsterSecond;
        private System.Windows.Forms.Timer timerSecondMonster;
        private System.Windows.Forms.Button buttonMute;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.ImageList imageListSound;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label labelPauseText;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitleForm;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlMoveWindow;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonMinimize;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonMiximizedWindow;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.ImageList imageListIconSizeWindow;
        private System.Windows.Forms.PictureBox pictureBoxIconAplication;
    }
}