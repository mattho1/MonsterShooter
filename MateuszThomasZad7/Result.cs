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
    public partial class Result : Form
    {
        public delegate void ChangeTextLabel(string text);
        public delegate void UpdateDatagridviewFromList(List<MateuszThomas_Results> listResult);
        public delegate void UpdateDatagridviewFormTable(DataTable tabelResult);
        public delegate void BlockForm(bool block);
        public delegate void DisplayLabelStatement(bool block);
        /// <summary>
        /// Odwołanie do internetowej bazy danych
        /// </summary>
        OnlineDatabaseEntity context;
        /// <summary>
        /// Sprawdzenie czy jest połaczenie z bazą danych.
        /// </summary>
        bool isConnectedWithDatabase;
        public Result(OnlineDatabaseEntity context)
        {
            this.context = context;
            InitializeComponent();
            labelStatement.Visible = false;
            //LoadResultFromDatabase();
        }
        /// <summary>
        /// Pobranie wyników z bazy danych i załadowanie do datagrid.
        /// </summary>
        private void LoadResultFromDatabase()
        {
            BlockForm blockForm = new BlockForm(LockForm);
            DisplayLabelStatement displayLabel = new DisplayLabelStatement(DisplayStatement);

            this.BeginInvoke(blockForm, false);
            this.BeginInvoke(displayLabel, true);
            try
            {
                MateuszThomas_Results testObject = context.MateuszThomas_Results.FirstOrDefault();
                if (testObject != null)
                {
                    int maxPoint = (from max in context.MateuszThomas_Results select max).Max(c => c.Points);
                    List<MateuszThomas_Results> bestPlayers = (from players in context.MateuszThomas_Results where players.Points == maxPoint select players).ToList();
                    int minNumberShot = bestPlayers.Min(c => c.Shots);
                    MateuszThomas_Results bestPlayer = bestPlayers.Where(c => c.Shots == minNumberShot).First();
                    if (bestPlayer != null)
                    {
                        ChangeTextLabel changeBestResult = new ChangeTextLabel(UpdateLabelPoints);
                        ChangeTextLabel changeBestPlayer = new ChangeTextLabel(UpdateLabelBestPlayer);
                        labelPoints.BeginInvoke(changeBestResult, bestPlayer.Points.ToString());
                        labelNameBestPlayer.BeginInvoke(changeBestPlayer, bestPlayer.Name);
                    }
                }
                var results = (from result in context.MateuszThomas_Results select result).ToList();
                UpdateDatagridviewFromList updateDatagridview = new UpdateDatagridviewFromList(UpdateDatagridviewFormOnlinedatabase);
                dataGridViewResults.BeginInvoke(updateDatagridview, results.OrderByDescending(r => r.Points).ToList());
                isConnectedWithDatabase = true;
                }
                catch
                {
                        isConnectedWithDatabase = false;
                        MessageBox.Show("Brak połączenia z baza dnaych. Sprawdź połaczenie z internetem. Dane zostaną wczytane z lokalnego pliku.");
                        LoadDataFromLocalFile();
                }
            this.BeginInvoke(displayLabel, false);
            this.BeginInvoke(blockForm, true);
        }
        private void LockForm(bool block)
        {
            this.Enabled = block;
        }
        private void DisplayStatement(bool show)
        {
            labelStatement.Visible = show;
        }
        private void UpdateLabelBestPlayer(string text)
        {
            this.labelNameBestPlayer.Text = text;
        }
        private void UpdateLabelPoints(string text)
        {
            this.labelPoints.Text = text;
        }
        private void UpdateDatagridviewFormOnlinedatabase(List<MateuszThomas_Results> listResult)
        {
            dataGridViewResults.DataSource = listResult;
        }
        private void UpdateDatagridviewDataFormTable(DataTable tableResult)
        {
            dataGridViewResults.DataSource = tableResult;
        }
        /// <summary>
        /// Wczytanie wyników z lokalnego pliku z rezultatami.
        /// </summary>
        private void LoadDataFromLocalFile()
        {
            try
            {
                string bestPlayer = "";
                int bestPoints = -1;
                int bestShot = -1;
                StreamReader fileWithResult = new StreamReader("LocalResult.csv");
                String line;
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add(new DataColumn("ID", typeof(int)));
                dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
                dataTable.Columns.Add(new DataColumn("Points", typeof(int)));
                dataTable.Columns.Add(new DataColumn("Shot", typeof(int)));
                while ((line = fileWithResult.ReadLine()) != null)
                {
                    UpdateDatagridviewFormTable updateDatagridview = new UpdateDatagridviewFormTable(UpdateDatagridviewDataFormTable);
                    Char delimiter = ';';
                    String[] substrings = line.Split(delimiter);
                    DataRow dataRow = dataTable.NewRow();
                    dataRow[0] = 0;
                    dataRow[1] = substrings[0];
                    dataRow[2] = Int32.Parse(substrings[1]);
                    dataRow[3] = Int32.Parse(substrings[2]);
                    dataTable.Rows.Add(dataRow);
                    if(bestPoints < Int32.Parse(substrings[1]))
                    {
                        if (bestShot > Int32.Parse(substrings[2]))
                        {
                            bestPlayer = substrings[0];
                            bestPoints = Int32.Parse(substrings[1]);
                            bestShot = Int32.Parse(substrings[2]);
                        }
                    }
                    dataGridViewResults.BeginInvoke(updateDatagridview, dataTable);
                }
                fileWithResult.Close();
                ChangeTextLabel changeBestResult = new ChangeTextLabel(UpdateLabelPoints);
                ChangeTextLabel changeBestPlayer = new ChangeTextLabel(UpdateLabelBestPlayer);
                if (bestPoints != -1)
                {
                    labelPoints.BeginInvoke(changeBestResult, bestPoints.ToString());
                }else
                {
                    labelPoints.BeginInvoke(changeBestResult, "");
                }
                labelNameBestPlayer.BeginInvoke(changeBestPlayer, bestPlayer.ToString());
            }
            catch
            {
                MessageBox.Show("Brak pliku z lokalnymi rezultatami. [LocalResult.csv]");
            }
        }   

        /// <summary>
        /// Ustawienie szerokości poszczególnych kolumn w datagrid w celu bardziej estetycznego wyświetlenia.
        /// </summary>
        private void SetWidthColumn()
        {
            DataGridViewColumn columnID = dataGridViewResults.Columns[0];
            columnID.Width = 50;
            DataGridViewColumn columnName = dataGridViewResults.Columns[1];
            columnName.Width = 277;
            DataGridViewColumn columnPoints = dataGridViewResults.Columns[2];
            columnPoints.Width = 150;
            DataGridViewColumn columnShot = dataGridViewResults.Columns[3];
            columnShot.Width = 150;
        }
        /// <summary>
        /// Usunięcie wyników z bazy po wcześniejszej autoryzacji.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            AuthenticationWindow authenticationOperation = new AuthenticationWindow(this, 0, context);
            authenticationOperation.ShowDialog();
        }
        /// <summary>
        /// Zapisanie wyników z bazy danych do pliku csv.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveResult_Click(object sender, EventArgs e)
        {
            if (!textBoxFileName.Text.Equals(""))
            {
                CreateCSV();
                textBoxFileName.Text = "";
                MessageBox.Show("Zapisywanie danych do pliku");
            }
        }
        /// <summary>
        /// Utworzenie pliku CSV.
        /// </summary>
        private void CreateCSV()
        {
            string fileName;
            if (textBoxFileName.Text.Contains(".csv")){
                fileName = textBoxFileName.Text;
            }
            else
            {
                fileName = textBoxFileName.Text + ".csv";
            }
            try
            {
                StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8);
                if (writer != null)
                {
                    writer.WriteLine(@"Nick;Punkty;Strzały;");
                    for (int i = 0; i < dataGridViewResults.Rows.Count; i++)
                    {
                        writer.WriteLine(String.Format(@"{0};{1};{2}",
                            dataGridViewResults[1, i].Value.ToString(), dataGridViewResults[2, i].Value.ToString(),
                            dataGridViewResults[3, i].Value.ToString()));
                    }
                    writer.Close();
                }
            }
            catch
            {
                MessageBox.Show("Błąd podczas próby zapisu do pliku. Sprawdź czy plik nie jest otwarty przez inny program.");
            }
        }
        /// <summary>
        /// Załadowanie wyników z pliku do bazy danych po wcześniejszej autoryzacji.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoadResult_Click(object sender, EventArgs e)
        {
            AuthenticationWindow authenticationOperation = new AuthenticationWindow(this, 1, context);
            authenticationOperation.ShowDialog();
        }
        /// <summary>
        /// Usunięcie wyników z bazy danych.
        /// </summary>
        private void RemoveResults()
        {
            if (isConnectedWithDatabase)
            {
                List<MateuszThomas_Results> results = (from result in context.MateuszThomas_Results select result).ToList();
                for (int i = results.Count - 1; i >= 0; i--)
                {
                    MateuszThomas_Results result = results[i];
                    context.MateuszThomas_Results.Remove(result);
                    context.SaveChanges();
                }
                labelBestResult.Text = "brak";
                labelNameBestPlayer.Text = "brak";
            }
            else
            {
                MessageBox.Show("Brak połączenia z baza danych. Sprawdź połaczenie z internetem.");
            }
        }
        /// <summary>
        /// Wczytanie wyników z pliku do bazy danych.
        /// </summary>
        private void ReadResult()
        {
            if (isConnectedWithDatabase)
            {
                try
                {
                    if (!textBoxFileWithResult.Text.Contains(".csv"))
                    {
                        textBoxFileWithResult.Text += ".csv";
                    }
                    try
                    {
                        StreamReader fileWithResult = new StreamReader(textBoxFileWithResult.Text);
                        String line = fileWithResult.ReadLine();
                        while ((line = fileWithResult.ReadLine()) != null)
                        {
                            Char delimiter = ';';
                            String[] substrings = line.Split(delimiter);
                            MateuszThomas_Results result = new MateuszThomas_Results();
                            result.Name = substrings[0];
                            result.Points = Int32.Parse(substrings[1]);
                            result.Shots = Int32.Parse(substrings[2]);
                            context.MateuszThomas_Results.Add(result);
                            context.SaveChanges();
                        }
                        fileWithResult.Close();
                        textBoxFileWithResult.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Niepoprawny format wybranego pliku lub brak pliku. Plik z danymi musi być w formacie .csv.");
                    }
                }
                catch
                {
                    MessageBox.Show("Nie można odczytać pliku.");
                }
            }
            else
            {
                MessageBox.Show("Brak połączenia z baza danych. Sprawdź połaczenie z internetem.");
            }
        }
        /// <summary>
        /// Autoryzacja działania.
        /// </summary>
        /// <param name="typeAction"></param>
        /// <param name="isConsent"></param>
        public void Authentication(int typeAction, bool isConsent)
        {
            if(typeAction == 0)
            {
                if (isConsent)
                {
                    RemoveResults();
                    Thread thr = new Thread(LoadResultFromDatabase);
                    thr.Start();
                    //LoadResultFromDatabase();
                    dataGridViewResults.Refresh();
                }
            }
            if(typeAction == 1)
            {
                if (isConsent)
                {
                    ReadResult();
                    Thread thr = new Thread(LoadResultFromDatabase);
                    thr.Start();
                    //LoadResultFromDatabase();
                    dataGridViewResults.Refresh();
                }
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

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(LoadResultFromDatabase);
            thr.Start();
        }
    }
}
