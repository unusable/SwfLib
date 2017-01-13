namespace SwfLib.Tags.FontTags {
    public abstract class FontExtensionTag : SwfTagBase
    {
        public ushort FontID;

    }

    public abstract class FontBaseTag : CharacterTag
    {
        public override ushort CharacterID
        {
            get
            {
                return FontID;
            }
            set
            {
                FontID = value;
            }
        }
        public ushort FontID;

    }
}
