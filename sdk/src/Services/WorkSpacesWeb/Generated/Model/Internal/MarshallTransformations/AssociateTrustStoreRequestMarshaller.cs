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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpacesWeb.Model;
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
namespace Amazon.WorkSpacesWeb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssociateTrustStore Request Marshaller
    /// </summary>       
    public class AssociateTrustStoreRequestMarshaller : IMarshaller<IRequest, AssociateTrustStoreRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssociateTrustStoreRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AssociateTrustStoreRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpacesWeb");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-08";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetPortalArn())
                throw new AmazonWorkSpacesWebException("Request object does not have required field PortalArn set");
            request.AddPathResource("{portalArn+}", StringUtils.FromString(publicRequest.PortalArn.TrimStart('/')));
            
            if (publicRequest.IsSetTrustStoreArn())
                request.Parameters.Add("trustStoreArn", StringUtils.FromString(publicRequest.TrustStoreArn));
            request.ResourcePath = "/portals/{portalArn+}/trustStores";
            request.UseQueryString = true;

            return request;
        }
        private static AssociateTrustStoreRequestMarshaller _instance = new AssociateTrustStoreRequestMarshaller();        

        internal static AssociateTrustStoreRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssociateTrustStoreRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}