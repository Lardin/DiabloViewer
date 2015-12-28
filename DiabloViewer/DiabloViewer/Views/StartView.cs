using DiabloViewer.Exceptions;
using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;

namespace DiabloViewer.Views
{
    public partial class StartView : UserControl
    {
        private String _battleTag;
        public String BattleTag { get; set; }
        private DiabloProfile _diabloProfile;
        public DiabloProfile DiabloProfile { get; set; }
        public StartView()
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

                    this.DiabloProfile = (DiabloProfile)serializer.ReadObject(input);
                    if (this.DiabloProfile.Code == "NOTFOUND")
                        throw new BattleTagNotFoundException();

                    OnUpdateProfile(new DiabloProfileArgs(this.DiabloProfile));
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
                    String title = this.DiabloProfile.Reason;
                    MessageBox.Show(errorMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public class DiabloProfileArgs : EventArgs
        {
            public DiabloProfileArgs(DiabloProfile profile)
            {
                DiabloProfile = profile;
            }
            public DiabloProfile DiabloProfile { get; set; }
        }

        public event EventHandler<DiabloProfileArgs> UpdateProfile;

        protected virtual void OnUpdateProfile(DiabloProfileArgs e)
        {
            EventHandler<DiabloProfileArgs> ev = UpdateProfile;
            if (ev != null)
                ev(this, e);
        }
    }
}
