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
    public partial class StartWindow : Form
    {
        /// <summary>
        /// Licznik taktów zegara do zamknięcia okna. 
        /// </summary>
        int timeToStartGame = 4;
        public StartWindow()
        {
            InitializeComponent();
            timerStartWindow.Start();
        }
        /// <summary>
        /// Odmierzanie czasu do zamknięcia okna z nazwą gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerStartWindow_Tick(object sender, EventArgs e)
        {
            timeToStartGame--;
            if (timeToStartGame == 0)
            {
                Menu menu = new Menu();
                menu.Show();
                timerStartWindow.Stop();
                this.Visible = false;
            }
        }

        private void bunifuImageButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
