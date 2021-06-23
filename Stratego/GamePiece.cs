using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    public class GamePiece
    {
        public Character character;
        public Owner owner;

        public GamePiece()
        {
            this.character = Character.None;
            this.owner = Owner.None;
        }

        public GamePiece(Character c, Owner o)
        {
            this.character = c;
            this.owner = o;
        }
    }
}
