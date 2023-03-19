using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodify
{
    public class Melodify
    {
        private IMusicLibrary musicLibrary;
        private IPlayer player;
        private IUI ui;

        public Melodify(IMusicLibrary musicLibrary, IPlayer player, IUI ui)
        {
            this.musicLibrary = musicLibrary;
            this.player = player;
            this.ui = ui;
        }

        public void Run()
        {
            // Code to start the music player
        }
    }
}
