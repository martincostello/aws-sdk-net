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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Drs.Model;
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
namespace Amazon.Drs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutLaunchAction Request Marshaller
    /// </summary>       
    public class PutLaunchActionRequestMarshaller : IMarshaller<IRequest, PutLaunchActionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutLaunchActionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutLaunchActionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Drs");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-02-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/PutLaunchAction";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetActionCode())
            {
                context.Writer.WritePropertyName("actionCode");
                context.Writer.WriteStringValue(publicRequest.ActionCode);
            }

            if(publicRequest.IsSetActionId())
            {
                context.Writer.WritePropertyName("actionId");
                context.Writer.WriteStringValue(publicRequest.ActionId);
            }

            if(publicRequest.IsSetActionVersion())
            {
                context.Writer.WritePropertyName("actionVersion");
                context.Writer.WriteStringValue(publicRequest.ActionVersion);
            }

            if(publicRequest.IsSetActive())
            {
                context.Writer.WritePropertyName("active");
                context.Writer.WriteBooleanValue(publicRequest.Active.Value);
            }

            if(publicRequest.IsSetCategory())
            {
                context.Writer.WritePropertyName("category");
                context.Writer.WriteStringValue(publicRequest.Category);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetOptional())
            {
                context.Writer.WritePropertyName("optional");
                context.Writer.WriteBooleanValue(publicRequest.Optional.Value);
            }

            if(publicRequest.IsSetOrder())
            {
                context.Writer.WritePropertyName("order");
                context.Writer.WriteNumberValue(publicRequest.Order.Value);
            }

            if(publicRequest.IsSetParameters())
            {
                context.Writer.WritePropertyName("parameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                {
                    context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                    var publicRequestParametersValue = publicRequestParametersKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = LaunchActionParameterMarshaller.Instance;
                    marshaller.Marshall(publicRequestParametersValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetResourceId())
            {
                context.Writer.WritePropertyName("resourceId");
                context.Writer.WriteStringValue(publicRequest.ResourceId);
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
        private static PutLaunchActionRequestMarshaller _instance = new PutLaunchActionRequestMarshaller();        

        internal static PutLaunchActionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutLaunchActionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}