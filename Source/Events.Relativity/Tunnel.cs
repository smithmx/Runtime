// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tunnel.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Dolittle.Runtime.Events.Relativity {

  /// <summary>Holder for reflection information generated from tunnel.proto</summary>
  public static partial class TunnelReflection {

    #region Descriptor
    /// <summary>File descriptor for tunnel.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TunnelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgx0dW5uZWwucHJvdG8SCnJlbGF0aXZpdHkiPAobUGFydGljbGVTdWJzY3Jp",
            "cHRpb25NZXNzYWdlEg0KBWV2ZW50GAEgASgJEg4KBm9mZnNldBgCIAEoAyJe",
            "ChxQYXJ0aWNsZVN1YnNjcmlwdGlvbnNNZXNzYWdlEj4KDXN1YnNjcmlwdGlv",
            "bnMYASADKAsyJy5yZWxhdGl2aXR5LlBhcnRpY2xlU3Vic2NyaXB0aW9uTWVz",
            "c2FnZSJOCg9QYXJ0aWNsZU1lc3NhZ2USCgoCaWQYASABKAwSEAoIbWV0YWRh",
            "dGEYAiABKAwSDQoFZXZlbnQYAyABKAwSDgoGY29tbWl0GAQgASgDMlsKBlR1",
            "bm5lbBJRCgRPcGVuEigucmVsYXRpdml0eS5QYXJ0aWNsZVN1YnNjcmlwdGlv",
            "bnNNZXNzYWdlGhsucmVsYXRpdml0eS5QYXJ0aWNsZU1lc3NhZ2UiADABQiWq",
            "AiJEb2xpdHRsZS5SdW50aW1lLkV2ZW50cy5SZWxhdGl2aXR5YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Dolittle.Runtime.Events.Relativity.ParticleSubscriptionMessage), global::Dolittle.Runtime.Events.Relativity.ParticleSubscriptionMessage.Parser, new[]{ "Event", "Offset" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Dolittle.Runtime.Events.Relativity.ParticleSubscriptionsMessage), global::Dolittle.Runtime.Events.Relativity.ParticleSubscriptionsMessage.Parser, new[]{ "Subscriptions" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Dolittle.Runtime.Events.Relativity.ParticleMessage), global::Dolittle.Runtime.Events.Relativity.ParticleMessage.Parser, new[]{ "Id", "Metadata", "Event", "Commit" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ParticleSubscriptionMessage : pb::IMessage<ParticleSubscriptionMessage> {
    private static readonly pb::MessageParser<ParticleSubscriptionMessage> _parser = new pb::MessageParser<ParticleSubscriptionMessage>(() => new ParticleSubscriptionMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ParticleSubscriptionMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dolittle.Runtime.Events.Relativity.TunnelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParticleSubscriptionMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParticleSubscriptionMessage(ParticleSubscriptionMessage other) : this() {
      event_ = other.event_;
      offset_ = other.offset_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParticleSubscriptionMessage Clone() {
      return new ParticleSubscriptionMessage(this);
    }

    /// <summary>Field number for the "event" field.</summary>
    public const int EventFieldNumber = 1;
    private string event_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Event {
      get { return event_; }
      set {
        event_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "offset" field.</summary>
    public const int OffsetFieldNumber = 2;
    private long offset_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Offset {
      get { return offset_; }
      set {
        offset_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ParticleSubscriptionMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ParticleSubscriptionMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Event != other.Event) return false;
      if (Offset != other.Offset) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Event.Length != 0) hash ^= Event.GetHashCode();
      if (Offset != 0L) hash ^= Offset.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Event.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Event);
      }
      if (Offset != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Offset);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Event.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Event);
      }
      if (Offset != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Offset);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ParticleSubscriptionMessage other) {
      if (other == null) {
        return;
      }
      if (other.Event.Length != 0) {
        Event = other.Event;
      }
      if (other.Offset != 0L) {
        Offset = other.Offset;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Event = input.ReadString();
            break;
          }
          case 16: {
            Offset = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ParticleSubscriptionsMessage : pb::IMessage<ParticleSubscriptionsMessage> {
    private static readonly pb::MessageParser<ParticleSubscriptionsMessage> _parser = new pb::MessageParser<ParticleSubscriptionsMessage>(() => new ParticleSubscriptionsMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ParticleSubscriptionsMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dolittle.Runtime.Events.Relativity.TunnelReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParticleSubscriptionsMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParticleSubscriptionsMessage(ParticleSubscriptionsMessage other) : this() {
      subscriptions_ = other.subscriptions_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParticleSubscriptionsMessage Clone() {
      return new ParticleSubscriptionsMessage(this);
    }

    /// <summary>Field number for the "subscriptions" field.</summary>
    public const int SubscriptionsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Dolittle.Runtime.Events.Relativity.ParticleSubscriptionMessage> _repeated_subscriptions_codec
        = pb::FieldCodec.ForMessage(10, global::Dolittle.Runtime.Events.Relativity.ParticleSubscriptionMessage.Parser);
    private readonly pbc::RepeatedField<global::Dolittle.Runtime.Events.Relativity.ParticleSubscriptionMessage> subscriptions_ = new pbc::RepeatedField<global::Dolittle.Runtime.Events.Relativity.ParticleSubscriptionMessage>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Dolittle.Runtime.Events.Relativity.ParticleSubscriptionMessage> Subscriptions {
      get { return subscriptions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ParticleSubscriptionsMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ParticleSubscriptionsMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!subscriptions_.Equals(other.subscriptions_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= subscriptions_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      subscriptions_.WriteTo(output, _repeated_subscriptions_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += subscriptions_.CalculateSize(_repeated_subscriptions_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ParticleSubscriptionsMessage other) {
      if (other == null) {
        return;
      }
      subscriptions_.Add(other.subscriptions_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            subscriptions_.AddEntriesFrom(input, _repeated_subscriptions_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ParticleMessage : pb::IMessage<ParticleMessage> {
    private static readonly pb::MessageParser<ParticleMessage> _parser = new pb::MessageParser<ParticleMessage>(() => new ParticleMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ParticleMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dolittle.Runtime.Events.Relativity.TunnelReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParticleMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParticleMessage(ParticleMessage other) : this() {
      id_ = other.id_;
      metadata_ = other.metadata_;
      event_ = other.event_;
      commit_ = other.commit_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParticleMessage Clone() {
      return new ParticleMessage(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private pb::ByteString id_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 2;
    private pb::ByteString metadata_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Metadata {
      get { return metadata_; }
      set {
        metadata_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "event" field.</summary>
    public const int EventFieldNumber = 3;
    private pb::ByteString event_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Event {
      get { return event_; }
      set {
        event_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "commit" field.</summary>
    public const int CommitFieldNumber = 4;
    private long commit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Commit {
      get { return commit_; }
      set {
        commit_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ParticleMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ParticleMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Metadata != other.Metadata) return false;
      if (Event != other.Event) return false;
      if (Commit != other.Commit) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Metadata.Length != 0) hash ^= Metadata.GetHashCode();
      if (Event.Length != 0) hash ^= Event.GetHashCode();
      if (Commit != 0L) hash ^= Commit.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Id);
      }
      if (Metadata.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Metadata);
      }
      if (Event.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Event);
      }
      if (Commit != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Commit);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Id);
      }
      if (Metadata.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Metadata);
      }
      if (Event.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Event);
      }
      if (Commit != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Commit);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ParticleMessage other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Metadata.Length != 0) {
        Metadata = other.Metadata;
      }
      if (other.Event.Length != 0) {
        Event = other.Event;
      }
      if (other.Commit != 0L) {
        Commit = other.Commit;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Id = input.ReadBytes();
            break;
          }
          case 18: {
            Metadata = input.ReadBytes();
            break;
          }
          case 26: {
            Event = input.ReadBytes();
            break;
          }
          case 32: {
            Commit = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
