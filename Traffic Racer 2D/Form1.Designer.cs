namespace Traffic_Racer_2D
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSolSerit6 = new System.Windows.Forms.Label();
            this.labelSagSerit6 = new System.Windows.Forms.Label();
            this.labelSagSerit5 = new System.Windows.Forms.Label();
            this.labelSolSerit5 = new System.Windows.Forms.Label();
            this.labelSagSerit4 = new System.Windows.Forms.Label();
            this.labelSolSerit4 = new System.Windows.Forms.Label();
            this.labelSagSerit3 = new System.Windows.Forms.Label();
            this.labelSolSerit3 = new System.Windows.Forms.Label();
            this.labelSagSerit2 = new System.Windows.Forms.Label();
            this.labelSolSerit2 = new System.Windows.Forms.Label();
            this.labelSagSerit1 = new System.Windows.Forms.Label();
            this.labelSolSerit1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelRoad = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelHighScore = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RedCar = new System.Windows.Forms.PictureBox();
            this.timerSerit = new System.Windows.Forms.Timer(this.components);
            this.timerRandomCar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedCar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-1, -9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 712);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(681, -9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 712);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 653);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(691, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // labelSolSerit6
            // 
            this.labelSolSerit6.BackColor = System.Drawing.Color.White;
            this.labelSolSerit6.Location = new System.Drawing.Point(223, -117);
            this.labelSolSerit6.Name = "labelSolSerit6";
            this.labelSolSerit6.Size = new System.Drawing.Size(10, 93);
            this.labelSolSerit6.TabIndex = 3;
            // 
            // labelSagSerit6
            // 
            this.labelSagSerit6.BackColor = System.Drawing.Color.White;
            this.labelSagSerit6.Location = new System.Drawing.Point(443, -124);
            this.labelSagSerit6.Name = "labelSagSerit6";
            this.labelSagSerit6.Size = new System.Drawing.Size(11, 93);
            this.labelSagSerit6.TabIndex = 4;
            // 
            // labelSagSerit5
            // 
            this.labelSagSerit5.BackColor = System.Drawing.Color.White;
            this.labelSagSerit5.Location = new System.Drawing.Point(443, 9);
            this.labelSagSerit5.Name = "labelSagSerit5";
            this.labelSagSerit5.Size = new System.Drawing.Size(11, 93);
            this.labelSagSerit5.TabIndex = 6;
            // 
            // labelSolSerit5
            // 
            this.labelSolSerit5.BackColor = System.Drawing.Color.White;
            this.labelSolSerit5.Location = new System.Drawing.Point(223, 16);
            this.labelSolSerit5.Name = "labelSolSerit5";
            this.labelSolSerit5.Size = new System.Drawing.Size(10, 93);
            this.labelSolSerit5.TabIndex = 5;
            // 
            // labelSagSerit4
            // 
            this.labelSagSerit4.BackColor = System.Drawing.Color.White;
            this.labelSagSerit4.Location = new System.Drawing.Point(443, 142);
            this.labelSagSerit4.Name = "labelSagSerit4";
            this.labelSagSerit4.Size = new System.Drawing.Size(11, 93);
            this.labelSagSerit4.TabIndex = 8;
            // 
            // labelSolSerit4
            // 
            this.labelSolSerit4.BackColor = System.Drawing.Color.White;
            this.labelSolSerit4.Location = new System.Drawing.Point(223, 149);
            this.labelSolSerit4.Name = "labelSolSerit4";
            this.labelSolSerit4.Size = new System.Drawing.Size(10, 93);
            this.labelSolSerit4.TabIndex = 7;
            // 
            // labelSagSerit3
            // 
            this.labelSagSerit3.BackColor = System.Drawing.Color.White;
            this.labelSagSerit3.Location = new System.Drawing.Point(443, 290);
            this.labelSagSerit3.Name = "labelSagSerit3";
            this.labelSagSerit3.Size = new System.Drawing.Size(11, 93);
            this.labelSagSerit3.TabIndex = 10;
            // 
            // labelSolSerit3
            // 
            this.labelSolSerit3.BackColor = System.Drawing.Color.White;
            this.labelSolSerit3.Location = new System.Drawing.Point(223, 297);
            this.labelSolSerit3.Name = "labelSolSerit3";
            this.labelSolSerit3.Size = new System.Drawing.Size(10, 93);
            this.labelSolSerit3.TabIndex = 9;
            // 
            // labelSagSerit2
            // 
            this.labelSagSerit2.BackColor = System.Drawing.Color.White;
            this.labelSagSerit2.Location = new System.Drawing.Point(443, 427);
            this.labelSagSerit2.Name = "labelSagSerit2";
            this.labelSagSerit2.Size = new System.Drawing.Size(11, 93);
            this.labelSagSerit2.TabIndex = 12;
            // 
            // labelSolSerit2
            // 
            this.labelSolSerit2.BackColor = System.Drawing.Color.White;
            this.labelSolSerit2.Location = new System.Drawing.Point(223, 434);
            this.labelSolSerit2.Name = "labelSolSerit2";
            this.labelSolSerit2.Size = new System.Drawing.Size(10, 93);
            this.labelSolSerit2.TabIndex = 11;
            // 
            // labelSagSerit1
            // 
            this.labelSagSerit1.BackColor = System.Drawing.Color.White;
            this.labelSagSerit1.Location = new System.Drawing.Point(443, 549);
            this.labelSagSerit1.Name = "labelSagSerit1";
            this.labelSagSerit1.Size = new System.Drawing.Size(11, 93);
            this.labelSagSerit1.TabIndex = 14;
            // 
            // labelSolSerit1
            // 
            this.labelSolSerit1.BackColor = System.Drawing.Color.White;
            this.labelSolSerit1.Location = new System.Drawing.Point(223, 556);
            this.labelSolSerit1.Name = "labelSolSerit1";
            this.labelSolSerit1.Size = new System.Drawing.Size(10, 93);
            this.labelSolSerit1.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(20, 656);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 33);
            this.label16.TabIndex = 16;
            this.label16.Text = "Speed:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.Color.Black;
            this.labelSpeed.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.ForeColor = System.Drawing.Color.White;
            this.labelSpeed.Location = new System.Drawing.Point(129, 656);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(117, 33);
            this.labelSpeed.TabIndex = 17;
            this.labelSpeed.Text = "0 km/h";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Black;
            this.label18.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(252, 656);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 33);
            this.label18.TabIndex = 18;
            this.label18.Text = "Road:";
            // 
            // labelRoad
            // 
            this.labelRoad.AutoSize = true;
            this.labelRoad.BackColor = System.Drawing.Color.Black;
            this.labelRoad.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoad.ForeColor = System.Drawing.Color.White;
            this.labelRoad.Location = new System.Drawing.Point(350, 656);
            this.labelRoad.Name = "labelRoad";
            this.labelRoad.Size = new System.Drawing.Size(63, 33);
            this.labelRoad.TabIndex = 19;
            this.labelRoad.Text = "0 m";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Black;
            this.label20.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(419, 656);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(206, 33);
            this.label20.TabIndex = 20;
            this.label20.Text = "High Score :";
            // 
            // labelHighScore
            // 
            this.labelHighScore.AutoSize = true;
            this.labelHighScore.BackColor = System.Drawing.Color.Black;
            this.labelHighScore.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighScore.ForeColor = System.Drawing.Color.White;
            this.labelHighScore.Location = new System.Drawing.Point(626, 656);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(63, 33);
            this.labelHighScore.TabIndex = 21;
            this.labelHighScore.Text = "0 m";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(29, 605);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(52, 37);
            this.axWindowsMediaPlayer1.TabIndex = 22;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Traffic_Racer_2D.Properties.Resources.volumeON;
            this.pictureBox2.Location = new System.Drawing.Point(645, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // RedCar
            // 
            this.RedCar.Image = global::Traffic_Racer_2D.Properties.Resources.car3;
            this.RedCar.Location = new System.Drawing.Point(290, 556);
            this.RedCar.Name = "RedCar";
            this.RedCar.Size = new System.Drawing.Size(90, 86);
            this.RedCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedCar.TabIndex = 15;
            this.RedCar.TabStop = false;
            // 
            // timerSerit
            // 
            this.timerSerit.Enabled = true;
            this.timerSerit.Interval = 150;
            this.timerSerit.Tick += new System.EventHandler(this.timerSerit_Tick);
            // 
            // timerRandomCar
            // 
            this.timerRandomCar.Enabled = true;
            this.timerRandomCar.Interval = 150;
            this.timerRandomCar.Tick += new System.EventHandler(this.timerRandomCar_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(705, 698);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.labelHighScore);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.labelRoad);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.RedCar);
            this.Controls.Add(this.labelSagSerit1);
            this.Controls.Add(this.labelSolSerit1);
            this.Controls.Add(this.labelSagSerit2);
            this.Controls.Add(this.labelSolSerit2);
            this.Controls.Add(this.labelSagSerit3);
            this.Controls.Add(this.labelSolSerit3);
            this.Controls.Add(this.labelSagSerit4);
            this.Controls.Add(this.labelSolSerit4);
            this.Controls.Add(this.labelSagSerit5);
            this.Controls.Add(this.labelSolSerit5);
            this.Controls.Add(this.labelSagSerit6);
            this.Controls.Add(this.labelSolSerit6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traffic Racer 2D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSolSerit6;
        private System.Windows.Forms.Label labelSagSerit6;
        private System.Windows.Forms.Label labelSagSerit5;
        private System.Windows.Forms.Label labelSolSerit5;
        private System.Windows.Forms.Label labelSagSerit4;
        private System.Windows.Forms.Label labelSolSerit4;
        private System.Windows.Forms.Label labelSagSerit3;
        private System.Windows.Forms.Label labelSolSerit3;
        private System.Windows.Forms.Label labelSagSerit2;
        private System.Windows.Forms.Label labelSolSerit2;
        private System.Windows.Forms.Label labelSagSerit1;
        private System.Windows.Forms.Label labelSolSerit1;
        private System.Windows.Forms.PictureBox RedCar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelRoad;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelHighScore;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerSerit;
        private System.Windows.Forms.Timer timerRandomCar;
    }
}

