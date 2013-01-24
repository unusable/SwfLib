﻿using System;
using System.Xml.Linq;
using Code.SwfLib.Tags.ControlTags;

namespace Code.SwfLib.SwfMill.TagFormatting.ControlTags {
    public class ScriptLimitsTagFormatter : TagFormatterBase<ScriptLimitsTag> {

        private const string MAX_RECURSION_ATTRIB = "maxRecursionDepth";
        private const string TIMEOUT_ATTRIB = "timeout";

        protected override void AcceptTagAttribute(ScriptLimitsTag tag, XAttribute attrib) {
            switch (attrib.Name.LocalName) {
                case MAX_RECURSION_ATTRIB:
                    tag.MaxRecursionDepth = ushort.Parse(attrib.Value);
                    break;
                case TIMEOUT_ATTRIB:
                    tag.ScriptTimeoutSeconds = ushort.Parse(attrib.Value);
                    break;
                default:
                    throw new FormatException("Invalid attribute " + attrib.Name.LocalName);
            }
        }

        protected override void AcceptTagElement(ScriptLimitsTag tag, XElement element) {
            throw new FormatException("Invalid element " + element.Name.LocalName);
        }

        protected override XElement FormatTagElement(ScriptLimitsTag tag, XElement xTag) {
            return new XElement(XName.Get(SwfTagNameMapping.SCRIPT_LIMITES_TAG),
                new XAttribute(XName.Get(MAX_RECURSION_ATTRIB), tag.MaxRecursionDepth),
                new XAttribute(XName.Get(TIMEOUT_ATTRIB), tag.ScriptTimeoutSeconds)
                );
        }

    }
}
