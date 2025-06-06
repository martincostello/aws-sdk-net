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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SheetDefinition Object
    /// </summary>  
    public class SheetDefinitionUnmarshaller : IJsonUnmarshaller<SheetDefinition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public SheetDefinition Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            SheetDefinition unmarshalledObject = new SheetDefinition();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ContentType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContentType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FilterControls", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<FilterControl, FilterControlUnmarshaller>(FilterControlUnmarshaller.Instance);
                    unmarshalledObject.FilterControls = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Images", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<SheetImage, SheetImageUnmarshaller>(SheetImageUnmarshaller.Instance);
                    unmarshalledObject.Images = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Layouts", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Layout, LayoutUnmarshaller>(LayoutUnmarshaller.Instance);
                    unmarshalledObject.Layouts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ParameterControls", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ParameterControl, ParameterControlUnmarshaller>(ParameterControlUnmarshaller.Instance);
                    unmarshalledObject.ParameterControls = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SheetControlLayouts", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<SheetControlLayout, SheetControlLayoutUnmarshaller>(SheetControlLayoutUnmarshaller.Instance);
                    unmarshalledObject.SheetControlLayouts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SheetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SheetId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TextBoxes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<SheetTextBox, SheetTextBoxUnmarshaller>(SheetTextBoxUnmarshaller.Instance);
                    unmarshalledObject.TextBoxes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Visuals", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Visual, VisualUnmarshaller>(VisualUnmarshaller.Instance);
                    unmarshalledObject.Visuals = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SheetDefinitionUnmarshaller _instance = new SheetDefinitionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SheetDefinitionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}