using LibraryAPI;
using System;
using System.Windows.Forms;

namespace SmartLibrary
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            DatabaseHost.Text = Util.Read("dbhost");
            DatabasePort.Text = Util.Read("dbport");
            DatabaseUser.Text = Util.Read("dbuser");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tryWrite("dbuser", DatabaseUser.Text);
            tryWrite("dbhost", DatabaseHost.Text);
            tryWrite("dbpass", EncryptionUtils.AESCryption(DatabaseNewPasswd.Text, EncryptionUtils.DEFAULT_KEY));
            tryWrite("dbport", DatabasePort.Text);
            Console.WriteLine(EncryptionUtils.aesDecryptBase64(Util.Read("dbpass"), EncryptionUtils.DEFAULT_KEY));
        }

        private void tryWrite(string key, string value)
        {
            if (!Util.Write(key, value))
            {
                MessageBox.Show("注册表写入失败");
            }
        }
    }
}
