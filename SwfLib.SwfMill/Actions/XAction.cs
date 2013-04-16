﻿using System.Collections.Generic;
using System.Xml.Linq;
using SwfLib.Actions;

namespace SwfLib.SwfMill.Actions {
    public static class XAction {

        private static readonly XActionReader _reader = new XActionReader();
        private static readonly XActionWriter _writer = new XActionWriter();

        public static XElement ToXml(ActionBase action) {
            return _writer.Serialize(action);
        }

        public static ActionBase FromXml(XElement xAction) {
            return _reader.Deserialize(xAction);
        }

        public static XElement ToXml(IList<ActionBase> actions, XElement xActions) {
            foreach (var action in actions) {
                xActions.Add(ToXml(action));
            }
            return xActions;
        }

        public static void FromXml(XElement xActions, IList<ActionBase> actions) {
            foreach (var xAction in xActions.Elements()) {
                actions.Add(FromXml(xAction));
            }
        }
    }
}