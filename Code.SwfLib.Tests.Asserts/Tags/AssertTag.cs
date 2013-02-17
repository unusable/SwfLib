﻿using Code.SwfLib.Tags.ControlTags;
using Code.SwfLib.Tags.DisplayListTags;
using Code.SwfLib.Tags.ShapeTags;
using Code.SwfLib.Tests.Asserts.Shapes;
using NUnit.Framework;

namespace Code.SwfLib.Tests.Asserts.Tags {
    public static class AssertTag {

        public static void AreEqual(PlaceObject2Tag expected, PlaceObject2Tag actual) {
            Assert.AreEqual(expected.CharacterID, actual.CharacterID);
            Assert.AreEqual(expected.Depth, actual.Depth);
            AssertData.AreEqual(expected.Matrix, actual.Matrix, "Matrix");
            Assert.AreEqual(expected.HasColorTransform, actual.HasColorTransform, "HasColorTransform");
            AssertData.AreEqual(expected.ColorTransform, actual.ColorTransform, "ColorTransform");
            Assert.AreEqual(expected.RestData, actual.RestData);
        }

        public static void AreEqual(PlaceObject3Tag expected, PlaceObject3Tag actual) {
            Assert.AreEqual(expected.CharacterID, actual.CharacterID);
            Assert.AreEqual(expected.Depth, actual.Depth);
            AssertData.AreEqual(expected.Matrix, actual.Matrix, "Matrix");
            AssertFilters.AreEqual(expected.Filters, actual.Filters);
            Assert.AreEqual(expected.RestData, actual.RestData);
        }

        public static void AreEqual(DefineShapeTag expected, DefineShapeTag actual) {
            Assert.AreEqual(expected.ShapeID, actual.ShapeID);
            AssertData.AreEqual(expected.ShapeBounds, actual.ShapeBounds, "ShapeBounds");
            Assert.AreEqual(expected.FillStyles.Count, actual.FillStyles.Count, "FillStyles.Count");
            for (var i = 0; i < expected.FillStyles.Count; i++) {
                var exp = expected.FillStyles[i];
                var act = actual.FillStyles[i];
                AssertFillStyles.AreEqual(exp, act, "FillStyles[" + i + "]");
            }
            Assert.AreEqual(expected.LineStyles.Count, actual.LineStyles.Count, "LineStyles.Count");
            for (var i = 0; i < expected.LineStyles.Count; i++) {
                var exp = expected.LineStyles[i];
                var act = actual.LineStyles[i];
                AssertShape.AreEqual(exp, act, "LineStyles[" + i + "]");
            }
            Assert.AreEqual(expected.ShapeRecords.Count, actual.ShapeRecords.Count, "ShapeRecords.Count");
            for (var i = 0; i < expected.ShapeRecords.Count; i++) {
                var exp = expected.ShapeRecords[i];
                var act = actual.ShapeRecords[i];
                AssertShape.AreEqual(exp, act, "ShapeRecords[" + i + "]");
            }
            Assert.AreEqual(expected.RestData, actual.RestData);
        }

        public static void AreEqual(FileAttributesTag expected, FileAttributesTag actual) {
            Assert.AreEqual(expected.AllowAbc, actual.AllowAbc);
            Assert.AreEqual(expected.HasMetadata, actual.HasMetadata);
            Assert.AreEqual(expected.Reserved, actual.Reserved);
            Assert.AreEqual(expected.Reserved0, actual.Reserved0);
            Assert.AreEqual(expected.SuppressCrossDomainCaching, actual.SuppressCrossDomainCaching);
            Assert.AreEqual(expected.SwfRelativeUrls, actual.SwfRelativeUrls);
            Assert.AreEqual(expected.UseDirectBlit, actual.UseDirectBlit);
            Assert.AreEqual(expected.UseGPU, actual.UseGPU);
            Assert.AreEqual(expected.UseNetwork, actual.UseNetwork);
            Assert.AreEqual(expected.RestData, actual.RestData);
        }
    }
}
