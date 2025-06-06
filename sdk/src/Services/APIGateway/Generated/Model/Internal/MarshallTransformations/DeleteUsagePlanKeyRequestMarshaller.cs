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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.APIGateway.Model;
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
namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteUsagePlanKey Request Marshaller
    /// </summary>       
    public class DeleteUsagePlanKeyRequestMarshaller : IMarshaller<IRequest, DeleteUsagePlanKeyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteUsagePlanKeyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteUsagePlanKeyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIGateway");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-07-09";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetKeyId())
                throw new AmazonAPIGatewayException("Request object does not have required field KeyId set");
            request.AddPathResource("{keyId}", StringUtils.FromString(publicRequest.KeyId));
            if (!publicRequest.IsSetUsagePlanId())
                throw new AmazonAPIGatewayException("Request object does not have required field UsagePlanId set");
            request.AddPathResource("{usageplanId}", StringUtils.FromString(publicRequest.UsagePlanId));
            request.ResourcePath = "/usageplans/{usageplanId}/keys/{keyId}";

            return request;
        }
        private static DeleteUsagePlanKeyRequestMarshaller _instance = new DeleteUsagePlanKeyRequestMarshaller();        

        internal static DeleteUsagePlanKeyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteUsagePlanKeyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}