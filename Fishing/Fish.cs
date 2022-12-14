using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;     //追加


namespace Fishing
{
    //魚クラス
    class Fish
    {
        //フィールド
        private PictureBox picture;

        //コンストラクター
        public Fish(int positionX, int positionY, int speed, int distanceW, PictureBox picture) 
        {
            PositionX = positionX;
            PositionY = positionY;
            Speed = speed;
            DistanceW = distanceW;//画面右端までの距離
            this.picture = picture;
        }

        //プロパティ
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Speed { get; set; }
        public int DistanceW { get; set; }

        //移動
        public void Run(out int x, out int y) 
        {
            //x座標をスピード分進める
            PositionX += Speed;

            //画面右端に到着したら、再度画面左端から現れる
            if (PositionX >= DistanceW)
                PositionX = 0;

            //x,yに現在の座標を代入
            x = PositionX;
            y = PositionY;
        }

        //ピクチャーボックスの移動
        public void PictureMove(int x, int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }

        //食べる
        public int Eat(int point) 
        {
            return point;
        }
    }
}
