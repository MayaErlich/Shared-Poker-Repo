using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Poker_Repo
{
    ///Main form where where everything is located
    ///Components are put inside panels
    ///panel is a seperate page
    ///Current Panels:(Update when more are added)
    ///    Main Page Panel     <see cref="MainForm.PokerPanel"/>
    ///    Texas Hold'Em Panel <see cref="MainForm.TexasHoldEmPanel"/>
    ///Panels to be added:(crefs not working)
    ///    5 Card Draw Panel   <see cref="MainForm.FiveCardDrawPanel"/>
    ///    BlackJack Panel     <see cref="MainForm.BlackJack"/>
    ///    TableTop Panel      <see cref="MainForm.TableTop"/>

    public partial class MainForm : Form
    {
        //NOTE:
        public MainForm()
        {
            InitializeComponent();
        }

        ///Loads the main form <see cref="MainForm.InitializeComponent"/> MainForm section
        //DO NOT change the order that panels are added, will make the PokerPanel buttons useless
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //Universally used method to move back
        private void ShiftBack(object sender, EventArgs e)
        {
            ((TableNodePanel)((Button)sender).Parent).ParentNode.BringToFront();
        }
        //Handles the switching of panels done on PokerPanel
        #region PokerPanel Button EventHandlers
        private void TexasHoldEmButton_Click(object sender, EventArgs e)
        {
            TexasHoldEmPanel.BringToFront();
        }

        private void FiveCardDrawButton_Click(object sender, EventArgs e)
        {

        }

        private void BlackJackButton_Click(object sender, EventArgs e)
        {

        }

        private void TableTopButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //Handles the events of TexasHoldEmPanel components
        #region TexasHoldEmPanel Component EventHandlers 
        //Potentially change this to be the event handler for all panels branched from PokerPanel
        private void NumPlayersSlider_Scroll(object sender, EventArgs e)
        {
            NumPlayersLabel.Text = $"Number of Players: {NumPlayersSlider.Value}";
        }

        private void NumGamesSlider_Scroll(object sender, EventArgs e)
        {
            NumGamesLabel.Text = $"Number of Games: {NumGamesSlider.Value}";
        }

        private void NumChipsSlider_Scroll(object sender, EventArgs e)
        {
            NumChipsSlider.Value = (int)Math.Round(NumChipsSlider.Value / 100d, 0) * 100;
            NumChipsLabel.Text = $"Amount Per Person : {NumChipsSlider.Value}";
        }
        #endregion

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TexasHoldEmPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
