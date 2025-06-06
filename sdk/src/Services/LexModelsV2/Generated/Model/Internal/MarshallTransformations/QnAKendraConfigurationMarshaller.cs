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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QnAKendraConfiguration Marshaller
    /// </summary>
    public class QnAKendraConfigurationMarshaller : IRequestMarshaller<QnAKendraConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(QnAKendraConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetExactResponse())
            {
                context.Writer.WritePropertyName("exactResponse");
                context.Writer.WriteBooleanValue(requestObject.ExactResponse.Value);
            }

            if(requestObject.IsSetKendraIndex())
            {
                context.Writer.WritePropertyName("kendraIndex");
                context.Writer.WriteStringValue(requestObject.KendraIndex);
            }

            if(requestObject.IsSetQueryFilterString())
            {
                context.Writer.WritePropertyName("queryFilterString");
                context.Writer.WriteStringValue(requestObject.QueryFilterString);
            }

            if(requestObject.IsSetQueryFilterStringEnabled())
            {
                context.Writer.WritePropertyName("queryFilterStringEnabled");
                context.Writer.WriteBooleanValue(requestObject.QueryFilterStringEnabled.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static QnAKendraConfigurationMarshaller Instance = new QnAKendraConfigurationMarshaller();

    }
}