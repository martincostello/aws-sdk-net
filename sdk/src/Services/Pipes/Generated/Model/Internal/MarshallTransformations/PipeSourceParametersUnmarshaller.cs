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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pipes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PipeSourceParameters Object
    /// </summary>  
    public class PipeSourceParametersUnmarshaller : IJsonUnmarshaller<PipeSourceParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public PipeSourceParameters Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            PipeSourceParameters unmarshalledObject = new PipeSourceParameters();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ActiveMQBrokerParameters", targetDepth))
                {
                    var unmarshaller = PipeSourceActiveMQBrokerParametersUnmarshaller.Instance;
                    unmarshalledObject.ActiveMQBrokerParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DynamoDBStreamParameters", targetDepth))
                {
                    var unmarshaller = PipeSourceDynamoDBStreamParametersUnmarshaller.Instance;
                    unmarshalledObject.DynamoDBStreamParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FilterCriteria", targetDepth))
                {
                    var unmarshaller = FilterCriteriaUnmarshaller.Instance;
                    unmarshalledObject.FilterCriteria = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KinesisStreamParameters", targetDepth))
                {
                    var unmarshaller = PipeSourceKinesisStreamParametersUnmarshaller.Instance;
                    unmarshalledObject.KinesisStreamParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ManagedStreamingKafkaParameters", targetDepth))
                {
                    var unmarshaller = PipeSourceManagedStreamingKafkaParametersUnmarshaller.Instance;
                    unmarshalledObject.ManagedStreamingKafkaParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RabbitMQBrokerParameters", targetDepth))
                {
                    var unmarshaller = PipeSourceRabbitMQBrokerParametersUnmarshaller.Instance;
                    unmarshalledObject.RabbitMQBrokerParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SelfManagedKafkaParameters", targetDepth))
                {
                    var unmarshaller = PipeSourceSelfManagedKafkaParametersUnmarshaller.Instance;
                    unmarshalledObject.SelfManagedKafkaParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SqsQueueParameters", targetDepth))
                {
                    var unmarshaller = PipeSourceSqsQueueParametersUnmarshaller.Instance;
                    unmarshalledObject.SqsQueueParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PipeSourceParametersUnmarshaller _instance = new PipeSourceParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PipeSourceParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}