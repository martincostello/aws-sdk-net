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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the PutStorageLensConfiguration operation.
    /// Puts an Amazon S3 Storage Lens configuration. For more information about S3 Storage
    /// Lens, see <a href="https://docs.aws.amazon.com/https:/docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Working
    /// with Amazon S3 Storage Lens</a> in the <i>Amazon Simple Storage Service Developer
    /// Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    /// To use this action, you must have permission to perform the <code>s3:PutStorageLensConfiguration</code>
    /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html#storage_lens_IAM">Setting
    /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon Simple Storage Service
    /// Developer Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutStorageLensConfigurationRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _configId;
        private StorageLensConfiguration _storageLensConfiguration;
        private List<StorageLensTag> _tags = new List<StorageLensTag>();

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID of the requester.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigId. 
        /// <para>
        /// The ID of the S3 Storage Lens configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ConfigId
        {
            get { return this._configId; }
            set { this._configId = value; }
        }

        // Check to see if ConfigId property is set
        internal bool IsSetConfigId()
        {
            return this._configId != null;
        }

        /// <summary>
        /// Gets and sets the property StorageLensConfiguration. 
        /// <para>
        /// The S3 Storage Lens configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StorageLensConfiguration StorageLensConfiguration
        {
            get { return this._storageLensConfiguration; }
            set { this._storageLensConfiguration = value; }
        }

        // Check to see if StorageLensConfiguration property is set
        internal bool IsSetStorageLensConfiguration()
        {
            return this._storageLensConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag set of the S3 Storage Lens configuration.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can set up to a maximum of 50 tags.
        /// </para>
        ///  </note>
        /// </summary>
        public List<StorageLensTag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}