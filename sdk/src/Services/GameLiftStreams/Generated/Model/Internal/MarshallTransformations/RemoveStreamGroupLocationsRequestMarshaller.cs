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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLiftStreams.Model;
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
namespace Amazon.GameLiftStreams.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RemoveStreamGroupLocations Request Marshaller
    /// </summary>       
    public class RemoveStreamGroupLocationsRequestMarshaller : IMarshaller<IRequest, RemoveStreamGroupLocationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RemoveStreamGroupLocationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RemoveStreamGroupLocationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLiftStreams");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetIdentifier())
                throw new AmazonGameLiftStreamsException("Request object does not have required field Identifier set");
            request.AddPathResource("{Identifier}", StringUtils.FromString(publicRequest.Identifier));
            
            if (publicRequest.IsSetLocations())
                request.ParameterCollection.Add("locations", publicRequest.Locations);
            request.ResourcePath = "/streamgroups/{Identifier}/locations";
            request.UseQueryString = true;

            return request;
        }
        private static RemoveStreamGroupLocationsRequestMarshaller _instance = new RemoveStreamGroupLocationsRequestMarshaller();        

        internal static RemoveStreamGroupLocationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RemoveStreamGroupLocationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}