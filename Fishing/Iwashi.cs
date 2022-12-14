using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    //イワシクラス
    class Iwashi : Fish//魚クラスを継承
    {
        //フィールド
        private bool sleeping;//寝ているかどうか

        //コンストラクター
        public Iwashi(int positionX, int positionY, int speed, int distanceX, PictureBox picture) : base(positionX, positionY, speed, distanceX, picture) 
        {
        }

        //眠る
        public void Sleep() 
        {
            sleeping = true;
        }

        //起きる
        public void WakeUp() 
        {
            sleeping = false;
        }

        //食べる
        public new int Eat(int point) 
        {
            //起きているときのみ餌を食べてポイントを加算
            if (sleeping == false)
                return point;
            //寝ているときはポイントは入らない
            else
                return 0;
        }
    }
}
