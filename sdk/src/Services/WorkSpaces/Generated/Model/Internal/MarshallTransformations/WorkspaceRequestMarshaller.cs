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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WorkspaceRequest Marshaller
    /// </summary>
    public class WorkspaceRequestMarshaller : IRequestMarshaller<WorkspaceRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WorkspaceRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBundleId())
            {
                context.Writer.WritePropertyName("BundleId");
                context.Writer.WriteStringValue(requestObject.BundleId);
            }

            if(requestObject.IsSetDirectoryId())
            {
                context.Writer.WritePropertyName("DirectoryId");
                context.Writer.WriteStringValue(requestObject.DirectoryId);
            }

            if(requestObject.IsSetRootVolumeEncryptionEnabled())
            {
                context.Writer.WritePropertyName("RootVolumeEncryptionEnabled");
                context.Writer.WriteBooleanValue(requestObject.RootVolumeEncryptionEnabled.Value);
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTagsListValue in requestObject.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUserName())
            {
                context.Writer.WritePropertyName("UserName");
                context.Writer.WriteStringValue(requestObject.UserName);
            }

            if(requestObject.IsSetUserVolumeEncryptionEnabled())
            {
                context.Writer.WritePropertyName("UserVolumeEncryptionEnabled");
                context.Writer.WriteBooleanValue(requestObject.UserVolumeEncryptionEnabled.Value);
            }

            if(requestObject.IsSetVolumeEncryptionKey())
            {
                context.Writer.WritePropertyName("VolumeEncryptionKey");
                context.Writer.WriteStringValue(requestObject.VolumeEncryptionKey);
            }

            if(requestObject.IsSetWorkspaceName())
            {
                context.Writer.WritePropertyName("WorkspaceName");
                context.Writer.WriteStringValue(requestObject.WorkspaceName);
            }

            if(requestObject.IsSetWorkspaceProperties())
            {
                context.Writer.WritePropertyName("WorkspaceProperties");
                context.Writer.WriteStartObject();

                var marshaller = WorkspacePropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.WorkspaceProperties, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WorkspaceRequestMarshaller Instance = new WorkspaceRequestMarshaller();

    }
}