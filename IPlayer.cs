using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodify
{
    public interface IPlayer
    {
        void Play(MusicContainer music);
        void Pause();
        void Resume();
        void Stop();
        void SkipForward();
        void SkipBackward();
    }
}
