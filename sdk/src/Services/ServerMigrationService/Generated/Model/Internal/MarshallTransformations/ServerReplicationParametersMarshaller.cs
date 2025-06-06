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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServerMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ServerMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ServerReplicationParameters Marshaller
    /// </summary>
    public class ServerReplicationParametersMarshaller : IRequestMarshaller<ServerReplicationParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ServerReplicationParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEncrypted())
            {
                context.Writer.WritePropertyName("encrypted");
                context.Writer.WriteBooleanValue(requestObject.Encrypted.Value);
            }

            if(requestObject.IsSetFrequency())
            {
                context.Writer.WritePropertyName("frequency");
                context.Writer.WriteNumberValue(requestObject.Frequency.Value);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("kmsKeyId");
                context.Writer.WriteStringValue(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetLicenseType())
            {
                context.Writer.WritePropertyName("licenseType");
                context.Writer.WriteStringValue(requestObject.LicenseType);
            }

            if(requestObject.IsSetNumberOfRecentAmisToKeep())
            {
                context.Writer.WritePropertyName("numberOfRecentAmisToKeep");
                context.Writer.WriteNumberValue(requestObject.NumberOfRecentAmisToKeep.Value);
            }

            if(requestObject.IsSetRunOnce())
            {
                context.Writer.WritePropertyName("runOnce");
                context.Writer.WriteBooleanValue(requestObject.RunOnce.Value);
            }

            if(requestObject.IsSetSeedTime())
            {
                context.Writer.WritePropertyName("seedTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.SeedTime.Value)));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ServerReplicationParametersMarshaller Instance = new ServerReplicationParametersMarshaller();

    }
}