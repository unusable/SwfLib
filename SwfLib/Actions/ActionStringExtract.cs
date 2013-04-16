﻿namespace SwfLib.Actions {
    public class ActionStringExtract : ActionBase {

        public override ActionCode ActionCode {
            get { return ActionCode.StringExtract; }
        }

        public override TResult AcceptVisitor<TArg, TResult>(IActionVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

    }
}