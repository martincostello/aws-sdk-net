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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationAutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationAutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PredictiveScalingMetricDataQuery Marshaller
    /// </summary>
    public class PredictiveScalingMetricDataQueryMarshaller : IRequestMarshaller<PredictiveScalingMetricDataQuery, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PredictiveScalingMetricDataQuery requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetExpression())
            {
                context.Writer.WritePropertyName("Expression");
                context.Writer.WriteStringValue(requestObject.Expression);
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetLabel())
            {
                context.Writer.WritePropertyName("Label");
                context.Writer.WriteStringValue(requestObject.Label);
            }

            if(requestObject.IsSetMetricStat())
            {
                context.Writer.WritePropertyName("MetricStat");
                context.Writer.WriteStartObject();

                var marshaller = PredictiveScalingMetricStatMarshaller.Instance;
                marshaller.Marshall(requestObject.MetricStat, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetReturnData())
            {
                context.Writer.WritePropertyName("ReturnData");
                context.Writer.WriteBooleanValue(requestObject.ReturnData.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PredictiveScalingMetricDataQueryMarshaller Instance = new PredictiveScalingMetricDataQueryMarshaller();

    }
}