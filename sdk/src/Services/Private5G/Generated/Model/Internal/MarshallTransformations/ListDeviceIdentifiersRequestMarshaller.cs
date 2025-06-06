/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Private5G.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.Private5G.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListDeviceIdentifiers Request Marshaller
    /// </summary>       
    public class ListDeviceIdentifiersRequestMarshaller : IMarshaller<IRequest, ListDeviceIdentifiersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListDeviceIdentifiersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListDeviceIdentifiersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Private5G");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-12-03";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/device-identifiers/list";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetFilters())
            {
                context.Writer.WritePropertyName("filters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestFiltersKvp in publicRequest.Filters)
                {
                    context.Writer.WritePropertyName(publicRequestFiltersKvp.Key);
                    var publicRequestFiltersValue = publicRequestFiltersKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var publicRequestFiltersValueListValue in publicRequestFiltersValue)
                    {
                            context.Writer.WriteStringValue(publicRequestFiltersValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("maxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetNetworkArn())
            {
                context.Writer.WritePropertyName("networkArn");
                context.Writer.WriteStringValue(publicRequest.NetworkArn);
            }

            if(publicRequest.IsSetStartToken())
            {
                context.Writer.WritePropertyName("startToken");
                context.Writer.WriteStringValue(publicRequest.StartToken);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static ListDeviceIdentifiersRequestMarshaller _instance = new ListDeviceIdentifiersRequestMarshaller();        

        internal static ListDeviceIdentifiersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListDeviceIdentifiersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}