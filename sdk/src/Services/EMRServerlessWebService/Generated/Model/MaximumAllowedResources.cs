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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EMRServerlessWebService.Model
{
    /// <summary>
    /// The maximum allowed cumulative resources for an application. No new resources will
    /// be created once the limit is hit.
    /// </summary>
    public partial class MaximumAllowedResources
    {
        private string _cpu;
        private string _disk;
        private string _memory;

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The maximum allowed CPU for an application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=15)]
        public string Cpu
        {
            get { return this._cpu; }
            set { this._cpu = value; }
        }

        // Check to see if Cpu property is set
        internal bool IsSetCpu()
        {
            return this._cpu != null;
        }

        /// <summary>
        /// Gets and sets the property Disk. 
        /// <para>
        /// The maximum allowed disk for an application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public string Disk
        {
            get { return this._disk; }
            set { this._disk = value; }
        }

        // Check to see if Disk property is set
        internal bool IsSetDisk()
        {
            return this._disk != null;
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The maximum allowed resources for an application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=15)]
        public string Memory
        {
            get { return this._memory; }
            set { this._memory = value; }
        }

        // Check to see if Memory property is set
        internal bool IsSetMemory()
        {
            return this._memory != null;
        }

    }
}