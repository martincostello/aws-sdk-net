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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
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
namespace Amazon.Private5G.Model
{
    /// <summary>
    /// Container for the parameters to the ListNetworks operation.
    /// Lists networks. Add filters to your request to return a more specific list of results.
    /// Use filters to match the status of the network.
    /// </summary>
    public partial class ListNetworksRequest : AmazonPrivate5GRequest
    {
        private Dictionary<string, List<string>> _filters = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private int? _maxResults;
        private string _startToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>STATUS</c> - The status (<c>AVAILABLE</c> | <c>CREATED</c> | <c>DELETED</c> |
        /// <c>DEPROVISIONING</c> | <c>PROVISIONING</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Filter values are case sensitive. If you specify multiple values for a filter, the
        /// values are joined with an <c>OR</c>, and the request returns all results that match
        /// any of the specified values.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartToken. 
        /// <para>
        /// The token for the next page of results.
        /// </para>
        /// </summary>
        public string StartToken
        {
            get { return this._startToken; }
            set { this._startToken = value; }
        }

        // Check to see if StartToken property is set
        internal bool IsSetStartToken()
        {
            return this._startToken != null;
        }

    }
}