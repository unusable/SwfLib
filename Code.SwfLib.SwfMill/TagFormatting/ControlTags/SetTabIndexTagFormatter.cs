﻿using System;
using System.Xml.Linq;
using Code.SwfLib.Tags.ControlTags;

namespace Code.SwfLib.SwfMill.TagFormatting.ControlTags {
    public class SetTabIndexTagFormatter : TagFormatterBase<SetTabIndexTag> {
        protected override XElement FormatTagElement(SetTabIndexTag tag) {
            throw new NotImplementedException();
        }

        protected override void AcceptTagAttribute(SetTabIndexTag tag, XAttribute attrib) {
            throw new NotImplementedException();
        }

        protected override void AcceptTagElement(SetTabIndexTag tag, XElement element) {
            throw new NotImplementedException();
        }
    }
}