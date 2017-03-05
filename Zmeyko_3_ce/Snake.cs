using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeyko_3_ce
{
    class Snake
    {
        public Snake()
        {
            Body = new List<Segment>();
            Body.Add(new Segment(0, 0));
            Drawing.putSymbol(getHead().x, getHead().y, "O".ToCharArray()[0]);
            Body.Add(new Segment(0, 1));
            Drawing.putSymbol(getHead().x, getHead().y, "O".ToCharArray()[0]);
        }

        public List<Segment> Body;

        public Segment getHead()
        {
            return Body.Last();
        }

        public Segment getTail()
        {
            return Body.First();
        }

        public Ways snake_direction;

        public void createNewHead()
        {
            Segment currentHead = this.getHead();
            
            switch (snake_direction)
                {
                case Ways.right: Body.Add(new Segment(currentHead.x + 1, currentHead.y));
                    break;
                case Ways.left:
                    Body.Add(new Segment(currentHead.x - 1, currentHead.y));
                    break;
                case Ways.up:
                    Body.Add(new Segment(currentHead.x, currentHead.y - 1));
                    break;
                case Ways.down:
                    Body.Add(new Segment(currentHead.x, currentHead.y + 1));
                    break;
            }

            
        }

        public void Move()
        {
            this.snake_direction = Game.current_direction;
            createNewHead();
            Drawing.putSymbol(this.getHead().x, this.getHead().y, "O".ToCharArray()[0]);
            if (getHead().x != Game.apple4s.x && getHead().y != Game.apple4s.y) {
                Drawing.eraseSymbol(this.getTail().x, this.getTail().y);
                Body.RemoveAt(0);
            }
            
        }
    }
}
