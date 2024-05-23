﻿using WMPLib;

namespace Race
{
    public partial class RaceGame : Form
    {
        public RaceGame()
        {
            InitializeComponent();
        }

        private int laneSegmentCount = 5;
        private List<Label> GameLeftLanes;
        private List<Label> GameRightLanes;
        private List<Label> MenuLeftLanes;
        private List<Label> MenuRightLanes;

        private static Random random = new Random();

        private int score = 0;

        private List<PictureBox> coins;
        private int coinsCollected = 0;
        private int coinsGameContinueCount = 15;

        private List<PictureBox> towardCars;
        private List<PictureBox> menuCars;
        private int carSpeed = 2;

        private bool playerNameTextBoxFirstClicked;
        private string playerName;

        private WindowsMediaPlayer wplayer = new WindowsMediaPlayer();

        private void timerRoad_Tick(object sender, EventArgs e)
        {
            if (carSpeed != 0) score++;
            labelScore.Text = "Score: " + score / 10;

            for (int index = 0; index < laneSegmentCount; index++)
            {
                GameLeftLanes[index].Top += carSpeed;
                if (GameLeftLanes[index].Top >= Height)
                    GameLeftLanes[index].Top = -GameLeftLanes[index].Height;

                GameRightLanes[index].Top += carSpeed;
                if (GameRightLanes[index].Top >= Height)
                    GameRightLanes[index].Top = -GameRightLanes[index].Height;
            }

            for (var index = 0; index < coins.Count; index++)
            {
                PictureBox? coin = coins[index];

                coin.Top += carSpeed;

                if (coin.Top > Height)
                {
                    coin.Top = -coin.Height;
                    coin.Left = random.Next(0, Width - coin.Width);
                }

                int coinAppearZone = (panelGame.Width - coin.Width) / 3;

                if (mainCar.Bounds.IntersectsWith(coin.Bounds))
                {
                    coinsCollected++;
                    labelCoins.Text = "Coins: " + coinsCollected;

                    coin.Top = -coin.Height;
                    coin.Left = random.Next(index * coinAppearZone, index * coinAppearZone + coinAppearZone);
                }
            }
        }

        private void RaceGame_Load(object sender, EventArgs e)
        {
            GameLeftLanes = new List<Label>() { GameLeftLane1, GameLeftLane2, GameLeftLane3, GameLeftLane4, GameLeftLane5 };
            GameRightLanes = new List<Label>() { GameRightLane1, GameRightLane2, GameRightLane3, GameRightLane4, GameRightLane5 };

            MenuLeftLanes = new List<Label>() { MenuLeftLane1, MenuLeftLane2, MenuLeftLane3, MenuLeftLane4, MenuLeftLane5 };
            MenuRightLanes = new List<Label>() { MenuRightLane1, MenuRightLane2, MenuRightLane3, MenuRightLane4, MenuRightLane5 };

            coins = new List<PictureBox>() { Coin1, Coin2, Coin3 };

            towardCars = new List<PictureBox>() { towardCar1, towardCar2, towardCar3 };
            menuCars = new List<PictureBox>() { menuCar1, menuCar2, menuCar3 };

            timerRoad.Stop();
            timerTowardCars.Stop();
            panelMenu.Show();

            wplayer.currentPlaylist = GetPlaylist();
        }

        private IWMPPlaylist GetPlaylist()
        {
            var playlist = wplayer.playlistCollection.newPlaylist("playlist");

            try
            {
                string[] mp3Files = Directory.GetFiles("Resources/Sounds/", "*.mp3");
                Shuffle<string>(mp3Files);

                foreach (var file in mp3Files)
                    playlist.appendItem(wplayer.newMedia(file));
            }
            catch
            {

            }
            return playlist;
        }

        public void Shuffle<T>(Span<T> values)
        {
            int n = values.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int j = random.Next(i, n);

                if (j != i)
                {
                    T temp = values[i];
                    values[i] = values[j];
                    values[j] = temp;
                }
            }
        }

        private void RaceGame_KeyDown(object sender, KeyEventArgs e)
        {
            int sideMoveStep = 9;
            int maxSpeed = 21;

            switch (e.KeyCode)
            {
                case Keys.Right:
                    {
                        if (carSpeed != 0 && mainCar.Left <= ClientSize.Width)
                        {
                            mainCar.Left += sideMoveStep;

                            if (ClientSize.Width - mainCar.Left < mainCar.Width / 2)
                                mainCar.Left = mainCar.Left - ClientSize.Width;
                        }
                        break;
                    }
                case Keys.Left:
                    {
                        if (carSpeed != 0 && mainCar.Left >= -mainCar.Width / 2)
                        {
                            mainCar.Left -= sideMoveStep;

                            if (mainCar.Left < -mainCar.Width / 2)
                                mainCar.Left = ClientSize.Width - mainCar.Width / 2;
                        }
                        break;
                    }
                case Keys.Up:
                    {
                        if (carSpeed < maxSpeed)
                            carSpeed++;
                        break;
                    }
                case Keys.Down:
                    {
                        if (carSpeed > 0)
                            carSpeed--;
                        break;
                    }
                case Keys.Escape:
                    {
                        timerRoad.Enabled = false;
                        timerTowardCars.Enabled = false;
                        panelPause.Show();
                        break;
                    }
            }
        }

        private void timerTowardCars_Tick(object sender, EventArgs e)
        {
            int speedAddition = 2;
            foreach (var car in towardCars)
            {
                car.Top += carSpeed + speedAddition;

                if (car.Top > Height)
                {
                    car.Top = -car.Height;
                    car.Left = random.Next(0, Width - car.Width);
                }
                speedAddition++;

                if (mainCar.Bounds.IntersectsWith(car.Bounds))
                    GameOver();
            }
        }

        private void GameOver()
        {
            timerRoad.Stop();
            timerTowardCars.Stop();

            if (coinsCollected < coinsGameContinueCount)
            {
                MessageBox.Show("Game Over!", "Приехали!");
                panelPause.Show();
                panelMenu.Show();
            }
            else
            {
                var dialogResult = MessageBox.Show($"Продолжить? (-{coinsGameContinueCount} coins)", "Приехали!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    coinsCollected -= coinsGameContinueCount;
                    labelCoins.Text = "Coins: " + coinsCollected;

                    StartMotion();

                    return;
                }
                else
                {
                    panelPause.Show();
                    panelMenu.Show();
                }
            }

            GameResultStorage.Save(new GameResult(playerName, score, coinsCollected, DateTime.Now));
        }

        private void StartMotion()
        {
            carSpeed = 2;

            timerRoad.Start();
            timerTowardCars.Start();

            foreach (var car in towardCars)
            {
                car.Top = -car.Height;
                car.Left = random.Next(0, Width - car.Width);
            }
        }

        private void StartGame()
        {
            score = 0;
            coinsCollected = 0;

            StartMotion();

            panelPause.Hide();
            panelGame.Show();
            panelMenu.Hide();
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < laneSegmentCount; ++i)
            {
                MenuLeftLanes[i].Top += carSpeed;
                MenuRightLanes[i].Top += carSpeed;

                if (MenuLeftLanes[i].Top >= Height)
                    MenuLeftLanes[i].Top = -MenuLeftLanes[i].Height;

                if (MenuRightLanes[i].Top >= Height)
                    MenuRightLanes[i].Top = -MenuRightLanes[i].Height;
            }

            int speedAddition = 0;

            foreach (var car in menuCars)
            {
                car.Top += 3 + speedAddition;

                if (car.Top > Height)
                {
                    car.Top = -car.Height;
                    car.Left = random.Next(0, Width - car.Width);
                }
                speedAddition++;
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {

            timerRoad.Enabled = false;
            timerTowardCars.Enabled = false;
            panelPause.Show();
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            timerRoad.Enabled = true;
            timerTowardCars.Enabled = true;
            panelPause.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            panelMenu.Show();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm", HelpNavigator.TableOfContents);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!IsNameValid(playerNameTextBox.Text))
            {
                MessageBox.Show("Please, enter valid name!");
                return;
            }

            playerName = playerNameTextBox.Text == "Enter your name here" ? "unnamed" : playerNameTextBox.Text;

            StartGame();
            panelGame.Show();
            panelMenu.Hide();
        }

        private bool IsNameValid(string name)
        {
            if (name.Trim().Length <= 1)
                return false;

            foreach (char c in name)
                if (!char.IsLetter(c) && !char.IsDigit(c) && !char.IsWhiteSpace(c)) return false;

            return true;
        }

        private void buttonMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playerNameTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (!playerNameTextBoxFirstClicked)
                playerNameTextBox.Clear();
            playerNameTextBoxFirstClicked = true;
        }

        private void buttonScores_Click(object sender, EventArgs e)
        {
            new ResultsForm().ShowDialog();
        }

        private void RaceGame_Shown(object sender, EventArgs e)
        {
            playerNameTextBox.SelectAll();
            playerNameTextBox.Focus();

            wplayer.controls.play();
        }

        public static Bitmap CropImage(Image source, int x, int y, int width, int height)
        {
            Rectangle crop = new Rectangle(x, y, width, height);

            var bmp = new Bitmap(crop.Width, crop.Height);
            using (var gr = Graphics.FromImage(bmp))
                gr.DrawImage(source, new Rectangle(0, 0, bmp.Width, bmp.Height), crop, GraphicsUnit.Pixel);
            return bmp;
        }

        private void playerPausePictureBox_Click(object sender, EventArgs e)
        {
            wplayer.controls.pause();
        }

        private void playerStopPictureBox_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
        }

        private void playerPlayPictureBox_Click(object sender, EventArgs e)
        {
            wplayer.controls.play();
        }

        private void playerNextPictureBox_Click(object sender, EventArgs e)
        {
            wplayer.controls.next();
        }

        private void playerPreviousPictureBox_Click(object sender, EventArgs e)
        {
            wplayer.controls.previous();
        }
    }
}

