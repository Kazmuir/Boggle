// Kazmuir Long Kenneth Griffin
// 3/30/20
// CIS 3309 Project 3 Boggle Game
//
// Random Letters Class
//
// This class's purpose is to encapsulates all data and methods associated with the generation of random letters
// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boggle
{
    class RandomLettersClass
    {
        //Minimum and maximum ASCII code for lower-case letters a-z to be used in Random system method
        private int minChar = 97; 
        private int maxChar = 122;

        private Random Rand; //Type random object

        public RandomLettersClass() //Constructor creates new Random Object for each Boggle round
        {
            Rand = new Random();
        }

        public char getNextRandomLetter() //returns character between a-z
        {
            int rl = Rand.Next(minChar, maxChar); //stores new random number restricted by ASCII lowercase letters a-z

            return (char)rl;
        }
    }
}
