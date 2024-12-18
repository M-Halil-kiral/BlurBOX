using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlurBOX.Blurgames.MayınTarlası
{
    public class Cell
    {
            public bool IsMine { get; set; }
            public bool IsRevealed { get; set; }
            public bool IsFlagged { get; set; }
            public int AdjacentMines { get; set; }

    }


}
