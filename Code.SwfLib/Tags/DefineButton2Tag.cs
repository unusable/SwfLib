﻿namespace Code.SwfLib.Tags
{
    public class DefineButton2Tag : SwfTagBase
    {
        public ushort ButtonID;

        public byte ReservedFlags;

        public bool TrackAsMenu;


        public override object AcceptVistor(ISwfTagVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
