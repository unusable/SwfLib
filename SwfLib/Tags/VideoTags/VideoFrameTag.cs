namespace SwfLib.Tags.VideoTags {
    public class VideoFrameTag : CharacterTag {

        public override ushort CharacterID
        {
            get
            {
                return StreamID;
            }
            set
            {
                StreamID = value;
            }
        }

        public ushort StreamID { get; set; }

        public override SwfTagType TagType {
            get { return SwfTagType.VideoFrame; }
        }

        public override TResult AcceptVistor<TArg, TResult>(ISwfTagVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }
    }
}
