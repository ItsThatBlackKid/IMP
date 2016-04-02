using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imagine_Music_Player
{
    class LibraryManager
    {

         public List<String> GetMusic(string dir)
        {
            List<string> songs = new List<string>();
                foreach (string s in Directory.GetFiles(dir))
                {
                    if (s.EndsWith(".mp3") || s.EndsWith(".m4a") || s.EndsWith(".wav"))
                    {
                        songs.Add(s);

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

    }
}
