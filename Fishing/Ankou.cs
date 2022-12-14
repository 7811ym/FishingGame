using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    //アンコウクラス
    class Ankou : Fish //魚クラスを継承
    {
        public Ankou(int positionX, int positionY, int speed, int distanceX, PictureBox picture) : base(positionX, positionY, speed, distanceX, picture)
        {
        }
    }
}
