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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppMesh.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.AppMesh.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VirtualNodeConnectionPool Object
    /// </summary>  
    public class VirtualNodeConnectionPoolUnmarshaller : IJsonUnmarshaller<VirtualNodeConnectionPool, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public VirtualNodeConnectionPool Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            VirtualNodeConnectionPool unmarshalledObject = new VirtualNodeConnectionPool();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("grpc", targetDepth))
                {
                    var unmarshaller = VirtualNodeGrpcConnectionPoolUnmarshaller.Instance;
                    unmarshalledObject.Grpc = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("http", targetDepth))
                {
                    var unmarshaller = VirtualNodeHttpConnectionPoolUnmarshaller.Instance;
                    unmarshalledObject.Http = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("http2", targetDepth))
                {
                    var unmarshaller = VirtualNodeHttp2ConnectionPoolUnmarshaller.Instance;
                    unmarshalledObject.Http2 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tcp", targetDepth))
                {
                    var unmarshaller = VirtualNodeTcpConnectionPoolUnmarshaller.Instance;
                    unmarshalledObject.Tcp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static VirtualNodeConnectionPoolUnmarshaller _instance = new VirtualNodeConnectionPoolUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VirtualNodeConnectionPoolUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}