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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DocDB.Model;

#pragma warning disable CS1570
namespace Amazon.DocDB
{
    /// <summary>
    /// <para>Interface for accessing DocDB</para>
    ///
    /// Amazon DocumentDB is a fast, reliable, and fully managed database service. Amazon
    /// DocumentDB makes it easy to set up, operate, and scale MongoDB-compatible databases
    /// in the cloud. With Amazon DocumentDB, you can run the same application code and use
    /// the same drivers and tools that you use with MongoDB.
    /// </summary>
    public partial interface IAmazonDocDB : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDocDBPaginatorFactory Paginators { get; }
#endif
                
        #region  AddSourceIdentifierToSubscription



        /// <summary>
        /// Adds a source identifier to an existing event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddSourceIdentifierToSubscription service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/AddSourceIdentifierToSubscription">REST API Reference for AddSourceIdentifierToSubscription Operation</seealso>
        Task<AddSourceIdentifierToSubscriptionResponse> AddSourceIdentifierToSubscriptionAsync(AddSourceIdentifierToSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AddTagsToResource



        /// <summary>
        /// Adds metadata tags to an Amazon DocumentDB resource. You can use these tags with cost
        /// allocation reporting to track costs that are associated with Amazon DocumentDB resources
        /// or in a <c>Condition</c> statement in an Identity and Access Management (IAM) policy
        /// for Amazon DocumentDB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing instance.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ApplyPendingMaintenanceAction



        /// <summary>
        /// Applies a pending maintenance action to a resource (for example, to an Amazon DocumentDB
        /// instance).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ApplyPendingMaintenanceAction service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBInstanceStateException">
        /// The specified instance isn't in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        Task<ApplyPendingMaintenanceActionResponse> ApplyPendingMaintenanceActionAsync(ApplyPendingMaintenanceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CopyDBClusterParameterGroup



        /// <summary>
        /// Copies the specified cluster parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyDBClusterParameterGroup service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupAlreadyExistsException">
        /// A parameter group with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupQuotaExceededException">
        /// This request would cause you to exceed the allowed number of parameter groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CopyDBClusterParameterGroup">REST API Reference for CopyDBClusterParameterGroup Operation</seealso>
        Task<CopyDBClusterParameterGroupResponse> CopyDBClusterParameterGroupAsync(CopyDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CopyDBClusterSnapshot



        /// <summary>
        /// Copies a snapshot of a cluster.
        /// 
        ///  
        /// <para>
        /// To copy a cluster snapshot from a shared manual cluster snapshot, <c>SourceDBClusterSnapshotIdentifier</c>
        /// must be the Amazon Resource Name (ARN) of the shared cluster snapshot. You can only
        /// copy a shared DB cluster snapshot, whether encrypted or not, in the same Amazon Web
        /// Services Region.
        /// </para>
        ///  
        /// <para>
        /// To cancel the copy operation after it is in progress, delete the target cluster snapshot
        /// identified by <c>TargetDBClusterSnapshotIdentifier</c> while that cluster snapshot
        /// is in the <i>copying</i> status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyDBClusterSnapshot service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotAlreadyExistsException">
        /// You already have a cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterSnapshotStateException">
        /// The provided value isn't a valid cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.KMSKeyNotAccessibleException">
        /// An error occurred when accessing an KMS key.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SnapshotQuotaExceededException">
        /// The request would cause you to exceed the allowed number of snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CopyDBClusterSnapshot">REST API Reference for CopyDBClusterSnapshot Operation</seealso>
        Task<CopyDBClusterSnapshotResponse> CopyDBClusterSnapshotAsync(CopyDBClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDBCluster



        /// <summary>
        /// Creates a new Amazon DocumentDB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterAlreadyExistsException">
        /// You already have a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterParameterGroupNotFoundException">
        /// <c>DBClusterParameterGroupName</c> doesn't refer to an existing cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterQuotaExceededException">
        /// The cluster can't be created because you have reached the maximum allowed quota of
        /// clusters.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing instance.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the subnet group should cover at least two Availability Zones unless there
        /// is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InsufficientStorageClusterCapacityException">
        /// There is not enough storage available for the current action. You might be able to
        /// resolve this error by updating your subnet group to use different Availability Zones
        /// that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBInstanceStateException">
        /// The specified instance isn't in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBSubnetGroupStateException">
        /// The subnet group can't be deleted because it's in use.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidGlobalClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or multiple subnets were requested that are not
        /// all in a common virtual private cloud (VPC).
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidVPCNetworkStateException">
        /// The subnet group doesn't cover all Availability Zones after it is created because
        /// of changes that were made.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.KMSKeyNotAccessibleException">
        /// An error occurred when accessing an KMS key.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.StorageQuotaExceededException">
        /// The request would cause you to exceed the allowed amount of storage available across
        /// all instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBCluster">REST API Reference for CreateDBCluster Operation</seealso>
        Task<CreateDBClusterResponse> CreateDBClusterAsync(CreateDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDBClusterParameterGroup



        /// <summary>
        /// Creates a new cluster parameter group.
        /// 
        ///  
        /// <para>
        /// Parameters in a cluster parameter group apply to all of the instances in a cluster.
        /// </para>
        ///  
        /// <para>
        /// A cluster parameter group is initially created with the default parameters for the
        /// database engine used by instances in the cluster. In Amazon DocumentDB, you cannot
        /// make modifications directly to the <c>default.docdb3.6</c> cluster parameter group.
        /// If your Amazon DocumentDB cluster is using the default cluster parameter group and
        /// you want to modify a value in it, you must first <a href="https://docs.aws.amazon.com/documentdb/latest/developerguide/cluster_parameter_group-create.html">
        /// create a new parameter group</a> or <a href="https://docs.aws.amazon.com/documentdb/latest/developerguide/cluster_parameter_group-copy.html">
        /// copy an existing parameter group</a>, modify it, and then apply the modified parameter
        /// group to your cluster. For the new cluster parameter group and associated settings
        /// to take effect, you must then reboot the instances in the cluster without failover.
        /// For more information, see <a href="https://docs.aws.amazon.com/documentdb/latest/developerguide/cluster_parameter_group-modify.html">
        /// Modifying Amazon DocumentDB Cluster Parameter Groups</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBClusterParameterGroup service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupAlreadyExistsException">
        /// A parameter group with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupQuotaExceededException">
        /// This request would cause you to exceed the allowed number of parameter groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBClusterParameterGroup">REST API Reference for CreateDBClusterParameterGroup Operation</seealso>
        Task<CreateDBClusterParameterGroupResponse> CreateDBClusterParameterGroupAsync(CreateDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDBClusterSnapshot



        /// <summary>
        /// Creates a snapshot of a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBClusterSnapshot service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotAlreadyExistsException">
        /// You already have a cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterSnapshotStateException">
        /// The provided value isn't a valid cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SnapshotQuotaExceededException">
        /// The request would cause you to exceed the allowed number of snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBClusterSnapshot">REST API Reference for CreateDBClusterSnapshot Operation</seealso>
        Task<CreateDBClusterSnapshotResponse> CreateDBClusterSnapshotAsync(CreateDBClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDBInstance



        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBInstance service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP or Amazon EC2 security group isn't authorized for the specified
        /// security group.
        /// 
        ///  
        /// <para>
        /// Amazon DocumentDB also might not be authorized to perform necessary actions on your
        /// behalf using IAM.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceAlreadyExistsException">
        /// You already have a instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing security group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the subnet group should cover at least two Availability Zones unless there
        /// is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InstanceQuotaExceededException">
        /// The request would cause you to exceed the allowed number of instances.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InsufficientDBInstanceCapacityException">
        /// The specified instance class isn't available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or multiple subnets were requested that are not
        /// all in a common virtual private cloud (VPC).
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidVPCNetworkStateException">
        /// The subnet group doesn't cover all Availability Zones after it is created because
        /// of changes that were made.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.KMSKeyNotAccessibleException">
        /// An error occurred when accessing an KMS key.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.StorageQuotaExceededException">
        /// The request would cause you to exceed the allowed amount of storage available across
        /// all instances.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.StorageTypeNotSupportedException">
        /// Storage of the specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBInstance">REST API Reference for CreateDBInstance Operation</seealso>
        Task<CreateDBInstanceResponse> CreateDBInstanceAsync(CreateDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDBSubnetGroup



        /// <summary>
        /// Creates a new subnet group. subnet groups must contain at least one subnet in at least
        /// two Availability Zones in the Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBSubnetGroup service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupAlreadyExistsException">
        /// <c>DBSubnetGroupName</c> is already being used by an existing subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the subnet group should cover at least two Availability Zones unless there
        /// is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupQuotaExceededException">
        /// The request would cause you to exceed the allowed number of subnet groups.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetQuotaExceededException">
        /// The request would cause you to exceed the allowed number of subnets in a subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or multiple subnets were requested that are not
        /// all in a common virtual private cloud (VPC).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBSubnetGroup">REST API Reference for CreateDBSubnetGroup Operation</seealso>
        Task<CreateDBSubnetGroupResponse> CreateDBSubnetGroupAsync(CreateDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEventSubscription



        /// <summary>
        /// Creates an Amazon DocumentDB event notification subscription. This action requires
        /// a topic Amazon Resource Name (ARN) created by using the Amazon DocumentDB console,
        /// the Amazon SNS console, or the Amazon SNS API. To obtain an ARN with Amazon SNS, you
        /// must create a topic in Amazon SNS and subscribe to the topic. The ARN is displayed
        /// in the Amazon SNS console.
        /// 
        ///  
        /// <para>
        /// You can specify the type of source (<c>SourceType</c>) that you want to be notified
        /// of. You can also provide a list of Amazon DocumentDB sources (<c>SourceIds</c>) that
        /// trigger the events, and you can provide a list of event categories (<c>EventCategories</c>)
        /// for events that you want to be notified of. For example, you can specify <c>SourceType
        /// = db-instance</c>, <c>SourceIds = mydbinstance1, mydbinstance2</c> and <c>EventCategories
        /// = Availability, Backup</c>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both the <c>SourceType</c> and <c>SourceIds</c> (such as <c>SourceType
        /// = db-instance</c> and <c>SourceIdentifier = myDBInstance1</c>), you are notified of
        /// all the <c>db-instance</c> events for the specified source. If you specify a <c>SourceType</c>
        /// but do not specify a <c>SourceIdentifier</c>, you receive notice of the events for
        /// that source type for all your Amazon DocumentDB sources. If you do not specify either
        /// the <c>SourceType</c> or the <c>SourceIdentifier</c>, you are notified of events generated
        /// from all Amazon DocumentDB sources belonging to your customer account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.EventSubscriptionQuotaExceededException">
        /// You have reached the maximum number of event subscriptions.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SNSInvalidTopicException">
        /// Amazon SNS has responded that there is a problem with the specified topic.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the SNS topic Amazon Resource Name (ARN).
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SNSTopicArnNotFoundException">
        /// The SNS topic Amazon Resource Name (ARN) does not exist.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SubscriptionAlreadyExistException">
        /// The provided subscription name already exists.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SubscriptionCategoryNotFoundException">
        /// The provided category does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGlobalCluster



        /// <summary>
        /// Creates an Amazon DocumentDB global cluster that can span multiple multiple Amazon
        /// Web Services Regions. The global cluster contains one primary cluster with read-write
        /// capability, and up-to give read-only secondary clusters. Global clusters uses storage-based
        /// fast replication across regions with latencies less than one second, using dedicated
        /// infrastructure with no impact to your workload’s performance.
        /// 
        ///   
        /// <para>
        /// You can create a global cluster that is initially empty, and then add a primary and
        /// a secondary to it. Or you can specify an existing cluster during the create operation,
        /// and this cluster becomes the primary of the global cluster. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Amazon DocumentDB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGlobalCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.GlobalClusterAlreadyExistsException">
        /// The <c>GlobalClusterIdentifier</c> already exists. Choose a new global cluster identifier
        /// (unique name) to create a new global cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.GlobalClusterQuotaExceededException">
        /// The number of global clusters for this account is already at the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateGlobalCluster">REST API Reference for CreateGlobalCluster Operation</seealso>
        Task<CreateGlobalClusterResponse> CreateGlobalClusterAsync(CreateGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDBCluster



        /// <summary>
        /// Deletes a previously provisioned cluster. When you delete a cluster, all automated
        /// backups for that cluster are deleted and can't be recovered. Manual DB cluster snapshots
        /// of the specified cluster are not deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotAlreadyExistsException">
        /// You already have a cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterSnapshotStateException">
        /// The provided value isn't a valid cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SnapshotQuotaExceededException">
        /// The request would cause you to exceed the allowed number of snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBCluster">REST API Reference for DeleteDBCluster Operation</seealso>
        Task<DeleteDBClusterResponse> DeleteDBClusterAsync(DeleteDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDBClusterParameterGroup



        /// <summary>
        /// Deletes a specified cluster parameter group. The cluster parameter group to be deleted
        /// can't be associated with any clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBClusterParameterGroup service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBParameterGroupStateException">
        /// The parameter group is in use, or it is in a state that is not valid. If you are trying
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBClusterParameterGroup">REST API Reference for DeleteDBClusterParameterGroup Operation</seealso>
        Task<DeleteDBClusterParameterGroupResponse> DeleteDBClusterParameterGroupAsync(DeleteDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDBClusterSnapshot



        /// <summary>
        /// Deletes a cluster snapshot. If the snapshot is being copied, the copy operation is
        /// terminated.
        /// 
        ///  <note> 
        /// <para>
        /// The cluster snapshot must be in the <c>available</c> state to be deleted.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBClusterSnapshot service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterSnapshotStateException">
        /// The provided value isn't a valid cluster snapshot state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBClusterSnapshot">REST API Reference for DeleteDBClusterSnapshot Operation</seealso>
        Task<DeleteDBClusterSnapshotResponse> DeleteDBClusterSnapshotAsync(DeleteDBClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDBInstance



        /// <summary>
        /// Deletes a previously provisioned instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBInstance service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing instance.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSnapshotAlreadyExistsException">
        /// <c>DBSnapshotIdentifier</c> is already being used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBInstanceStateException">
        /// The specified instance isn't in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SnapshotQuotaExceededException">
        /// The request would cause you to exceed the allowed number of snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBInstance">REST API Reference for DeleteDBInstance Operation</seealso>
        Task<DeleteDBInstanceResponse> DeleteDBInstanceAsync(DeleteDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDBSubnetGroup



        /// <summary>
        /// Deletes a subnet group.
        /// 
        ///  <note> 
        /// <para>
        /// The specified database subnet group must not be associated with any DB instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBSubnetGroup service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBSubnetGroupStateException">
        /// The subnet group can't be deleted because it's in use.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBSubnetStateException">
        /// The subnet isn't in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBSubnetGroup">REST API Reference for DeleteDBSubnetGroup Operation</seealso>
        Task<DeleteDBSubnetGroupResponse> DeleteDBSubnetGroupAsync(DeleteDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEventSubscription



        /// <summary>
        /// Deletes an Amazon DocumentDB event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.InvalidEventSubscriptionStateException">
        /// Someone else might be modifying a subscription. Wait a few seconds, and try again.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGlobalCluster



        /// <summary>
        /// Deletes a global cluster. The primary and secondary clusters must already be detached
        /// or deleted before attempting to delete a global cluster.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Amazon DocumentDB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGlobalCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidGlobalClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteGlobalCluster">REST API Reference for DeleteGlobalCluster Operation</seealso>
        Task<DeleteGlobalClusterResponse> DeleteGlobalClusterAsync(DeleteGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCertificates



        /// <summary>
        /// Returns a list of certificate authority (CA) certificates provided by Amazon DocumentDB
        /// for this Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCertificates service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.CertificateNotFoundException">
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        Task<DescribeCertificatesResponse> DescribeCertificatesAsync(DescribeCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBClusterParameterGroups



        /// <summary>
        /// Returns a list of <c>DBClusterParameterGroup</c> descriptions. If a <c>DBClusterParameterGroupName</c>
        /// parameter is specified, the list contains only the description of the specified cluster
        /// parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameterGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameterGroups service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusterParameterGroups">REST API Reference for DescribeDBClusterParameterGroups Operation</seealso>
        Task<DescribeDBClusterParameterGroupsResponse> DescribeDBClusterParameterGroupsAsync(DescribeDBClusterParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBClusterParameters



        /// <summary>
        /// Returns the detailed parameter list for a particular cluster parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameters service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusterParameters">REST API Reference for DescribeDBClusterParameters Operation</seealso>
        Task<DescribeDBClusterParametersResponse> DescribeDBClusterParametersAsync(DescribeDBClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBClusters



        /// <summary>
        /// Returns information about provisioned Amazon DocumentDB clusters. This API operation
        /// supports pagination. For certain management features such as cluster and instance
        /// lifecycle management, Amazon DocumentDB leverages operational technology that is shared
        /// with Amazon RDS and Amazon Neptune. Use the <c>filterName=engine,Values=docdb</c>
        /// filter parameter to return only Amazon DocumentDB clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusters service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusters">REST API Reference for DescribeDBClusters Operation</seealso>
        Task<DescribeDBClustersResponse> DescribeDBClustersAsync(DescribeDBClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBClusterSnapshotAttributes



        /// <summary>
        /// Returns a list of cluster snapshot attribute names and values for a manual DB cluster
        /// snapshot.
        /// 
        ///  
        /// <para>
        /// When you share snapshots with other Amazon Web Services accounts, <c>DescribeDBClusterSnapshotAttributes</c>
        /// returns the <c>restore</c> attribute and a list of IDs for the Amazon Web Services
        /// accounts that are authorized to copy or restore the manual cluster snapshot. If <c>all</c>
        /// is included in the list of values for the <c>restore</c> attribute, then the manual
        /// cluster snapshot is public and can be copied or restored by all Amazon Web Services
        /// accounts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshotAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshotAttributes service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing cluster snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusterSnapshotAttributes">REST API Reference for DescribeDBClusterSnapshotAttributes Operation</seealso>
        Task<DescribeDBClusterSnapshotAttributesResponse> DescribeDBClusterSnapshotAttributesAsync(DescribeDBClusterSnapshotAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBClusterSnapshots



        /// <summary>
        /// Returns information about cluster snapshots. This API operation supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshots service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing cluster snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusterSnapshots">REST API Reference for DescribeDBClusterSnapshots Operation</seealso>
        Task<DescribeDBClusterSnapshotsResponse> DescribeDBClusterSnapshotsAsync(DescribeDBClusterSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBEngineVersions



        /// <summary>
        /// Returns a list of the available engines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        Task<DescribeDBEngineVersionsResponse> DescribeDBEngineVersionsAsync(DescribeDBEngineVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBInstances



        /// <summary>
        /// Returns information about provisioned Amazon DocumentDB instances. This API supports
        /// pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(DescribeDBInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBSubnetGroups



        /// <summary>
        /// Returns a list of <c>DBSubnetGroup</c> descriptions. If a <c>DBSubnetGroupName</c>
        /// is specified, the list will contain only the descriptions of the specified <c>DBSubnetGroup</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSubnetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        Task<DescribeDBSubnetGroupsResponse> DescribeDBSubnetGroupsAsync(DescribeDBSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEngineDefaultClusterParameters



        /// <summary>
        /// Returns the default engine and system parameter information for the cluster database
        /// engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultClusterParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultClusterParameters service method, as returned by DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeEngineDefaultClusterParameters">REST API Reference for DescribeEngineDefaultClusterParameters Operation</seealso>
        Task<DescribeEngineDefaultClusterParametersResponse> DescribeEngineDefaultClusterParametersAsync(DescribeEngineDefaultClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEventCategories



        /// <summary>
        /// Displays a list of categories for all event source types, or, if specified, for a
        /// specified source type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEvents



        /// <summary>
        /// Returns events related to instances, security groups, snapshots, and DB parameter
        /// groups for the past 14 days. You can obtain events specific to a particular DB instance,
        /// security group, snapshot, or parameter group by providing the name as a parameter.
        /// By default, the events of the past hour are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEventSubscriptions



        /// <summary>
        /// Lists all the subscription descriptions for a customer account. The description for
        /// a subscription includes <c>SubscriptionName</c>, <c>SNSTopicARN</c>, <c>CustomerID</c>,
        /// <c>SourceType</c>, <c>SourceID</c>, <c>CreationTime</c>, and <c>Status</c>.
        /// 
        ///  
        /// <para>
        /// If you specify a <c>SubscriptionName</c>, lists the description for that subscription.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeGlobalClusters



        /// <summary>
        /// Returns information about Amazon DocumentDB global clusters. This API supports pagination.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Amazon DocumentDB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGlobalClusters service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeGlobalClusters">REST API Reference for DescribeGlobalClusters Operation</seealso>
        Task<DescribeGlobalClustersResponse> DescribeGlobalClustersAsync(DescribeGlobalClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeOrderableDBInstanceOptions



        /// <summary>
        /// Returns a list of orderable instance options for the specified engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrderableDBInstanceOptions service method, as returned by DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeOrderableDBInstanceOptions">REST API Reference for DescribeOrderableDBInstanceOptions Operation</seealso>
        Task<DescribeOrderableDBInstanceOptionsResponse> DescribeOrderableDBInstanceOptionsAsync(DescribeOrderableDBInstanceOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePendingMaintenanceActions



        /// <summary>
        /// Returns a list of resources (for example, instances) that have at least one pending
        /// maintenance action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingMaintenanceActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePendingMaintenanceActions service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        Task<DescribePendingMaintenanceActionsResponse> DescribePendingMaintenanceActionsAsync(DescribePendingMaintenanceActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  FailoverDBCluster



        /// <summary>
        /// Forces a failover for a cluster.
        /// 
        ///  
        /// <para>
        /// A failover for a cluster promotes one of the Amazon DocumentDB replicas (read-only
        /// instances) in the cluster to be the primary instance (the cluster writer).
        /// </para>
        ///  
        /// <para>
        /// If the primary instance fails, Amazon DocumentDB automatically fails over to an Amazon
        /// DocumentDB replica, if one exists. You can force a failover when you want to simulate
        /// a failure of a primary instance for testing.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FailoverDBCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBInstanceStateException">
        /// The specified instance isn't in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/FailoverDBCluster">REST API Reference for FailoverDBCluster Operation</seealso>
        Task<FailoverDBClusterResponse> FailoverDBClusterAsync(FailoverDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  FailoverGlobalCluster



        /// <summary>
        /// Promotes the specified secondary DB cluster to be the primary DB cluster in the global
        /// cluster when failing over a global cluster occurs.
        /// 
        ///  
        /// <para>
        /// Use this operation to respond to an unplanned event, such as a regional disaster in
        /// the primary region. Failing over can result in a loss of write transaction data that
        /// wasn't replicated to the chosen secondary before the failover event occurred. However,
        /// the recovery process that promotes a DB instance on the chosen seconday DB cluster
        /// to be the primary writer DB instance guarantees that the data is in a transactionally
        /// consistent state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FailoverGlobalCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidGlobalClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/FailoverGlobalCluster">REST API Reference for FailoverGlobalCluster Operation</seealso>
        Task<FailoverGlobalClusterResponse> FailoverGlobalClusterAsync(FailoverGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists all tags on an Amazon DocumentDB resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing instance.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyDBCluster



        /// <summary>
        /// Modifies a setting for an Amazon DocumentDB cluster. You can change one or more database
        /// configuration parameters by specifying these parameters and the new values in the
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterAlreadyExistsException">
        /// You already have a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterParameterGroupNotFoundException">
        /// <c>DBClusterParameterGroupName</c> doesn't refer to an existing cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBInstanceStateException">
        /// The specified instance isn't in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBSecurityGroupStateException">
        /// The state of the security group doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBSubnetGroupStateException">
        /// The subnet group can't be deleted because it's in use.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or multiple subnets were requested that are not
        /// all in a common virtual private cloud (VPC).
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidVPCNetworkStateException">
        /// The subnet group doesn't cover all Availability Zones after it is created because
        /// of changes that were made.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.StorageQuotaExceededException">
        /// The request would cause you to exceed the allowed amount of storage available across
        /// all instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBCluster">REST API Reference for ModifyDBCluster Operation</seealso>
        Task<ModifyDBClusterResponse> ModifyDBClusterAsync(ModifyDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyDBClusterParameterGroup



        /// <summary>
        /// Modifies the parameters of a cluster parameter group. To modify more than one parameter,
        /// submit a list of the following: <c>ParameterName</c>, <c>ParameterValue</c>, and <c>ApplyMethod</c>.
        /// A maximum of 20 parameters can be modified in a single request. 
        /// 
        ///  <note> 
        /// <para>
        /// Changes to dynamic parameters are applied immediately. Changes to static parameters
        /// require a reboot or maintenance window before the change can take effect.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// After you create a cluster parameter group, you should wait at least 5 minutes before
        /// creating your first cluster that uses that cluster parameter group as the default
        /// parameter group. This allows Amazon DocumentDB to fully complete the create action
        /// before the parameter group is used as the default for a new cluster. This step is
        /// especially important for parameters that are critical when creating the default database
        /// for a cluster, such as the character set for the default database defined by the <c>character_set_database</c>
        /// parameter.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBClusterParameterGroup service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBParameterGroupStateException">
        /// The parameter group is in use, or it is in a state that is not valid. If you are trying
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBClusterParameterGroup">REST API Reference for ModifyDBClusterParameterGroup Operation</seealso>
        Task<ModifyDBClusterParameterGroupResponse> ModifyDBClusterParameterGroupAsync(ModifyDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyDBClusterSnapshotAttribute



        /// <summary>
        /// Adds an attribute and values to, or removes an attribute and values from, a manual
        /// cluster snapshot.
        /// 
        ///  
        /// <para>
        /// To share a manual cluster snapshot with other Amazon Web Services accounts, specify
        /// <c>restore</c> as the <c>AttributeName</c>, and use the <c>ValuesToAdd</c> parameter
        /// to add a list of IDs of the Amazon Web Services accounts that are authorized to restore
        /// the manual cluster snapshot. Use the value <c>all</c> to make the manual cluster snapshot
        /// public, which means that it can be copied or restored by all Amazon Web Services accounts.
        /// Do not add the <c>all</c> value for any manual cluster snapshots that contain private
        /// information that you don't want available to all Amazon Web Services accounts. If
        /// a manual cluster snapshot is encrypted, it can be shared, but only by specifying a
        /// list of authorized Amazon Web Services account IDs for the <c>ValuesToAdd</c> parameter.
        /// You can't use <c>all</c> as a value for that parameter in this case.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterSnapshotAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBClusterSnapshotAttribute service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterSnapshotStateException">
        /// The provided value isn't a valid cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SharedSnapshotQuotaExceededException">
        /// You have exceeded the maximum number of accounts that you can share a manual DB snapshot
        /// with.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBClusterSnapshotAttribute">REST API Reference for ModifyDBClusterSnapshotAttribute Operation</seealso>
        Task<ModifyDBClusterSnapshotAttributeResponse> ModifyDBClusterSnapshotAttributeAsync(ModifyDBClusterSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyDBInstance



        /// <summary>
        /// Modifies settings for an instance. You can change one or more database configuration
        /// parameters by specifying these parameters and the new values in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBInstance service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP or Amazon EC2 security group isn't authorized for the specified
        /// security group.
        /// 
        ///  
        /// <para>
        /// Amazon DocumentDB also might not be authorized to perform necessary actions on your
        /// behalf using IAM.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.CertificateNotFoundException">
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceAlreadyExistsException">
        /// You already have a instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing instance.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing security group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBUpgradeDependencyFailureException">
        /// The upgrade failed because a resource that the depends on can't be modified.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InsufficientDBInstanceCapacityException">
        /// The specified instance class isn't available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBInstanceStateException">
        /// The specified instance isn't in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBSecurityGroupStateException">
        /// The state of the security group doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidVPCNetworkStateException">
        /// The subnet group doesn't cover all Availability Zones after it is created because
        /// of changes that were made.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.StorageQuotaExceededException">
        /// The request would cause you to exceed the allowed amount of storage available across
        /// all instances.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.StorageTypeNotSupportedException">
        /// Storage of the specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBInstance">REST API Reference for ModifyDBInstance Operation</seealso>
        Task<ModifyDBInstanceResponse> ModifyDBInstanceAsync(ModifyDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyDBSubnetGroup



        /// <summary>
        /// Modifies an existing subnet group. subnet groups must contain at least one subnet
        /// in at least two Availability Zones in the Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBSubnetGroup service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the subnet group should cover at least two Availability Zones unless there
        /// is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetQuotaExceededException">
        /// The request would cause you to exceed the allowed number of subnets in a subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or multiple subnets were requested that are not
        /// all in a common virtual private cloud (VPC).
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SubnetAlreadyInUseException">
        /// The subnet is already in use in the Availability Zone.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBSubnetGroup">REST API Reference for ModifyDBSubnetGroup Operation</seealso>
        Task<ModifyDBSubnetGroupResponse> ModifyDBSubnetGroupAsync(ModifyDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyEventSubscription



        /// <summary>
        /// Modifies an existing Amazon DocumentDB event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.EventSubscriptionQuotaExceededException">
        /// You have reached the maximum number of event subscriptions.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SNSInvalidTopicException">
        /// Amazon SNS has responded that there is a problem with the specified topic.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the SNS topic Amazon Resource Name (ARN).
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SNSTopicArnNotFoundException">
        /// The SNS topic Amazon Resource Name (ARN) does not exist.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SubscriptionCategoryNotFoundException">
        /// The provided category does not exist.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyGlobalCluster



        /// <summary>
        /// Modify a setting for an Amazon DocumentDB global cluster. You can change one or more
        /// configuration parameters (for example: deletion protection), or the global cluster
        /// identifier by specifying these parameters and the new values in the request.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Amazon DocumentDB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyGlobalCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidGlobalClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyGlobalCluster">REST API Reference for ModifyGlobalCluster Operation</seealso>
        Task<ModifyGlobalClusterResponse> ModifyGlobalClusterAsync(ModifyGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RebootDBInstance



        /// <summary>
        /// You might need to reboot your instance, usually for maintenance reasons. For example,
        /// if you make certain changes, or if you change the cluster parameter group that is
        /// associated with the instance, you must reboot the instance for the changes to take
        /// effect. 
        /// 
        ///  
        /// <para>
        /// Rebooting an instance restarts the database engine service. Rebooting an instance
        /// results in a momentary outage, during which the instance status is set to <i>rebooting</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootDBInstance service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing instance.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBInstanceStateException">
        /// The specified instance isn't in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RebootDBInstance">REST API Reference for RebootDBInstance Operation</seealso>
        Task<RebootDBInstanceResponse> RebootDBInstanceAsync(RebootDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveFromGlobalCluster



        /// <summary>
        /// Detaches an Amazon DocumentDB secondary cluster from a global cluster. The cluster
        /// becomes a standalone cluster with read-write capability instead of being read-only
        /// and receiving data from a primary in a different region. 
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Amazon DocumentDB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFromGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveFromGlobalCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidGlobalClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RemoveFromGlobalCluster">REST API Reference for RemoveFromGlobalCluster Operation</seealso>
        Task<RemoveFromGlobalClusterResponse> RemoveFromGlobalClusterAsync(RemoveFromGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveSourceIdentifierFromSubscription



        /// <summary>
        /// Removes a source identifier from an existing Amazon DocumentDB event notification
        /// subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveSourceIdentifierFromSubscription service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RemoveSourceIdentifierFromSubscription">REST API Reference for RemoveSourceIdentifierFromSubscription Operation</seealso>
        Task<RemoveSourceIdentifierFromSubscriptionResponse> RemoveSourceIdentifierFromSubscriptionAsync(RemoveSourceIdentifierFromSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveTagsFromResource



        /// <summary>
        /// Removes metadata tags from an Amazon DocumentDB resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing instance.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetDBClusterParameterGroup



        /// <summary>
        /// Modifies the parameters of a cluster parameter group to the default value. To reset
        /// specific parameters, submit a list of the following: <c>ParameterName</c> and <c>ApplyMethod</c>.
        /// To reset the entire cluster parameter group, specify the <c>DBClusterParameterGroupName</c>
        /// and <c>ResetAllParameters</c> parameters. 
        /// 
        ///  
        /// <para>
        ///  When you reset the entire group, dynamic parameters are updated immediately and static
        /// parameters are set to <c>pending-reboot</c> to take effect on the next DB instance
        /// reboot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDBClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetDBClusterParameterGroup service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBParameterGroupStateException">
        /// The parameter group is in use, or it is in a state that is not valid. If you are trying
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ResetDBClusterParameterGroup">REST API Reference for ResetDBClusterParameterGroup Operation</seealso>
        Task<ResetDBClusterParameterGroupResponse> ResetDBClusterParameterGroupAsync(ResetDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreDBClusterFromSnapshot



        /// <summary>
        /// Creates a new cluster from a snapshot or cluster snapshot.
        /// 
        ///  
        /// <para>
        /// If a snapshot is specified, the target cluster is created from the source DB snapshot
        /// with a default configuration and default security group.
        /// </para>
        ///  
        /// <para>
        /// If a cluster snapshot is specified, the target cluster is created from the source
        /// cluster restore point with the same configuration as the original source DB cluster,
        /// except that the new cluster is created with the default security group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreDBClusterFromSnapshot service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterAlreadyExistsException">
        /// You already have a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterQuotaExceededException">
        /// The cluster can't be created because you have reached the maximum allowed quota of
        /// clusters.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InsufficientDBClusterCapacityException">
        /// The cluster doesn't have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InsufficientStorageClusterCapacityException">
        /// There is not enough storage available for the current action. You might be able to
        /// resolve this error by updating your subnet group to use different Availability Zones
        /// that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterSnapshotStateException">
        /// The provided value isn't a valid cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBSnapshotStateException">
        /// The state of the snapshot doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidRestoreException">
        /// You cannot restore from a virtual private cloud (VPC) backup to a non-VPC DB instance.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or multiple subnets were requested that are not
        /// all in a common virtual private cloud (VPC).
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidVPCNetworkStateException">
        /// The subnet group doesn't cover all Availability Zones after it is created because
        /// of changes that were made.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.KMSKeyNotAccessibleException">
        /// An error occurred when accessing an KMS key.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.StorageQuotaExceededException">
        /// The request would cause you to exceed the allowed amount of storage available across
        /// all instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RestoreDBClusterFromSnapshot">REST API Reference for RestoreDBClusterFromSnapshot Operation</seealso>
        Task<RestoreDBClusterFromSnapshotResponse> RestoreDBClusterFromSnapshotAsync(RestoreDBClusterFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreDBClusterToPointInTime



        /// <summary>
        /// Restores a cluster to an arbitrary point in time. Users can restore to any point in
        /// time before <c>LatestRestorableTime</c> for up to <c>BackupRetentionPeriod</c> days.
        /// The target cluster is created from the source cluster with the same configuration
        /// as the original cluster, except that the new cluster is created with the default security
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterToPointInTime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreDBClusterToPointInTime service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterAlreadyExistsException">
        /// You already have a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterQuotaExceededException">
        /// The cluster can't be created because you have reached the maximum allowed quota of
        /// clusters.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InsufficientDBClusterCapacityException">
        /// The cluster doesn't have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InsufficientStorageClusterCapacityException">
        /// There is not enough storage available for the current action. You might be able to
        /// resolve this error by updating your subnet group to use different Availability Zones
        /// that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterSnapshotStateException">
        /// The provided value isn't a valid cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBSnapshotStateException">
        /// The state of the snapshot doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidRestoreException">
        /// You cannot restore from a virtual private cloud (VPC) backup to a non-VPC DB instance.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or multiple subnets were requested that are not
        /// all in a common virtual private cloud (VPC).
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidVPCNetworkStateException">
        /// The subnet group doesn't cover all Availability Zones after it is created because
        /// of changes that were made.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.KMSKeyNotAccessibleException">
        /// An error occurred when accessing an KMS key.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.StorageQuotaExceededException">
        /// The request would cause you to exceed the allowed amount of storage available across
        /// all instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RestoreDBClusterToPointInTime">REST API Reference for RestoreDBClusterToPointInTime Operation</seealso>
        Task<RestoreDBClusterToPointInTimeResponse> RestoreDBClusterToPointInTimeAsync(RestoreDBClusterToPointInTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartDBCluster



        /// <summary>
        /// Restarts the stopped cluster that is specified by <c>DBClusterIdentifier</c>. For
        /// more information, see <a href="https://docs.aws.amazon.com/documentdb/latest/developerguide/db-cluster-stop-start.html">Stopping
        /// and Starting an Amazon DocumentDB Cluster</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDBCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBInstanceStateException">
        /// The specified instance isn't in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/StartDBCluster">REST API Reference for StartDBCluster Operation</seealso>
        Task<StartDBClusterResponse> StartDBClusterAsync(StartDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopDBCluster



        /// <summary>
        /// Stops the running cluster that is specified by <c>DBClusterIdentifier</c>. The cluster
        /// must be in the <i>available</i> state. For more information, see <a href="https://docs.aws.amazon.com/documentdb/latest/developerguide/db-cluster-stop-start.html">Stopping
        /// and Starting an Amazon DocumentDB Cluster</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDBCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBInstanceStateException">
        /// The specified instance isn't in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/StopDBCluster">REST API Reference for StopDBCluster Operation</seealso>
        Task<StopDBClusterResponse> StopDBClusterAsync(StopDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SwitchoverGlobalCluster



        /// <summary>
        /// Switches over the specified secondary Amazon DocumentDB cluster to be the new primary
        /// Amazon DocumentDB cluster in the global database cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwitchoverGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SwitchoverGlobalCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidGlobalClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/SwitchoverGlobalCluster">REST API Reference for SwitchoverGlobalCluster Operation</seealso>
        Task<SwitchoverGlobalClusterResponse> SwitchoverGlobalClusterAsync(SwitchoverGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonDocDBConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonDocDBConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonDocDBConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonDocDBConfig to create AmazonDocDBClient");
            }

            return awsCredentials == null ? 
                    new AmazonDocDBClient(serviceClientConfig) :
                    new AmazonDocDBClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}