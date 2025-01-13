using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Racer_2D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int SeritSayisi = 1; // aslında bu orta şerite verdiğimiz numara bunun üzerinde yapacağımız şeyleri ortaşerit üzerinde yapıyoruz 
        int Road = 0;
        int Speed = 1000;
        Random R = new Random();

        class Random_CAR
        {
            public bool FakeHaveCar = false;
            public PictureBox FakeCar; // nesne oluşturduk bu nesne aracılığıyla resimleri atayacaz  
            public bool vakit = false;

        }

        Random_CAR[] rndCar = new Random_CAR[2];

        void BringRandomCar(PictureBox pb) // böylece arabaları çekmiş olacaz 
        {
            int rnd = R.Next(0, 4);
            switch (rnd)
            {
                case 0:
                    pb.Image = Properties.Resources.car0;
                    break;
                case 1:
                    pb.Image = Properties.Resources.car1;
                    break;
                case 2:
                    pb.Image = Properties.Resources.car2;
                    break;
                case 3:
                    pb.Image = Properties.Resources.car3;
                    break;

            }
            pb.SizeMode = PictureBoxSizeMode.StretchImage; // seçilen arabanın tam picturebox ın içine yerleşecek şekilde olmasını istiyorum 

        }


        private void AracYerine() // bu method ile aracı kontrol etmiş oluyoruz 
        {
            if (SeritSayisi == 1) // başlangıçta orta şeritten başlasın diye ilk konumu ayarladık 
            {
                RedCar.Location = new Point(220, 405);
            }
            else if (SeritSayisi == 0) // sol tuşuna basınca sola geçtiğindeki konumu ayarladık
            {
                RedCar.Location = new Point(65, 405);
            }
            else if (SeritSayisi == 2) // sağ tuşa bastığında sağ şeritteki konumunu ayarladık 
            {
                RedCar.Location = new Point(400, 405);
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e) // kullanıcı herhangi bir tuşa pastığında algılanmasını sağlar bu KeyDown anahtarı
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) // klavyenin sağ ok tuşuna basılırsa 
            {
                if (SeritSayisi < 2) // bizim sağ tuşa basıldığında şerit sayımız 2 den küçükse yani en sağda değilse  o zaman şerit sayısını arttır ve şerit numarasının konumunu ayarla 
                {
                    SeritSayisi++;
                }
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) // sol tuşa basıldığında şerit sayısı 0 dan büyükse yani en solda değil ise şerit sayısını eksilt ve yeni şerit numarasına göre yeni konumu ayarla 
            {
                if (SeritSayisi > 0)
                {
                    SeritSayisi--;
                }
            }

            AracYerine();
        }

        private void RandomMusicEkle()
        {
            int MuzikDeger = R.Next(1, 4); // 1 den 4 e kadar random bir sayı verecek 

            axWindowsMediaPlayer1.URL = @"music/track " + MuzikDeger.ToString() + ".mp3"; // oynatılacak medya dosyasının yolunu (path) veya adını belirtir. Bu örnekte bir müzik dosyası yolu atanıyor:
            axWindowsMediaPlayer1.Ctlcontrols.play(); //  medya kontrol işlemleri (oynat, durdur, duraklat vb.) için kullanılır.
            // böylece rastgele bir müzik eklemiş olacaz 
            // eğer debug içine atmazsan tam dosya yolunu yazmak zorundasın ve dosya ismi de tam yaptığın forma uygun olmalı 
            // uzantısını eklemeyi unutmamak lazım 

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            AracYerine(); // form ilk başladığında ki araç yerini ayarlamak için 
            RandomMusicEkle();  // oyun başladığında rastgele müzik çalması için methodu çağırmış olduk 


            for (var i = 0; i < rndCar.Length; i++)
            {
                rndCar[i] = new Random_CAR();
            }

            rndCar[0].vakit = true;
            labelHighScore.Text = Settings1.Default.HighScore.ToString();

        }

        bool SesKontrol = true; // başlangıçta ses açık olsun 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (SesKontrol == true) // yani açıkken tıklandığında 
            {
                SesKontrol = false; //  sesi kapatması için false yaptık 
                axWindowsMediaPlayer1.Ctlcontrols.pause(); // pause demek kapat demek 
                pictureBox2.Image = Properties.Resources.volumeOff; // yani bu da açık olan sembol yerine kapalı olan sembolü getir demek 
            }
            else if (SesKontrol == false) // bu da ses kapalı iken basıldığında 
            {
                SesKontrol = true; // ses açık olsun demek 
                axWindowsMediaPlayer1.Ctlcontrols.play(); // sesi açması için gerekli 
                pictureBox2.Image = Properties.Resources.volumeON; // ses açıldığında ses açık olan sembolü getirsin diye 
            }
        }


        bool SeritHareket = false;

        void HızLevel()
        {
            //// 2. seviye 
            //if(Road>150 && Road < 300)
            //{
            //    Speed = 100;
            //    timerSerit.Interval = 125; // 20 piksellik bir hareket var 
            //    timerRandomCar.Interval = 100; // 25 piksellik bir hareket var 

            //}

            //// 3.seviye

            //else if (Road > 300 && Road < 550)
            //{
            //    Speed = 130;
            //    timerSerit.Interval = 10; // 20 piksellik bir hareket var 
            //    timerRandomCar.Interval = 80; // 25 piksellik bir hareket var 

            //}

            // 4.seviye

            if (Road > 20 )
            {
                Speed = 170;
                timerSerit.Interval = 80; // 20 piksellik bir hareket var 
                timerRandomCar.Interval = 20; // 25 piksellik bir hareket var 

            }

        }
        private void timerSerit_Tick(object sender, EventArgs e) // ileri geri hareket yapacaktık ve aynı zamanda sonsuz döngü yapacaz şeritleri hareket etmiş gibi gösterecez 
        {
            Road += 1;

            HızLevel();

            if (SeritHareket == false)
            {
                for (int i = 1; i < 7; i++) // toplam 6 şerit var diye her birini ayrı ayrı hareket ettirecek kodu yazmak yük olur bu yöntem daha kısa 
                {
                    this.Controls.Find("labelSolSerit" + i.ToString(), true)[0].Top -= 25; // ilk başta yukarı doğru bir hareket olacak top kısmından sürekli 25 çıkaracak bu da ileri yönlüymüş gibi bi hareket sağlayacak
                                                                                           // ilgili nesneyi bulmasını söylüyoruz 

                    this.Controls.Find("labelSagSerit" + i.ToString(), true)[0].Top -= 25; // bu da sağ şerit için böylece çalıştığında her iki şeritte yukarı doğru hareket edecek 
                    // sonsuz döngü için 
                    SeritHareket = true;
                }
            }
            else
            {
                for (int i = 1; i < 7; i++) // toplam 6 şerit var diye her birini ayrı ayrı hareket ettirecek kodu yazmak yük olur bu yöntem daha kısa 
                {
                    this.Controls.Find("labelSolSerit" + i.ToString(), true)[0].Top += 25;  // top kısmından sürekli 25 ekleyecek bu da aşağı yönlüymüş gibi bi hareket sağlayacak
                                                                                            // ilgili nesneyi bulmasını söylüyoruz find ile label adını tam yazmamız lazım ama 

                    this.Controls.Find("labelSagSerit" + i.ToString(), true)[0].Top += 25; // bu da sağ şerit için böylece çalıştığında her iki şeritte aşağı doğru hareket edecek 
                    // sonsuz döngü için 
                    SeritHareket = false; // bunlar sayesinde sonsuz bir döngü olmuş oldu 

                }
            }

            labelRoad.Text = Road.ToString() + "m";
            labelSpeed.Text = Speed.ToString() + "km/h";

        }

        private void timerRandomCar_Tick(object sender, EventArgs e)
        {


            for (int i = 0; i < rndCar.Length; i++)
            {
                if (!rndCar[i].FakeHaveCar && rndCar[i].vakit)
                {                    rndCar[i].FakeCar = new PictureBox();
                    BringRandomCar(rndCar[i].FakeCar);
                    rndCar[i].FakeCar.Size = new Size(70, 130); // bu aslında gelecek olan araçların boyutu 
                    rndCar[i].FakeCar.Top = -rndCar[i].FakeCar.Height; // gelen arçatan sonra gelen bir sonraki araç art arda gelmesin diye yazılam kod 
                                                                       // bu kod satırı sayesinde bir araç gelecek ve yeni bir aracın gelmesi için bir araç boyu o aracın aşağı inmesi gerekiyor ki araçlar mesafeli gelsin 

                    int Sol_Yerles = R.Next(0, 3);

                    if (Sol_Yerles == 0) // böylece araçların geldikleri şerite göre konumlarını belirlemiş olduk 
                    {
                        rndCar[i].FakeCar.Left = 55;
                    }
                    else if (Sol_Yerles == 1)
                    {
                        rndCar[i].FakeCar.Left = 210;
                    }
                    else if (Sol_Yerles == 2)
                    {
                        rndCar[i].FakeCar.Left = 390;
                    }

                    this.Controls.Add(rndCar[i].FakeCar);
                    rndCar[i].FakeHaveCar = true;

                    // yukarıdaki satırlarda arabaları oluşturup şeritlerine yerleştirmiş olduk 

                }
                else
                {
                    if (rndCar[i].vakit)
                    {
                        rndCar[i].FakeCar.Top += 20;
                        if (rndCar[i].FakeCar.Top >= 154)
                        {
                            for (int j = 0; j < rndCar.Length; j++)
                            {
                                if (!rndCar[j].vakit)
                                {
                                    rndCar[j].vakit = true;
                                    break;
                                }
                            }
                        }


                        if (rndCar[i].FakeCar.Top >= this.Height - 20) // araç düştükten sonra sonsuza kadar aşağı gitmesin diye ekranın dışına çıktıktan 20 piksel sonra bunu kapat ve döngüden çık
                        {
                            rndCar[i].FakeCar.Dispose(); // aracı durdur çıkar anlamında 
                            rndCar[i].FakeHaveCar = false;
                            rndCar[i].vakit = false;
                        }
                    }

                }

                // kaza durumu 

                if (rndCar[i].vakit) // true ise sanal araba ekrandadır demektir 
                {
                    float MutlakX = Math.Abs((RedCar.Left + (RedCar.Width / 2)) - (rndCar[i].FakeCar.Left + (rndCar[i].FakeCar.Width / 2)));
                    float MutlakY = Math.Abs((RedCar.Top + (RedCar.Height / 2)) - (rndCar[i].FakeCar.Top + (rndCar[i].FakeCar.Height / 2)));
                    float FarkGenislik = (RedCar.Width / 2) + (rndCar[i].FakeCar.Width / 2);
                    float FarkYukseklik = (RedCar.Height / 2) + (rndCar[i].FakeCar.Height / 2);

                    if ((FarkGenislik > MutlakX) && (FarkYukseklik > MutlakY)) // kaza durumu burada gerçekleşiyor 
                    {

                        timerRandomCar.Enabled = false;
                        timerSerit.Enabled = false;
                        axWindowsMediaPlayer1.Ctlcontrols.pause();
                        axWindowsMediaPlayer1.URL = @"music/crash.mp3"; // kaza yapıldığı anda kaza sesini versin diye 
                        axWindowsMediaPlayer1.Ctlcontrols.play(); // çarptığı anda çalsın diye 

                        if (Road > Settings1.Default.HighScore) // böylece kullanıcının önceki değeri kaydedilmiş olur bu da veriTabanı kullanmadan oluşturmuş oluyoruz 
                        {
                            MessageBox.Show("New High Score ==> " + Road.ToString() + "m", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Settings1.Default.HighScore = Road;
                            Settings1.Default.Save();
                        }


                        DialogResult dr = MessageBox.Show("GAME OVER ! Wanna Try Again ? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // kullanıcıya mesaj verecek 

                        if(dr == DialogResult.Yes)
                        {
                            AracYerine();
                            for(int j = 0; j < rndCar.Length; j++)
                            {
                                rndCar[j].FakeCar.Dispose();
                                rndCar[j].FakeHaveCar = false;
                                rndCar[j].vakit = false;
                            }

                            Road = 0;
                            Speed = 70;
                            rndCar[0].vakit = true;
                            timerRandomCar.Enabled = true;
                            timerRandomCar.Interval = 200;

                            timerSerit.Enabled = true;
                            timerSerit.Interval = 200;

                            RandomMusicEkle();
                            axWindowsMediaPlayer1.Ctlcontrols.play();

                            labelHighScore.Text = Settings1.Default.HighScore.ToString(); // kaza yaptığı zaman hemen en yüksek değeri tutsun diye 
                            // yani her kaza yapıldığında en yüksek skora ulaşılmış ise onu kaydedip tekrar açtığında ise onu yazıyor 
                        }
                        else
                        {
                            this.Close(); // eğer hayır derse çıksın diye 
                        }

                    }

                }

            }
        }
    }
}
