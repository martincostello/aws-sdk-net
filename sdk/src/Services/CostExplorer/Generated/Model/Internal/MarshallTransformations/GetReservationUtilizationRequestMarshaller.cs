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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
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
namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetReservationUtilization Request Marshaller
    /// </summary>       
    public class GetReservationUtilizationRequestMarshaller : IMarshaller<IRequest, GetReservationUtilizationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetReservationUtilizationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetReservationUtilizationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CostExplorer");
            string target = "AWSInsightsIndexService.GetReservationUtilization";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-25";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetFilter())
            {
                context.Writer.WritePropertyName("Filter");
                context.Writer.WriteStartObject();

                var marshaller = ExpressionMarshaller.Instance;
                marshaller.Marshall(publicRequest.Filter, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetGranularity())
            {
                context.Writer.WritePropertyName("Granularity");
                context.Writer.WriteStringValue(publicRequest.Granularity);
            }

            if(publicRequest.IsSetGroupBy())
            {
                context.Writer.WritePropertyName("GroupBy");
                context.Writer.WriteStartArray();
                foreach(var publicRequestGroupByListValue in publicRequest.GroupBy)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GroupDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequestGroupByListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetNextPageToken())
            {
                context.Writer.WritePropertyName("NextPageToken");
                context.Writer.WriteStringValue(publicRequest.NextPageToken);
            }

            if(publicRequest.IsSetSortBy())
            {
                context.Writer.WritePropertyName("SortBy");
                context.Writer.WriteStartObject();

                var marshaller = SortDefinitionMarshaller.Instance;
                marshaller.Marshall(publicRequest.SortBy, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTimePeriod())
            {
                context.Writer.WritePropertyName("TimePeriod");
                context.Writer.WriteStartObject();

                var marshaller = DateIntervalMarshaller.Instance;
                marshaller.Marshall(publicRequest.TimePeriod, context);

                context.Writer.WriteEndObject();
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
        private static GetReservationUtilizationRequestMarshaller _instance = new GetReservationUtilizationRequestMarshaller();        

        internal static GetReservationUtilizationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetReservationUtilizationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}