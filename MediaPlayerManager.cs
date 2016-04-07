using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using CSCore;
using System.Threading;
using CSCore.Codecs;
using CSCore.SoundOut;


namespace Imagine_Music_Player
{
    public class MediaPlayerManager
    {
        public string SONG_URL;

        public int Length 
        {
            get {return (int)songURL.GetLength().TotalSeconds;}
        }
        public int Position 
        {
            get{return (int)songURL.GetPosition().TotalSeconds;}
            set{Position = value;}
        }

        private IWaveSource songURL;
        private ISoundOut Output;

        public void Play()
        {
            songURL = GetSoundSource(SONG_URL);
             Output = GetSoundOut();

            Output.Initialize(songURL);
            Output.Play();
            Thread.Sleep(2000);
        }

        public void Pause()
        {
            Output.Pause();
        }

        public void Stop()
        {
            Output.Stop();
        }

        public void Resume()
        {
            Output.Resume();
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
