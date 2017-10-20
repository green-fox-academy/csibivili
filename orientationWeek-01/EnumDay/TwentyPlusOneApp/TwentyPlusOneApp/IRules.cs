using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOneApp
{
    public interface IRules
    {
        void Deal(Game game, int HowMuch);
        int ValueOfHand(List<Card> hand);
    }
}
