using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterManager.Shared
{
    public partial class CharControl : UserControl
    {
        public CharControl()
        {
            InitializeComponent();
        }

        private void CharControl_Load( object sender, EventArgs e )
        {

        }

        private void Delete_Click( object sender, EventArgs e )
        {
            Hide();
            Dispose();
        }

        private void menuStrip1_ItemClicked( object sender, ToolStripItemClickedEventArgs e )
        {

        }

        private void editToolStripMenuItem_Click( object sender, EventArgs e )
        {

        }
    }
}
