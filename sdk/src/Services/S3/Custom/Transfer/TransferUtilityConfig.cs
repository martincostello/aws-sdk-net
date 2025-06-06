﻿/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// 	<para>
    /// 	Provides configuration options for how <see cref="TransferUtility"/> processes requests.
    /// 	</para>
    /// 	<para>
    /// 	The best configuration settings depend on network
    /// 	configuration, latency and bandwidth. 
    /// 	The default configuration settings are suitable
    /// 	for most applications, but this class enables developers to experiment with
    /// 	different configurations and tune transfer manager performance.
    /// 	</para>
    /// </summary>
    public partial class TransferUtilityConfig
    {
        long _minSizeBeforePartUpload = 16 * (long)Math.Pow(2, 20);
        int _concurrentServiceRequests;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public TransferUtilityConfig()
        {
            this.ConcurrentServiceRequests = 10;
        }

        /// <summary>
        /// Gets or sets the minimum size required (in bytes) to enable multi-part upload. The default is 16 MB.
        /// If the file size is greater than or equal to MinSizeBeforePartUpload, multi-part upload will be used.
        /// </summary>
        public long MinSizeBeforePartUpload
        {
            get { return this._minSizeBeforePartUpload; }
            set { this._minSizeBeforePartUpload = value; }
        }

        /// <summary>
        /// This property determines how many active threads
        /// or the number of concurrent asynchronous web requests 
        /// will be used to upload/download the file .
        /// The default value is 10.
        /// </summary>
        /// <remarks>
        /// 	A value less than or equal to 0 will be silently ignored.
        /// </remarks>
        public int ConcurrentServiceRequests
        {
            get { return this._concurrentServiceRequests; }
            set
            {
                if (value < 1)
                    value = 1;

                this._concurrentServiceRequests = value;
            }
        }
    }
}
