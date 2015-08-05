using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhantasaiasSoundBoard
{
    public static class Helpers
    {
        static Helpers() { }
        public static string GetFilenameFromPath(string path)
        {
            return System.IO.Path.GetFileNameWithoutExtension(path);
        }
        public static string OpenFile(string filter)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = filter;
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;


            var userClickedOK = openFileDialog.ShowDialog();

            if (userClickedOK == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return string.Empty;
        }
        public static string OpenGifFile()
        {
            return OpenFile("GIF File (.gif)|*.gif");
        }
        public static string OpenAudioFile()
        {
            return OpenFile("Audio Files|*.ogg;*.mp3;*.wav");
        }
    }
}
