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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestXmlProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HttpPrefixHeaders operation
    /// </summary>  
    public class HttpPrefixHeadersResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            HttpPrefixHeadersResponse response = new HttpPrefixHeadersResponse();
            if (context.ResponseData.IsHeaderPresent("x-foo"))
                response.Foo = context.ResponseData.GetHeaderValue("x-foo");
            //Map of headers with prefix "x-foo-".
            var headersForFooMap = new Dictionary<string, string>();
            foreach (var nameFooMap in context.ResponseData.GetHeaderNames())
            {
                var keyToUse = nameFooMap;
                if("x-foo-".Length > 0 && keyToUse.StartsWith("x-foo-")) {
                    keyToUse = keyToUse.Substring("x-foo-".Length);
                }

                if (context.ResponseData.IsHeaderPresent($"x-foo-{keyToUse}"))
                {
                    headersForFooMap.Add(
                        keyToUse,
                        context.ResponseData.GetHeaderValue($"x-foo-{keyToUse}")
                    );
                }
            }
            if(headersForFooMap.Count > 0)
                response.FooMap = headersForFooMap;
            
            return response;
        }        
  

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
            }
            return new AmazonRestXmlProtocolException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static HttpPrefixHeadersResponseUnmarshaller _instance = new HttpPrefixHeadersResponseUnmarshaller();        

        internal static HttpPrefixHeadersResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HttpPrefixHeadersResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}