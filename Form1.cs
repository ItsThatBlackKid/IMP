using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using TagLib;
using WMPLib;
namespace Imagine_Music_Player
{
    public partial class musicForm : Form
    {
        LibManager Lib = new LibManager();
        int chosenItem = 0;

        Boolean isPressed = false;
        Boolean songSelected = false;


        private int currentPosition;
        MediaPlayerManager MPM = new MediaPlayerManager();

        private TagLib.File[] SongQueue;

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
            Lib.DIR_URL = "C:\\Users\\215358\\OneDrive\\Music";
            SongQueue = Lib.Songs;
            foreach (TagLib.File file in SongQueue)
            {
                var songlist = new ListViewItem();
                if (file.Tag.Title != "")
                {
                    songlist.Text = file.Tag.Title;
                    songlist.SubItems.Add(file.Tag.Album);
                    songlist.SubItems.Add(file.Tag.FirstPerformer);
                    songlist.SubItems.Add(file.Name);
                }

                fileList.Items.Add(songlist);
            }

            TagLib.File[] shuffled = MPM.ShuffleQueue(SongQueue);
            foreach(TagLib.File f in shuffled) 
            {
                Console.WriteLine(f.Tag.Title);
            }
        }

        private void show_info(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            MPM.SONG_URL = SongQueue[e.ItemIndex].Name;
            if (MPM.MusicState == PlaybackState.Playing)
            {
                MPM.Stop();
                MPM.Play();
            }
            else
            {
                MPM.Play();
            }
            playButton.Text = "Pause";
        }

        private void play_click(object sender, EventArgs e)
        {

            if (MPM.MusicState == PlaybackState.Playing)
            {
                MPM.Pause();
                playButton.Text = "Play";
            }
            else
            {
                MPM.Play();
                playButton.Text = "Pause";
            }
        }

        private void updateBar()
        {
            progressUpdate.Enabled = true;
            progressUpdate.Start();
        }

        private void nextSong()
        {
            if()
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
            int songLength = MPM.Length;
            currentPosition = MPM.Position;

            songProgress.Maximum = songLength +1;
            if (currentPosition !=  songLength)
            {
                songProgress.Value = MPM.Position;
                Console.WriteLine(MPM.Position + "/" + songLength);
                if (currentPosition == 0)
                {
                    nextSong();

                }
            }
        }

        private void musicForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void fileList_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void close_all_processes(object sender, FormClosingEventArgs e)
        {
            if(MPM.songPlaying)
            MPM.EndSession();
        }
    }
}
