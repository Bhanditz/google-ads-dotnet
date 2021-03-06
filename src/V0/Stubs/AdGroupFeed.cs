// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/resources/ad_group_feed.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/resources/ad_group_feed.proto</summary>
  public static partial class AdGroupFeedReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/resources/ad_group_feed.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupFeedReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9yZXNvdXJjZXMvYWRfZ3JvdXBf",
            "ZmVlZC5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAucmVzb3VyY2Vz",
            "GjZnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9jb21tb24vbWF0Y2hpbmdfZnVu",
            "Y3Rpb24ucHJvdG8aNGdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YwL2VudW1zL2Zl",
            "ZWRfbGlua19zdGF0dXMucHJvdG8aNGdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Yw",
            "L2VudW1zL3BsYWNlaG9sZGVyX3R5cGUucHJvdG8aHmdvb2dsZS9wcm90b2J1",
            "Zi93cmFwcGVycy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90",
            "byL+AgoLQWRHcm91cEZlZWQSFQoNcmVzb3VyY2VfbmFtZRgBIAEoCRIqCgRm",
            "ZWVkGAIgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlEi4KCGFk",
            "X2dyb3VwGAMgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlEl0K",
            "EXBsYWNlaG9sZGVyX3R5cGVzGAQgAygOMkIuZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjAuZW51bXMuUGxhY2Vob2xkZXJUeXBlRW51bS5QbGFjZWhvbGRlclR5",
            "cGUSSwoRbWF0Y2hpbmdfZnVuY3Rpb24YBSABKAsyMC5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MC5jb21tb24uTWF0Y2hpbmdGdW5jdGlvbhJQCgZzdGF0dXMY",
            "BiABKA4yQC5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lbnVtcy5GZWVkTGlu",
            "a1N0YXR1c0VudW0uRmVlZExpbmtTdGF0dXNC/QEKJWNvbS5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52MC5yZXNvdXJjZXNCEEFkR3JvdXBGZWVkUHJvdG9QAVpK",
            "Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29v",
            "Z2xlYWRzL3YwL3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiFHb29nbGUu",
            "QWRzLkdvb2dsZUFkcy5WMC5SZXNvdXJjZXPKAiFHb29nbGVcQWRzXEdvb2ds",
            "ZUFkc1xWMFxSZXNvdXJjZXPqAiVHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpW",
            "MDo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Common.MatchingFunctionReflection.Descriptor, global::Google.Ads.GoogleAds.V0.Enums.FeedLinkStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V0.Enums.PlaceholderTypeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Resources.AdGroupFeed), global::Google.Ads.GoogleAds.V0.Resources.AdGroupFeed.Parser, new[]{ "ResourceName", "Feed", "AdGroup", "PlaceholderTypes", "MatchingFunction", "Status" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An ad group feed.
  /// </summary>
  public sealed partial class AdGroupFeed : pb::IMessage<AdGroupFeed> {
    private static readonly pb::MessageParser<AdGroupFeed> _parser = new pb::MessageParser<AdGroupFeed>(() => new AdGroupFeed());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdGroupFeed> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Resources.AdGroupFeedReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupFeed() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupFeed(AdGroupFeed other) : this() {
      resourceName_ = other.resourceName_;
      Feed = other.Feed;
      AdGroup = other.AdGroup;
      placeholderTypes_ = other.placeholderTypes_.Clone();
      matchingFunction_ = other.matchingFunction_ != null ? other.matchingFunction_.Clone() : null;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupFeed Clone() {
      return new AdGroupFeed(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the ad group feed.
    /// Ad group feed resource names have the form:
    ///
    /// `customers/{customer_id}/adGroupFeeds/{ad_group_id}~{feed_id}
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "feed" field.</summary>
    public const int FeedFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_feed_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string feed_;
    /// <summary>
    /// The feed being linked to the ad group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Feed {
      get { return feed_; }
      set {
        feed_ = value;
      }
    }

    /// <summary>Field number for the "ad_group" field.</summary>
    public const int AdGroupFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_adGroup_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string adGroup_;
    /// <summary>
    /// The ad group being linked to the feed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroup {
      get { return adGroup_; }
      set {
        adGroup_ = value;
      }
    }

    /// <summary>Field number for the "placeholder_types" field.</summary>
    public const int PlaceholderTypesFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V0.Enums.PlaceholderTypeEnum.Types.PlaceholderType> _repeated_placeholderTypes_codec
        = pb::FieldCodec.ForEnum(34, x => (int) x, x => (global::Google.Ads.GoogleAds.V0.Enums.PlaceholderTypeEnum.Types.PlaceholderType) x);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Enums.PlaceholderTypeEnum.Types.PlaceholderType> placeholderTypes_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Enums.PlaceholderTypeEnum.Types.PlaceholderType>();
    /// <summary>
    /// Indicates which placeholder types the feed may populate under the connected
    /// ad group. Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Enums.PlaceholderTypeEnum.Types.PlaceholderType> PlaceholderTypes {
      get { return placeholderTypes_; }
    }

    /// <summary>Field number for the "matching_function" field.</summary>
    public const int MatchingFunctionFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V0.Common.MatchingFunction matchingFunction_;
    /// <summary>
    /// Matching function associated with the AdGroupFeed.
    /// The matching function is used to filter the set of feed items selected.
    /// Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Common.MatchingFunction MatchingFunction {
      get { return matchingFunction_; }
      set {
        matchingFunction_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V0.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus status_ = 0;
    /// <summary>
    /// Status of the ad group feed.
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdGroupFeed);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdGroupFeed other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Feed != other.Feed) return false;
      if (AdGroup != other.AdGroup) return false;
      if(!placeholderTypes_.Equals(other.placeholderTypes_)) return false;
      if (!object.Equals(MatchingFunction, other.MatchingFunction)) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (feed_ != null) hash ^= Feed.GetHashCode();
      if (adGroup_ != null) hash ^= AdGroup.GetHashCode();
      hash ^= placeholderTypes_.GetHashCode();
      if (matchingFunction_ != null) hash ^= MatchingFunction.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (feed_ != null) {
        _single_feed_codec.WriteTagAndValue(output, Feed);
      }
      if (adGroup_ != null) {
        _single_adGroup_codec.WriteTagAndValue(output, AdGroup);
      }
      placeholderTypes_.WriteTo(output, _repeated_placeholderTypes_codec);
      if (matchingFunction_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(MatchingFunction);
      }
      if (Status != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (feed_ != null) {
        size += _single_feed_codec.CalculateSizeWithTag(Feed);
      }
      if (adGroup_ != null) {
        size += _single_adGroup_codec.CalculateSizeWithTag(AdGroup);
      }
      size += placeholderTypes_.CalculateSize(_repeated_placeholderTypes_codec);
      if (matchingFunction_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MatchingFunction);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdGroupFeed other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.feed_ != null) {
        if (feed_ == null || other.Feed != "") {
          Feed = other.Feed;
        }
      }
      if (other.adGroup_ != null) {
        if (adGroup_ == null || other.AdGroup != "") {
          AdGroup = other.AdGroup;
        }
      }
      placeholderTypes_.Add(other.placeholderTypes_);
      if (other.matchingFunction_ != null) {
        if (matchingFunction_ == null) {
          matchingFunction_ = new global::Google.Ads.GoogleAds.V0.Common.MatchingFunction();
        }
        MatchingFunction.MergeFrom(other.MatchingFunction);
      }
      if (other.Status != 0) {
        Status = other.Status;
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
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            string value = _single_feed_codec.Read(input);
            if (feed_ == null || value != "") {
              Feed = value;
            }
            break;
          }
          case 26: {
            string value = _single_adGroup_codec.Read(input);
            if (adGroup_ == null || value != "") {
              AdGroup = value;
            }
            break;
          }
          case 34:
          case 32: {
            placeholderTypes_.AddEntriesFrom(input, _repeated_placeholderTypes_codec);
            break;
          }
          case 42: {
            if (matchingFunction_ == null) {
              matchingFunction_ = new global::Google.Ads.GoogleAds.V0.Common.MatchingFunction();
            }
            input.ReadMessage(matchingFunction_);
            break;
          }
          case 48: {
            status_ = (global::Google.Ads.GoogleAds.V0.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
