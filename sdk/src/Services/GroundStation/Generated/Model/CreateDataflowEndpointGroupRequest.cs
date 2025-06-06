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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataflowEndpointGroup operation.
    /// Creates a <c>DataflowEndpoint</c> group containing the specified list of <c>DataflowEndpoint</c>
    /// objects.
    /// 
    ///  
    /// <para>
    /// The <c>name</c> field in each endpoint is used in your mission profile <c>DataflowEndpointConfig</c>
    /// to specify which endpoints to use during a contact.
    /// </para>
    ///  
    /// <para>
    /// When a contact uses multiple <c>DataflowEndpointConfig</c> objects, each <c>Config</c>
    /// must match a <c>DataflowEndpoint</c> in the same group.
    /// </para>
    /// </summary>
    public partial class CreateDataflowEndpointGroupRequest : AmazonGroundStationRequest
    {
        private int? _contactPostPassDurationSeconds;
        private int? _contactPrePassDurationSeconds;
        private List<EndpointDetails> _endpointDetails = AWSConfigs.InitializeCollections ? new List<EndpointDetails>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ContactPostPassDurationSeconds. 
        /// <para>
        /// Amount of time, in seconds, after a contact ends that the Ground Station Dataflow
        /// Endpoint Group will be in a <c>POSTPASS</c> state. A Ground Station Dataflow Endpoint
        /// Group State Change event will be emitted when the Dataflow Endpoint Group enters and
        /// exits the <c>POSTPASS</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=120, Max=480)]
        public int? ContactPostPassDurationSeconds
        {
            get { return this._contactPostPassDurationSeconds; }
            set { this._contactPostPassDurationSeconds = value; }
        }

        // Check to see if ContactPostPassDurationSeconds property is set
        internal bool IsSetContactPostPassDurationSeconds()
        {
            return this._contactPostPassDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContactPrePassDurationSeconds. 
        /// <para>
        /// Amount of time, in seconds, before a contact starts that the Ground Station Dataflow
        /// Endpoint Group will be in a <c>PREPASS</c> state. A Ground Station Dataflow Endpoint
        /// Group State Change event will be emitted when the Dataflow Endpoint Group enters and
        /// exits the <c>PREPASS</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=120, Max=480)]
        public int? ContactPrePassDurationSeconds
        {
            get { return this._contactPrePassDurationSeconds; }
            set { this._contactPrePassDurationSeconds = value; }
        }

        // Check to see if ContactPrePassDurationSeconds property is set
        internal bool IsSetContactPrePassDurationSeconds()
        {
            return this._contactPrePassDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointDetails. 
        /// <para>
        /// Endpoint details of each endpoint in the dataflow endpoint group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=500)]
        public List<EndpointDetails> EndpointDetails
        {
            get { return this._endpointDetails; }
            set { this._endpointDetails = value; }
        }

        // Check to see if EndpointDetails property is set
        internal bool IsSetEndpointDetails()
        {
            return this._endpointDetails != null && (this._endpointDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags of a dataflow endpoint group.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}