using SwfLib.Data;

namespace SwfLib.Tags.ShapeTags {
    public abstract class ShapeBaseTag : CharacterTag
    {
        public override ushort CharacterID
        {
            get
            {
                return ShapeID;
            }
            set
            {
                ShapeID = value;
            }
        }

        public ushort ShapeID { get; set; }

        public SwfRect ShapeBounds { get; set; }

    }
}
