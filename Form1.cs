using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using System.Media;
using System.Windows;
using WMPLib;
namespace Imagine_Music_Player
{
    public partial class musicForm : Form
    {
        LibManager lib = new LibManager();
        List<TagLib.File> grabbedMusic = null;
        TagLib.File[] songs = null;
        int chosenItem = 0;

        Boolean isPressed = false;
        Boolean songSelected = false;
        Boolean doShuffle = false;

        private double currentPosition;
        MediaPlayerManager mpm = new MediaPlayerManager();

        WindowsMediaPlayer mPLayer = new WindowsMediaPlayer();

        public musicForm()
        {
            InitializeComponent();
            setList();
        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void setList()
        {
            grabbedMusic = lib.GetMusic("C:\\Users\\215358\\OneDrive\\Music");
            songs = grabbedMusic.ToArray();
            Array.Sort(songs, (x, y) => String.Compare(x.Tag.Title, y.Tag.Title));

            foreach (TagLib.File file in songs)
            {
                var songlist = new ListViewItem();
                songlist.Text = file.Tag.Title;
                songlist.SubItems.Add(file.Tag.Album);
                songlist.SubItems.Add(file.Tag.FirstPerformer);
                songlist.SubItems.Add(file.Name);

                fileList.Items.Add(songlist);
            }
        }

        private void show_info(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            chosenItem = e.ItemIndex;
            songSelected = false;
            playButton.Text = "Play";
            isPressed = false;
            showTags(songs[chosenItem].Tag.Title, songs[chosenItem].Tag.FirstPerformer);
        }

        private void shuffle()
        {
        }

        private void play_click(object sender, EventArgs e)
        {
            if (!isPressed)
            {
                if (!songSelected)
                {
                    mPLayer.URL = songs[chosenItem].Name;
                   // mPLayer.controls.currentPosition = 210;
                    mPLayer.controls.play();
                    songSelected = true;
                    updateBar();
                }
                else
                {
                    mPLayer.controls.currentPosition = currentPosition;
                    mPLayer.controls.play();
                }
                playButton.Text = "Pause";
                isPressed = true;
            }
            else
            {
                currentPosition = mPLayer.controls.currentPosition;
                mPLayer.controls.pause();
                playButton.Text = "Play";
                isPressed = false;
            }
        }

        private void updateBar()
        {
            progressUpdate.Enabled = true;
            progressUpdate.Start();
        }

        private void nextSong() 
        {
            Random rnd = new Random();
            if (checkBox1.Checked == true)
            {
                chosenItem = rnd.Next(songs.Length);
            }
            else
            {
                chosenItem++;
            }
             mPLayer.URL = songs[chosenItem].Name;
            showTags(songs[chosenItem].Tag.Title, songs[chosenItem].Tag.FirstPerformer);
            mPLayer.controls.stop();
            mPLayer.controls.play();
        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            nextSong();
            
        }

        private void showTags(string name, string artist)
        {
            if (name != null)
            {
                name = Regex.Replace(name, "(\\(.*\\))", "");
                songName.Text = name + " || " + artist;
            }
            else
            {
                //do nothing
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double timeInDouble = Math.Round(songs[chosenItem].Properties.Duration.TotalSeconds);
            int songLength = (int) timeInDouble;
            currentPosition = Math.Round(mPLayer.controls.currentPosition);
           // Math.Round(timeInDouble, 2);

            var positionInt = (int)currentPosition;

            songProgress.Maximum = songLength +1;
            if (currentPosition !=  songLength)
            {
                songProgress.Value = positionInt;
                Console.WriteLine(positionInt + "/" + timeInDouble);
                if (currentPosition == 0)
                {
                    nextSong();

                }
            }
        }

        private void musicForm_Load(object sender, EventArgs e)
        {

        }
    }
}
