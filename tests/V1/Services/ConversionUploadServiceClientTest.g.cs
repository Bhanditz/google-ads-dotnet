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

namespace Google.Ads.GoogleAds.V1.Services.Tests
{
    using apis = Google.Ads.GoogleAds.V1.Services;
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using NUnit.Framework;

    /// <summary>Generated unit tests</summary>
    public class GeneratedConversionUploadServiceClientTest
    {
        [Test]
        public void UploadClickConversions()
        {
            Mock<ConversionUploadService.ConversionUploadServiceClient> mockGrpcClient = new Mock<ConversionUploadService.ConversionUploadServiceClient>(MockBehavior.Strict);
            UploadClickConversionsRequest expectedRequest = new UploadClickConversionsRequest
            {
                CustomerId = "customerId-1772061412",
                Conversions = { },
                PartialFailure = true,
            };
            UploadClickConversionsResponse expectedResponse = new UploadClickConversionsResponse();
            mockGrpcClient.Setup(x => x.UploadClickConversions(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConversionUploadServiceClient client = new ConversionUploadServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<ClickConversion> conversions = new List<ClickConversion>();
            bool partialFailure = true;
            UploadClickConversionsResponse response = client.UploadClickConversions(customerId, conversions, partialFailure);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task UploadClickConversionsAsync()
        {
            Mock<ConversionUploadService.ConversionUploadServiceClient> mockGrpcClient = new Mock<ConversionUploadService.ConversionUploadServiceClient>(MockBehavior.Strict);
            UploadClickConversionsRequest expectedRequest = new UploadClickConversionsRequest
            {
                CustomerId = "customerId-1772061412",
                Conversions = { },
                PartialFailure = true,
            };
            UploadClickConversionsResponse expectedResponse = new UploadClickConversionsResponse();
            mockGrpcClient.Setup(x => x.UploadClickConversionsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UploadClickConversionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ConversionUploadServiceClient client = new ConversionUploadServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<ClickConversion> conversions = new List<ClickConversion>();
            bool partialFailure = true;
            UploadClickConversionsResponse response = await client.UploadClickConversionsAsync(customerId, conversions, partialFailure);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void UploadClickConversions2()
        {
            Mock<ConversionUploadService.ConversionUploadServiceClient> mockGrpcClient = new Mock<ConversionUploadService.ConversionUploadServiceClient>(MockBehavior.Strict);
            UploadClickConversionsRequest expectedRequest = new UploadClickConversionsRequest
            {
                CustomerId = "customerId-1772061412",
                Conversions = { },
            };
            UploadClickConversionsResponse expectedResponse = new UploadClickConversionsResponse();
            mockGrpcClient.Setup(x => x.UploadClickConversions(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConversionUploadServiceClient client = new ConversionUploadServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<ClickConversion> conversions = new List<ClickConversion>();
            UploadClickConversionsResponse response = client.UploadClickConversions(customerId, conversions);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task UploadClickConversionsAsync2()
        {
            Mock<ConversionUploadService.ConversionUploadServiceClient> mockGrpcClient = new Mock<ConversionUploadService.ConversionUploadServiceClient>(MockBehavior.Strict);
            UploadClickConversionsRequest expectedRequest = new UploadClickConversionsRequest
            {
                CustomerId = "customerId-1772061412",
                Conversions = { },
            };
            UploadClickConversionsResponse expectedResponse = new UploadClickConversionsResponse();
            mockGrpcClient.Setup(x => x.UploadClickConversionsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UploadClickConversionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ConversionUploadServiceClient client = new ConversionUploadServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<ClickConversion> conversions = new List<ClickConversion>();
            UploadClickConversionsResponse response = await client.UploadClickConversionsAsync(customerId, conversions);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void UploadClickConversions3()
        {
            Mock<ConversionUploadService.ConversionUploadServiceClient> mockGrpcClient = new Mock<ConversionUploadService.ConversionUploadServiceClient>(MockBehavior.Strict);
            UploadClickConversionsRequest request = new UploadClickConversionsRequest
            {
                CustomerId = "customerId-1772061412",
                Conversions = { },
            };
            UploadClickConversionsResponse expectedResponse = new UploadClickConversionsResponse();
            mockGrpcClient.Setup(x => x.UploadClickConversions(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConversionUploadServiceClient client = new ConversionUploadServiceClientImpl(mockGrpcClient.Object, null);
            UploadClickConversionsResponse response = client.UploadClickConversions(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task UploadClickConversionsAsync3()
        {
            Mock<ConversionUploadService.ConversionUploadServiceClient> mockGrpcClient = new Mock<ConversionUploadService.ConversionUploadServiceClient>(MockBehavior.Strict);
            UploadClickConversionsRequest request = new UploadClickConversionsRequest
            {
                CustomerId = "customerId-1772061412",
                Conversions = { },
            };
            UploadClickConversionsResponse expectedResponse = new UploadClickConversionsResponse();
            mockGrpcClient.Setup(x => x.UploadClickConversionsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UploadClickConversionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ConversionUploadServiceClient client = new ConversionUploadServiceClientImpl(mockGrpcClient.Object, null);
            UploadClickConversionsResponse response = await client.UploadClickConversionsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
