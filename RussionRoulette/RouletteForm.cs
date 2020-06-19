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
        }
     
        
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
