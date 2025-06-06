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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GlobalReplicationGroup Object
    /// </summary>  
    public class GlobalReplicationGroupUnmarshaller : IXmlUnmarshaller<GlobalReplicationGroup, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public GlobalReplicationGroup Unmarshall(XmlUnmarshallerContext context)
        {
            GlobalReplicationGroup unmarshalledObject = new GlobalReplicationGroup();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ARN", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ARN = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AtRestEncryptionEnabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.AtRestEncryptionEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AuthTokenEnabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.AuthTokenEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CacheNodeType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CacheNodeType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClusterEnabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.ClusterEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Engine", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Engine = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EngineVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("GlobalNodeGroups/GlobalNodeGroup", targetDepth))
                    {
                        var unmarshaller = GlobalNodeGroupUnmarshaller.Instance;
                        if (unmarshalledObject.GlobalNodeGroups == null)
                        {
                            unmarshalledObject.GlobalNodeGroups = new List<GlobalNodeGroup>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.GlobalNodeGroups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("GlobalReplicationGroupDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.GlobalReplicationGroupDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("GlobalReplicationGroupId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.GlobalReplicationGroupId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Members/GlobalReplicationGroupMember", targetDepth))
                    {
                        var unmarshaller = GlobalReplicationGroupMemberUnmarshaller.Instance;
                        if (unmarshalledObject.Members == null)
                        {
                            unmarshalledObject.Members = new List<GlobalReplicationGroupMember>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Members.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TransitEncryptionEnabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.TransitEncryptionEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        private static GlobalReplicationGroupUnmarshaller _instance = new GlobalReplicationGroupUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GlobalReplicationGroupUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}