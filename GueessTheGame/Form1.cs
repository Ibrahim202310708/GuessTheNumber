using System;
using System.Drawing;
using System.Windows.Forms;

namespace GuessTheNumberGame
{
    public partial class GuessTheGame : Form
    {
        private int randomNumber;
        private int previousGuess;
        private Random random = new Random();

        public GuessTheGame()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            randomNumber = random.Next(1, 1001); // Generates a random number between 1 and 1000
            previousGuess = 0;
            GuessTextBox.Enabled = true;
            GuessTextBox.Clear();
            HintLabel.Text = "";
            this.BackColor = Color.LightGray; // Resets background color
            GuessTextBox.Focus(); // Sets focus to the input textbox for the user to start typing immediately
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            int userGuess;
            bool isNumeric = int.TryParse(GuessTextBox.Text, out userGuess);

            // Validate input
            if (!isNumeric || userGuess < 1 || userGuess > 1000)
            {
                MessageBox.Show("Please enter a valid number between 1 and 1000.");
                GuessTextBox.SelectAll();
                return;
            }

            // Check if the guess is correct, too high, or too low
            if (userGuess == randomNumber)
            {
                this.BackColor = Color.Green;
                MessageBox.Show("Correct!");
                GuessTextBox.Enabled = false; // Disable further input
            }
            else
            {
                if (Math.Abs(randomNumber - userGuess) < Math.Abs(randomNumber - previousGuess))
                {
                    this.BackColor = Color.Red; // Warmer
                }
                else
                {
                    this.BackColor = Color.Blue; // Colder
                }

                HintLabel.Text = userGuess > randomNumber ? "Too High" : "Too Low";
                previousGuess = userGuess; // Update previous guess
            }

            GuessTextBox.SelectAll(); // Select the text to make it easier to change the guess
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            InitializeGame(); // Resets the game
        }
    }
}
