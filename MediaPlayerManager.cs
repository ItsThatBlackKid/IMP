using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using CSCore;
using System.Threading;
using CSCore.Codecs;
using CSCore.SoundOut;
using TagLib;


namespace Imagine_Music_Player
{
    public class MediaPlayerManager
    {
        public string SONG_URL;

        private PlaybackState music_state;

        public int Length 
        {
            get {return (int)songURL.GetLength().TotalSeconds;}
        }
        public int Position 
        {
            get{return (int)songURL.GetPosition().TotalSeconds;}
            set{Position = value;}
        }

        private TagLib.File[] SongQueue;
        private IWaveSource songURL;
        private ISoundOut Output;
        public Boolean songPlaying;

        public PlaybackState MusicState
        {
            get { return this.music_state;}
            set { this.music_state = value; }
        }

        public void Play()
        {
            songURL = GetSoundSource(SONG_URL);
            Output = GetSoundOut();
            Output.Initialize(songURL);
            Output.Play();
            MusicState = PlaybackState.Playing;
            songPlaying = true;
        }

        public TagLib.File[] ShuffleQueue(TagLib.File[] queue) 
        {
            Random rnd = new Random();
            List<KeyValuePair<int, TagLib.File>> queue_list = new List<KeyValuePair<int, TagLib.File>>();
            foreach (TagLib.File TF in queue)
            {
                queue_list.Add(new KeyValuePair<int, TagLib.File>(rnd.Next(), TF));
            }

            var sorted = from item in queue_list
                         orderby item.Key
                         select item;
            TagLib.File[] new_queue = new TagLib.File[queue.Length];

            int index = 0; 
            foreach(KeyValuePair<int, TagLib.File> pair in sorted)
            {
                new_queue[index] = pair.Value;
                index++;
            }

            return new_queue;
        }

        public void NextSong(int i, TagLib.File[] queue)
        {
            SONG_URL = queue[i].Name;
        }

        public void Pause()
        {
            Output.Pause();
            MusicState = PlaybackState.Paused;
        }

        public void Stop()
        {
            Output.Stop();
            MusicState = PlaybackState.Stopped;
        }

        public void Resume()
        {
            Output.Resume();
            MusicState = PlaybackState.Playing;
        }

        public void EndSession() 
        {
            Output.Dispose();
        }

        private ISoundOut GetSoundOut()
        {
            if (WasapiOut.IsSupportedOnCurrentPlatform)
                return new WasapiOut();
            else
                return new DirectSoundOut();
        }

        private IWaveSource GetSoundSource(String source)
        {
            return CodecFactory.Instance.GetCodec(source);
        }
    }
}
