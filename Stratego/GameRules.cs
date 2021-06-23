using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    public static class GameRules
    {
        public static bool canMove(Tile a, Tile b)
        {
            /// If trying to move to itself, deny
            if (a == b) return false;

            /// If trying to move onto friendly tile, deny
            //if (a.getGamePiece().owner == b.)

            /// If piece cannot move, return false

            /// If none of the above, return true
            return true;
        }

        public static bool isEncounterSuccess(Tile attacker, Tile defender)
        {
            return isEncounterSuccess(attacker.getGamePiece().character, defender.getGamePiece().character);
        }

        public static bool isEncounterSuccess(Character attacker, Character defender)
        {
            /// is the attacker successful against the defender
            return true;
        }
    }
}
