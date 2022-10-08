using static Akasztófa_WinForm.szavak;

namespace Akasztófa_WinForm
{
    public partial class Form1 : Form
    {
       // public static int diff = -1;

        public Form1()
        {
            InitializeComponent();
            NGBtn.Hide();
            
            
            /*    if (Easy.Checked == true) GameDifficulty = Difficulty.Easy;
           
                if (Medium.Checked == true)GameDifficulty = Difficulty.Medium;
                
                if (Brutal.Checked == true)GameDifficulty = Difficulty.Hard; 
                
                if (Brutal.Checked == true)GameDifficulty = Difficulty.Brutal; 
              */  
            

        }
        
        public static Difficulty GameDifficulty { get; set; }

        public enum Difficulty
        {
            Easy,
            Medium,
            Hard,
            Brutal
        }

    private void button1_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void NGBtn_Click(object sender, EventArgs e)
        {

            if (Easy.Checked == true) GameDifficulty = Difficulty.Easy;

            if (Medium.Checked == true) GameDifficulty = Difficulty.Medium;

            if (Brutal.Checked == true) GameDifficulty = Difficulty.Hard;

            if (Brutal.Checked == true) GameDifficulty = Difficulty.Brutal;

            var sz = new szavak();

            sz.Difficult();

            this.Hide();
            Form2 F2 = new Form2();
           // F2.ShowDialog();
            F2.Show();

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form2.élet= Convert.ToByte(comboBox1.Text);
           
            NGBtn.Show();
        }
    }
}