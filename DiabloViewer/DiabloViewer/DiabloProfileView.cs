using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using DiabloViewer.Exceptions;

namespace DiabloViewer
{
    public partial class DiabloProfileView : UserControl
    {
        private String _battleTag;
        public String BattleTag { get; set; }
        private DiabloProfile diabloProfle;

        public DiabloProfileView()
        {
            InitializeComponent();
        }

        private void tb_battleTag_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BattleTag = tb_battleTag.Text;
                try
                {
                    if (!this.BattleTag.Contains("#"))
                        throw new BattleTagInvalidException();

                    this.BattleTag = this.BattleTag.Replace("#", "%23");
                    WebRequest test = WebRequest.Create("https://eu.api.battle.net/d3/profile/" + this.BattleTag + "/?locale=en_GB&apikey=" + new APIKey().APIKEY1);
                    WebResponse response = test.GetResponse();
                    Stream input = ((HttpWebResponse)response).GetResponseStream();
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(DiabloProfile));

                    diabloProfle = (DiabloProfile)serializer.ReadObject(input);
                    if (diabloProfle.Code == "NOTFOUND")
                        throw new BattleTagNotFoundException();
                    Console.WriteLine(diabloProfle.GuildName);
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
                    String title = diabloProfle.Reason;
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
