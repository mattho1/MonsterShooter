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
    public partial class AuthenticationWindow : Form
    {
        /// <summary>
        /// Kontekst do zwrócenia informacji o poprawnej lub nie poprawnej autoryzacji działania.
        /// </summary>
        Result resultWindow;
        /// <summary>
        /// Typ działania.
        /// </summary>
        int typeAction;
        /// <summary>
        /// Odwołanie do internetowej bazy danych
        /// </summary>
        OnlineDatabaseEntity context;
        /// <summary>
        /// Hasło domyślne
        /// </summary>
        string defaultPassword;
        public AuthenticationWindow(Result resultWindow, int typeAction, OnlineDatabaseEntity context)
        {
            defaultPassword = "#Admin1234#";
            this.context = context;
            this.typeAction = typeAction;
            this.resultWindow = resultWindow;
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }
        /// <summary>
        /// Sprawdzenie poprawności wprowadzonego hasła.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (CheckPassword(textBoxPassword.Text))
            {
                MessageBox.Show("Poprawne hasło. Operacja zostnaie wykonana ale może chwilę potrwać.");
                resultWindow.Authentication(typeAction, true);
                this.Close();
            }
            else
            {
                MessageBox.Show("Niepoprawne hasło");
            }
        }
        /// <summary>
        /// Sprawdzenie w bazie danych czy jest podane hasło.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool CheckPassword(string password)
        {
            try
            {
                EncryptedWord encryptedWord = new EncryptedWord(password);
                var foundID = (from record in context.MateuszThomas_Passwords where record.Password == encryptedWord.word select record.ID.ToString()).FirstOrDefault();
                if ((foundID != null)||defaultPassword.Equals(password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch
            {
                MessageBox.Show("Brak połączenia z bazą danych. Autoryzacja możliwa tylko z hasłem administratora.");
                if (defaultPassword.Equals(password))
                {
                    return true;
                }else
                {
                    return false;
                }
            }
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
