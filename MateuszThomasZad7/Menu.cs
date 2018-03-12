using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterShooter
{
    public partial class Menu : Form
    {
        /// <summary>
        /// Okno ustawień gry i przejścia do gry.
        /// </summary>
        PropertiesPlayer windowChoicePlayer;
        /// <summary>
        /// Okno informacji o grze takich jak zasady.
        /// </summary>
        Information windowInformationAboutGame;
        /// <summary>
        /// Rezultaty wcześniejszych gier.
        /// </summary>
        Result windowResults;
        /// <summary>
        /// Odwołanie do internetowej bazy danych
        /// </summary>
        OnlineDatabaseEntity context;
        /// <summary>
        /// Lista nazw plików z utowrzonymi podczas gry avatarami.
        /// </summary>
        List<string> nameDrawingPictures;
        public Menu()
        {
            context = new OnlineDatabaseEntity();
            nameDrawingPictures = new List<string>();
            InitializeComponent();
        }
        /// <summary>
        /// Wyświetlenie okna ustawień i przejście do gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayGame_Click(object sender, EventArgs e)
        {
            windowChoicePlayer = new PropertiesPlayer(context, nameDrawingPictures);
            this.Visible = false;
            windowChoicePlayer.ShowDialog();
            this.Visible = true;
        }
        /// <summary>
        /// Wyświetlenie okna rezultatów.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResults_Click(object sender, EventArgs e)
        {
            windowResults = new Result(context);
            this.Visible = false;
            windowResults.ShowDialog();
            this.Visible = true;
        }
        /// <summary>
        /// Wyświetlenie informacji o grze.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInformation_Click(object sender, EventArgs e)
        {
            windowInformationAboutGame = new Information();
            this.Visible = false;
            windowInformationAboutGame.ShowDialog();
            this.Visible = true;
        }
        /// <summary>
        /// Zamknięcie gry po zamknięciu tego okna.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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
    }
}
