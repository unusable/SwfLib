namespace SwfLib.Tags.SoundTags {
    public class SoundStreamBlockTag : SoundStreamBaseTag
    {

        public override SwfTagType TagType {
            get { return SwfTagType.SoundStreamBlock; }
        }

        public override TResult AcceptVistor<TArg, TResult>(ISwfTagVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

    }
}
