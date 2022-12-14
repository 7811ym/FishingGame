using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    public partial class Form1 : Form
    {
        //フィールド
        private Iwashi iwashi;
        private Utubo utubo;
        private Ankou ankou;

        private int remainingTime = 600;    //残り時間,tickイベントは100msごとに起こるので60sを計測するにはtickイベントが1回起きるごとに-1して合計600回繰り返す
        private bool isDayTime = true;  //昼か夜かの状態、初めはtrueで昼
        private int daytime = 100;      //昼間は10秒,ここからtickイベントが起こるたびに-1で10s計測
        private int night = 50;         //夜は5秒
        private int score;              //得点

        public Form1()
        {
            InitializeComponent();
        }

        //アプリ起動時
        private void Form1_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;          //クライアント領域

            //イワシクラスのインスタンス
            int x = pictureBoxIwashi.Location.X;
            int y = pictureBoxIwashi.Location.Y;
            int distanceW = formSizeW - pictureBoxIwashi.Width;
            iwashi = new Iwashi(x, y, 20, distanceW, pictureBoxIwashi);

            //ウツボクラスのインスタンス
            x = pictureBoxUtubo.Location.X;
            y = pictureBoxUtubo.Location.Y;
            distanceW = formSizeW - pictureBoxUtubo.Width;
            utubo = new Utubo(x, y, 10, distanceW, pictureBoxUtubo);

            //アンコウクラスのインスタンス
            x = pictureBoxAnkou.Location.X;
            y = pictureBoxAnkou.Location.Y;
            distanceW = formSizeW - pictureBoxAnkou.Width;
            ankou = new Ankou(x, y, 10, distanceW, pictureBoxAnkou);

            //ラベルの初期化
            labelTime.Text = " 秒";
            labelPoint.Text = " 点";
        }

        //スタートボタンを押したとき
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();//残り時間の計測開始

            run();
        }

        //魚が進む処理
        private void run() 
        {
            int x, y;
            //ピクチャーボックスの位置を進める
                //イワシ
                iwashi.Run(out x, out y);//x, yに進むべき座標を代入
                iwashi.PictureMove(x, y);//x, yに基づいて画像が進む

                //ウツボ
                utubo.Run(out x, out y);//x, yに進むべき座標を代入
                utubo.PictureMove(x, y);//x, yに基づいて画像が進む

                //アンコウ
                ankou.Run(out x, out y);//x, yに進むべき座標を代入
                ankou.PictureMove(x, y);//x, yに基づいて画像が進む
        }

        //餌を食べたかの判定
        private void Form1_KeyPress(object sender, KeyPressEventArgs e) 
        {
            
            //各魚の位置座標を定義(個々のメソッド内でのみ、ifを使うときの便宜上)
            int ix = pictureBoxIwashi.Location.X + pictureBoxIwashi.Size.Width;
            int ux = pictureBoxUtubo.Location.X + pictureBoxUtubo.Size.Width;
            int ax = pictureBoxAnkou.Location.X + pictureBoxAnkou.Size.Width;

            //イワシについて
            //えさSの位置とかぶり、かつキー入力が1,2,3のとき
            if (ix >= pictureBoxEsaS.Location.X && ix <= pictureBoxEsaS.Location.X + pictureBoxEsaS.Width + 30)
            {
                if (e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3')
                {
                    score += iwashi.Eat(int.Parse(e.KeyChar.ToString()));//入力した数字キーの分だけ加算
                    labelPoint.Text = score + "点";
                    iwashi.PictureMove(-ix, -ix);           //餌を食べたら左端から再スタート
                }
            }

            //ウツボについて
            //えさLの位置とかぶり、かつキー入力が7,8,9のとき
            if (ux >= pictureBoxEsaL.Location.X && ux <= pictureBoxEsaL.Location.X + pictureBoxEsaL.Width + 30)
            {
                if (e.KeyChar == '7' || e.KeyChar == '8' || e.KeyChar == '9')
                { 
                    score += utubo.Eat(int.Parse(e.KeyChar.ToString()));//入力した数字キーの分だけ加算
                    labelPoint.Text = score + "点";
                    utubo.PictureMove(-ux, -ux);            //餌を食べたら左端から再スタート
                }
            }

            //アンコウについて
            //えさS,M,Lのいずれかとかぶり、キー入力は何でも
            //えさS
            if (ax >= pictureBoxEsaS.Location.X && ax <= pictureBoxEsaS.Location.X + pictureBoxEsaS.Width + 30)
            {
                score += ankou.Eat(int.Parse(e.KeyChar.ToString()));
                labelPoint.Text = score + "点";
                ankou.PictureMove(-ax, -ax);
            }  
            //えさM
            else if (ax >= pictureBoxEsaM.Location.X && ax <= pictureBoxEsaM.Location.X + pictureBoxEsaM.Width + 30)
            {
                score += ankou.Eat(int.Parse(e.KeyChar.ToString()));
                labelPoint.Text = score + "点";
                ankou.PictureMove(-ax, -ax);
            }
            //えさL
            else if (ux >= pictureBoxEsaL.Location.X && ux <= pictureBoxEsaL.Location.X + pictureBoxEsaL.Width + 30)
            {
                score += ankou.Eat(int.Parse(e.KeyChar.ToString()));
                labelPoint.Text = score + "点";
                ankou.PictureMove(-ax, -ax);
            }
            
            /*
            if (e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3')
            {
                score += iwashi.Eat(int.Parse(e.KeyChar.ToString()));//入力した数字キーの分だけ加算
                labelPoint.Text = score + "点";
                iwashi.PictureMove(0, 0);           //餌を食べたら左端から再スタート
            }
            */
        }

        //タイマー１のイベントハンドラ
        private void timer1_Tick(object sender, EventArgs e)
        {
            //魚を動かす
            run();

            //残り時間の計測
            remainingTime -= 1;

            //常に残り時間と得点を表示
            labelTime.Text = remainingTime/10 + "秒";
            labelPoint.Text = score + "点";

            //昼と夜の切り替え
            //昼の場合
            if (isDayTime == true)
            {
                //時間計測
                daytime -= 1;

                //魚が起きる
                iwashi.WakeUp();
                utubo.WakeUp();

                //10s経ったら、夜状態にして背景を変更、昼の変数を元の10sに戻す
                if (daytime == 0)
                {
                    isDayTime = false;
                    this.BackColor = Color.Blue;
                    daytime = 100;
                }
            }

            //夜の場合
            else 
            {
                //時間計測
                night -= 1;

                //魚が寝る
                iwashi.Sleep();
                utubo.Sleep();

                //5s経ったら夜が終了
                if (night == 0) 
                {
                    isDayTime = true;
                    this.BackColor = Color.White;
                    night = 50;
                }
            }

            //制限時間60秒で終了
            if (remainingTime == 0)
            {
                timer1.Stop();
                labelTime.Text = "終了";
            }

        }
    }
}
