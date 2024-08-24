using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeFacade
{
    public class Cell
    {
        private MarkType mark;

        public Cell()
        {
            mark = MarkType.EMPTY;
        }

        public bool IsEmpty()
        {
            return mark == MarkType.EMPTY;
        }

        public MarkType GetMark()
        {
            return mark;
        }

        public void SetMark(MarkType mark)
        {
            if (!IsEmpty())
            {
                throw new InvalidOperationException("Cell is already marked.");
            }
            this.mark = mark;
        }
    }
}