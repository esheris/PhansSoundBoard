using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrrKlang;
using PhansSoundBoard;


namespace PhantasaiasSoundBoard
{
    public partial class PhannysSoundBoard : Form
    {
        KeyboardHook hook = new KeyboardHook();
        ISoundEngine engine = new ISoundEngine();
        public PhannysSoundBoard()
        {
            InitializeComponent();
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            hook.RegisterHotKey(PhansSoundBoard.ModifierKeys.Control, Keys.NumPad0);
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            // show the keys pressed in a label.
            //label1.Text = e.Modifier.ToString() + " + " + e.Key.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayImageAndSound(PhansSoundBoard.Properties.Settings.Default.btn1gif, PhansSoundBoard.Properties.Settings.Default.btn1snd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayImageAndSound(PhansSoundBoard.Properties.Settings.Default.btn2gif, PhansSoundBoard.Properties.Settings.Default.btn2snd);
        }

        private void PlayImageAndSound(string picture, string sound)
        {
            MySoundEndReceiver rcv = new MySoundEndReceiver();
            pictureBox1.ImageLocation = picture;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.Refresh();
            var x = engine.Play2D(sound);
            x.setSoundStopEventReceiver(rcv, pictureBox1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void PhannysSoundBoard_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PhansSoundBoard.Properties.Settings.Default.btn1gif ))
            {
                Settings settings = new Settings();

                settings.ShowDialog();
            }
            foreach (Control ctl in this.Controls)
            {
                if (ctl is Button)
                {
                    string settingName = string.Format("{0}gif", ctl.Name);
                    ctl.Text = Helpers.GetFilenameFromPath(PhansSoundBoard.Properties.Settings.Default[settingName].ToString());
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            PlayImageAndSound(PhansSoundBoard.Properties.Settings.Default.btn3gif, PhansSoundBoard.Properties.Settings.Default.btn3snd);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            PlayImageAndSound(PhansSoundBoard.Properties.Settings.Default.btn4gif, PhansSoundBoard.Properties.Settings.Default.btn4snd);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            PlayImageAndSound(PhansSoundBoard.Properties.Settings.Default.btn5gif, PhansSoundBoard.Properties.Settings.Default.btn5snd);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            PlayImageAndSound(PhansSoundBoard.Properties.Settings.Default.btn6gif, PhansSoundBoard.Properties.Settings.Default.btn6snd);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            PlayImageAndSound(PhansSoundBoard.Properties.Settings.Default.btn7gif, PhansSoundBoard.Properties.Settings.Default.btn7snd);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            PlayImageAndSound(PhansSoundBoard.Properties.Settings.Default.btn8gif, PhansSoundBoard.Properties.Settings.Default.btn8snd);
        }
    }
     public class MySoundEndReceiver : IrrKlang.ISoundStopEventReceiver
 {
     public void OnSoundStopped (ISound sound,IrrKlang.StopEventCause reason, object userData)
     {
         PictureBox picbox = ((PictureBox)userData);
         picbox.Image = null;
         picbox.Refresh();
     }
 }
}
