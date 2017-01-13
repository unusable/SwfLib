namespace SwfLib.Tags.VideoTags {
    public class DefineVideoStreamTag : CharacterTag
    {

        public override ushort CharacterID { get; set; }


        public override SwfTagType TagType {
            get { return SwfTagType.DefineVideoStream; }
        }

        public override TResult AcceptVistor<TArg, TResult>(ISwfTagVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

    }
}
