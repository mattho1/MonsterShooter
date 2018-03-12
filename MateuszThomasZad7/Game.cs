using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterShooter
{
    public partial class Game : Form
    {
        /// <summary>
        /// Nazwa gracza
        /// </summary>
        string login;
        /// <summary>
        /// Avatar gracza
        /// </summary>
        Image avatar;
        /// <summary>
        /// Czas gry
        /// </summary>
        int gameTime;
        /// <summary>
        /// Punkty zdobyte przez gracza
        /// </summary>
        int points;
        /// <summary>
        /// Liczba strzałów
        /// </summary>
        int counterShot;
        /// <summary>
        /// Aktualny bonus
        /// </summary>
        int bonus;
        /// <summary>
        /// Licznik taktów zegara do zaniku bonusu
        /// </summary>
        int counterBonusTime;
        /// <summary>
        /// Zmienna informujaca czy ma być dźwięk strzału
        /// </summary>
        bool playSound;
        /// <summary>
        /// Losowa zmienna określająca współrzedna X potworka
        /// </summary>
        Random randomNumberFirst = new Random();
        /// <summary>
        /// Losowa zmienna określająca współrzedna Y potworka
        /// </summary>
        Random randomNumberSecond = new Random();
        /// <summary>
        /// Zmienna przechowująca dźwięk strzału
        /// </summary>
        System.Media.SoundPlayer soundClick = new System.Media.SoundPlayer();
        /// <summary>
        /// Odwołanie do internetowej bazy danych
        /// </summary>
        OnlineDatabaseEntity context;
        /// <summary>
        /// Zdjęcie mapy
        /// </summary>
        private Image mapPicture;
        /// <summary>
        /// Zdjęcie potworka
        /// </summary>
        private Image monsterPicture;
        /// <summary>
        /// Zmienna informująca czy gra jest zatrzymana
        /// </summary>
        private bool pause;
        /// <summary>
        /// Zmienna informuje czy okno jest powiekszone
        /// </summary>
        private bool isMaximized;
        private int shotWithoutIncreaseSpeed;
        public Game(Image avatar, Image map, Image monster, string login, OnlineDatabaseEntity context)
        {
            shotWithoutIncreaseSpeed = 0;
            isMaximized = false;
            pause = false;
            playSound = true;
            mapPicture = map;
            monsterPicture = monster;
            this.context = context;
            InitializeComponent();
            pictureBoxMonster.Image = monster;
            pictureBoxMonsterSecond.Image = monster;
            BackgroundImage = map;
            pictureBoxMonsterSecond.Enabled = false;
            pictureBoxMonsterSecond.Visible = false;
            labelPlayer.BackColor = Color.Transparent;
            labelLogin.BackColor = Color.Transparent;
            labelGameTime.BackColor = Color.Transparent;
            labelShotResult.BackColor = Color.Transparent;
            bonus = 1;
            gameTime = 600;
            points = 0;
            counterShot = 0;
            ChangePositionFirstMonster();
            ChangePositionSecondMonster();
            timerGameTime.Start();
            timerLocationMonster.Start();
            SetUser(login, avatar);
        }
        /// <summary>
        /// Ustawienie danych o użytkowniku
        /// </summary>
        /// <param name="login"></param>
        /// <param name="avatar"></param>
        private void SetUser(String login, Image avatar)
        {
            this.login = login;
            this.avatar = avatar;
            pictureBoxAvatar.Image = avatar;
            labelLogin.Text = login;
        }
        /// <summary>
        /// Zegar odmierzający czas gry i nadzorujacy zdarzenia w grze.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerGameTime_Tick(object sender, EventArgs e)
        {
            labelGameTime.Text = "" + gameTime / 10 + "," + gameTime % 10;
            gameTime--;
            if(gameTime < 100)
            {
                labelGameTime.ForeColor = Color.Red;
            }
            if(gameTime == 300)
            {
                timerSecondMonster.Interval = timerLocationMonster.Interval;
                timerSecondMonster.Interval += 100;
                timerSecondMonster.Start();
                pictureBoxMonsterSecond.Enabled = true;
                pictureBoxMonsterSecond.Visible = true;
            }
            if(gameTime < 0)
            {
                EndGame();
            }
        }
        /// <summary>
        /// Zakończenie gry i podsumowanie. Zapis wyniku do bazy danych.
        /// </summary>
        private void EndGame()
        {
            shotWithoutIncreaseSpeed = 0;
            buttonPause.Enabled = false;
            buttonStop.Enabled = false;
            timerGameTime.Stop();
            timerLocationMonster.Stop();
            timerSecondMonster.Stop();
            MessageBox.Show("Koniec gry!\n Twój wynik: " + points);
            Pause();
            Thread thr = new Thread(showMessage);
            thr.Start();
            SaveResult();
            gameTime = 600;
            points = 0;
            counterShot = 0;
            bonus = 1;
            timerLocationMonster.Interval = 2500;
            timerSecondMonster.Interval = 2500;
            labelGameTime.ForeColor = Color.Black;
            labelGameTime.Text = "" + gameTime / 10 + "," + gameTime % 10;
        }
        private void showMessage()
        {
            MessageBox.Show("Zapisywanie wyniku.");
        }
        /// <summary>
        /// Zapis wyniku do bazy danych.
        /// </summary>
        private void SaveResult()
        {
            try
            {
                MateuszThomas_Results result = new MateuszThomas_Results();
                result.Name = login;
                result.Points = points;
                result.Shots = Int32.Parse(labelNumberShot.Text);
                context.MateuszThomas_Results.Add(result);
                context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Wynik nie został zapisany w bazie danych ponieważ nie ma połączenia z internetem. Wynik zapisany lokalnie na komputerze.");
                SaveResultLocal();
            }
        }
        /// <summary>
        /// Zapis wyniku do lokalnego pliku z wynikami.
        /// </summary>
        private void SaveResultLocal()
        {
            try
            {
                StreamWriter writer = new StreamWriter("LocalResult.csv", true, Encoding.UTF8);
                writer.WriteLine(String.Format(@"{0};{1};{2}",
                login, points,
                Int32.Parse(labelNumberShot.Text)));
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Błąd podczas próby zapisu do pliku. Sprawdź czy plik nie jest otwarty przez inny program.");
            }
        }
        /// <summary>
        /// Reakcja na wciśnięcie przycisku myszy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game_MouseDown(object sender, MouseEventArgs e)
        {
            if (!pause)
            {
                labelShotResult.ForeColor = Color.Red;
                labelShotResult.Text = "Pudło!";
                Shot();
            }
        }
        /// <summary>
        /// Reakcja na trafienie w potworka.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxMonster_MouseDown(object sender, MouseEventArgs e)
        {
            if (!pause)
            {
                labelShotResult.ForeColor = Color.Black;
                labelShotResult.Text = "Trafiony!";
                if (timerLocationMonster.Interval > 200)
                {
                    if(timerLocationMonster.Interval > 400)
                    {
                        timerLocationMonster.Interval -= 150;
                        timerSecondMonster.Interval -= 150;
                    }else
                    {
                        shotWithoutIncreaseSpeed++;
                        timerLocationMonster.Interval -= 15;
                        timerSecondMonster.Interval -= 15;
                    }
                }else
                {
                    shotWithoutIncreaseSpeed++;
                }
                points = points + bonus;
                SetBonus();
                Shot();
                labelResult.Text = points.ToString();
                ChangePositionFirstMonster();
            }
        }
        /// <summary>
        /// ustawienie bonusu za trafienie.
        /// </summary>
        private void SetBonus()
        {
            counterBonusTime = 20;
            progressBarBonus.Value = counterBonusTime;
            bonus++;
            labelBonus.Text = "x" + bonus;
            timerBonus.Stop();
            timerBonus.Start();
        }
        /// <summary>
        /// Obsługa trafienia w potworka. Odtworzenie dźwięku strzału i zwiększenie liczby oddanych strzałów.
        /// </summary>
        private void Shot()
        {
            counterShot++;
            labelNumberShot.Text = counterShot.ToString();
            try
            {
                if (playSound)
                {
                    soundClick.SoundLocation = "pistolShot.wav";
                    soundClick.Play();
                }
            }catch
            {
                playSound = false;
                buttonMute.BackgroundImage = imageListSound.Images[0];
            }
            
        }
        /// <summary>
        /// Zmiana pozycji pierwszego potworka.
        /// </summary>
        private void ChangePositionFirstMonster()
        {
            Point newLocation = new Point(randomNumberFirst.Next(20, 900), randomNumberSecond.Next(450, 650));
            Point secondMonsterLocation = pictureBoxMonsterSecond.Location;
            if (Math.Sqrt(Math.Pow((newLocation.X-secondMonsterLocation.X),2) + Math.Pow((newLocation.Y - secondMonsterLocation.Y), 2)) < 182)
            {
                newLocation.X -= 200;
                if(newLocation.X < 0)
                {
                    newLocation.X += 400;
                }
                newLocation.Y -= 200;
                if (newLocation.Y > 600)
                {
                    newLocation.Y += 400;
                }
            }
            pictureBoxMonster.Location = newLocation;
        }
        /// <summary>
        /// Zmiana pozycji drugiego potworka.
        /// </summary>
        private void ChangePositionSecondMonster()
        {
            Point newLocation = new Point(randomNumberFirst.Next(20, 900), randomNumberSecond.Next(450, 650));
            Point firstMonsterLocation = pictureBoxMonster.Location;
            if (Math.Sqrt(Math.Pow((newLocation.X - firstMonsterLocation.X), 2) + Math.Pow((newLocation.Y - firstMonsterLocation.Y), 2)) < 182)
            {
                newLocation.X -= 200;
                if (newLocation.X < 0)
                {
                    newLocation.X += 400;
                }
                newLocation.Y -= 200;
                if (newLocation.Y > 600)
                {
                    newLocation.Y += 400;
                }
            }
            pictureBoxMonsterSecond.Location = newLocation;
        }
        /// <summary>
        /// Licznik odmierzający czas do zmiany pozycji pierwszego potworka.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerLocationMonster_Tick(object sender, EventArgs e)
        {
            ChangePositionFirstMonster();
        }
        /// <summary>
        /// Licznik odmierzający czas trwania bonusu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBonus_Tick(object sender, EventArgs e)
        {
            counterBonusTime--;
            progressBarBonus.Value = counterBonusTime;
            if (counterBonusTime == 0)
            {
                timerSecondMonster.Interval += (bonus -1 - shotWithoutIncreaseSpeed) * 120;
                timerLocationMonster.Interval += (bonus -1 - shotWithoutIncreaseSpeed) * 120;
                shotWithoutIncreaseSpeed = 0;
                int test1 = timerSecondMonster.Interval;
                int test2 = timerLocationMonster.Interval;
                bonus = 1;
                labelBonus.Text = "x" + bonus;
                timerBonus.Stop();
            }
        }
        /// <summary>
        /// Reakcja na trafienie drugiego potworka.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxMonsterSecond_MouseDown(object sender, MouseEventArgs e)
        {
            if (!pause)
            {
                labelShotResult.ForeColor = Color.Black;
                labelShotResult.Text = "Trafiony!";
                if (timerSecondMonster.Interval > 200)
                {
                    if (timerSecondMonster.Interval > 400)
                    {
                        timerLocationMonster.Interval -= 150;
                        timerSecondMonster.Interval -= 150;
                    }
                    else
                    {
                        shotWithoutIncreaseSpeed++;
                        timerLocationMonster.Interval -= 15;
                        timerSecondMonster.Interval -= 15;
                    }
                }
                else
                {
                    shotWithoutIncreaseSpeed++;
                }
                Shot();
                points = points + bonus;
                SetBonus();
                labelResult.Text = points.ToString();
                ChangePositionSecondMonster();
            }
        }
        /// <summary>
        /// Licznik odmierzający czas do zmiany pozycji drugiego potworka.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerSecondMonster_Tick(object sender, EventArgs e)
        {
            ChangePositionSecondMonster();
        }
        /// <summary>
        /// Wyciczenie dźwięku strzałów.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMute_Click(object sender, EventArgs e)
        {
            playSound = !playSound;
            if (playSound)
            {
                buttonMute.BackgroundImage = imageListSound.Images[1];
            }else
            {
                buttonMute.BackgroundImage = imageListSound.Images[0];
            }
        }
        /// <summary>
        /// Przerwanie gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            Pause();
            DialogResult messageBoxResult = MessageBox.Show("Na pewno chcesz wyjść? Uzyskany wynik zostanie utracony.", "Zatrzymanie gry", MessageBoxButtons.YesNo);
            if (messageBoxResult == DialogResult.Yes)
            {
                this.Close();
            }
            Resume();
        }
        /// <summary>
        /// Zatrzymanie gry.
        /// </summary>
        private void Pause()
        {
            labelPauseText.Visible = true;
            timerBonus.Stop();
            timerGameTime.Stop();
            timerLocationMonster.Stop();
            timerSecondMonster.Stop();
            pause = true;
        }
        /// <summary>
        /// Wznowienie gry.
        /// </summary>
        private void Resume()
        {
            if(counterBonusTime > 0)
            {
                timerBonus.Start();
            }
            timerGameTime.Start();
            timerLocationMonster.Start();
            timerSecondMonster.Start();
            ChangePositionFirstMonster();
            ChangePositionSecondMonster();
            labelPauseText.Visible = false;
            pause = false;
        }
        /// <summary>
        /// Obsługa przycisku zatrzymującego grę.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (pause)
            {
                Resume();
                buttonPause.Text = "PAUSE";
            }
            else
            {
                Pause();
                buttonPause.Text = "RESUME";
            }
        }
        /// <summary>
        /// Zmiana wyglądu kursora myszy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
        }
        /// <summary>
        /// Rozpoczecie gry od nowa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Pause();
            DialogResult messageBoxResult = MessageBox.Show("Na pewno chcesz rozpocząć od nowa?", "Nowa gra", MessageBoxButtons.YesNo);
            if (messageBoxResult == DialogResult.Yes)
            {
                shotWithoutIncreaseSpeed = 0;
                buttonPause.Enabled = true;
                buttonStop.Enabled = true;
                pause = false;
                playSound = true;
                pictureBoxMonsterSecond.Enabled = false;
                pictureBoxMonsterSecond.Visible = false;
                bonus = 1;
                gameTime = 600;
                points = 0;
                counterShot = 0;
                labelBonus.Text = bonus.ToString();
                labelNumberShot.Text = "0";
                labelResult.Text = "0";
                ChangePositionFirstMonster();
                ChangePositionSecondMonster();
                timerLocationMonster.Interval = 2500;
                timerSecondMonster.Interval = 2500;
                timerGameTime.Start();
                timerLocationMonster.Start();
            }
            Resume();
        }
        /// <summary>
        /// Zatrzymanie gry czyli wszystkich timerów wraz z zamykaniem okna. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Pause();
        }
        /// <summary>
        /// Obsługa przycisku zamykającego okno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Obśługa przycisku minimalizującego okno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Obśługa przycisku maksymalizuje okno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButtonMiximizedWindow_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal;
                bunifuImageButtonMiximizedWindow.Image = imageListIconSizeWindow.Images[0];
                isMaximized = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                bunifuImageButtonMiximizedWindow.Image = imageListIconSizeWindow.Images[1];
                isMaximized = true;
            }
        }
    }
}
