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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Snowball.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Snowball.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OnDeviceServiceConfiguration Marshaller
    /// </summary>
    public class OnDeviceServiceConfigurationMarshaller : IRequestMarshaller<OnDeviceServiceConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OnDeviceServiceConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEKSOnDeviceService())
            {
                context.Writer.WritePropertyName("EKSOnDeviceService");
                context.Writer.WriteStartObject();

                var marshaller = EKSOnDeviceServiceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.EKSOnDeviceService, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNFSOnDeviceService())
            {
                context.Writer.WritePropertyName("NFSOnDeviceService");
                context.Writer.WriteStartObject();

                var marshaller = NFSOnDeviceServiceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.NFSOnDeviceService, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3OnDeviceService())
            {
                context.Writer.WritePropertyName("S3OnDeviceService");
                context.Writer.WriteStartObject();

                var marshaller = S3OnDeviceServiceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3OnDeviceService, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTGWOnDeviceService())
            {
                context.Writer.WritePropertyName("TGWOnDeviceService");
                context.Writer.WriteStartObject();

                var marshaller = TGWOnDeviceServiceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.TGWOnDeviceService, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OnDeviceServiceConfigurationMarshaller Instance = new OnDeviceServiceConfigurationMarshaller();

    }
}