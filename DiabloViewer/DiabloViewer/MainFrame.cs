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
        public MainFrame()
        {
            InitializeComponent();

            WebRequest test = WebRequest.Create("https://eu.api.battle.net/d3/profile/Svenson%232281/?locale=en_GB&apikey=" + new APIKey().APIKEY1);
            WebResponse response = test.GetResponse();
            Stream input = ((HttpWebResponse)response).GetResponseStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(DiabloProfile));

            DiabloProfile diabloProfile = (DiabloProfile)serializer.ReadObject(input);
            Console.WriteLine(diabloProfile.GuildName);
        }
    }
}
