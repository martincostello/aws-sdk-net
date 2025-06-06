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
    /// Flag the presence or absence of interruptions in your Call Analytics transcription
    /// output.
    /// 
    ///  
    /// <para>
    /// Rules using <c>InterruptionFilter</c> are designed to match:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Instances where an agent interrupts a customer
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Instances where a customer interrupts an agent
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Either participant interrupting the other
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A lack of interruptions
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// See <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-batch.html#tca-rules-batch">Rule
    /// criteria for post-call categories</a> for usage examples.
    /// </para>
    /// </summary>
    public partial class InterruptionFilter
    {
        private AbsoluteTimeRange _absoluteTimeRange;
        private bool? _negate;
        private ParticipantRole _participantRole;
        private RelativeTimeRange _relativeTimeRange;
        private long? _threshold;

        /// <summary>
        /// Gets and sets the property AbsoluteTimeRange. 
        /// <para>
        /// Makes it possible to specify a time range (in milliseconds) in your audio, during
        /// which you want to search for an interruption. See for more detail.
        /// </para>
        /// </summary>
        public AbsoluteTimeRange AbsoluteTimeRange
        {
            get { return this._absoluteTimeRange; }
            set { this._absoluteTimeRange = value; }
        }

        // Check to see if AbsoluteTimeRange property is set
        internal bool IsSetAbsoluteTimeRange()
        {
            return this._absoluteTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property Negate. 
        /// <para>
        /// Set to <c>TRUE</c> to flag speech that does not contain interruptions. Set to <c>FALSE</c>
        /// to flag speech that contains interruptions.
        /// </para>
        /// </summary>
        public bool? Negate
        {
            get { return this._negate; }
            set { this._negate = value; }
        }

        // Check to see if Negate property is set
        internal bool IsSetNegate()
        {
            return this._negate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParticipantRole. 
        /// <para>
        /// Specify the interrupter that you want to flag. Omitting this parameter is equivalent
        /// to specifying both participants.
        /// </para>
        /// </summary>
        public ParticipantRole ParticipantRole
        {
            get { return this._participantRole; }
            set { this._participantRole = value; }
        }

        // Check to see if ParticipantRole property is set
        internal bool IsSetParticipantRole()
        {
            return this._participantRole != null;
        }

        /// <summary>
        /// Gets and sets the property RelativeTimeRange. 
        /// <para>
        /// Makes it possible to specify a time range (in percentage) in your media file, during
        /// which you want to search for an interruption. See for more detail.
        /// </para>
        /// </summary>
        public RelativeTimeRange RelativeTimeRange
        {
            get { return this._relativeTimeRange; }
            set { this._relativeTimeRange = value; }
        }

        // Check to see if RelativeTimeRange property is set
        internal bool IsSetRelativeTimeRange()
        {
            return this._relativeTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// Specify the duration of the interruptions in milliseconds. For example, you can flag
        /// speech that contains more than 10,000 milliseconds of interruptions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=14400000)]
        public long? Threshold
        {
            get { return this._threshold; }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold.HasValue; 
        }

    }
}