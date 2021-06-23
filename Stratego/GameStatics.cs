using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    public enum Character
    {
        None,
        Flag,
        Sergeant,
        Captain,
        General
    }

    public enum GameState
    {
        PreGame,
        InGame,
        PostGame,
        Paused
    }

    public enum Owner
    {
        None,
        Player1,
        Player2
    }
    public static class GameStatics
    {
        public static int GridSize = 6;

        public static Character[] DefaultBackRow =
        {
            // back row
            Character.General,
            Character.Sergeant,
            Character.Captain,
            Character.Flag,
            Character.Captain,
            Character.Sergeant  
        };

        public static Character[] DefaultFrontRow =
        {
            // back row
            Character.Sergeant,
            Character.Sergeant,
            Character.Sergeant,
            Character.Sergeant,
            Character.Sergeant,
            Character.Sergeant
        };

        public static string instructionString = 
            "How to play Stratego.\nStratego is a tile-based board game where 2 players battle with military units(MU's).\n" + 
            "The objective is to capture the opponents flag unit. The first player to capture their opponent's flag wins. What " +
            "differentiates Stratego from other games like chess is that each player cannot see the opponent's MU types.\n" + 
            "The game is played in turns. Player 1 starts, followed by player 2, followed by player 1, etc.\nBefore the game begins," +
            " players perform Formation, where they can rearrange their MU's by dragging an MU onto the desired tile.\nOnce each player" +
            " has finished formation, a player starts the game.During the game, MU's can move a single tile Up, Down, Left or Right. " +
            "A MU cannot move onto a tile occupied by a friendly MU. If a MU moves onto a tile occupied by an enemy MU, the two MU's " +
            "will perform combat. In combat, the winner is the tile with the higher rank, or if the ranks are equal, the aggressor.\n\n" + 
            "Instructions:\n" + "1. Start a new game\n" + "2. Player 1 performs Formation (rearrange MU's)\n" + "3. Player 2 performs" +
            " Formation.\n4. A player clicks the Start button.\n5. Player 1 moves a single MU. The turn automatically passes to player 2.\n" +
            "6. Player 2 moves a single MU. The turn automatically passes to player 1.\n7. Repeat steps 5 and 6 until a player wins.";
                
    }


}

