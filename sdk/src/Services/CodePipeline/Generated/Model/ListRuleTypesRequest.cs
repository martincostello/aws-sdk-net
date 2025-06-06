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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Container for the parameters to the ListRuleTypes operation.
    /// Lists the rules for the condition. For more information about conditions, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/stage-conditions.html">Stage
    /// conditions</a> and <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/concepts-how-it-works-conditions.html">How
    /// do stage conditions work?</a>.For more information about rules, see the <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/rule-reference.html">CodePipeline
    /// rule reference</a>.
    /// </summary>
    public partial class ListRuleTypesRequest : AmazonCodePipelineRequest
    {
        private string _regionFilter;
        private RuleOwner _ruleOwnerFilter;

        /// <summary>
        /// Gets and sets the property RegionFilter. 
        /// <para>
        /// The rule Region to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=30)]
        public string RegionFilter
        {
            get { return this._regionFilter; }
            set { this._regionFilter = value; }
        }

        // Check to see if RegionFilter property is set
        internal bool IsSetRegionFilter()
        {
            return this._regionFilter != null;
        }

        /// <summary>
        /// Gets and sets the property RuleOwnerFilter. 
        /// <para>
        /// The rule owner to filter on.
        /// </para>
        /// </summary>
        public RuleOwner RuleOwnerFilter
        {
            get { return this._ruleOwnerFilter; }
            set { this._ruleOwnerFilter = value; }
        }

        // Check to see if RuleOwnerFilter property is set
        internal bool IsSetRuleOwnerFilter()
        {
            return this._ruleOwnerFilter != null;
        }

    }
}