using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterShooter
{
    public partial class PropertiesPlayer : Form
    {
        public delegate void LoadPlayersNameFormOnlineDatabase(List<string> playerNames);
        public delegate void ChangeComboBox(string text);
        /// <summary>
        /// Okno rysowania avatara.
        /// </summary>
        DrawingAvatar windowDrawingAvatar;
        /// <summary>
        /// Okno robienia zdjęć kamerą.
        /// </summary>
        TakePicture windowTakePicture;
        /// <summary>
        /// Okno gry.
        /// </summary>
        Game windowGame;
        /// <summary>
        /// Zdjęcie avatara.
        /// </summary>
        Image avatarPicture;
        /// <summary>
        /// Odwołanie do internetowej bazy danych
        /// </summary>
        OnlineDatabaseEntity context;
        /// <summary>
        /// Lista zrobionych i narysowanych zdjęć.
        /// </summary>
        List<string> nameDrawingPictures;
        public PropertiesPlayer(OnlineDatabaseEntity context, List<string> nameDrawingPictures)
        {
            this.nameDrawingPictures = nameDrawingPictures;
            this.context = context;
            InitializeComponent();
            SetAvatar(pictureBoxAvatar.InitialImage);
            LoadComboBox();
            LoadDefaultMapAndMonster();
            //LoadPlayerName();
        }
        /// <summary>
        /// Załadowanie danych do textbox-ów
        /// </summary>
        private void LoadComboBox()
        {
            char[] enlargementJPG = { '.', 'j', 'p', 'g'};
            char[] enlargementPNG = { '.', 'p', 'n', 'g' };
            for (int i = 0; i < imageListMaps.Images.Count; i++)
            {
                comboBoxMaps.Items.Add(imageListMaps.Images.Keys[i].ToString().TrimEnd(enlargementJPG));
            }
            for (int i = 0; i < imageListMonsters.Images.Count; i++)
            {
                comboBoxMonsters.Items.Add(imageListMonsters.Images.Keys[i].ToString().TrimEnd(enlargementPNG));
            }
            for (int i = 0; i < nameDrawingPictures.Count; i++)
            {
                comboBoxPictureName.Items.Add(nameDrawingPictures[i]);
            }
        }
        /// <summary>
        /// Ustawienie domyślnej mapy i potworka.
        /// </summary>
        private void LoadDefaultMapAndMonster()
        {
            comboBoxMaps.Text = "Map0";
            pictureBoxMap.Image = imageListMaps.Images[0];
            comboBoxMonsters.Text = "Monster0";
            pictureBoxMonster.Image = imageListMonsters.Images[0];
        }
        /// <summary>
        /// Pobranie z bazy danych nicków graczy, którzy grali w grę.
        /// </summary>
        private void LoadPlayerName()
        {
            try
            {
                List<string> playerNames = (from players in context.MateuszThomas_Results select players.Name).Distinct().ToList();
                LoadPlayersNameFormOnlineDatabase loadPlayers = new LoadPlayersNameFormOnlineDatabase(LoadPlayerNamesFormdatabase);
                comboBoxPlayerNames.BeginInvoke(loadPlayers, playerNames);
                //comboBoxPlayerNames.DataSource = playerNames;
            }
            catch
            {
                ChangeComboBox loadText = new ChangeComboBox(LoadTextToComboBox);
                comboBoxPlayerNames.BeginInvoke(loadText, "");
            }
        }
        private void LoadTextToComboBox(string text)
        {
            this.comboBoxPlayerNames.Text = text;
        }
        private void LoadPlayerNamesFormdatabase(List<string> playerNames)
        {
            comboBoxPlayerNames.DataSource = playerNames;
        }
        /// <summary>
        /// Otwarcie okna do robienia zdjęć.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakePicture_Click(object sender, EventArgs e)
        {
            windowTakePicture = new TakePicture(this);
            Visible = false;
            windowTakePicture.ShowDialog();
            Visible = true;
        }
        /// <summary>
        /// Ustawienie avatara na zdjęcie podane jako argument. Załadowanie nowego zdjęcia lub obrazka do listy.
        /// </summary>
        /// <param name="avatarPicture"></param>
        public void SetAvatar(Image avatarPicture)
        {
            this.avatarPicture = avatarPicture;
            pictureBoxAvatar.Image = avatarPicture;
            if (avatarPicture.Tag != null)
            {
                comboBoxPictureName.Items.Add(avatarPicture.Tag.ToString());
                comboBoxPictureName.Text = avatarPicture.Tag.ToString();
                nameDrawingPictures.Add(comboBoxPictureName.Text);
            }
        }
        /// <summary>
        /// Ustawienie avatara na zdjęcie domyślne.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDefaultPicture_Click(object sender, EventArgs e)
        {
            SetAvatar(pictureBoxAvatar.InitialImage);
            comboBoxPictureName.Text = "";
        }
        /// <summary>
        /// Otwarcie okna rysowania.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPainting_Click(object sender, EventArgs e)
        {
            windowDrawingAvatar = new DrawingAvatar(this);
            Visible = false;
            windowDrawingAvatar.ShowDialog();
            Visible = true;
        }
        /// <summary>
        /// Otwarcie okna gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (!comboBoxPlayerNames.Text.Equals("") && !comboBoxPlayerNames.Text.Equals(" "))
            {
                windowGame = new Game(avatarPicture, pictureBoxMap.Image, pictureBoxMonster.Image, comboBoxPlayerNames.Text, context);
                Visible = false;
                windowGame.ShowDialog();
                Visible = true;
            }else
            {
                MessageBox.Show("Musisz podać jakiś nick.");
            }
        }
        /// <summary>
        /// Załadowanie wybranej mapy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxMap.Image = imageListMaps.Images[Int32.Parse(comboBoxMaps.Text.Remove(0,3))];
        }
        /// <summary>
        /// Załadowanie wybranego potworka.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxMonsters_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxMonster.Image = imageListMonsters.Images[Int32.Parse(comboBoxMonsters.Text.Remove(0, 7))];
        }
        /// <summary>
        /// Załadowanie wybranego zdjęcia avatara z listy wcześniej stworzonych.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxPictureName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!comboBoxPictureName.Text.Equals("")&& !comboBoxPictureName.Text.Equals(" "))
            {
                pictureBoxAvatar.Image = Image.FromFile(comboBoxPictureName.Text);
            }
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
        /// Obsługa przycisku zamykającego okno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLoadPlayerNames_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(LoadPlayerName);
            thr.Start();
        }
    }
}
