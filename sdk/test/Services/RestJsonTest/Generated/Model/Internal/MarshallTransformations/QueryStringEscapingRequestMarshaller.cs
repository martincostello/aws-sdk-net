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
 * Do not modify this file. This file is generated from the rest-json-test-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestJsonTest.Model;
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
namespace Amazon.RestJsonTest.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QueryStringEscaping Request Marshaller
    /// </summary>       
    public class QueryStringEscapingRequestMarshaller : IMarshaller<IRequest, QueryStringEscapingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((QueryStringEscapingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(QueryStringEscapingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonTest");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-05-13";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetQueryString())
                request.Parameters.Add("String", StringUtils.FromString(publicRequest.QueryString));
            request.ResourcePath = "/path";
            request.UseQueryString = true;

            return request;
        }
        private static QueryStringEscapingRequestMarshaller _instance = new QueryStringEscapingRequestMarshaller();        

        internal static QueryStringEscapingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static QueryStringEscapingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}