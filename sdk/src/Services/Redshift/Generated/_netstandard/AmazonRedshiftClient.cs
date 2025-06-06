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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Redshift.Model;
using Amazon.Redshift.Model.Internal.MarshallTransformations;
using Amazon.Redshift.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Redshift
{
    /// <summary>
    /// <para>Implementation for accessing Redshift</para>
    ///
    /// Amazon Redshift 
    /// <para>
    ///  <b>Overview</b> 
    /// </para>
    ///  
    /// <para>
    /// This is an interface reference for Amazon Redshift. It contains documentation for
    /// one of the programming or command line interfaces you can use to manage Amazon Redshift
    /// clusters. Note that Amazon Redshift is asynchronous, which means that some interfaces
    /// may require techniques, such as polling or asynchronous callback handlers, to determine
    /// when a command has been applied. In this reference, the parameter descriptions indicate
    /// whether a change is applied immediately, on the next instance reboot, or during the
    /// next maintenance window. For a summary of the Amazon Redshift cluster management interfaces,
    /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/using-aws-sdk.html">Using
    /// the Amazon Redshift Management Interfaces</a>.
    /// </para>
    ///  
    /// <para>
    /// Amazon Redshift manages all the work of setting up, operating, and scaling a data
    /// warehouse: provisioning capacity, monitoring and backing up the cluster, and applying
    /// patches and upgrades to the Amazon Redshift engine. You can focus on using your data
    /// to acquire new insights for your business and customers.
    /// </para>
    ///  
    /// <para>
    /// If you are a first-time user of Amazon Redshift, we recommend that you begin by reading
    /// the <a href="https://docs.aws.amazon.com/redshift/latest/gsg/getting-started.html">Amazon
    /// Redshift Getting Started Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// If you are a database developer, the <a href="https://docs.aws.amazon.com/redshift/latest/dg/welcome.html">Amazon
    /// Redshift Database Developer Guide</a> explains how to design, build, query, and maintain
    /// the databases that make up your data warehouse. 
    /// </para>
    /// </summary>
    public partial class AmazonRedshiftClient : AmazonServiceClient, IAmazonRedshift
    {
        private static IServiceMetadata serviceMetadata = new AmazonRedshiftMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonRedshiftClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonRedshiftClient()
            : base(new AmazonRedshiftConfig()) { }

        /// <summary>
        /// Constructs AmazonRedshiftClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftClient(RegionEndpoint region)
            : base(new AmazonRedshiftConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRedshiftClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(AmazonRedshiftConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRedshiftClient(AWSCredentials credentials)
            : this(credentials, new AmazonRedshiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRedshiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Credentials and an
        /// AmazonRedshiftClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(AWSCredentials credentials, AmazonRedshiftConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRedshiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRedshiftConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRedshiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRedshiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IRedshiftPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRedshiftPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new RedshiftPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRedshiftEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRedshiftAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AcceptReservedNodeExchange

        internal virtual AcceptReservedNodeExchangeResponse AcceptReservedNodeExchange(AcceptReservedNodeExchangeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptReservedNodeExchangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptReservedNodeExchangeResponseUnmarshaller.Instance;

            return Invoke<AcceptReservedNodeExchangeResponse>(request, options);
        }



        /// <summary>
        /// Exchanges a DC1 Reserved Node for a DC2 Reserved Node with no changes to the configuration
        /// (term, payment type, or number of nodes) and no additional costs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptReservedNodeExchange service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptReservedNodeExchange service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidReservedNodeStateException">
        /// Indicates that the Reserved Node being exchanged is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyMigratedException">
        /// Indicates that the reserved node has already been exchanged.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AcceptReservedNodeExchange">REST API Reference for AcceptReservedNodeExchange Operation</seealso>
        public virtual Task<AcceptReservedNodeExchangeResponse> AcceptReservedNodeExchangeAsync(AcceptReservedNodeExchangeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptReservedNodeExchangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptReservedNodeExchangeResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptReservedNodeExchangeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddPartner

        internal virtual AddPartnerResponse AddPartner(AddPartnerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddPartnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPartnerResponseUnmarshaller.Instance;

            return Invoke<AddPartnerResponse>(request, options);
        }



        /// <summary>
        /// Adds a partner integration to a cluster. This operation authorizes a partner to push
        /// status updates for the specified database. To complete the integration, you also set
        /// up the integration on the partner website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPartner service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddPartner service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.PartnerNotFoundException">
        /// The name of the partner was not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedPartnerIntegrationException">
        /// The partner integration is not authorized.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AddPartner">REST API Reference for AddPartner Operation</seealso>
        public virtual Task<AddPartnerResponse> AddPartnerAsync(AddPartnerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddPartnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPartnerResponseUnmarshaller.Instance;

            return InvokeAsync<AddPartnerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateDataShareConsumer

        internal virtual AssociateDataShareConsumerResponse AssociateDataShareConsumer(AssociateDataShareConsumerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDataShareConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDataShareConsumerResponseUnmarshaller.Instance;

            return Invoke<AssociateDataShareConsumerResponse>(request, options);
        }



        /// <summary>
        /// From a datashare consumer account, associates a datashare with the account (AssociateEntireAccount)
        /// or the specified namespace (ConsumerArn). If you make this association, the consumer
        /// can consume the datashare.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDataShareConsumer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateDataShareConsumer service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidDataShareException">
        /// There is an error with the datashare.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidNamespaceException">
        /// The namespace isn't valid because the namespace doesn't exist. Provide a valid namespace.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AssociateDataShareConsumer">REST API Reference for AssociateDataShareConsumer Operation</seealso>
        public virtual Task<AssociateDataShareConsumerResponse> AssociateDataShareConsumerAsync(AssociateDataShareConsumerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDataShareConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDataShareConsumerResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDataShareConsumerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AuthorizeClusterSecurityGroupIngress

        internal virtual AuthorizeClusterSecurityGroupIngressResponse AuthorizeClusterSecurityGroupIngress(AuthorizeClusterSecurityGroupIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeClusterSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeClusterSecurityGroupIngressResponse>(request, options);
        }



        /// <summary>
        /// Adds an inbound (ingress) rule to an Amazon Redshift security group. Depending on
        /// whether the application accessing your cluster is running on the Internet or an Amazon
        /// EC2 instance, you can authorize inbound access to either a Classless Interdomain Routing
        /// (CIDR)/Internet Protocol (IP) range or to an Amazon EC2 security group. You can add
        /// as many as 20 ingress rules to an Amazon Redshift security group.
        /// 
        ///  
        /// <para>
        /// If you authorize access to an Amazon EC2 security group, specify <i>EC2SecurityGroupName</i>
        /// and <i>EC2SecurityGroupOwnerId</i>. The Amazon EC2 security group and Amazon Redshift
        /// cluster must be in the same Amazon Web Services Region. 
        /// </para>
        ///  
        /// <para>
        /// If you authorize access to a CIDR/IP address range, specify <i>CIDRIP</i>. For an
        /// overview of CIDR blocks, see the Wikipedia article on <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
        /// Inter-Domain Routing</a>. 
        /// </para>
        ///  
        /// <para>
        /// You must also associate the security group with a cluster so that clients running
        /// on these IP addresses or the EC2 instance are authorized to connect to the cluster.
        /// For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Working
        /// with Security Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClusterSecurityGroupIngress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AuthorizeClusterSecurityGroupIngress service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationAlreadyExistsException">
        /// The specified CIDR block or EC2 security group is already authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationQuotaExceededException">
        /// The authorization quota for the cluster security group has been reached.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <c>available</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeClusterSecurityGroupIngress">REST API Reference for AuthorizeClusterSecurityGroupIngress Operation</seealso>
        public virtual Task<AuthorizeClusterSecurityGroupIngressResponse> AuthorizeClusterSecurityGroupIngressAsync(AuthorizeClusterSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeClusterSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeClusterSecurityGroupIngressResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AuthorizeDataShare

        internal virtual AuthorizeDataShareResponse AuthorizeDataShare(AuthorizeDataShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeDataShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeDataShareResponseUnmarshaller.Instance;

            return Invoke<AuthorizeDataShareResponse>(request, options);
        }



        /// <summary>
        /// From a data producer account, authorizes the sharing of a datashare with one or more
        /// consumer accounts or managing entities. To authorize a datashare for a data consumer,
        /// the producer account must have the correct access permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeDataShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AuthorizeDataShare service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidDataShareException">
        /// There is an error with the datashare.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeDataShare">REST API Reference for AuthorizeDataShare Operation</seealso>
        public virtual Task<AuthorizeDataShareResponse> AuthorizeDataShareAsync(AuthorizeDataShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeDataShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeDataShareResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeDataShareResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AuthorizeEndpointAccess

        internal virtual AuthorizeEndpointAccessResponse AuthorizeEndpointAccess(AuthorizeEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<AuthorizeEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Grants access to a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AuthorizeEndpointAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointAuthorizationAlreadyExistsException">
        /// The authorization already exists for this endpoint.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointAuthorizationsPerClusterLimitExceededException">
        /// The number of endpoint authorizations per cluster has exceeded its limit.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidAuthorizationStateException">
        /// The status of the authorization is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeEndpointAccess">REST API Reference for AuthorizeEndpointAccess Operation</seealso>
        public virtual Task<AuthorizeEndpointAccessResponse> AuthorizeEndpointAccessAsync(AuthorizeEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeEndpointAccessResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AuthorizeSnapshotAccess

        internal virtual AuthorizeSnapshotAccessResponse AuthorizeSnapshotAccess(AuthorizeSnapshotAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeSnapshotAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeSnapshotAccessResponseUnmarshaller.Instance;

            return Invoke<AuthorizeSnapshotAccessResponse>(request, options);
        }



        /// <summary>
        /// Authorizes the specified Amazon Web Services account to restore the specified snapshot.
        /// 
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSnapshotAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AuthorizeSnapshotAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationAlreadyExistsException">
        /// The specified CIDR block or EC2 security group is already authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationQuotaExceededException">
        /// The authorization quota for the cluster security group has been reached.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <c>available</c> state, or other accounts
        /// are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in Amazon Web Services KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeSnapshotAccess">REST API Reference for AuthorizeSnapshotAccess Operation</seealso>
        public virtual Task<AuthorizeSnapshotAccessResponse> AuthorizeSnapshotAccessAsync(AuthorizeSnapshotAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeSnapshotAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeSnapshotAccessResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeSnapshotAccessResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDeleteClusterSnapshots

        internal virtual BatchDeleteClusterSnapshotsResponse BatchDeleteClusterSnapshots(BatchDeleteClusterSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteClusterSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Deletes a set of cluster snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteClusterSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.BatchDeleteRequestSizeExceededException">
        /// The maximum number for a batch delete of snapshots has been reached. The limit is
        /// 100.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/BatchDeleteClusterSnapshots">REST API Reference for BatchDeleteClusterSnapshots Operation</seealso>
        public virtual Task<BatchDeleteClusterSnapshotsResponse> BatchDeleteClusterSnapshotsAsync(BatchDeleteClusterSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteClusterSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteClusterSnapshotsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchModifyClusterSnapshots

        internal virtual BatchModifyClusterSnapshotsResponse BatchModifyClusterSnapshots(BatchModifyClusterSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchModifyClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchModifyClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<BatchModifyClusterSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Modifies the settings for a set of cluster snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchModifyClusterSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchModifyClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.BatchModifyClusterSnapshotsLimitExceededException">
        /// The maximum number for snapshot identifiers has been reached. The limit is 100.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/BatchModifyClusterSnapshots">REST API Reference for BatchModifyClusterSnapshots Operation</seealso>
        public virtual Task<BatchModifyClusterSnapshotsResponse> BatchModifyClusterSnapshotsAsync(BatchModifyClusterSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchModifyClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchModifyClusterSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchModifyClusterSnapshotsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelResize

        internal virtual CancelResizeResponse CancelResize(CancelResizeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelResizeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelResizeResponseUnmarshaller.Instance;

            return Invoke<CancelResizeResponse>(request, options);
        }



        /// <summary>
        /// Cancels a resize operation for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelResize service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelResize service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResizeNotFoundException">
        /// A resize operation for the specified cluster is not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CancelResize">REST API Reference for CancelResize Operation</seealso>
        public virtual Task<CancelResizeResponse> CancelResizeAsync(CancelResizeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelResizeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelResizeResponseUnmarshaller.Instance;

            return InvokeAsync<CancelResizeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CopyClusterSnapshot

        internal virtual CopyClusterSnapshotResponse CopyClusterSnapshot(CopyClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyClusterSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Copies the specified automated cluster snapshot to a new manual cluster snapshot.
        /// The source must be an automated snapshot and it must be in the available state.
        /// 
        ///  
        /// <para>
        /// When you delete a cluster, Amazon Redshift deletes any automated snapshots of the
        /// cluster. Also, when the retention period of the snapshot expires, Amazon Redshift
        /// automatically deletes it. If you want to keep an automated snapshot for a longer period,
        /// you can make a manual copy of the snapshot. Manual snapshots are retained until you
        /// delete them.
        /// </para>
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster snapshots.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <c>available</c> state, or other accounts
        /// are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CopyClusterSnapshot">REST API Reference for CopyClusterSnapshot Operation</seealso>
        public virtual Task<CopyClusterSnapshotResponse> CopyClusterSnapshotAsync(CopyClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopyClusterSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAuthenticationProfile

        internal virtual CreateAuthenticationProfileResponse CreateAuthenticationProfile(CreateAuthenticationProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAuthenticationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthenticationProfileResponseUnmarshaller.Instance;

            return Invoke<CreateAuthenticationProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates an authentication profile with the specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthenticationProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAuthenticationProfile service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthenticationProfileAlreadyExistsException">
        /// The authentication profile already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthenticationProfileQuotaExceededException">
        /// The size or number of authentication profiles has exceeded the quota. The maximum
        /// length of the JSON string and maximum number of authentication profiles is determined
        /// by a quota for your account.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidAuthenticationProfileRequestException">
        /// The authentication profile request is not valid. The profile name can't be null or
        /// empty. The authentication profile API operation must be available in the Amazon Web
        /// Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateAuthenticationProfile">REST API Reference for CreateAuthenticationProfile Operation</seealso>
        public virtual Task<CreateAuthenticationProfileResponse> CreateAuthenticationProfileAsync(CreateAuthenticationProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAuthenticationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthenticationProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAuthenticationProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCluster

        internal virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }



        /// <summary>
        /// Creates a new cluster with the specified parameters.
        /// 
        ///  
        /// <para>
        /// To create a cluster in Virtual Private Cloud (VPC), you must provide a cluster subnet
        /// group name. The cluster subnet group identifies the subnets of your VPC that Amazon
        /// Redshift uses when creating the cluster. For more information about managing clusters,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// VPC Block Public Access (BPA) enables you to block resources in VPCs and subnets that
        /// you own in a Region from reaching or being reached from the internet through internet
        /// gateways and egress-only internet gateways. If a subnet group for a provisioned cluster
        /// is in an account with VPC BPA turned on, the following capabilities are blocked:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creating a public cluster
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Restoring a public cluster
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Modifying a private cluster to be public
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Adding a subnet with VPC BPA turned on to the subnet group when there's at least one
        /// public cluster within the group
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about VPC BPA, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/security-vpc-bpa.html">Block
        /// public access to VPCs and subnets</a> in the <i>Amazon VPC User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterQuotaExceededException">
        /// The request would exceed the allowed number of cluster instances for this account.
        /// For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterTrackException">
        /// The provided cluster track name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidVPCNetworkStateException">
        /// The cluster subnet group does not cover all Availability Zones.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.Ipv6CidrBlockNotFoundException">
        /// There are no subnets in your VPC with associated IPv6 CIDR blocks. To use dual-stack
        /// mode, associate an IPv6 CIDR block with each subnet in your VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in Amazon Web Services KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.RedshiftIdcApplicationNotExistsException">
        /// The application you attempted to find doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateClusterParameterGroup

        internal virtual CreateClusterParameterGroupResponse CreateClusterParameterGroup(CreateClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateClusterParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Redshift parameter group.
        /// 
        ///  
        /// <para>
        /// Creating parameter groups is independent of creating clusters. You can associate a
        /// cluster with a parameter group when you create the cluster. You can also associate
        /// an existing cluster with a parameter group after the cluster is created by using <a>ModifyCluster</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Parameters in the parameter group define specific behavior that applies to the databases
        /// you create on the cluster. For more information about parameters and parameter groups,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupAlreadyExistsException">
        /// A cluster parameter group with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster parameter
        /// groups. For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterParameterGroup">REST API Reference for CreateClusterParameterGroup Operation</seealso>
        public virtual Task<CreateClusterParameterGroupResponse> CreateClusterParameterGroupAsync(CreateClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateClusterSecurityGroup

        internal virtual CreateClusterSecurityGroupResponse CreateClusterSecurityGroup(CreateClusterSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateClusterSecurityGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Amazon Redshift security group. You use security groups to control access
        /// to non-VPC clusters.
        /// 
        ///  
        /// <para>
        ///  For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateClusterSecurityGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupAlreadyExistsException">
        /// A cluster security group with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster security
        /// groups. For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSecurityGroup">REST API Reference for CreateClusterSecurityGroup Operation</seealso>
        public virtual Task<CreateClusterSecurityGroupResponse> CreateClusterSecurityGroupAsync(CreateClusterSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterSecurityGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateClusterSnapshot

        internal virtual CreateClusterSnapshotResponse CreateClusterSnapshot(CreateClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateClusterSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a manual snapshot of the specified cluster. The cluster must be in the <c>available</c>
        /// state. 
        /// 
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster snapshots.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSnapshot">REST API Reference for CreateClusterSnapshot Operation</seealso>
        public virtual Task<CreateClusterSnapshotResponse> CreateClusterSnapshotAsync(CreateClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateClusterSubnetGroup

        internal virtual CreateClusterSubnetGroupResponse CreateClusterSubnetGroup(CreateClusterSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateClusterSubnetGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Amazon Redshift subnet group. You must provide a list of one or more
        /// subnets in your existing Amazon Virtual Private Cloud (Amazon VPC) when creating Amazon
        /// Redshift subnet group.
        /// 
        ///  
        /// <para>
        ///  For information about subnet groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-cluster-subnet-groups.html">Amazon
        /// Redshift Cluster Subnet Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupAlreadyExistsException">
        /// A <i>ClusterSubnetGroupName</i> is already used by an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupQuotaExceededException">
        /// The request would result in user exceeding the allowed number of cluster subnet groups.
        /// For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetQuotaExceededException">
        /// The request would result in user exceeding the allowed number of subnets in a cluster
        /// subnet groups. For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSubnetGroup">REST API Reference for CreateClusterSubnetGroup Operation</seealso>
        public virtual Task<CreateClusterSubnetGroupResponse> CreateClusterSubnetGroupAsync(CreateClusterSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterSubnetGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCustomDomainAssociation

        internal virtual CreateCustomDomainAssociationResponse CreateCustomDomainAssociation(CreateCustomDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateCustomDomainAssociationResponse>(request, options);
        }



        /// <summary>
        /// Used to create a custom domain name for a cluster. Properties include the custom domain
        /// name, the cluster the custom domain is associated with, and the certificate Amazon
        /// Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomDomainAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomDomainAssociation service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.CustomCnameAssociationException">
        /// An error occurred when an attempt was made to change the custom domain association.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateCustomDomainAssociation">REST API Reference for CreateCustomDomainAssociation Operation</seealso>
        public virtual Task<CreateCustomDomainAssociationResponse> CreateCustomDomainAssociationAsync(CreateCustomDomainAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomDomainAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomDomainAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEndpointAccess

        internal virtual CreateEndpointAccessResponse CreateEndpointAccess(CreateEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Creates a Redshift-managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEndpointAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AccessToClusterDeniedException">
        /// You are not authorized to access the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointAlreadyExistsException">
        /// The account already has a Redshift-managed VPC endpoint with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointsPerAuthorizationLimitExceededException">
        /// The number of Redshift-managed VPC endpoints per authorization has exceeded its limit.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointsPerClusterLimitExceededException">
        /// The number of Redshift-managed VPC endpoints per cluster has exceeded its limit.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <c>available</c>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateEndpointAccess">REST API Reference for CreateEndpointAccess Operation</seealso>
        public virtual Task<CreateEndpointAccessResponse> CreateEndpointAccessAsync(CreateEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEndpointAccessResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEventSubscription

        internal virtual CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateEventSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Redshift event notification subscription. This action requires an
        /// ARN (Amazon Resource Name) of an Amazon SNS topic created by either the Amazon Redshift
        /// console, the Amazon SNS console, or the Amazon SNS API. To obtain an ARN with Amazon
        /// SNS, you must create a topic in Amazon SNS and subscribe to the topic. The ARN is
        /// displayed in the SNS console.
        /// 
        ///  
        /// <para>
        /// You can specify the source type, and lists of Amazon Redshift source IDs, event categories,
        /// and event severities. Notifications will be sent for all events you want that match
        /// those criteria. For example, you can specify source type = cluster, source ID = my-cluster-1
        /// and mycluster2, event categories = Availability, Backup, and severity = ERROR. The
        /// subscription will only send notifications for those ERROR events in the Availability
        /// and Backup categories for the specified clusters.
        /// </para>
        ///  
        /// <para>
        /// If you specify both the source type and source IDs, such as source type = cluster
        /// and source identifier = my-cluster-1, notifications will be sent for all the cluster
        /// events for my-cluster-1. If you specify a source type but do not specify a source
        /// identifier, you will receive notice of the events for the objects of that type in
        /// your Amazon Web Services account. If you do not specify either the SourceType nor
        /// the SourceIdentifier, you will be notified of events generated from all Amazon Redshift
        /// sources belonging to your Amazon Web Services account. You must specify a source type
        /// if you specify a source ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.EventSubscriptionQuotaExceededException">
        /// The request would exceed the allowed number of event subscriptions for this account.
        /// For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSInvalidTopicException">
        /// Amazon SNS has responded that there is a problem with the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSTopicArnNotFoundException">
        /// An Amazon SNS topic with the specified Amazon Resource Name (ARN) does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SourceNotFoundException">
        /// The specified Amazon Redshift event source could not be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionAlreadyExistException">
        /// There is already an existing event notification subscription with the specified name.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionCategoryNotFoundException">
        /// The value specified for the event category was not one of the allowed values, or it
        /// specified a category that does not apply to the specified source type. The allowed
        /// values are Configuration, Management, Monitoring, and Security.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionEventIdNotFoundException">
        /// An Amazon Redshift event with the specified event ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionSeverityNotFoundException">
        /// The value specified for the event severity was not one of the allowed values, or it
        /// specified a severity that does not apply to the specified source type. The allowed
        /// values are ERROR and INFO.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEventSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateHsmClientCertificate

        internal virtual CreateHsmClientCertificateResponse CreateHsmClientCertificate(CreateHsmClientCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHsmClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHsmClientCertificateResponseUnmarshaller.Instance;

            return Invoke<CreateHsmClientCertificateResponse>(request, options);
        }



        /// <summary>
        /// Creates an HSM client certificate that an Amazon Redshift cluster will use to connect
        /// to the client's HSM in order to store and retrieve the keys used to encrypt the cluster
        /// databases.
        /// 
        ///  
        /// <para>
        /// The command returns a public key, which you must store in the HSM. In addition to
        /// creating the HSM certificate, you must create an Amazon Redshift HSM configuration
        /// that provides a cluster the information needed to store and use encryption keys in
        /// the HSM. For more information, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-db-encryption.html#working-with-HSM">Hardware
        /// Security Modules</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmClientCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHsmClientCertificate service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateAlreadyExistsException">
        /// There is already an existing Amazon Redshift HSM client certificate with the specified
        /// identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateQuotaExceededException">
        /// The quota for HSM client certificates has been reached. For information about increasing
        /// your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateHsmClientCertificate">REST API Reference for CreateHsmClientCertificate Operation</seealso>
        public virtual Task<CreateHsmClientCertificateResponse> CreateHsmClientCertificateAsync(CreateHsmClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHsmClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHsmClientCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHsmClientCertificateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateHsmConfiguration

        internal virtual CreateHsmConfigurationResponse CreateHsmConfiguration(CreateHsmConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHsmConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHsmConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateHsmConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates an HSM configuration that contains the information required by an Amazon Redshift
        /// cluster to store and use database encryption keys in a Hardware Security Module (HSM).
        /// After creating the HSM configuration, you can specify it as a parameter when creating
        /// a cluster. The cluster will then store its encryption keys in the HSM.
        /// 
        ///  
        /// <para>
        /// In addition to creating an HSM configuration, you must also create an HSM client certificate.
        /// For more information, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-HSM.html">Hardware
        /// Security Modules</a> in the Amazon Redshift Cluster Management Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHsmConfiguration service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationAlreadyExistsException">
        /// There is already an existing Amazon Redshift HSM configuration with the specified
        /// identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationQuotaExceededException">
        /// The quota for HSM configurations has been reached. For information about increasing
        /// your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateHsmConfiguration">REST API Reference for CreateHsmConfiguration Operation</seealso>
        public virtual Task<CreateHsmConfigurationResponse> CreateHsmConfigurationAsync(CreateHsmConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHsmConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHsmConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHsmConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateIntegration

        internal virtual CreateIntegrationResponse CreateIntegration(CreateIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationResponse>(request, options);
        }



        /// <summary>
        /// Creates a zero-ETL integration or S3 event integration with Amazon Redshift.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIntegration service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.IntegrationAlreadyExistsException">
        /// The integration you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.IntegrationConflictOperationException">
        /// A conflicting conditional operation is currently in progress against this resource.
        /// This typically occurs when there are multiple requests being made to the same resource
        /// at the same time, and these requests conflict with each other.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.IntegrationQuotaExceededException">
        /// You can't create any more zero-ETL or S3 event integrations because the quota has
        /// been reached.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.IntegrationSourceNotFoundException">
        /// The specified integration source can't be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.IntegrationTargetNotFoundException">
        /// The specified integration target can't be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        public virtual Task<CreateIntegrationResponse> CreateIntegrationAsync(CreateIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIntegrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRedshiftIdcApplication

        internal virtual CreateRedshiftIdcApplicationResponse CreateRedshiftIdcApplication(CreateRedshiftIdcApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRedshiftIdcApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRedshiftIdcApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateRedshiftIdcApplicationResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Redshift application for use with IAM Identity Center.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRedshiftIdcApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRedshiftIdcApplication service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceAccessDeniedException">
        /// A dependent service denied access for the integration.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.RedshiftIdcApplicationAlreadyExistsException">
        /// The application you attempted to add already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.RedshiftIdcApplicationQuotaExceededException">
        /// The maximum number of Redshift IAM Identity Center applications was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateRedshiftIdcApplication">REST API Reference for CreateRedshiftIdcApplication Operation</seealso>
        public virtual Task<CreateRedshiftIdcApplicationResponse> CreateRedshiftIdcApplicationAsync(CreateRedshiftIdcApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRedshiftIdcApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRedshiftIdcApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRedshiftIdcApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateScheduledAction

        internal virtual CreateScheduledActionResponse CreateScheduledAction(CreateScheduledActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduledActionResponseUnmarshaller.Instance;

            return Invoke<CreateScheduledActionResponse>(request, options);
        }



        /// <summary>
        /// Creates a scheduled action. A scheduled action contains a schedule and an Amazon Redshift
        /// API action. For example, you can create a schedule of when to run the <c>ResizeCluster</c>
        /// API operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateScheduledAction service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduledActionException">
        /// The scheduled action is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduleException">
        /// The schedule you submitted isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionAlreadyExistsException">
        /// The scheduled action already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionQuotaExceededException">
        /// The quota for scheduled actions exceeded.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionTypeUnsupportedException">
        /// The action type specified for a scheduled action is not supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateScheduledAction">REST API Reference for CreateScheduledAction Operation</seealso>
        public virtual Task<CreateScheduledActionResponse> CreateScheduledActionAsync(CreateScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduledActionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateScheduledActionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSnapshotCopyGrant

        internal virtual CreateSnapshotCopyGrantResponse CreateSnapshotCopyGrant(CreateSnapshotCopyGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotCopyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotCopyGrantResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotCopyGrantResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot copy grant that permits Amazon Redshift to use an encrypted symmetric
        /// key from Key Management Service (KMS) to encrypt copied snapshots in a destination
        /// region.
        /// 
        ///  
        /// <para>
        ///  For more information about managing snapshot copy grants, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-db-encryption.html">Amazon
        /// Redshift Database Encryption</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotCopyGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshotCopyGrant service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in Amazon Web Services KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantAlreadyExistsException">
        /// The snapshot copy grant can't be created because a grant with the same name already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantQuotaExceededException">
        /// The Amazon Web Services account has exceeded the maximum number of snapshot copy grants
        /// in this region.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateSnapshotCopyGrant">REST API Reference for CreateSnapshotCopyGrant Operation</seealso>
        public virtual Task<CreateSnapshotCopyGrantResponse> CreateSnapshotCopyGrantAsync(CreateSnapshotCopyGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotCopyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotCopyGrantResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotCopyGrantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSnapshotSchedule

        internal virtual CreateSnapshotScheduleResponse CreateSnapshotSchedule(CreateSnapshotScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotScheduleResponse>(request, options);
        }



        /// <summary>
        /// Create a snapshot schedule that can be associated to a cluster and which overrides
        /// the default system backup schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshotSchedule service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduleException">
        /// The schedule you submitted isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduleDefinitionTypeUnsupportedException">
        /// The definition you submitted is not supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleAlreadyExistsException">
        /// The specified snapshot schedule already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleQuotaExceededException">
        /// You have exceeded the quota of snapshot schedules.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateSnapshotSchedule">REST API Reference for CreateSnapshotSchedule Operation</seealso>
        public virtual Task<CreateSnapshotScheduleResponse> CreateSnapshotScheduleAsync(CreateSnapshotScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTags

        internal virtual CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsResponse>(request, options);
        }



        /// <summary>
        /// Adds tags to a cluster.
        /// 
        ///  
        /// <para>
        /// A resource can have up to 50 tags. If you try to create more than 50 tags for a resource,
        /// you will receive an error and the attempt will fail.
        /// </para>
        ///  
        /// <para>
        /// If you specify a key that already exists for the resource, the value for that key
        /// will be updated with the new value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateUsageLimit

        internal virtual CreateUsageLimitResponse CreateUsageLimit(CreateUsageLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUsageLimitResponseUnmarshaller.Instance;

            return Invoke<CreateUsageLimitResponse>(request, options);
        }



        /// <summary>
        /// Creates a usage limit for a specified Amazon Redshift feature on a cluster. The usage
        /// limit is identified by the returned usage limit identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUsageLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUsageLimit service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidUsageLimitException">
        /// The usage limit is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in Amazon Web Services KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UsageLimitAlreadyExistsException">
        /// The usage limit already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateUsageLimit">REST API Reference for CreateUsageLimit Operation</seealso>
        public virtual Task<CreateUsageLimitResponse> CreateUsageLimitAsync(CreateUsageLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUsageLimitResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUsageLimitResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeauthorizeDataShare

        internal virtual DeauthorizeDataShareResponse DeauthorizeDataShare(DeauthorizeDataShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeauthorizeDataShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeauthorizeDataShareResponseUnmarshaller.Instance;

            return Invoke<DeauthorizeDataShareResponse>(request, options);
        }



        /// <summary>
        /// From a datashare producer account, removes authorization from the specified datashare.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeauthorizeDataShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeauthorizeDataShare service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidDataShareException">
        /// There is an error with the datashare.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeauthorizeDataShare">REST API Reference for DeauthorizeDataShare Operation</seealso>
        public virtual Task<DeauthorizeDataShareResponse> DeauthorizeDataShareAsync(DeauthorizeDataShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeauthorizeDataShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeauthorizeDataShareResponseUnmarshaller.Instance;

            return InvokeAsync<DeauthorizeDataShareResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAuthenticationProfile

        internal virtual DeleteAuthenticationProfileResponse DeleteAuthenticationProfile(DeleteAuthenticationProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAuthenticationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthenticationProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteAuthenticationProfileResponse>(request, options);
        }



        /// <summary>
        /// Deletes an authentication profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthenticationProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAuthenticationProfile service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthenticationProfileNotFoundException">
        /// The authentication profile can't be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidAuthenticationProfileRequestException">
        /// The authentication profile request is not valid. The profile name can't be null or
        /// empty. The authentication profile API operation must be available in the Amazon Web
        /// Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteAuthenticationProfile">REST API Reference for DeleteAuthenticationProfile Operation</seealso>
        public virtual Task<DeleteAuthenticationProfileResponse> DeleteAuthenticationProfileAsync(DeleteAuthenticationProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAuthenticationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthenticationProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAuthenticationProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCluster

        internal virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }



        /// <summary>
        /// Deletes a previously provisioned cluster without its final snapshot being created.
        /// A successful response from the web service indicates that the request was received
        /// correctly. Use <a>DescribeClusters</a> to monitor the status of the deletion. The
        /// delete operation cannot be canceled or reverted once submitted. For more information
        /// about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        ///  
        /// <para>
        /// If you want to shut down the cluster and retain it for future use, set <i>SkipFinalClusterSnapshot</i>
        /// to <c>false</c> and specify a name for <i>FinalClusterSnapshotIdentifier</i>. You
        /// can later restore this snapshot to resume using the cluster. If a final cluster snapshot
        /// is requested, the status of the cluster will be "final-snapshot" while the snapshot
        /// is being taken, then it's "deleting" once Amazon Redshift begins deleting the cluster.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  For more information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster snapshots.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteClusterParameterGroup

        internal virtual DeleteClusterParameterGroupResponse DeleteClusterParameterGroup(DeleteClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a specified Amazon Redshift parameter group.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete a parameter group if it is associated with a cluster.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because another task is in
        /// progress that involves the parameter group. Wait a few moments and try the operation
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterParameterGroup">REST API Reference for DeleteClusterParameterGroup Operation</seealso>
        public virtual Task<DeleteClusterParameterGroupResponse> DeleteClusterParameterGroupAsync(DeleteClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteClusterSecurityGroup

        internal virtual DeleteClusterSecurityGroupResponse DeleteClusterSecurityGroup(DeleteClusterSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterSecurityGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Redshift security group.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete a security group that is associated with any clusters. You cannot
        /// delete the default security group.
        /// </para>
        ///  </note> 
        /// <para>
        ///  For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteClusterSecurityGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <c>available</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSecurityGroup">REST API Reference for DeleteClusterSecurityGroup Operation</seealso>
        public virtual Task<DeleteClusterSecurityGroupResponse> DeleteClusterSecurityGroupAsync(DeleteClusterSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterSecurityGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteClusterSnapshot

        internal virtual DeleteClusterSnapshotResponse DeleteClusterSnapshot(DeleteClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified manual snapshot. The snapshot must be in the <c>available</c>
        /// state, with no other users authorized to access the snapshot. 
        /// 
        ///  
        /// <para>
        /// Unlike automated snapshots, manual snapshots are retained even after you delete your
        /// cluster. Amazon Redshift does not delete your manual snapshots. You must delete manual
        /// snapshot explicitly to avoid getting charged. If other accounts are authorized to
        /// access the snapshot, you must revoke all of the authorizations before you can delete
        /// the snapshot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <c>available</c> state, or other accounts
        /// are authorized to access the snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSnapshot">REST API Reference for DeleteClusterSnapshot Operation</seealso>
        public virtual Task<DeleteClusterSnapshotResponse> DeleteClusterSnapshotAsync(DeleteClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteClusterSubnetGroup

        internal virtual DeleteClusterSubnetGroupResponse DeleteClusterSubnetGroup(DeleteClusterSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterSubnetGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified cluster subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetStateException">
        /// The state of the subnet is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSubnetGroup">REST API Reference for DeleteClusterSubnetGroup Operation</seealso>
        public virtual Task<DeleteClusterSubnetGroupResponse> DeleteClusterSubnetGroupAsync(DeleteClusterSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterSubnetGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCustomDomainAssociation

        internal virtual DeleteCustomDomainAssociationResponse DeleteCustomDomainAssociation(DeleteCustomDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomDomainAssociationResponse>(request, options);
        }



        /// <summary>
        /// Contains information about deleting a custom domain association for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomDomainAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomDomainAssociation service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.CustomCnameAssociationException">
        /// An error occurred when an attempt was made to change the custom domain association.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.CustomDomainAssociationNotFoundException">
        /// An error occurred. The custom domain name couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteCustomDomainAssociation">REST API Reference for DeleteCustomDomainAssociation Operation</seealso>
        public virtual Task<DeleteCustomDomainAssociationResponse> DeleteCustomDomainAssociationAsync(DeleteCustomDomainAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomDomainAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomDomainAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEndpointAccess

        internal virtual DeleteEndpointAccessResponse DeleteEndpointAccess(DeleteEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Redshift-managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEndpointAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointNotFoundException">
        /// The endpoint name doesn't refer to an existing endpoint.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <c>available</c>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidEndpointStateException">
        /// The status of the endpoint is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteEndpointAccess">REST API Reference for DeleteEndpointAccess Operation</seealso>
        public virtual Task<DeleteEndpointAccessResponse> DeleteEndpointAccessAsync(DeleteEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEndpointAccessResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEventSubscription

        internal virtual DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Redshift event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubscriptionStateException">
        /// The subscription request is invalid because it is a duplicate request. This subscription
        /// request is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteHsmClientCertificate

        internal virtual DeleteHsmClientCertificateResponse DeleteHsmClientCertificate(DeleteHsmClientCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHsmClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHsmClientCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteHsmClientCertificateResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified HSM client certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmClientCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHsmClientCertificate service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidHsmClientCertificateStateException">
        /// The specified HSM client certificate is not in the <c>available</c> state, or it is
        /// still in use by one or more Amazon Redshift clusters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteHsmClientCertificate">REST API Reference for DeleteHsmClientCertificate Operation</seealso>
        public virtual Task<DeleteHsmClientCertificateResponse> DeleteHsmClientCertificateAsync(DeleteHsmClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHsmClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHsmClientCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHsmClientCertificateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteHsmConfiguration

        internal virtual DeleteHsmConfigurationResponse DeleteHsmConfiguration(DeleteHsmConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHsmConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHsmConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteHsmConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified Amazon Redshift HSM configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHsmConfiguration service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidHsmConfigurationStateException">
        /// The specified HSM configuration is not in the <c>available</c> state, or it is still
        /// in use by one or more Amazon Redshift clusters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteHsmConfiguration">REST API Reference for DeleteHsmConfiguration Operation</seealso>
        public virtual Task<DeleteHsmConfigurationResponse> DeleteHsmConfigurationAsync(DeleteHsmConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHsmConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHsmConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHsmConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteIntegration

        internal virtual DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a zero-ETL integration or S3 event integration with Amazon Redshift.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.IntegrationConflictOperationException">
        /// A conflicting conditional operation is currently in progress against this resource.
        /// This typically occurs when there are multiple requests being made to the same resource
        /// at the same time, and these requests conflict with each other.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.IntegrationConflictStateException">
        /// The integration is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.IntegrationNotFoundException">
        /// The integration can't be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        public virtual Task<DeleteIntegrationResponse> DeleteIntegrationAsync(DeleteIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIntegrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePartner

        internal virtual DeletePartnerResponse DeletePartner(DeletePartnerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePartnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartnerResponseUnmarshaller.Instance;

            return Invoke<DeletePartnerResponse>(request, options);
        }



        /// <summary>
        /// Deletes a partner integration from a cluster. Data can still flow to the cluster until
        /// the integration is deleted at the partner's website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePartner service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePartner service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.PartnerNotFoundException">
        /// The name of the partner was not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedPartnerIntegrationException">
        /// The partner integration is not authorized.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeletePartner">REST API Reference for DeletePartner Operation</seealso>
        public virtual Task<DeletePartnerResponse> DeletePartnerAsync(DeletePartnerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePartnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartnerResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePartnerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRedshiftIdcApplication

        internal virtual DeleteRedshiftIdcApplicationResponse DeleteRedshiftIdcApplication(DeleteRedshiftIdcApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRedshiftIdcApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRedshiftIdcApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteRedshiftIdcApplicationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Redshift IAM Identity Center application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRedshiftIdcApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRedshiftIdcApplication service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceAccessDeniedException">
        /// A dependent service denied access for the integration.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.RedshiftIdcApplicationNotExistsException">
        /// The application you attempted to find doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteRedshiftIdcApplication">REST API Reference for DeleteRedshiftIdcApplication Operation</seealso>
        public virtual Task<DeleteRedshiftIdcApplicationResponse> DeleteRedshiftIdcApplicationAsync(DeleteRedshiftIdcApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRedshiftIdcApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRedshiftIdcApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRedshiftIdcApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteResourcePolicy

        internal virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the resource policy for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteScheduledAction

        internal virtual DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return Invoke<DeleteScheduledActionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a scheduled action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScheduledAction service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionNotFoundException">
        /// The scheduled action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        public virtual Task<DeleteScheduledActionResponse> DeleteScheduledActionAsync(DeleteScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScheduledActionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSnapshotCopyGrant

        internal virtual DeleteSnapshotCopyGrantResponse DeleteSnapshotCopyGrant(DeleteSnapshotCopyGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotCopyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotCopyGrantResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotCopyGrantResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified snapshot copy grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotCopyGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSnapshotCopyGrant service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidSnapshotCopyGrantStateException">
        /// The snapshot copy grant can't be deleted because it is used by one or more clusters.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantNotFoundException">
        /// The specified snapshot copy grant can't be found. Make sure that the name is typed
        /// correctly and that the grant exists in the destination region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteSnapshotCopyGrant">REST API Reference for DeleteSnapshotCopyGrant Operation</seealso>
        public virtual Task<DeleteSnapshotCopyGrantResponse> DeleteSnapshotCopyGrantAsync(DeleteSnapshotCopyGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotCopyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotCopyGrantResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotCopyGrantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSnapshotSchedule

        internal virtual DeleteSnapshotScheduleResponse DeleteSnapshotSchedule(DeleteSnapshotScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotScheduleResponse>(request, options);
        }



        /// <summary>
        /// Deletes a snapshot schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSnapshotSchedule service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotScheduleStateException">
        /// The cluster snapshot schedule state is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteSnapshotSchedule">REST API Reference for DeleteSnapshotSchedule Operation</seealso>
        public virtual Task<DeleteSnapshotScheduleResponse> DeleteSnapshotScheduleAsync(DeleteSnapshotScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTags

        internal virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }



        /// <summary>
        /// Deletes tags from a resource. You must provide the ARN of the resource from which
        /// you want to delete the tag or tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteUsageLimit

        internal virtual DeleteUsageLimitResponse DeleteUsageLimit(DeleteUsageLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUsageLimitResponseUnmarshaller.Instance;

            return Invoke<DeleteUsageLimitResponse>(request, options);
        }



        /// <summary>
        /// Deletes a usage limit from a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsageLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUsageLimit service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UsageLimitNotFoundException">
        /// The usage limit identifier can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteUsageLimit">REST API Reference for DeleteUsageLimit Operation</seealso>
        public virtual Task<DeleteUsageLimitResponse> DeleteUsageLimitAsync(DeleteUsageLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUsageLimitResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUsageLimitResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeregisterNamespace

        internal virtual DeregisterNamespaceResponse DeregisterNamespace(DeregisterNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeregisterNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Deregisters a cluster or serverless namespace from the Amazon Web Services Glue Data
        /// Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterNamespace service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidNamespaceException">
        /// The namespace isn't valid because the namespace doesn't exist. Provide a valid namespace.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeregisterNamespace">REST API Reference for DeregisterNamespace Operation</seealso>
        public virtual Task<DeregisterNamespaceResponse> DeregisterNamespaceAsync(DeregisterNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAccountAttributes

        internal virtual DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of attributes attached to an account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAuthenticationProfiles

        internal virtual DescribeAuthenticationProfilesResponse DescribeAuthenticationProfiles(DescribeAuthenticationProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuthenticationProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuthenticationProfilesResponseUnmarshaller.Instance;

            return Invoke<DescribeAuthenticationProfilesResponse>(request, options);
        }



        /// <summary>
        /// Describes an authentication profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuthenticationProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAuthenticationProfiles service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthenticationProfileNotFoundException">
        /// The authentication profile can't be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidAuthenticationProfileRequestException">
        /// The authentication profile request is not valid. The profile name can't be null or
        /// empty. The authentication profile API operation must be available in the Amazon Web
        /// Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeAuthenticationProfiles">REST API Reference for DescribeAuthenticationProfiles Operation</seealso>
        public virtual Task<DescribeAuthenticationProfilesResponse> DescribeAuthenticationProfilesAsync(DescribeAuthenticationProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuthenticationProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuthenticationProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAuthenticationProfilesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeClusterDbRevisions

        internal virtual DescribeClusterDbRevisionsResponse DescribeClusterDbRevisions(DescribeClusterDbRevisionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterDbRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterDbRevisionsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterDbRevisionsResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of <c>ClusterDbRevision</c> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterDbRevisions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterDbRevisions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterDbRevisions">REST API Reference for DescribeClusterDbRevisions Operation</seealso>
        public virtual Task<DescribeClusterDbRevisionsResponse> DescribeClusterDbRevisionsAsync(DescribeClusterDbRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterDbRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterDbRevisionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterDbRevisionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeClusterParameterGroups

        internal virtual DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups()
        {
            return DescribeClusterParameterGroups(new DescribeClusterParameterGroupsRequest());
        }
        internal virtual DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterParameterGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of Amazon Redshift parameter groups, including parameter groups you
        /// created and the default parameter group. For each parameter group, the response includes
        /// the parameter group name, description, and parameter group family name. You can optionally
        /// specify a name to retrieve the description of a specific parameter group.
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all parameter groups that match any combination of the specified keys and values.
        /// For example, if you have <c>owner</c> and <c>environment</c> for tag keys, and <c>admin</c>
        /// and <c>test</c> for tag values, all parameter groups that have any combination of
        /// those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, parameter groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameterGroups">REST API Reference for DescribeClusterParameterGroups Operation</seealso>
        public virtual Task<DescribeClusterParameterGroupsResponse> DescribeClusterParameterGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClusterParameterGroupsAsync(new DescribeClusterParameterGroupsRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns a list of Amazon Redshift parameter groups, including parameter groups you
        /// created and the default parameter group. For each parameter group, the response includes
        /// the parameter group name, description, and parameter group family name. You can optionally
        /// specify a name to retrieve the description of a specific parameter group.
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all parameter groups that match any combination of the specified keys and values.
        /// For example, if you have <c>owner</c> and <c>environment</c> for tag keys, and <c>admin</c>
        /// and <c>test</c> for tag values, all parameter groups that have any combination of
        /// those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, parameter groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameterGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameterGroups">REST API Reference for DescribeClusterParameterGroups Operation</seealso>
        public virtual Task<DescribeClusterParameterGroupsResponse> DescribeClusterParameterGroupsAsync(DescribeClusterParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterParameterGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterParameterGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeClusterParameters

        internal virtual DescribeClusterParametersResponse DescribeClusterParameters(DescribeClusterParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterParametersResponse>(request, options);
        }



        /// <summary>
        /// Returns a detailed list of parameters contained within the specified Amazon Redshift
        /// parameter group. For each parameter the response includes information such as parameter
        /// name, description, data type, value, whether the parameter value is modifiable, and
        /// so on.
        /// 
        ///  
        /// <para>
        /// You can specify <i>source</i> filter to retrieve parameters of only specific type.
        /// For example, to retrieve parameters that were modified by a user action such as from
        /// <a>ModifyClusterParameterGroup</a>, you can specify <i>source</i> equal to <i>user</i>.
        /// </para>
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterParameters service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameters">REST API Reference for DescribeClusterParameters Operation</seealso>
        public virtual Task<DescribeClusterParametersResponse> DescribeClusterParametersAsync(DescribeClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterParametersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeClusters

        internal virtual DescribeClustersResponse DescribeClusters()
        {
            return DescribeClusters(new DescribeClustersRequest());
        }
        internal virtual DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeClustersResponse>(request, options);
        }


        /// <summary>
        /// Returns properties of provisioned clusters including general cluster properties, cluster
        /// database properties, maintenance and backup properties, and security and access properties.
        /// This operation supports pagination. For more information about managing clusters,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all clusters that match any combination of the specified keys and values. For example,
        /// if you have <c>owner</c> and <c>environment</c> for tag keys, and <c>admin</c> and
        /// <c>test</c> for tag values, all clusters that have any combination of those values
        /// are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, clusters are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        public virtual Task<DescribeClustersResponse> DescribeClustersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClustersAsync(new DescribeClustersRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns properties of provisioned clusters including general cluster properties, cluster
        /// database properties, maintenance and backup properties, and security and access properties.
        /// This operation supports pagination. For more information about managing clusters,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all clusters that match any combination of the specified keys and values. For example,
        /// if you have <c>owner</c> and <c>environment</c> for tag keys, and <c>admin</c> and
        /// <c>test</c> for tag values, all clusters that have any combination of those values
        /// are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, clusters are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        public virtual Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClustersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeClusterSecurityGroups

        internal virtual DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups()
        {
            return DescribeClusterSecurityGroups(new DescribeClusterSecurityGroupsRequest());
        }
        internal virtual DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterSecurityGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about Amazon Redshift security groups. If the name of a security
        /// group is specified, the response will contain only information about only that security
        /// group.
        /// 
        ///  
        /// <para>
        ///  For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all security groups that match any combination of the specified keys and values. For
        /// example, if you have <c>owner</c> and <c>environment</c> for tag keys, and <c>admin</c>
        /// and <c>test</c> for tag values, all security groups that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, security groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSecurityGroups">REST API Reference for DescribeClusterSecurityGroups Operation</seealso>
        public virtual Task<DescribeClusterSecurityGroupsResponse> DescribeClusterSecurityGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClusterSecurityGroupsAsync(new DescribeClusterSecurityGroupsRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns information about Amazon Redshift security groups. If the name of a security
        /// group is specified, the response will contain only information about only that security
        /// group.
        /// 
        ///  
        /// <para>
        ///  For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all security groups that match any combination of the specified keys and values. For
        /// example, if you have <c>owner</c> and <c>environment</c> for tag keys, and <c>admin</c>
        /// and <c>test</c> for tag values, all security groups that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, security groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSecurityGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSecurityGroups">REST API Reference for DescribeClusterSecurityGroups Operation</seealso>
        public virtual Task<DescribeClusterSecurityGroupsResponse> DescribeClusterSecurityGroupsAsync(DescribeClusterSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterSecurityGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeClusterSnapshots

        internal virtual DescribeClusterSnapshotsResponse DescribeClusterSnapshots()
        {
            return DescribeClusterSnapshots(new DescribeClusterSnapshotsRequest());
        }
        internal virtual DescribeClusterSnapshotsResponse DescribeClusterSnapshots(DescribeClusterSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterSnapshotsResponse>(request, options);
        }


        /// <summary>
        /// Returns one or more snapshot objects, which contain metadata about your cluster snapshots.
        /// By default, this operation returns information about all snapshots of all clusters
        /// that are owned by your Amazon Web Services account. No information is returned for
        /// snapshots owned by inactive Amazon Web Services accounts.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all snapshots that match any combination of the specified keys and values. For example,
        /// if you have <c>owner</c> and <c>environment</c> for tag keys, and <c>admin</c> and
        /// <c>test</c> for tag values, all snapshots that have any combination of those values
        /// are returned. Only snapshots that you own are returned in the response; shared snapshots
        /// are not returned with the tag key and tag value request parameters.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, snapshots are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSnapshots">REST API Reference for DescribeClusterSnapshots Operation</seealso>
        public virtual Task<DescribeClusterSnapshotsResponse> DescribeClusterSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClusterSnapshotsAsync(new DescribeClusterSnapshotsRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns one or more snapshot objects, which contain metadata about your cluster snapshots.
        /// By default, this operation returns information about all snapshots of all clusters
        /// that are owned by your Amazon Web Services account. No information is returned for
        /// snapshots owned by inactive Amazon Web Services accounts.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all snapshots that match any combination of the specified keys and values. For example,
        /// if you have <c>owner</c> and <c>environment</c> for tag keys, and <c>admin</c> and
        /// <c>test</c> for tag values, all snapshots that have any combination of those values
        /// are returned. Only snapshots that you own are returned in the response; shared snapshots
        /// are not returned with the tag key and tag value request parameters.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, snapshots are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSnapshots">REST API Reference for DescribeClusterSnapshots Operation</seealso>
        public virtual Task<DescribeClusterSnapshotsResponse> DescribeClusterSnapshotsAsync(DescribeClusterSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterSnapshotsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeClusterSubnetGroups

        internal virtual DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups()
        {
            return DescribeClusterSubnetGroups(new DescribeClusterSubnetGroupsRequest());
        }
        internal virtual DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterSubnetGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns one or more cluster subnet group objects, which contain metadata about your
        /// cluster subnet groups. By default, this operation returns information about all cluster
        /// subnet groups that are defined in your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all subnet groups that match any combination of the specified keys and values. For
        /// example, if you have <c>owner</c> and <c>environment</c> for tag keys, and <c>admin</c>
        /// and <c>test</c> for tag values, all subnet groups that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subnet groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSubnetGroups">REST API Reference for DescribeClusterSubnetGroups Operation</seealso>
        public virtual Task<DescribeClusterSubnetGroupsResponse> DescribeClusterSubnetGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClusterSubnetGroupsAsync(new DescribeClusterSubnetGroupsRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns one or more cluster subnet group objects, which contain metadata about your
        /// cluster subnet groups. By default, this operation returns information about all cluster
        /// subnet groups that are defined in your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all subnet groups that match any combination of the specified keys and values. For
        /// example, if you have <c>owner</c> and <c>environment</c> for tag keys, and <c>admin</c>
        /// and <c>test</c> for tag values, all subnet groups that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subnet groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSubnetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSubnetGroups">REST API Reference for DescribeClusterSubnetGroups Operation</seealso>
        public virtual Task<DescribeClusterSubnetGroupsResponse> DescribeClusterSubnetGroupsAsync(DescribeClusterSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterSubnetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterSubnetGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeClusterTracks

        internal virtual DescribeClusterTracksResponse DescribeClusterTracks(DescribeClusterTracksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterTracksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterTracksResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterTracksResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all the available maintenance tracks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterTracks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterTracks service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterTrackException">
        /// The provided cluster track name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterTracks">REST API Reference for DescribeClusterTracks Operation</seealso>
        public virtual Task<DescribeClusterTracksResponse> DescribeClusterTracksAsync(DescribeClusterTracksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterTracksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterTracksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterTracksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeClusterVersions

        internal virtual DescribeClusterVersionsResponse DescribeClusterVersions()
        {
            return DescribeClusterVersions(new DescribeClusterVersionsRequest());
        }
        internal virtual DescribeClusterVersionsResponse DescribeClusterVersions(DescribeClusterVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterVersionsResponse>(request, options);
        }


        /// <summary>
        /// Returns descriptions of the available Amazon Redshift cluster versions. You can call
        /// this operation even before creating any clusters to learn more about the Amazon Redshift
        /// versions. For more information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterVersions">REST API Reference for DescribeClusterVersions Operation</seealso>
        public virtual Task<DescribeClusterVersionsResponse> DescribeClusterVersionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClusterVersionsAsync(new DescribeClusterVersionsRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns descriptions of the available Amazon Redshift cluster versions. You can call
        /// this operation even before creating any clusters to learn more about the Amazon Redshift
        /// versions. For more information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterVersions">REST API Reference for DescribeClusterVersions Operation</seealso>
        public virtual Task<DescribeClusterVersionsResponse> DescribeClusterVersionsAsync(DescribeClusterVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeCustomDomainAssociations

        internal virtual DescribeCustomDomainAssociationsResponse DescribeCustomDomainAssociations(DescribeCustomDomainAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomDomainAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomDomainAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomDomainAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Contains information about custom domain associations for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomDomainAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomDomainAssociations service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.CustomDomainAssociationNotFoundException">
        /// An error occurred. The custom domain name couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeCustomDomainAssociations">REST API Reference for DescribeCustomDomainAssociations Operation</seealso>
        public virtual Task<DescribeCustomDomainAssociationsResponse> DescribeCustomDomainAssociationsAsync(DescribeCustomDomainAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomDomainAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomDomainAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCustomDomainAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDataShares

        internal virtual DescribeDataSharesResponse DescribeDataShares(DescribeDataSharesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSharesResponseUnmarshaller.Instance;

            return Invoke<DescribeDataSharesResponse>(request, options);
        }



        /// <summary>
        /// Shows the status of any inbound or outbound datashares available in the specified
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataShares service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidDataShareException">
        /// There is an error with the datashare.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDataShares">REST API Reference for DescribeDataShares Operation</seealso>
        public virtual Task<DescribeDataSharesResponse> DescribeDataSharesAsync(DescribeDataSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSharesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDataSharesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDataSharesForConsumer

        internal virtual DescribeDataSharesForConsumerResponse DescribeDataSharesForConsumer(DescribeDataSharesForConsumerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSharesForConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSharesForConsumerResponseUnmarshaller.Instance;

            return Invoke<DescribeDataSharesForConsumerResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of datashares where the account identifier being called is a consumer
        /// account identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSharesForConsumer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataSharesForConsumer service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidNamespaceException">
        /// The namespace isn't valid because the namespace doesn't exist. Provide a valid namespace.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDataSharesForConsumer">REST API Reference for DescribeDataSharesForConsumer Operation</seealso>
        public virtual Task<DescribeDataSharesForConsumerResponse> DescribeDataSharesForConsumerAsync(DescribeDataSharesForConsumerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSharesForConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSharesForConsumerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDataSharesForConsumerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDataSharesForProducer

        internal virtual DescribeDataSharesForProducerResponse DescribeDataSharesForProducer(DescribeDataSharesForProducerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSharesForProducerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSharesForProducerResponseUnmarshaller.Instance;

            return Invoke<DescribeDataSharesForProducerResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of datashares when the account identifier being called is a producer
        /// account identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSharesForProducer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataSharesForProducer service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidNamespaceException">
        /// The namespace isn't valid because the namespace doesn't exist. Provide a valid namespace.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDataSharesForProducer">REST API Reference for DescribeDataSharesForProducer Operation</seealso>
        public virtual Task<DescribeDataSharesForProducerResponse> DescribeDataSharesForProducerAsync(DescribeDataSharesForProducerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSharesForProducerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSharesForProducerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDataSharesForProducerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDefaultClusterParameters

        internal virtual DescribeDefaultClusterParametersResponse DescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDefaultClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDefaultClusterParametersResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of parameter settings for the specified parameter group family.
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultClusterParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDefaultClusterParameters service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDefaultClusterParameters">REST API Reference for DescribeDefaultClusterParameters Operation</seealso>
        public virtual Task<DescribeDefaultClusterParametersResponse> DescribeDefaultClusterParametersAsync(DescribeDefaultClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDefaultClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultClusterParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDefaultClusterParametersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeEndpointAccess

        internal virtual DescribeEndpointAccessResponse DescribeEndpointAccess(DescribeEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Describes a Redshift-managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpointAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointNotFoundException">
        /// The endpoint name doesn't refer to an existing endpoint.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEndpointAccess">REST API Reference for DescribeEndpointAccess Operation</seealso>
        public virtual Task<DescribeEndpointAccessResponse> DescribeEndpointAccessAsync(DescribeEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEndpointAccessResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeEndpointAuthorization

        internal virtual DescribeEndpointAuthorizationResponse DescribeEndpointAuthorization(DescribeEndpointAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointAuthorizationResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointAuthorizationResponse>(request, options);
        }



        /// <summary>
        /// Describes an endpoint authorization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpointAuthorization service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEndpointAuthorization">REST API Reference for DescribeEndpointAuthorization Operation</seealso>
        public virtual Task<DescribeEndpointAuthorizationResponse> DescribeEndpointAuthorizationAsync(DescribeEndpointAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEndpointAuthorizationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeEventCategories

        internal virtual DescribeEventCategoriesResponse DescribeEventCategories()
        {
            return DescribeEventCategories(new DescribeEventCategoriesRequest());
        }
        internal virtual DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventCategoriesResponse>(request, options);
        }


        /// <summary>
        /// Displays a list of event categories for all event source types, or for a specified
        /// source type. For a list of the event categories and source types, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon
        /// Redshift Event Notifications</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEventCategoriesAsync(new DescribeEventCategoriesRequest(), cancellationToken);
        }



        /// <summary>
        /// Displays a list of event categories for all event source types, or for a specified
        /// source type. For a list of the event categories and source types, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon
        /// Redshift Event Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventCategoriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeEvents

        internal virtual DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }
        internal virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsResponse>(request, options);
        }


        /// <summary>
        /// Returns events related to clusters, security groups, snapshots, and parameter groups
        /// for the past 14 days. Events specific to a particular cluster, security group, snapshot
        /// or parameter group can be obtained by providing the name as a parameter. By default,
        /// the past hour of events are returned.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEventsAsync(new DescribeEventsRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns events related to clusters, security groups, snapshots, and parameter groups
        /// for the past 14 days. Events specific to a particular cluster, security group, snapshot
        /// or parameter group can be obtained by providing the name as a parameter. By default,
        /// the past hour of events are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeEventSubscriptions

        internal virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions()
        {
            return DescribeEventSubscriptions(new DescribeEventSubscriptionsRequest());
        }
        internal virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSubscriptionsResponse>(request, options);
        }


        /// <summary>
        /// Lists descriptions of all the Amazon Redshift event notification subscriptions for
        /// a customer account. If you specify a subscription name, lists the description for
        /// that subscription.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all event notification subscriptions that match any combination of the specified keys
        /// and values. For example, if you have <c>owner</c> and <c>environment</c> for tag keys,
        /// and <c>admin</c> and <c>test</c> for tag values, all subscriptions that have any combination
        /// of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subscriptions are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEventSubscriptionsAsync(new DescribeEventSubscriptionsRequest(), cancellationToken);
        }



        /// <summary>
        /// Lists descriptions of all the Amazon Redshift event notification subscriptions for
        /// a customer account. If you specify a subscription name, lists the description for
        /// that subscription.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all event notification subscriptions that match any combination of the specified keys
        /// and values. For example, if you have <c>owner</c> and <c>environment</c> for tag keys,
        /// and <c>admin</c> and <c>test</c> for tag values, all subscriptions that have any combination
        /// of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subscriptions are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventSubscriptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeHsmClientCertificates

        internal virtual DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates()
        {
            return DescribeHsmClientCertificates(new DescribeHsmClientCertificatesRequest());
        }
        internal virtual DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHsmClientCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHsmClientCertificatesResponseUnmarshaller.Instance;

            return Invoke<DescribeHsmClientCertificatesResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the specified HSM client certificate. If no certificate
        /// ID is specified, returns information about all the HSM certificates owned by your
        /// Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM client certificates that match any combination of the specified keys and values.
        /// For example, if you have <c>owner</c> and <c>environment</c> for tag keys, and <c>admin</c>
        /// and <c>test</c> for tag values, all HSM client certificates that have any combination
        /// of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM client certificates
        /// are returned regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmClientCertificates">REST API Reference for DescribeHsmClientCertificates Operation</seealso>
        public virtual Task<DescribeHsmClientCertificatesResponse> DescribeHsmClientCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeHsmClientCertificatesAsync(new DescribeHsmClientCertificatesRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns information about the specified HSM client certificate. If no certificate
        /// ID is specified, returns information about all the HSM certificates owned by your
        /// Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM client certificates that match any combination of the specified keys and values.
        /// For example, if you have <c>owner</c> and <c>environment</c> for tag keys, and <c>admin</c>
        /// and <c>test</c> for tag values, all HSM client certificates that have any combination
        /// of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM client certificates
        /// are returned regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmClientCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmClientCertificates">REST API Reference for DescribeHsmClientCertificates Operation</seealso>
        public virtual Task<DescribeHsmClientCertificatesResponse> DescribeHsmClientCertificatesAsync(DescribeHsmClientCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHsmClientCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHsmClientCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHsmClientCertificatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeHsmConfigurations

        internal virtual DescribeHsmConfigurationsResponse DescribeHsmConfigurations()
        {
            return DescribeHsmConfigurations(new DescribeHsmConfigurationsRequest());
        }
        internal virtual DescribeHsmConfigurationsResponse DescribeHsmConfigurations(DescribeHsmConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHsmConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHsmConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeHsmConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the specified Amazon Redshift HSM configuration. If no configuration
        /// ID is specified, returns information about all the HSM configurations owned by your
        /// Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM connections that match any combination of the specified keys and values. For
        /// example, if you have <c>owner</c> and <c>environment</c> for tag keys, and <c>admin</c>
        /// and <c>test</c> for tag values, all HSM connections that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM connections are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmConfigurations">REST API Reference for DescribeHsmConfigurations Operation</seealso>
        public virtual Task<DescribeHsmConfigurationsResponse> DescribeHsmConfigurationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeHsmConfigurationsAsync(new DescribeHsmConfigurationsRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns information about the specified Amazon Redshift HSM configuration. If no configuration
        /// ID is specified, returns information about all the HSM configurations owned by your
        /// Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM connections that match any combination of the specified keys and values. For
        /// example, if you have <c>owner</c> and <c>environment</c> for tag keys, and <c>admin</c>
        /// and <c>test</c> for tag values, all HSM connections that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM connections are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmConfigurations">REST API Reference for DescribeHsmConfigurations Operation</seealso>
        public virtual Task<DescribeHsmConfigurationsResponse> DescribeHsmConfigurationsAsync(DescribeHsmConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHsmConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHsmConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHsmConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeInboundIntegrations

        internal virtual DescribeInboundIntegrationsResponse DescribeInboundIntegrations(DescribeInboundIntegrationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInboundIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInboundIntegrationsResponseUnmarshaller.Instance;

            return Invoke<DescribeInboundIntegrationsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of inbound integrations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInboundIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInboundIntegrations service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.IntegrationNotFoundException">
        /// The integration can't be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidNamespaceException">
        /// The namespace isn't valid because the namespace doesn't exist. Provide a valid namespace.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeInboundIntegrations">REST API Reference for DescribeInboundIntegrations Operation</seealso>
        public virtual Task<DescribeInboundIntegrationsResponse> DescribeInboundIntegrationsAsync(DescribeInboundIntegrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInboundIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInboundIntegrationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInboundIntegrationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeIntegrations

        internal virtual DescribeIntegrationsResponse DescribeIntegrations(DescribeIntegrationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIntegrationsResponseUnmarshaller.Instance;

            return Invoke<DescribeIntegrationsResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more zero-ETL or S3 event integrations with Amazon Redshift.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIntegrations service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.IntegrationNotFoundException">
        /// The integration can't be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeIntegrations">REST API Reference for DescribeIntegrations Operation</seealso>
        public virtual Task<DescribeIntegrationsResponse> DescribeIntegrationsAsync(DescribeIntegrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIntegrationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIntegrationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeLoggingStatus

        internal virtual DescribeLoggingStatusResponse DescribeLoggingStatus(DescribeLoggingStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoggingStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeLoggingStatusResponse>(request, options);
        }



        /// <summary>
        /// Describes whether information, such as queries and connection attempts, is being logged
        /// for the specified Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoggingStatus service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeLoggingStatus">REST API Reference for DescribeLoggingStatus Operation</seealso>
        public virtual Task<DescribeLoggingStatusResponse> DescribeLoggingStatusAsync(DescribeLoggingStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoggingStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoggingStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeNodeConfigurationOptions

        internal virtual DescribeNodeConfigurationOptionsResponse DescribeNodeConfigurationOptions(DescribeNodeConfigurationOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNodeConfigurationOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNodeConfigurationOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeNodeConfigurationOptionsResponse>(request, options);
        }



        /// <summary>
        /// Returns properties of possible node configurations such as node type, number of nodes,
        /// and disk usage for the specified action type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodeConfigurationOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNodeConfigurationOptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AccessToSnapshotDeniedException">
        /// The owner of the specified snapshot has not authorized your account to access the
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <c>available</c> state, or other accounts
        /// are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeNodeConfigurationOptions">REST API Reference for DescribeNodeConfigurationOptions Operation</seealso>
        public virtual Task<DescribeNodeConfigurationOptionsResponse> DescribeNodeConfigurationOptionsAsync(DescribeNodeConfigurationOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNodeConfigurationOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNodeConfigurationOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNodeConfigurationOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeOrderableClusterOptions

        internal virtual DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions()
        {
            return DescribeOrderableClusterOptions(new DescribeOrderableClusterOptionsRequest());
        }
        internal virtual DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrderableClusterOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableClusterOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOrderableClusterOptionsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of orderable cluster options. Before you create a new cluster you can
        /// use this operation to find what options are available, such as the EC2 Availability
        /// Zones (AZ) in the specific Amazon Web Services Region that you can specify, and the
        /// node types you can request. The node types differ by available storage, memory, CPU
        /// and price. With the cost involved you might want to obtain a list of cluster options
        /// in the specific region and specify values when creating a cluster. For more information
        /// about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeOrderableClusterOptions">REST API Reference for DescribeOrderableClusterOptions Operation</seealso>
        public virtual Task<DescribeOrderableClusterOptionsResponse> DescribeOrderableClusterOptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeOrderableClusterOptionsAsync(new DescribeOrderableClusterOptionsRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns a list of orderable cluster options. Before you create a new cluster you can
        /// use this operation to find what options are available, such as the EC2 Availability
        /// Zones (AZ) in the specific Amazon Web Services Region that you can specify, and the
        /// node types you can request. The node types differ by available storage, memory, CPU
        /// and price. With the cost involved you might want to obtain a list of cluster options
        /// in the specific region and specify values when creating a cluster. For more information
        /// about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableClusterOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeOrderableClusterOptions">REST API Reference for DescribeOrderableClusterOptions Operation</seealso>
        public virtual Task<DescribeOrderableClusterOptionsResponse> DescribeOrderableClusterOptionsAsync(DescribeOrderableClusterOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrderableClusterOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableClusterOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOrderableClusterOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribePartners

        internal virtual DescribePartnersResponse DescribePartners(DescribePartnersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePartnersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePartnersResponseUnmarshaller.Instance;

            return Invoke<DescribePartnersResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the partner integrations defined for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePartners service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePartners service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedPartnerIntegrationException">
        /// The partner integration is not authorized.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribePartners">REST API Reference for DescribePartners Operation</seealso>
        public virtual Task<DescribePartnersResponse> DescribePartnersAsync(DescribePartnersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePartnersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePartnersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePartnersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRedshiftIdcApplications

        internal virtual DescribeRedshiftIdcApplicationsResponse DescribeRedshiftIdcApplications(DescribeRedshiftIdcApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRedshiftIdcApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRedshiftIdcApplicationsResponseUnmarshaller.Instance;

            return Invoke<DescribeRedshiftIdcApplicationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the Amazon Redshift IAM Identity Center applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRedshiftIdcApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRedshiftIdcApplications service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceAccessDeniedException">
        /// A dependent service denied access for the integration.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.RedshiftIdcApplicationNotExistsException">
        /// The application you attempted to find doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeRedshiftIdcApplications">REST API Reference for DescribeRedshiftIdcApplications Operation</seealso>
        public virtual Task<DescribeRedshiftIdcApplicationsResponse> DescribeRedshiftIdcApplicationsAsync(DescribeRedshiftIdcApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRedshiftIdcApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRedshiftIdcApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRedshiftIdcApplicationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeReservedNodeExchangeStatus

        internal virtual DescribeReservedNodeExchangeStatusResponse DescribeReservedNodeExchangeStatus(DescribeReservedNodeExchangeStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodeExchangeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodeExchangeStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedNodeExchangeStatusResponse>(request, options);
        }



        /// <summary>
        /// Returns exchange status details and associated metadata for a reserved-node exchange.
        /// Statuses include such values as in progress and requested.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeExchangeStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedNodeExchangeStatus service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeExchangeNotFoundException">
        /// The reserved-node exchange status wasn't found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodeExchangeStatus">REST API Reference for DescribeReservedNodeExchangeStatus Operation</seealso>
        public virtual Task<DescribeReservedNodeExchangeStatusResponse> DescribeReservedNodeExchangeStatusAsync(DescribeReservedNodeExchangeStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodeExchangeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodeExchangeStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedNodeExchangeStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeReservedNodeOfferings

        internal virtual DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings()
        {
            return DescribeReservedNodeOfferings(new DescribeReservedNodeOfferingsRequest());
        }
        internal virtual DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodeOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodeOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedNodeOfferingsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the available reserved node offerings by Amazon Redshift with their
        /// descriptions including the node type, the fixed and recurring costs of reserving the
        /// node and duration the node will be reserved for you. These descriptions help you determine
        /// which reserve node offering you want to purchase. You then use the unique offering
        /// ID in you call to <a>PurchaseReservedNodeOffering</a> to reserve one or more nodes
        /// for your Amazon Redshift cluster. 
        /// 
        ///  
        /// <para>
        ///  For more information about reserved node offerings, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodeOfferings">REST API Reference for DescribeReservedNodeOfferings Operation</seealso>
        public virtual Task<DescribeReservedNodeOfferingsResponse> DescribeReservedNodeOfferingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedNodeOfferingsAsync(new DescribeReservedNodeOfferingsRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns a list of the available reserved node offerings by Amazon Redshift with their
        /// descriptions including the node type, the fixed and recurring costs of reserving the
        /// node and duration the node will be reserved for you. These descriptions help you determine
        /// which reserve node offering you want to purchase. You then use the unique offering
        /// ID in you call to <a>PurchaseReservedNodeOffering</a> to reserve one or more nodes
        /// for your Amazon Redshift cluster. 
        /// 
        ///  
        /// <para>
        ///  For more information about reserved node offerings, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodeOfferings">REST API Reference for DescribeReservedNodeOfferings Operation</seealso>
        public virtual Task<DescribeReservedNodeOfferingsResponse> DescribeReservedNodeOfferingsAsync(DescribeReservedNodeOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodeOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodeOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedNodeOfferingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeReservedNodes

        internal virtual DescribeReservedNodesResponse DescribeReservedNodes()
        {
            return DescribeReservedNodes(new DescribeReservedNodesRequest());
        }
        internal virtual DescribeReservedNodesResponse DescribeReservedNodes(DescribeReservedNodesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedNodesResponse>(request, options);
        }


        /// <summary>
        /// Returns the descriptions of the reserved nodes.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodes">REST API Reference for DescribeReservedNodes Operation</seealso>
        public virtual Task<DescribeReservedNodesResponse> DescribeReservedNodesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedNodesAsync(new DescribeReservedNodesRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns the descriptions of the reserved nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodes">REST API Reference for DescribeReservedNodes Operation</seealso>
        public virtual Task<DescribeReservedNodesResponse> DescribeReservedNodesAsync(DescribeReservedNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedNodesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeResize

        internal virtual DescribeResizeResponse DescribeResize(DescribeResizeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResizeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResizeResponseUnmarshaller.Instance;

            return Invoke<DescribeResizeResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the last resize operation for the specified cluster. If
        /// no resize operation has ever been initiated for the specified cluster, a <c>HTTP 404</c>
        /// error is returned. If a resize operation was initiated and completed, the status of
        /// the resize remains as <c>SUCCEEDED</c> until the next resize. 
        /// 
        ///  
        /// <para>
        /// A resize operation can be requested using <a>ModifyCluster</a> and specifying a different
        /// number or type of nodes for the cluster. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResize service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeResize service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResizeNotFoundException">
        /// A resize operation for the specified cluster is not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeResize">REST API Reference for DescribeResize Operation</seealso>
        public virtual Task<DescribeResizeResponse> DescribeResizeAsync(DescribeResizeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResizeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResizeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResizeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeScheduledActions

        internal virtual DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledActionsResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduledActionsResponse>(request, options);
        }



        /// <summary>
        /// Describes properties of scheduled actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionNotFoundException">
        /// The scheduled action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        public virtual Task<DescribeScheduledActionsResponse> DescribeScheduledActionsAsync(DescribeScheduledActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledActionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScheduledActionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSnapshotCopyGrants

        internal virtual DescribeSnapshotCopyGrantsResponse DescribeSnapshotCopyGrants(DescribeSnapshotCopyGrantsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotCopyGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotCopyGrantsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotCopyGrantsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of snapshot copy grants owned by the Amazon Web Services account in
        /// the destination region.
        /// 
        ///  
        /// <para>
        ///  For more information about managing snapshot copy grants, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-db-encryption.html">Amazon
        /// Redshift Database Encryption</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotCopyGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshotCopyGrants service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantNotFoundException">
        /// The specified snapshot copy grant can't be found. Make sure that the name is typed
        /// correctly and that the grant exists in the destination region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeSnapshotCopyGrants">REST API Reference for DescribeSnapshotCopyGrants Operation</seealso>
        public virtual Task<DescribeSnapshotCopyGrantsResponse> DescribeSnapshotCopyGrantsAsync(DescribeSnapshotCopyGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotCopyGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotCopyGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotCopyGrantsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSnapshotSchedules

        internal virtual DescribeSnapshotSchedulesResponse DescribeSnapshotSchedules(DescribeSnapshotSchedulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotSchedulesResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotSchedulesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of snapshot schedules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshotSchedules service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeSnapshotSchedules">REST API Reference for DescribeSnapshotSchedules Operation</seealso>
        public virtual Task<DescribeSnapshotSchedulesResponse> DescribeSnapshotSchedulesAsync(DescribeSnapshotSchedulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotSchedulesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotSchedulesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStorage

        internal virtual DescribeStorageResponse DescribeStorage(DescribeStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorageResponseUnmarshaller.Instance;

            return Invoke<DescribeStorageResponse>(request, options);
        }



        /// <summary>
        /// Returns account level backups storage size and provisional storage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStorage service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeStorage">REST API Reference for DescribeStorage Operation</seealso>
        public virtual Task<DescribeStorageResponse> DescribeStorageAsync(DescribeStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorageResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStorageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTableRestoreStatus

        internal virtual DescribeTableRestoreStatusResponse DescribeTableRestoreStatus(DescribeTableRestoreStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTableRestoreStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableRestoreStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeTableRestoreStatusResponse>(request, options);
        }



        /// <summary>
        /// Lists the status of one or more table restore requests made using the <a>RestoreTableFromClusterSnapshot</a>
        /// API action. If you don't specify a value for the <c>TableRestoreRequestId</c> parameter,
        /// then <c>DescribeTableRestoreStatus</c> returns the status of all table restore requests
        /// ordered by the date and time of the request in ascending order. Otherwise <c>DescribeTableRestoreStatus</c>
        /// returns the status of the table specified by <c>TableRestoreRequestId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableRestoreStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTableRestoreStatus service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TableRestoreNotFoundException">
        /// The specified <c>TableRestoreRequestId</c> value was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeTableRestoreStatus">REST API Reference for DescribeTableRestoreStatus Operation</seealso>
        public virtual Task<DescribeTableRestoreStatusResponse> DescribeTableRestoreStatusAsync(DescribeTableRestoreStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTableRestoreStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableRestoreStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTableRestoreStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTags

        internal virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of tags. You can return tags from a specific resource by specifying
        /// an ARN, or you can return all tags for a given type of resource, such as clusters,
        /// snapshots, and so on.
        /// 
        ///  
        /// <para>
        /// The following are limitations for <c>DescribeTags</c>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot specify an ARN and a resource-type value together in the same request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use the <c>MaxRecords</c> and <c>Marker</c> parameters together with the
        /// ARN parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>MaxRecords</c> parameter can be a range from 10 to 50 results to return in
        /// a request.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all resources that match any combination of the specified keys and values. For example,
        /// if you have <c>owner</c> and <c>environment</c> for tag keys, and <c>admin</c> and
        /// <c>test</c> for tag values, all resources that have any combination of those values
        /// are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, resources are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeUsageLimits

        internal virtual DescribeUsageLimitsResponse DescribeUsageLimits(DescribeUsageLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUsageLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUsageLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeUsageLimitsResponse>(request, options);
        }



        /// <summary>
        /// Shows usage limits on a cluster. Results are filtered based on the combination of
        /// input usage limit identifier, cluster identifier, and feature type parameters:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If usage limit identifier, cluster identifier, and feature type are not provided,
        /// then all usage limit objects for the current account in the current region are returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If usage limit identifier is provided, then the corresponding usage limit object is
        /// returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If cluster identifier is provided, then all usage limit objects for the specified
        /// cluster are returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If cluster identifier and feature type are provided, then all usage limit objects
        /// for the combination of cluster and feature are returned.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsageLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUsageLimits service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeUsageLimits">REST API Reference for DescribeUsageLimits Operation</seealso>
        public virtual Task<DescribeUsageLimitsResponse> DescribeUsageLimitsAsync(DescribeUsageLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUsageLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUsageLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUsageLimitsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisableLogging

        internal virtual DisableLoggingResponse DisableLogging(DisableLoggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableLoggingResponseUnmarshaller.Instance;

            return Invoke<DisableLoggingResponse>(request, options);
        }



        /// <summary>
        /// Stops logging information, such as queries and connection attempts, for the specified
        /// Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableLogging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableLogging service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisableLogging">REST API Reference for DisableLogging Operation</seealso>
        public virtual Task<DisableLoggingResponse> DisableLoggingAsync(DisableLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<DisableLoggingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisableSnapshotCopy

        internal virtual DisableSnapshotCopyResponse DisableSnapshotCopy(DisableSnapshotCopyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableSnapshotCopyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSnapshotCopyResponseUnmarshaller.Instance;

            return Invoke<DisableSnapshotCopyResponse>(request, options);
        }



        /// <summary>
        /// Disables the automatic copying of snapshots from one region to another region for
        /// a specified cluster.
        /// 
        ///  
        /// <para>
        /// If your cluster and its snapshots are encrypted using an encrypted symmetric key from
        /// Key Management Service, use <a>DeleteSnapshotCopyGrant</a> to delete the grant that
        /// grants Amazon Redshift permission to the key in the destination region. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSnapshotCopy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableSnapshotCopy service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyAlreadyDisabledException">
        /// The cluster already has cross-region snapshot copy disabled.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisableSnapshotCopy">REST API Reference for DisableSnapshotCopy Operation</seealso>
        public virtual Task<DisableSnapshotCopyResponse> DisableSnapshotCopyAsync(DisableSnapshotCopyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableSnapshotCopyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSnapshotCopyResponseUnmarshaller.Instance;

            return InvokeAsync<DisableSnapshotCopyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateDataShareConsumer

        internal virtual DisassociateDataShareConsumerResponse DisassociateDataShareConsumer(DisassociateDataShareConsumerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDataShareConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDataShareConsumerResponseUnmarshaller.Instance;

            return Invoke<DisassociateDataShareConsumerResponse>(request, options);
        }



        /// <summary>
        /// From a datashare consumer account, remove association for the specified datashare.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDataShareConsumer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateDataShareConsumer service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidDataShareException">
        /// There is an error with the datashare.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidNamespaceException">
        /// The namespace isn't valid because the namespace doesn't exist. Provide a valid namespace.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisassociateDataShareConsumer">REST API Reference for DisassociateDataShareConsumer Operation</seealso>
        public virtual Task<DisassociateDataShareConsumerResponse> DisassociateDataShareConsumerAsync(DisassociateDataShareConsumerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDataShareConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDataShareConsumerResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateDataShareConsumerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EnableLogging

        internal virtual EnableLoggingResponse EnableLogging(EnableLoggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableLoggingResponseUnmarshaller.Instance;

            return Invoke<EnableLoggingResponse>(request, options);
        }



        /// <summary>
        /// Starts logging information, such as queries and connection attempts, for the specified
        /// Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableLogging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableLogging service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.BucketNotFoundException">
        /// Could not find the specified S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientS3BucketPolicyException">
        /// The cluster does not have read bucket or put object permissions on the S3 bucket specified
        /// when enabling logging.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidS3BucketNameException">
        /// The S3 bucket name is invalid. For more information about naming rules, go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/BucketRestrictions.html">Bucket
        /// Restrictions and Limitations</a> in the Amazon Simple Storage Service (S3) Developer
        /// Guide.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidS3KeyPrefixException">
        /// The string specified for the logging S3 key prefix does not comply with the documented
        /// constraints.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/EnableLogging">REST API Reference for EnableLogging Operation</seealso>
        public virtual Task<EnableLoggingResponse> EnableLoggingAsync(EnableLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<EnableLoggingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EnableSnapshotCopy

        internal virtual EnableSnapshotCopyResponse EnableSnapshotCopy(EnableSnapshotCopyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSnapshotCopyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSnapshotCopyResponseUnmarshaller.Instance;

            return Invoke<EnableSnapshotCopyResponse>(request, options);
        }



        /// <summary>
        /// Enables the automatic copy of snapshots from one region to another region for a specified
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSnapshotCopy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableSnapshotCopy service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.CopyToRegionDisabledException">
        /// Cross-region snapshot copy was temporarily disabled. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.IncompatibleOrderableOptionsException">
        /// The specified options are incompatible.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in Amazon Web Services KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyAlreadyEnabledException">
        /// The cluster already has cross-region snapshot copy enabled.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantNotFoundException">
        /// The specified snapshot copy grant can't be found. Make sure that the name is typed
        /// correctly and that the grant exists in the destination region.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnknownSnapshotCopyRegionException">
        /// The specified region is incorrect or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/EnableSnapshotCopy">REST API Reference for EnableSnapshotCopy Operation</seealso>
        public virtual Task<EnableSnapshotCopyResponse> EnableSnapshotCopyAsync(EnableSnapshotCopyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSnapshotCopyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSnapshotCopyResponseUnmarshaller.Instance;

            return InvokeAsync<EnableSnapshotCopyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  FailoverPrimaryCompute

        internal virtual FailoverPrimaryComputeResponse FailoverPrimaryCompute(FailoverPrimaryComputeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = FailoverPrimaryComputeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverPrimaryComputeResponseUnmarshaller.Instance;

            return Invoke<FailoverPrimaryComputeResponse>(request, options);
        }



        /// <summary>
        /// Fails over the primary compute unit of the specified Multi-AZ cluster to another Availability
        /// Zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverPrimaryCompute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FailoverPrimaryCompute service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/FailoverPrimaryCompute">REST API Reference for FailoverPrimaryCompute Operation</seealso>
        public virtual Task<FailoverPrimaryComputeResponse> FailoverPrimaryComputeAsync(FailoverPrimaryComputeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = FailoverPrimaryComputeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverPrimaryComputeResponseUnmarshaller.Instance;

            return InvokeAsync<FailoverPrimaryComputeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetClusterCredentials

        internal virtual GetClusterCredentialsResponse GetClusterCredentials(GetClusterCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClusterCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetClusterCredentialsResponse>(request, options);
        }



        /// <summary>
        /// Returns a database user name and temporary password with temporary authorization to
        /// log on to an Amazon Redshift database. The action returns the database user name prefixed
        /// with <c>IAM:</c> if <c>AutoCreate</c> is <c>False</c> or <c>IAMA:</c> if <c>AutoCreate</c>
        /// is <c>True</c>. You can optionally specify one or more database user groups that the
        /// user will join at log on. By default, the temporary credentials expire in 900 seconds.
        /// You can optionally specify a duration between 900 seconds (15 minutes) and 3600 seconds
        /// (60 minutes). For more information, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/generating-user-credentials.html">Using
        /// IAM Authentication to Generate Database User Credentials</a> in the Amazon Redshift
        /// Cluster Management Guide.
        /// 
        ///  
        /// <para>
        /// The Identity and Access Management (IAM) user or role that runs GetClusterCredentials
        /// must have an IAM policy attached that allows access to all necessary actions and resources.
        /// For more information about permissions, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/redshift-iam-access-control-identity-based.html#redshift-policy-resources.getclustercredentials-resources">Resource
        /// Policies for GetClusterCredentials</a> in the Amazon Redshift Cluster Management Guide.
        /// </para>
        ///  
        /// <para>
        /// If the <c>DbGroups</c> parameter is specified, the IAM policy must allow the <c>redshift:JoinGroup</c>
        /// action with access to the listed <c>dbgroups</c>. 
        /// </para>
        ///  
        /// <para>
        /// In addition, if the <c>AutoCreate</c> parameter is set to <c>True</c>, then the policy
        /// must include the <c>redshift:CreateClusterUser</c> permission.
        /// </para>
        ///  
        /// <para>
        /// If the <c>DbName</c> parameter is specified, the IAM policy must allow access to the
        /// resource <c>dbname</c> for the specified database name. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClusterCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetClusterCredentials service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetClusterCredentials">REST API Reference for GetClusterCredentials Operation</seealso>
        public virtual Task<GetClusterCredentialsResponse> GetClusterCredentialsAsync(GetClusterCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClusterCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<GetClusterCredentialsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetClusterCredentialsWithIAM

        internal virtual GetClusterCredentialsWithIAMResponse GetClusterCredentialsWithIAM(GetClusterCredentialsWithIAMRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClusterCredentialsWithIAMRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterCredentialsWithIAMResponseUnmarshaller.Instance;

            return Invoke<GetClusterCredentialsWithIAMResponse>(request, options);
        }



        /// <summary>
        /// Returns a database user name and temporary password with temporary authorization to
        /// log in to an Amazon Redshift database. The database user is mapped 1:1 to the source
        /// Identity and Access Management (IAM) identity. For more information about IAM identities,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id.html">IAM Identities
        /// (users, user groups, and roles)</a> in the Amazon Web Services Identity and Access
        /// Management User Guide.
        /// 
        ///  
        /// <para>
        /// The Identity and Access Management (IAM) identity that runs this operation must have
        /// an IAM policy attached that allows access to all necessary actions and resources.
        /// For more information about permissions, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/redshift-iam-access-control-identity-based.html">Using
        /// identity-based policies (IAM policies)</a> in the Amazon Redshift Cluster Management
        /// Guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClusterCredentialsWithIAM service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetClusterCredentialsWithIAM service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetClusterCredentialsWithIAM">REST API Reference for GetClusterCredentialsWithIAM Operation</seealso>
        public virtual Task<GetClusterCredentialsWithIAMResponse> GetClusterCredentialsWithIAMAsync(GetClusterCredentialsWithIAMRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClusterCredentialsWithIAMRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterCredentialsWithIAMResponseUnmarshaller.Instance;

            return InvokeAsync<GetClusterCredentialsWithIAMResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReservedNodeExchangeConfigurationOptions

        internal virtual GetReservedNodeExchangeConfigurationOptionsResponse GetReservedNodeExchangeConfigurationOptions(GetReservedNodeExchangeConfigurationOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservedNodeExchangeConfigurationOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservedNodeExchangeConfigurationOptionsResponseUnmarshaller.Instance;

            return Invoke<GetReservedNodeExchangeConfigurationOptionsResponse>(request, options);
        }



        /// <summary>
        /// Gets the configuration options for the reserved-node exchange. These options include
        /// information about the source reserved node and target reserved node offering. Details
        /// include the node type, the price, the node count, and the offering type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservedNodeExchangeConfigurationOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReservedNodeExchangeConfigurationOptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidReservedNodeStateException">
        /// Indicates that the Reserved Node being exchanged is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyMigratedException">
        /// Indicates that the reserved node has already been exchanged.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetReservedNodeExchangeConfigurationOptions">REST API Reference for GetReservedNodeExchangeConfigurationOptions Operation</seealso>
        public virtual Task<GetReservedNodeExchangeConfigurationOptionsResponse> GetReservedNodeExchangeConfigurationOptionsAsync(GetReservedNodeExchangeConfigurationOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservedNodeExchangeConfigurationOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservedNodeExchangeConfigurationOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetReservedNodeExchangeConfigurationOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReservedNodeExchangeOfferings

        internal virtual GetReservedNodeExchangeOfferingsResponse GetReservedNodeExchangeOfferings(GetReservedNodeExchangeOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservedNodeExchangeOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservedNodeExchangeOfferingsResponseUnmarshaller.Instance;

            return Invoke<GetReservedNodeExchangeOfferingsResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of DC2 ReservedNodeOfferings that matches the payment type, term,
        /// and usage price of the given DC1 reserved node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservedNodeExchangeOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReservedNodeExchangeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidReservedNodeStateException">
        /// Indicates that the Reserved Node being exchanged is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyMigratedException">
        /// Indicates that the reserved node has already been exchanged.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetReservedNodeExchangeOfferings">REST API Reference for GetReservedNodeExchangeOfferings Operation</seealso>
        public virtual Task<GetReservedNodeExchangeOfferingsResponse> GetReservedNodeExchangeOfferingsAsync(GetReservedNodeExchangeOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservedNodeExchangeOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservedNodeExchangeOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetReservedNodeExchangeOfferingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResourcePolicy

        internal virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Get the resource policy for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidPolicyException">
        /// The resource policy isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRecommendations

        internal virtual ListRecommendationsResponse ListRecommendations(ListRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// List the Amazon Redshift Advisor recommendations for one or multiple Amazon Redshift
        /// clusters in an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        public virtual Task<ListRecommendationsResponse> ListRecommendationsAsync(ListRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyAquaConfiguration

        internal virtual ModifyAquaConfigurationResponse ModifyAquaConfiguration(ModifyAquaConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyAquaConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyAquaConfigurationResponseUnmarshaller.Instance;

            return Invoke<ModifyAquaConfigurationResponse>(request, options);
        }



        /// <summary>
        /// This operation is retired. Calling this operation does not change AQUA configuration.
        /// Amazon Redshift automatically determines whether to use AQUA (Advanced Query Accelerator).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyAquaConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyAquaConfiguration service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyAquaConfiguration">REST API Reference for ModifyAquaConfiguration Operation</seealso>
        public virtual Task<ModifyAquaConfigurationResponse> ModifyAquaConfigurationAsync(ModifyAquaConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyAquaConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyAquaConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyAquaConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyAuthenticationProfile

        internal virtual ModifyAuthenticationProfileResponse ModifyAuthenticationProfile(ModifyAuthenticationProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyAuthenticationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyAuthenticationProfileResponseUnmarshaller.Instance;

            return Invoke<ModifyAuthenticationProfileResponse>(request, options);
        }



        /// <summary>
        /// Modifies an authentication profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyAuthenticationProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyAuthenticationProfile service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthenticationProfileNotFoundException">
        /// The authentication profile can't be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthenticationProfileQuotaExceededException">
        /// The size or number of authentication profiles has exceeded the quota. The maximum
        /// length of the JSON string and maximum number of authentication profiles is determined
        /// by a quota for your account.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidAuthenticationProfileRequestException">
        /// The authentication profile request is not valid. The profile name can't be null or
        /// empty. The authentication profile API operation must be available in the Amazon Web
        /// Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyAuthenticationProfile">REST API Reference for ModifyAuthenticationProfile Operation</seealso>
        public virtual Task<ModifyAuthenticationProfileResponse> ModifyAuthenticationProfileAsync(ModifyAuthenticationProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyAuthenticationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyAuthenticationProfileResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyAuthenticationProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyCluster

        internal virtual ModifyClusterResponse ModifyCluster(ModifyClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterResponse>(request, options);
        }



        /// <summary>
        /// Modifies the settings for a cluster.
        /// 
        ///  
        /// <para>
        /// You can also change node type and the number of nodes to scale up or down the cluster.
        /// When resizing a cluster, you must specify both the number of nodes and the node type
        /// even if one of the parameters does not change.
        /// </para>
        ///  
        /// <para>
        /// You can add another security or parameter group, or change the admin user password.
        /// Resetting a cluster password or modifying the security groups associated with a cluster
        /// do not need a reboot. However, modifying a parameter group requires a reboot for parameters
        /// to take effect. For more information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// VPC Block Public Access (BPA) enables you to block resources in VPCs and subnets that
        /// you own in a Region from reaching or being reached from the internet through internet
        /// gateways and egress-only internet gateways. If a subnet group for a provisioned cluster
        /// is in an account with VPC BPA turned on, the following capabilities are blocked:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creating a public cluster
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Restoring a public cluster
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Modifying a private cluster to be public
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Adding a subnet with VPC BPA turned on to the subnet group when there's at least one
        /// public cluster within the group
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about VPC BPA, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/security-vpc-bpa.html">Block
        /// public access to VPCs and subnets</a> in the <i>Amazon VPC User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.CustomCnameAssociationException">
        /// An error occurred when an attempt was made to change the custom domain association.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <c>available</c>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterTrackException">
        /// The provided cluster track name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.Ipv6CidrBlockNotFoundException">
        /// There are no subnets in your VPC with associated IPv6 CIDR blocks. To use dual-stack
        /// mode, associate an IPv6 CIDR block with each subnet in your VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in Amazon Web Services KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TableLimitExceededException">
        /// The number of tables in the cluster exceeds the limit for the requested new cluster
        /// node type.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOptionException">
        /// A request option was specified that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyCluster">REST API Reference for ModifyCluster Operation</seealso>
        public virtual Task<ModifyClusterResponse> ModifyClusterAsync(ModifyClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyClusterDbRevision

        internal virtual ModifyClusterDbRevisionResponse ModifyClusterDbRevision(ModifyClusterDbRevisionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterDbRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterDbRevisionResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterDbRevisionResponse>(request, options);
        }



        /// <summary>
        /// Modifies the database revision of a cluster. The database revision is a unique revision
        /// of the database running in a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterDbRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyClusterDbRevision service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterOnLatestRevisionException">
        /// Cluster is already on the latest database revision.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterDbRevision">REST API Reference for ModifyClusterDbRevision Operation</seealso>
        public virtual Task<ModifyClusterDbRevisionResponse> ModifyClusterDbRevisionAsync(ModifyClusterDbRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterDbRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterDbRevisionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterDbRevisionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyClusterIamRoles

        internal virtual ModifyClusterIamRolesResponse ModifyClusterIamRoles(ModifyClusterIamRolesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterIamRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterIamRolesResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterIamRolesResponse>(request, options);
        }



        /// <summary>
        /// Modifies the list of Identity and Access Management (IAM) roles that can be used by
        /// the cluster to access other Amazon Web Services services.
        /// 
        ///  
        /// <para>
        /// The maximum number of IAM roles that you can associate is subject to a quota. For
        /// more information, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Quotas
        /// and limits</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterIamRoles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyClusterIamRoles service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterIamRoles">REST API Reference for ModifyClusterIamRoles Operation</seealso>
        public virtual Task<ModifyClusterIamRolesResponse> ModifyClusterIamRolesAsync(ModifyClusterIamRolesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterIamRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterIamRolesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterIamRolesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyClusterMaintenance

        internal virtual ModifyClusterMaintenanceResponse ModifyClusterMaintenance(ModifyClusterMaintenanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterMaintenanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterMaintenanceResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterMaintenanceResponse>(request, options);
        }



        /// <summary>
        /// Modifies the maintenance settings of a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterMaintenance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyClusterMaintenance service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterMaintenance">REST API Reference for ModifyClusterMaintenance Operation</seealso>
        public virtual Task<ModifyClusterMaintenanceResponse> ModifyClusterMaintenanceAsync(ModifyClusterMaintenanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterMaintenanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterMaintenanceResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterMaintenanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyClusterParameterGroup

        internal virtual ModifyClusterParameterGroupResponse ModifyClusterParameterGroup(ModifyClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies the parameters of a parameter group. For the parameters parameter, it can't
        /// contain ASCII characters.
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because another task is in
        /// progress that involves the parameter group. Wait a few moments and try the operation
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterParameterGroup">REST API Reference for ModifyClusterParameterGroup Operation</seealso>
        public virtual Task<ModifyClusterParameterGroupResponse> ModifyClusterParameterGroupAsync(ModifyClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyClusterSnapshot

        internal virtual ModifyClusterSnapshotResponse ModifyClusterSnapshot(ModifyClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Modifies the settings for a snapshot.
        /// 
        ///  
        /// <para>
        /// This exanmple modifies the manual retention period setting for a cluster snapshot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <c>available</c> state, or other accounts
        /// are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSnapshot">REST API Reference for ModifyClusterSnapshot Operation</seealso>
        public virtual Task<ModifyClusterSnapshotResponse> ModifyClusterSnapshotAsync(ModifyClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyClusterSnapshotSchedule

        internal virtual ModifyClusterSnapshotScheduleResponse ModifyClusterSnapshotSchedule(ModifyClusterSnapshotScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterSnapshotScheduleResponse>(request, options);
        }



        /// <summary>
        /// Modifies a snapshot schedule for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSnapshotSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyClusterSnapshotSchedule service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotScheduleStateException">
        /// The cluster snapshot schedule state is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSnapshotSchedule">REST API Reference for ModifyClusterSnapshotSchedule Operation</seealso>
        public virtual Task<ModifyClusterSnapshotScheduleResponse> ModifyClusterSnapshotScheduleAsync(ModifyClusterSnapshotScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterSnapshotScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterSnapshotScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyClusterSubnetGroup

        internal virtual ModifyClusterSubnetGroupResponse ModifyClusterSubnetGroup(ModifyClusterSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterSubnetGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies a cluster subnet group to include the specified list of VPC subnets. The
        /// operation replaces the existing list of subnets with the new list of subnets.
        /// 
        ///  
        /// <para>
        /// VPC Block Public Access (BPA) enables you to block resources in VPCs and subnets that
        /// you own in a Region from reaching or being reached from the internet through internet
        /// gateways and egress-only internet gateways. If a subnet group for a provisioned cluster
        /// is in an account with VPC BPA turned on, the following capabilities are blocked:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creating a public cluster
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Restoring a public cluster
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Modifying a private cluster to be public
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Adding a subnet with VPC BPA turned on to the subnet group when there's at least one
        /// public cluster within the group
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about VPC BPA, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/security-vpc-bpa.html">Block
        /// public access to VPCs and subnets</a> in the <i>Amazon VPC User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetQuotaExceededException">
        /// The request would result in user exceeding the allowed number of subnets in a cluster
        /// subnet groups. For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubnetAlreadyInUseException">
        /// A specified subnet is already in use by another cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSubnetGroup">REST API Reference for ModifyClusterSubnetGroup Operation</seealso>
        public virtual Task<ModifyClusterSubnetGroupResponse> ModifyClusterSubnetGroupAsync(ModifyClusterSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterSubnetGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyCustomDomainAssociation

        internal virtual ModifyCustomDomainAssociationResponse ModifyCustomDomainAssociation(ModifyCustomDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCustomDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<ModifyCustomDomainAssociationResponse>(request, options);
        }



        /// <summary>
        /// Contains information for changing a custom domain association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCustomDomainAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyCustomDomainAssociation service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.CustomCnameAssociationException">
        /// An error occurred when an attempt was made to change the custom domain association.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.CustomDomainAssociationNotFoundException">
        /// An error occurred. The custom domain name couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyCustomDomainAssociation">REST API Reference for ModifyCustomDomainAssociation Operation</seealso>
        public virtual Task<ModifyCustomDomainAssociationResponse> ModifyCustomDomainAssociationAsync(ModifyCustomDomainAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCustomDomainAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyCustomDomainAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyEndpointAccess

        internal virtual ModifyEndpointAccessResponse ModifyEndpointAccess(ModifyEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<ModifyEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Modifies a Redshift-managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyEndpointAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointNotFoundException">
        /// The endpoint name doesn't refer to an existing endpoint.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <c>available</c>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidEndpointStateException">
        /// The status of the endpoint is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyEndpointAccess">REST API Reference for ModifyEndpointAccess Operation</seealso>
        public virtual Task<ModifyEndpointAccessResponse> ModifyEndpointAccessAsync(ModifyEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyEndpointAccessResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyEventSubscription

        internal virtual ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ModifyEventSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Modifies an existing Amazon Redshift event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubscriptionStateException">
        /// The subscription request is invalid because it is a duplicate request. This subscription
        /// request is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSInvalidTopicException">
        /// Amazon SNS has responded that there is a problem with the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSTopicArnNotFoundException">
        /// An Amazon SNS topic with the specified Amazon Resource Name (ARN) does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SourceNotFoundException">
        /// The specified Amazon Redshift event source could not be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionCategoryNotFoundException">
        /// The value specified for the event category was not one of the allowed values, or it
        /// specified a category that does not apply to the specified source type. The allowed
        /// values are Configuration, Management, Monitoring, and Security.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionEventIdNotFoundException">
        /// An Amazon Redshift event with the specified event ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionSeverityNotFoundException">
        /// The value specified for the event severity was not one of the allowed values, or it
        /// specified a severity that does not apply to the specified source type. The allowed
        /// values are ERROR and INFO.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyEventSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyIntegration

        internal virtual ModifyIntegrationResponse ModifyIntegration(ModifyIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyIntegrationResponseUnmarshaller.Instance;

            return Invoke<ModifyIntegrationResponse>(request, options);
        }



        /// <summary>
        /// Modifies a zero-ETL integration or S3 event integration with Amazon Redshift.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyIntegration service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.IntegrationAlreadyExistsException">
        /// The integration you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.IntegrationConflictOperationException">
        /// A conflicting conditional operation is currently in progress against this resource.
        /// This typically occurs when there are multiple requests being made to the same resource
        /// at the same time, and these requests conflict with each other.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.IntegrationConflictStateException">
        /// The integration is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.IntegrationNotFoundException">
        /// The integration can't be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyIntegration">REST API Reference for ModifyIntegration Operation</seealso>
        public virtual Task<ModifyIntegrationResponse> ModifyIntegrationAsync(ModifyIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyIntegrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyRedshiftIdcApplication

        internal virtual ModifyRedshiftIdcApplicationResponse ModifyRedshiftIdcApplication(ModifyRedshiftIdcApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyRedshiftIdcApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyRedshiftIdcApplicationResponseUnmarshaller.Instance;

            return Invoke<ModifyRedshiftIdcApplicationResponse>(request, options);
        }



        /// <summary>
        /// Changes an existing Amazon Redshift IAM Identity Center application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyRedshiftIdcApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyRedshiftIdcApplication service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceAccessDeniedException">
        /// A dependent service denied access for the integration.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.RedshiftIdcApplicationNotExistsException">
        /// The application you attempted to find doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyRedshiftIdcApplication">REST API Reference for ModifyRedshiftIdcApplication Operation</seealso>
        public virtual Task<ModifyRedshiftIdcApplicationResponse> ModifyRedshiftIdcApplicationAsync(ModifyRedshiftIdcApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyRedshiftIdcApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyRedshiftIdcApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyRedshiftIdcApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyScheduledAction

        internal virtual ModifyScheduledActionResponse ModifyScheduledAction(ModifyScheduledActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyScheduledActionResponseUnmarshaller.Instance;

            return Invoke<ModifyScheduledActionResponse>(request, options);
        }



        /// <summary>
        /// Modifies a scheduled action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyScheduledAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyScheduledAction service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduledActionException">
        /// The scheduled action is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduleException">
        /// The schedule you submitted isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionNotFoundException">
        /// The scheduled action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionTypeUnsupportedException">
        /// The action type specified for a scheduled action is not supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyScheduledAction">REST API Reference for ModifyScheduledAction Operation</seealso>
        public virtual Task<ModifyScheduledActionResponse> ModifyScheduledActionAsync(ModifyScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyScheduledActionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyScheduledActionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifySnapshotCopyRetentionPeriod

        internal virtual ModifySnapshotCopyRetentionPeriodResponse ModifySnapshotCopyRetentionPeriod(ModifySnapshotCopyRetentionPeriodRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySnapshotCopyRetentionPeriodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance;

            return Invoke<ModifySnapshotCopyRetentionPeriodResponse>(request, options);
        }



        /// <summary>
        /// Modifies the number of days to retain snapshots in the destination Amazon Web Services
        /// Region after they are copied from the source Amazon Web Services Region. By default,
        /// this operation only changes the retention period of copied automated snapshots. The
        /// retention periods for both new and existing copied automated snapshots are updated
        /// with the new retention period. You can set the manual option to change only the retention
        /// periods of copied manual snapshots. If you set this option, only newly copied manual
        /// snapshots have the new retention period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotCopyRetentionPeriod service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifySnapshotCopyRetentionPeriod service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyDisabledException">
        /// Cross-region snapshot copy was temporarily disabled. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifySnapshotCopyRetentionPeriod">REST API Reference for ModifySnapshotCopyRetentionPeriod Operation</seealso>
        public virtual Task<ModifySnapshotCopyRetentionPeriodResponse> ModifySnapshotCopyRetentionPeriodAsync(ModifySnapshotCopyRetentionPeriodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySnapshotCopyRetentionPeriodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySnapshotCopyRetentionPeriodResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifySnapshotSchedule

        internal virtual ModifySnapshotScheduleResponse ModifySnapshotSchedule(ModifySnapshotScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<ModifySnapshotScheduleResponse>(request, options);
        }



        /// <summary>
        /// Modifies a snapshot schedule. Any schedule associated with a cluster is modified asynchronously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifySnapshotSchedule service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduleException">
        /// The schedule you submitted isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleUpdateInProgressException">
        /// The specified snapshot schedule is already being updated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifySnapshotSchedule">REST API Reference for ModifySnapshotSchedule Operation</seealso>
        public virtual Task<ModifySnapshotScheduleResponse> ModifySnapshotScheduleAsync(ModifySnapshotScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySnapshotScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySnapshotScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyUsageLimit

        internal virtual ModifyUsageLimitResponse ModifyUsageLimit(ModifyUsageLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyUsageLimitResponseUnmarshaller.Instance;

            return Invoke<ModifyUsageLimitResponse>(request, options);
        }



        /// <summary>
        /// Modifies a usage limit in a cluster. You can't modify the feature type or period of
        /// a usage limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyUsageLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyUsageLimit service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidUsageLimitException">
        /// The usage limit is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UsageLimitNotFoundException">
        /// The usage limit identifier can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyUsageLimit">REST API Reference for ModifyUsageLimit Operation</seealso>
        public virtual Task<ModifyUsageLimitResponse> ModifyUsageLimitAsync(ModifyUsageLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyUsageLimitResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyUsageLimitResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PauseCluster

        internal virtual PauseClusterResponse PauseCluster(PauseClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PauseClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PauseClusterResponseUnmarshaller.Instance;

            return Invoke<PauseClusterResponse>(request, options);
        }



        /// <summary>
        /// Pauses a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PauseCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PauseCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/PauseCluster">REST API Reference for PauseCluster Operation</seealso>
        public virtual Task<PauseClusterResponse> PauseClusterAsync(PauseClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PauseClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PauseClusterResponseUnmarshaller.Instance;

            return InvokeAsync<PauseClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PurchaseReservedNodeOffering

        internal virtual PurchaseReservedNodeOfferingResponse PurchaseReservedNodeOffering(PurchaseReservedNodeOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedNodeOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedNodeOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedNodeOfferingResponse>(request, options);
        }



        /// <summary>
        /// Allows you to purchase reserved nodes. Amazon Redshift offers a predefined set of
        /// reserved node offerings. You can purchase one or more of the offerings. You can call
        /// the <a>DescribeReservedNodeOfferings</a> API to obtain the available reserved node
        /// offerings. You can call this API by providing a specific reserved node offering and
        /// the number of nodes you want to reserve. 
        /// 
        ///  
        /// <para>
        ///  For more information about reserved node offerings, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodeOffering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseReservedNodeOffering service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeQuotaExceededException">
        /// Request would exceed the user's compute node quota. For information about increasing
        /// your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/PurchaseReservedNodeOffering">REST API Reference for PurchaseReservedNodeOffering Operation</seealso>
        public virtual Task<PurchaseReservedNodeOfferingResponse> PurchaseReservedNodeOfferingAsync(PurchaseReservedNodeOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedNodeOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedNodeOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseReservedNodeOfferingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutResourcePolicy

        internal virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Updates the resource policy for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ConflictPolicyUpdateException">
        /// There is a conflict while updating the resource policy.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidPolicyException">
        /// The resource policy isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RebootCluster

        internal virtual RebootClusterResponse RebootCluster(RebootClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootClusterResponseUnmarshaller.Instance;

            return Invoke<RebootClusterResponse>(request, options);
        }



        /// <summary>
        /// Reboots a cluster. This action is taken as soon as possible. It results in a momentary
        /// outage to the cluster, during which the cluster status is set to <c>rebooting</c>.
        /// A cluster event is created when the reboot is completed. Any pending cluster modifications
        /// (see <a>ModifyCluster</a>) are applied at this reboot. For more information about
        /// managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RebootCluster">REST API Reference for RebootCluster Operation</seealso>
        public virtual Task<RebootClusterResponse> RebootClusterAsync(RebootClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootClusterResponseUnmarshaller.Instance;

            return InvokeAsync<RebootClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RegisterNamespace

        internal virtual RegisterNamespaceResponse RegisterNamespace(RegisterNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterNamespaceResponseUnmarshaller.Instance;

            return Invoke<RegisterNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Registers a cluster or serverless namespace to the Amazon Web Services Glue Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterNamespace service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidNamespaceException">
        /// The namespace isn't valid because the namespace doesn't exist. Provide a valid namespace.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RegisterNamespace">REST API Reference for RegisterNamespace Operation</seealso>
        public virtual Task<RegisterNamespaceResponse> RegisterNamespaceAsync(RegisterNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RejectDataShare

        internal virtual RejectDataShareResponse RejectDataShare(RejectDataShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectDataShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectDataShareResponseUnmarshaller.Instance;

            return Invoke<RejectDataShareResponse>(request, options);
        }



        /// <summary>
        /// From a datashare consumer account, rejects the specified datashare.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectDataShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectDataShare service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidDataShareException">
        /// There is an error with the datashare.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RejectDataShare">REST API Reference for RejectDataShare Operation</seealso>
        public virtual Task<RejectDataShareResponse> RejectDataShareAsync(RejectDataShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectDataShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectDataShareResponseUnmarshaller.Instance;

            return InvokeAsync<RejectDataShareResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ResetClusterParameterGroup

        internal virtual ResetClusterParameterGroupResponse ResetClusterParameterGroup(ResetClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetClusterParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Sets one or more parameters of the specified parameter group to their default values
        /// and sets the source values of the parameters to "engine-default". To reset the entire
        /// parameter group specify the <i>ResetAllParameters</i> parameter. For parameter changes
        /// to take effect you must reboot any associated clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because another task is in
        /// progress that involves the parameter group. Wait a few moments and try the operation
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResetClusterParameterGroup">REST API Reference for ResetClusterParameterGroup Operation</seealso>
        public virtual Task<ResetClusterParameterGroupResponse> ResetClusterParameterGroupAsync(ResetClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ResetClusterParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ResizeCluster

        internal virtual ResizeClusterResponse ResizeCluster(ResizeClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResizeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResizeClusterResponseUnmarshaller.Instance;

            return Invoke<ResizeClusterResponse>(request, options);
        }



        /// <summary>
        /// Changes the size of the cluster. You can change the cluster's type, or change the
        /// number or type of nodes. The default behavior is to use the elastic resize method.
        /// With an elastic resize, your cluster is available for read and write operations more
        /// quickly than with the classic resize method. 
        /// 
        ///  
        /// <para>
        /// Elastic resize operations have the following restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can only resize clusters of the following types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// dc2.large
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// dc2.8xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ra3.large
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ra3.xlplus
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ra3.4xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ra3.16xlarge
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// The type of nodes that you add must match the node type for the cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResizeCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResizeCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidReservedNodeStateException">
        /// Indicates that the Reserved Node being exchanged is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in Amazon Web Services KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyMigratedException">
        /// Indicates that the reserved node has already been exchanged.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOptionException">
        /// A request option was specified that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResizeCluster">REST API Reference for ResizeCluster Operation</seealso>
        public virtual Task<ResizeClusterResponse> ResizeClusterAsync(ResizeClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResizeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResizeClusterResponseUnmarshaller.Instance;

            return InvokeAsync<ResizeClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RestoreFromClusterSnapshot

        internal virtual RestoreFromClusterSnapshotResponse RestoreFromClusterSnapshot(RestoreFromClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreFromClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreFromClusterSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a new cluster from a snapshot. By default, Amazon Redshift creates the resulting
        /// cluster with the same configuration as the original cluster from which the snapshot
        /// was created, except that the new cluster is created with the default cluster security
        /// and parameter groups. After Amazon Redshift creates the cluster, you can use the <a>ModifyCluster</a>
        /// API to associate a different security group and different parameter group with the
        /// restored cluster. If you are using a DS node type, you can also choose to change to
        /// another DS node type of the same size during restore.
        /// 
        ///  
        /// <para>
        /// If you restore a cluster into a VPC, you must provide a cluster subnet group where
        /// you want the cluster restored.
        /// </para>
        ///  
        /// <para>
        /// VPC Block Public Access (BPA) enables you to block resources in VPCs and subnets that
        /// you own in a Region from reaching or being reached from the internet through internet
        /// gateways and egress-only internet gateways. If a subnet group for a provisioned cluster
        /// is in an account with VPC BPA turned on, the following capabilities are blocked:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creating a public cluster
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Restoring a public cluster
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Modifying a private cluster to be public
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Adding a subnet with VPC BPA turned on to the subnet group when there's at least one
        /// public cluster within the group
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about VPC BPA, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/security-vpc-bpa.html">Block
        /// public access to VPCs and subnets</a> in the <i>Amazon VPC User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreFromClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AccessToSnapshotDeniedException">
        /// The owner of the specified snapshot has not authorized your account to access the
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterQuotaExceededException">
        /// The request would exceed the allowed number of cluster instances for this account.
        /// For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <c>available</c> state, or other accounts
        /// are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterTrackException">
        /// The provided cluster track name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidReservedNodeStateException">
        /// Indicates that the Reserved Node being exchanged is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRestoreException">
        /// The restore is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidVPCNetworkStateException">
        /// The cluster subnet group does not cover all Availability Zones.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.Ipv6CidrBlockNotFoundException">
        /// There are no subnets in your VPC with associated IPv6 CIDR blocks. To use dual-stack
        /// mode, associate an IPv6 CIDR block with each subnet in your VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in Amazon Web Services KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyMigratedException">
        /// Indicates that the reserved node has already been exchanged.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RestoreFromClusterSnapshot">REST API Reference for RestoreFromClusterSnapshot Operation</seealso>
        public virtual Task<RestoreFromClusterSnapshotResponse> RestoreFromClusterSnapshotAsync(RestoreFromClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreFromClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreFromClusterSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RestoreTableFromClusterSnapshot

        internal virtual RestoreTableFromClusterSnapshotResponse RestoreTableFromClusterSnapshot(RestoreTableFromClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreTableFromClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableFromClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreTableFromClusterSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a new table from a table in an Amazon Redshift cluster snapshot. You must
        /// create the new table within the Amazon Redshift cluster that the snapshot was taken
        /// from.
        /// 
        ///  
        /// <para>
        /// You cannot use <c>RestoreTableFromClusterSnapshot</c> to restore a table with the
        /// same name as an existing table in an Amazon Redshift cluster. That is, you cannot
        /// overwrite an existing table in a cluster with a restored table. If you want to replace
        /// your original table with a new, restored table, then rename or drop your original
        /// table before you call <c>RestoreTableFromClusterSnapshot</c>. When you have renamed
        /// your original table, then you can pass the original name of the table as the <c>NewTableName</c>
        /// parameter value in the call to <c>RestoreTableFromClusterSnapshot</c>. This way, you
        /// can replace the original table with the table created from the snapshot.
        /// </para>
        ///  
        /// <para>
        /// You can't use this operation to restore tables with <a href="https://docs.aws.amazon.com/redshift/latest/dg/t_Sorting_data.html#t_Sorting_data-interleaved">interleaved
        /// sort keys</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreTableFromClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InProgressTableRestoreQuotaExceededException">
        /// You have exceeded the allowed number of table restore requests. Wait for your current
        /// table restore requests to complete before making a new request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <c>available</c> state, or other accounts
        /// are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTableRestoreArgumentException">
        /// The value specified for the <c>sourceDatabaseName</c>, <c>sourceSchemaName</c>, or
        /// <c>sourceTableName</c> parameter, or a combination of these, doesn't exist in the
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RestoreTableFromClusterSnapshot">REST API Reference for RestoreTableFromClusterSnapshot Operation</seealso>
        public virtual Task<RestoreTableFromClusterSnapshotResponse> RestoreTableFromClusterSnapshotAsync(RestoreTableFromClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreTableFromClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableFromClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreTableFromClusterSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ResumeCluster

        internal virtual ResumeClusterResponse ResumeCluster(ResumeClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeClusterResponseUnmarshaller.Instance;

            return Invoke<ResumeClusterResponse>(request, options);
        }



        /// <summary>
        /// Resumes a paused cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResumeCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResumeCluster">REST API Reference for ResumeCluster Operation</seealso>
        public virtual Task<ResumeClusterResponse> ResumeClusterAsync(ResumeClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeClusterResponseUnmarshaller.Instance;

            return InvokeAsync<ResumeClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RevokeClusterSecurityGroupIngress

        internal virtual RevokeClusterSecurityGroupIngressResponse RevokeClusterSecurityGroupIngress(RevokeClusterSecurityGroupIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeClusterSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeClusterSecurityGroupIngressResponse>(request, options);
        }



        /// <summary>
        /// Revokes an ingress rule in an Amazon Redshift security group for a previously authorized
        /// IP range or Amazon EC2 security group. To add an ingress rule, see <a>AuthorizeClusterSecurityGroupIngress</a>.
        /// For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeClusterSecurityGroupIngress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeClusterSecurityGroupIngress service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or EC2 security group is not authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <c>available</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeClusterSecurityGroupIngress">REST API Reference for RevokeClusterSecurityGroupIngress Operation</seealso>
        public virtual Task<RevokeClusterSecurityGroupIngressResponse> RevokeClusterSecurityGroupIngressAsync(RevokeClusterSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeClusterSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeClusterSecurityGroupIngressResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RevokeEndpointAccess

        internal virtual RevokeEndpointAccessResponse RevokeEndpointAccess(RevokeEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<RevokeEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Revokes access to a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeEndpointAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointAuthorizationNotFoundException">
        /// The authorization for this endpoint can't be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointNotFoundException">
        /// The endpoint name doesn't refer to an existing endpoint.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidAuthorizationStateException">
        /// The status of the authorization is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <c>available</c>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidEndpointStateException">
        /// The status of the endpoint is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeEndpointAccess">REST API Reference for RevokeEndpointAccess Operation</seealso>
        public virtual Task<RevokeEndpointAccessResponse> RevokeEndpointAccessAsync(RevokeEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeEndpointAccessResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RevokeSnapshotAccess

        internal virtual RevokeSnapshotAccessResponse RevokeSnapshotAccess(RevokeSnapshotAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeSnapshotAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSnapshotAccessResponseUnmarshaller.Instance;

            return Invoke<RevokeSnapshotAccessResponse>(request, options);
        }



        /// <summary>
        /// Removes the ability of the specified Amazon Web Services account to restore the specified
        /// snapshot. If the account is currently restoring the snapshot, the restore will run
        /// to completion.
        /// 
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSnapshotAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeSnapshotAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AccessToSnapshotDeniedException">
        /// The owner of the specified snapshot has not authorized your account to access the
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or EC2 security group is not authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeSnapshotAccess">REST API Reference for RevokeSnapshotAccess Operation</seealso>
        public virtual Task<RevokeSnapshotAccessResponse> RevokeSnapshotAccessAsync(RevokeSnapshotAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeSnapshotAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSnapshotAccessResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeSnapshotAccessResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RotateEncryptionKey

        internal virtual RotateEncryptionKeyResponse RotateEncryptionKey(RotateEncryptionKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RotateEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RotateEncryptionKeyResponseUnmarshaller.Instance;

            return Invoke<RotateEncryptionKeyResponse>(request, options);
        }



        /// <summary>
        /// Rotates the encryption keys for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateEncryptionKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RotateEncryptionKey service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RotateEncryptionKey">REST API Reference for RotateEncryptionKey Operation</seealso>
        public virtual Task<RotateEncryptionKeyResponse> RotateEncryptionKeyAsync(RotateEncryptionKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RotateEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RotateEncryptionKeyResponseUnmarshaller.Instance;

            return InvokeAsync<RotateEncryptionKeyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdatePartnerStatus

        internal virtual UpdatePartnerStatusResponse UpdatePartnerStatus(UpdatePartnerStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePartnerStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartnerStatusResponseUnmarshaller.Instance;

            return Invoke<UpdatePartnerStatusResponse>(request, options);
        }



        /// <summary>
        /// Updates the status of a partner integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartnerStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePartnerStatus service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <c>ClusterIdentifier</c> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.PartnerNotFoundException">
        /// The name of the partner was not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedPartnerIntegrationException">
        /// The partner integration is not authorized.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/UpdatePartnerStatus">REST API Reference for UpdatePartnerStatus Operation</seealso>
        public virtual Task<UpdatePartnerStatusResponse> UpdatePartnerStatusAsync(UpdatePartnerStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePartnerStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartnerStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePartnerStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}