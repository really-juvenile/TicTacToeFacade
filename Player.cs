using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeFacade
{
    public class Player
    {
        private MarkType mark;

        public Player(MarkType mark)
        {
            this.mark = mark;
        }

        public MarkType GetMark()
        {
            return mark;
        }
    }
}