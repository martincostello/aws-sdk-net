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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MWAA.Model;
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
namespace Amazon.MWAA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEnvironment Request Marshaller
    /// </summary>       
    public class CreateEnvironmentRequestMarshaller : IMarshaller<IRequest, CreateEnvironmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEnvironmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEnvironmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MWAA");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-01";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetName())
                throw new AmazonMWAAException("Request object does not have required field Name set");
            request.AddPathResource("{Name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/environments/{Name}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAirflowConfigurationOptions())
            {
                context.Writer.WritePropertyName("AirflowConfigurationOptions");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAirflowConfigurationOptionsKvp in publicRequest.AirflowConfigurationOptions)
                {
                    context.Writer.WritePropertyName(publicRequestAirflowConfigurationOptionsKvp.Key);
                    var publicRequestAirflowConfigurationOptionsValue = publicRequestAirflowConfigurationOptionsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestAirflowConfigurationOptionsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAirflowVersion())
            {
                context.Writer.WritePropertyName("AirflowVersion");
                context.Writer.WriteStringValue(publicRequest.AirflowVersion);
            }

            if(publicRequest.IsSetDagS3Path())
            {
                context.Writer.WritePropertyName("DagS3Path");
                context.Writer.WriteStringValue(publicRequest.DagS3Path);
            }

            if(publicRequest.IsSetEndpointManagement())
            {
                context.Writer.WritePropertyName("EndpointManagement");
                context.Writer.WriteStringValue(publicRequest.EndpointManagement);
            }

            if(publicRequest.IsSetEnvironmentClass())
            {
                context.Writer.WritePropertyName("EnvironmentClass");
                context.Writer.WriteStringValue(publicRequest.EnvironmentClass);
            }

            if(publicRequest.IsSetExecutionRoleArn())
            {
                context.Writer.WritePropertyName("ExecutionRoleArn");
                context.Writer.WriteStringValue(publicRequest.ExecutionRoleArn);
            }

            if(publicRequest.IsSetKmsKey())
            {
                context.Writer.WritePropertyName("KmsKey");
                context.Writer.WriteStringValue(publicRequest.KmsKey);
            }

            if(publicRequest.IsSetLoggingConfiguration())
            {
                context.Writer.WritePropertyName("LoggingConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = LoggingConfigurationInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.LoggingConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMaxWebservers())
            {
                context.Writer.WritePropertyName("MaxWebservers");
                context.Writer.WriteNumberValue(publicRequest.MaxWebservers.Value);
            }

            if(publicRequest.IsSetMaxWorkers())
            {
                context.Writer.WritePropertyName("MaxWorkers");
                context.Writer.WriteNumberValue(publicRequest.MaxWorkers.Value);
            }

            if(publicRequest.IsSetMinWebservers())
            {
                context.Writer.WritePropertyName("MinWebservers");
                context.Writer.WriteNumberValue(publicRequest.MinWebservers.Value);
            }

            if(publicRequest.IsSetMinWorkers())
            {
                context.Writer.WritePropertyName("MinWorkers");
                context.Writer.WriteNumberValue(publicRequest.MinWorkers.Value);
            }

            if(publicRequest.IsSetNetworkConfiguration())
            {
                context.Writer.WritePropertyName("NetworkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = NetworkConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.NetworkConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPluginsS3ObjectVersion())
            {
                context.Writer.WritePropertyName("PluginsS3ObjectVersion");
                context.Writer.WriteStringValue(publicRequest.PluginsS3ObjectVersion);
            }

            if(publicRequest.IsSetPluginsS3Path())
            {
                context.Writer.WritePropertyName("PluginsS3Path");
                context.Writer.WriteStringValue(publicRequest.PluginsS3Path);
            }

            if(publicRequest.IsSetRequirementsS3ObjectVersion())
            {
                context.Writer.WritePropertyName("RequirementsS3ObjectVersion");
                context.Writer.WriteStringValue(publicRequest.RequirementsS3ObjectVersion);
            }

            if(publicRequest.IsSetRequirementsS3Path())
            {
                context.Writer.WritePropertyName("RequirementsS3Path");
                context.Writer.WriteStringValue(publicRequest.RequirementsS3Path);
            }

            if(publicRequest.IsSetSchedulers())
            {
                context.Writer.WritePropertyName("Schedulers");
                context.Writer.WriteNumberValue(publicRequest.Schedulers.Value);
            }

            if(publicRequest.IsSetSourceBucketArn())
            {
                context.Writer.WritePropertyName("SourceBucketArn");
                context.Writer.WriteStringValue(publicRequest.SourceBucketArn);
            }

            if(publicRequest.IsSetStartupScriptS3ObjectVersion())
            {
                context.Writer.WritePropertyName("StartupScriptS3ObjectVersion");
                context.Writer.WriteStringValue(publicRequest.StartupScriptS3ObjectVersion);
            }

            if(publicRequest.IsSetStartupScriptS3Path())
            {
                context.Writer.WritePropertyName("StartupScriptS3Path");
                context.Writer.WriteStringValue(publicRequest.StartupScriptS3Path);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetWebserverAccessMode())
            {
                context.Writer.WritePropertyName("WebserverAccessMode");
                context.Writer.WriteStringValue(publicRequest.WebserverAccessMode);
            }

            if(publicRequest.IsSetWeeklyMaintenanceWindowStart())
            {
                context.Writer.WritePropertyName("WeeklyMaintenanceWindowStart");
                context.Writer.WriteStringValue(publicRequest.WeeklyMaintenanceWindowStart);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            
            request.HostPrefix = $"api.";

            return request;
        }
        private static CreateEnvironmentRequestMarshaller _instance = new CreateEnvironmentRequestMarshaller();        

        internal static CreateEnvironmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEnvironmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}