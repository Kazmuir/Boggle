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
        List<string> outputs; //used at the end to give the player information on the words that they used.
        List<String> board; //holds the 16 characters that make up the current boggle board.
        int score;

        public InternalBoardClass() // constructor
        {
            userWords = new List<string> { };
            outputs = new List<string> { };
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

        public string results()
        {
            string resultMessage = "";

            for (int i = 0; i < userWords.Count; i++)
            {
                if (firstLetter(userWords[i]) == true)
                {
                    int wS = calculateScore(userWords[i]);

                    if(resultMessage == "")
                    {
                        resultMessage += userWords[i] + "\t" + wS.ToString();
                    }
                    else
                    {
                        resultMessage += "\n" + userWords[i] + "\t" + wS.ToString();
                    }
                }
                else
                {
                    if (resultMessage == "")
                    {
                        resultMessage += userWords[i] + "\t Word not found";
                    }
                    else
                    {
                        resultMessage += "\n" + userWords[i] + "\t Word not found";
                    }
                }
            }

            resultMessage += "\n Total score: \t" + score.ToString();

            return resultMessage;

        }

        public int calculateScore(string word)
        {
            int wordPoints;

            if (word.Length == 3)
            {
                score += 1;
                wordPoints = 1;
            }
            else if (word.Length == 4)
            {
                score += 2;
                wordPoints = 2;
            }
            else if (word.Length == 5)
            {
                score += 3;
                wordPoints = 3;
            }
            else if (word.Length == 6)
            {
                score += 4;
                wordPoints = 4;
            }
            else if (word.Length == 7)
            {
                score += 5;
                wordPoints = 5;
            }
            else
            {
                score += 6;
                wordPoints = 6;
            }

            return wordPoints;

        }

        public bool firstLetter(string word)
        {

            string start = word.Substring(0, 1);

            for (int k = 0; k < board.Count; k++)
            {
                if (start == board[k])
                { 
                    if (lastMethodPlease(word, k, 1))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool lastMethodPlease(string word, int placed, int position)
        {

            if (position >= word.Length)
            {
                return true;
            }
            else
            {
                string pieces = word.Substring(position, 1);

                for (int l = 0; l < board.Count; l++)
                {
                    if (pieces == board[l])
                    {

                        if (placed == 0 && l == 1 || placed == 0 && l == 4 || placed == 0 && l == 5)
                        {
                            if(lastMethodPlease(word, l, position + 1))
                            {
                                return true;
                            }
                        }
                        else if (placed == 1 && l == 0 || placed == 1 && l == 2 || placed == 1 && l == 4 || placed == 1 && l == 5 || placed == 1 && l == 6)
                        {
                            if (lastMethodPlease(word, l, position + 1))
                            {
                                return true;
                            }
                        }
                        else if (placed == 2 && l == 1 || placed == 2 && l == 3 || placed == 2 && l == 5 || placed == 2 && l == 6 || placed == 2 && l == 7)
                        {
                            if (lastMethodPlease(word, l, position + 1))
                            {
                                return true;
                            }
                        }
                        else if (placed == 3 && l == 2 || placed == 3 && l == 6 || placed == 3 && l == 7)
                        {
                            if (lastMethodPlease(word, l, position + 1))
                            {
                                return true;
                            }
                        }
                        else if (placed == 4 && l == 0 || placed == 4 && l == 1 || placed == 4 && l == 5 || placed == 4 && l == 8 || placed == 4 && l == 9)
                        {
                            if (lastMethodPlease(word, l, position + 1))
                            {
                                return true;
                            }
                        }
                        else if (placed == 5 && l == 0 || placed == 5 && l == 1 || placed == 5 && l == 2 || placed == 5 && l == 4 || placed == 5 && l == 6 || placed == 5 && l == 8 || placed == 5 && l == 9 || placed == 5 && l == 10)
                        {
                            if (lastMethodPlease(word, l, position + 1))
                            {
                                return true;
                            }
                        }
                        else if (placed == 6 && l == 1 || placed == 6 && l == 2 || placed == 6 && l == 3 || placed == 6 && l == 5 || placed == 6 && l == 7 || placed == 6 && l == 9 || placed == 6 && l == 10 || placed == 6 && l == 11)
                        {
                            if (lastMethodPlease(word, l, position + 1))
                            {
                                return true;
                            }
                        }
                        else if (placed == 7 && l == 2 || placed == 7 && l == 3 || placed == 7 && l == 6 || placed == 7 && l == 10 || placed == 7 && l == 11)
                        {
                            if (lastMethodPlease(word, l, position + 1))
                            {
                                return true;
                            }
                        }
                        else if (placed == 8 && l == 4 || placed == 8 && l == 5 || placed == 8 && l == 9 || placed == 8 && l == 12 || placed == 8 && l == 13)
                        {
                            if (lastMethodPlease(word, l, position + 1))
                            {
                                return true;
                            }
                        }
                        else if (placed == 9 && l == 4 || placed == 9 && l == 5 || placed == 9 && l == 6 || placed == 9 && l == 8 || placed == 9 && l == 10 || placed == 9 && l == 12 || placed == 9 && l == 13 || placed == 9 && l == 14)
                        {
                            if (lastMethodPlease(word, l, position + 1))
                            {
                                return true;
                            }
                        }
                        else if (placed == 10 && l == 5 || placed == 10 && l == 6 || placed == 10 && l == 7 || placed == 10 && l == 9 || placed == 10 && l == 11 || placed == 10 && l == 13 || placed == 10 && l == 14 || placed == 10 && l == 15)
                        {
                            if (lastMethodPlease(word, l, position + 1))
                            {
                                return true;
                            }
                        }
                        else if (placed == 11 && l == 6 || placed == 11 && l == 7 || placed == 11 && l == 10 || placed == 11 && l == 14 || placed == 11 && l == 15)
                        {
                            if (lastMethodPlease(word, l, position + 1))
                            {
                                return true;
                            }
                        }
                        else if (placed == 12 && l == 8 || placed == 12 && l == 9 || placed == 12 && l == 13)
                        {
                            if (lastMethodPlease(word, l, position + 1))
                            {
                                return true;
                            }
                        }
                        else if (placed == 13 && l == 8 || placed == 13 && l == 9 || placed == 13 && l == 10 || placed == 13 && l == 12 || placed == 13 && l == 14)
                        {
                            if (lastMethodPlease(word, l, position + 1))
                            {
                                return true;
                            }
                        }
                        else if (placed == 14 && l == 9 || placed == 14 && l == 10 || placed == 14 && l == 11 || placed == 14 && l == 13 || placed == 14 && l == 15)
                        {
                            if (lastMethodPlease(word, l, position + 1))
                            {
                                return true;
                            }
                        }
                        else if (placed == 15 && l == 10 || placed == 15 && l == 11 || placed == 15 && l == 14)
                        {
                            if (lastMethodPlease(word, l, position + 1))
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
            
        }

        public void resetAttributes() //clear all attributes for new game
        {
            userWords.Clear();
            outputs.Clear();
            board.Clear();
            score = 0;
        }
    }
}
