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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
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
namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetJourneyDateRangeKpi Request Marshaller
    /// </summary>       
    public class GetJourneyDateRangeKpiRequestMarshaller : IMarshaller<IRequest, GetJourneyDateRangeKpiRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetJourneyDateRangeKpiRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetJourneyDateRangeKpiRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Pinpoint");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonPinpointException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{application-id}", StringUtils.FromString(publicRequest.ApplicationId));
            if (!publicRequest.IsSetJourneyId())
                throw new AmazonPinpointException("Request object does not have required field JourneyId set");
            request.AddPathResource("{journey-id}", StringUtils.FromString(publicRequest.JourneyId));
            if (!publicRequest.IsSetKpiName())
                throw new AmazonPinpointException("Request object does not have required field KpiName set");
            request.AddPathResource("{kpi-name}", StringUtils.FromString(publicRequest.KpiName));
            
            if (publicRequest.IsSetEndTime())
                request.Parameters.Add("end-time", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("next-token", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetPageSize())
                request.Parameters.Add("page-size", StringUtils.FromString(publicRequest.PageSize));
            
            if (publicRequest.IsSetStartTime())
                request.Parameters.Add("start-time", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime));
            request.ResourcePath = "/v1/apps/{application-id}/journeys/{journey-id}/kpis/daterange/{kpi-name}";
            request.UseQueryString = true;

            return request;
        }
        private static GetJourneyDateRangeKpiRequestMarshaller _instance = new GetJourneyDateRangeKpiRequestMarshaller();        

        internal static GetJourneyDateRangeKpiRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetJourneyDateRangeKpiRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}