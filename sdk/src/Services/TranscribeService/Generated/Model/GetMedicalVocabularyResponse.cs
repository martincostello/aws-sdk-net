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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
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
namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// This is the response object from the GetMedicalVocabulary operation.
    /// </summary>
    public partial class GetMedicalVocabularyResponse : AmazonWebServiceResponse
    {
        private string _downloadUri;
        private string _failureReason;
        private LanguageCode _languageCode;
        private DateTime? _lastModifiedTime;
        private string _vocabularyName;
        private VocabularyState _vocabularyState;

        /// <summary>
        /// Gets and sets the property DownloadUri. 
        /// <para>
        /// The Amazon S3 location where the specified custom medical vocabulary is stored; use
        /// this URI to view or download the custom vocabulary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string DownloadUri
        {
            get { return this._downloadUri; }
            set { this._downloadUri = value; }
        }

        // Check to see if DownloadUri property is set
        internal bool IsSetDownloadUri()
        {
            return this._downloadUri != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If <c>VocabularyState</c> is <c>FAILED</c>, <c>FailureReason</c> contains information
        /// about why the custom medical vocabulary request failed. See also: <a href="https://docs.aws.amazon.com/transcribe/latest/APIReference/CommonErrors.html">Common
        /// Errors</a>.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code you selected for your custom medical vocabulary. US English (<c>en-US</c>)
        /// is the only language supported with Amazon Transcribe Medical.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time the specified custom medical vocabulary was last modified.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <c>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</c>. For example,
        /// <c>2022-05-04T12:32:58.761000-07:00</c> represents 12:32 PM UTC-7 on May 4, 2022.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// The name of the custom medical vocabulary you requested information about.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string VocabularyName
        {
            get { return this._vocabularyName; }
            set { this._vocabularyName = value; }
        }

        // Check to see if VocabularyName property is set
        internal bool IsSetVocabularyName()
        {
            return this._vocabularyName != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyState. 
        /// <para>
        /// The processing state of your custom medical vocabulary. If the state is <c>READY</c>,
        /// you can use the custom vocabulary in a <c>StartMedicalTranscriptionJob</c> request.
        /// </para>
        /// </summary>
        public VocabularyState VocabularyState
        {
            get { return this._vocabularyState; }
            set { this._vocabularyState = value; }
        }

        // Check to see if VocabularyState property is set
        internal bool IsSetVocabularyState()
        {
            return this._vocabularyState != null;
        }

    }
}