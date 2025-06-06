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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The TemplateParameter data type.
    /// </summary>
    public partial class TemplateParameter
    {
        private string _defaultValue;
        private string _description;
        private bool? _noEcho;
        private string _parameterKey;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value associated with the parameter.
        /// </para>
        /// </summary>
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// User defined description associated with the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property NoEcho. 
        /// <para>
        /// Flag indicating whether the parameter should be displayed as plain text in logs and
        /// UIs.
        /// </para>
        /// </summary>
        public bool? NoEcho
        {
            get { return this._noEcho; }
            set { this._noEcho = value; }
        }

        // Check to see if NoEcho property is set
        internal bool IsSetNoEcho()
        {
            return this._noEcho.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParameterKey. 
        /// <para>
        /// The name associated with the parameter.
        /// </para>
        /// </summary>
        public string ParameterKey
        {
            get { return this._parameterKey; }
            set { this._parameterKey = value; }
        }

        // Check to see if ParameterKey property is set
        internal bool IsSetParameterKey()
        {
            return this._parameterKey != null;
        }

    }
}