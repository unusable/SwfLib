﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Code.SwfLib.Tags;

namespace Code.SwfLib.Tests.ExternalEtalonTests {
    public abstract class ExternalEtalonTestFixtureBase : TestFixtureBase {

        protected struct TagBinaryInfo {
            public SwfTagType Type;

            public byte[] Binary;

        }

        protected IEnumerable<TagBinaryInfo> GetTagFullBinariesFromSwfResource(string resourceName) {
            var file = new SwfFile();
            var stream = OpenEmbeddedResource(resourceName);
            SwfStreamReader reader = new SwfStreamReader(stream);
            file.FileInfo = reader.ReadSwfFileInfo();
            stream = DecompressIfNeeded(file.FileInfo, stream);
            stream.Seek(8, SeekOrigin.Begin);
            reader = new SwfStreamReader(stream);
            file.Header = reader.ReadSwfHeader();

            while (stream.Position < stream.Length) {
                var position = stream.Position;

                ushort typeAndSize = reader.ReadUInt16();
                SwfTagType type = (SwfTagType)(typeAndSize >> 6);
                int shortSize = typeAndSize & 0x3f;
                int size = shortSize < 0x3f ? shortSize : reader.ReadInt32();

                var length = stream.Position - position + size;

                stream.Seek(position, SeekOrigin.Begin);
                yield return new TagBinaryInfo { Type = type, Binary = reader.ReadBytes((int)length) };
            }
        }

        protected IEnumerable<SwfTagData> GetTagBinariesFromSwfResource(string resourceName) {
            var file = new SwfFile();
            var stream = OpenEmbeddedResource(resourceName);
            SwfStreamReader reader = new SwfStreamReader(stream);
            file.FileInfo = reader.ReadSwfFileInfo();
            stream = DecompressIfNeeded(file.FileInfo, stream);
            stream.Seek(8, SeekOrigin.Begin);
            reader = new SwfStreamReader(stream);
            file.Header = reader.ReadSwfHeader();

            while (stream.Position < stream.Length) {
                ushort typeAndSize = reader.ReadUInt16();
                SwfTagType type = (SwfTagType)(typeAndSize >> 6);
                int shortSize = typeAndSize & 0x3f;
                int size = shortSize < 0x3f ? shortSize : reader.ReadInt32();
                yield return new SwfTagData { Type = type, Data = reader.ReadBytes(size) };
            }
        }

        private static Stream DecompressIfNeeded(SwfFileInfo info, Stream stream) {
            switch (info.Format) {
                case "CWS":
                    MemoryStream mem = new MemoryStream();
                    SwfZip.Decompress(stream, mem);
                    mem.Seek(8, SeekOrigin.Begin);
                    return mem;
                case "FWS":
                    return stream;
                default:
                    throw new NotSupportedException("Illegal file format");
            }
        }
    }
}