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
        }

        private void RaceGame_KeyDown(object sender, KeyEventArgs e)
        {
            int sideMoveStep = 9;
            int maxSpeed = 21;

            switch (e.KeyCode)
            {
                case Keys.Right:
                    {
                        if (carSpeed != 0 && mainCar.Left <= ClientSize.Width - mainCar.Width)
                            mainCar.Left += sideMoveStep;
                        break;
                    }
                case Keys.Left:
                    {
                        if (carSpeed != 0 && mainCar.Left >= 0)
                            mainCar.Left -= sideMoveStep;
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
                }
                else
                {
                    panelPause.Show();
                    panelMenu.Show();
                }
            }
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
            StartGame();
            panelGame.Show();
            panelMenu.Hide();
        }

        private void buttonMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

