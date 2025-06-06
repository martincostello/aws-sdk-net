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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AcceleratorCapabilities Marshaller
    /// </summary>
    public class AcceleratorCapabilitiesMarshaller : IRequestMarshaller<AcceleratorCapabilities, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AcceleratorCapabilities requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCount())
            {
                context.Writer.WritePropertyName("count");
                context.Writer.WriteStartObject();

                var marshaller = AcceleratorCountRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.Count, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSelections())
            {
                context.Writer.WritePropertyName("selections");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSelectionsListValue in requestObject.Selections)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AcceleratorSelectionMarshaller.Instance;
                    marshaller.Marshall(requestObjectSelectionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AcceleratorCapabilitiesMarshaller Instance = new AcceleratorCapabilitiesMarshaller();

    }
}