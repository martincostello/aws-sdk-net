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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The configuration of custom values for the destination parameter in <c>DestinationParameterValueConfiguration</c>.
    /// </summary>
    public partial class CustomValuesConfiguration
    {
        private CustomParameterValues _customValues;
        private bool? _includeNullValue;

        /// <summary>
        /// Gets and sets the property CustomValues.
        /// </summary>
        [AWSProperty(Required=true)]
        public CustomParameterValues CustomValues
        {
            get { return this._customValues; }
            set { this._customValues = value; }
        }

        // Check to see if CustomValues property is set
        internal bool IsSetCustomValues()
        {
            return this._customValues != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeNullValue. 
        /// <para>
        /// Includes the null value in custom action parameter values.
        /// </para>
        /// </summary>
        public bool? IncludeNullValue
        {
            get { return this._includeNullValue; }
            set { this._includeNullValue = value; }
        }

        // Check to see if IncludeNullValue property is set
        internal bool IsSetIncludeNullValue()
        {
            return this._includeNullValue.HasValue; 
        }

    }
}