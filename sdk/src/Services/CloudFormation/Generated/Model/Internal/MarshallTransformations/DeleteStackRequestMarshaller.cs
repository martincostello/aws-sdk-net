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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteStack Request Marshaller
    /// </summary>       
    public class DeleteStackRequestMarshaller : IMarshaller<IRequest, DeleteStackRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteStackRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteStackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.Parameters.Add("Action", "DeleteStack");
            request.Parameters.Add("Version", "2010-05-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientRequestToken())
                {
                    request.Parameters.Add("ClientRequestToken", StringUtils.FromString(publicRequest.ClientRequestToken));
                }
                if(publicRequest.IsSetDeletionMode())
                {
                    request.Parameters.Add("DeletionMode", StringUtils.FromString(publicRequest.DeletionMode));
                }
                if(publicRequest.IsSetRetainResources())
                {
                    if (publicRequest.RetainResources.Count == 0)
                        request.Parameters.Add("RetainResources", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.RetainResources)
                         {
                             request.Parameters.Add("RetainResources" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetRoleARN())
                {
                    request.Parameters.Add("RoleARN", StringUtils.FromString(publicRequest.RoleARN));
                }
                if(publicRequest.IsSetStackName())
                {
                    request.Parameters.Add("StackName", StringUtils.FromString(publicRequest.StackName));
                }
            }
            return request;
        }
                    private static DeleteStackRequestMarshaller _instance = new DeleteStackRequestMarshaller();        

        internal static DeleteStackRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteStackRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}