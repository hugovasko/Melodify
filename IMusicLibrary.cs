using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodify
{
    public interface IMusicLibrary
    {
        List<MusicContainer> GetAllMusic();
        void AddMusic(MusicContainer music);
        void RemoveMusic(MusicContainer music);
    }
}
