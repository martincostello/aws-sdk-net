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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataFormatConversionConfiguration Marshaller
    /// </summary>
    public class DataFormatConversionConfigurationMarshaller : IRequestMarshaller<DataFormatConversionConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataFormatConversionConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.WriteBooleanValue(requestObject.Enabled.Value);
            }

            if(requestObject.IsSetInputFormatConfiguration())
            {
                context.Writer.WritePropertyName("InputFormatConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = InputFormatConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.InputFormatConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOutputFormatConfiguration())
            {
                context.Writer.WritePropertyName("OutputFormatConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = OutputFormatConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputFormatConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSchemaConfiguration())
            {
                context.Writer.WritePropertyName("SchemaConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SchemaConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SchemaConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataFormatConversionConfigurationMarshaller Instance = new DataFormatConversionConfigurationMarshaller();

    }
}