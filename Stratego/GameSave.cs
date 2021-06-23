using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stratego
{
    public class GameSave
    {
        public GamePiece[,] boardPieces;
        public Owner currentTurn;
        public TimeSpan elapsedTime;

        public GameSave()
        {
            boardPieces = new GamePiece[GameStatics.GridSize, GameStatics.GridSize];
            currentTurn = Owner.None;
            elapsedTime = TimeSpan.Zero;
        }

        public static bool SaveGame(string filepath, Tile[,] tiles, Owner currentPlayer, TimeSpan currentTime)
        {
            if (tiles.Length != Math.Pow(GameStatics.GridSize, 2) || filepath == null)
                return false;

            /// save the game data to a file as strings

            return true;
        }

        public bool loadFromFile(string filepath)
        {
            /// try read and load data from a file. Return the success
            return true;
        }

        private bool parseLine(string line)
        {
            /// read a line, select which makeX method to use
            return true;
        }

        private bool makeTile(string row, string col, string owner, string character)
        {
            /// make a tile from string values
            return true;
        }

        private bool makeTime(string s)
        {
            /// make a TimeSpan from a string
            return true;
        }

        private bool makePlayer(string p)
        {
            /// make a player value from a string
            return true;
        }
    }
}
