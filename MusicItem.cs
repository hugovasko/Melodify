using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodify
{
    public class MusicItem
    {
        public string Title { get; set; }
        public int Duration { get; set; }

        public MusicItem(string title, int duration)
        {
            this.Title = title;
            this.Duration = duration;
        }
    }
}
