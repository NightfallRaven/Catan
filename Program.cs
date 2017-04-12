using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan_Classes
{
    class Program
    {


        //Declare Enum Variables for classes
        public enum Resource {LUMBER = 0, WOOL = 0, ORE = 0, GRAIN = 0, BRICK = 0 };
        public enum Tiles {LUMBER = 1, WOOL=2, ORE = 3, GRAIN =4, BRICK =5 }
        

        static void Main(string[] args)
        {
            //mock data for entered player names
            string[] playerNames = { "player one", "player two", "player three", "player four" };

            //instantiating players and using mock data from playerNames array
            Player player1 = new Catan_Classes.Program.Player(playerNames[0],  1);
            Player player2 = new Catan_Classes.Program.Player(playerNames[1],  2);
            Player player3 = new Catan_Classes.Program.Player(playerNames[2],  3);
            Player player4 = new Catan_Classes.Program.Player(playerNames[3],  4);

            //instantiate random for future uses
            Random random = new Random();

            //Build the Grid out of 5 possibilities using a random number
            switch (random.Next(5)) {
                case 0:
                    GameBoard board0 = new GameBoard();
                    break;
                case 1:
                    GameBoard board1 = new GameBoard();
                    break;
                case 2:
                    GameBoard board2 = new GameBoard();
                    break;
                case 3:
                    GameBoard board3 = new GameBoard();
                    break;
                case 4:
                    GameBoard board4 = new GameBoard();
                    break;


            }
            
           

        }

        #region game classes
        // Game Classes
        public class Player
        {
            // declaring class variables for the players
            public int lumber { get; set; }
            public int wool { get; set; }
            public int brick { get; set; }
            public int ore { get; set; }
            public int grain { get; set; }
            public string name { get; set; }
            public int playerNum { get; set; }


            //Class constructor for player
            public Player (string _name, int _playerNum)
            {
                name = _name;
                playerNum = _playerNum;
                lumber = 0;
                wool = 0;
                brick = 0;
                ore = 0;
                grain = 0;
            }
                
            

        }

        public class GameBoard
        {
           

            
            public GameBoard()
            {

            }

        }

        public class Tile
        {
            public int tileNumber { get; set; }
            public int location { get; set; }
            public Resource type { get; set; }
            

        }

        public class Settlement {
            
        }

        public class Road {

        }

        #endregion

        #region game functions

        public static int RollDice() {

            //declaring random numbers and integer
            Random rand1 = new Random();
            Random rand2 = new Random();
            int roll = 0;

            //simulating rolling two dice and adding them together
            roll = (rand1.Next(6) + 1) + (rand2.Next(6) + 1);

            //return the simulated dice roll
            return roll;


        }

        #endregion


    }



}
