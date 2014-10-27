using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace szyfr2
{
    public partial class Form1 : Form
    {
        char[,] macierz = new char[5, 5];
        char[] alfabet = new char[25];
        string klucz, _alfabet;
        int licznik = 0;
        

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Start programu.");
            domyslnyAlfabet();
            //wypelnijMacierzDomyslnie();
        }

        string usunSpacje(string lancuch)
        {
            string bezSpacji;
            bezSpacji = lancuch.Replace(" ", "");
            return bezSpacji;
        }

        public static T[] MergeArrays<T>(T[] first, T[] second)
        {
            T[] result = new T[first.Length + second.Length];
            Array.Copy(first, result, first.Length);
            Array.Copy(second, 0, result, first.Length, second.Length);
            return result;
        }

        void domyslnyAlfabet()
        {
            int k = 0;

            for (int j = 0; j < 25; j++)
            {
                if (65 + k == 86) k++;
                alfabet[j] = (char)(65 + k);
                k++;
            }

        }

        void alfabetZKluczem()
        {
            int i = 0;
            char temp = klucz[0];
            char[] nowyAlfabet = new char[50];
            while (temp != 0)
            {
                nowyAlfabet[i] = klucz[i];
                temp = klucz[i+1];
                i++;
            }
            Array.Resize(ref nowyAlfabet, i);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Tworzenie alfabetu zawierającego klucz...");
            
            char[] alfabetTemp = MergeArrays(nowyAlfabet, alfabet);

            Console.ForegroundColor = ConsoleColor.Red;
            _alfabet = String.Join("", alfabetTemp);
            Console.WriteLine("Alfabet uwzględniający klucz: " + _alfabet);

            alfabet = usunDuplitakyZAlfabetu(alfabetTemp);

            Console.ForegroundColor = ConsoleColor.Red;
            _alfabet = String.Join("", alfabet);
            Console.WriteLine("Alfabet z usunietymi duplikatami: " + _alfabet);
            Console.ResetColor();

       
        }

        void wypelnijMacierz(char[] _alfabet)
        {
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    macierz[i,j]=_alfabet[count];
                    count++;
                }
            }
        }

        void usunDuplikatyZKlucza(){

            licznik = 0;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Usuwanie duplikatow z klucza...");

        char[] kluczTemp = new char[25];
        
            for (int j = 0; j < klucz.Length; j++)
            {
                if (PrzeszukajSlowo(kluczTemp, klucz[j]) == true)
                {
                    kluczTemp[licznik] = klucz[j];
                    licznik++;
                }
                else
                    continue;
            }
            
        Console.ForegroundColor = ConsoleColor.Red;
        klucz = String.Join("", kluczTemp);
        Console.WriteLine("Klucz z usunietymi duplikatami: " + klucz);
        Console.ResetColor();
        }

        char[] usunDuplitakyZAlfabetu(char[] alfabet)
        {
            licznik=0;
            char[] nowyAlfabet = new char[25];

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Usuwanie duplikatow z alfabetu...");
        
            for (int j = 0; j < alfabet.Length; j++)
            {
                if (PrzeszukajSlowo(nowyAlfabet, alfabet[j]) == true)
                {
                    nowyAlfabet[licznik] = alfabet[j];
                    licznik++;
                }
                else
                    continue;
            }
            return nowyAlfabet;
        }

        bool PrzeszukajSlowo(char[] slowo, char litera)
        {
            for (int i = 0; i < licznik; i++)              
            {
                if(slowo[i] == litera)
                {
                    return false;
                }
                else
                {
                    continue;
                }
            }
            return true;      
        }

        void wypiszMacierz()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Generowanie macierzy z alfabetem uwzgledzniajacym zadany klucz...");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Aktualnie używana macierz: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(macierz[i, j]+" ");
                }
                Console.WriteLine();

            }
            Console.ResetColor();
        }

        int numerKol(char literka)
        {
            int x=0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (literka == macierz[i, j])
                    {
                        x = j;
                        return x+1;
                    }
                }
            }

            return (int)literka;   
        }

        int numerWer(char literka)
        {
            int x = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (literka == macierz[i, j])
                    {
                        x = i;
                        return x + 1;
                    }
                }
            }

            return (int)literka;
        }
        char[,] tabPomoc(string tekstJawny)
        {
            char[,] tekstJawnyTab = new char[3, tekstJawny.Length];
            

            for (int i = 0; i < tekstJawny.Length; i++)
            {
                if (tekstJawny[i] == 32)
                {
                    tekstJawnyTab[0, i] = tekstJawny[i];
                    tekstJawnyTab[1, i] = (char)0;
                    tekstJawnyTab[2, i] = (char)0;
                }
                else
                {
                    tekstJawnyTab[0, i] = tekstJawny[i];
                    tekstJawnyTab[1, i] = (char)numerKol(tekstJawnyTab[0, i]);
                    tekstJawnyTab[2, i] = (char)numerWer(tekstJawnyTab[0, i]);
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Tworzenie tabeli pomocniczej...");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Tabela pomocnicza: ");


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < tekstJawny.Length; j++)
                {
                    if (i == 0 || tekstJawnyTab[i,j] == 48)
                    {
                        Console.Write((char)(tekstJawnyTab[i, j]));
                    }
                    else
                    {
                        Console.Write((int)(tekstJawnyTab[i, j]));
                    }
                }
                Console.WriteLine();
            }


            return tekstJawnyTab;
        }

        char OdczytajZMacierzy(int wsp2, int wsp1)
        {
             char literka = 'Q';
             try
             {
                 wsp1 -= 1;
                 wsp2 -= 1;
                 literka = macierz[wsp1, wsp2];
                 Console.Write((wsp2 + 1) + "," + (wsp1 + 1) + " " + literka + "\t");
                 return literka;
             }
             catch
             {
                 return literka;
             }
        }
        char OdczytajZMacierzy2(int wsp1, int wsp2)
        {
            char literka = 'Q';
            try
            {
                
                // wsp1 -= 1;
                // wsp2 -= 1;
                literka = macierz[wsp2, wsp1];
                Console.Write((wsp1 + 1) + "," + (wsp2 + 1) + " " + literka + "\t");
                return literka;
            }
            catch (Exception ex)
            {
                return literka;
            }
        }
      

        //SZYFROWANIE

        void szyfrPoz(char[,] tabPomoc)
        {
            string szyfr;
            int licznik = 0;
            int[] tabKod = new int[(tabPomoc.Length/3)*2];
            int[,] tabSzyfr = new int[2, tabPomoc.Length];
            char[] _szyfr = new char[tabPomoc.Length / 3];

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Szyfrowanie...");

            for (int i = 0; i < (tabPomoc.Length/3); i++)
            {
                tabKod[i] = tabPomoc[1, i];
                tabKod[(tabPomoc.Length/3) + i] = tabPomoc[2, i];
            }

            for (int i = 0; i < (tabPomoc.Length / 3); i++)
            {
                _szyfr[i] = OdczytajZMacierzy(tabKod[licznik], tabKod[licznik + 1]);
                licznik += 2; ;
            }

            szyfr = string.Join("",_szyfr);

            tekstZaszyfrowany.Text = szyfr;
        }

        void szyfrGD(char[,] tabPomoc)
        {
            string szyfr;
            int licznik = 0;
            int[] tabKod = new int[(tabPomoc.Length / 3) * 2];
            int[,] tabSzyfr = new int[2, tabPomoc.Length];
            char[] _szyfr = new char[tabPomoc.Length / 3];

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Szyfrowanie...");

            for (int i = 0; i < (tabPomoc.Length / 3); i++)
            {
                if (i == (tabPomoc.Length / 3) - 1)
                {
                    tabKod[((tabPomoc.Length / 3) * 2) - 2] = tabPomoc[1, (tabPomoc.Length / 3) - 1];
                    tabKod[((tabPomoc.Length / 3) * 2) - 1] = tabPomoc[2, 0];
                }
                else
                {
                    tabKod[licznik] = tabPomoc[1, i];
                    tabKod[licznik + 1] = tabPomoc[2, i + 1];
                    licznik += 2;
                }
            }
            licznik = 0;

            for (int i = 0; i < (tabPomoc.Length / 3); i++)
            {
                _szyfr[i] = OdczytajZMacierzy2(tabKod[licznik]-1, tabKod[licznik + 1]-1);
                licznik += 2; ;
            }

            szyfr = string.Join("", _szyfr);

            tekstZaszyfrowany.Text = szyfr;

        }

        void szyfrDG(char[,] tabPomoc)
        {
            string szyfr;
            int licznik = 0;
            int[] tabKod = new int[(tabPomoc.Length / 3) * 2];
            int[,] tabSzyfr = new int[2, tabPomoc.Length];
            char[] _szyfr = new char[tabPomoc.Length / 3];

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Szyfrowanie...");

            for (int i = 0; i < (tabPomoc.Length / 3); i++)
            {
                if (i == (tabPomoc.Length / 3) - 1)
                {
                    tabKod[((tabPomoc.Length / 3) * 2) - 2] = tabPomoc[2, (tabPomoc.Length / 3) - 1];
                    tabKod[((tabPomoc.Length / 3) * 2) - 1] = tabPomoc[1, 0];
                }
                else
                {
                    tabKod[licznik+1] = tabPomoc[1, i+1];
                    tabKod[licznik] = tabPomoc[2, i];
                    licznik += 2;
                }
            }
            licznik = 0;

            for (int i = 0; i < (tabPomoc.Length / 3); i++)
            {
                _szyfr[i] = OdczytajZMacierzy2(tabKod[licznik] - 1, tabKod[licznik + 1] - 1);
                licznik += 2; ;
            }

            szyfr = string.Join("", _szyfr);

            tekstZaszyfrowany.Text = szyfr;

        }

        //DESZYFROWANIE

        string deSzyfrPoz(string szyfr)
        {
            int wsp1, wsp2;
            int[] tabKod = new int[szyfr.Length * 2];
            char[,] tabPomoc = new char[3, szyfr.Length];
            char[] tekstJawny = new char[szyfr.Length];
            int licznik = 0;
            string rozszyfr;

            for (int i = 0; i < szyfr.Length; i++)
            {
                wsp1 = numerKol(szyfr[i]);
                wsp2 = numerWer(szyfr[i]);
                tabKod[licznik] = wsp1;
                tabKod[licznik+1] = wsp2;
                licznik += 2;
            }
            licznik =0;
            for (int i = 0; i < szyfr.Length; i++)
            {
                tabPomoc[1, i] = (char)tabKod[i];
                tabPomoc[2, i] = (char)tabKod[tabKod.Length/2+i];
                tabPomoc[0, i] = OdczytajZMacierzy2(tabKod[i]-1, tabKod[tabKod.Length / 2 + i]-1);
                tekstJawny[i] = tabPomoc[0, i];
                licznik += 2;

            }
            
            rozszyfr = string.Join("", tekstJawny);

            return rozszyfr;

        }

        string deSzyfrGD(string szyfr)
        {
            int wsp1, wsp2;
            int[] tabKod = new int[szyfr.Length * 2];
            char[,] tabPomoc = new char[3, szyfr.Length];
            char[] tekstJawny = new char[szyfr.Length];
            int licznik = 0;
            string rozszyfr;

            for (int i = 0; i < szyfr.Length; i++)
            {
                wsp1 = numerKol(szyfr[i]);
                wsp2 = numerWer(szyfr[i]);
                tabKod[licznik] = wsp1;
                tabKod[licznik + 1] = wsp2;
                licznik += 2;
            }
            licznik = 0;
            for (int i = 0; i < szyfr.Length; i++)
            {
                if (i == (tabKod.Length/2) - 1)
                {
                    tabPomoc[2, 0] = (char)tabKod[tabKod.Length-1];
                    tabPomoc[1, (tabKod.Length / 2)-1] = (char)tabKod[tabKod.Length - 2];

                }
                else
                {
                    tabPomoc[1, i] = (char)tabKod[licznik];
                    tabPomoc[2, i + 1] = (char)tabKod[licznik+1];
                    licznik += 2;
                 }

            }

            for (int i = 0; i < szyfr.Length; i++)
            {
                tabPomoc[0, i] = OdczytajZMacierzy2(tabPomoc[1,i]-1, tabPomoc[2,i]-1);
                tekstJawny[i] = tabPomoc[0, i];
            }
            rozszyfr = string.Join("", tekstJawny);

            return rozszyfr;

        }

        string deSzyfrDG(string szyfr)
        {
            int wsp1, wsp2;
            int[] tabKod = new int[szyfr.Length * 2];
            char[,] tabPomoc = new char[3, szyfr.Length];
            char[] tekstJawny = new char[szyfr.Length];
            int licznik = 0;
            string rozszyfr;

            for (int i = 0; i < szyfr.Length; i++)
            {
                wsp1 = numerKol(szyfr[i]);
                wsp2 = numerWer(szyfr[i]);
                tabKod[licznik] = wsp1;
                tabKod[licznik + 1] = wsp2;
                licznik += 2;
            }
            licznik = 0;
            for (int i = 0; i < szyfr.Length; i++)
            {
                if (i == (tabKod.Length / 2) - 1)
                {
                    tabPomoc[1, 0] = (char)tabKod[tabKod.Length - 1];
                    tabPomoc[2, (tabKod.Length / 2) - 1] = (char)tabKod[tabKod.Length - 2];

                }
                else
                {
                    tabPomoc[1, i+1] = (char)tabKod[licznik+1];
                    tabPomoc[2, i] = (char)tabKod[licznik];
                    licznik += 2;
                }

            }

            for (int i = 0; i < szyfr.Length; i++)
            {
                tabPomoc[0, i] = OdczytajZMacierzy2(tabPomoc[1, i] - 1, tabPomoc[2, i] - 1);
                tekstJawny[i] = tabPomoc[0, i];
            }
            rozszyfr = string.Join("", tekstJawny);

            return rozszyfr;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Brak wskazanego klucza.");
                Console.ResetColor();
                wypelnijMacierz(alfabet);
                wypiszMacierz();
            }
            else
            {
                klucz = textBox1.Text.ToUpper();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wskazany klucz: " + klucz);
                Console.ResetColor();
                usunDuplikatyZKlucza();
                alfabetZKluczem();
                wypelnijMacierz(alfabet);
                wypiszMacierz();
            }

            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Szyfrowanie poziome");
            Console.ResetColor();
            szyfrPoz(tabPomoc(usunSpacje(tekstJawny.Text.ToUpper())));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nDeszyfrowanie poziome");
            Console.ResetColor();
            tekstJawny.Text = deSzyfrPoz(usunSpacje(tekstZaszyfrowany.Text.ToUpper()));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            szyfrGD(tabPomoc(usunSpacje(tekstJawny.Text.ToUpper())));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Szyfrowanie góra-dół");
            Console.ResetColor();
            szyfrGD(tabPomoc(usunSpacje(tekstJawny.Text.ToUpper())));

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tekstJawny.Text = deSzyfrGD(usunSpacje(tekstZaszyfrowany.Text.ToUpper()));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nDeszyfrowanie góra-dół");
            Console.ResetColor();
            tekstJawny.Text = deSzyfrGD(usunSpacje(tekstZaszyfrowany.Text.ToUpper()));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Szyfrowanie dół-góra");
            Console.ResetColor();
            szyfrDG(tabPomoc(usunSpacje(tekstJawny.Text.ToUpper())));

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nDeszyfrowanie dół-góra");
            Console.ResetColor();
            tekstJawny.Text = deSzyfrDG(usunSpacje(tekstZaszyfrowany.Text.ToUpper()));

        }

        private void zakończProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void otwórzZPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            tekstJawny.Text = File.ReadAllText(openFileDialog1.FileName);
                            Console.WriteLine("Otwarto plik z tekstem jawnym o nazwie: " + openFileDialog1.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd. Nie można odczytać wskazenego pliku! \n " + ex.Message);
                }
            }
        }

        private void otwórzZPlikuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            tekstZaszyfrowany.Text = File.ReadAllText(openFileDialog1.FileName);
                            Console.WriteLine("Otwarto plik z tekstem zaszyfrowanym o nazwie: " + openFileDialog1.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd. Nie można odczytać wskazenego pliku! \n " + ex.Message);
                }
            }
        }

        private void zapiszDoPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            try
            {

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    {

                        using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                        {

                            sw.Write(tekstJawny.Text);

                        }

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Błąd. Nie można zapisać wskazenego pliku! \n " + ex.Message);
            }
        }

        private void zapiszDoPlikuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            try
            {

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    {

                        using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                        {

                            sw.Write(tekstZaszyfrowany.Text);

                        }

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Błąd. Nie można zapisać wskazenego pliku! \n " + ex.Message);
            }
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Szyfr Delastella \nMarcin Gluza \n2014 \n\ngumball300@gmail.com", "Autor");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            tekstZaszyfrowany.Clear();
            tekstJawny.Clear();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tekstJawny.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tekstZaszyfrowany.Clear();
        }
    }
}
