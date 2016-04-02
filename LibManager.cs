using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Imagine_Music_Player
{
    class LibManager
    {
        public List<TagLib.File> GetMusic(string dir)
        {
            List<TagLib.File> songs = new List<TagLib.File>();
            foreach (string s in Directory.GetFiles(dir))
            {
                if (s.EndsWith(".mp3") || s.EndsWith(".m4a") || s.EndsWith(".wav"))
                {
                    songs.Add(TagLib.File.Create(s));

                }
                else
                {
                    // do nothing
                }
            }
            foreach (string d in Directory.GetDirectories(dir))
            {
                try
                {
                    if (!d.Contains("MACOSX"))
                    {
                        songs.AddRange(GetMusic(d));
                    }
                    else
                    {
                        //skip file
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return songs;
        }

        public String GetTrack(string dir)
        {
            return dir;
        }
    }
}
