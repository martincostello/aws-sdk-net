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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExpectedAttributeValue Marshaller
    /// </summary>
    public class ExpectedAttributeValueMarshaller : IRequestMarshaller<ExpectedAttributeValue, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ExpectedAttributeValue requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttributeValueList())
            {
                context.Writer.WritePropertyName("AttributeValueList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAttributeValueListListValue in requestObject.AttributeValueList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AttributeValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttributeValueListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetComparisonOperator())
            {
                context.Writer.WritePropertyName("ComparisonOperator");
                context.Writer.WriteStringValue(requestObject.ComparisonOperator);
            }

            if(requestObject.IsSetExists())
            {
                context.Writer.WritePropertyName("Exists");
                context.Writer.WriteBooleanValue(requestObject.Exists.Value);
            }

            if(requestObject.IsSetValue())
            {
                context.Writer.WritePropertyName("Value");
                context.Writer.WriteStartObject();

                var marshaller = AttributeValueMarshaller.Instance;
                marshaller.Marshall(requestObject.Value, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExpectedAttributeValueMarshaller Instance = new ExpectedAttributeValueMarshaller();

    }
}