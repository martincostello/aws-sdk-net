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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApiGatewayV2.Model;
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
namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateApi Request Marshaller
    /// </summary>       
    public class CreateApiRequestMarshaller : IMarshaller<IRequest, CreateApiRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateApiRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateApiRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-29";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v2/apis";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetApiKeySelectionExpression())
            {
                context.Writer.WritePropertyName("apiKeySelectionExpression");
                context.Writer.WriteStringValue(publicRequest.ApiKeySelectionExpression);
            }

            if(publicRequest.IsSetCorsConfiguration())
            {
                context.Writer.WritePropertyName("corsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CorsMarshaller.Instance;
                marshaller.Marshall(publicRequest.CorsConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCredentialsArn())
            {
                context.Writer.WritePropertyName("credentialsArn");
                context.Writer.WriteStringValue(publicRequest.CredentialsArn);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDisableExecuteApiEndpoint())
            {
                context.Writer.WritePropertyName("disableExecuteApiEndpoint");
                context.Writer.WriteBooleanValue(publicRequest.DisableExecuteApiEndpoint.Value);
            }

            if(publicRequest.IsSetDisableSchemaValidation())
            {
                context.Writer.WritePropertyName("disableSchemaValidation");
                context.Writer.WriteBooleanValue(publicRequest.DisableSchemaValidation.Value);
            }

            if(publicRequest.IsSetIpAddressType())
            {
                context.Writer.WritePropertyName("ipAddressType");
                context.Writer.WriteStringValue(publicRequest.IpAddressType);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetProtocolType())
            {
                context.Writer.WritePropertyName("protocolType");
                context.Writer.WriteStringValue(publicRequest.ProtocolType);
            }

            if(publicRequest.IsSetRouteKey())
            {
                context.Writer.WritePropertyName("routeKey");
                context.Writer.WriteStringValue(publicRequest.RouteKey);
            }

            if(publicRequest.IsSetRouteSelectionExpression())
            {
                context.Writer.WritePropertyName("routeSelectionExpression");
                context.Writer.WriteStringValue(publicRequest.RouteSelectionExpression);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTarget())
            {
                context.Writer.WritePropertyName("target");
                context.Writer.WriteStringValue(publicRequest.Target);
            }

            if(publicRequest.IsSetVersion())
            {
                context.Writer.WritePropertyName("version");
                context.Writer.WriteStringValue(publicRequest.Version);
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
        private static CreateApiRequestMarshaller _instance = new CreateApiRequestMarshaller();        

        internal static CreateApiRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateApiRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}