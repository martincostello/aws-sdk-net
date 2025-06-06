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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
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
namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// Details about a custom plugin.
    /// </summary>
    public partial class CustomPluginDescription
    {
        private string _customPluginArn;
        private long? _revision;

        /// <summary>
        /// Gets and sets the property CustomPluginArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom plugin.
        /// </para>
        /// </summary>
        public string CustomPluginArn
        {
            get { return this._customPluginArn; }
            set { this._customPluginArn = value; }
        }

        // Check to see if CustomPluginArn property is set
        internal bool IsSetCustomPluginArn()
        {
            return this._customPluginArn != null;
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of the custom plugin.
        /// </para>
        /// </summary>
        public long? Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision.HasValue; 
        }

    }
}