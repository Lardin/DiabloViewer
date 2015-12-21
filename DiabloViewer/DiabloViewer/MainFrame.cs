using DiabloViewer.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiabloViewer
{
    public partial class MainFrame : Form
    {
        private String _battleTag;
        public String BattleTag { get; set; }
        public MainFrame()
        {
            InitializeComponent();
        }

        private void startPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (e.Control == this.diabloProfileView)
            {
                this.BattleTag = this.diabloProfileView.BattleTag;
            }
        }
    }
}
