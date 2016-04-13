using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TagLib;

namespace Imagine_Music_Player
{
    class LibManager
    {
        private string dir_url;
        public String DIR_URL
        {
            set { this.dir_url = value;}
            get { return this.dir_url; }
        }

        public List<TagLib.File> GetMusic(string dir)
        {
            List<TagLib.File> songs = new List<TagLib.File>();
            foreach (string s in Directory.EnumerateFiles(dir, "*.mp3", SearchOption.AllDirectories))
            {
                if(!s.Contains("MACOSX")) {
                    songs.Add(TagLib.File.Create(s));
                }
            }
            songs.Sort((x, y) => String.Compare(x.Tag.Title, y.Tag.Title));

            return songs;
        }

        public String GetTrack(string dir)
        {
            return dir;
        }

         public TagLib.File[] Songs
        {
            get { return GetMusic(dir_url).ToArray(); }
        }
    }
}
