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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CisScanResultDetailsFilterCriteria Marshaller
    /// </summary>
    public class CisScanResultDetailsFilterCriteriaMarshaller : IRequestMarshaller<CisScanResultDetailsFilterCriteria, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CisScanResultDetailsFilterCriteria requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCheckIdFilters())
            {
                context.Writer.WritePropertyName("checkIdFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCheckIdFiltersListValue in requestObject.CheckIdFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCheckIdFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFindingArnFilters())
            {
                context.Writer.WritePropertyName("findingArnFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFindingArnFiltersListValue in requestObject.FindingArnFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingArnFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFindingStatusFilters())
            {
                context.Writer.WritePropertyName("findingStatusFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFindingStatusFiltersListValue in requestObject.FindingStatusFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisFindingStatusFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingStatusFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSecurityLevelFilters())
            {
                context.Writer.WritePropertyName("securityLevelFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecurityLevelFiltersListValue in requestObject.SecurityLevelFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisSecurityLevelFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectSecurityLevelFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTitleFilters())
            {
                context.Writer.WritePropertyName("titleFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTitleFiltersListValue in requestObject.TitleFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTitleFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CisScanResultDetailsFilterCriteriaMarshaller Instance = new CisScanResultDetailsFilterCriteriaMarshaller();

    }
}