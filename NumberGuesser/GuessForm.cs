
namespace NumberGuesser
{
    using System.Windows.Forms;

    public partial class GuessForm : Form
    {
        public GuessForm()
        {
            InitializeComponent();

            rGuesser = new RandomNumberGuesser(MIN_GUESS_VALUE, MAX_GUESS_VALUE);

            timer = new Timer();

            timer.Interval = 1500;

            timer.Tick += WinEvent;
        }
        public const int MIN_GUESS_VALUE = 1;

        public const int MAX_GUESS_VALUE = 100;

        private Timer timer;

        private RandomNumberGuesser rGuesser;

        private void guessBtn_Click(object sender, EventArgs e)
        {

            int guessInput = default(int);

            string input = guessBox.Text;

            guessBox.Text = string.Empty;

            try
            {
                guessInput = ReadGuessInput(input);

            }
            catch (Exception ex)
            {
                if (ex is ArgumentOutOfRangeException || ex is FormatException)
                {
                    MessageBox.Show("Please enter a valid number between 1 - 100");

                    rGuesser.GuessCount++;

                    return;
                }
                else
                {
                    Environment.Exit(1);
                }

            }

            Color result = rGuesser.Guess(guessInput);

            outputLabel.BackColor = result;

            if (result == Color.Red)
            {
                outputLabel.Text = "Too Low!";
            }
            else if (result == Color.Blue)
            {
                outputLabel.Text = "Too High!";
            }
            else if (result == Color.Green)
            {
                outputLabel.Text = "Correct!";

                PageInteractionNone(false);
              
                timer.Start();
            }
            else
            {
                throw new Exception("Undefined Result");
            }
        }
        private void WinEvent(object sender, EventArgs e)
        {
            timer.Stop();

            MessageBox.Show($"Congratulations it took you {rGuesser.GuessCount} amount of tries to guess the anwser!");

            ResetGame();

            PageInteractionNone(true);
        }
        private void PageInteractionNone(bool state)
        {
            guessBtn.Enabled = state;
            guessBox.Enabled = state;
            replayBtn.Enabled = state;
        }
        private int ReadGuessInput(string txt)
        {

            int val = int.Parse(txt);

            if (val < MIN_GUESS_VALUE || val > MAX_GUESS_VALUE)
            {
                throw new ArgumentOutOfRangeException();
            }
        
            return val;

        }

        private void ResetGame()
        {
            outputLabel.Text = string.Empty;
            guessBox.Text = string.Empty;

            rGuesser.CreateNewRandomNumber();
        }

        private void replayBtn_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}