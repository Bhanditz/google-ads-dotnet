// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gagvr = Google.Ads.GoogleAds.V1.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V1.Services
{
    /// <summary>
    /// Settings for a <see cref="CustomerManagerLinkServiceClient"/>.
    /// </summary>
    public sealed partial class CustomerManagerLinkServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="CustomerManagerLinkServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="CustomerManagerLinkServiceSettings"/>.
        /// </returns>
        public static CustomerManagerLinkServiceSettings GetDefault() => new CustomerManagerLinkServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomerManagerLinkServiceSettings"/> object with default settings.
        /// </summary>
        public CustomerManagerLinkServiceSettings() { }

        private CustomerManagerLinkServiceSettings(CustomerManagerLinkServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCustomerManagerLinkSettings = existing.GetCustomerManagerLinkSettings;
            MutateCustomerManagerLinkSettings = existing.MutateCustomerManagerLinkSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerManagerLinkServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="CustomerManagerLinkServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="CustomerManagerLinkServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="CustomerManagerLinkServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="CustomerManagerLinkServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="CustomerManagerLinkServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="CustomerManagerLinkServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="CustomerManagerLinkServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="CustomerManagerLinkServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerManagerLinkServiceClient.GetCustomerManagerLink</c> and <c>CustomerManagerLinkServiceClient.GetCustomerManagerLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CustomerManagerLinkServiceClient.GetCustomerManagerLink</c> and
        /// <c>CustomerManagerLinkServiceClient.GetCustomerManagerLinkAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomerManagerLinkSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerManagerLinkServiceClient.MutateCustomerManagerLink</c> and <c>CustomerManagerLinkServiceClient.MutateCustomerManagerLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CustomerManagerLinkServiceClient.MutateCustomerManagerLink</c> and
        /// <c>CustomerManagerLinkServiceClient.MutateCustomerManagerLinkAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings MutateCustomerManagerLinkSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="CustomerManagerLinkServiceSettings"/> object.</returns>
        public CustomerManagerLinkServiceSettings Clone() => new CustomerManagerLinkServiceSettings(this);
    }

    /// <summary>
    /// CustomerManagerLinkService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class CustomerManagerLinkServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerManagerLinkService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default CustomerManagerLinkService scopes.
        /// </summary>
        /// <remarks>
        /// The default CustomerManagerLinkService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerManagerLinkServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V1.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// CustomerManagerLinkServiceClient client = await CustomerManagerLinkServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V1.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     CustomerManagerLinkServiceClient.DefaultEndpoint.Host, CustomerManagerLinkServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CustomerManagerLinkServiceClient client = CustomerManagerLinkServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CustomerManagerLinkServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="CustomerManagerLinkServiceClient"/>.</returns>
        public static async stt::Task<CustomerManagerLinkServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, CustomerManagerLinkServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="CustomerManagerLinkServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V1.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// CustomerManagerLinkServiceClient client = CustomerManagerLinkServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V1.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     CustomerManagerLinkServiceClient.DefaultEndpoint.Host, CustomerManagerLinkServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CustomerManagerLinkServiceClient client = CustomerManagerLinkServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CustomerManagerLinkServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerManagerLinkServiceClient"/>.</returns>
        public static CustomerManagerLinkServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, CustomerManagerLinkServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="CustomerManagerLinkServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CustomerManagerLinkServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerManagerLinkServiceClient"/>.</returns>
        public static CustomerManagerLinkServiceClient Create(grpccore::Channel channel, CustomerManagerLinkServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="CustomerManagerLinkServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CustomerManagerLinkServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerManagerLinkServiceClient"/>.</returns>
        public static CustomerManagerLinkServiceClient Create(grpccore::CallInvoker callInvoker, CustomerManagerLinkServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerManagerLinkService.CustomerManagerLinkServiceClient grpcClient = new CustomerManagerLinkService.CustomerManagerLinkServiceClient(callInvoker);
            return new CustomerManagerLinkServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, CustomerManagerLinkServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CustomerManagerLinkServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, CustomerManagerLinkServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CustomerManagerLinkServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC CustomerManagerLinkService client.
        /// </summary>
        public virtual CustomerManagerLinkService.CustomerManagerLinkServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the CustomerManagerLink to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CustomerManagerLink> GetCustomerManagerLinkAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetCustomerManagerLinkAsync(
                new GetCustomerManagerLinkRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the CustomerManagerLink to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CustomerManagerLink> GetCustomerManagerLinkAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetCustomerManagerLinkAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the CustomerManagerLink to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::CustomerManagerLink GetCustomerManagerLink(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetCustomerManagerLink(
                new GetCustomerManagerLinkRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CustomerManagerLink> GetCustomerManagerLinkAsync(
            GetCustomerManagerLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CustomerManagerLink> GetCustomerManagerLinkAsync(
            GetCustomerManagerLinkRequest request,
            st::CancellationToken cancellationToken) => GetCustomerManagerLinkAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::CustomerManagerLink GetCustomerManagerLink(
            GetCustomerManagerLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates or updates customer manager links. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose customer manager links are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual customer manager links.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCustomerManagerLinkResponse> MutateCustomerManagerLinkAsync(
            string customerId,
            scg::IEnumerable<CustomerManagerLinkOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCustomerManagerLinkAsync(
                new MutateCustomerManagerLinkRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates or updates customer manager links. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose customer manager links are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual customer manager links.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCustomerManagerLinkResponse> MutateCustomerManagerLinkAsync(
            string customerId,
            scg::IEnumerable<CustomerManagerLinkOperation> operations,
            st::CancellationToken cancellationToken) => MutateCustomerManagerLinkAsync(
                customerId,
                operations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates customer manager links. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose customer manager links are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual customer manager links.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateCustomerManagerLinkResponse MutateCustomerManagerLink(
            string customerId,
            scg::IEnumerable<CustomerManagerLinkOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCustomerManagerLink(
                new MutateCustomerManagerLinkRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates or updates customer manager links. Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCustomerManagerLinkResponse> MutateCustomerManagerLinkAsync(
            MutateCustomerManagerLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates or updates customer manager links. Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCustomerManagerLinkResponse> MutateCustomerManagerLinkAsync(
            MutateCustomerManagerLinkRequest request,
            st::CancellationToken cancellationToken) => MutateCustomerManagerLinkAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates customer manager links. Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateCustomerManagerLinkResponse MutateCustomerManagerLink(
            MutateCustomerManagerLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// CustomerManagerLinkService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class CustomerManagerLinkServiceClientImpl : CustomerManagerLinkServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCustomerManagerLinkRequest, gagvr::CustomerManagerLink> _callGetCustomerManagerLink;
        private readonly gaxgrpc::ApiCall<MutateCustomerManagerLinkRequest, MutateCustomerManagerLinkResponse> _callMutateCustomerManagerLink;

        /// <summary>
        /// Constructs a client wrapper for the CustomerManagerLinkService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CustomerManagerLinkServiceSettings"/> used within this client </param>
        public CustomerManagerLinkServiceClientImpl(CustomerManagerLinkService.CustomerManagerLinkServiceClient grpcClient, CustomerManagerLinkServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CustomerManagerLinkServiceSettings effectiveSettings = settings ?? CustomerManagerLinkServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCustomerManagerLink = clientHelper.BuildApiCall<GetCustomerManagerLinkRequest, gagvr::CustomerManagerLink>(
                GrpcClient.GetCustomerManagerLinkAsync, GrpcClient.GetCustomerManagerLink, effectiveSettings.GetCustomerManagerLinkSettings);
            _callMutateCustomerManagerLink = clientHelper.BuildApiCall<MutateCustomerManagerLinkRequest, MutateCustomerManagerLinkResponse>(
                GrpcClient.MutateCustomerManagerLinkAsync, GrpcClient.MutateCustomerManagerLink, effectiveSettings.MutateCustomerManagerLinkSettings);
            Modify_ApiCall(ref _callGetCustomerManagerLink);
            Modify_GetCustomerManagerLinkApiCall(ref _callGetCustomerManagerLink);
            Modify_ApiCall(ref _callMutateCustomerManagerLink);
            Modify_MutateCustomerManagerLinkApiCall(ref _callMutateCustomerManagerLink);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_GetCustomerManagerLinkApiCall(ref gaxgrpc::ApiCall<GetCustomerManagerLinkRequest, gagvr::CustomerManagerLink> call);
        partial void Modify_MutateCustomerManagerLinkApiCall(ref gaxgrpc::ApiCall<MutateCustomerManagerLinkRequest, MutateCustomerManagerLinkResponse> call);
        partial void OnConstruction(CustomerManagerLinkService.CustomerManagerLinkServiceClient grpcClient, CustomerManagerLinkServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC CustomerManagerLinkService client.
        /// </summary>
        public override CustomerManagerLinkService.CustomerManagerLinkServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetCustomerManagerLinkRequest(ref GetCustomerManagerLinkRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateCustomerManagerLinkRequest(ref MutateCustomerManagerLinkRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<gagvr::CustomerManagerLink> GetCustomerManagerLinkAsync(
            GetCustomerManagerLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerManagerLinkRequest(ref request, ref callSettings);
            return _callGetCustomerManagerLink.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override gagvr::CustomerManagerLink GetCustomerManagerLink(
            GetCustomerManagerLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerManagerLinkRequest(ref request, ref callSettings);
            return _callGetCustomerManagerLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or updates customer manager links. Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<MutateCustomerManagerLinkResponse> MutateCustomerManagerLinkAsync(
            MutateCustomerManagerLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerManagerLinkRequest(ref request, ref callSettings);
            return _callMutateCustomerManagerLink.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or updates customer manager links. Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override MutateCustomerManagerLinkResponse MutateCustomerManagerLink(
            MutateCustomerManagerLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerManagerLinkRequest(ref request, ref callSettings);
            return _callMutateCustomerManagerLink.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
