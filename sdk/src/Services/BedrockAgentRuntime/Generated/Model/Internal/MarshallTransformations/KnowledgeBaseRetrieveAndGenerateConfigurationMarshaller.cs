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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KnowledgeBaseRetrieveAndGenerateConfiguration Marshaller
    /// </summary>
    public class KnowledgeBaseRetrieveAndGenerateConfigurationMarshaller : IRequestMarshaller<KnowledgeBaseRetrieveAndGenerateConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KnowledgeBaseRetrieveAndGenerateConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetGenerationConfiguration())
            {
                context.Writer.WritePropertyName("generationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = GenerationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.GenerationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKnowledgeBaseId())
            {
                context.Writer.WritePropertyName("knowledgeBaseId");
                context.Writer.WriteStringValue(requestObject.KnowledgeBaseId);
            }

            if(requestObject.IsSetModelArn())
            {
                context.Writer.WritePropertyName("modelArn");
                context.Writer.WriteStringValue(requestObject.ModelArn);
            }

            if(requestObject.IsSetOrchestrationConfiguration())
            {
                context.Writer.WritePropertyName("orchestrationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = OrchestrationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.OrchestrationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRetrievalConfiguration())
            {
                context.Writer.WritePropertyName("retrievalConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = KnowledgeBaseRetrievalConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.RetrievalConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KnowledgeBaseRetrieveAndGenerateConfigurationMarshaller Instance = new KnowledgeBaseRetrieveAndGenerateConfigurationMarshaller();

    }
}