using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stratego
{
    public class Game
    {
        public GameState currentState;
        public Tile[,] tiles;
        public GameForm mainform;

        public Tile tileMouseDown;
        public Tile tileDragOver;

        private Owner currentPlayer;

        public Game(GameForm form, Tile[,] tiles)
        {
            this.mainform = form;
            this.tiles = tiles;
            setGameState(GameState.PreGame);
            setPlayer(Owner.Player1);
            //TODO: The Player Control radio button should have Player 1 selected.
            //TODO: The form should display an “Elapsed Time” with a current value of 0 minutes, 0 seconds.


            foreach (Tile t in tiles)
            {
                t.bindToGame(this);
            }

            resetGame();
        }

        public void setGameState(GameState state)
        {
            currentState = state;
            mainform.setPhaseDisplay(currentState);
        }

        public void setPlayer(Owner player)
        {
            currentPlayer = player;
            mainform.setCurrentPlayerDisplay(currentPlayer);
            updateTilesVisibility();
        }

        public void changePlayer()
        {
            if (this.currentPlayer == Owner.Player1)
            {
                setPlayer(Owner.Player2);
            }
            else
            {
                setPlayer(Owner.Player1);
            }
        }

        /////////////////////////////////////////////////////
        ///  Game status controls
        /////////////////////////////////////////////////////

        public void startGame()
        {

        }

        public void pauseGame()
        {

        }

        public void resumeGame()
        {

        }

        public void stopGame()
        { 

        }

        private void endGame(Owner winner)
        {

        }

        public void resetGame()
        {
            setDefaultBoard();
        }

        /////////////////////////////////////////////////////
        ///  Tile interaction registrations
        /////////////////////////////////////////////////////

        public void registerMouseDown(Tile sender)
        {

            Console.WriteLine("Mouse Down: {0}", getTileIndex(sender));
        }

        public bool registerDragOver(Tile sender)
        {
            
            Console.WriteLine("Drag {0} Over: {1}", getTileIndex(this.tileMouseDown), getTileIndex(sender));
            return true;
        }

        public void registerDragLeave(Tile sender)
        {
            
            Console.WriteLine("Drag {0} Leave: {1}", getTileIndex(this.tileMouseDown), getTileIndex(sender));
        }

        public void registerDragDrop(Tile sender)
        {
           
            Console.WriteLine("Drop {0} on : {1}", getTileIndex(this.tileMouseDown), getTileIndex(sender));
        }


        /////////////////////////////////////////////////////
        ///  Game helper methods
        /////////////////////////////////////////////////////
        public Tuple<int, int> getTileIndex(Tile tile)
        {
            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(0); j++)
                {
                    if (tiles[i, j] == tile)
                        return new Tuple<int, int>(i, j);
                }
            }
            return new Tuple<int, int>(-1, -1);
        }

        private void setDefaultBoard()
        {
            int p1backRow = tiles.GetLength(1) - 1;
            int p1frontRow = p1backRow - 1;

            int p2backRow = 0;
            int p2frontRow = 1;

            for (int i = 0; i < GameStatics.DefaultBackRow.Length; i++)
            {
                tiles[i, p1backRow].setGamePiece(GameStatics.DefaultBackRow[i],Owner.Player1);
                tiles[i, p2backRow].setGamePiece(GameStatics.DefaultBackRow[i],Owner.Player2);
                tiles[i, p1frontRow].setGamePiece(GameStatics.DefaultFrontRow[i],Owner.Player1);
                tiles[i, p2frontRow].setGamePiece(GameStatics.DefaultFrontRow[i],Owner.Player2);
            }
        }
        private void clearBoard()
        {            
            GC.Collect();
        }

        private void move(Tile a, Tile b)
        {
                
        }

        private void attack(Tile a, Tile b)
        {
            
        }

        /// <summary>
        /// Used during pregame for swapping location of game pieces in a 
        /// player's army
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private void swap(Tile a, Tile b)
        {
            /// if it's not a player's turn, stop the swap
            
            /// else, if the owner of both tiles match
            
        }

        private bool checkValidMove(Tile a, Tile b)
        {
            // if the tile trying to move belongs to the current player
            return true;
        }

        private bool checkIfNeighbour(Tile a, Tile b)
        {
            Tuple<int, int> aPos = getTileIndex(a);
            Tuple<int, int> bPos = getTileIndex(b);

            int diffX = Math.Abs(aPos.Item1 - bPos.Item1);
            int diffY = Math.Abs(aPos.Item2 - bPos.Item2);

            Console.WriteLine("neighbour check: X = {0}, Y = {1}", diffX, diffY);
            if (diffX != diffY && diffX < 2 && diffY < 2)
                return true;
            return false;
        }

        private void updateTilesVisibility()
        {
            Tile t = new Tile();

            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(0); j++)
                {
                    if (isTileOwnerCurrentPlayer(tiles[i, j]))
                        t.setVisibility(true);
                    else
                        t.setVisibility(false);
                }
            }
        }

        private bool isTileOwnerCurrentPlayer(Tile tile)
        {
            return currentPlayer == tile.getGamePiece().owner;
        }

        ///////////////////////////////////////////
        /// File IO
        ///////////////////////////////////////////
        
        public bool loadGameFromFile(string filepath)
        {
            
            GC.Collect();
            return true;
        }

        public bool saveGame(string filepath)
        {
            return true;
        }
    }
}
