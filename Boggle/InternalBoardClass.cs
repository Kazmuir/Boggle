﻿// Kazmuir Long Kenneth Griffin
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
        APIDictionaryClass API = new APIDictionaryClass();

        List<String> userWords; //store words the player has entered during the gameplay
        List<String> validUserWords; //Words confirmed to be real after checking with API
        List<string> outputs; //used at the end to give the player information on the words that they used.
        List<String> board; //holds the 16 characters that make up the current boggle board.
        int score;

        public InternalBoardClass() // constructor
        {
            userWords = new List<string> { };
            validUserWords = new List<string> { };
            outputs = new List<string> { };
            board = new List<string> { };
            score = 0;
        }

        public void fillBoard(string letter) //when creating new board, add each character to list
        {
            board.Add(letter);
        }

        public void buildWordList(string word)// each word a user submits is collected in the userWords list
        {
            userWords.Add(word);
        }

        public void checkWordValidity() //Check the status code: if 200 (successful request) this means the word exists.
        {
            for(int i = 0; i < userWords.Count; i++)
            {
                int responseStatus;
                responseStatus = API.GetDefine(userWords[i]);
                if (responseStatus == 200)
                {
                    validUserWords.Add(userWords[i]);
                }
            }
        }

        public string results() // the begining of the end. When the timer reaches zero this method will loop through the userWords list and find if the word is valid or not.
        {
            checkWordValidity();
            string resultMessage = "";

            for (int i = 0; i < validUserWords.Count; i++)
            {
                if (firstLetter(validUserWords[i]) == true)
                {
                    int wS = calculateScore(validUserWords[i]);

                    if(resultMessage == "")
                    {
                        resultMessage += validUserWords[i] + "\t" + wS.ToString();
                    }
                    else
                    {
                        resultMessage += "\n" + validUserWords[i] + "\t" + wS.ToString();
                    }
                }
                else
                {
                    if (resultMessage == "")
                    {
                        resultMessage += validUserWords[i] + "\t Word not found";
                    }
                    else
                    {
                        resultMessage += "\n" + validUserWords[i] + "\t Word not found";
                    }
                }
            }

            resultMessage += "\n Total score: \t" + score.ToString();

            return resultMessage;

        }

        public int calculateScore(string word) // caculartes each sussecful words score and adds it to the total score
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

        public bool firstLetter(string word) // finds the first letter of the word past to this method and sends the rest of the word through another method to loop through the rest of the word. Why didn't I just
                                             // find the first letter of the word in the next method and why does this method even exist you ask? Thats a good question.
        {

            string start = word.Substring(0, 1);

            for (int k = 0; k < board.Count; k++)
            {
                List<int> usedCells = new List<int> { };

                if (start == board[k])
                {
                    if (lastMethodPlease(word, k, 1, usedCells))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool lastMethodPlease(string word, int placed, int position, List<int> cells) // loops through the word passed to it to find if it exists validly on the board.
        {

            if (cells.Contains(placed) == true)
            {
                return false;
            }

            cells.Add(placed);

            if (position >= word.Length)
            {
                return true;
            }
            else
            {
                string pieces = word.Substring(position, 1);

                for (int l = 0; l < board.Count; l++) // loops through the board looking for a valid space to put the next letter in the word
                {
                    if (pieces == board[l])
                    {

                        if (placed == 0 && l == 1 || placed == 0 && l == 4 || placed == 0 && l == 5)
                        {
                            if(lastMethodPlease(word, l, position + 1, cells))
                            {
                                return true;
                            }
                        }
                        else if (placed == 1 && l == 0 || placed == 1 && l == 2 || placed == 1 && l == 4 || placed == 1 && l == 5 || placed == 1 && l == 6)
                        {
                            if (lastMethodPlease(word, l, position + 1, cells))
                            {
                                return true;
                            }
                        }
                        else if (placed == 2 && l == 1 || placed == 2 && l == 3 || placed == 2 && l == 5 || placed == 2 && l == 6 || placed == 2 && l == 7)
                        {
                            if (lastMethodPlease(word, l, position + 1, cells))
                            {
                                return true;
                            }
                        }
                        else if (placed == 3 && l == 2 || placed == 3 && l == 6 || placed == 3 && l == 7)
                        {
                            if (lastMethodPlease(word, l, position + 1, cells))
                            {
                                return true;
                            }
                        }
                        else if (placed == 4 && l == 0 || placed == 4 && l == 1 || placed == 4 && l == 5 || placed == 4 && l == 8 || placed == 4 && l == 9)
                        {
                            if (lastMethodPlease(word, l, position + 1, cells))
                            {
                                return true;
                            }
                        }
                        else if (placed == 5 && l == 0 || placed == 5 && l == 1 || placed == 5 && l == 2 || placed == 5 && l == 4 || placed == 5 && l == 6 || placed == 5 && l == 8 || placed == 5 && l == 9 || placed == 5 && l == 10)
                        {
                            if (lastMethodPlease(word, l, position + 1, cells))
                            {
                                return true;
                            }
                        }
                        else if (placed == 6 && l == 1 || placed == 6 && l == 2 || placed == 6 && l == 3 || placed == 6 && l == 5 || placed == 6 && l == 7 || placed == 6 && l == 9 || placed == 6 && l == 10 || placed == 6 && l == 11)
                        {
                            if (lastMethodPlease(word, l, position + 1, cells))
                            {
                                return true;
                            }
                        }
                        else if (placed == 7 && l == 2 || placed == 7 && l == 3 || placed == 7 && l == 6 || placed == 7 && l == 10 || placed == 7 && l == 11)
                        {
                            if (lastMethodPlease(word, l, position + 1, cells))
                            {
                                return true;
                            }
                        }
                        else if (placed == 8 && l == 4 || placed == 8 && l == 5 || placed == 8 && l == 9 || placed == 8 && l == 12 || placed == 8 && l == 13)
                        {
                            if (lastMethodPlease(word, l, position + 1, cells))
                            {
                                return true;
                            }
                        }
                        else if (placed == 9 && l == 4 || placed == 9 && l == 5 || placed == 9 && l == 6 || placed == 9 && l == 8 || placed == 9 && l == 10 || placed == 9 && l == 12 || placed == 9 && l == 13 || placed == 9 && l == 14)
                        {
                            if (lastMethodPlease(word, l, position + 1, cells))
                            {
                                return true;
                            }
                        }
                        else if (placed == 10 && l == 5 || placed == 10 && l == 6 || placed == 10 && l == 7 || placed == 10 && l == 9 || placed == 10 && l == 11 || placed == 10 && l == 13 || placed == 10 && l == 14 || placed == 10 && l == 15)
                        {
                            if (lastMethodPlease(word, l, position + 1, cells))
                            {
                                return true;
                            }
                        }
                        else if (placed == 11 && l == 6 || placed == 11 && l == 7 || placed == 11 && l == 10 || placed == 11 && l == 14 || placed == 11 && l == 15)
                        {
                            if (lastMethodPlease(word, l, position + 1, cells))
                            {
                                return true;
                            }
                        }
                        else if (placed == 12 && l == 8 || placed == 12 && l == 9 || placed == 12 && l == 13)
                        {
                            if (lastMethodPlease(word, l, position + 1, cells))
                            {
                                return true;
                            }
                        }
                        else if (placed == 13 && l == 8 || placed == 13 && l == 9 || placed == 13 && l == 10 || placed == 13 && l == 12 || placed == 13 && l == 14)
                        {
                            if (lastMethodPlease(word, l, position + 1, cells))
                            {
                                return true;
                            }
                        }
                        else if (placed == 14 && l == 9 || placed == 14 && l == 10 || placed == 14 && l == 11 || placed == 14 && l == 13 || placed == 14 && l == 15)
                        {
                            if (lastMethodPlease(word, l, position + 1, cells))
                            {
                                return true;
                            }
                        }
                        else if (placed == 15 && l == 10 || placed == 15 && l == 11 || placed == 15 && l == 14)
                        {
                            if (lastMethodPlease(word, l, position + 1, cells))
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
            validUserWords.Clear();
            outputs.Clear();
            board.Clear();
            score = 0;
        }
    }
}
