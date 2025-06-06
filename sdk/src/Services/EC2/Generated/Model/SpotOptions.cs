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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the configuration of Spot Instances in an EC2 Fleet.
    /// </summary>
    public partial class SpotOptions
    {
        private SpotAllocationStrategy _allocationStrategy;
        private SpotInstanceInterruptionBehavior _instanceInterruptionBehavior;
        private int? _instancePoolsToUseCount;
        private FleetSpotMaintenanceStrategies _maintenanceStrategies;
        private string _maxTotalPrice;
        private int? _minTargetCapacity;
        private bool? _singleAvailabilityZone;
        private bool? _singleInstanceType;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// The strategy that determines how to allocate the target Spot Instance capacity across
        /// the Spot Instance pools specified by the EC2 Fleet launch configuration. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet-allocation-strategy.html">Allocation
        /// strategies for Spot Instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  <dl> <dt>price-capacity-optimized (recommended)</dt> <dd> 
        /// <para>
        /// EC2 Fleet identifies the pools with the highest capacity availability for the number
        /// of instances that are launching. This means that we will request Spot Instances from
        /// the pools that we believe have the lowest chance of interruption in the near term.
        /// EC2 Fleet then requests Spot Instances from the lowest priced of these pools.
        /// </para>
        ///  </dd> <dt>capacity-optimized</dt> <dd> 
        /// <para>
        /// EC2 Fleet identifies the pools with the highest capacity availability for the number
        /// of instances that are launching. This means that we will request Spot Instances from
        /// the pools that we believe have the lowest chance of interruption in the near term.
        /// To give certain instance types a higher chance of launching first, use <c>capacity-optimized-prioritized</c>.
        /// Set a priority for each instance type by using the <c>Priority</c> parameter for <c>LaunchTemplateOverrides</c>.
        /// You can assign the same priority to different <c>LaunchTemplateOverrides</c>. EC2
        /// implements the priorities on a best-effort basis, but optimizes for capacity first.
        /// <c>capacity-optimized-prioritized</c> is supported only if your EC2 Fleet uses a launch
        /// template. Note that if the On-Demand <c>AllocationStrategy</c> is set to <c>prioritized</c>,
        /// the same priority is applied when fulfilling On-Demand capacity.
        /// </para>
        ///  </dd> <dt>diversified</dt> <dd> 
        /// <para>
        /// EC2 Fleet requests instances from all of the Spot Instance pools that you specify.
        /// </para>
        ///  </dd> <dt>lowest-price (not recommended)</dt> <dd> <important> 
        /// <para>
        /// We don't recommend the <c>lowest-price</c> allocation strategy because it has the
        /// highest risk of interruption for your Spot Instances.
        /// </para>
        ///  </important> 
        /// <para>
        /// EC2 Fleet requests instances from the lowest priced Spot Instance pool that has available
        /// capacity. If the lowest priced pool doesn't have available capacity, the Spot Instances
        /// come from the next lowest priced pool that has available capacity. If a pool runs
        /// out of capacity before fulfilling your desired capacity, EC2 Fleet will continue to
        /// fulfill your request by drawing from the next lowest priced pool. To ensure that your
        /// desired capacity is met, you might receive Spot Instances from several pools. Because
        /// this strategy only considers instance price and not capacity availability, it might
        /// lead to high interruption rates.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// Default: <c>lowest-price</c> 
        /// </para>
        /// </summary>
        public SpotAllocationStrategy AllocationStrategy
        {
            get { return this._allocationStrategy; }
            set { this._allocationStrategy = value; }
        }

        // Check to see if AllocationStrategy property is set
        internal bool IsSetAllocationStrategy()
        {
            return this._allocationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceInterruptionBehavior. 
        /// <para>
        /// The behavior when a Spot Instance is interrupted.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>terminate</c> 
        /// </para>
        /// </summary>
        public SpotInstanceInterruptionBehavior InstanceInterruptionBehavior
        {
            get { return this._instanceInterruptionBehavior; }
            set { this._instanceInterruptionBehavior = value; }
        }

        // Check to see if InstanceInterruptionBehavior property is set
        internal bool IsSetInstanceInterruptionBehavior()
        {
            return this._instanceInterruptionBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property InstancePoolsToUseCount. 
        /// <para>
        /// The number of Spot pools across which to allocate your target Spot capacity. Supported
        /// only when <c>AllocationStrategy</c> is set to <c>lowest-price</c>. EC2 Fleet selects
        /// the cheapest Spot pools and evenly allocates your target Spot capacity across the
        /// number of Spot pools that you specify.
        /// </para>
        ///  
        /// <para>
        /// Note that EC2 Fleet attempts to draw Spot Instances from the number of pools that
        /// you specify on a best effort basis. If a pool runs out of Spot capacity before fulfilling
        /// your target capacity, EC2 Fleet will continue to fulfill your request by drawing from
        /// the next cheapest pool. To ensure that your target capacity is met, you might receive
        /// Spot Instances from more than the number of pools that you specified. Similarly, if
        /// most of the pools have no Spot capacity, you might receive your full target capacity
        /// from fewer than the number of pools that you specified.
        /// </para>
        /// </summary>
        public int? InstancePoolsToUseCount
        {
            get { return this._instancePoolsToUseCount; }
            set { this._instancePoolsToUseCount = value; }
        }

        // Check to see if InstancePoolsToUseCount property is set
        internal bool IsSetInstancePoolsToUseCount()
        {
            return this._instancePoolsToUseCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaintenanceStrategies. 
        /// <para>
        /// The strategies for managing your workloads on your Spot Instances that will be interrupted.
        /// Currently only the capacity rebalance strategy is available.
        /// </para>
        /// </summary>
        public FleetSpotMaintenanceStrategies MaintenanceStrategies
        {
            get { return this._maintenanceStrategies; }
            set { this._maintenanceStrategies = value; }
        }

        // Check to see if MaintenanceStrategies property is set
        internal bool IsSetMaintenanceStrategies()
        {
            return this._maintenanceStrategies != null;
        }

        /// <summary>
        /// Gets and sets the property MaxTotalPrice. 
        /// <para>
        /// The maximum amount per hour for Spot Instances that you're willing to pay. We do not
        /// recommend using this parameter because it can lead to increased interruptions. If
        /// you do not specify this parameter, you will pay the current Spot price.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify a maximum price, your Spot Instances will be interrupted more frequently
        /// than if you do not specify this parameter.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// If your fleet includes T instances that are configured as <c>unlimited</c>, and if
        /// their average CPU usage exceeds the baseline utilization, you will incur a charge
        /// for surplus credits. The <c>maxTotalPrice</c> does not account for surplus credits,
        /// and, if you use surplus credits, your final cost might be higher than what you specified
        /// for <c>maxTotalPrice</c>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances-unlimited-mode-concepts.html#unlimited-mode-surplus-credits">Surplus
        /// credits can incur charges</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public string MaxTotalPrice
        {
            get { return this._maxTotalPrice; }
            set { this._maxTotalPrice = value; }
        }

        // Check to see if MaxTotalPrice property is set
        internal bool IsSetMaxTotalPrice()
        {
            return this._maxTotalPrice != null;
        }

        /// <summary>
        /// Gets and sets the property MinTargetCapacity. 
        /// <para>
        /// The minimum target capacity for Spot Instances in the fleet. If this minimum capacity
        /// isn't reached, no instances are launched.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum value of <c>1000</c>. Supported only for fleets of type <c>instant</c>.
        /// </para>
        ///  
        /// <para>
        /// At least one of the following must be specified: <c>SingleAvailabilityZone</c> | <c>SingleInstanceType</c>
        /// 
        /// </para>
        /// </summary>
        public int? MinTargetCapacity
        {
            get { return this._minTargetCapacity; }
            set { this._minTargetCapacity = value; }
        }

        // Check to see if MinTargetCapacity property is set
        internal bool IsSetMinTargetCapacity()
        {
            return this._minTargetCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SingleAvailabilityZone. 
        /// <para>
        /// Indicates that the fleet launches all Spot Instances into a single Availability Zone.
        /// </para>
        ///  
        /// <para>
        /// Supported only for fleets of type <c>instant</c>.
        /// </para>
        /// </summary>
        public bool? SingleAvailabilityZone
        {
            get { return this._singleAvailabilityZone; }
            set { this._singleAvailabilityZone = value; }
        }

        // Check to see if SingleAvailabilityZone property is set
        internal bool IsSetSingleAvailabilityZone()
        {
            return this._singleAvailabilityZone.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SingleInstanceType. 
        /// <para>
        /// Indicates that the fleet uses a single instance type to launch all Spot Instances
        /// in the fleet.
        /// </para>
        ///  
        /// <para>
        /// Supported only for fleets of type <c>instant</c>.
        /// </para>
        /// </summary>
        public bool? SingleInstanceType
        {
            get { return this._singleInstanceType; }
            set { this._singleInstanceType = value; }
        }

        // Check to see if SingleInstanceType property is set
        internal bool IsSetSingleInstanceType()
        {
            return this._singleInstanceType.HasValue; 
        }

    }
}