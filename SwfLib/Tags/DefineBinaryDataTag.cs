namespace SwfLib.Tags {
    public class DefineBinaryDataTag : CharacterTag
    {

        public override ushort CharacterID { get; set; }

        public override SwfTagType TagType
        {
            get { return SwfTagType.DefineBinaryData; }
        }

        public override TResult AcceptVistor<TArg, TResult>(ISwfTagVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

    }
}
