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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Defines an audio channel in a Kinesis video stream.
    /// </summary>
    public partial class ChannelDefinition
    {
        private int? _channelId;
        private ParticipantRole _participantRole;

        /// <summary>
        /// Gets and sets the property ChannelId. 
        /// <para>
        /// The channel ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public int? ChannelId
        {
            get { return this._channelId; }
            set { this._channelId = value; }
        }

        // Check to see if ChannelId property is set
        internal bool IsSetChannelId()
        {
            return this._channelId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParticipantRole. 
        /// <para>
        /// Specifies whether the audio in a channel belongs to the <c>AGENT</c> or <c>CUSTOMER</c>.
        /// </para>
        /// </summary>
        public ParticipantRole ParticipantRole
        {
            get { return this._participantRole; }
            set { this._participantRole = value; }
        }

        // Check to see if ParticipantRole property is set
        internal bool IsSetParticipantRole()
        {
            return this._participantRole != null;
        }

    }
}