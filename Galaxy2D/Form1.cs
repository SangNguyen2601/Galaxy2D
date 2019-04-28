using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Galaxy2D
{
    public partial class Form1 : Form
    {
        PictureBox[] lstStation, lstEnemy, lstHeal, lstObj;      // list lưu phi thuyền địch và trạm không gian

        int x_rocket, y_rocket, x_station, y_station, x_enemy, y_enemy;     //toạ độ x,y của các đối tượng có trong game
        int x_enemy2, y_enemy2, x_enemy3, y_enemy3, x_enemy4, y_enemy4, x_enemy5, y_enemy5;
        bool shooting;       //biến cho phép bắn
        bool moving;
        int speedStation = 2;
        int diem = 0;
        bool banTrung = false;
        PictureBox DTBiTrungDan;
        int temp;
        bool dead = false;
        int deadcount = 0;
        int douma=0, douma2=0;

        int speedEnemy = 3, speedEnemy2 = 2, speedEnemy3 = 2, speedEnemy4 = 2, speedEnemy5 = 2;

        private void timerRest_Tick(object sender, EventArgs e)
        {
            douma++;
            if(douma == 15)
            {
                playerShip.Visible = false;
            }
            if(douma == 17)
            {
                playerShip.Visible = true;
                douma = 0;
                douma2++;
                if (douma2 == 3)
                {
                    timerRest.Stop();
                    douma2 = 0;
                }
            }
        }

        private void timerEnemy2_Tick(object sender, EventArgs e)
        {
            enemy2.Visible = true;
            Random rd = new Random();
            x_enemy2 = enemy2.Location.X - speedEnemy2;
            y_enemy2 = enemy2.Location.Y;

            enemy2.Location = new Point(x_enemy2, y_enemy2);

            if (enemy2.Location.X < 0 - enemy2.Width)
            {
                speedEnemy2 = rd.Next(2, 5);
                x_enemy2 = 1280;
                y_enemy2 = rd.Next(30, 310);
                enemy2.Location = new Point(x_enemy2, y_enemy2);
            }
            DeadEvent(sender, e);
        }

        private void timerEnemy3_Tick(object sender, EventArgs e)
        {
            enemy3.Visible = true;
            Random rd = new Random();
            x_enemy3 = enemy3.Location.X - speedEnemy3;
            y_enemy3 = enemy3.Location.Y;

            enemy3.Location = new Point(x_enemy3, y_enemy3);

            if (enemy3.Location.X < 0 - enemy3.Width)
            {
                speedEnemy3 = rd.Next(2, 3);
                x_enemy3 = 1280;
                y_enemy3 = rd.Next(30, 310);
                enemy3.Location = new Point(x_enemy3, y_enemy3);
            }
            DeadEvent(sender, e);
        }

        private void timerEnemy4_Tick(object sender, EventArgs e)
        {
            enemy4.Visible = true;
            Random rd = new Random();
            x_enemy4 = enemy4.Location.X - speedEnemy4;
            y_enemy4 = enemy4.Location.Y;

            enemy4.Location = new Point(x_enemy4, y_enemy4);

            if (enemy4.Location.X < 0 - enemy4.Width)
            {
                speedEnemy4 = rd.Next(2, 5);
                x_enemy4 = 1280;
                y_enemy4 = rd.Next(30, 310);
                enemy4.Location = new Point(x_enemy4, y_enemy4);
            }
            DeadEvent(sender, e);
        }

        private void timerEnemy5_Tick(object sender, EventArgs e)
        {
            enemy5.Visible = true;
            Random rd = new Random();
            x_enemy5 = enemy5.Location.X - speedEnemy5;
            y_enemy5 = enemy5.Location.Y;

            enemy5.Location = new Point(x_enemy5, y_enemy5);

            if (enemy5.Location.X < 0 - enemy5.Width)
            {
                speedEnemy5 = rd.Next(2, 5);
                x_enemy5 = 1280;
                y_enemy5 = rd.Next(30, 310);
                enemy5.Location = new Point(x_enemy5, y_enemy5);
            }
            DeadEvent(sender, e);
        }

        private void timerStation_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            int count = rd.Next(0, 3);
            Point temp1 = lstStation[count].Location;
            x_station = temp1.X - speedStation;
            y_station = temp1.Y;

            lstStation[count].Location = new Point(x_station, y_station);

            if (lstStation[count].Location.X < 0 - lstStation[count].Width)
            {
                speedStation = rd.Next(2, 5);
                x_station = 2300;
                lstStation[count].Location = new Point(x_station, y_station);
            }
            DeadEvent(sender, e);
        }
        
        private void timerEnemy1_Tick(object sender, EventArgs e)
        {
            enemy1.Visible = true;
            Random rd = new Random();
            x_enemy = enemy1.Location.X - speedEnemy;
            y_enemy = enemy1.Location.Y;

            enemy1.Location = new Point(x_enemy, y_enemy);

            if (enemy1.Location.X < 0 - enemy1.Width)
            {
                speedEnemy = rd.Next(3,7);
                x_enemy = 1280;
                y_enemy = rd.Next(30, 310);
                enemy1.Location = new Point(x_enemy,y_enemy);
            }
            DeadEvent(sender, e);
        }

        private void timerBoom_Tick(object sender, EventArgs e)
        {
            boomPic.BringToFront();
            boomPic.Visible = true;
            boomPic.Location = new Point(playerRocket.Location.X, playerRocket.Location.Y - playerRocket.Size.Height + 10);
            temp += 1;
            playerRocket.Visible = false;
            if (temp > 16)
            {
                boomPic.Visible = false;
                temp = 0;
                timerBoom.Stop();
                //timerRocket.Stop();
            }
            if (temp > 15)
            {
                DTBiTrungDan.Visible = false;
                Random rd = new Random();
                int x = rd.Next(1000, 1200);
                int y = rd.Next(30, 310);
                DTBiTrungDan.Location = new Point(x, y);

            }
        }

        //bắn bằng phím "Space"
        private void shoot(object sender, KeyPressEventArgs e)
        {
            if (shooting)
            {
                if (e.KeyChar == 32)
                {
                    playerRocket.Visible = true;

                    //lấy vị trí viên đạn sẽ xuất hiện
                    playerRocket.Location = new Point(playerShip.Location.X + playerShip.Width, playerShip.Location.Y + 20);
                    x_rocket = playerRocket.Location.X;
                    y_rocket = playerRocket.Location.Y;

                    timerRocket.Start();
                    shooting = false;
                }
            }
        }

        private void DeadEvent(object sender, EventArgs e)
        {
            if (!dead)
            {
                for(int i=0;i< lstObj.Count(); i++)
                    if (playerShip.Bounds.IntersectsWith(lstObj[i].Bounds))
                    {
                       dead = true;
                       deadcount++;
                        DTBiTrungDan = lstObj[i];
                        playerShip.Visible = false;
                       lstObj[i].Visible = false;
                        timerBoom.Start();
                        break;
                    }
            }
            if(dead)
            {
                if(deadcount == 3)
                {
                    lstHeal[deadcount - 1].Visible = false;
                    timerEnemy1.Stop();
                    timerEnemy2.Stop();
                    timerEnemy3.Stop();
                    timerEnemy4.Stop();
                    timerEnemy5.Stop();
                    timerStation.Stop();
                    MessageBox.Show("Chicken !");
                    Form1_Load(sender,e);
                    dead = false;
                    deadcount = 0;
                }
                else
                {
                    playerShip.Location = new Point(12, 140);
                    playerShip.Visible = true;
                    lstHeal[deadcount-1].Visible = false;
                        dead = false;
                    timerRest.Start();
                }
            }
        }

        //timer viên đạn bay
        private void timerRocket_Tick(object sender, EventArgs e)
        {
            x_rocket += 15;     //tốc độ đạn
            playerRocket.Location = new Point(x_rocket, y_rocket);

            //chỉ khi đạn bay hết map mới dc bắn tiếp
            if ((x_rocket > 800) || (banTrung))
            {
                banTrung = false;
                timerRocket.Stop();
                playerRocket.Visible = false;
                shooting = true;
                return;
            }

            for (int i = 0; i< lstEnemy.Count(); i++)
            {
                if (playerRocket.Bounds.IntersectsWith(lstEnemy[i].Bounds))
                {
                    diem++;
                    scoreLb.Text = ""+diem;
                    /*if (diem - 5 == diembandau)
                    {
                        diembandau = diem;
                        level++;
                        label3.Text = "LEVEL: " + level;
                    }*/
                    banTrung = true;
                    DTBiTrungDan = lstEnemy[i];
                    timerBoom.Start();
                    break;
                }
            }
        }

        private void startBt_Click(object sender, EventArgs e)
        {
            moving = true;
            startBt.Enabled = false;
            shooting = true;

            if (moving)
            {
                enemy1.Visible = true;
                enemy2.Visible = true;
                enemy3.Visible = true;
                enemy4.Visible = true;
                enemy5.Visible = true;
                station1.Visible = true;
                station2.Visible = true;
                station3.Visible = true;

                timerEnemy1.Start();
                timerEnemy2.Start();
                timerEnemy3.Start();
                timerEnemy4.Start();
                timerEnemy5.Start();
                timerStation.Start();
            }
        }

        public Form1()
        {
            InitializeComponent();
            //khởi tạo list, đưa các control vào list
            lstStation = new PictureBox[] { station1, station2, station3 };
            lstEnemy = new PictureBox[] { enemy1, enemy2, enemy3, enemy4, enemy5 };
            lstHeal = new PictureBox[] { helth1, helth2, helth3};
            lstObj = new PictureBox[] { enemy1, enemy2, enemy3, enemy4, enemy5 , station1, station2, station3};
        }

        //di chuyển lên, xuống, trái, phải
        private void playerMove(object sender, PreviewKeyDownEventArgs e)
        {
            Point pointShip = playerShip.Location;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (pointShip.Y > 35)
                        pointShip.Y = pointShip.Y - 5;
                    break;
                case Keys.Down:
                        if (pointShip.Y < 310)
                        pointShip.Y = pointShip.Y + 5;
                    break;
                case Keys.Left:
                    if (pointShip.X > 10)
                        pointShip.X = pointShip.X - 5;
                    break;
                case Keys.Right:
                    if (pointShip.X < 700)
                        pointShip.X = pointShip.X + 5;
                    break;
            }
            playerShip.Location = pointShip;
            playerRocket.Location = pointShip;
            //DeadEvent(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            moving = false;
            shooting = false;
            enemy1.Visible = false;
            enemy2.Visible = false;
            enemy3.Visible = false;
            enemy4.Visible = false;
            enemy5.Visible = false;
            station1.Visible = false;
            station2.Visible = false;
            station3.Visible = false;
            boomPic.Visible = false;

            startBt.Enabled = true;
            for (int i = 0; i < lstHeal.Count(); i++)
                lstHeal[i].Visible = true;
            scoreLb.Text = "";

            //setup size map, vị trí playership
            this.Size = new Size(892, 456);
            playerShip.Location = new Point(12,140);

            enemy1.Location = new Point(750,56);
            enemy2.Location = new Point(830,214);
            enemy3.Location = new Point(1270,291);
            enemy4.Location = new Point(1100,63);
            enemy5.Location = new Point(960,120);

            station1.Location = new Point(1600,214);
            station2.Location = new Point(2000,0);
            station3.Location = new Point(2400,205);

            //setup tốc độ
            timerEnemy1.Interval = 10;
            timerEnemy2.Interval = 10;
            timerEnemy3.Interval = 10;
            timerEnemy4.Interval = 10;
            timerEnemy5.Interval = 10;
            timerRocket.Interval = 10;
            timerStation.Interval = 10;

        }

    }
}
