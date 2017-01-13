using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwfLib.Tags
{
    public abstract class CharacterTag : SwfTagBase
    {
        public abstract ushort CharacterID { get; set; }
    }
}
