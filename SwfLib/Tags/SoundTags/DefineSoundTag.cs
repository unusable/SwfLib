namespace SwfLib.Tags.SoundTags {
    public class DefineSoundTag : CharacterTag
    {
        public override ushort CharacterID
        {
            get
            {
                return SoundId;
            }
            set
            {
                SoundId = value;
            }
        }

        public ushort SoundId { get; set; }

        /// <summary>
        /// Gets swf tag type.
        /// </summary>
        public override SwfTagType TagType {
            get { return SwfTagType.DefineSound; }
        }

        public override TResult AcceptVistor<TArg, TResult>(ISwfTagVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }
    }
}
