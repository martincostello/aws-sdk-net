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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// This is the response object from the GetAIAgent operation.
    /// </summary>
    public partial class GetAIAgentResponse : AmazonWebServiceResponse
    {
        private AIAgentData _aiAgent;
        private long? _versionNumber;

        /// <summary>
        /// Gets and sets the property AiAgent. 
        /// <para>
        /// The data of the AI Agent.
        /// </para>
        /// </summary>
        public AIAgentData AiAgent
        {
            get { return this._aiAgent; }
            set { this._aiAgent = value; }
        }

        // Check to see if AiAgent property is set
        internal bool IsSetAiAgent()
        {
            return this._aiAgent != null;
        }

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number of the AI Agent version (returned if an AI Agent version was specified
        /// via use of a qualifier for the <c>aiAgentId</c> on the request). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? VersionNumber
        {
            get { return this._versionNumber; }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}