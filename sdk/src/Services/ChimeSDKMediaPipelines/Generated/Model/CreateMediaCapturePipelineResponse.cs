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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// This is the response object from the CreateMediaCapturePipeline operation.
    /// </summary>
    public partial class CreateMediaCapturePipelineResponse : AmazonWebServiceResponse
    {
        private MediaCapturePipeline _mediaCapturePipeline;

        /// <summary>
        /// Gets and sets the property MediaCapturePipeline. 
        /// <para>
        /// A media capture pipeline object, the ID, source type, source ARN, sink type, and sink
        /// ARN of a media capture pipeline object.
        /// </para>
        /// </summary>
        public MediaCapturePipeline MediaCapturePipeline
        {
            get { return this._mediaCapturePipeline; }
            set { this._mediaCapturePipeline = value; }
        }

        // Check to see if MediaCapturePipeline property is set
        internal bool IsSetMediaCapturePipeline()
        {
            return this._mediaCapturePipeline != null;
        }

    }
}