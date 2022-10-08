using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static Akasztófa_WinForm.Form1;

namespace Akasztófa_WinForm
{
    internal class szavak
    {
        //string easy = "teszt.txt";
        string easy = "easy2.txt";
        string medium = "medium2.txt";
        string hard = "hard2.txt";
        string brutal = "brutal2.txt";

        private static string szoveg;

      //  public static char[] secretword;
       
        private static char[] secretword;

        private static char[] eddigkitaláltszó;

        public static char[] Secretword { get => secretword; set => secretword = value; }
        public static char[] Eddigkitaláltszó { get => eddigkitaláltszó; set => eddigkitaláltszó = value; }
        public static string Szoveg { get => szoveg; set => szoveg = value; }



        // Random rnd = new Random();



        public void Difficult()
        {
            switch (GameDifficulty)
            {
                case Difficulty.Easy:
                    Easy();
                    break;
                case Difficulty.Medium:
                    Medium();
                    break;
                case Difficulty.Hard:
                    Hard();
                    break;
                case Difficulty.Brutal:
                    Brutal();
                    break;
            }
        }

        private void Brutal()
        {
            string[] allLines = File.ReadAllLines(brutal);
            Random rnd1 = new Random();
            Szoveg = allLines[rnd1.Next(allLines.Length)];

            //MessageBox.Show(szoveg);

            Secretword = Szoveg.ToCharArray();

            Eddigkitaláltszó = Szoveg.ToCharArray();
        }

        private void Hard()
        {
            string[] allLines = File.ReadAllLines(hard);
            Random rnd1 = new Random();
            Szoveg = allLines[rnd1.Next(allLines.Length)];

            //MessageBox.Show(szoveg);

            Secretword = Szoveg.ToCharArray();

            Eddigkitaláltszó = Szoveg.ToCharArray();
        }

        private void Medium()
        {
            string[] allLines = File.ReadAllLines(medium);
            Random rnd1 = new Random();
            Szoveg = allLines[rnd1.Next(allLines.Length)];

            //MessageBox.Show(szoveg);

            Secretword = Szoveg.ToCharArray();

            Eddigkitaláltszó = Szoveg.ToCharArray();
        }

        public void Easy()
        {
            string[] allLines = File.ReadAllLines(easy);
            Random rnd1 = new Random();
            Szoveg = allLines[rnd1.Next(allLines.Length)];

            //MessageBox.Show(szoveg);

            Secretword = Szoveg.ToCharArray();
          
            Eddigkitaláltszó = Szoveg.ToCharArray();

          

        }

    }	
}
