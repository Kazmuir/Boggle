// Kazmuir Long Kenneth Griffin
// 3/30/20
// CIS 3309 Project 3 Boggle Game
//
// Player Class
//
// This class's purpose is to retrieve and store player's name from input for use in the program.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boggle
{
    class PlayerClass
    {
        private string playerName; //string that player name input will be stored

        public PlayerClass(string nameInput) //Constructor for player class used to instatiate player name from input
        {
            playerName = nameInput;
        }

        public string getPlayerName() //Method returns player name
        {
            return playerName;
        }
    }
}
