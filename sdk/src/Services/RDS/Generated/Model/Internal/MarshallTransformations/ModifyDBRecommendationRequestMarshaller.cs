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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyDBRecommendation Request Marshaller
    /// </summary>       
    public class ModifyDBRecommendationRequestMarshaller : IMarshaller<IRequest, ModifyDBRecommendationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyDBRecommendationRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyDBRecommendationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "ModifyDBRecommendation");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetLocale())
                {
                    request.Parameters.Add("Locale", StringUtils.FromString(publicRequest.Locale));
                }
                if(publicRequest.IsSetRecommendationId())
                {
                    request.Parameters.Add("RecommendationId", StringUtils.FromString(publicRequest.RecommendationId));
                }
                if(publicRequest.IsSetRecommendedActionUpdates())
                {
                    if (publicRequest.RecommendedActionUpdates.Count == 0)
                        request.Parameters.Add("RecommendedActionUpdates", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.RecommendedActionUpdates)
                         {
                            if(publicRequestlistValue.IsSetActionId())
                            {
                                request.Parameters.Add("RecommendedActionUpdates" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ActionId", StringUtils.FromString(publicRequestlistValue.ActionId));
                            }
                            if(publicRequestlistValue.IsSetStatus())
                            {
                                request.Parameters.Add("RecommendedActionUpdates" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Status", StringUtils.FromString(publicRequestlistValue.Status));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetStatus())
                {
                    request.Parameters.Add("Status", StringUtils.FromString(publicRequest.Status));
                }
            }
            return request;
        }
                    private static ModifyDBRecommendationRequestMarshaller _instance = new ModifyDBRecommendationRequestMarshaller();        

        internal static ModifyDBRecommendationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyDBRecommendationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}