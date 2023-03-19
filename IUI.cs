using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodify
{
    public interface IUI
    {
        void Initialize();
        void DisplayMusicLibrary(IMusicLibrary musicLibrary);
        MusicContainer SelectMusicToPlay(IMusicLibrary musicLibrary);
        void ControlPlayback(IPlayer player);
        void SetVolume(int volume);
        void Exit();
    }
}
