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
        private DiabloProfile diabloProfile;
        public MainFrame()
        {
            InitializeComponent();

        }

        private void tb_battleTag_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String battleTag = tb_battleTag.Text;
                try
                {
                    if (!battleTag.Contains("#"))
                        throw new BattleTagInvalidException();

                    battleTag = battleTag.Replace("#", "%23");
                    WebRequest test = WebRequest.Create("https://eu.api.battle.net/d3/profile/" + battleTag + "/?locale=en_GB&apikey=" + new APIKey().APIKEY1);
                    WebResponse response = test.GetResponse();
                    Stream input = ((HttpWebResponse)response).GetResponseStream();
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(DiabloProfile));

                    diabloProfile = (DiabloProfile)serializer.ReadObject(input);
                    if (diabloProfile.Code == "NOTFOUND")
                        throw new BattleTagNotFoundException();
                    Console.WriteLine(diabloProfile.GuildName);
                }
                catch (BattleTagInvalidException)
                {
                    String errorMessage = "Please Enter a correct Battle Tag.\n\nFor Example: Peter#1234.";
                    String title = "Invalid Battle-Tag Format";
                    MessageBox.Show(errorMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (BattleTagNotFoundException)
                {
                    String errorMessage = "Please check if your Battle-Tag is correct";
                    String title = diabloProfile.Reason;
                    MessageBox.Show(errorMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {         
                    throw;
                }
                
            }
        }
    }
}
