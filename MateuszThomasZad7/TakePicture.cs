using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterShooter
{
    public partial class TakePicture : Form
    {
        // Zmienne pomocnicze do obsługi kamery
        static int numberPicture = 0;
        public const short WM_CAP = 0x400;
        public const int WM_CAP_DRIVER_CONNECT = 0x40a;
        public const int WM_CAP_DRIVER_DISCONNECT = 0x40b;
        public const int WM_CAP_EDIT_COPY = 0x41e;
        public const int WM_CAP_SET_PREVIEW = 0x432;
        public const int WM_CAP_SET_OVERLAY = 0x433;
        public const int WM_CAP_SET_PREVIEWRATE = 0x434;
        public const int WM_CAP_SET_SCALE = 0x435;
        public const int WM_CAP_SAVEDIB = WM_CAP + 25;
        public const int WS_CHILD = 0x40000000;
        public const int WS_VISIBLE = 0x10000000;
        public const short SWP_NOMOVE = 0x2;
        public const short SWP_NOZORDER = 0x4;

        public const short HWND_BOTTOM = 1;
        private int previewHandle;
        /// <summary>
        /// Kontekst do zwrócenia zrobionego zdjęcia.
        /// </summary>
        PropertiesPlayer windowChoicePalyer;
        // Funkcje do obsługi kamery.
        [DllImport("avicap32.dll")]
        public static extern bool capGetDriverDescription(
           short wDriverIndex,
           [MarshalAs(UnmanagedType.VBByRefStr)]ref String lpszName,
           int cbName,
           [MarshalAs(UnmanagedType.VBByRefStr)]ref String lpszVer,
           int cbVer
        );
        [DllImport("user32")]
        public static extern int SendMessage(
          int hWnd,
          int Msg,
          int wParam,
          string lParam
        );
        [DllImport("user32")]
        public static extern bool DestroyWindow(int hwnd);
        [DllImport("avicap32.dll")]
        public static extern int capCreateCaptureWindow(
           string lpszWindowName,
           int dwStyle,
           int x,
           int y,
           int nWidth,
           int nHeight,
           int hWnd,
           int nID
        );

        [DllImport("user32")]
        public static extern bool SetWindowPos(
          int hWnd,
          int hWndInsertAfter,
          int X,
          int Y,
          int cx,
          int cy,
          int uFlags
        );

        public TakePicture(PropertiesPlayer windowChoicePalyer)
        {
            this.windowChoicePalyer = windowChoicePalyer;
            InitializeComponent();
            LockTakePhoto();
            LockSetAvatar();
        }
        /// <summary>
        /// Zwraca listę dostępnych kamer.
        /// </summary>
        /// <returns></returns>
        public ArrayList returnDeviceList()
        {
            ArrayList urzadzenia = new ArrayList();
            bool czyWszystkieUrzadzenia = false;

            for (int i = 0; i < 5 && !czyWszystkieUrzadzenia; i++)
            {
                string nazwa = String.Empty.PadRight(100);
                string wersja = String.Empty.PadRight(100);

                czyWszystkieUrzadzenia = capGetDriverDescription((short)i, ref nazwa, 100, ref wersja, 100);
                urzadzenia.Add(nazwa);
            }

            return urzadzenia;
        }
        /// <summary>
        /// Załadowanie dostępnych urządzeń do zrobienia zdjęcia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TakePicture_Load(object sender, EventArgs e)
        {
            int numberDevice = 0;
            foreach (string nazwaUrzadzenia in returnDeviceList())
            {
                comboBoxCamera.Items.Add(nazwaUrzadzenia);
                numberDevice++;
            }
            if (numberDevice == 0)
            {
                MessageBox.Show("Brak urządzeń mogących zrobić zdjęcie podpiętych do komputera.");
                Close();
            }
        }
        /// <summary>
        /// Zrobienie zdjęcia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakePicture_Click(object sender, EventArgs e)
        {
            string namePicture = "takePhoto" + numberPicture + ".jpg";
            numberPicture++;
            SendMessage(previewHandle, WM_CAP_SAVEDIB, comboBoxCamera.SelectedIndex, namePicture);
            pictureBoxTakePicture.Image = Image.FromFile(namePicture);
            pictureBoxTakePicture.Image.Tag = namePicture;
            UnlockSetAvatar();
        }
        /// <summary>
        /// Wybranie urządzenai do zrobienia zdjęcia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedDeviceIndex = comboBoxCamera.SelectedIndex;
            IntPtr pbViewHandle = pictureBoxCameraImage.Handle; // uchwyt do okna 

            DestroyWindow(previewHandle); // zmiana wybranej kamery

            previewHandle = capCreateCaptureWindow("Obraz", WS_VISIBLE | WS_CHILD, 0, 0, 400, 500, pbViewHandle.ToInt32(), 0);

            if (SendMessage(previewHandle, WM_CAP_DRIVER_CONNECT, selectedDeviceIndex, null) != 0)
            {
                SendMessage(previewHandle, WM_CAP_SET_SCALE, 1, null);
                SendMessage(previewHandle, WM_CAP_SET_PREVIEWRATE, 30, null);
                SendMessage(previewHandle, WM_CAP_SET_PREVIEW, 1, null);

                SetWindowPos(previewHandle, HWND_BOTTOM, 0, 0, pictureBoxCameraImage.Height, pictureBoxCameraImage.Width, SWP_NOMOVE | SWP_NOZORDER);
            }
            UnlockTakePhoto();
        }
        /// <summary>
        /// Zablokowanie próby zrobienia zdjęcia przed wybraniem urządzenai do robienia zdjęć. 
        /// </summary>
        private void LockTakePhoto()
        {
            buttonTakePicture.Enabled = false;
        }
        /// <summary>
        /// Odblokowanie możliwości zrobienia zdjęcia.
        /// </summary>
        private void UnlockTakePhoto()
        {
            buttonTakePicture.Enabled = true;
        }
        /// <summary>
        /// Zablokowanie próby załadowania nieistniejącego zdjęcia do avatara.
        /// </summary>
        private void LockSetAvatar()
        {
            buttonSetAvatar.Enabled = false;
        }
        /// <summary>
        /// Odblokowanie możliwości ząłdowania zdjęcia do avatara.
        /// </summary>
        private void UnlockSetAvatar()
        {
            buttonSetAvatar.Enabled = true;
        }
        /// <summary>
        /// Ustawienie zrobionego zdjęcia jako avatar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetAvatar_Click(object sender, EventArgs e)
        {
            windowChoicePalyer.SetAvatar(pictureBoxTakePicture.Image);
            Close();
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
