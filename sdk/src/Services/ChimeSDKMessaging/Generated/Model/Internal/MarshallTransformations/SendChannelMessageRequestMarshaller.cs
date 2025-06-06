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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMessaging.Model;
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
namespace Amazon.ChimeSDKMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendChannelMessage Request Marshaller
    /// </summary>       
    public class SendChannelMessageRequestMarshaller : IMarshaller<IRequest, SendChannelMessageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendChannelMessageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendChannelMessageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMessaging");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-05-15";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetChannelArn())
                throw new AmazonChimeSDKMessagingException("Request object does not have required field ChannelArn set");
            request.AddPathResource("{channelArn}", StringUtils.FromString(publicRequest.ChannelArn));
            request.ResourcePath = "/channels/{channelArn}/messages";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientRequestToken())
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(publicRequest.ClientRequestToken);
            }

            else if(!(publicRequest.IsSetClientRequestToken()))
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetContent())
            {
                context.Writer.WritePropertyName("Content");
                context.Writer.WriteStringValue(publicRequest.Content);
            }

            if(publicRequest.IsSetContentType())
            {
                context.Writer.WritePropertyName("ContentType");
                context.Writer.WriteStringValue(publicRequest.ContentType);
            }

            if(publicRequest.IsSetMessageAttributes())
            {
                context.Writer.WritePropertyName("MessageAttributes");
                context.Writer.WriteStartObject();
                foreach (var publicRequestMessageAttributesKvp in publicRequest.MessageAttributes)
                {
                    context.Writer.WritePropertyName(publicRequestMessageAttributesKvp.Key);
                    var publicRequestMessageAttributesValue = publicRequestMessageAttributesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = MessageAttributeValueMarshaller.Instance;
                    marshaller.Marshall(publicRequestMessageAttributesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMetadata())
            {
                context.Writer.WritePropertyName("Metadata");
                context.Writer.WriteStringValue(publicRequest.Metadata);
            }

            if(publicRequest.IsSetPersistence())
            {
                context.Writer.WritePropertyName("Persistence");
                context.Writer.WriteStringValue(publicRequest.Persistence);
            }

            if(publicRequest.IsSetPushNotification())
            {
                context.Writer.WritePropertyName("PushNotification");
                context.Writer.WriteStartObject();

                var marshaller = PushNotificationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.PushNotification, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSubChannelId())
            {
                context.Writer.WritePropertyName("SubChannelId");
                context.Writer.WriteStringValue(publicRequest.SubChannelId);
            }

            if(publicRequest.IsSetTarget())
            {
                context.Writer.WritePropertyName("Target");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTargetListValue in publicRequest.Target)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TargetMarshaller.Instance;
                    marshaller.Marshall(publicRequestTargetListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(publicRequest.Type);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

        
            if (publicRequest.IsSetChimeBearer()) 
            {
                request.Headers["x-amz-chime-bearer"] = publicRequest.ChimeBearer;
            }

            return request;
        }
        private static SendChannelMessageRequestMarshaller _instance = new SendChannelMessageRequestMarshaller();        

        internal static SendChannelMessageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendChannelMessageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}