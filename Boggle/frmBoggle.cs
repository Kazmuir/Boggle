// Kazmuir Long Kenneth Griffin
// 3/24/20
// CIS 3309 Project 3 Boggle Game
//
// Boggle Windows Form Class
//
//Purpose of this class is to represent controls on windows form as well as the interactions with it. Serves as the main class in a way.
// Methods for creating dynamic board inspired by Frank Friedman Bingo Game
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Boggle
{
    public partial class frmBoggle : Form
    {
        PlayerClass player; //create object instance of player
        private RandomLettersClass RandObj = new RandomLettersClass(); //random letter generator for boggle board
        private InternalBoardClass Board = new InternalBoardClass(); // the boggle board internally
        private System.Timers.Timer turnTimer; // the timer

        // Constants
        private const int BOGGLEBOARDSIZE = 4;

        string wordList = ""; // just used to display all the words entered by the user

        // Total width and height of a board cell
        int barWidth = 2; // Width or thickness of horizontal and vertical bars
        int padding = 5;

        int countDown = 60; // the count down for the timer

        // 4x4 2D Array of buttons
        private Button[,] newButton = new Button[BOGGLEBOARDSIZE, BOGGLEBOARDSIZE];

        public frmBoggle() //Default constructor
        {
            InitializeComponent();
        }

        //******CREATING BOGGLE BOARD*****//

        private void createBoggleBoardOnForm() //shows boggle board panel and calls method that creates dynamic boggle board controls
        {
            txtEnterWords.Enabled = true;
            btnSubmit.Enabled = true;
            pnlBoard.Visible = true;
            createBoard();
        } // end createBoggleBoardOnForm

        // Creates the Boggle Board for display of letters allowed for play
        private void createBoard()
        {
            // Dynamically Creates 16 disabled buttons on a Boggle Board 
            // Inspired by Bingo Card Generator written by Bill Hall with Joe Jupin and FLF
            // Creates and add the buttons to the form

            Size size = new Size(75, 75);
            Point loc = new Point(0, 0);
            int topMargin = 20;

            // The board is treated like a 4x4 array
            for (int row = 0; row < BOGGLEBOARDSIZE; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int col = 0; col < BOGGLEBOARDSIZE; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding) + barWidth, loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                    newButton[row, col].Enabled = true;
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                    string ranChar = RandObj.getNextRandomLetter().ToString(); // assigns a sting to input into the button text and internal board
                    newButton[row, col].Text = ranChar;

                    Board.fillBoard(ranChar); // fills internal board

                    newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

                    // Associates the same event handler with each of the buttons generated
                    newButton[row, col].Enabled = false;

                    // Add button to the form
                    pnlBoard.Controls.Add(newButton[row, col]);

                } // end for col
                // One row now complete
            } // end for row
            setTimer();
        } // end createBoard

        //******END CREATING BOGGLE BOARD*****//

        private void setTimer()
        {

            // sets timer for one second.
            turnTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer.
            turnTimer.Elapsed += EndTurn;
            turnTimer.Enabled = true;

            string text = Convert.ToString(countDown);
            lblTimer.Invoke(new Action(() => lblTimer.Text = text));

        }

        private void EndTurn(Object source, ElapsedEventArgs e) // event that occurs every seconed
        {
            if (countDown > 1)
            {
                countDown--;
                string text = Convert.ToString(countDown);
                lblTimer.Invoke(new Action(() => lblTimer.Text = text));
            }
            else
            {
                countDown--;
                string text = Convert.ToString(countDown);
                lblTimer.Invoke(new Action(() => lblTimer.Text = text));
                turnTimer.Stop();

                timesUp();
            }
        }

        private void timesUp() // event that occurs when timer hits zero.
        {
            txtEnterWords.Invoke(new Action(() => txtEnterWords.Enabled = false));
            btnSubmit.Invoke(new Action(() => btnSubmit.Enabled = false));

            string finalScore = Board.results();

            MessageBox.Show(finalScore, "Final Score", MessageBoxButtons.OK);

        }

        private void btnPlay_Click(object sender, EventArgs e)//On Play click, check if name entered, then show game instructions
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter a name to continue.",
                      "No name entered.",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else //if name not null, disable Play button and image, show instructions and Start Game button
            {
                player = new PlayerClass(txtName.Text); //Store player name input in PlayerClass string

                pcbxBoggleSet.Visible = false;
                btnPlay.Enabled = false;
                pnlInstructions.Visible = true;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e) //On Quit pressed, show thank you message, close the program.
        {
            MessageBox.Show("Thanks for playing! Please rate us on the game store!",
                      "Before You Leave!",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            btnStartGame.Visible = false;
            pnlGameDisplay.Visible = true;
            createBoggleBoardOnForm();

            lblWordsEntered.Text = player.getPlayerName() + "'s Words"; //Add player's name to word list label
            //setTimer();
        }

        private void btnSubmit_Click(object sender, EventArgs e) //If structurally valid and more than 2 letters, add player submitted word to list display on form as well as internal list
        {
            if (txtEnterWords.Text.Length < 3)
            {
                MessageBox.Show("Your word must be more than 2 letters. It's the rules!",
                     "Enter a longer word.",
                     MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //Add word to InternalBoard list and form display list
                txtEnterWords.Clear();
                txtEnterWords.Focus();
            }
            else
            {
                ListViewItem word = new ListViewItem(txtEnterWords.Text, 0);
                lvUserWords.Items.Add(word);
                Board.buildWordList(txtEnterWords.Text);
                txtEnterWords.Clear();
                txtEnterWords.Focus();
            }
        }

        private void btnResetBoard_Click(object sender, EventArgs e) //Start Over Before The Game Ends (Useful for bad boards)
        {
            turnTimer.Stop();
            countDown = 60;
            lvUserWords.Clear();
            pnlBoard.Visible = false;
            pnlBoard.Controls.Clear();
            createBoggleBoardOnForm();
            //setTimer();
        }

        private void clearBoard(object sender, System.EventArgs e) //Remove buttons from board so new ones can be created.
        {
            pnlBoard.Controls.Clear();
        }

    }
}