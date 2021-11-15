using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaga_assign
{
    public partial class Form1 : Form
    {
        bool Game_Over = false;
        bool FireMode = false;
        int score = 0;
        int Speed_Ally = 8;
        int EnemeyAircraftSpeed;
        int Bullet_Speed;
        int Game_Speed = 1;


        Random random = new Random();


        public Form1()
        {
            InitializeComponent();
        }




        // 여기서부터 움직임 관련


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                BF101.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                BF101.Left += 8;
            }
            if (e.KeyCode == Keys.Space)
            {
                FireMode = true;
            }

        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                FireMode = true;
            }

        }


        private void GameTICK_Tick(object sender, EventArgs e)
        {
            EnemyMove(Game_Speed);

            if(Missile.Top < -10)
            {
                FireMode = false;
                Missile.Left = BF101.Left+20;
            }


            // 여기서부터는 미사일 관련(아군 미사일)

            if (Missile.Bounds.IntersectsWith(EnemyAircraft1.Bounds)) {
                score += 1;
                EnemyAircraft1.Top = 0;
                EnemyAircraft1.Left = random.Next(25, 375);
                FireMode = false;
            }
            if (Missile.Bounds.IntersectsWith(EnemyAircraft2.Bounds))
            {
                score += 1;
                EnemyAircraft2.Top = 0;
                EnemyAircraft2.Left = random.Next(25, 375);
                FireMode = false;
            }
            if (Missile.Bounds.IntersectsWith(EnemyAircraft3.Bounds))
            {
                score += 1;
                EnemyAircraft3.Top = 0;
                EnemyAircraft3.Left = random.Next(25, 375);
                FireMode = false;
            }

            // 여기서부터는 게임오버 처리

            if (BF101.Bounds.IntersectsWith(EnemyAircraft1.Bounds))
            {
                Game_Over = true;
                defeat(Game_Over);
            }
            if (BF101.Bounds.IntersectsWith(EnemyAircraft2.Bounds))
            {
                Game_Over = true;
                defeat(Game_Over);
            }
            if (BF101.Bounds.IntersectsWith(EnemyAircraft3.Bounds))
            {
                Game_Over = true;
                defeat(Game_Over);
            }

            // 일반 함수호출

            Fire(FireMode, 20, Game_Over);
        }

        private void EnemyMove(int speed)
        {
            EnemyAircraft1.Top += speed;
            EnemyAircraft2.Top += speed;
            EnemyAircraft3.Top += speed;
        }

        private void Fire(bool FireMode, int Bullet_Speed, bool Gamestate)
        {
            if (Gamestate == false)
            {
                if (FireMode == true)
                {
                    Missile.Top -= Bullet_Speed;
                }
                if (FireMode == false)
                {
                    Missile.Top = BF101.Top;
                    Bullet_Speed = 0;
                }
            }
        }

        private void defeat(bool GameOver)
        {
            if (GameOver == true) {
                GameTICK.Stop();
            }

        }


    }
}
