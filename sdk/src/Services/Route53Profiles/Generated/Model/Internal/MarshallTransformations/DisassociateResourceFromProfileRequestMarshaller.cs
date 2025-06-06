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
 * Do not modify this file. This file is generated from the route53profiles-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53Profiles.Model;
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
namespace Amazon.Route53Profiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DisassociateResourceFromProfile Request Marshaller
    /// </summary>       
    public class DisassociateResourceFromProfileRequestMarshaller : IMarshaller<IRequest, DisassociateResourceFromProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DisassociateResourceFromProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DisassociateResourceFromProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53Profiles");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetProfileId())
                throw new AmazonRoute53ProfilesException("Request object does not have required field ProfileId set");
            request.AddPathResource("{ProfileId}", StringUtils.FromString(publicRequest.ProfileId));
            if (!publicRequest.IsSetResourceArn())
                throw new AmazonRoute53ProfilesException("Request object does not have required field ResourceArn set");
            request.AddPathResource("{ResourceArn}", StringUtils.FromString(publicRequest.ResourceArn));
            request.ResourcePath = "/profileresourceassociation/profileid/{ProfileId}/resourcearn/{ResourceArn}";

            return request;
        }
        private static DisassociateResourceFromProfileRequestMarshaller _instance = new DisassociateResourceFromProfileRequestMarshaller();        

        internal static DisassociateResourceFromProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DisassociateResourceFromProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}