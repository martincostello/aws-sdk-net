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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RoboMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RoboMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Compute Marshaller
    /// </summary>
    public class ComputeMarshaller : IRequestMarshaller<Compute, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Compute requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComputeType())
            {
                context.Writer.WritePropertyName("computeType");
                context.Writer.WriteStringValue(requestObject.ComputeType);
            }

            if(requestObject.IsSetGpuUnitLimit())
            {
                context.Writer.WritePropertyName("gpuUnitLimit");
                context.Writer.WriteNumberValue(requestObject.GpuUnitLimit.Value);
            }

            if(requestObject.IsSetSimulationUnitLimit())
            {
                context.Writer.WritePropertyName("simulationUnitLimit");
                context.Writer.WriteNumberValue(requestObject.SimulationUnitLimit.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ComputeMarshaller Instance = new ComputeMarshaller();

    }
}