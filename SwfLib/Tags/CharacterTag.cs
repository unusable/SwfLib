using System;
using System.Collections.Generic;
using System.Text;

namespace SwfLib.Tags
{
    public abstract class CharacterTag : SwfTagBase
    {
        public abstract ushort CharacterID { get; set; }
    }
}
