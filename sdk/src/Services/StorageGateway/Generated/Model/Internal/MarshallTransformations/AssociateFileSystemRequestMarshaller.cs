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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.StorageGateway.Model;
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
namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssociateFileSystem Request Marshaller
    /// </summary>       
    public class AssociateFileSystemRequestMarshaller : IMarshaller<IRequest, AssociateFileSystemRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssociateFileSystemRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AssociateFileSystemRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.StorageGateway");
            string target = "StorageGateway_20130630.AssociateFileSystem";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-06-30";
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
            if(publicRequest.IsSetAuditDestinationARN())
            {
                context.Writer.WritePropertyName("AuditDestinationARN");
                context.Writer.WriteStringValue(publicRequest.AuditDestinationARN);
            }

            if(publicRequest.IsSetCacheAttributes())
            {
                context.Writer.WritePropertyName("CacheAttributes");
                context.Writer.WriteStartObject();

                var marshaller = CacheAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.CacheAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            if(publicRequest.IsSetEndpointNetworkConfiguration())
            {
                context.Writer.WritePropertyName("EndpointNetworkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EndpointNetworkConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.EndpointNetworkConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetGatewayARN())
            {
                context.Writer.WritePropertyName("GatewayARN");
                context.Writer.WriteStringValue(publicRequest.GatewayARN);
            }

            if(publicRequest.IsSetLocationARN())
            {
                context.Writer.WritePropertyName("LocationARN");
                context.Writer.WriteStringValue(publicRequest.LocationARN);
            }

            if(publicRequest.IsSetPassword())
            {
                context.Writer.WritePropertyName("Password");
                context.Writer.WriteStringValue(publicRequest.Password);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetUserName())
            {
                context.Writer.WritePropertyName("UserName");
                context.Writer.WriteStringValue(publicRequest.UserName);
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
        private static AssociateFileSystemRequestMarshaller _instance = new AssociateFileSystemRequestMarshaller();        

        internal static AssociateFileSystemRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssociateFileSystemRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}