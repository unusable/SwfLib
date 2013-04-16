﻿using SwfLib.Data;

namespace SwfLib.Tags.TextTags {
    public class DefineEditTextTag : TextBaseTag {

        public ushort CharacterID;

        public SwfRect Bounds;

        public bool WordWrap;

        public bool Multiline;

        public bool Password;

        public bool ReadOnly;

        public bool HasFont;

        public bool HasFontClass;

        public bool AutoSize;

        public bool HasLayout;

        public bool NoSelect;

        public bool Border;

        public bool WasStatic;

        public bool HTML;

        public bool UseOutlines;

        public ushort FontID;

        public string FontClass;

        public ushort FontHeight;

        public SwfRGBA? TextColor;

        public ushort? MaxLength;

        //TODO: Use enum
        public byte Align;

        public ushort LeftMargin;

        public ushort RightMargin;

        public ushort Indent;

        public short Leading;

        public string VariableName;

        public string InitialText;

        public override SwfTagType TagType {
            get { return SwfTagType.DefineEditText; }
        }

        public override TResult AcceptVistor<TArg, TResult>(ISwfTagVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }
    }
}