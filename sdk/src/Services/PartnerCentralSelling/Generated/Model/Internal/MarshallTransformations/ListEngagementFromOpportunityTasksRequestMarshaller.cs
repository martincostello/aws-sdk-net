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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralSelling.Model;
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
namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListEngagementFromOpportunityTasks Request Marshaller
    /// </summary>       
    public class ListEngagementFromOpportunityTasksRequestMarshaller : IMarshaller<IRequest, ListEngagementFromOpportunityTasksRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListEngagementFromOpportunityTasksRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListEngagementFromOpportunityTasksRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralSelling");
            string target = "AWSPartnerCentralSelling.ListEngagementFromOpportunityTasks";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
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
            if(publicRequest.IsSetCatalog())
            {
                context.Writer.WritePropertyName("Catalog");
                context.Writer.WriteStringValue(publicRequest.Catalog);
            }

            if(publicRequest.IsSetEngagementIdentifier())
            {
                context.Writer.WritePropertyName("EngagementIdentifier");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEngagementIdentifierListValue in publicRequest.EngagementIdentifier)
                {
                        context.Writer.WriteStringValue(publicRequestEngagementIdentifierListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("NextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }

            if(publicRequest.IsSetOpportunityIdentifier())
            {
                context.Writer.WritePropertyName("OpportunityIdentifier");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOpportunityIdentifierListValue in publicRequest.OpportunityIdentifier)
                {
                        context.Writer.WriteStringValue(publicRequestOpportunityIdentifierListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSort())
            {
                context.Writer.WritePropertyName("Sort");
                context.Writer.WriteStartObject();

                var marshaller = ListTasksSortBaseMarshaller.Instance;
                marshaller.Marshall(publicRequest.Sort, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTaskIdentifier())
            {
                context.Writer.WritePropertyName("TaskIdentifier");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTaskIdentifierListValue in publicRequest.TaskIdentifier)
                {
                        context.Writer.WriteStringValue(publicRequestTaskIdentifierListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTaskStatus())
            {
                context.Writer.WritePropertyName("TaskStatus");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTaskStatusListValue in publicRequest.TaskStatus)
                {
                        context.Writer.WriteStringValue(publicRequestTaskStatusListValue);
                }
                context.Writer.WriteEndArray();
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
        private static ListEngagementFromOpportunityTasksRequestMarshaller _instance = new ListEngagementFromOpportunityTasksRequestMarshaller();        

        internal static ListEngagementFromOpportunityTasksRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListEngagementFromOpportunityTasksRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}