﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Code.SwfLib.Tags;

namespace Code.SwfLib.SwfMill.TagFormatting {
    public class ExportTagFormatter : TagFormatterBase<ExportTag> {

        public override void AcceptAttribute(ExportTag tag, XAttribute attrib) {
            switch (attrib.Name.LocalName) {
                default:
                    throw new FormatException("Invalid attribute " + attrib.Name.LocalName);
            }
        }

        public override void AcceptElement(ExportTag tag, XElement element) {
            switch (element.Name.LocalName) {
                default:
                    throw new FormatException("Invalid element " + element.Name.LocalName);
            }
        }

        public override XElement FormatTag(ExportTag tag) {
            return new XElement(XName.Get(SwfTagNameMapping.EXPORT_TAG),
                                 new XElement(XName.Get("symbols"), tag.Symbols.Select(item => GetSymbol(item))));
        }
    }
}
