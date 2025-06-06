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
 * Do not modify this file. This file is generated from the account-2021-02-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Account.Model;
using Amazon.Account.Model.Internal.MarshallTransformations;
using Amazon.Account.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Account
{
    /// <summary>
    /// <para>Implementation for accessing Account</para>
    ///
    /// Operations for Amazon Web Services Account Management
    /// </summary>
    public partial class AmazonAccountClient : AmazonServiceClient, IAmazonAccount
    {
        private static IServiceMetadata serviceMetadata = new AmazonAccountMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAccountClient with the credentials loaded from the application's
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
        public AmazonAccountClient()
            : base(new AmazonAccountConfig()) { }

        /// <summary>
        /// Constructs AmazonAccountClient with the credentials loaded from the application's
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
        public AmazonAccountClient(RegionEndpoint region)
            : base(new AmazonAccountConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAccountClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAccountClient Configuration Object</param>
        public AmazonAccountClient(AmazonAccountConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonAccountClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAccountClient(AWSCredentials credentials)
            : this(credentials, new AmazonAccountConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAccountClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAccountConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Credentials and an
        /// AmazonAccountClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAccountClient Configuration Object</param>
        public AmazonAccountClient(AWSCredentials credentials, AmazonAccountConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAccountClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAccountConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAccountClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAccountConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAccountClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAccountClient Configuration Object</param>
        public AmazonAccountClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAccountConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAccountClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAccountConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAccountClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAccountConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAccountClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAccountClient Configuration Object</param>
        public AmazonAccountClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAccountConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IAccountPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAccountPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AccountPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAccountEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAccountAuthSchemeHandler());
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


        #region  AcceptPrimaryEmailUpdate

        internal virtual AcceptPrimaryEmailUpdateResponse AcceptPrimaryEmailUpdate(AcceptPrimaryEmailUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptPrimaryEmailUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptPrimaryEmailUpdateResponseUnmarshaller.Instance;

            return Invoke<AcceptPrimaryEmailUpdateResponse>(request, options);
        }



        /// <summary>
        /// Accepts the request that originated from <a>StartPrimaryEmailUpdate</a> to update
        /// the primary email address (also known as the root user email address) for the specified
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptPrimaryEmailUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptPrimaryEmailUpdate service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ConflictException">
        /// The request could not be processed because of a conflict in the current status of
        /// the resource. For example, this happens if you try to enable a Region that is currently
        /// being disabled (in a status of DISABLING).
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ResourceNotFoundException">
        /// The operation failed because it specified a resource that can't be found.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/AcceptPrimaryEmailUpdate">REST API Reference for AcceptPrimaryEmailUpdate Operation</seealso>
        public virtual Task<AcceptPrimaryEmailUpdateResponse> AcceptPrimaryEmailUpdateAsync(AcceptPrimaryEmailUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptPrimaryEmailUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptPrimaryEmailUpdateResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptPrimaryEmailUpdateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAlternateContact

        internal virtual DeleteAlternateContactResponse DeleteAlternateContact(DeleteAlternateContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlternateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlternateContactResponseUnmarshaller.Instance;

            return Invoke<DeleteAlternateContactResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified alternate contact from an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the alternate contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Access
        /// or updating the alternate contacts</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before you can update the alternate contact information for an Amazon Web Services
        /// account that is managed by Organizations, you must first enable integration between
        /// Amazon Web Services Account Management and Organizations. For more information, see
        /// <a href="https://docs.aws.amazon.com/accounts/latest/reference/using-orgs-trusted-access.html">Enabling
        /// trusted access for Amazon Web Services Account Management</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlternateContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlternateContact service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ResourceNotFoundException">
        /// The operation failed because it specified a resource that can't be found.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/DeleteAlternateContact">REST API Reference for DeleteAlternateContact Operation</seealso>
        public virtual Task<DeleteAlternateContactResponse> DeleteAlternateContactAsync(DeleteAlternateContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlternateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlternateContactResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAlternateContactResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisableRegion

        internal virtual DisableRegionResponse DisableRegion(DisableRegionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableRegionResponseUnmarshaller.Instance;

            return Invoke<DisableRegionResponse>(request, options);
        }



        /// <summary>
        /// Disables (opts-out) a particular Region for an account.
        /// 
        ///  <note> 
        /// <para>
        /// The act of disabling a Region will remove all IAM access to any resources that reside
        /// in that Region.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableRegion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableRegion service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ConflictException">
        /// The request could not be processed because of a conflict in the current status of
        /// the resource. For example, this happens if you try to enable a Region that is currently
        /// being disabled (in a status of DISABLING).
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/DisableRegion">REST API Reference for DisableRegion Operation</seealso>
        public virtual Task<DisableRegionResponse> DisableRegionAsync(DisableRegionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableRegionResponseUnmarshaller.Instance;

            return InvokeAsync<DisableRegionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EnableRegion

        internal virtual EnableRegionResponse EnableRegion(EnableRegionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableRegionResponseUnmarshaller.Instance;

            return Invoke<EnableRegionResponse>(request, options);
        }



        /// <summary>
        /// Enables (opts-in) a particular Region for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableRegion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableRegion service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ConflictException">
        /// The request could not be processed because of a conflict in the current status of
        /// the resource. For example, this happens if you try to enable a Region that is currently
        /// being disabled (in a status of DISABLING).
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/EnableRegion">REST API Reference for EnableRegion Operation</seealso>
        public virtual Task<EnableRegionResponse> EnableRegionAsync(EnableRegionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableRegionResponseUnmarshaller.Instance;

            return InvokeAsync<EnableRegionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAlternateContact

        internal virtual GetAlternateContactResponse GetAlternateContact(GetAlternateContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAlternateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAlternateContactResponseUnmarshaller.Instance;

            return Invoke<GetAlternateContactResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the specified alternate contact attached to an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the alternate contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Access
        /// or updating the alternate contacts</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before you can update the alternate contact information for an Amazon Web Services
        /// account that is managed by Organizations, you must first enable integration between
        /// Amazon Web Services Account Management and Organizations. For more information, see
        /// <a href="https://docs.aws.amazon.com/accounts/latest/reference/using-orgs-trusted-access.html">Enabling
        /// trusted access for Amazon Web Services Account Management</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAlternateContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAlternateContact service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ResourceNotFoundException">
        /// The operation failed because it specified a resource that can't be found.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetAlternateContact">REST API Reference for GetAlternateContact Operation</seealso>
        public virtual Task<GetAlternateContactResponse> GetAlternateContactAsync(GetAlternateContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAlternateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAlternateContactResponseUnmarshaller.Instance;

            return InvokeAsync<GetAlternateContactResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetContactInformation

        internal virtual GetContactInformationResponse GetContactInformation(GetContactInformationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactInformationResponseUnmarshaller.Instance;

            return Invoke<GetContactInformationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the primary contact information of an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the primary contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Update
        /// the primary and alternate contact information</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactInformation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContactInformation service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ResourceNotFoundException">
        /// The operation failed because it specified a resource that can't be found.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetContactInformation">REST API Reference for GetContactInformation Operation</seealso>
        public virtual Task<GetContactInformationResponse> GetContactInformationAsync(GetContactInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactInformationResponseUnmarshaller.Instance;

            return InvokeAsync<GetContactInformationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPrimaryEmail

        internal virtual GetPrimaryEmailResponse GetPrimaryEmail(GetPrimaryEmailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPrimaryEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPrimaryEmailResponseUnmarshaller.Instance;

            return Invoke<GetPrimaryEmailResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the primary email address for the specified account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPrimaryEmail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPrimaryEmail service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ResourceNotFoundException">
        /// The operation failed because it specified a resource that can't be found.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetPrimaryEmail">REST API Reference for GetPrimaryEmail Operation</seealso>
        public virtual Task<GetPrimaryEmailResponse> GetPrimaryEmailAsync(GetPrimaryEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPrimaryEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPrimaryEmailResponseUnmarshaller.Instance;

            return InvokeAsync<GetPrimaryEmailResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRegionOptStatus

        internal virtual GetRegionOptStatusResponse GetRegionOptStatus(GetRegionOptStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegionOptStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegionOptStatusResponseUnmarshaller.Instance;

            return Invoke<GetRegionOptStatusResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the opt-in status of a particular Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegionOptStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRegionOptStatus service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetRegionOptStatus">REST API Reference for GetRegionOptStatus Operation</seealso>
        public virtual Task<GetRegionOptStatusResponse> GetRegionOptStatusAsync(GetRegionOptStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegionOptStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegionOptStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetRegionOptStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRegions

        internal virtual ListRegionsResponse ListRegions(ListRegionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegionsResponseUnmarshaller.Instance;

            return Invoke<ListRegionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the Regions for a given account and their respective opt-in statuses. Optionally,
        /// this list can be filtered by the <c>region-opt-status-contains</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegions service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/ListRegions">REST API Reference for ListRegions Operation</seealso>
        public virtual Task<ListRegionsResponse> ListRegionsAsync(ListRegionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRegionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutAlternateContact

        internal virtual PutAlternateContactResponse PutAlternateContact(PutAlternateContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAlternateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAlternateContactResponseUnmarshaller.Instance;

            return Invoke<PutAlternateContactResponse>(request, options);
        }



        /// <summary>
        /// Modifies the specified alternate contact attached to an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the alternate contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Access
        /// or updating the alternate contacts</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before you can update the alternate contact information for an Amazon Web Services
        /// account that is managed by Organizations, you must first enable integration between
        /// Amazon Web Services Account Management and Organizations. For more information, see
        /// <a href="https://docs.aws.amazon.com/accounts/latest/reference/using-orgs-trusted-access.html">Enabling
        /// trusted access for Amazon Web Services Account Management</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAlternateContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAlternateContact service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/PutAlternateContact">REST API Reference for PutAlternateContact Operation</seealso>
        public virtual Task<PutAlternateContactResponse> PutAlternateContactAsync(PutAlternateContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAlternateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAlternateContactResponseUnmarshaller.Instance;

            return InvokeAsync<PutAlternateContactResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutContactInformation

        internal virtual PutContactInformationResponse PutContactInformation(PutContactInformationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutContactInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutContactInformationResponseUnmarshaller.Instance;

            return Invoke<PutContactInformationResponse>(request, options);
        }



        /// <summary>
        /// Updates the primary contact information of an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the primary contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Update
        /// the primary and alternate contact information</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutContactInformation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutContactInformation service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/PutContactInformation">REST API Reference for PutContactInformation Operation</seealso>
        public virtual Task<PutContactInformationResponse> PutContactInformationAsync(PutContactInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutContactInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutContactInformationResponseUnmarshaller.Instance;

            return InvokeAsync<PutContactInformationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartPrimaryEmailUpdate

        internal virtual StartPrimaryEmailUpdateResponse StartPrimaryEmailUpdate(StartPrimaryEmailUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPrimaryEmailUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPrimaryEmailUpdateResponseUnmarshaller.Instance;

            return Invoke<StartPrimaryEmailUpdateResponse>(request, options);
        }



        /// <summary>
        /// Starts the process to update the primary email address for the specified account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPrimaryEmailUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPrimaryEmailUpdate service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ConflictException">
        /// The request could not be processed because of a conflict in the current status of
        /// the resource. For example, this happens if you try to enable a Region that is currently
        /// being disabled (in a status of DISABLING).
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ResourceNotFoundException">
        /// The operation failed because it specified a resource that can't be found.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/StartPrimaryEmailUpdate">REST API Reference for StartPrimaryEmailUpdate Operation</seealso>
        public virtual Task<StartPrimaryEmailUpdateResponse> StartPrimaryEmailUpdateAsync(StartPrimaryEmailUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPrimaryEmailUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPrimaryEmailUpdateResponseUnmarshaller.Instance;

            return InvokeAsync<StartPrimaryEmailUpdateResponse>(request, options, cancellationToken);
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