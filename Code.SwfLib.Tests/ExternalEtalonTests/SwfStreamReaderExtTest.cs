﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Code.SwfLib.Tags;
using NUnit.Framework;

namespace Code.SwfLib.Tests.ExternalEtalonTests {
    [TestFixture]
    public class SwfStreamReaderExtTest : ExternalEtalonTestFixtureBase {

        [Test]
        public void ReadMatrixTest() {
            var reader = new SwfTagReader(10);
            var tags =
                GetTagBinariesFromSwfResource("Matrix-compiled.swf")
                .Where(item => item.Type == SwfTagType.PlaceObject2);
            var tagData = tags.First();
            var tag = reader.ReadPlaceObject2Tag(tagData);
            Assert.AreEqual(20.5, tag.Matrix.Value.ScaleX);
            Assert.AreEqual(17.25, tag.Matrix.Value.ScaleY);

            tagData = tags.Skip(1).First();
            tag = reader.ReadPlaceObject2Tag(tagData);
            Assert.AreEqual(0.5, tag.Matrix.Value.ScaleX);
            Assert.AreEqual(1.25, tag.Matrix.Value.ScaleY);

            tagData = tags.Skip(2).First();
            tag = reader.ReadPlaceObject2Tag(tagData);
            Assert.AreEqual(0.5, tag.Matrix.Value.ScaleX);
            Assert.AreEqual(-1.25, tag.Matrix.Value.ScaleY);
        }

    }
}