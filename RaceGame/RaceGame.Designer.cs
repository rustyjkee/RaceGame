namespace Race
{
    partial class RaceGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaceGame));
            timerRoad = new System.Windows.Forms.Timer(components);
            panelGame = new Panel();
            panelPause = new Panel();
            panelMenu = new Panel();
            playerNameTextBox = new TextBox();
            buttonScores = new Button();
            buttonHelp = new Button();
            buttonMenuExit = new Button();
            buttonStart = new Button();
            labelRace = new Label();
            menuCar1 = new PictureBox();
            menuCar3 = new PictureBox();
            menuCar2 = new PictureBox();
            MenuRightLane5 = new Label();
            MenuRightLane4 = new Label();
            MenuRightLane3 = new Label();
            MenuRightLane2 = new Label();
            MenuRightLane1 = new Label();
            MenuLeftLane5 = new Label();
            MenuLeftLane4 = new Label();
            MenuLeftLane3 = new Label();
            MenuLeftLane2 = new Label();
            MenuLeftLane1 = new Label();
            buttonExit = new Button();
            buttonResume = new Button();
            pictureFlag = new PictureBox();
            labelPause = new Label();
            labelScore = new Label();
            labelCoins = new Label();
            towardCar2 = new PictureBox();
            towardCar1 = new PictureBox();
            towardCar3 = new PictureBox();
            Coin3 = new PictureBox();
            Coin2 = new PictureBox();
            Coin1 = new PictureBox();
            buttonPause = new Button();
            mainCar = new PictureBox();
            GameRightLane5 = new Label();
            GameRightLane4 = new Label();
            GameRightLane3 = new Label();
            GameRightLane2 = new Label();
            GameRightLane1 = new Label();
            GameLeftLane5 = new Label();
            GameLeftLane4 = new Label();
            GameLeftLane3 = new Label();
            GameLeftLane2 = new Label();
            GameLeftLane1 = new Label();
            MiddleLane = new Label();
            timerTowardCars = new System.Windows.Forms.Timer(components);
            timerMenu = new System.Windows.Forms.Timer(components);
            panelGame.SuspendLayout();
            panelPause.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuCar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuCar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuCar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)towardCar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)towardCar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)towardCar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Coin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Coin2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainCar).BeginInit();
            SuspendLayout();
            // 
            // timerRoad
            // 
            timerRoad.Enabled = true;
            timerRoad.Interval = 1;
            timerRoad.Tick += timerRoad_Tick;
            // 
            // panelGame
            // 
            panelGame.BackColor = SystemColors.ControlDarkDark;
            panelGame.Controls.Add(panelPause);
            panelGame.Controls.Add(labelScore);
            panelGame.Controls.Add(labelCoins);
            panelGame.Controls.Add(towardCar2);
            panelGame.Controls.Add(towardCar1);
            panelGame.Controls.Add(towardCar3);
            panelGame.Controls.Add(Coin3);
            panelGame.Controls.Add(Coin2);
            panelGame.Controls.Add(Coin1);
            panelGame.Controls.Add(buttonPause);
            panelGame.Controls.Add(mainCar);
            panelGame.Controls.Add(GameRightLane5);
            panelGame.Controls.Add(GameRightLane4);
            panelGame.Controls.Add(GameRightLane3);
            panelGame.Controls.Add(GameRightLane2);
            panelGame.Controls.Add(GameRightLane1);
            panelGame.Controls.Add(GameLeftLane5);
            panelGame.Controls.Add(GameLeftLane4);
            panelGame.Controls.Add(GameLeftLane3);
            panelGame.Controls.Add(GameLeftLane2);
            panelGame.Controls.Add(GameLeftLane1);
            panelGame.Controls.Add(MiddleLane);
            panelGame.Location = new Point(0, 0);
            panelGame.Margin = new Padding(4);
            panelGame.Name = "panelGame";
            panelGame.Size = new Size(448, 650);
            panelGame.TabIndex = 1;
            // 
            // panelPause
            // 
            panelPause.BackColor = SystemColors.ControlDarkDark;
            panelPause.Controls.Add(panelMenu);
            panelPause.Controls.Add(buttonExit);
            panelPause.Controls.Add(buttonResume);
            panelPause.Controls.Add(pictureFlag);
            panelPause.Controls.Add(labelPause);
            panelPause.Location = new Point(0, 0);
            panelPause.Margin = new Padding(4);
            panelPause.Name = "panelPause";
            panelPause.Size = new Size(451, 654);
            panelPause.TabIndex = 57;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ControlDarkDark;
            panelMenu.Controls.Add(playerNameTextBox);
            panelMenu.Controls.Add(buttonScores);
            panelMenu.Controls.Add(buttonHelp);
            panelMenu.Controls.Add(buttonMenuExit);
            panelMenu.Controls.Add(buttonStart);
            panelMenu.Controls.Add(labelRace);
            panelMenu.Controls.Add(menuCar1);
            panelMenu.Controls.Add(menuCar3);
            panelMenu.Controls.Add(menuCar2);
            panelMenu.Controls.Add(MenuRightLane5);
            panelMenu.Controls.Add(MenuRightLane4);
            panelMenu.Controls.Add(MenuRightLane3);
            panelMenu.Controls.Add(MenuRightLane2);
            panelMenu.Controls.Add(MenuRightLane1);
            panelMenu.Controls.Add(MenuLeftLane5);
            panelMenu.Controls.Add(MenuLeftLane4);
            panelMenu.Controls.Add(MenuLeftLane3);
            panelMenu.Controls.Add(MenuLeftLane2);
            panelMenu.Controls.Add(MenuLeftLane1);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(451, 650);
            panelMenu.TabIndex = 84;
            // 
            // playerNameTextBox
            // 
            playerNameTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            playerNameTextBox.HideSelection = false;
            playerNameTextBox.Location = new Point(125, 323);
            playerNameTextBox.Multiline = true;
            playerNameTextBox.Name = "playerNameTextBox";
            playerNameTextBox.Size = new Size(200, 38);
            playerNameTextBox.TabIndex = 0;
            playerNameTextBox.Text = "Enter your name here";
            playerNameTextBox.TextAlign = HorizontalAlignment.Center;
            playerNameTextBox.MouseDown += playerNameTextBox_MouseDown;
            // 
            // buttonScores
            // 
            buttonScores.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonScores.Location = new Point(125, 380);
            buttonScores.Margin = new Padding(4);
            buttonScores.Name = "buttonScores";
            buttonScores.Size = new Size(199, 54);
            buttonScores.TabIndex = 85;
            buttonScores.Text = "Show scores";
            buttonScores.UseVisualStyleBackColor = true;
            buttonScores.Click += buttonScores_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHelp.Location = new Point(361, 609);
            buttonHelp.Margin = new Padding(4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(81, 37);
            buttonHelp.TabIndex = 82;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonMenuExit
            // 
            buttonMenuExit.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMenuExit.Location = new Point(146, 451);
            buttonMenuExit.Margin = new Padding(4);
            buttonMenuExit.Name = "buttonMenuExit";
            buttonMenuExit.Size = new Size(154, 54);
            buttonMenuExit.TabIndex = 67;
            buttonMenuExit.Text = "Exit";
            buttonMenuExit.UseVisualStyleBackColor = true;
            buttonMenuExit.Click += buttonMenuExit_Click;
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(130, 232);
            buttonStart.Margin = new Padding(4);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(186, 68);
            buttonStart.TabIndex = 65;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelRace
            // 
            labelRace.AutoSize = true;
            labelRace.BackColor = Color.FromArgb(64, 64, 64);
            labelRace.Font = new Font("Microsoft Tai Le", 105F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelRace.ForeColor = SystemColors.Control;
            labelRace.Location = new Point(0, 0);
            labelRace.Margin = new Padding(4, 0, 4, 0);
            labelRace.Name = "labelRace";
            labelRace.Size = new Size(384, 178);
            labelRace.TabIndex = 66;
            labelRace.Text = "Race";
            // 
            // menuCar1
            // 
            menuCar1.BackColor = Color.Transparent;
            menuCar1.Image = (Image)resources.GetObject("menuCar1.Image");
            menuCar1.Location = new Point(14, 15);
            menuCar1.Margin = new Padding(4);
            menuCar1.Name = "menuCar1";
            menuCar1.Size = new Size(59, 127);
            menuCar1.SizeMode = PictureBoxSizeMode.Zoom;
            menuCar1.TabIndex = 80;
            menuCar1.TabStop = false;
            // 
            // menuCar3
            // 
            menuCar3.BackColor = Color.Transparent;
            menuCar3.Image = (Image)resources.GetObject("menuCar3.Image");
            menuCar3.Location = new Point(375, 30);
            menuCar3.Margin = new Padding(4);
            menuCar3.Name = "menuCar3";
            menuCar3.Size = new Size(59, 127);
            menuCar3.SizeMode = PictureBoxSizeMode.Zoom;
            menuCar3.TabIndex = 81;
            menuCar3.TabStop = false;
            // 
            // menuCar2
            // 
            menuCar2.BackColor = Color.Transparent;
            menuCar2.Image = (Image)resources.GetObject("menuCar2.Image");
            menuCar2.Location = new Point(150, 4);
            menuCar2.Margin = new Padding(4);
            menuCar2.Name = "menuCar2";
            menuCar2.Size = new Size(59, 127);
            menuCar2.SizeMode = PictureBoxSizeMode.Zoom;
            menuCar2.TabIndex = 79;
            menuCar2.TabStop = false;
            // 
            // MenuRightLane5
            // 
            MenuRightLane5.BackColor = Color.White;
            MenuRightLane5.ForeColor = SystemColors.Control;
            MenuRightLane5.Location = new Point(337, 598);
            MenuRightLane5.Margin = new Padding(4, 0, 4, 0);
            MenuRightLane5.Name = "MenuRightLane5";
            MenuRightLane5.Size = new Size(18, 104);
            MenuRightLane5.TabIndex = 78;
            MenuRightLane5.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuRightLane4
            // 
            MenuRightLane4.BackColor = Color.White;
            MenuRightLane4.ForeColor = SystemColors.Control;
            MenuRightLane4.Location = new Point(337, 436);
            MenuRightLane4.Margin = new Padding(4, 0, 4, 0);
            MenuRightLane4.Name = "MenuRightLane4";
            MenuRightLane4.Size = new Size(18, 104);
            MenuRightLane4.TabIndex = 77;
            MenuRightLane4.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuRightLane3
            // 
            MenuRightLane3.BackColor = Color.White;
            MenuRightLane3.ForeColor = SystemColors.Control;
            MenuRightLane3.Location = new Point(337, 274);
            MenuRightLane3.Margin = new Padding(4, 0, 4, 0);
            MenuRightLane3.Name = "MenuRightLane3";
            MenuRightLane3.Size = new Size(18, 104);
            MenuRightLane3.TabIndex = 76;
            MenuRightLane3.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuRightLane2
            // 
            MenuRightLane2.BackColor = Color.White;
            MenuRightLane2.ForeColor = SystemColors.Control;
            MenuRightLane2.Location = new Point(337, 113);
            MenuRightLane2.Margin = new Padding(4, 0, 4, 0);
            MenuRightLane2.Name = "MenuRightLane2";
            MenuRightLane2.Size = new Size(18, 104);
            MenuRightLane2.TabIndex = 75;
            MenuRightLane2.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuRightLane1
            // 
            MenuRightLane1.BackColor = Color.White;
            MenuRightLane1.ForeColor = SystemColors.Control;
            MenuRightLane1.Location = new Point(337, -49);
            MenuRightLane1.Margin = new Padding(4, 0, 4, 0);
            MenuRightLane1.Name = "MenuRightLane1";
            MenuRightLane1.Size = new Size(18, 104);
            MenuRightLane1.TabIndex = 74;
            MenuRightLane1.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuLeftLane5
            // 
            MenuLeftLane5.BackColor = Color.White;
            MenuLeftLane5.ForeColor = SystemColors.Control;
            MenuLeftLane5.Location = new Point(104, 598);
            MenuLeftLane5.Margin = new Padding(4, 0, 4, 0);
            MenuLeftLane5.Name = "MenuLeftLane5";
            MenuLeftLane5.Size = new Size(18, 104);
            MenuLeftLane5.TabIndex = 73;
            MenuLeftLane5.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuLeftLane4
            // 
            MenuLeftLane4.BackColor = Color.White;
            MenuLeftLane4.ForeColor = SystemColors.Control;
            MenuLeftLane4.Location = new Point(104, 436);
            MenuLeftLane4.Margin = new Padding(4, 0, 4, 0);
            MenuLeftLane4.Name = "MenuLeftLane4";
            MenuLeftLane4.Size = new Size(18, 104);
            MenuLeftLane4.TabIndex = 72;
            MenuLeftLane4.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuLeftLane3
            // 
            MenuLeftLane3.BackColor = Color.White;
            MenuLeftLane3.ForeColor = SystemColors.Control;
            MenuLeftLane3.Location = new Point(104, 274);
            MenuLeftLane3.Margin = new Padding(4, 0, 4, 0);
            MenuLeftLane3.Name = "MenuLeftLane3";
            MenuLeftLane3.Size = new Size(18, 104);
            MenuLeftLane3.TabIndex = 71;
            MenuLeftLane3.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuLeftLane2
            // 
            MenuLeftLane2.BackColor = Color.White;
            MenuLeftLane2.ForeColor = SystemColors.Control;
            MenuLeftLane2.Location = new Point(104, 113);
            MenuLeftLane2.Margin = new Padding(4, 0, 4, 0);
            MenuLeftLane2.Name = "MenuLeftLane2";
            MenuLeftLane2.Size = new Size(18, 104);
            MenuLeftLane2.TabIndex = 70;
            MenuLeftLane2.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuLeftLane1
            // 
            MenuLeftLane1.BackColor = Color.White;
            MenuLeftLane1.ForeColor = SystemColors.Control;
            MenuLeftLane1.Location = new Point(104, -49);
            MenuLeftLane1.Margin = new Padding(4, 0, 4, 0);
            MenuLeftLane1.Name = "MenuLeftLane1";
            MenuLeftLane1.Size = new Size(18, 104);
            MenuLeftLane1.TabIndex = 69;
            MenuLeftLane1.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(139, 555);
            buttonExit.Margin = new Padding(4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(178, 46);
            buttonExit.TabIndex = 53;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonResume
            // 
            buttonResume.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            buttonResume.Location = new Point(139, 469);
            buttonResume.Margin = new Padding(4);
            buttonResume.Name = "buttonResume";
            buttonResume.Size = new Size(178, 67);
            buttonResume.TabIndex = 52;
            buttonResume.Text = "Resume";
            buttonResume.UseVisualStyleBackColor = true;
            buttonResume.Click += buttonResume_Click;
            // 
            // pictureFlag
            // 
            pictureFlag.BackColor = SystemColors.ControlDarkDark;
            pictureFlag.Image = (Image)resources.GetObject("pictureFlag.Image");
            pictureFlag.Location = new Point(-3, 124);
            pictureFlag.Margin = new Padding(4);
            pictureFlag.Name = "pictureFlag";
            pictureFlag.Size = new Size(451, 364);
            pictureFlag.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFlag.TabIndex = 55;
            pictureFlag.TabStop = false;
            // 
            // labelPause
            // 
            labelPause.AutoSize = true;
            labelPause.Font = new Font("Microsoft YaHei", 90F, FontStyle.Bold, GraphicsUnit.Point);
            labelPause.Location = new Point(0, 0);
            labelPause.Margin = new Padding(4, 0, 4, 0);
            labelPause.Name = "labelPause";
            labelPause.Size = new Size(422, 159);
            labelPause.TabIndex = 54;
            labelPause.Text = "Pause";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.BackColor = Color.Black;
            labelScore.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelScore.ForeColor = SystemColors.ButtonHighlight;
            labelScore.Location = new Point(14, 10);
            labelScore.Margin = new Padding(4, 0, 4, 0);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(110, 40);
            labelScore.TabIndex = 56;
            labelScore.Text = "Score:";
            // 
            // labelCoins
            // 
            labelCoins.AutoSize = true;
            labelCoins.BackColor = Color.Black;
            labelCoins.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelCoins.ForeColor = SystemColors.ButtonHighlight;
            labelCoins.Location = new Point(242, 10);
            labelCoins.Margin = new Padding(4, 0, 4, 0);
            labelCoins.Name = "labelCoins";
            labelCoins.Size = new Size(109, 40);
            labelCoins.TabIndex = 57;
            labelCoins.Text = "Coins:";
            // 
            // towardCar2
            // 
            towardCar2.BackColor = Color.Transparent;
            towardCar2.Image = (Image)resources.GetObject("towardCar2.Image");
            towardCar2.Location = new Point(14, 26);
            towardCar2.Margin = new Padding(4);
            towardCar2.Name = "towardCar2";
            towardCar2.Size = new Size(59, 127);
            towardCar2.SizeMode = PictureBoxSizeMode.Zoom;
            towardCar2.TabIndex = 49;
            towardCar2.TabStop = false;
            // 
            // towardCar1
            // 
            towardCar1.BackColor = Color.Transparent;
            towardCar1.Image = (Image)resources.GetObject("towardCar1.Image");
            towardCar1.Location = new Point(150, 15);
            towardCar1.Margin = new Padding(4);
            towardCar1.Name = "towardCar1";
            towardCar1.Size = new Size(59, 127);
            towardCar1.SizeMode = PictureBoxSizeMode.Zoom;
            towardCar1.TabIndex = 48;
            towardCar1.TabStop = false;
            // 
            // towardCar3
            // 
            towardCar3.BackColor = Color.Transparent;
            towardCar3.Image = (Image)resources.GetObject("towardCar3.Image");
            towardCar3.Location = new Point(375, 41);
            towardCar3.Margin = new Padding(4);
            towardCar3.Name = "towardCar3";
            towardCar3.Size = new Size(59, 127);
            towardCar3.SizeMode = PictureBoxSizeMode.Zoom;
            towardCar3.TabIndex = 50;
            towardCar3.TabStop = false;
            // 
            // Coin3
            // 
            Coin3.BackColor = Color.Transparent;
            Coin3.Image = (Image)resources.GetObject("Coin3.Image");
            Coin3.Location = new Point(375, 257);
            Coin3.Margin = new Padding(4);
            Coin3.Name = "Coin3";
            Coin3.Size = new Size(39, 37);
            Coin3.SizeMode = PictureBoxSizeMode.Zoom;
            Coin3.TabIndex = 54;
            Coin3.TabStop = false;
            // 
            // Coin2
            // 
            Coin2.BackColor = Color.Transparent;
            Coin2.Image = (Image)resources.GetObject("Coin2.Image");
            Coin2.Location = new Point(258, 180);
            Coin2.Margin = new Padding(4);
            Coin2.Name = "Coin2";
            Coin2.Size = new Size(39, 37);
            Coin2.SizeMode = PictureBoxSizeMode.Zoom;
            Coin2.TabIndex = 53;
            Coin2.TabStop = false;
            // 
            // Coin1
            // 
            Coin1.BackColor = Color.Transparent;
            Coin1.Image = (Image)resources.GetObject("Coin1.Image");
            Coin1.Location = new Point(129, 291);
            Coin1.Margin = new Padding(4);
            Coin1.Name = "Coin1";
            Coin1.Size = new Size(39, 37);
            Coin1.SizeMode = PictureBoxSizeMode.Zoom;
            Coin1.TabIndex = 52;
            Coin1.TabStop = false;
            // 
            // buttonPause
            // 
            buttonPause.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPause.Location = new Point(0, 602);
            buttonPause.Margin = new Padding(4);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(95, 44);
            buttonPause.TabIndex = 1;
            buttonPause.Text = "Pause";
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += buttonPause_Click;
            // 
            // mainCar
            // 
            mainCar.BackColor = Color.Transparent;
            mainCar.BackgroundImageLayout = ImageLayout.None;
            mainCar.Image = (Image)resources.GetObject("mainCar.Image");
            mainCar.Location = new Point(258, 508);
            mainCar.Margin = new Padding(4);
            mainCar.Name = "mainCar";
            mainCar.Size = new Size(59, 127);
            mainCar.SizeMode = PictureBoxSizeMode.Zoom;
            mainCar.TabIndex = 47;
            mainCar.TabStop = false;
            // 
            // GameRightLane5
            // 
            GameRightLane5.BackColor = Color.White;
            GameRightLane5.ForeColor = SystemColors.Control;
            GameRightLane5.Location = new Point(337, 609);
            GameRightLane5.Margin = new Padding(4, 0, 4, 0);
            GameRightLane5.Name = "GameRightLane5";
            GameRightLane5.Size = new Size(18, 104);
            GameRightLane5.TabIndex = 43;
            GameRightLane5.TextAlign = ContentAlignment.TopCenter;
            // 
            // GameRightLane4
            // 
            GameRightLane4.BackColor = Color.White;
            GameRightLane4.ForeColor = SystemColors.Control;
            GameRightLane4.Location = new Point(337, 447);
            GameRightLane4.Margin = new Padding(4, 0, 4, 0);
            GameRightLane4.Name = "GameRightLane4";
            GameRightLane4.Size = new Size(18, 104);
            GameRightLane4.TabIndex = 42;
            GameRightLane4.TextAlign = ContentAlignment.TopCenter;
            // 
            // GameRightLane3
            // 
            GameRightLane3.BackColor = Color.White;
            GameRightLane3.ForeColor = SystemColors.Control;
            GameRightLane3.Location = new Point(337, 286);
            GameRightLane3.Margin = new Padding(4, 0, 4, 0);
            GameRightLane3.Name = "GameRightLane3";
            GameRightLane3.Size = new Size(18, 104);
            GameRightLane3.TabIndex = 41;
            GameRightLane3.TextAlign = ContentAlignment.TopCenter;
            // 
            // GameRightLane2
            // 
            GameRightLane2.BackColor = Color.White;
            GameRightLane2.ForeColor = SystemColors.Control;
            GameRightLane2.Location = new Point(337, 124);
            GameRightLane2.Margin = new Padding(4, 0, 4, 0);
            GameRightLane2.Name = "GameRightLane2";
            GameRightLane2.Size = new Size(18, 104);
            GameRightLane2.TabIndex = 40;
            GameRightLane2.TextAlign = ContentAlignment.TopCenter;
            // 
            // GameRightLane1
            // 
            GameRightLane1.BackColor = Color.White;
            GameRightLane1.ForeColor = SystemColors.Control;
            GameRightLane1.Location = new Point(337, -37);
            GameRightLane1.Margin = new Padding(4, 0, 4, 0);
            GameRightLane1.Name = "GameRightLane1";
            GameRightLane1.Size = new Size(18, 104);
            GameRightLane1.TabIndex = 39;
            GameRightLane1.TextAlign = ContentAlignment.TopCenter;
            // 
            // GameLeftLane5
            // 
            GameLeftLane5.BackColor = Color.White;
            GameLeftLane5.ForeColor = SystemColors.Control;
            GameLeftLane5.Location = new Point(104, 609);
            GameLeftLane5.Margin = new Padding(4, 0, 4, 0);
            GameLeftLane5.Name = "GameLeftLane5";
            GameLeftLane5.Size = new Size(18, 104);
            GameLeftLane5.TabIndex = 38;
            GameLeftLane5.TextAlign = ContentAlignment.TopCenter;
            // 
            // GameLeftLane4
            // 
            GameLeftLane4.BackColor = Color.White;
            GameLeftLane4.ForeColor = SystemColors.Control;
            GameLeftLane4.Location = new Point(104, 448);
            GameLeftLane4.Margin = new Padding(4, 0, 4, 0);
            GameLeftLane4.Name = "GameLeftLane4";
            GameLeftLane4.Size = new Size(18, 104);
            GameLeftLane4.TabIndex = 37;
            GameLeftLane4.TextAlign = ContentAlignment.TopCenter;
            // 
            // GameLeftLane3
            // 
            GameLeftLane3.BackColor = Color.White;
            GameLeftLane3.ForeColor = SystemColors.Control;
            GameLeftLane3.Location = new Point(104, 286);
            GameLeftLane3.Margin = new Padding(4, 0, 4, 0);
            GameLeftLane3.Name = "GameLeftLane3";
            GameLeftLane3.Size = new Size(18, 104);
            GameLeftLane3.TabIndex = 36;
            GameLeftLane3.TextAlign = ContentAlignment.TopCenter;
            // 
            // GameLeftLane2
            // 
            GameLeftLane2.BackColor = Color.White;
            GameLeftLane2.ForeColor = SystemColors.Control;
            GameLeftLane2.Location = new Point(104, 124);
            GameLeftLane2.Margin = new Padding(4, 0, 4, 0);
            GameLeftLane2.Name = "GameLeftLane2";
            GameLeftLane2.Size = new Size(18, 104);
            GameLeftLane2.TabIndex = 35;
            GameLeftLane2.TextAlign = ContentAlignment.TopCenter;
            // 
            // GameLeftLane1
            // 
            GameLeftLane1.BackColor = Color.White;
            GameLeftLane1.ForeColor = SystemColors.Control;
            GameLeftLane1.Location = new Point(104, -37);
            GameLeftLane1.Margin = new Padding(4, 0, 4, 0);
            GameLeftLane1.Name = "GameLeftLane1";
            GameLeftLane1.Size = new Size(18, 104);
            GameLeftLane1.TabIndex = 34;
            GameLeftLane1.TextAlign = ContentAlignment.TopCenter;
            // 
            // MiddleLane
            // 
            MiddleLane.BackColor = Color.White;
            MiddleLane.ForeColor = SystemColors.Control;
            MiddleLane.Location = new Point(214, -4);
            MiddleLane.Margin = new Padding(4, 0, 4, 0);
            MiddleLane.Name = "MiddleLane";
            MiddleLane.Size = new Size(20, 654);
            MiddleLane.TabIndex = 33;
            MiddleLane.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerTowardCars
            // 
            timerTowardCars.Enabled = true;
            timerTowardCars.Interval = 1;
            timerTowardCars.Tick += timerTowardCars_Tick;
            // 
            // timerMenu
            // 
            timerMenu.Enabled = true;
            timerMenu.Interval = 1;
            timerMenu.Tick += timerMenu_Tick;
            // 
            // RaceGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(448, 649);
            Controls.Add(panelGame);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "RaceGame";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Race";
            Load += RaceGame_Load;
            Shown += RaceGame_Shown;
            KeyDown += RaceGame_KeyDown;
            panelGame.ResumeLayout(false);
            panelGame.PerformLayout();
            panelPause.ResumeLayout(false);
            panelPause.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuCar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuCar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuCar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureFlag).EndInit();
            ((System.ComponentModel.ISupportInitialize)towardCar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)towardCar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)towardCar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Coin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Coin2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainCar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerRoad;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label GameRightLane5;
        private System.Windows.Forms.Label GameRightLane4;
        private System.Windows.Forms.Label GameRightLane3;
        private System.Windows.Forms.Label GameRightLane2;
        private System.Windows.Forms.Label GameRightLane1;
        private System.Windows.Forms.Label GameLeftLane5;
        private System.Windows.Forms.Label GameLeftLane4;
        private System.Windows.Forms.Label GameLeftLane3;
        private System.Windows.Forms.Label GameLeftLane2;
        private System.Windows.Forms.Label GameLeftLane1;
        private System.Windows.Forms.Label MiddleLane;
        private System.Windows.Forms.PictureBox towardCar2;
        private System.Windows.Forms.PictureBox towardCar3;
        private System.Windows.Forms.PictureBox towardCar1;
        private System.Windows.Forms.PictureBox mainCar;
        private System.Windows.Forms.Timer timerTowardCars;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.PictureBox Coin3;
        private System.Windows.Forms.PictureBox Coin2;
        private System.Windows.Forms.Panel panelPause;
        private System.Windows.Forms.PictureBox pictureFlag;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.Label labelScore;
        private Panel panelMenu;
        private Button buttonHelp;
        private Button buttonMenuExit;
        private Button buttonStart;
        private Label labelRace;
        private PictureBox menuCar1;
        private PictureBox menuCar3;
        private PictureBox menuCar2;
        private Label MenuRightLane5;
        private Label MenuRightLane4;
        private Label MenuRightLane3;
        private Label MenuRightLane2;
        private Label MenuRightLane1;
        private Label MenuLeftLane5;
        private Label MenuLeftLane4;
        private Label MenuLeftLane3;
        private Label MenuLeftLane2;
        private Label MenuLeftLane1;
        private TextBox playerNameTextBox;
        private Button buttonScores;
    }
}