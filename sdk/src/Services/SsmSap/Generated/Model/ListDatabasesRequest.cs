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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
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
namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// Container for the parameters to the ListDatabases operation.
    /// Lists the SAP HANA databases of an application registered with AWS Systems Manager
    /// for SAP.
    /// </summary>
    public partial class ListDatabasesRequest : AmazonSsmSapRequest
    {
        private string _applicationId;
        private string _componentId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentId. 
        /// <para>
        /// The ID of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ComponentId
        {
            get { return this._componentId; }
            set { this._componentId = value; }
        }

        // Check to see if ComponentId property is set
        internal bool IsSetComponentId()
        {
            return this._componentId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned nextToken value. If you do not specify
        /// a value for MaxResults, the request returns 50 items per page by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results. 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}