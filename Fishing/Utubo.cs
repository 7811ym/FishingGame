using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    //ウツボクラス
    class Utubo : Fish//魚クラスを継承
    {
        //フィールド
        private int speed;
        private bool sleeping;

        //コンストラクター
        public Utubo(int positionX, int positionY, int speed, int distanceX, PictureBox picture) : base(positionX, positionY, speed, distanceX, picture) 
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
            //起きているときは餌を食べてポイントが加算
            if (sleeping == false)
                return point;
            //寝ているときは餌を食べずポイントが入らない
            else
                return 0;
        }
    }
}
