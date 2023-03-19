using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodify
{
    public interface ISettings
    {
        int Volume { get; set; }
        Song LastPlayedSong { get; set; }

        void SetVolume(int volume);
        Song GetLastPlayedSong();
    }
}
