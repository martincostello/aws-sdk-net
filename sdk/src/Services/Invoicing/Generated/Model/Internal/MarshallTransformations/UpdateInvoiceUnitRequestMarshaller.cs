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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Invoicing.Model;
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
namespace Amazon.Invoicing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateInvoiceUnit Request Marshaller
    /// </summary>       
    public class UpdateInvoiceUnitRequestMarshaller : IMarshaller<IRequest, UpdateInvoiceUnitRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateInvoiceUnitRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateInvoiceUnitRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Invoicing");
            string target = "Invoicing.UpdateInvoiceUnit";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-12-01";
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
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetInvoiceUnitArn())
            {
                context.Writer.WritePropertyName("InvoiceUnitArn");
                context.Writer.WriteStringValue(publicRequest.InvoiceUnitArn);
            }

            if(publicRequest.IsSetRule())
            {
                context.Writer.WritePropertyName("Rule");
                context.Writer.WriteStartObject();

                var marshaller = InvoiceUnitRuleMarshaller.Instance;
                marshaller.Marshall(publicRequest.Rule, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTaxInheritanceDisabled())
            {
                context.Writer.WritePropertyName("TaxInheritanceDisabled");
                context.Writer.WriteBooleanValue(publicRequest.TaxInheritanceDisabled.Value);
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
        private static UpdateInvoiceUnitRequestMarshaller _instance = new UpdateInvoiceUnitRequestMarshaller();        

        internal static UpdateInvoiceUnitRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateInvoiceUnitRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}