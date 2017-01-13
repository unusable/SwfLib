using SwfLib.Tags.ControlTags;


namespace SwfLib.Tags.SoundTags {
    public class StartSoundTag : ControlBaseTag
    {

        public override SwfTagType TagType {
            get { return SwfTagType.StartSound; }
        }

        public override TResult AcceptVistor<TArg, TResult>(ISwfTagVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }
    }
}
