using System.Collections.Generic;
using SwfLib.ClipActions;
using SwfLib.Data;
using SwfLib.Filters;

namespace SwfLib.Tags.DisplayListTags {
    public class PlaceObject3Tag : PlaceObjectBaseTag {

        public bool HasClipActions;

        public bool HasCharacter;

        public bool HasMatrix;

        public bool Move;

        public bool HasImage;


        public string Name{ get; set; }

        public string ClassName{ get; set; }

        public byte Reserved{ get; set; }

        public ushort? Ratio { get; set; }

        public byte? BitmapCache{ get; set; }

        public ushort? ClipDepth{ get; set; }

        public ColorTransformRGBA? ColorTransform{ get; set; }

        public readonly ClipActionsList ClipActions = new ClipActionsList();

        public BlendMode? BlendMode{ get; set; }

        public readonly IList<BaseFilter> Filters = new List<BaseFilter>();

        public override SwfTagType TagType {
            get { return SwfTagType.PlaceObject3; }
        }

        public override TResult AcceptVistor<TArg, TResult>(ISwfTagVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }
    }
}