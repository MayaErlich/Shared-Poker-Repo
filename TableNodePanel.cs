using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Poker_Repo
{
    // Custom made class to act as a tree
    // Makes the changing of panels easy and convenient
    // In future will add more functionality, such as hashmaps using control strings
    public class TableNodePanel : TableLayoutPanel
    {
        // Used to show that this is a root
        // Determines what is returned by ParentNode
        [Category("Node Attributes")]
        public bool IsRoot { get; set; }
        // The "parent" of this panel. Used when there is switching between multiple pages
        // The parent is the panel used to go to this 
        // If no parent, returns itself
        private TableNodePanel _parentNode;
        [Category("Node Attributes")]
        public TableNodePanel ParentNode {
            get 
            {
                return IsRoot ? this : _parentNode;

            }
            set 
            {
                if (!IsRoot)
                {
                    _parentNode = value;
                }
            } 
        }
        public TableNodePanel()
        {

        }
    }
}
