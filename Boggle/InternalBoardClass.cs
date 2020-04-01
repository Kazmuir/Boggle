// Kazmuir Long Kenneth Griffin
// 3/30/20
// CIS 3309 Project 3 Boggle Game
//
// Internal Board Class
//
// The purpose of this class is to represent the state of the visual boggle form throughout the game. Also stores user word list.
// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boggle
{
    class InternalBoardClass
    {
        List<String> userWords; //store words the player has entered during the gameplay
        List<String> board; //holds the 16 characters that make up the current boggle board.
        int score;

        public InternalBoardClass() //empty default constructor
        {
            userWords = new List<string> { };
            board = new List<string> { };
            score = 0;
        }

        public void fillBoard(string letter) //when creating new board, add each character to list
        {
            board.Add(letter);
        }

        public void buildWordList(string word)
        {
            userWords.Add(word);
        }
    }
}
