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
    /// ModifyCacheSubnetGroup Request Marshaller
    /// </summary>       
    public class ModifyCacheSubnetGroupRequestMarshaller : IMarshaller<IRequest, ModifyCacheSubnetGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyCacheSubnetGroupRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyCacheSubnetGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.Parameters.Add("Action", "ModifyCacheSubnetGroup");
            request.Parameters.Add("Version", "2015-02-02");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCacheSubnetGroupDescription())
                {
                    request.Parameters.Add("CacheSubnetGroupDescription", StringUtils.FromString(publicRequest.CacheSubnetGroupDescription));
                }
                if(publicRequest.IsSetCacheSubnetGroupName())
                {
                    request.Parameters.Add("CacheSubnetGroupName", StringUtils.FromString(publicRequest.CacheSubnetGroupName));
                }
                if(publicRequest.IsSetSubnetIds())
                {
                    if (publicRequest.SubnetIds.Count == 0)
                        request.Parameters.Add("SubnetIds", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.SubnetIds)
                         {
                             request.Parameters.Add("SubnetIds" + "." + "SubnetIdentifier" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static ModifyCacheSubnetGroupRequestMarshaller _instance = new ModifyCacheSubnetGroupRequestMarshaller();        

        internal static ModifyCacheSubnetGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyCacheSubnetGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}