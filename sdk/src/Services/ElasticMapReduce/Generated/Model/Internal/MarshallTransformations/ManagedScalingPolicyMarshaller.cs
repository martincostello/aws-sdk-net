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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ManagedScalingPolicy Marshaller
    /// </summary>
    public class ManagedScalingPolicyMarshaller : IRequestMarshaller<ManagedScalingPolicy, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ManagedScalingPolicy requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComputeLimits())
            {
                context.Writer.WritePropertyName("ComputeLimits");
                context.Writer.WriteStartObject();

                var marshaller = ComputeLimitsMarshaller.Instance;
                marshaller.Marshall(requestObject.ComputeLimits, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScalingStrategy())
            {
                context.Writer.WritePropertyName("ScalingStrategy");
                context.Writer.WriteStringValue(requestObject.ScalingStrategy);
            }

            if(requestObject.IsSetUtilizationPerformanceIndex())
            {
                context.Writer.WritePropertyName("UtilizationPerformanceIndex");
                context.Writer.WriteNumberValue(requestObject.UtilizationPerformanceIndex.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ManagedScalingPolicyMarshaller Instance = new ManagedScalingPolicyMarshaller();

    }
}