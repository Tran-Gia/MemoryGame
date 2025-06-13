using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Enums
{
    public enum MatchingState
    {
        None,
        Selected,
        Revealed,
        Blocked,
    }
}

//Revealed means the player can see its image, but cannot select it while it's being revealed
//Blocked means the player cannot select it whatsoever
