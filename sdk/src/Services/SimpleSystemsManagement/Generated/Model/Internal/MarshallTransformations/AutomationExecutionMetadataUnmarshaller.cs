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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AutomationExecutionMetadata Object
    /// </summary>  
    public class AutomationExecutionMetadataUnmarshaller : IUnmarshaller<AutomationExecutionMetadata, XmlUnmarshallerContext>, IUnmarshaller<AutomationExecutionMetadata, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AutomationExecutionMetadata IUnmarshaller<AutomationExecutionMetadata, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AutomationExecutionMetadata Unmarshall(JsonUnmarshallerContext context)
        {
            AutomationExecutionMetadata unmarshalledObject = new AutomationExecutionMetadata();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AlarmConfiguration", targetDepth))
                {
                    var unmarshaller = AlarmConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AlarmConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AssociationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssociationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutomationExecutionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AutomationExecutionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutomationExecutionStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AutomationExecutionStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutomationSubtype", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AutomationSubtype = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutomationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AutomationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ChangeRequestName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChangeRequestName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrentAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrentStepName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentStepName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DocumentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DocumentVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutedBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ExecutionEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ExecutionStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogFile", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogFile = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxConcurrency", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxConcurrency = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxErrors", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxErrors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Mode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Mode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OpsItemId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OpsItemId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Outputs", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<string>, StringUnmarshaller, ListUnmarshaller<string, StringUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance));
                    unmarshalledObject.Outputs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParentAutomationExecutionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParentAutomationExecutionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResolvedTargets", targetDepth))
                {
                    var unmarshaller = ResolvedTargetsUnmarshaller.Instance;
                    unmarshalledObject.ResolvedTargets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Runbooks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Runbook, RunbookUnmarshaller>(RunbookUnmarshaller.Instance);
                    unmarshalledObject.Runbooks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScheduledTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ScheduledTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Target", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Target = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetLocationsURL", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetLocationsURL = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetMaps", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Dictionary<string, List<string>>, DictionaryUnmarshaller<string, List<string>, StringUnmarshaller, ListUnmarshaller<string, StringUnmarshaller>>>(new DictionaryUnmarshaller<string, List<string>, StringUnmarshaller, ListUnmarshaller<string, StringUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance)));
                    unmarshalledObject.TargetMaps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetParameterName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetParameterName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Targets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Target, TargetUnmarshaller>(TargetUnmarshaller.Instance);
                    unmarshalledObject.Targets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TriggeredAlarms", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AlarmStateInformation, AlarmStateInformationUnmarshaller>(AlarmStateInformationUnmarshaller.Instance);
                    unmarshalledObject.TriggeredAlarms = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AutomationExecutionMetadataUnmarshaller _instance = new AutomationExecutionMetadataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AutomationExecutionMetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}