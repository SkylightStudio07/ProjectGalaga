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


        int score;
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
        }

        private void GameTICK_Tick(object sender, EventArgs e)
        {
            EnemyMove(Game_Speed);
        }

        private void EnemyMove(int speed)
        {
            EnemyAircraft1.Top += speed;
            EnemyAircraft2.Top += speed;
            EnemyAircraft3.Top += speed;
        }


    }
}
