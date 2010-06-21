﻿namespace Code.SwfLib.Tags.FontTags
{
    public class DefineFont3Tag : SwfTagBase
    {
        public ushort ObjectID;

        public DefineFont3Attributes Attributes;

        public override object AcceptVistor(ISwfTagVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}