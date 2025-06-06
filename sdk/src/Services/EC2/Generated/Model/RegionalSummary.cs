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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// A summary report for the attribute for a Region.
    /// </summary>
    public partial class RegionalSummary
    {
        private int? _numberOfMatchedAccounts;
        private int? _numberOfUnmatchedAccounts;
        private string _regionName;

        /// <summary>
        /// Gets and sets the property NumberOfMatchedAccounts. 
        /// <para>
        /// The number of accounts in the Region with the same configuration value for the attribute
        /// that is most frequently observed.
        /// </para>
        /// </summary>
        public int? NumberOfMatchedAccounts
        {
            get { return this._numberOfMatchedAccounts; }
            set { this._numberOfMatchedAccounts = value; }
        }

        // Check to see if NumberOfMatchedAccounts property is set
        internal bool IsSetNumberOfMatchedAccounts()
        {
            return this._numberOfMatchedAccounts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfUnmatchedAccounts. 
        /// <para>
        /// The number of accounts in the Region with a configuration value different from the
        /// most frequently observed value for the attribute.
        /// </para>
        /// </summary>
        public int? NumberOfUnmatchedAccounts
        {
            get { return this._numberOfUnmatchedAccounts; }
            set { this._numberOfUnmatchedAccounts = value; }
        }

        // Check to see if NumberOfUnmatchedAccounts property is set
        internal bool IsSetNumberOfUnmatchedAccounts()
        {
            return this._numberOfUnmatchedAccounts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string RegionName
        {
            get { return this._regionName; }
            set { this._regionName = value; }
        }

        // Check to see if RegionName property is set
        internal bool IsSetRegionName()
        {
            return this._regionName != null;
        }

    }
}