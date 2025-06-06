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
    /// S3DataSource Marshaller
    /// </summary>
    public class S3DataSourceMarshaller : IRequestMarshaller<S3DataSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3DataSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttributeNames())
            {
                context.Writer.WritePropertyName("AttributeNames");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAttributeNamesListValue in requestObject.AttributeNames)
                {
                        context.Writer.WriteStringValue(requestObjectAttributeNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetHubAccessConfig())
            {
                context.Writer.WritePropertyName("HubAccessConfig");
                context.Writer.WriteStartObject();

                var marshaller = HubAccessConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.HubAccessConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInstanceGroupNames())
            {
                context.Writer.WritePropertyName("InstanceGroupNames");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInstanceGroupNamesListValue in requestObject.InstanceGroupNames)
                {
                        context.Writer.WriteStringValue(requestObjectInstanceGroupNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetModelAccessConfig())
            {
                context.Writer.WritePropertyName("ModelAccessConfig");
                context.Writer.WriteStartObject();

                var marshaller = ModelAccessConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ModelAccessConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3DataDistributionType())
            {
                context.Writer.WritePropertyName("S3DataDistributionType");
                context.Writer.WriteStringValue(requestObject.S3DataDistributionType);
            }

            if(requestObject.IsSetS3DataType())
            {
                context.Writer.WritePropertyName("S3DataType");
                context.Writer.WriteStringValue(requestObject.S3DataType);
            }

            if(requestObject.IsSetS3Uri())
            {
                context.Writer.WritePropertyName("S3Uri");
                context.Writer.WriteStringValue(requestObject.S3Uri);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3DataSourceMarshaller Instance = new S3DataSourceMarshaller();

    }
}