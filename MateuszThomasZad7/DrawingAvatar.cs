using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterShooter
{
    public partial class DrawingAvatar : Form
    {
        /// <summary>
        /// Okno ustawień. Wykorzystywane do zwrócenia narysowanego obrazka.
        /// </summary>
        PropertiesPlayer windowChoicePlayer;
        /// <summary>
        /// Kolor rysowania.
        /// </summary>
        Color drawingColor;
        /// <summary>
        /// Kontekst graficzny.
        /// </summary>
        Graphics graphics;
        /// <summary>
        /// Informacja czy jest wciśniety klawisz myszy i ma być rysowany obrazek.
        /// </summary>
        bool isDrawing;
        /// <summary>
        /// Rozmiar pędzla.
        /// </summary>
        int sizePen;
        /// <summary>
        /// Numer rysowanego obrazka podczas jednego uruchomienia gry.
        /// </summary>
        static int numberPicture = 0;
        public DrawingAvatar(PropertiesPlayer windowChoicePlayer)
        {
            this.windowChoicePlayer = windowChoicePlayer;
            InitializeComponent();
            sizePen = trackBarSizePen.Value;
            graphics = panelAvatar.CreateGraphics();
            
            //graphics = pictureBox1.CreateGraphics();
            drawingColor = Color.Black;
            isDrawing = false;
        }
        /// <summary>
        /// Ustawienie avatara i zamknięcie okna.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetAvatar_Click(object sender, EventArgs e)
        {
            int width = panelAvatar.Size.Width;
            int height = panelAvatar.Size.Height;
            Bitmap bmp = new Bitmap(panelAvatar.Width, panelAvatar.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Rectangle rectangle = new Rectangle(this.Location.X + 32, this.Location.Y + 81, 630, 1100);// pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
            graph.CopyFromScreen(rectangle.Location, Point.Empty, panelAvatar.Size);
            graph.Dispose();
            string fileName = "picture" + numberPicture + ".jpg";
            bmp.Save(fileName, ImageFormat.Jpeg);
            bmp.Tag = fileName;
            windowChoicePlayer.SetAvatar(bmp);
            numberPicture++;
            Close();
        }
        /// <summary>
        /// Ustawienie czarnego koloru rysowania.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonBlack_CheckedChanged(object sender, EventArgs e)
        {
            drawingColor = Color.Black;
        }
        /// <summary>
        /// Ustawienie czerwonego koloru rysowania.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            drawingColor = Color.Red;
        }
        /// <summary>
        /// Ustawienie niebieskiego koloru rysowania.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            drawingColor = Color.Blue;
        }
        /// <summary>
        /// Ustawienie szarego koloru rysowania.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonGray_CheckedChanged(object sender, EventArgs e)
        {
            drawingColor = Color.Silver;
        }
        /// <summary>
        /// Ustawienie pomarańczowego koloru rysowania.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonOrange_CheckedChanged(object sender, EventArgs e)
        {
            drawingColor = Color.Orange;
        }
        /// <summary>
        /// Ustawienie białego koloru rysowania.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonWhite_CheckedChanged(object sender, EventArgs e)
        {
            drawingColor = Color.White;
        }
        /// <summary>
        /// Ustawienie zielonego koloru rysowania.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            drawingColor = Color.Lime;
        }
        /// <summary>
        /// Ustawienie żółtego koloru rysowania.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonYellow_CheckedChanged(object sender, EventArgs e)
        {
            drawingColor = Color.Yellow;
        }
        /// <summary>
        /// Ustawienie białego koloru rysowania.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearPanel_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
        }
        /// <summary>
        /// Reakcja na wciśnięcie klawisza myszy na panelu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelAvatar_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            SolidBrush brush = new SolidBrush(drawingColor);
            graphics.FillEllipse(brush, e.X-5, e.Y-5, sizePen, sizePen);
        }
        /// <summary>
        /// reakcje na podniesienie klawisza myszy nad panelem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelAvatar_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
        /// <summary>
        /// Reakcja na ruch myszy nad panelem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelAvatar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                SolidBrush brush = new SolidBrush(drawingColor);
                graphics.FillEllipse(brush, e.X-5, e.Y-5, sizePen, sizePen);
            }
        }
        /// <summary>
        /// Przeźroczysty kolor rysowania.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonTransparentColor_CheckedChanged(object sender, EventArgs e)
        {
            drawingColor = Color.LavenderBlush;
        }
        /// <summary>
        /// Zmiana wielkości pędzla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarSizePen_Scroll(object sender, EventArgs e)
        {
            sizePen = trackBarSizePen.Value;
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
