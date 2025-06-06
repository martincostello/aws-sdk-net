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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DomainSettingsForUpdate Marshaller
    /// </summary>
    public class DomainSettingsForUpdateMarshaller : IRequestMarshaller<DomainSettingsForUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DomainSettingsForUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAmazonQSettings())
            {
                context.Writer.WritePropertyName("AmazonQSettings");
                context.Writer.WriteStartObject();

                var marshaller = AmazonQSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.AmazonQSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDockerSettings())
            {
                context.Writer.WritePropertyName("DockerSettings");
                context.Writer.WriteStartObject();

                var marshaller = DockerSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DockerSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExecutionRoleIdentityConfig())
            {
                context.Writer.WritePropertyName("ExecutionRoleIdentityConfig");
                context.Writer.WriteStringValue(requestObject.ExecutionRoleIdentityConfig);
            }

            if(requestObject.IsSetRStudioServerProDomainSettingsForUpdate())
            {
                context.Writer.WritePropertyName("RStudioServerProDomainSettingsForUpdate");
                context.Writer.WriteStartObject();

                var marshaller = RStudioServerProDomainSettingsForUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.RStudioServerProDomainSettingsForUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSecurityGroupIds())
            {
                context.Writer.WritePropertyName("SecurityGroupIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecurityGroupIdsListValue in requestObject.SecurityGroupIds)
                {
                        context.Writer.WriteStringValue(requestObjectSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DomainSettingsForUpdateMarshaller Instance = new DomainSettingsForUpdateMarshaller();

    }
}