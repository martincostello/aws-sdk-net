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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PI.Model;
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
namespace Amazon.PI.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetPerformanceAnalysisReport Request Marshaller
    /// </summary>       
    public class GetPerformanceAnalysisReportRequestMarshaller : IMarshaller<IRequest, GetPerformanceAnalysisReportRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetPerformanceAnalysisReportRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetPerformanceAnalysisReportRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PI");
            string target = "PerformanceInsightsv20180227.GetPerformanceAnalysisReport";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-02-27";
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
            if(publicRequest.IsSetAcceptLanguage())
            {
                context.Writer.WritePropertyName("AcceptLanguage");
                context.Writer.WriteStringValue(publicRequest.AcceptLanguage);
            }

            if(publicRequest.IsSetAnalysisReportId())
            {
                context.Writer.WritePropertyName("AnalysisReportId");
                context.Writer.WriteStringValue(publicRequest.AnalysisReportId);
            }

            if(publicRequest.IsSetIdentifier())
            {
                context.Writer.WritePropertyName("Identifier");
                context.Writer.WriteStringValue(publicRequest.Identifier);
            }

            if(publicRequest.IsSetServiceType())
            {
                context.Writer.WritePropertyName("ServiceType");
                context.Writer.WriteStringValue(publicRequest.ServiceType);
            }

            if(publicRequest.IsSetTextFormat())
            {
                context.Writer.WritePropertyName("TextFormat");
                context.Writer.WriteStringValue(publicRequest.TextFormat);
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
        private static GetPerformanceAnalysisReportRequestMarshaller _instance = new GetPerformanceAnalysisReportRequestMarshaller();        

        internal static GetPerformanceAnalysisReportRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetPerformanceAnalysisReportRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}