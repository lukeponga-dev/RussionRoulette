using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

//ToDo Add Images and Audio
namespace RussionRoulette
{
    public partial class RouletteFormv2 : Form
    {
        GameClass2 MyClassRoulette = new GameClass2(); // Defining the object of the game class
        //Random variable used for picking value from 1 to 6 
        Random rand = new Random();
        
        
        // //Sounds
        // private readonly SoundPlayer _dryGunShot;
        // private readonly SoundPlayer _load;
        // private readonly SoundPlayer _shoot;
        // private readonly SoundPlayer _spin;

        public RouletteFormv2()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        //Load Game
        public void RouletteForm_Load(object sender, EventArgs e)
        {

        }
        //Load Bullet
        private void btnLoad_Click(object sender, EventArgs e)
        {
            MyClassRoulette.LoadBullet = 1;
            btnLoad.Enabled = false;
            btnSpin.Enabled = true;// Enabling spin function
            btnShoot.Enabled = false;
            btnNoOfAway.Enabled = false;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(RussionRoulette.Resource1.load);
            player.Play();// for playing the sound for load buttonm
            Assembly mygame = Assembly.GetExecutingAssembly();
            Stream myst = mygame.GetManifestResourceStream("RussianRoulette.Resource1.load1");// Adding image in load function
            imgBox.Image = RussionRoulette.Resource1.load1;


        }

        private void btnSpin_Click(object sender, EventArgs e)
        {

        }

        private void btnShoot_Click(object sender, EventArgs e)
        {

        }



        private void btnNoOfAway_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();

            Application.Exit();
        }
    }
}

// public int Spin;
// //Sounds
// private readonly SoundPlayer _dryGunShot;
// private readonly SoundPlayer _load;
// private readonly SoundPlayer _shoot;
// private readonly SoundPlayer _spin;
//
// //Linking class to Game
// private readonly ClassGame MyClassRoulette;
// private ClassSpinner spinnerClass;
// private Random rand = new Random();
//
// public RouletteForm()
// {
//     spinnerClass = new ClassSpinner();
//     MyClassRoulette = new ClassGame();
//     _dryGunShot = new SoundPlayer(Resource1.drygunshot);
//     _load = new SoundPlayer(Resource1.load);
//     _shoot = new SoundPlayer(Resource1.gunshot);
//     _spin = new SoundPlayer(Resource1.spin);
//     InitializeComponent();
//     RefreshScreen();
// }
//
//
// private void RefreshScreen()
// {
//     lblBulletLocation.Text = String.Empty;
//     lblCurrentID.Text = string.Empty;
//     lblBulletLocation.Text = MyClassRoulette.SecretChamberID.ToString();
//     lblCurrentID.Text = MyClassRoulette.CurrentChamberID.ToString();
//     lblGame.Text = MyClassRoulette.TotalGamePlayed.ToString();
//     lblWin.Text = MyClassRoulette.Win.ToString();
//     lblLose.Text = MyClassRoulette.Lose.ToString();
//     lblNoOfAway.Text = "You have " + MyClassRoulette.AwayCount + " away shots left.";
// }
//
// //Load Game
// public void RouletteForm_Load(object sender, EventArgs e)
// {
//     btnSpin.Enabled = false;
//     btnShoot.Enabled = false;
//     btnNoOfAway.Enabled = false;
//     RefreshScreen();
// }
//
// private void btnNew_Click(object sender, EventArgs e)
// {
//     RefreshScreen();
// }
//
//
//
// //Load Bullet
// private void btnLoad_Click(object sender, EventArgs e)
// {
//
//     RefreshScreen();
//     _load.Play();
//
//     //btnSpin button is enabled
//     btnLoad.Enabled = false;
//     btnSpin.Enabled = true;
//     btnShoot.Enabled = false;
//     btnNoOfAway.Enabled = false;
//     _load.Play();
//     var mygame = Assembly.GetExecutingAssembly();
//     var myst = mygame.GetManifestResourceStream("RussianRoulette.Resources1.load1"); // Adding image in load function
//     imgBox.Image = Resource1.load1;
// }
//
// private void btnSpin_Click(object sender, EventArgs e)
// {
//     Spin = rand.Next(1, 7);
//     _spin.Play();
//     /*
//     var mygame = Assembly.GetExecutingAssembly();
//     var myst = mygame.GetManifestResourceStream(
//         "RussionRoulette.Resource1.spin1"); // This is used to add image on spin function
//     */
//     imgBox.Visible = true;
//     var img = Image.FromFile("RussionRoulette.Resource1.spin1");
//     imgBox.Image = img;
//     MyClassRoulette.CurrentChamberID.ToString();
//     MessageBox.Show("bullet" + MyClassRoulette.CurrentChamberID);
//     imgBox.Visible = true;
//     btnLoad.Enabled = false; // Disable the spin button
//     btnSpin.Enabled = false; // Disable the spin button
//     btnShoot.Enabled = true; // Enabling shoot button
//     btnNoOfAway.Enabled = true;
// }
//
// private void btnShoot_Click(object sender, EventArgs e)
// {
//     if (MyClassRoulette.bulletShot())
//     {
//         // System.Media.SoundPlayer player = new System.Media.SoundPlayer(RussionRoulette.Resource1.gunshot);
//         _shoot.Play(); // This sound will play on the click of shoot button
//         var mygame = Assembly.GetExecutingAssembly();
//         var myst =
//             mygame.GetManifestResourceStream(
//                 "RussionRoulette.Resources1.shoot1jpg"); // This image will show on the click of shoot button
//         imgBox.Image = Resource1.shoot1;
//         MessageBox.Show("You just blew your brains.!\nYou Lose!\nTry Again.");
//         btnLoad.Enabled = false;
//         btnSpin.Enabled = false;
//         btnShoot.Enabled = false;
//         btnNoOfAway.Enabled = false;
//         MyClassRoulette.YouLose();
//         MyClassRoulette.NewGame();
//     }
//     else
//     {
//         MyClassRoulette.Next();
//         if (MyClassRoulette.CurrentChamberID == MyClassRoulette.NoOfChamber)
//         {
//             _dryGunShot.Play();
//             var mygame = Assembly.GetExecutingAssembly();
//             var myst =
//                 mygame.GetManifestResourceStream(
//                     "RussionRoulette.Resources1.NotShoot"); // This image will show on the click of shoot button
//             imgBox.Image = Resource1.NotShoot;
//
//             MessageBox.Show(
//                 $"You Have Shot All {MyClassRoulette.NoOfChamber - 1} Chambers & Found Bullet In The {MyClassRoulette.SecretChamberID}.\nYou Won!!!");
//             MyClassRoulette.YouWon();
//             MyClassRoulette.NewGame();
//         }
//     }
// }
//
// private void btnNoOfAway_Click(object sender, EventArgs e)
// {
//     if (MyClassRoulette.bulletShot())
//     {
//         MessageBox.Show("You Just Shot The Bullet Away!\nYou Won!");
//         MyClassRoulette.YouWon();
//         MyClassRoulette.NewGame();
//     }
//     else
//     {
//         MyClassRoulette.AwayCount--;
//         MyClassRoulette.Next();
//     }
//
//     if (MyClassRoulette.AwayCount == 0)
//     {
//         MessageBox.Show("Used all away shots & You didn't find the bullet.\nYou Lost!");
//         MyClassRoulette.YouLose();
//         MyClassRoulette.NewGame();
//     }
//
//     RefreshScreen();
// }
//
// private void btnQuit_Click(object sender, EventArgs e)
// {
//     Process.GetCurrentProcess().Kill();
//
//     Application.Exit();
// }