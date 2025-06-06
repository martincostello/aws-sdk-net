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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudDirectory.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudDirectory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchListIndex Marshaller
    /// </summary>
    public class BatchListIndexMarshaller : IRequestMarshaller<BatchListIndex, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchListIndex requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetIndexReference())
            {
                context.Writer.WritePropertyName("IndexReference");
                context.Writer.WriteStartObject();

                var marshaller = ObjectReferenceMarshaller.Instance;
                marshaller.Marshall(requestObject.IndexReference, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(requestObject.MaxResults.Value);
            }

            if(requestObject.IsSetNextToken())
            {
                context.Writer.WritePropertyName("NextToken");
                context.Writer.WriteStringValue(requestObject.NextToken);
            }

            if(requestObject.IsSetRangesOnIndexedValues())
            {
                context.Writer.WritePropertyName("RangesOnIndexedValues");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRangesOnIndexedValuesListValue in requestObject.RangesOnIndexedValues)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ObjectAttributeRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectRangesOnIndexedValuesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchListIndexMarshaller Instance = new BatchListIndexMarshaller();

    }
}