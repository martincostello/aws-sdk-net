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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
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
namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRule operation.
    /// Updates a specified rule for the listener. You can't modify a default listener rule.
    /// To modify a default listener rule, use <c>UpdateListener</c>.
    /// </summary>
    public partial class UpdateRuleRequest : AmazonVPCLatticeRequest
    {
        private RuleAction _action;
        private string _listenerIdentifier;
        private RuleMatch _match;
        private int? _priority;
        private string _ruleIdentifier;
        private string _serviceIdentifier;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Information about the action for the specified listener rule.
        /// </para>
        /// </summary>
        public RuleAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ListenerIdentifier. 
        /// <para>
        /// The ID or ARN of the listener.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ListenerIdentifier
        {
            get { return this._listenerIdentifier; }
            set { this._listenerIdentifier = value; }
        }

        // Check to see if ListenerIdentifier property is set
        internal bool IsSetListenerIdentifier()
        {
            return this._listenerIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Match. 
        /// <para>
        /// The rule match.
        /// </para>
        /// </summary>
        public RuleMatch Match
        {
            get { return this._match; }
            set { this._match = value; }
        }

        // Check to see if Match property is set
        internal bool IsSetMatch()
        {
            return this._match != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The rule priority. A listener can't have multiple rules with the same priority.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleIdentifier. 
        /// <para>
        /// The ID or ARN of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RuleIdentifier
        {
            get { return this._ruleIdentifier; }
            set { this._ruleIdentifier = value; }
        }

        // Check to see if RuleIdentifier property is set
        internal bool IsSetRuleIdentifier()
        {
            return this._ruleIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceIdentifier. 
        /// <para>
        /// The ID or ARN of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=17, Max=2048)]
        public string ServiceIdentifier
        {
            get { return this._serviceIdentifier; }
            set { this._serviceIdentifier = value; }
        }

        // Check to see if ServiceIdentifier property is set
        internal bool IsSetServiceIdentifier()
        {
            return this._serviceIdentifier != null;
        }

    }
}