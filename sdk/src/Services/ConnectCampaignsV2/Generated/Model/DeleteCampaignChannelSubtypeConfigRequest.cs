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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
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
namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCampaignChannelSubtypeConfig operation.
    /// Deletes the channel subtype config of a campaign. This API is idempotent.
    /// </summary>
    public partial class DeleteCampaignChannelSubtypeConfigRequest : AmazonConnectCampaignsV2Request
    {
        private ChannelSubtype _channelSubtype;
        private string _id;

        /// <summary>
        /// Gets and sets the property ChannelSubtype.
        /// </summary>
        [AWSProperty(Required=true)]
        public ChannelSubtype ChannelSubtype
        {
            get { return this._channelSubtype; }
            set { this._channelSubtype = value; }
        }

        // Check to see if ChannelSubtype property is set
        internal bool IsSetChannelSubtype()
        {
            return this._channelSubtype != null;
        }

        /// <summary>
        /// Gets and sets the property Id.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}