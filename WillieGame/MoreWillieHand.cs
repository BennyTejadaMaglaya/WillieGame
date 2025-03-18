using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillieGame
{
    public partial class WillieHand
    {
        public int Wonka
        {
            get
            {
                if (_CardOne > _CardTwo)
                {
                    return _CardOne;
                }
                else
                {
                    return _CardTwo;
                }
            }
        }
    }
}
