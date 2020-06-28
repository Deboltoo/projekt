using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Projekt
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            /// <summary>
            /// Start odtwarzania muzyki, przy satrcie programu.
            /// </summary>
            PlaySimpleSound();
            /// <summary>
            /// Dodawanie 40 nowych EventHandler dla przyciskow typu Radiobutton, pomaga to z późniejszą weryfikacją, który z 40 radiobuttonów jest aktywny.
            /// </summary>
            radioButton1.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton1.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton4.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton5.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton6.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton7.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton8.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton9.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton10.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton11.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton12.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton13.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton14.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton15.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton16.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton17.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton18.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton19.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton20.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton21.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton22.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton23.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton24.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton25.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton26.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton27.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton28.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton29.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton30.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton31.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton32.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton33.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton34.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton35.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton36.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton37.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton38.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton39.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            radioButton40.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
        }
        /// <summary>
        /// Wyswietlanie nazwy postaci, po nacisnieciu radiobuttona.
        /// </summary>
        public void ARadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                /// <summary>
                /// Czyszczenie wyświelanych nazw i obrazków ze skinami postaci po zmianie radiobuttonu.
                /// </summary>
                if (radioButton.Checked)
                {
                    label1.Text = "" + radioButton.Tag;
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                    pictureBox3.Image = null;
                }
            }
        }
        /// <summary>
        /// Odtwarzacz muzyki w tle.
        /// </summary>
        public void PlaySimpleSound()
        {
            /// <summary>
            /// Znajdowanie aktualnej ścieżki działania programu.
            /// </summary>
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            /// <summary>
            /// Dodanie do aktualnej ścieżki nakierowanie na odpowiedni plik muzyczny do odtworzenia przy starcie programu.
            /// </summary>
            SoundPlayer simpleSound = new SoundPlayer(string.Format("{0}Resources\\" + "Dead_by_Daylight_Theme_Soundtrack.wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\"))));
            /// <summary>
            /// Odtworzenie muzyki w pętli.
            /// </summary>
            simpleSound.PlayLooping();

        }

        Random random = new Random();
        /// <summary>
        /// Przycisk aktywujący losowanie.
        /// </summary>
        public void Button1_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Sprawdzanie, który checkbox jest aktywny.
            /// </summary>
            var checkedButton = Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            try
            {
                label2.Text = "";
                /// <summary>
                /// Jeżeli jest zaznaczony, któryś z checkboxów to aktywuje się skrypt losowania.
                /// </summary>
                if (checkedButton.Checked == true)
                {
                    /// <summary>
                    /// Znajdowanie aktualnej lokalizacji programu na komputerze.
                    /// </summary>
                    string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                    /// <summary>
                    /// Lokalizowanie folderu z plikami
                    /// </summary>
                    string nazwafolderu = Path.GetDirectoryName(string.Format("{0}Resources\\dbd\\" + checkedButton.AccessibleName + "\\" + checkedButton.AccessibleDescription + "1", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\"))));

                    /// <summary>
                    /// Odczytywanie plików gdzie ich nazwa kończy się na "_Head" + jakiś numer i dodawanie ich do tablicy.
                    /// </summary>
                    string[] iloscplikow1 = Directory.GetFiles(string.Format("{0}Resources\\dbd\\" + checkedButton.AccessibleName, Path.GetFullPath(Path.Combine(RunningPath, @"..\..\"))),
                        "*_Head*", SearchOption.AllDirectories);
                    /// <summary>
                    /// Losowanie numeru, zaczyna się od nr 1, a kończy na ostatnim pliku w tablicy.
                    /// </summary>
                    int randomnumber1 = random.Next(1, iloscplikow1.Length + 1);
                    /// <summary>
                    /// Nastawianie ścieżki pliku na nowo wylosowany plik.
                    /// </summary>
                    string filePath1 = string.Format(nazwafolderu + "\\" + checkedButton.AccessibleName + "_Head" + randomnumber1 + ".png");
                    /// <summary>
                    /// Zmiana wyświetlanego zdjęcia dla 1 pictureboxa, na wylosowany nowy plik.
                    /// </summary>
                    pictureBox1.Image = Image.FromFile(filePath1);

                    /// <summary>
                    /// Odczytywanie plików gdzie ich nazwa kończy się na "_Torso" + jakiś numer i dodawanie ich do tablicy.
                    /// </summary>
                    string[] iloscplikow2 = Directory.GetFiles(string.Format("{0}Resources\\dbd\\" + checkedButton.AccessibleName, Path.GetFullPath(Path.Combine(RunningPath, @"..\..\"))),
                        "*_Torso*", SearchOption.AllDirectories);
                    /// <summary>
                    /// Losowanie numeru, zaczyna się od nr 1, a kończy na ostatnim pliku w tablicy.
                    /// </summary>
                    int randomnumber2 = random.Next(1, iloscplikow2.Length + 1);
                    /// <summary>
                    /// Nastawianie ścieżki pliku na nowo wylosowany plik.
                    /// </summary>
                    string filePath2 = string.Format(nazwafolderu + "\\" + checkedButton.AccessibleName + "_Torso" + randomnumber2 + ".png");
                    /// <summary>
                    /// Zmiana wyświetlanego zdjęcia dla 1 pictureboxa, na wylosowany nowy plik.
                    /// </summary>
                    pictureBox2.Image = Image.FromFile(filePath2);

                    /// <summary>
                    /// Odczytywanie plików gdzie ich nazwa kończy się na "_Nogi" + jakiś numer i dodawanie ich do tablicy.
                    /// </summary>
                    string[] iloscplikow3 = Directory.GetFiles(string.Format("{0}Resources\\dbd\\" + checkedButton.AccessibleName, Path.GetFullPath(Path.Combine(RunningPath, @"..\..\"))),
                        "*_Nogi*", SearchOption.AllDirectories);
                    /// <summary>
                    /// Losowanie numeru, zaczyna się od nr 1, a kończy na ostatnim pliku w tablicy.
                    /// </summary>
                    int randomnumber3 = random.Next(1, iloscplikow3.Length + 1);
                    /// <summary>
                    /// Nastawianie ścieżki pliku na nowo wylosowany plik.
                    /// </summary>
                    string filePath3 = string.Format(nazwafolderu + "\\" + checkedButton.AccessibleName + "_Nogi" + randomnumber3 + ".png");
                    /// <summary>
                    /// Zmiana wyświetlanego zdjęcia dla 1 pictureboxa, na wylosowany nowy plik.
                    /// </summary>
                    pictureBox3.Image = Image.FromFile(filePath3);


                }

            }
            /// <summary>
            /// Jeżeli nie ma plików, lub mają błędną nazwę, to program wyświetla informację o tym.
            /// </summary>
            catch (Exception)
            {
                label1.Text = "";
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                label2.Text = "Brakuje plików lub jest niepoprawna nazwa!";
            }
        }

        bool on = true;
        /// <summary>
        /// Zmiana stron z dostępnymi radiobuttonami "ludzie/potwory".
        /// </summary>
        public void Button2_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Zamiana wyświetlanych radiobuttonow na "potwory".
            /// </summary>
            if (on)
            {
                button2.Image = Projekt.Properties.Resources.zmiana2;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                radioButton12.Visible = false;
                radioButton13.Visible = false;
                radioButton14.Visible = false;
                radioButton15.Visible = false;
                radioButton16.Visible = false;
                radioButton17.Visible = false;
                radioButton18.Visible = false;
                radioButton19.Visible = false;
                radioButton20.Visible = false;
                radioButton21.Visible = false;
                radioButton22.Visible = true;
                radioButton23.Visible = true;
                radioButton24.Visible = true;
                radioButton25.Visible = true;
                radioButton26.Visible = true;
                radioButton27.Visible = true;
                radioButton28.Visible = true;
                radioButton29.Visible = true;
                radioButton30.Visible = true;
                radioButton31.Visible = true;
                radioButton32.Visible = true;
                radioButton33.Visible = true;
                radioButton34.Visible = true;
                radioButton35.Visible = true;
                radioButton36.Visible = true;
                radioButton37.Visible = true;
                radioButton38.Visible = true;
                radioButton39.Visible = true;
                radioButton40.Visible = true;
                on = false;
            }
            /// <summary>
            /// Zamiana wyświetlanych radiobuttonow na "ludzi".
            /// </summary>
            else
            {
                button2.Image = Projekt.Properties.Resources.zmiana;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;
                radioButton8.Visible = true;
                radioButton9.Visible = true;
                radioButton10.Visible = true;
                radioButton11.Visible = true;
                radioButton12.Visible = true;
                radioButton13.Visible = true;
                radioButton14.Visible = true;
                radioButton15.Visible = true;
                radioButton16.Visible = true;
                radioButton17.Visible = true;
                radioButton18.Visible = true;
                radioButton19.Visible = true;
                radioButton20.Visible = true;
                radioButton21.Visible = true;
                radioButton22.Visible = false;
                radioButton23.Visible = false;
                radioButton24.Visible = false;
                radioButton25.Visible = false;
                radioButton26.Visible = false;
                radioButton27.Visible = false;
                radioButton28.Visible = false;
                radioButton29.Visible = false;
                radioButton30.Visible = false;
                radioButton31.Visible = false;
                radioButton32.Visible = false;
                radioButton33.Visible = false;
                radioButton34.Visible = false;
                radioButton35.Visible = false;
                radioButton36.Visible = false;
                radioButton37.Visible = false;
                radioButton38.Visible = false;
                radioButton39.Visible = false;
                radioButton40.Visible = false;
                on = true;
            }
        }
        /// <summary>
        /// Przycisk wychodzenia z programu.
        /// </summary>
        public void Button3_Click(object sender, EventArgs e)
        {
            Close();

        }

    }

}