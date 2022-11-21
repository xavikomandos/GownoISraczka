using System.Drawing.Text;

namespace KrzyzykIKolko
{
    enum CurrentPlayer
    {
        Cross,
        Circle
    }
    public partial class Form1 : Form
    {
        CurrentPlayer currentPlayer;
        public Form1()
        {
            InitializeComponent();
            currentPlayer = CurrentPlayer.Cross;
            changeLabel2();
        }

        private void changeLabel2()
        {
            if (currentPlayer == CurrentPlayer.Cross)
            {
                label2.Text = "Krzyzyk";
            }
            else
            {
                label2.Text = "Kolko";
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if (currentPlayer == CurrentPlayer.Cross)
            {
                senderButton.Text = "X";
                currentPlayer = CurrentPlayer.Circle;
            }
            else
            {
                senderButton.Text = "O";
                currentPlayer = CurrentPlayer.Cross;
            }
            checkForkWinner();
            changeLabel2();
        }
        public void checkForkWinner()
        {
            if(String.Compare(LewyGorny.Text, LewySrodek.Text) == 0 && String.Compare(LewySrodek.Text, LewyDol.Text) == 0)
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = LewyGorny.Text;
                victoryScreen.Show();
            }
            else if (String.Compare(SrodekGorny.Text, Srodek.Text) == 0 && String.Compare(Srodek.Text, SrodekDol.Text) == 0)
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = SrodekGorny.Text;
                victoryScreen.Show();
            }
        }
        
        public void clearBoard()
        {
            TableLayoutControlCollection buttons = tableLayoutPanel1.Controls;
            
            for(int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i] is Button)
                    buttons[i].Text = "";
            }
        }

        }
    }