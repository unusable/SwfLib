namespace SwfLib.Tags.FontTags {
    public class DefineFontInfo2Tag : FontExtensionTag {

        public override SwfTagType TagType {
            get { return SwfTagType.DefineFontInfo2; }
        }

        public override TResult AcceptVistor<TArg, TResult>(ISwfTagVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }
    }
}
