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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssetModelProperty Marshaller
    /// </summary>
    public class AssetModelPropertyMarshaller : IRequestMarshaller<AssetModelProperty, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AssetModelProperty requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataType())
            {
                context.Writer.WritePropertyName("dataType");
                context.Writer.WriteStringValue(requestObject.DataType);
            }

            if(requestObject.IsSetDataTypeSpec())
            {
                context.Writer.WritePropertyName("dataTypeSpec");
                context.Writer.WriteStringValue(requestObject.DataTypeSpec);
            }

            if(requestObject.IsSetExternalId())
            {
                context.Writer.WritePropertyName("externalId");
                context.Writer.WriteStringValue(requestObject.ExternalId);
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetPath())
            {
                context.Writer.WritePropertyName("path");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPathListValue in requestObject.Path)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AssetModelPropertyPathSegmentMarshaller.Instance;
                    marshaller.Marshall(requestObjectPathListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStartObject();

                var marshaller = PropertyTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.Type, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUnit())
            {
                context.Writer.WritePropertyName("unit");
                context.Writer.WriteStringValue(requestObject.Unit);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AssetModelPropertyMarshaller Instance = new AssetModelPropertyMarshaller();

    }
}