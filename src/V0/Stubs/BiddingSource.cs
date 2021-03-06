// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/bidding_source.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/bidding_source.proto</summary>
  public static partial class BiddingSourceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/bidding_source.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BiddingSourceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9iaWRkaW5nX3NvdXJj",
            "ZS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZW51bXMaHGdvb2ds",
            "ZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8ifQoRQmlkZGluZ1NvdXJjZUVudW0i",
            "aAoNQmlkZGluZ1NvdXJjZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04Q",
            "ARILCgdBREdST1VQEAISDQoJQ1JJVEVSSU9OEAMSHQoZQ0FNUEFJR05fQklE",
            "RElOR19TVFJBVEVHWRAFQucBCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djAuZW51bXNCEkJpZGRpbmdTb3VyY2VQcm90b1ABWkJnb29nbGUuZ29sYW5n",
            "Lm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjAvZW51",
            "bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMC5FbnVt",
            "c8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYwXEVudW1z6gIhR29vZ2xlOjpB",
            "ZHM6Okdvb2dsZUFkczo6VjA6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.BiddingSourceEnum), global::Google.Ads.GoogleAds.V0.Enums.BiddingSourceEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.BiddingSourceEnum.Types.BiddingSource) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible bidding sources.
  /// </summary>
  public sealed partial class BiddingSourceEnum : pb::IMessage<BiddingSourceEnum> {
    private static readonly pb::MessageParser<BiddingSourceEnum> _parser = new pb::MessageParser<BiddingSourceEnum>(() => new BiddingSourceEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BiddingSourceEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.BiddingSourceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BiddingSourceEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BiddingSourceEnum(BiddingSourceEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BiddingSourceEnum Clone() {
      return new BiddingSourceEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BiddingSourceEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BiddingSourceEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BiddingSourceEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the BiddingSourceEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible bidding sources.
      /// </summary>
      public enum BiddingSource {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Bidding entity is defined on the ad group.
        /// </summary>
        [pbr::OriginalName("ADGROUP")] Adgroup = 2,
        /// <summary>
        /// Bidding entity is defined on the ad group criterion.
        /// </summary>
        [pbr::OriginalName("CRITERION")] Criterion = 3,
        /// <summary>
        /// Effective bidding entity is inherited from campaign bidding strategy.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BIDDING_STRATEGY")] CampaignBiddingStrategy = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
