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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// The LoRaWAN information returned from getting a FUOTA task.
    /// </summary>
    public partial class LoRaWANFuotaTaskGetInfo
    {
        private string _rfRegion;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property RfRegion.
        /// </summary>
        [AWSProperty(Max=64)]
        public string RfRegion
        {
            get { return this._rfRegion; }
            set { this._rfRegion = value; }
        }

        // Check to see if RfRegion property is set
        internal bool IsSetRfRegion()
        {
            return this._rfRegion != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime.
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}