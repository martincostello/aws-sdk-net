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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ClusterPendingModifiedValues Object
    /// </summary>  
    public class ClusterPendingModifiedValuesUnmarshaller : IXmlUnmarshaller<ClusterPendingModifiedValues, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ClusterPendingModifiedValues Unmarshall(XmlUnmarshallerContext context)
        {
            ClusterPendingModifiedValues unmarshalledObject = new ClusterPendingModifiedValues();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AllocatedStorage", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.AllocatedStorage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("BackupRetentionPeriod", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.BackupRetentionPeriod = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CertificateDetails", targetDepth))
                    {
                        var unmarshaller = CertificateDetailsUnmarshaller.Instance;
                        unmarshalledObject.CertificateDetails = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBClusterIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBClusterIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EngineVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IAMDatabaseAuthenticationEnabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.IAMDatabaseAuthenticationEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Iops", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Iops = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MasterUserPassword", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MasterUserPassword = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PendingCloudwatchLogsExports", targetDepth))
                    {
                        var unmarshaller = PendingCloudwatchLogsExportsUnmarshaller.Instance;
                        unmarshalledObject.PendingCloudwatchLogsExports = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RdsCustomClusterConfiguration", targetDepth))
                    {
                        var unmarshaller = RdsCustomClusterConfigurationUnmarshaller.Instance;
                        unmarshalledObject.RdsCustomClusterConfiguration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StorageType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StorageType = unmarshaller.Unmarshall(context);
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

        private static ClusterPendingModifiedValuesUnmarshaller _instance = new ClusterPendingModifiedValuesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ClusterPendingModifiedValuesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}