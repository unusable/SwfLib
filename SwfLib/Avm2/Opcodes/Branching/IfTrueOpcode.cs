﻿namespace SwfLib.Avm2.Opcodes.Branching {
    public class IfTrueOpcode : BaseAvm2BranchOpcode {

        public override TResult AcceptVisitor<TArg, TResult>(IAvm2OpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

    }
}
