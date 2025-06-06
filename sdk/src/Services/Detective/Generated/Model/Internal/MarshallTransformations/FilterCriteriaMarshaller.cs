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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Detective.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Detective.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FilterCriteria Marshaller
    /// </summary>
    public class FilterCriteriaMarshaller : IRequestMarshaller<FilterCriteria, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FilterCriteria requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCreatedTime())
            {
                context.Writer.WritePropertyName("CreatedTime");
                context.Writer.WriteStartObject();

                var marshaller = DateFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.CreatedTime, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEntityArn())
            {
                context.Writer.WritePropertyName("EntityArn");
                context.Writer.WriteStartObject();

                var marshaller = StringFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.EntityArn, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSeverity())
            {
                context.Writer.WritePropertyName("Severity");
                context.Writer.WriteStartObject();

                var marshaller = StringFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Severity, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.WriteStartObject();

                var marshaller = StringFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.State, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStartObject();

                var marshaller = StringFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Status, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FilterCriteriaMarshaller Instance = new FilterCriteriaMarshaller();

    }
}