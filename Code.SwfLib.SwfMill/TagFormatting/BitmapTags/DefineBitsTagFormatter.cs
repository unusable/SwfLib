﻿using System.Xml.Linq;
using Code.SwfLib.Tags.BitmapTags;

namespace Code.SwfLib.SwfMill.TagFormatting.BitmapTags {
    public class DefineBitsTagFormatter : TagFormatterBase<DefineBitsTag> {
        protected override XElement FormatTagElement(DefineBitsTag tag) {
            throw new System.NotImplementedException();
        }

        protected override void AcceptTagAttribute(DefineBitsTag tag, XAttribute attrib) {
            throw new System.NotImplementedException();
        }

        protected override void AcceptTagElement(DefineBitsTag tag, XElement element) {
            throw new System.NotImplementedException();
        }
    }
}