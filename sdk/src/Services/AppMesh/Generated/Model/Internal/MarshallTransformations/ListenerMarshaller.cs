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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppMesh.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AppMesh.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Listener Marshaller
    /// </summary>
    public class ListenerMarshaller : IRequestMarshaller<Listener, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Listener requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConnectionPool())
            {
                context.Writer.WritePropertyName("connectionPool");
                context.Writer.WriteStartObject();

                var marshaller = VirtualNodeConnectionPoolMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectionPool, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHealthCheck())
            {
                context.Writer.WritePropertyName("healthCheck");
                context.Writer.WriteStartObject();

                var marshaller = HealthCheckPolicyMarshaller.Instance;
                marshaller.Marshall(requestObject.HealthCheck, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOutlierDetection())
            {
                context.Writer.WritePropertyName("outlierDetection");
                context.Writer.WriteStartObject();

                var marshaller = OutlierDetectionMarshaller.Instance;
                marshaller.Marshall(requestObject.OutlierDetection, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPortMapping())
            {
                context.Writer.WritePropertyName("portMapping");
                context.Writer.WriteStartObject();

                var marshaller = PortMappingMarshaller.Instance;
                marshaller.Marshall(requestObject.PortMapping, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimeout())
            {
                context.Writer.WritePropertyName("timeout");
                context.Writer.WriteStartObject();

                var marshaller = ListenerTimeoutMarshaller.Instance;
                marshaller.Marshall(requestObject.Timeout, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTls())
            {
                context.Writer.WritePropertyName("tls");
                context.Writer.WriteStartObject();

                var marshaller = ListenerTlsMarshaller.Instance;
                marshaller.Marshall(requestObject.Tls, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ListenerMarshaller Instance = new ListenerMarshaller();

    }
}