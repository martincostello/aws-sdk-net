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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.VPCLattice.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.VPCLattice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ServiceNetworkEndpointAssociation Object
    /// </summary>  
    public class ServiceNetworkEndpointAssociationUnmarshaller : IJsonUnmarshaller<ServiceNetworkEndpointAssociation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ServiceNetworkEndpointAssociation Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ServiceNetworkEndpointAssociation unmarshalledObject = new ServiceNetworkEndpointAssociation();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceNetworkArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceNetworkArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("state", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("vpcEndpointId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcEndpointId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("vpcEndpointOwnerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcEndpointOwnerId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("vpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ServiceNetworkEndpointAssociationUnmarshaller _instance = new ServiceNetworkEndpointAssociationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServiceNetworkEndpointAssociationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}