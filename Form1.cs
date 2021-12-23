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
        List<Panel> listPanel = new List<Panel>();
        public MainForm()
        {
            InitializeComponent();
        }

        ///Loads the main form <see cref="MainForm.InitializeComponent"/> MainForm section
        //DO NOT change the order that panels are added, will make the PokerPanel buttons useless
        private void MainForm_Load(object sender, EventArgs e)
        {
            listPanel.Add(PokerPanel);
            listPanel.Add(TexasHoldEmPanel);
        }

        //Handles the switching of panels done on PokerPanel
        #region PokerPanel Button EventHandlers
        private void TexasHoldEmButton_Click(object sender, EventArgs e)
        {
            listPanel[1].BringToFront();
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

        //Handles the events of all TexasHoldEmPanel components
        #region TexasHoldEmPanel Component EventHandlers 
        //Potentially change this to be the event handler for all panels branched from PokerPanel
        private void TexasHoldEmBackButton_Click(object sender, EventArgs e)
        {
            listPanel[0].BringToFront();
        }

        private void NumPlayersSlider_Scroll(object sender, EventArgs e)
        {

        }

        private void NumGamesSlider_Scroll(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
