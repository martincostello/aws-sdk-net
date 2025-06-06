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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetAccessGrantsInstance operation
    /// </summary>  
    public class GetAccessGrantsInstanceResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            GetAccessGrantsInstanceResponse response = new GetAccessGrantsInstanceResponse();
            UnmarshallResult(context,response);
            
            return response;
        }        

        private static void UnmarshallResult(XmlUnmarshallerContext context, GetAccessGrantsInstanceResponse response)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
                   targetDepth += 1;
            if (context.IsEmptyResponse)
            {
                return;
            }
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AccessGrantsInstanceArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.AccessGrantsInstanceArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AccessGrantsInstanceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.AccessGrantsInstanceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CreatedAt", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        response.CreatedAt = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IdentityCenterApplicationArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.IdentityCenterApplicationArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IdentityCenterArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.IdentityCenterArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IdentityCenterInstanceArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.IdentityCenterInstanceArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }
          
            return;
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
            return new AmazonS3ControlException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static GetAccessGrantsInstanceResponseUnmarshaller _instance = new GetAccessGrantsInstanceResponseUnmarshaller();        

        internal static GetAccessGrantsInstanceResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetAccessGrantsInstanceResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}