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
using System.Collections.Generic;

using Amazon.S3.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///   InventoryFilter Unmarshaller
    /// </summary>
    public class InventoryFilterUnmarshaller : IXmlUnmarshaller<InventoryFilter, XmlUnmarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public InventoryFilter Unmarshall(XmlUnmarshallerContext context)
        {
            InventoryFilter filter = new InventoryFilter();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Prefix", targetDepth))
                    {
                        filter.InventoryFilterPredicate = new InventoryPrefixPredicate(StringUnmarshaller.Instance.Unmarshall(context));

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return filter;
                }
            }



            return filter;
        }

        private static InventoryFilterUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static InventoryFilterUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InventoryFilterUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
