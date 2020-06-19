using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussionRoulette
{
    public partial class RouletteForm : Form
    {
        ClassGame MyClassRoulette = new ClassGame();
        public RouletteForm()
        {
            InitializeComponent();
            RefreshScreen();
        }

        private void RefreshScreen()
        {
            lblBulletLocation.Text = MyClassRoulette.SecretChamberID.ToString();
            lblCurrentID.Text = MyClassRoulette.CurrentChamberID.ToString();
            lblGame.Text = MyClassRoulette.TotalGamePlayed.ToString();
            lblWin.Text = MyClassRoulette.Win.ToString();
            lblLose.Text = MyClassRoulette.Lose.ToString();
            lblNoOfAway.Text = "You have " + MyClassRoulette.AwayCount + " away shots left.";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            MyClassRoulette.NewGame();
            RefreshScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            if (MyClassRoulette.bulletShot())
            { MessageBox.Show("You just blew your brains.!\nYou Lose!\nTry Again."); MyClassRoulette.YouLose(); MyClassRoulette.NewGame(); }
            else
            {
                MyClassRoulette.Next();
                if (MyClassRoulette.CurrentChamberID == MyClassRoulette.NoOfChamber)
                { 
                    MessageBox.Show($"You Have Shot All {MyClassRoulette.NoOfChamber-1} Chambers & Found Bullet In The {MyClassRoulette.SecretChamberID}.\nYou Won!!!");
                    MyClassRoulette.YouWon();
                    MyClassRoulette.NewGame();
                }
            }
            RefreshScreen();
        }

        private void btnNoOfAway_Click(object sender, EventArgs e)
        {
            if (MyClassRoulette.bulletShot())
            {
                MessageBox.Show("You Just Shot The Bullet Away!\nYou Won!");
                MyClassRoulette.YouWon();
                MyClassRoulette.NewGame();
            }
            else
            {
                MyClassRoulette.AwayCount--;
                MyClassRoulette.Next();
                if ( MyClassRoulette.AwayCount==0)
                { 
                    MessageBox.Show("Used all away shots & You didn't find the bullet.\nYou Lost!");
                    MyClassRoulette.YouLose();
                    MyClassRoulette.NewGame();
                }
            }
            RefreshScreen();
        }
    }
}
