using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;
using File = TagLib.File;

namespace Melodify.Classes
{
    public abstract class MusicData
    {
        public string Data { get; protected set; } = "";
    }

    public class Title : MusicData
    {
        public Title(string musicPath)
        {
            try
            {
                Data = File.Create(musicPath).Tag.Title;
            }
            catch
            {
                Data = "";
            }
        }
    }
}
