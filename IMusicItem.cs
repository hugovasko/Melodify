using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodify
{
    public interface IMusicItem
    {
        string Title { get; set; }
        int Duration { get; set; }
    }
}
