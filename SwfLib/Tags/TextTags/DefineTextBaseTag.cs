using SwfLib.Data;

namespace SwfLib.Tags.TextTags {
    public abstract class DefineTextBaseTag : CharacterTag
    {

        public override ushort CharacterID { get; set; }

        public SwfRect TextBounds { get; set; }

        public SwfMatrix TextMatrix = SwfMatrix.Identity;

    }
}
