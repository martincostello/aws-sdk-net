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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EMRServerlessWebService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.EMRServerlessWebService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartApplication Request Marshaller
    /// </summary>       
    public class StartApplicationRequestMarshaller : IMarshaller<IRequest, StartApplicationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartApplicationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EMRServerlessWebService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-13";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonEMRServerlessWebServiceException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            request.ResourcePath = "/applications/{applicationId}/start";

            return request;
        }
        private static StartApplicationRequestMarshaller _instance = new StartApplicationRequestMarshaller();        

        internal static StartApplicationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartApplicationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}