
namespace Fishing
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPoint = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxAnkou = new System.Windows.Forms.PictureBox();
            this.pictureBoxIsogintyaku = new System.Windows.Forms.PictureBox();
            this.pictureBoxEsaL = new System.Windows.Forms.PictureBox();
            this.pictureBoxEsaS = new System.Windows.Forms.PictureBox();
            this.pictureBoxUtubo = new System.Windows.Forms.PictureBox();
            this.pictureBoxHitode = new System.Windows.Forms.PictureBox();
            this.pictureBoxEsaM = new System.Windows.Forms.PictureBox();
            this.pictureBoxIwashi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnkou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIsogintyaku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtubo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHitode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIwashi)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(26, 25);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(112, 40);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "スタート";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(186, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "残り時間：";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTime.Location = new System.Drawing.Point(306, 36);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(48, 24);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "0秒";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(392, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "得点：";
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPoint.Location = new System.Drawing.Point(471, 36);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(48, 24);
            this.labelPoint.TabIndex = 4;
            this.labelPoint.Text = "0点";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxAnkou
            // 
            this.pictureBoxAnkou.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAnkou.Image")));
            this.pictureBoxAnkou.Location = new System.Drawing.Point(3, 544);
            this.pictureBoxAnkou.Name = "pictureBoxAnkou";
            this.pictureBoxAnkou.Size = new System.Drawing.Size(200, 197);
            this.pictureBoxAnkou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAnkou.TabIndex = 5;
            this.pictureBoxAnkou.TabStop = false;
            // 
            // pictureBoxIsogintyaku
            // 
            this.pictureBoxIsogintyaku.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIsogintyaku.Image")));
            this.pictureBoxIsogintyaku.Location = new System.Drawing.Point(498, 651);
            this.pictureBoxIsogintyaku.Name = "pictureBoxIsogintyaku";
            this.pictureBoxIsogintyaku.Size = new System.Drawing.Size(97, 100);
            this.pictureBoxIsogintyaku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxIsogintyaku.TabIndex = 6;
            this.pictureBoxIsogintyaku.TabStop = false;
            // 
            // pictureBoxEsaL
            // 
            this.pictureBoxEsaL.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEsaL.Image")));
            this.pictureBoxEsaL.Location = new System.Drawing.Point(1163, 316);
            this.pictureBoxEsaL.Name = "pictureBoxEsaL";
            this.pictureBoxEsaL.Size = new System.Drawing.Size(42, 100);
            this.pictureBoxEsaL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEsaL.TabIndex = 7;
            this.pictureBoxEsaL.TabStop = false;
            // 
            // pictureBoxEsaS
            // 
            this.pictureBoxEsaS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEsaS.Image")));
            this.pictureBoxEsaS.Location = new System.Drawing.Point(696, 124);
            this.pictureBoxEsaS.Name = "pictureBoxEsaS";
            this.pictureBoxEsaS.Size = new System.Drawing.Size(21, 50);
            this.pictureBoxEsaS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEsaS.TabIndex = 9;
            this.pictureBoxEsaS.TabStop = false;
            // 
            // pictureBoxUtubo
            // 
            this.pictureBoxUtubo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUtubo.Image")));
            this.pictureBoxUtubo.Location = new System.Drawing.Point(0, 274);
            this.pictureBoxUtubo.Name = "pictureBoxUtubo";
            this.pictureBoxUtubo.Size = new System.Drawing.Size(300, 172);
            this.pictureBoxUtubo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUtubo.TabIndex = 10;
            this.pictureBoxUtubo.TabStop = false;
            // 
            // pictureBoxHitode
            // 
            this.pictureBoxHitode.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHitode.Image")));
            this.pictureBoxHitode.Location = new System.Drawing.Point(1847, 666);
            this.pictureBoxHitode.Name = "pictureBoxHitode";
            this.pictureBoxHitode.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxHitode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHitode.TabIndex = 11;
            this.pictureBoxHitode.TabStop = false;
            // 
            // pictureBoxEsaM
            // 
            this.pictureBoxEsaM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEsaM.Image")));
            this.pictureBoxEsaM.Location = new System.Drawing.Point(1627, 651);
            this.pictureBoxEsaM.Name = "pictureBoxEsaM";
            this.pictureBoxEsaM.Size = new System.Drawing.Size(31, 75);
            this.pictureBoxEsaM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEsaM.TabIndex = 12;
            this.pictureBoxEsaM.TabStop = false;
            // 
            // pictureBoxIwashi
            // 
            this.pictureBoxIwashi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIwashi.Image")));
            this.pictureBoxIwashi.Location = new System.Drawing.Point(3, 125);
            this.pictureBoxIwashi.Name = "pictureBoxIwashi";
            this.pictureBoxIwashi.Size = new System.Drawing.Size(150, 49);
            this.pictureBoxIwashi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxIwashi.TabIndex = 13;
            this.pictureBoxIwashi.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 745);
            this.Controls.Add(this.pictureBoxIwashi);
            this.Controls.Add(this.pictureBoxEsaM);
            this.Controls.Add(this.pictureBoxHitode);
            this.Controls.Add(this.pictureBoxUtubo);
            this.Controls.Add(this.pictureBoxEsaS);
            this.Controls.Add(this.pictureBoxEsaL);
            this.Controls.Add(this.pictureBoxIsogintyaku);
            this.Controls.Add(this.pictureBoxAnkou);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "釣りゲーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnkou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIsogintyaku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtubo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHitode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIwashi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxAnkou;
        private System.Windows.Forms.PictureBox pictureBoxIsogintyaku;
        private System.Windows.Forms.PictureBox pictureBoxEsaL;
        private System.Windows.Forms.PictureBox pictureBoxEsaS;
        private System.Windows.Forms.PictureBox pictureBoxUtubo;
        private System.Windows.Forms.PictureBox pictureBoxHitode;
        private System.Windows.Forms.PictureBox pictureBoxEsaM;
        private System.Windows.Forms.PictureBox pictureBoxIwashi;
    }
}

