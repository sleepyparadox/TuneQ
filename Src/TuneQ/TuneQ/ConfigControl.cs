using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuneQ
{
    public partial class ConfigControl : UserControl
    {
        public ConfigControl()
        {
            InitializeComponent();
            TwitchDisplayName.Text = Config.Instance.TwitchNick;
            TwitchChannel.Text = Config.Instance.TwitchChannel;
            TwitchOAuth.Text = Config.Instance.TwitchOauth;
        }

        private void TwitchDisplayName_TextChanged(object sender, EventArgs e)
        {
            Config.Instance.TwitchNick = TwitchDisplayName.Text;
            Config.Instance.Save();
        }

        private void TwitchChannel_TextChanged(object sender, EventArgs e)
        {
            Config.Instance.TwitchChannel = TwitchChannel.Text;
            Config.Instance.Save();
        }

        private void TwitchOAuth_TextChanged(object sender, EventArgs e)
        {
            Config.Instance.TwitchOauth = TwitchOAuth.Text;
            Config.Instance.Save();
        }
    }
}
