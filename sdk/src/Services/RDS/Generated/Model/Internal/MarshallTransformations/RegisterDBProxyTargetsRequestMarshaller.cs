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
    /// RegisterDBProxyTargets Request Marshaller
    /// </summary>       
    public class RegisterDBProxyTargetsRequestMarshaller : IMarshaller<IRequest, RegisterDBProxyTargetsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterDBProxyTargetsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterDBProxyTargetsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "RegisterDBProxyTargets");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDBClusterIdentifiers())
                {
                    if (publicRequest.DBClusterIdentifiers.Count == 0)
                        request.Parameters.Add("DBClusterIdentifiers", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.DBClusterIdentifiers)
                         {
                             request.Parameters.Add("DBClusterIdentifiers" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetDBInstanceIdentifiers())
                {
                    if (publicRequest.DBInstanceIdentifiers.Count == 0)
                        request.Parameters.Add("DBInstanceIdentifiers", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.DBInstanceIdentifiers)
                         {
                             request.Parameters.Add("DBInstanceIdentifiers" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetDBProxyName())
                {
                    request.Parameters.Add("DBProxyName", StringUtils.FromString(publicRequest.DBProxyName));
                }
                if(publicRequest.IsSetTargetGroupName())
                {
                    request.Parameters.Add("TargetGroupName", StringUtils.FromString(publicRequest.TargetGroupName));
                }
            }
            return request;
        }
                    private static RegisterDBProxyTargetsRequestMarshaller _instance = new RegisterDBProxyTargetsRequestMarshaller();        

        internal static RegisterDBProxyTargetsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterDBProxyTargetsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}