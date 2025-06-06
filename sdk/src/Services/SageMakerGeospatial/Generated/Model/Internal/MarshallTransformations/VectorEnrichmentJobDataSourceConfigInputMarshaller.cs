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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMakerGeospatial.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMakerGeospatial.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VectorEnrichmentJobDataSourceConfigInput Marshaller
    /// </summary>
    public class VectorEnrichmentJobDataSourceConfigInputMarshaller : IRequestMarshaller<VectorEnrichmentJobDataSourceConfigInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VectorEnrichmentJobDataSourceConfigInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetS3Data())
            {
                context.Writer.WritePropertyName("S3Data");
                context.Writer.WriteStartObject();

                var marshaller = VectorEnrichmentJobS3DataMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Data, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VectorEnrichmentJobDataSourceConfigInputMarshaller Instance = new VectorEnrichmentJobDataSourceConfigInputMarshaller();

    }
}