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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeGuruProfiler.Model;
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
namespace Amazon.CodeGuruProfiler.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RemoveNotificationChannel Request Marshaller
    /// </summary>       
    public class RemoveNotificationChannelRequestMarshaller : IMarshaller<IRequest, RemoveNotificationChannelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RemoveNotificationChannelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RemoveNotificationChannelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeGuruProfiler");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-18";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetChannelId())
                throw new AmazonCodeGuruProfilerException("Request object does not have required field ChannelId set");
            request.AddPathResource("{channelId}", StringUtils.FromString(publicRequest.ChannelId));
            if (!publicRequest.IsSetProfilingGroupName())
                throw new AmazonCodeGuruProfilerException("Request object does not have required field ProfilingGroupName set");
            request.AddPathResource("{profilingGroupName}", StringUtils.FromString(publicRequest.ProfilingGroupName));
            request.ResourcePath = "/profilingGroups/{profilingGroupName}/notificationConfiguration/{channelId}";

            return request;
        }
        private static RemoveNotificationChannelRequestMarshaller _instance = new RemoveNotificationChannelRequestMarshaller();        

        internal static RemoveNotificationChannelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RemoveNotificationChannelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}