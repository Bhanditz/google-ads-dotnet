// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/errors/campaign_budget_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/errors/campaign_budget_error.proto</summary>
  public static partial class CampaignBudgetErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/errors/campaign_budget_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignBudgetErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lcnJvcnMvY2FtcGFpZ25fYnVk",
            "Z2V0X2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5lcnJv",
            "cnMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i4AUKF0NhbXBhaWdu",
            "QnVkZ2V0RXJyb3JFbnVtIsQFChNDYW1wYWlnbkJ1ZGdldEVycm9yEg8KC1VO",
            "U1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEiQKIENBTVBBSUdOX0JVREdFVF9D",
            "QU5OT1RfQkVfU0hBUkVEEBESGwoXQ0FNUEFJR05fQlVER0VUX1JFTU9WRUQQ",
            "AhIaChZDQU1QQUlHTl9CVURHRVRfSU5fVVNFEAMSKAokQ0FNUEFJR05fQlVE",
            "R0VUX1BFUklPRF9OT1RfQVZBSUxBQkxFEAQSPAo4Q0FOTk9UX01PRElGWV9G",
            "SUVMRF9PRl9JTVBMSUNJVExZX1NIQVJFRF9DQU1QQUlHTl9CVURHRVQQBhI2",
            "CjJDQU5OT1RfVVBEQVRFX0NBTVBBSUdOX0JVREdFVF9UT19JTVBMSUNJVExZ",
            "X1NIQVJFRBAHEkMKP0NBTk5PVF9VUERBVEVfQ0FNUEFJR05fQlVER0VUX1RP",
            "X0VYUExJQ0lUTFlfU0hBUkVEX1dJVEhPVVRfTkFNRRAIEjYKMkNBTk5PVF9V",
            "UERBVEVfQ0FNUEFJR05fQlVER0VUX1RPX0VYUExJQ0lUTFlfU0hBUkVEEAkS",
            "SApEQ0FOTk9UX1VTRV9JTVBMSUNJVExZX1NIQVJFRF9DQU1QQUlHTl9CVURH",
            "RVRfV0lUSF9NVUxUSVBMRV9DQU1QQUlHTlMQChISCg5EVVBMSUNBVEVfTkFN",
            "RRALEiIKHk1PTkVZX0FNT1VOVF9JTl9XUk9OR19DVVJSRU5DWRAMEi8KK01P",
            "TkVZX0FNT1VOVF9MRVNTX1RIQU5fQ1VSUkVOQ1lfTUlOSU1VTV9DUEMQDRIa",
            "ChZNT05FWV9BTU9VTlRfVE9PX0xBUkdFEA4SGQoVTkVHQVRJVkVfTU9ORVlf",
            "QU1PVU5UEA8SKQolTk9OX01VTFRJUExFX09GX01JTklNVU1fQ1VSUkVOQ1lf",
            "VU5JVBAQQvMBCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEuZXJyb3Jz",
            "QhhDYW1wYWlnbkJ1ZGdldEVycm9yUHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxL2Vycm9y",
            "cztlcnJvcnOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMS5FcnJv",
            "cnPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMVxFcnJvcnPqAiJHb29nbGU6",
            "OkFkczo6R29vZ2xlQWRzOjpWMTo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Errors.CampaignBudgetErrorEnum), global::Google.Ads.GoogleAds.V1.Errors.CampaignBudgetErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Errors.CampaignBudgetErrorEnum.Types.CampaignBudgetError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible campaign budget errors.
  /// </summary>
  public sealed partial class CampaignBudgetErrorEnum : pb::IMessage<CampaignBudgetErrorEnum> {
    private static readonly pb::MessageParser<CampaignBudgetErrorEnum> _parser = new pb::MessageParser<CampaignBudgetErrorEnum>(() => new CampaignBudgetErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CampaignBudgetErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Errors.CampaignBudgetErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignBudgetErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignBudgetErrorEnum(CampaignBudgetErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignBudgetErrorEnum Clone() {
      return new CampaignBudgetErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CampaignBudgetErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CampaignBudgetErrorEnum other) {
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
    public void MergeFrom(CampaignBudgetErrorEnum other) {
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
    /// <summary>Container for nested types declared in the CampaignBudgetErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible campaign budget errors.
      /// </summary>
      public enum CampaignBudgetError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The campaign budget cannot be shared.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_CANNOT_BE_SHARED")] CampaignBudgetCannotBeShared = 17,
        /// <summary>
        /// The requested campaign budget no longer exists.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_REMOVED")] CampaignBudgetRemoved = 2,
        /// <summary>
        /// The campaign budget is associated with at least one campaign, and so the
        /// campaign budget cannot be removed.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_IN_USE")] CampaignBudgetInUse = 3,
        /// <summary>
        /// Customer is not whitelisted for this campaign budget period.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_PERIOD_NOT_AVAILABLE")] CampaignBudgetPeriodNotAvailable = 4,
        /// <summary>
        /// This field is not mutable on implicitly shared campaign budgets
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_FIELD_OF_IMPLICITLY_SHARED_CAMPAIGN_BUDGET")] CannotModifyFieldOfImplicitlySharedCampaignBudget = 6,
        /// <summary>
        /// Cannot change explicitly shared campaign budgets back to implicitly
        /// shared ones.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_CAMPAIGN_BUDGET_TO_IMPLICITLY_SHARED")] CannotUpdateCampaignBudgetToImplicitlyShared = 7,
        /// <summary>
        /// An implicit campaign budget without a name cannot be changed to
        /// explicitly shared campaign budget.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_CAMPAIGN_BUDGET_TO_EXPLICITLY_SHARED_WITHOUT_NAME")] CannotUpdateCampaignBudgetToExplicitlySharedWithoutName = 8,
        /// <summary>
        /// Cannot change an implicitly shared campaign budget to an explicitly
        /// shared one.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_CAMPAIGN_BUDGET_TO_EXPLICITLY_SHARED")] CannotUpdateCampaignBudgetToExplicitlyShared = 9,
        /// <summary>
        /// Only explicitly shared campaign budgets can be used with multiple
        /// campaigns.
        /// </summary>
        [pbr::OriginalName("CANNOT_USE_IMPLICITLY_SHARED_CAMPAIGN_BUDGET_WITH_MULTIPLE_CAMPAIGNS")] CannotUseImplicitlySharedCampaignBudgetWithMultipleCampaigns = 10,
        /// <summary>
        /// A campaign budget with this name already exists.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_NAME")] DuplicateName = 11,
        /// <summary>
        /// A money amount was not in the expected currency.
        /// </summary>
        [pbr::OriginalName("MONEY_AMOUNT_IN_WRONG_CURRENCY")] MoneyAmountInWrongCurrency = 12,
        /// <summary>
        /// A money amount was less than the minimum CPC for currency.
        /// </summary>
        [pbr::OriginalName("MONEY_AMOUNT_LESS_THAN_CURRENCY_MINIMUM_CPC")] MoneyAmountLessThanCurrencyMinimumCpc = 13,
        /// <summary>
        /// A money amount was greater than the maximum allowed.
        /// </summary>
        [pbr::OriginalName("MONEY_AMOUNT_TOO_LARGE")] MoneyAmountTooLarge = 14,
        /// <summary>
        /// A money amount was negative.
        /// </summary>
        [pbr::OriginalName("NEGATIVE_MONEY_AMOUNT")] NegativeMoneyAmount = 15,
        /// <summary>
        /// A money amount was not a multiple of a minimum unit.
        /// </summary>
        [pbr::OriginalName("NON_MULTIPLE_OF_MINIMUM_CURRENCY_UNIT")] NonMultipleOfMinimumCurrencyUnit = 16,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
