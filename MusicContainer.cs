using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Melodify
{
    public class MusicContainer
    {
        public string Title { get; set; }
        public List<IMusicItem> MusicItems { get; set; }

        public MusicContainer(string title)
        {
            Title = title;
            MusicItems = new List<IMusicItem>();
        }

        public void Add(IMusicItem item)
        {
            MusicItems.Add(item);
        }

        public void Remove(IMusicItem item)
        {
            MusicItems.Remove(item);
        }

        public int GetTotalDuration()
        {
            int totalDuration = 0;

            // Get total duration of all items in the container
            foreach (IMusicItem item in MusicItems)
            {
                totalDuration += item.Duration;
            }

            return totalDuration;
        }
    }
}
