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
        int songInt = -1;

        Boolean isPressed = false;
        Boolean songSelected = false;


        private int currentPosition;
        MediaPlayerManager MPM = new MediaPlayerManager();

        private TagLib.File[] SongQueue;
        private TagLib.File[] ShuffledQueue;

        private ListViewItem SongList;


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
                SongList = new ListViewItem();
                if (file.Tag.Title != "")
                {
                    SongList.Text = file.Tag.Title;
                    SongList.SubItems.Add(file.Tag.Album);
                    SongList.SubItems.Add(file.Tag.FirstPerformer);
                    SongList.SubItems.Add(file.Name);
                }

                fileList.Items.Add(SongList);
            }
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

        private void play()
        {
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

        private void nextSong()
        {
            if (shuffleBox.Checked)
            {
                songInt++;
                MPM.NextSong(songInt, ShuffledQueue);
            }
            else
            {
                chosenItem++;
                MPM.NextSong(chosenItem, SongQueue);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nextSong();
        }

        private void ShowTags(string name, string artist)
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
            if (shuffleBox.Checked)
            {
                ShuffledQueue = MPM.ShuffleQueue(SongQueue);
                foreach (TagLib.File TF in ShuffledQueue)
                {
                    SongList.SubItems.Add(TF.Tag.Title);
                }
            }
            else
            {
                SongList.SubItems.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int songLength = MPM.Length;
            currentPosition = MPM.Position;

            songProgress.Maximum = songLength;
            if (MPM.TruePosition != MPM.TrueLength)
            {
                songProgress.Value = MPM.Position;
                Console.WriteLine(MPM.TruePosition + "/" + MPM.TrueLength);
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
            if (MPM.songPlaying)
                MPM.EndSession();
        }

        private void show_info(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            chosenItem = e.ItemIndex;
            MPM.SONG_URL = SongQueue[chosenItem].Name;
            play();
            updateBar();
        }
    }
}
