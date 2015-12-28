using DiabloViewer.Exceptions;
using DiabloViewer.Views;
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
        private DiabloProfile _diabloProfile;
        public DiabloProfile DiabloProfile { get; set; }
        public MainFrame()
        {
            InitializeComponent();
        }
        void UpdateDiabloProfile(object sender, StartView.DiabloProfileArgs e)
        {
            Console.WriteLine(e.DiabloProfile.GuildName);
            this.Controls.Remove(this.startView1);
        }
    }
}
