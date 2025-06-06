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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
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
namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// Response for GetProgrammaticAccessCredentials operation
    /// </summary>
    public partial class GetProgrammaticAccessCredentialsResponse : AmazonWebServiceResponse
    {
        private Credentials _credentials;
        private long? _durationInMinutes;

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// Returns the programmatic credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Credentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property DurationInMinutes. 
        /// <para>
        /// Returns the duration in which the credentials will remain valid.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public long? DurationInMinutes
        {
            get { return this._durationInMinutes; }
            set { this._durationInMinutes = value; }
        }

        // Check to see if DurationInMinutes property is set
        internal bool IsSetDurationInMinutes()
        {
            return this._durationInMinutes.HasValue; 
        }

    }
}