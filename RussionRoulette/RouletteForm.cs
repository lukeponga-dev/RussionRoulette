using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace RussionRoulette
{
    public partial class RouletteForm : Form
    {
        private readonly ClassGame MyClassRoulette = new ClassGame();

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
            btnLoad_Click(sender, e);
        }


        private void btnShoot_Click(object sender, EventArgs e)
        {
            if (MyClassRoulette.bulletShot())
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(RussionRoulette.Resource1.gunshot);
                player.Play();// This sound will play on the click of shoot button
                Assembly mygame = Assembly.GetExecutingAssembly();
                Stream myst = mygame.GetManifestResourceStream("RussionRoulette.Resources1.shoot1jpg");// This image will show on the click of shoot button
                imgBox.Image = RussionRoulette.Resource1.shoot1;
                MessageBox.Show("You just blew your brains.!\nYou Lose!\nTry Again.");
                MyClassRoulette.YouLose();
                MyClassRoulette.NewGame();
                btnLoad.Enabled = false;
                btnSpin.Enabled = false;
                btnShoot.Enabled = false;
                btnNoOfAway.Enabled = false;
            }
            else
            {
                MyClassRoulette.Next();
                if (MyClassRoulette.CurrentChamberID == MyClassRoulette.NoOfChamber)
                {
                    MessageBox.Show(
                        $"You Have Shot All {MyClassRoulette.NoOfChamber - 1} Chambers & Found Bullet In The {MyClassRoulette.SecretChamberID}.\nYou Won!!!");
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
                if (MyClassRoulette.AwayCount == 0)
                {
                    MessageBox.Show("Used all away shots & You didn't find the bullet.\nYou Lost!");
                    MyClassRoulette.YouLose();
                    MyClassRoulette.NewGame();
                }
            }

            RefreshScreen();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            MyClassRoulette.NewGame();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();

            Application.Exit();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            imgBox.Visible = true;
            
        }
    }
}