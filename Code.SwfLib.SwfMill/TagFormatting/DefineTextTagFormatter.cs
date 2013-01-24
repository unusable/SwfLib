﻿using System;
using System.Linq;
using System.Xml.Linq;
using Code.SwfLib.SwfMill.Data;
using Code.SwfLib.Tags.TextTags;

namespace Code.SwfLib.SwfMill.TagFormatting {
    public class DefineTextTagFormatter : TagFormatterBase<DefineTextTag> {

        private const string BOUNDS_ELEM = "bounds";
        private const string TRANSFORM_ELEM = "transform";
        private const string RECORDS_ELEM = "records";

        protected override void AcceptTagAttribute(DefineTextTag tag, XAttribute attrib) {
            switch (attrib.Name.LocalName) {
                case OBJECT_ID_ATTRIB:
                    tag.CharacterID = SwfMillPrimitives.ParseObjectID(attrib);
                    break;
                default:
                    throw new FormatException("Invalid attribute " + attrib.Name.LocalName);
            }
        }

        protected override void AcceptTagElement(DefineTextTag tag, XElement element) {
            switch (element.Name.LocalName) {
                case BOUNDS_ELEM:
                    tag.TextBounds = XRect.FromXml(element.Element(XName.Get("Rectangle")));
                    break;
                case TRANSFORM_ELEM:
                    _formatters.Matrix.Parse(element.Element(XName.Get("Transform")), out tag.TextMatrix);
                    break;
                case RECORDS_ELEM:
                    ReadRecords(tag, element);
                    break;
                default:
                    throw new FormatException("Invalid element " + element.Name.LocalName);
            }
        }

        private static void ReadRecords(DefineTextTag tag, XElement recordsElem) {
            var elem = recordsElem.Element(XName.Get("TextRecord")).Element(XName.Get("records"));
            foreach (var recordElem in elem.Elements()) {
                tag.TextRecords.Add(SwfMillPrimitives.ParseTextRecord(recordElem));
            }
        }

        //TODO: simulate swfmill incorrect structure of TextRecord (parsing, formating)

        protected override XElement FormatTagElement(DefineTextTag tag, XElement xTag) {
            var res = new XElement(XName.Get(SwfTagNameMapping.DEFINE_TEXT_TAG),
                                   new XAttribute(XName.Get("objectID"), tag.CharacterID));
            res.Add(new XElement("bounds", XRect.ToXml(tag.TextBounds)));
            res.Add(new XElement("transform", _formatters.Matrix.Format(ref tag.TextMatrix)));
            //TODO: remove unnessary nested nodes. Swfmill requires them
            res.Add(new XElement(XName.Get("records"),
                                 new XElement(XName.Get("TextRecord"),
                                              new XElement(XName.Get("records"),
                                                           tag.TextRecords.Select(item => SwfMillPrimitives.FormatTextRecord(item))
                                                  )
                                     )));
            //TODO: Other fields
            return res;
        }
    }
}
