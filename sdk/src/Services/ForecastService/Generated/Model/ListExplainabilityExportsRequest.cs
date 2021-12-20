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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Container for the parameters to the ListExplainabilityExports operation.
    /// Returns a list of Explainability exports created using the <a>CreateExplainabilityExport</a>
    /// operation. This operation returns a summary for each Explainability export. You can
    /// filter the list using an array of <a>Filter</a> objects.
    /// 
    ///  
    /// <para>
    /// To retrieve the complete set of properties for a particular Explainability export,
    /// use the ARN with the <a>DescribeExplainability</a> operation.
    /// </para>
    /// </summary>
    public partial class ListExplainabilityExportsRequest : AmazonForecastServiceRequest
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of filters. For each filter, provide a condition and a match statement. The
        /// condition is either <code>IS</code> or <code>IS_NOT</code>, which specifies whether
        /// to include or exclude resources that match the statement from the list. The match
        /// statement consists of a key and a value.
        /// </para>
        ///  
        /// <para>
        ///  <b>Filter properties</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Condition</code> - The condition to apply. Valid values are <code>IS</code>
        /// and <code>IS_NOT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Key</code> - The name of the parameter to filter on. Valid values are <code>ResourceArn</code>
        /// and <code>Status</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Value</code> - The value to match.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of items to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// If the result of the previous request was truncated, the response includes a NextToken.
        /// To retrieve the next set of results, use the token in the next request. Tokens expire
        /// after 24 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3000)]
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