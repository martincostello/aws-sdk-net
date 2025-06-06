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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// This is the response object from the CreateUpdatedImage operation.
    /// </summary>
    public partial class CreateUpdatedImageResponse : AmazonWebServiceResponse
    {
        private bool? _canUpdateImage;
        private Image _image;

        /// <summary>
        /// Gets and sets the property CanUpdateImage. 
        /// <para>
        /// Indicates whether a new image can be created.
        /// </para>
        /// </summary>
        public bool? CanUpdateImage
        {
            get { return this._canUpdateImage; }
            set { this._canUpdateImage = value; }
        }

        // Check to see if CanUpdateImage property is set
        internal bool IsSetCanUpdateImage()
        {
            return this._canUpdateImage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Image.
        /// </summary>
        public Image Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

    }
}