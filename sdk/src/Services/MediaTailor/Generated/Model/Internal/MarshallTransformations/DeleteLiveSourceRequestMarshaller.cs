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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
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
namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteLiveSource Request Marshaller
    /// </summary>       
    public class DeleteLiveSourceRequestMarshaller : IMarshaller<IRequest, DeleteLiveSourceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteLiveSourceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteLiveSourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaTailor");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-23";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetLiveSourceName())
                throw new AmazonMediaTailorException("Request object does not have required field LiveSourceName set");
            request.AddPathResource("{LiveSourceName}", StringUtils.FromString(publicRequest.LiveSourceName));
            if (!publicRequest.IsSetSourceLocationName())
                throw new AmazonMediaTailorException("Request object does not have required field SourceLocationName set");
            request.AddPathResource("{SourceLocationName}", StringUtils.FromString(publicRequest.SourceLocationName));
            request.ResourcePath = "/sourceLocation/{SourceLocationName}/liveSource/{LiveSourceName}";

            return request;
        }
        private static DeleteLiveSourceRequestMarshaller _instance = new DeleteLiveSourceRequestMarshaller();        

        internal static DeleteLiveSourceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteLiveSourceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}