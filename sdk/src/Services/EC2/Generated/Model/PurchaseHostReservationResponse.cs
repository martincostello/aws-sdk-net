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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the PurchaseHostReservation operation.
    /// </summary>
    public partial class PurchaseHostReservationResponse : AmazonWebServiceResponse
    {
        private string _clientToken;
        private CurrencyCodeValues _currencyCode;
        private List<Purchase> _purchase = new List<Purchase>();
        private string _totalHourlyPrice;
        private string _totalUpfrontPrice;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency in which the <code>totalUpfrontPrice</code> and <code>totalHourlyPrice</code>
        /// amounts are specified. At this time, the only supported currency is <code>USD</code>.
        /// </para>
        /// </summary>
        public CurrencyCodeValues CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property Purchase. 
        /// <para>
        /// Describes the details of the purchase.
        /// </para>
        /// </summary>
        public List<Purchase> Purchase
        {
            get { return this._purchase; }
            set { this._purchase = value; }
        }

        // Check to see if Purchase property is set
        internal bool IsSetPurchase()
        {
            return this._purchase != null && this._purchase.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TotalHourlyPrice. 
        /// <para>
        /// The total hourly price of the reservation calculated per hour.
        /// </para>
        /// </summary>
        public string TotalHourlyPrice
        {
            get { return this._totalHourlyPrice; }
            set { this._totalHourlyPrice = value; }
        }

        // Check to see if TotalHourlyPrice property is set
        internal bool IsSetTotalHourlyPrice()
        {
            return this._totalHourlyPrice != null;
        }

        /// <summary>
        /// Gets and sets the property TotalUpfrontPrice. 
        /// <para>
        /// The total amount charged to your account when you purchase the reservation.
        /// </para>
        /// </summary>
        public string TotalUpfrontPrice
        {
            get { return this._totalUpfrontPrice; }
            set { this._totalUpfrontPrice = value; }
        }

        // Check to see if TotalUpfrontPrice property is set
        internal bool IsSetTotalUpfrontPrice()
        {
            return this._totalUpfrontPrice != null;
        }

    }
}