namespace SwfLib.Tags.ButtonTags {
    public abstract class DefineButtonBaseTag : CharacterTag
    {
        public override ushort CharacterID
        {
            get
            {
                return ButtonID;
            }
            set
            {
                ButtonID = value;
            }
        }

        public ushort ButtonID;

    }
}
