﻿namespace Code.SwfLib.Actions {
    public class ActionEnumerate : ActionBase {
        
        public override ActionCode ActionCode {
            get { return ActionCode.Enumerate; }
        }

        public override TResult AcceptVisitor<TArg, TResult>(IActionVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

    }
}
