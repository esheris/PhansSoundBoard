using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhantasaiasSoundBoard
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btn1gif_Click(object sender, EventArgs e)
        {
            txt1gif.Text = Helpers.OpenGifFile();
        }

        private void btn1snd_Click(object sender, EventArgs e)
        {
            txt1snd.Text = Helpers.OpenAudioFile();
        }

        private void btn2gif_Click(object sender, EventArgs e)
        {
            txt2gif.Text = Helpers.OpenGifFile();
        }

        private void btn3gif_Click(object sender, EventArgs e)
        {
            txt3gif.Text = Helpers.OpenGifFile();
        }

        private void btn4gif_Click(object sender, EventArgs e)
        {
            txt4gif.Text = Helpers.OpenGifFile();
        }

        private void btn5gif_Click(object sender, EventArgs e)
        {
            txt5gif.Text = Helpers.OpenGifFile();
        }

        private void btn6gif_Click(object sender, EventArgs e)
        {
            txt6gif.Text = Helpers.OpenGifFile();
        }

        private void btn7gif_Click(object sender, EventArgs e)
        {
            txt7gif.Text = Helpers.OpenGifFile();
        }

        private void btn8gif_Click(object sender, EventArgs e)
        {
            txt8gif.Text = Helpers.OpenGifFile();
        }

        private void btn2snd_Click(object sender, EventArgs e)
        {
            txt2snd.Text = Helpers.OpenAudioFile();
        }

        private void btn3snd_Click(object sender, EventArgs e)
        {
            txt3snd.Text = Helpers.OpenAudioFile();
        }

        private void btn4snd_Click(object sender, EventArgs e)
        {
            txt4snd.Text = Helpers.OpenAudioFile();
        }

        private void btn5snd_Click(object sender, EventArgs e)
        {
            txt5snd.Text = Helpers.OpenAudioFile();
        }

        private void btn6snd_Click(object sender, EventArgs e)
        {
            txt6snd.Text = Helpers.OpenAudioFile();
        }

        private void btn7snd_Click(object sender, EventArgs e)
        {
            txt7snd.Text = Helpers.OpenAudioFile();
        }

        private void btn8snd_Click(object sender, EventArgs e)
        {
            txt8snd.Text = Helpers.OpenAudioFile();
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            PhansSoundBoard.Properties.Settings.Default.btn1gif = txt1gif.Text;
            PhansSoundBoard.Properties.Settings.Default.btn2gif = txt2gif.Text;
            PhansSoundBoard.Properties.Settings.Default.btn3gif = txt3gif.Text;
            PhansSoundBoard.Properties.Settings.Default.btn4gif = txt4gif.Text;
            PhansSoundBoard.Properties.Settings.Default.btn5gif = txt5gif.Text;
            PhansSoundBoard.Properties.Settings.Default.btn6gif = txt6gif.Text;
            PhansSoundBoard.Properties.Settings.Default.btn7gif = txt7gif.Text;
            PhansSoundBoard.Properties.Settings.Default.btn8gif = txt8gif.Text;

            PhansSoundBoard.Properties.Settings.Default.btn1snd = txt1snd.Text;
            PhansSoundBoard.Properties.Settings.Default.btn2snd = txt2snd.Text;
            PhansSoundBoard.Properties.Settings.Default.btn3snd = txt3snd.Text;
            PhansSoundBoard.Properties.Settings.Default.btn4snd = txt4snd.Text;
            PhansSoundBoard.Properties.Settings.Default.btn5snd = txt5snd.Text;
            PhansSoundBoard.Properties.Settings.Default.btn6snd = txt6snd.Text;
            PhansSoundBoard.Properties.Settings.Default.btn7snd = txt7snd.Text;
            PhansSoundBoard.Properties.Settings.Default.btn8snd = txt8snd.Text;
            PhansSoundBoard.Properties.Settings.Default.Save();

            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txt1gif.Text = PhansSoundBoard.Properties.Settings.Default.btn1gif;
            txt2gif.Text = PhansSoundBoard.Properties.Settings.Default.btn2gif;
            txt3gif.Text = PhansSoundBoard.Properties.Settings.Default.btn3gif;
            txt4gif.Text = PhansSoundBoard.Properties.Settings.Default.btn4gif;
            txt5gif.Text = PhansSoundBoard.Properties.Settings.Default.btn5gif;
            txt6gif.Text = PhansSoundBoard.Properties.Settings.Default.btn6gif;
            txt7gif.Text = PhansSoundBoard.Properties.Settings.Default.btn7gif;
            txt8gif.Text = PhansSoundBoard.Properties.Settings.Default.btn8gif;
                                                                              
            txt1snd.Text = PhansSoundBoard.Properties.Settings.Default.btn1snd;
            txt2snd.Text = PhansSoundBoard.Properties.Settings.Default.btn2snd;
            txt3snd.Text = PhansSoundBoard.Properties.Settings.Default.btn3snd;
            txt4snd.Text = PhansSoundBoard.Properties.Settings.Default.btn4snd;
            txt5snd.Text = PhansSoundBoard.Properties.Settings.Default.btn5snd;
            txt6snd.Text = PhansSoundBoard.Properties.Settings.Default.btn6snd;
            txt7snd.Text = PhansSoundBoard.Properties.Settings.Default.btn7snd;
            txt8snd.Text = PhansSoundBoard.Properties.Settings.Default.btn8snd;
        }
    }
}
