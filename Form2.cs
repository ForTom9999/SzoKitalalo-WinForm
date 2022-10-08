using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akasztófa_WinForm
{

    
    public partial class Form2 : Form
    {
        

        Font MediumFont = new Font("Georgia", 22, FontStyle.Bold);
        private static readonly char[] alphabet =
    {
        'a', 'á', 'b', 'c', 'd', 'e', 'é', 'f', 'g', 'h', 'i', 'í', 'j', 'k', 'l', 'm', 'n',
        'o', 'ó', 'ö', 'ő', 'p', 'q', 'r', 's', 't', 'u', 'ú', 'ü', 'ű', 'v', 'w', 'y', 'z'
    };
        
        public static bool Tartalmaz = false;
        public static byte élet;
        public static bool isLife = true;


        public Form2()
        {
            InitializeComponent();
            lifelbl.Text = Convert.ToString(élet);
            CreateButtons();
            Konvert();
            Kitalálandó();
        }

        public void CreateButtons()
        {
            int startX = 18;
            int startY = 330;
            int köviX = 65;
            int köviY = 65;
            int méretX = 50;
            int méretY = 50;

            for (int i = 0; i < alphabet.Length; i++)
            {
                Button newButton = new Button();
                this.Controls.Add(newButton);
                newButton.Name = "btn" + Convert.ToString(i);
                newButton.Tag = i;
                newButton.BackColor = Color.Beige;
                newButton.Font = MediumFont;
                newButton.Text = Convert.ToString(Char.ToUpper(alphabet[i]));
                newButton.Location = new Point(startX, startY);
                newButton.Size = new Size(méretX, méretY);
                startX += köviX;
                if ((i+1) % 12 == 0)
                {
                    startY += köviY;
                    startX = 20;
                }
                newButton.Click += LetterClick;

            }                                                
            


        }

        private void LetterClick(object sender, EventArgs e)
        {
            Button newButton = sender as Button;
            
            char a = Char.ToLower(newButton.Text[0]);

            LetterContains(a);                                             

            newButton.Dispose();

            CheckWin();
        }

        public void Kitalálandó()
        {
            
            SecretLbl.Text = new string(szavak.Eddigkitaláltszó);
        }

        public void CheckWin()
        {
            
            
             if ((new string(szavak.Eddigkitaláltszó) == new string(szavak.Secretword)) && isLife)
           
            {
                DialogResult dialogResult = MessageBox.Show("Gratulálok! Nyertél! Akarsz még egyet játszani?", "Nyertél!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Reset();
                    this.Hide();
                    Form1 F1 = new Form1();
                    F1.ShowDialog();
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void Reset()
        {
            
            isLife = true;
        }

        public void LetterContains(char a)
        {
            //A Secretword tartalamzza-e a karaktert

            for (int i = 0; i < szavak.Secretword.Length; i++)
            {
                if (szavak.Secretword[i] == a)
                {
                    szavak.Eddigkitaláltszó[i] = a;
                    Kitalálandó();
                     Tartalmaz = true;

                }
               
            }
            if (!Tartalmaz)
            {
                    élet--;
                    CheckLife();
                lifelbl.Text = Convert.ToString(élet);

            }
            Tartalmaz = false;
            
        }

        private void CheckLife()
        {
            //Nézi, hogy él-e még a játékos

            if (élet<=0)
            {
                DialogResult dialogResult = MessageBox.Show($"Sajnálom, de vesztettél! A szó: {new string(szavak.Secretword)} volt. Akarsz még egyet játszani?", "Vesztettél!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Reset();
                    this.Hide();
                    Form1 F1 = new Form1();
                    F1.ShowDialog();

                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        public static void Konvert()
        {
            //A kitalálandó szavat átalakítja '?'-jellé, kivéve ha '-'

            for (int i = 0; i < szavak.Eddigkitaláltszó.Length; i++)
            {
                if (szavak.Eddigkitaláltszó[i] == '-')
                {
                    szavak.Eddigkitaláltszó[i] = '-';
                }
                else szavak.Eddigkitaláltszó[i] = '?';
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Kilépés gomb

            Application.Exit();
        }

        private void BBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.ShowDialog();
        }
    }      
}
