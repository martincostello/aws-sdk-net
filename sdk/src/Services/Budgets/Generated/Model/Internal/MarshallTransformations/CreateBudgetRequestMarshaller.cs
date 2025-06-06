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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Budgets.Model;
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
namespace Amazon.Budgets.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateBudget Request Marshaller
    /// </summary>       
    public class CreateBudgetRequestMarshaller : IMarshaller<IRequest, CreateBudgetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBudgetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateBudgetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Budgets");
            string target = "AWSBudgetServiceGateway.CreateBudget";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-10-20";
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
            if(publicRequest.IsSetAccountId())
            {
                context.Writer.WritePropertyName("AccountId");
                context.Writer.WriteStringValue(publicRequest.AccountId);
            }

            if(publicRequest.IsSetBudget())
            {
                context.Writer.WritePropertyName("Budget");
                context.Writer.WriteStartObject();

                var marshaller = BudgetMarshaller.Instance;
                marshaller.Marshall(publicRequest.Budget, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNotificationsWithSubscribers())
            {
                context.Writer.WritePropertyName("NotificationsWithSubscribers");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNotificationsWithSubscribersListValue in publicRequest.NotificationsWithSubscribers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NotificationWithSubscribersMarshaller.Instance;
                    marshaller.Marshall(publicRequestNotificationsWithSubscribersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetResourceTags())
            {
                context.Writer.WritePropertyName("ResourceTags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestResourceTagsListValue in publicRequest.ResourceTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourceTagMarshaller.Instance;
                    marshaller.Marshall(publicRequestResourceTagsListValue, context);

                    context.Writer.WriteEndObject();
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
        private static CreateBudgetRequestMarshaller _instance = new CreateBudgetRequestMarshaller();        

        internal static CreateBudgetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateBudgetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}