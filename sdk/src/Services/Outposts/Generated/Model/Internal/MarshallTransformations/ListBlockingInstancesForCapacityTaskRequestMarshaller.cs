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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Outposts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListBlockingInstancesForCapacityTask Request Marshaller
    /// </summary>       
    public class ListBlockingInstancesForCapacityTaskRequestMarshaller : IMarshaller<IRequest, ListBlockingInstancesForCapacityTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListBlockingInstancesForCapacityTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListBlockingInstancesForCapacityTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Outposts");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-03";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetCapacityTaskId())
                throw new AmazonOutpostsException("Request object does not have required field CapacityTaskId set");
            request.AddPathResource("{CapacityTaskId}", StringUtils.FromString(publicRequest.CapacityTaskId));
            if (!publicRequest.IsSetOutpostIdentifier())
                throw new AmazonOutpostsException("Request object does not have required field OutpostIdentifier set");
            request.AddPathResource("{OutpostId}", StringUtils.FromString(publicRequest.OutpostIdentifier));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/outposts/{OutpostId}/capacity/{CapacityTaskId}/blockingInstances";
            request.UseQueryString = true;

            return request;
        }
        private static ListBlockingInstancesForCapacityTaskRequestMarshaller _instance = new ListBlockingInstancesForCapacityTaskRequestMarshaller();        

        internal static ListBlockingInstancesForCapacityTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListBlockingInstancesForCapacityTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}