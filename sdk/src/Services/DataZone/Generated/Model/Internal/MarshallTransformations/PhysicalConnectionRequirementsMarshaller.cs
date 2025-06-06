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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PhysicalConnectionRequirements Marshaller
    /// </summary>
    public class PhysicalConnectionRequirementsMarshaller : IRequestMarshaller<PhysicalConnectionRequirements, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PhysicalConnectionRequirements requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("availabilityZone");
                context.Writer.WriteStringValue(requestObject.AvailabilityZone);
            }

            if(requestObject.IsSetSecurityGroupIdList())
            {
                context.Writer.WritePropertyName("securityGroupIdList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecurityGroupIdListListValue in requestObject.SecurityGroupIdList)
                {
                        context.Writer.WriteStringValue(requestObjectSecurityGroupIdListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSubnetId())
            {
                context.Writer.WritePropertyName("subnetId");
                context.Writer.WriteStringValue(requestObject.SubnetId);
            }

            if(requestObject.IsSetSubnetIdList())
            {
                context.Writer.WritePropertyName("subnetIdList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSubnetIdListListValue in requestObject.SubnetIdList)
                {
                        context.Writer.WriteStringValue(requestObjectSubnetIdListListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PhysicalConnectionRequirementsMarshaller Instance = new PhysicalConnectionRequirementsMarshaller();

    }
}