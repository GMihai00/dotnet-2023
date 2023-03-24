// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: fileformat.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OSMPBF {

  /// <summary>Holder for reflection information generated from fileformat.proto</summary>
  public static partial class FileformatReflection {

    #region Descriptor
    /// <summary>File descriptor for fileformat.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FileformatReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBmaWxlZm9ybWF0LnByb3RvEgZPU01QQkYipQEKBEJsb2ISEAoIcmF3X3Np",
            "emUYAiABKAUSDQoDcmF3GAEgASgMSAASEwoJemxpYl9kYXRhGAMgASgMSAAS",
            "EwoJbHptYV9kYXRhGAQgASgMSAASIQoTT0JTT0xFVEVfYnppcDJfZGF0YRgF",
            "IAEoDEICGAFIABISCghsejRfZGF0YRgGIAEoDEgAEhMKCXpzdGRfZGF0YRgH",
            "IAEoDEgAQgYKBGRhdGEiPwoKQmxvYkhlYWRlchIMCgR0eXBlGAEgAigJEhEK",
            "CWluZGV4ZGF0YRgCIAEoDBIQCghkYXRhc2l6ZRgDIAIoBUIPCg1jcm9zYnku",
            "YmluYXJ5"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OSMPBF.Blob), global::OSMPBF.Blob.Parser, new[]{ "RawSize", "Raw", "ZlibData", "LzmaData", "OBSOLETEBzip2Data", "Lz4Data", "ZstdData" }, new[]{ "Data" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::OSMPBF.BlobHeader), global::OSMPBF.BlobHeader.Parser, new[]{ "Type", "Indexdata", "Datasize" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Blob : pb::IMessage<Blob> {
    private static readonly pb::MessageParser<Blob> _parser = new pb::MessageParser<Blob>(() => new Blob());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Blob> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OSMPBF.FileformatReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Blob() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Blob(Blob other) : this() {
      _hasBits0 = other._hasBits0;
      rawSize_ = other.rawSize_;
      switch (other.DataCase) {
        case DataOneofCase.Raw:
          Raw = other.Raw;
          break;
        case DataOneofCase.ZlibData:
          ZlibData = other.ZlibData;
          break;
        case DataOneofCase.LzmaData:
          LzmaData = other.LzmaData;
          break;
        case DataOneofCase.OBSOLETEBzip2Data:
          OBSOLETEBzip2Data = other.OBSOLETEBzip2Data;
          break;
        case DataOneofCase.Lz4Data:
          Lz4Data = other.Lz4Data;
          break;
        case DataOneofCase.ZstdData:
          ZstdData = other.ZstdData;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Blob Clone() {
      return new Blob(this);
    }

    /// <summary>Field number for the "raw_size" field.</summary>
    public const int RawSizeFieldNumber = 2;
    private readonly static int RawSizeDefaultValue = 0;

    private int rawSize_;
    /// <summary>
    /// When compressed, the uncompressed size
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RawSize {
      get { if ((_hasBits0 & 1) != 0) { return rawSize_; } else { return RawSizeDefaultValue; } }
      set {
        _hasBits0 |= 1;
        rawSize_ = value;
      }
    }
    /// <summary>Gets whether the "raw_size" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasRawSize {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "raw_size" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearRawSize() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "raw" field.</summary>
    public const int RawFieldNumber = 1;
    /// <summary>
    /// No compression
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Raw {
      get { return HasRaw ? (pb::ByteString) data_ : pb::ByteString.Empty; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        dataCase_ = DataOneofCase.Raw;
      }
    }
    /// <summary>Gets whether the "raw" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasRaw {
      get { return dataCase_ == DataOneofCase.Raw; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "raw" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearRaw() {
      if (HasRaw) {
        ClearData();
      }
    }

    /// <summary>Field number for the "zlib_data" field.</summary>
    public const int ZlibDataFieldNumber = 3;
    /// <summary>
    /// Possible compressed versions of the data.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString ZlibData {
      get { return HasZlibData ? (pb::ByteString) data_ : pb::ByteString.Empty; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        dataCase_ = DataOneofCase.ZlibData;
      }
    }
    /// <summary>Gets whether the "zlib_data" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasZlibData {
      get { return dataCase_ == DataOneofCase.ZlibData; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "zlib_data" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearZlibData() {
      if (HasZlibData) {
        ClearData();
      }
    }

    /// <summary>Field number for the "lzma_data" field.</summary>
    public const int LzmaDataFieldNumber = 4;
    /// <summary>
    /// For LZMA compressed data (optional)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString LzmaData {
      get { return HasLzmaData ? (pb::ByteString) data_ : pb::ByteString.Empty; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        dataCase_ = DataOneofCase.LzmaData;
      }
    }
    /// <summary>Gets whether the "lzma_data" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasLzmaData {
      get { return dataCase_ == DataOneofCase.LzmaData; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "lzma_data" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearLzmaData() {
      if (HasLzmaData) {
        ClearData();
      }
    }

    /// <summary>Field number for the "OBSOLETE_bzip2_data" field.</summary>
    public const int OBSOLETEBzip2DataFieldNumber = 5;
    /// <summary>
    /// Formerly used for bzip2 compressed data. Deprecated in 2010.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString OBSOLETEBzip2Data {
      get { return HasOBSOLETEBzip2Data ? (pb::ByteString) data_ : pb::ByteString.Empty; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        dataCase_ = DataOneofCase.OBSOLETEBzip2Data;
      }
    }
    /// <summary>Gets whether the "OBSOLETE_bzip2_data" field is set</summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasOBSOLETEBzip2Data {
      get { return dataCase_ == DataOneofCase.OBSOLETEBzip2Data; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "OBSOLETE_bzip2_data" </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearOBSOLETEBzip2Data() {
      if (HasOBSOLETEBzip2Data) {
        ClearData();
      }
    }

    /// <summary>Field number for the "lz4_data" field.</summary>
    public const int Lz4DataFieldNumber = 6;
    /// <summary>
    /// For LZ4 compressed data (optional)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Lz4Data {
      get { return HasLz4Data ? (pb::ByteString) data_ : pb::ByteString.Empty; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        dataCase_ = DataOneofCase.Lz4Data;
      }
    }
    /// <summary>Gets whether the "lz4_data" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasLz4Data {
      get { return dataCase_ == DataOneofCase.Lz4Data; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "lz4_data" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearLz4Data() {
      if (HasLz4Data) {
        ClearData();
      }
    }

    /// <summary>Field number for the "zstd_data" field.</summary>
    public const int ZstdDataFieldNumber = 7;
    /// <summary>
    /// For ZSTD compressed data (optional)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString ZstdData {
      get { return HasZstdData ? (pb::ByteString) data_ : pb::ByteString.Empty; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        dataCase_ = DataOneofCase.ZstdData;
      }
    }
    /// <summary>Gets whether the "zstd_data" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasZstdData {
      get { return dataCase_ == DataOneofCase.ZstdData; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "zstd_data" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearZstdData() {
      if (HasZstdData) {
        ClearData();
      }
    }

    private object data_;
    /// <summary>Enum of possible cases for the "data" oneof.</summary>
    public enum DataOneofCase {
      None = 0,
      Raw = 1,
      ZlibData = 3,
      LzmaData = 4,
      OBSOLETEBzip2Data = 5,
      Lz4Data = 6,
      ZstdData = 7,
    }
    private DataOneofCase dataCase_ = DataOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataOneofCase DataCase {
      get { return dataCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearData() {
      dataCase_ = DataOneofCase.None;
      data_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Blob);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Blob other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RawSize != other.RawSize) return false;
      if (Raw != other.Raw) return false;
      if (ZlibData != other.ZlibData) return false;
      if (LzmaData != other.LzmaData) return false;
      if (OBSOLETEBzip2Data != other.OBSOLETEBzip2Data) return false;
      if (Lz4Data != other.Lz4Data) return false;
      if (ZstdData != other.ZstdData) return false;
      if (DataCase != other.DataCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasRawSize) hash ^= RawSize.GetHashCode();
      if (HasRaw) hash ^= Raw.GetHashCode();
      if (HasZlibData) hash ^= ZlibData.GetHashCode();
      if (HasLzmaData) hash ^= LzmaData.GetHashCode();
      if (HasOBSOLETEBzip2Data) hash ^= OBSOLETEBzip2Data.GetHashCode();
      if (HasLz4Data) hash ^= Lz4Data.GetHashCode();
      if (HasZstdData) hash ^= ZstdData.GetHashCode();
      hash ^= (int) dataCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (HasRaw) {
        output.WriteRawTag(10);
        output.WriteBytes(Raw);
      }
      if (HasRawSize) {
        output.WriteRawTag(16);
        output.WriteInt32(RawSize);
      }
      if (HasZlibData) {
        output.WriteRawTag(26);
        output.WriteBytes(ZlibData);
      }
      if (HasLzmaData) {
        output.WriteRawTag(34);
        output.WriteBytes(LzmaData);
      }
      if (HasOBSOLETEBzip2Data) {
        output.WriteRawTag(42);
        output.WriteBytes(OBSOLETEBzip2Data);
      }
      if (HasLz4Data) {
        output.WriteRawTag(50);
        output.WriteBytes(Lz4Data);
      }
      if (HasZstdData) {
        output.WriteRawTag(58);
        output.WriteBytes(ZstdData);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasRawSize) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RawSize);
      }
      if (HasRaw) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Raw);
      }
      if (HasZlibData) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ZlibData);
      }
      if (HasLzmaData) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(LzmaData);
      }
      if (HasOBSOLETEBzip2Data) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(OBSOLETEBzip2Data);
      }
      if (HasLz4Data) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Lz4Data);
      }
      if (HasZstdData) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ZstdData);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Blob other) {
      if (other == null) {
        return;
      }
      if (other.HasRawSize) {
        RawSize = other.RawSize;
      }
      switch (other.DataCase) {
        case DataOneofCase.Raw:
          Raw = other.Raw;
          break;
        case DataOneofCase.ZlibData:
          ZlibData = other.ZlibData;
          break;
        case DataOneofCase.LzmaData:
          LzmaData = other.LzmaData;
          break;
        case DataOneofCase.OBSOLETEBzip2Data:
          OBSOLETEBzip2Data = other.OBSOLETEBzip2Data;
          break;
        case DataOneofCase.Lz4Data:
          Lz4Data = other.Lz4Data;
          break;
        case DataOneofCase.ZstdData:
          ZstdData = other.ZstdData;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Raw = input.ReadBytes();
            break;
          }
          case 16: {
            RawSize = input.ReadInt32();
            break;
          }
          case 26: {
            ZlibData = input.ReadBytes();
            break;
          }
          case 34: {
            LzmaData = input.ReadBytes();
            break;
          }
          case 42: {
            OBSOLETEBzip2Data = input.ReadBytes();
            break;
          }
          case 50: {
            Lz4Data = input.ReadBytes();
            break;
          }
          case 58: {
            ZstdData = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  public sealed partial class BlobHeader : pb::IMessage<BlobHeader> {
    private static readonly pb::MessageParser<BlobHeader> _parser = new pb::MessageParser<BlobHeader>(() => new BlobHeader());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BlobHeader> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OSMPBF.FileformatReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BlobHeader() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BlobHeader(BlobHeader other) : this() {
      _hasBits0 = other._hasBits0;
      type_ = other.type_;
      indexdata_ = other.indexdata_;
      datasize_ = other.datasize_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BlobHeader Clone() {
      return new BlobHeader(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private readonly static string TypeDefaultValue = "";

    private string type_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_ ?? TypeDefaultValue; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "type" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasType {
      get { return type_ != null; }
    }
    /// <summary>Clears the value of the "type" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearType() {
      type_ = null;
    }

    /// <summary>Field number for the "indexdata" field.</summary>
    public const int IndexdataFieldNumber = 2;
    private readonly static pb::ByteString IndexdataDefaultValue = pb::ByteString.Empty;

    private pb::ByteString indexdata_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Indexdata {
      get { return indexdata_ ?? IndexdataDefaultValue; }
      set {
        indexdata_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "indexdata" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasIndexdata {
      get { return indexdata_ != null; }
    }
    /// <summary>Clears the value of the "indexdata" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearIndexdata() {
      indexdata_ = null;
    }

    /// <summary>Field number for the "datasize" field.</summary>
    public const int DatasizeFieldNumber = 3;
    private readonly static int DatasizeDefaultValue = 0;

    private int datasize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Datasize {
      get { if ((_hasBits0 & 1) != 0) { return datasize_; } else { return DatasizeDefaultValue; } }
      set {
        _hasBits0 |= 1;
        datasize_ = value;
      }
    }
    /// <summary>Gets whether the "datasize" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasDatasize {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "datasize" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearDatasize() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BlobHeader);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BlobHeader other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Indexdata != other.Indexdata) return false;
      if (Datasize != other.Datasize) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasType) hash ^= Type.GetHashCode();
      if (HasIndexdata) hash ^= Indexdata.GetHashCode();
      if (HasDatasize) hash ^= Datasize.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (HasType) {
        output.WriteRawTag(10);
        output.WriteString(Type);
      }
      if (HasIndexdata) {
        output.WriteRawTag(18);
        output.WriteBytes(Indexdata);
      }
      if (HasDatasize) {
        output.WriteRawTag(24);
        output.WriteInt32(Datasize);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasType) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (HasIndexdata) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Indexdata);
      }
      if (HasDatasize) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Datasize);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BlobHeader other) {
      if (other == null) {
        return;
      }
      if (other.HasType) {
        Type = other.Type;
      }
      if (other.HasIndexdata) {
        Indexdata = other.Indexdata;
      }
      if (other.HasDatasize) {
        Datasize = other.Datasize;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Type = input.ReadString();
            break;
          }
          case 18: {
            Indexdata = input.ReadBytes();
            break;
          }
          case 24: {
            Datasize = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
