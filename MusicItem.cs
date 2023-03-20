using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodify
{
    public abstract class MusicItem
    {
        public string Title { get; set; }
        public int Duration { get; set; }

        protected MusicItem(string title, int duration)
        {
            this.Title = title;
            this.Duration = duration;
        }
    }
}
