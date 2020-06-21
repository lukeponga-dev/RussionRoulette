using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussionRoulette
{
    class GameClass2
    {
        public GameClass2()
        {
            NewGame();
        }
        private Random NumGenerator { set; get; } = new Random(DateTime.Now.Millisecond);
        public int CurrentChamberID { private set; get; } = 0;
        public int AwayCount { set; get; } = 2;

        public int LoadBullet, SpinBullet, totalBullet = 6;
        public int win = 0, lose = 0, shootawayBullet = 2;
        public int BulletLocation { get; set; }
        public void NewGame()
        {
            // generate the secret chamber ID to be guessed
            LoadBullet = NumGenerator.Next(1, totalBullet + 1);
            shootawayBullet = 2; // Total Available away shots 2 
            // CurrentChamberID = 1;

        }

        public void Shoot() // Shoot function will shoot the bullet
        {
            if (totalBullet == 0)
            {
                lose = 1;
            }
            else
            {
                if (LoadBullet == SpinBullet)// if load bullet is equal to spin then we will loose the game.
                {
                    lose = 1;
                }
                else
                {
                    SpinBullet = ShootFire(SpinBullet);
                }
                totalBullet--;
            }
        }
        public int ShootFire(int SpinBullet)
        {
            if (SpinBullet == 6)
            {
                SpinBullet = 1;
            }
            else
            {
                SpinBullet++;
            }
            return SpinBullet;
        }
        public void ShootAway() // Shoot Away function will save the player
        {
            if (totalBullet == 0 || shootawayBullet == 0)
            {
                lose = 1;
            }
            else
            {
                shootawayBullet--;
                totalBullet--;
                if (LoadBullet == SpinBullet)
                {
                    win = 1;
                }
                else if (SpinBullet == 6)
                {
                    SpinBullet = 1;
                    if (shootawayBullet == 0)
                    {
                        lose = 1;
                    }
                }
                else
                {
                    SpinBullet++;
                    if (shootawayBullet == 0)
                    {
                        lose = 1;
                    }
                }
            }
        }
    }
}

