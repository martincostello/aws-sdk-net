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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Outposts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Address Marshaller
    /// </summary>
    public class AddressMarshaller : IRequestMarshaller<Address, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Address requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddressLine1())
            {
                context.Writer.WritePropertyName("AddressLine1");
                context.Writer.WriteStringValue(requestObject.AddressLine1);
            }

            if(requestObject.IsSetAddressLine2())
            {
                context.Writer.WritePropertyName("AddressLine2");
                context.Writer.WriteStringValue(requestObject.AddressLine2);
            }

            if(requestObject.IsSetAddressLine3())
            {
                context.Writer.WritePropertyName("AddressLine3");
                context.Writer.WriteStringValue(requestObject.AddressLine3);
            }

            if(requestObject.IsSetCity())
            {
                context.Writer.WritePropertyName("City");
                context.Writer.WriteStringValue(requestObject.City);
            }

            if(requestObject.IsSetContactName())
            {
                context.Writer.WritePropertyName("ContactName");
                context.Writer.WriteStringValue(requestObject.ContactName);
            }

            if(requestObject.IsSetContactPhoneNumber())
            {
                context.Writer.WritePropertyName("ContactPhoneNumber");
                context.Writer.WriteStringValue(requestObject.ContactPhoneNumber);
            }

            if(requestObject.IsSetCountryCode())
            {
                context.Writer.WritePropertyName("CountryCode");
                context.Writer.WriteStringValue(requestObject.CountryCode);
            }

            if(requestObject.IsSetDistrictOrCounty())
            {
                context.Writer.WritePropertyName("DistrictOrCounty");
                context.Writer.WriteStringValue(requestObject.DistrictOrCounty);
            }

            if(requestObject.IsSetMunicipality())
            {
                context.Writer.WritePropertyName("Municipality");
                context.Writer.WriteStringValue(requestObject.Municipality);
            }

            if(requestObject.IsSetPostalCode())
            {
                context.Writer.WritePropertyName("PostalCode");
                context.Writer.WriteStringValue(requestObject.PostalCode);
            }

            if(requestObject.IsSetStateOrRegion())
            {
                context.Writer.WritePropertyName("StateOrRegion");
                context.Writer.WriteStringValue(requestObject.StateOrRegion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AddressMarshaller Instance = new AddressMarshaller();

    }
}