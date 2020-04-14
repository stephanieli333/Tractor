using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tractor
{
    public class GameManager
    {
        public Player P1 { get; set; }
        public Player P2 { get; set; }
        public Player P3 { get; set; }
        public Player P4 { get; set; }
        // draws cards one at a time into 4 hands, sorts, leaves 8 @ bottom
        // if you draw a card of the trump rank, then prompt user to show card or continue
        // update hands based on information received by the controller
        // keep track of points and gameplay 
        // has method to check for validity of move

    }
}
