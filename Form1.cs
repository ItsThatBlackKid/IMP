using System;
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
        private double songTime;

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
            
        }

        private void play_click(object sender, EventArgs e)
        {
            if (!isPressed)
            {
                if (!songSelected)
                {
                    mPLayer.URL = songs[chosenItem].Name;
                    mPLayer.controls.play();
                    songSelected = true;
                    
                }
                else
                {
                    mPLayer.controls.currentPosition = songTime;
                    mPLayer.controls.play();
                }
                playButton.Text = "Pause";
                isPressed = true;
            }
            else
            {
                songTime = mPLayer.controls.currentPosition;
                mPLayer.controls.pause();
                playButton.Text = "Play";
                isPressed = false;
            }
        }
    }
}
