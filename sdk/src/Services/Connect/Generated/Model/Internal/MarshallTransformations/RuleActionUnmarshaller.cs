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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RuleAction Object
    /// </summary>  
    public class RuleActionUnmarshaller : IJsonUnmarshaller<RuleAction, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RuleAction Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RuleAction unmarshalledObject = new RuleAction();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ActionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActionType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AssignContactCategoryAction", targetDepth))
                {
                    var unmarshaller = AssignContactCategoryActionDefinitionUnmarshaller.Instance;
                    unmarshalledObject.AssignContactCategoryAction = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreateCaseAction", targetDepth))
                {
                    var unmarshaller = CreateCaseActionDefinitionUnmarshaller.Instance;
                    unmarshalledObject.CreateCaseAction = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EndAssociatedTasksAction", targetDepth))
                {
                    var unmarshaller = EndAssociatedTasksActionDefinitionUnmarshaller.Instance;
                    unmarshalledObject.EndAssociatedTasksAction = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EventBridgeAction", targetDepth))
                {
                    var unmarshaller = EventBridgeActionDefinitionUnmarshaller.Instance;
                    unmarshalledObject.EventBridgeAction = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SendNotificationAction", targetDepth))
                {
                    var unmarshaller = SendNotificationActionDefinitionUnmarshaller.Instance;
                    unmarshalledObject.SendNotificationAction = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SubmitAutoEvaluationAction", targetDepth))
                {
                    var unmarshaller = SubmitAutoEvaluationActionDefinitionUnmarshaller.Instance;
                    unmarshalledObject.SubmitAutoEvaluationAction = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TaskAction", targetDepth))
                {
                    var unmarshaller = TaskActionDefinitionUnmarshaller.Instance;
                    unmarshalledObject.TaskAction = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UpdateCaseAction", targetDepth))
                {
                    var unmarshaller = UpdateCaseActionDefinitionUnmarshaller.Instance;
                    unmarshalledObject.UpdateCaseAction = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RuleActionUnmarshaller _instance = new RuleActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RuleActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}