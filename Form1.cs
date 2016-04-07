﻿using CSCore;
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
        LibManager lib = new LibManager();
        List<TagLib.File> grabbedMusic = null;
        TagLib.File[] songs = null;
        int chosenItem = 0;

        Boolean isPressed = false;
        Boolean songSelected = false;
        Boolean doShuffle = false;

        private int currentPosition;
        MediaPlayerManager MPM = new MediaPlayerManager();

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
                    MPM.SONG_URL = songs[chosenItem].Name;
                    MPM.Play();
                    Console.WriteLine(MPM.Length);
                    songSelected = true;
                   updateBar();
                }
                else
                {
                  //  mPLayer.controls.currentPosition = currentPosition;
                  //  mPLayer.controls.play();
                    MPM.Resume();
                }
                playButton.Text = "Pause";
                isPressed = true;
            }
            else
            {
               // currentPosition = mPLayer.controls.currentPosition;
              //  mPLayer.controls.pause();
                currentPosition = MPM.Position;
                MPM.Pause();
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
            MPM.EndSession();
        }
    }
}
