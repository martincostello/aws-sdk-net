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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Kinesis.Model;
using Amazon.Kinesis.Model.Internal.MarshallTransformations;
using Amazon.Kinesis.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Kinesis
{
    /// <summary>
    /// <para>Implementation for accessing Kinesis</para>
    ///
    /// Amazon Kinesis Data Streams Service API Reference 
    /// <para>
    /// Amazon Kinesis Data Streams is a managed service that scales elastically for real-time
    /// processing of streaming big data.
    /// </para>
    /// </summary>
    public partial class AmazonKinesisClient : AmazonServiceClient, IAmazonKinesis
    {
        private static IServiceMetadata serviceMetadata = new AmazonKinesisMetadata();
        private IKinesisPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IKinesisPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new KinesisPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonKinesisClient with the credentials loaded from the application's
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
        public AmazonKinesisClient()
            : base(new AmazonKinesisConfig()) { }

        /// <summary>
        /// Constructs AmazonKinesisClient with the credentials loaded from the application's
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
        public AmazonKinesisClient(RegionEndpoint region)
            : base(new AmazonKinesisConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKinesisClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonKinesisClient Configuration Object</param>
        public AmazonKinesisClient(AmazonKinesisConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKinesisClient(AWSCredentials credentials)
            : this(credentials, new AmazonKinesisConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKinesisConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Credentials and an
        /// AmazonKinesisClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKinesisClient Configuration Object</param>
        public AmazonKinesisClient(AWSCredentials credentials, AmazonKinesisConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKinesisClient Configuration Object</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKinesisConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKinesisClient Configuration Object</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKinesisConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKinesisEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKinesisAuthSchemeHandler());
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


        #region  AddTagsToStream


        /// <summary>
        /// Adds or updates tags for the specified Kinesis data stream. You can assign up to 50
        /// tags to a data stream.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// If tags have already been assigned to the stream, <c>AddTagsToStream</c> overwrites
        /// any existing tags that correspond to the specified tag keys.
        /// </para>
        ///  
        /// <para>
        ///  <a>AddTagsToStream</a> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToStream service method.</param>
        /// 
        /// <returns>The response from the AddTagsToStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/AddTagsToStream">REST API Reference for AddTagsToStream Operation</seealso>
        public virtual AddTagsToStreamResponse AddTagsToStream(AddTagsToStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToStreamResponseUnmarshaller.Instance;

            return Invoke<AddTagsToStreamResponse>(request, options);
        }


        /// <summary>
        /// Adds or updates tags for the specified Kinesis data stream. You can assign up to 50
        /// tags to a data stream.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// If tags have already been assigned to the stream, <c>AddTagsToStream</c> overwrites
        /// any existing tags that correspond to the specified tag keys.
        /// </para>
        ///  
        /// <para>
        ///  <a>AddTagsToStream</a> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTagsToStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/AddTagsToStream">REST API Reference for AddTagsToStream Operation</seealso>
        public virtual Task<AddTagsToStreamResponse> AddTagsToStreamAsync(AddTagsToStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<AddTagsToStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStream


        /// <summary>
        /// Creates a Kinesis data stream. A stream captures and transports data records that
        /// are continuously emitted from different data sources or <i>producers</i>. Scale-out
        /// within a stream is explicitly supported by means of shards, which are uniquely identified
        /// groups of data records in a stream.
        /// 
        ///  
        /// <para>
        /// You can create your data stream using either on-demand or provisioned capacity mode.
        /// Data streams with an on-demand mode require no capacity planning and automatically
        /// scale to handle gigabytes of write and read throughput per minute. With the on-demand
        /// mode, Kinesis Data Streams automatically manages the shards in order to provide the
        /// necessary throughput. For the data streams with a provisioned mode, you must specify
        /// the number of shards for the data stream. Each shard can support reads up to five
        /// transactions per second, up to a maximum data read total of 2 MiB per second. Each
        /// shard can support writes up to 1,000 records per second, up to a maximum data write
        /// total of 1 MiB per second. If the amount of data input increases or decreases, you
        /// can add or remove shards.
        /// </para>
        ///  
        /// <para>
        /// The stream name identifies the stream. The name is scoped to the Amazon Web Services
        /// account used by the application. It is also scoped by Amazon Web Services Region.
        /// That is, two streams in two different accounts can have the same name, and two streams
        /// in the same account, but in two different Regions, can have the same name.
        /// </para>
        ///  
        /// <para>
        ///  <c>CreateStream</c> is an asynchronous operation. Upon receiving a <c>CreateStream</c>
        /// request, Kinesis Data Streams immediately returns and sets the stream status to <c>CREATING</c>.
        /// After the stream is created, Kinesis Data Streams sets the stream status to <c>ACTIVE</c>.
        /// You should perform read and write operations only on an <c>ACTIVE</c> stream. 
        /// </para>
        ///  
        /// <para>
        /// You receive a <c>LimitExceededException</c> when making a <c>CreateStream</c> request
        /// when you try to do one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Have more than five streams in the <c>CREATING</c> state at any point in time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create more shards than are authorized for your account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the default shard limit for an Amazon Web Services account, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Amazon
        /// Kinesis Data Streams Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// To increase this limit, <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">contact
        /// Amazon Web Services Support</a>.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeStreamSummary</a> to check the stream status, which is returned
        /// in <c>StreamStatus</c>.
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateStream</a> has a limit of five transactions per second per account.
        /// </para>
        ///  
        /// <para>
        /// You can add tags to the stream when making a <c>CreateStream</c> request by setting
        /// the <c>Tags</c> parameter. If you pass <c>Tags</c> parameter, in addition to having
        /// <c>kinesis:createStream</c> permission, you must also have <c>kinesis:addTagsToStream</c>
        /// permission for the stream that will be created. Tags will take effect from the <c>CREATING</c>
        /// status of the stream. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStream service method.</param>
        /// 
        /// <returns>The response from the CreateStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/CreateStream">REST API Reference for CreateStream Operation</seealso>
        public virtual CreateStreamResponse CreateStream(CreateStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamResponseUnmarshaller.Instance;

            return Invoke<CreateStreamResponse>(request, options);
        }


        /// <summary>
        /// Creates a Kinesis data stream. A stream captures and transports data records that
        /// are continuously emitted from different data sources or <i>producers</i>. Scale-out
        /// within a stream is explicitly supported by means of shards, which are uniquely identified
        /// groups of data records in a stream.
        /// 
        ///  
        /// <para>
        /// You can create your data stream using either on-demand or provisioned capacity mode.
        /// Data streams with an on-demand mode require no capacity planning and automatically
        /// scale to handle gigabytes of write and read throughput per minute. With the on-demand
        /// mode, Kinesis Data Streams automatically manages the shards in order to provide the
        /// necessary throughput. For the data streams with a provisioned mode, you must specify
        /// the number of shards for the data stream. Each shard can support reads up to five
        /// transactions per second, up to a maximum data read total of 2 MiB per second. Each
        /// shard can support writes up to 1,000 records per second, up to a maximum data write
        /// total of 1 MiB per second. If the amount of data input increases or decreases, you
        /// can add or remove shards.
        /// </para>
        ///  
        /// <para>
        /// The stream name identifies the stream. The name is scoped to the Amazon Web Services
        /// account used by the application. It is also scoped by Amazon Web Services Region.
        /// That is, two streams in two different accounts can have the same name, and two streams
        /// in the same account, but in two different Regions, can have the same name.
        /// </para>
        ///  
        /// <para>
        ///  <c>CreateStream</c> is an asynchronous operation. Upon receiving a <c>CreateStream</c>
        /// request, Kinesis Data Streams immediately returns and sets the stream status to <c>CREATING</c>.
        /// After the stream is created, Kinesis Data Streams sets the stream status to <c>ACTIVE</c>.
        /// You should perform read and write operations only on an <c>ACTIVE</c> stream. 
        /// </para>
        ///  
        /// <para>
        /// You receive a <c>LimitExceededException</c> when making a <c>CreateStream</c> request
        /// when you try to do one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Have more than five streams in the <c>CREATING</c> state at any point in time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create more shards than are authorized for your account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the default shard limit for an Amazon Web Services account, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Amazon
        /// Kinesis Data Streams Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// To increase this limit, <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">contact
        /// Amazon Web Services Support</a>.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeStreamSummary</a> to check the stream status, which is returned
        /// in <c>StreamStatus</c>.
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateStream</a> has a limit of five transactions per second per account.
        /// </para>
        ///  
        /// <para>
        /// You can add tags to the stream when making a <c>CreateStream</c> request by setting
        /// the <c>Tags</c> parameter. If you pass <c>Tags</c> parameter, in addition to having
        /// <c>kinesis:createStream</c> permission, you must also have <c>kinesis:addTagsToStream</c>
        /// permission for the stream that will be created. Tags will take effect from the <c>CREATING</c>
        /// status of the stream. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/CreateStream">REST API Reference for CreateStream Operation</seealso>
        public virtual Task<CreateStreamResponse> CreateStreamAsync(CreateStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DecreaseStreamRetentionPeriod


        /// <summary>
        /// Decreases the Kinesis data stream's retention period, which is the length of time
        /// data records are accessible after they are added to the stream. The minimum value
        /// of a stream's retention period is 24 hours.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation may result in lost data. For example, if the stream's retention period
        /// is 48 hours and is decreased to 24 hours, any data already in the stream that is older
        /// than 24 hours is inaccessible.
        /// </para>
        /// </summary>
        /// <param name="streamName">The name of the stream to modify.</param>
        /// <param name="retentionPeriodHours">The new retention period of the stream, in hours. Must be less than the current retention period.</param>
        /// 
        /// <returns>The response from the DecreaseStreamRetentionPeriod service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DecreaseStreamRetentionPeriod">REST API Reference for DecreaseStreamRetentionPeriod Operation</seealso>
        public virtual DecreaseStreamRetentionPeriodResponse DecreaseStreamRetentionPeriod(string streamName, int? retentionPeriodHours)
        {
            var request = new DecreaseStreamRetentionPeriodRequest();
            request.StreamName = streamName;
            request.RetentionPeriodHours = retentionPeriodHours;
            return DecreaseStreamRetentionPeriod(request);
        }


        /// <summary>
        /// Decreases the Kinesis data stream's retention period, which is the length of time
        /// data records are accessible after they are added to the stream. The minimum value
        /// of a stream's retention period is 24 hours.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation may result in lost data. For example, if the stream's retention period
        /// is 48 hours and is decreased to 24 hours, any data already in the stream that is older
        /// than 24 hours is inaccessible.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DecreaseStreamRetentionPeriod service method.</param>
        /// 
        /// <returns>The response from the DecreaseStreamRetentionPeriod service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DecreaseStreamRetentionPeriod">REST API Reference for DecreaseStreamRetentionPeriod Operation</seealso>
        public virtual DecreaseStreamRetentionPeriodResponse DecreaseStreamRetentionPeriod(DecreaseStreamRetentionPeriodRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecreaseStreamRetentionPeriodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecreaseStreamRetentionPeriodResponseUnmarshaller.Instance;

            return Invoke<DecreaseStreamRetentionPeriodResponse>(request, options);
        }


        /// <summary>
        /// Decreases the Kinesis data stream's retention period, which is the length of time
        /// data records are accessible after they are added to the stream. The minimum value
        /// of a stream's retention period is 24 hours.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation may result in lost data. For example, if the stream's retention period
        /// is 48 hours and is decreased to 24 hours, any data already in the stream that is older
        /// than 24 hours is inaccessible.
        /// </para>
        /// </summary>
        /// <param name="streamName">The name of the stream to modify.</param>
        /// <param name="retentionPeriodHours">The new retention period of the stream, in hours. Must be less than the current retention period.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DecreaseStreamRetentionPeriod service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DecreaseStreamRetentionPeriod">REST API Reference for DecreaseStreamRetentionPeriod Operation</seealso>
        public virtual Task<DecreaseStreamRetentionPeriodResponse> DecreaseStreamRetentionPeriodAsync(string streamName, int? retentionPeriodHours, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DecreaseStreamRetentionPeriodRequest();
            request.StreamName = streamName;
            request.RetentionPeriodHours = retentionPeriodHours;
            return DecreaseStreamRetentionPeriodAsync(request, cancellationToken);
        }


        /// <summary>
        /// Decreases the Kinesis data stream's retention period, which is the length of time
        /// data records are accessible after they are added to the stream. The minimum value
        /// of a stream's retention period is 24 hours.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation may result in lost data. For example, if the stream's retention period
        /// is 48 hours and is decreased to 24 hours, any data already in the stream that is older
        /// than 24 hours is inaccessible.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DecreaseStreamRetentionPeriod service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DecreaseStreamRetentionPeriod service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DecreaseStreamRetentionPeriod">REST API Reference for DecreaseStreamRetentionPeriod Operation</seealso>
        public virtual Task<DecreaseStreamRetentionPeriodResponse> DecreaseStreamRetentionPeriodAsync(DecreaseStreamRetentionPeriodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecreaseStreamRetentionPeriodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecreaseStreamRetentionPeriodResponseUnmarshaller.Instance;
            
            return InvokeAsync<DecreaseStreamRetentionPeriodResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Delete a policy for the specified data stream or consumer. Request patterns can be
        /// one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Data stream pattern: <c>arn:aws.*:kinesis:.*:\d{12}:.*stream/\S+</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Consumer pattern: <c>^(arn):aws.*:kinesis:.*:\d{12}:.*stream\/[a-zA-Z0-9_.-]+\/consumer\/[a-zA-Z0-9_.-]+:[0-9]+</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Delete a policy for the specified data stream or consumer. Request patterns can be
        /// one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Data stream pattern: <c>arn:aws.*:kinesis:.*:\d{12}:.*stream/\S+</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Consumer pattern: <c>^(arn):aws.*:kinesis:.*:\d{12}:.*stream\/[a-zA-Z0-9_.-]+\/consumer\/[a-zA-Z0-9_.-]+:[0-9]+</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStream


        /// <summary>
        /// Deletes a Kinesis data stream and all its shards and data. You must shut down any
        /// applications that are operating on the stream before you delete the stream. If an
        /// application attempts to operate on a deleted stream, it receives the exception <c>ResourceNotFoundException</c>.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// If the stream is in the <c>ACTIVE</c> state, you can delete it. After a <c>DeleteStream</c>
        /// request, the specified stream is in the <c>DELETING</c> state until Kinesis Data Streams
        /// completes the deletion.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> Kinesis Data Streams might continue to accept data read and write operations,
        /// such as <a>PutRecord</a>, <a>PutRecords</a>, and <a>GetRecords</a>, on a stream in
        /// the <c>DELETING</c> state until the stream deletion is complete.
        /// </para>
        ///  
        /// <para>
        /// When you delete a stream, any shards in that stream are also deleted, and any tags
        /// are dissociated from the stream.
        /// </para>
        ///  
        /// <para>
        /// You can use the <a>DescribeStreamSummary</a> operation to check the state of the stream,
        /// which is returned in <c>StreamStatus</c>.
        /// </para>
        ///  
        /// <para>
        ///  <a>DeleteStream</a> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream service method.</param>
        /// 
        /// <returns>The response from the DeleteStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DeleteStream">REST API Reference for DeleteStream Operation</seealso>
        public virtual DeleteStreamResponse DeleteStream(DeleteStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Kinesis data stream and all its shards and data. You must shut down any
        /// applications that are operating on the stream before you delete the stream. If an
        /// application attempts to operate on a deleted stream, it receives the exception <c>ResourceNotFoundException</c>.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// If the stream is in the <c>ACTIVE</c> state, you can delete it. After a <c>DeleteStream</c>
        /// request, the specified stream is in the <c>DELETING</c> state until Kinesis Data Streams
        /// completes the deletion.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> Kinesis Data Streams might continue to accept data read and write operations,
        /// such as <a>PutRecord</a>, <a>PutRecords</a>, and <a>GetRecords</a>, on a stream in
        /// the <c>DELETING</c> state until the stream deletion is complete.
        /// </para>
        ///  
        /// <para>
        /// When you delete a stream, any shards in that stream are also deleted, and any tags
        /// are dissociated from the stream.
        /// </para>
        ///  
        /// <para>
        /// You can use the <a>DescribeStreamSummary</a> operation to check the state of the stream,
        /// which is returned in <c>StreamStatus</c>.
        /// </para>
        ///  
        /// <para>
        ///  <a>DeleteStream</a> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DeleteStream">REST API Reference for DeleteStream Operation</seealso>
        public virtual Task<DeleteStreamResponse> DeleteStreamAsync(DeleteStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterStreamConsumer


        /// <summary>
        /// To deregister a consumer, provide its ARN. Alternatively, you can provide the ARN
        /// of the data stream and the name you gave the consumer when you registered it. You
        /// may also provide all three parameters, as long as they don't conflict with each other.
        /// If you don't know the name or ARN of the consumer that you want to deregister, you
        /// can use the <a>ListStreamConsumers</a> operation to get a list of the descriptions
        /// of all the consumers that are currently registered with a given data stream. The description
        /// of a consumer contains its name and ARN.
        /// 
        ///  
        /// <para>
        /// This operation has a limit of five transactions per second per stream.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterStreamConsumer service method.</param>
        /// 
        /// <returns>The response from the DeregisterStreamConsumer service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DeregisterStreamConsumer">REST API Reference for DeregisterStreamConsumer Operation</seealso>
        public virtual DeregisterStreamConsumerResponse DeregisterStreamConsumer(DeregisterStreamConsumerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterStreamConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterStreamConsumerResponseUnmarshaller.Instance;

            return Invoke<DeregisterStreamConsumerResponse>(request, options);
        }


        /// <summary>
        /// To deregister a consumer, provide its ARN. Alternatively, you can provide the ARN
        /// of the data stream and the name you gave the consumer when you registered it. You
        /// may also provide all three parameters, as long as they don't conflict with each other.
        /// If you don't know the name or ARN of the consumer that you want to deregister, you
        /// can use the <a>ListStreamConsumers</a> operation to get a list of the descriptions
        /// of all the consumers that are currently registered with a given data stream. The description
        /// of a consumer contains its name and ARN.
        /// 
        ///  
        /// <para>
        /// This operation has a limit of five transactions per second per stream.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterStreamConsumer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterStreamConsumer service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DeregisterStreamConsumer">REST API Reference for DeregisterStreamConsumer Operation</seealso>
        public virtual Task<DeregisterStreamConsumerResponse> DeregisterStreamConsumerAsync(DeregisterStreamConsumerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterStreamConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterStreamConsumerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeregisterStreamConsumerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLimits


        /// <summary>
        /// Describes the shard limits and usage for the account.
        /// 
        ///  
        /// <para>
        /// If you update your account limits, the old limits might be returned for a few minutes.
        /// </para>
        ///  
        /// <para>
        /// This operation has a limit of one transaction per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeLimits service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeLimits">REST API Reference for DescribeLimits Operation</seealso>
        public virtual DescribeLimitsResponse DescribeLimits(DescribeLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeLimitsResponse>(request, options);
        }


        /// <summary>
        /// Describes the shard limits and usage for the account.
        /// 
        ///  
        /// <para>
        /// If you update your account limits, the old limits might be returned for a few minutes.
        /// </para>
        ///  
        /// <para>
        /// This operation has a limit of one transaction per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLimits service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeLimits">REST API Reference for DescribeLimits Operation</seealso>
        public virtual Task<DescribeLimitsResponse> DescribeLimitsAsync(DescribeLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLimitsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStream


        /// <summary>
        /// Describes the specified Kinesis data stream.
        /// 
        ///  <note> 
        /// <para>
        /// This API has been revised. It's highly recommended that you use the <a>DescribeStreamSummary</a>
        /// API to get a summarized description of the specified Kinesis data stream and the <a>ListShards</a>
        /// API to list the shards in a specified data stream and obtain information about each
        /// shard. 
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// The information returned includes the stream name, Amazon Resource Name (ARN), creation
        /// time, enhanced metric configuration, and shard map. The shard map is an array of shard
        /// objects. For each shard object, there is the hash key and sequence number ranges that
        /// the shard spans, and the IDs of any earlier shards that played in a role in creating
        /// the shard. Every record ingested in the stream is identified by a sequence number,
        /// which is assigned when the record is put into the stream.
        /// </para>
        ///  
        /// <para>
        /// You can limit the number of shards returned by each call. For more information, see
        /// <a href="https://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-sdk-java-retrieve-shards.html">Retrieving
        /// Shards from a Stream</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// There are no guarantees about the chronological order shards returned. To process
        /// shards in chronological order, use the ID of the parent shard to track the lineage
        /// to the oldest shard.
        /// </para>
        ///  
        /// <para>
        /// This operation has a limit of 10 transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream service method.</param>
        /// 
        /// <returns>The response from the DescribeStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStream">REST API Reference for DescribeStream Operation</seealso>
        public virtual DescribeStreamResponse DescribeStream(DescribeStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified Kinesis data stream.
        /// 
        ///  <note> 
        /// <para>
        /// This API has been revised. It's highly recommended that you use the <a>DescribeStreamSummary</a>
        /// API to get a summarized description of the specified Kinesis data stream and the <a>ListShards</a>
        /// API to list the shards in a specified data stream and obtain information about each
        /// shard. 
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// The information returned includes the stream name, Amazon Resource Name (ARN), creation
        /// time, enhanced metric configuration, and shard map. The shard map is an array of shard
        /// objects. For each shard object, there is the hash key and sequence number ranges that
        /// the shard spans, and the IDs of any earlier shards that played in a role in creating
        /// the shard. Every record ingested in the stream is identified by a sequence number,
        /// which is assigned when the record is put into the stream.
        /// </para>
        ///  
        /// <para>
        /// You can limit the number of shards returned by each call. For more information, see
        /// <a href="https://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-sdk-java-retrieve-shards.html">Retrieving
        /// Shards from a Stream</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// There are no guarantees about the chronological order shards returned. To process
        /// shards in chronological order, use the ID of the parent shard to track the lineage
        /// to the oldest shard.
        /// </para>
        ///  
        /// <para>
        /// This operation has a limit of 10 transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStream">REST API Reference for DescribeStream Operation</seealso>
        public virtual Task<DescribeStreamResponse> DescribeStreamAsync(DescribeStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStreamConsumer


        /// <summary>
        /// To get the description of a registered consumer, provide the ARN of the consumer.
        /// Alternatively, you can provide the ARN of the data stream and the name you gave the
        /// consumer when you registered it. You may also provide all three parameters, as long
        /// as they don't conflict with each other. If you don't know the name or ARN of the consumer
        /// that you want to describe, you can use the <a>ListStreamConsumers</a> operation to
        /// get a list of the descriptions of all the consumers that are currently registered
        /// with a given data stream.
        /// 
        ///  
        /// <para>
        /// This operation has a limit of 20 transactions per second per stream.
        /// </para>
        ///  <note> 
        /// <para>
        /// When making a cross-account call with <c>DescribeStreamConsumer</c>, make sure to
        /// provide the ARN of the consumer. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamConsumer service method.</param>
        /// 
        /// <returns>The response from the DescribeStreamConsumer service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStreamConsumer">REST API Reference for DescribeStreamConsumer Operation</seealso>
        public virtual DescribeStreamConsumerResponse DescribeStreamConsumer(DescribeStreamConsumerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamConsumerResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamConsumerResponse>(request, options);
        }


        /// <summary>
        /// To get the description of a registered consumer, provide the ARN of the consumer.
        /// Alternatively, you can provide the ARN of the data stream and the name you gave the
        /// consumer when you registered it. You may also provide all three parameters, as long
        /// as they don't conflict with each other. If you don't know the name or ARN of the consumer
        /// that you want to describe, you can use the <a>ListStreamConsumers</a> operation to
        /// get a list of the descriptions of all the consumers that are currently registered
        /// with a given data stream.
        /// 
        ///  
        /// <para>
        /// This operation has a limit of 20 transactions per second per stream.
        /// </para>
        ///  <note> 
        /// <para>
        /// When making a cross-account call with <c>DescribeStreamConsumer</c>, make sure to
        /// provide the ARN of the consumer. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamConsumer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStreamConsumer service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStreamConsumer">REST API Reference for DescribeStreamConsumer Operation</seealso>
        public virtual Task<DescribeStreamConsumerResponse> DescribeStreamConsumerAsync(DescribeStreamConsumerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamConsumerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeStreamConsumerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStreamSummary


        /// <summary>
        /// Provides a summarized description of the specified Kinesis data stream without the
        /// shard list.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// The information returned includes the stream name, Amazon Resource Name (ARN), status,
        /// record retention period, approximate creation time, monitoring, encryption details,
        /// and open shard count. 
        /// </para>
        ///  
        /// <para>
        ///  <a>DescribeStreamSummary</a> has a limit of 20 transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamSummary service method.</param>
        /// 
        /// <returns>The response from the DescribeStreamSummary service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStreamSummary">REST API Reference for DescribeStreamSummary Operation</seealso>
        public virtual DescribeStreamSummaryResponse DescribeStreamSummary(DescribeStreamSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamSummaryResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamSummaryResponse>(request, options);
        }


        /// <summary>
        /// Provides a summarized description of the specified Kinesis data stream without the
        /// shard list.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// The information returned includes the stream name, Amazon Resource Name (ARN), status,
        /// record retention period, approximate creation time, monitoring, encryption details,
        /// and open shard count. 
        /// </para>
        ///  
        /// <para>
        ///  <a>DescribeStreamSummary</a> has a limit of 20 transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStreamSummary service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStreamSummary">REST API Reference for DescribeStreamSummary Operation</seealso>
        public virtual Task<DescribeStreamSummaryResponse> DescribeStreamSummaryAsync(DescribeStreamSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamSummaryResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeStreamSummaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableEnhancedMonitoring


        /// <summary>
        /// Disables enhanced monitoring.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableEnhancedMonitoring service method.</param>
        /// 
        /// <returns>The response from the DisableEnhancedMonitoring service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DisableEnhancedMonitoring">REST API Reference for DisableEnhancedMonitoring Operation</seealso>
        public virtual DisableEnhancedMonitoringResponse DisableEnhancedMonitoring(DisableEnhancedMonitoringRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableEnhancedMonitoringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableEnhancedMonitoringResponseUnmarshaller.Instance;

            return Invoke<DisableEnhancedMonitoringResponse>(request, options);
        }


        /// <summary>
        /// Disables enhanced monitoring.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableEnhancedMonitoring service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableEnhancedMonitoring service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DisableEnhancedMonitoring">REST API Reference for DisableEnhancedMonitoring Operation</seealso>
        public virtual Task<DisableEnhancedMonitoringResponse> DisableEnhancedMonitoringAsync(DisableEnhancedMonitoringRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableEnhancedMonitoringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableEnhancedMonitoringResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableEnhancedMonitoringResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableEnhancedMonitoring


        /// <summary>
        /// Enables enhanced Kinesis data stream monitoring for shard-level metrics.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableEnhancedMonitoring service method.</param>
        /// 
        /// <returns>The response from the EnableEnhancedMonitoring service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/EnableEnhancedMonitoring">REST API Reference for EnableEnhancedMonitoring Operation</seealso>
        public virtual EnableEnhancedMonitoringResponse EnableEnhancedMonitoring(EnableEnhancedMonitoringRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableEnhancedMonitoringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableEnhancedMonitoringResponseUnmarshaller.Instance;

            return Invoke<EnableEnhancedMonitoringResponse>(request, options);
        }


        /// <summary>
        /// Enables enhanced Kinesis data stream monitoring for shard-level metrics.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableEnhancedMonitoring service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableEnhancedMonitoring service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/EnableEnhancedMonitoring">REST API Reference for EnableEnhancedMonitoring Operation</seealso>
        public virtual Task<EnableEnhancedMonitoringResponse> EnableEnhancedMonitoringAsync(EnableEnhancedMonitoringRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableEnhancedMonitoringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableEnhancedMonitoringResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableEnhancedMonitoringResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRecords


        /// <summary>
        /// Gets data records from a Kinesis data stream's shard.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// Specify a shard iterator using the <c>ShardIterator</c> parameter. The shard iterator
        /// specifies the position in the shard from which you want to start reading data records
        /// sequentially. If there are no records available in the portion of the shard that the
        /// iterator points to, <a>GetRecords</a> returns an empty list. It might take multiple
        /// calls to get to a portion of the shard that contains records.
        /// </para>
        ///  
        /// <para>
        /// You can scale by provisioning multiple shards per stream while considering service
        /// limits (for more information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Amazon
        /// Kinesis Data Streams Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>).
        /// Your application should have one thread per shard, each reading continuously from
        /// its stream. To read from a stream continually, call <a>GetRecords</a> in a loop. Use
        /// <a>GetShardIterator</a> to get the shard iterator to specify in the first <a>GetRecords</a>
        /// call. <a>GetRecords</a> returns a new shard iterator in <c>NextShardIterator</c>.
        /// Specify the shard iterator returned in <c>NextShardIterator</c> in subsequent calls
        /// to <a>GetRecords</a>. If the shard has been closed, the shard iterator can't return
        /// more data and <a>GetRecords</a> returns <c>null</c> in <c>NextShardIterator</c>. You
        /// can terminate the loop when the shard is closed, or when the shard iterator reaches
        /// the record with the sequence number or other attribute that marks it as the last record
        /// to process.
        /// </para>
        ///  
        /// <para>
        /// Each data record can be up to 1 MiB in size, and each shard can read up to 2 MiB per
        /// second. You can ensure that your calls don't exceed the maximum supported size or
        /// throughput by using the <c>Limit</c> parameter to specify the maximum number of records
        /// that <a>GetRecords</a> can return. Consider your average record size when determining
        /// this limit. The maximum number of records that can be returned per call is 10,000.
        /// </para>
        ///  
        /// <para>
        /// The size of the data returned by <a>GetRecords</a> varies depending on the utilization
        /// of the shard. It is recommended that consumer applications retrieve records via the
        /// <c>GetRecords</c> command using the 5 TPS limit to remain caught up. Retrieving records
        /// less frequently can lead to consumer applications falling behind. The maximum size
        /// of data that <a>GetRecords</a> can return is 10 MiB. If a call returns this amount
        /// of data, subsequent calls made within the next 5 seconds throw <c>ProvisionedThroughputExceededException</c>.
        /// If there is insufficient provisioned throughput on the stream, subsequent calls made
        /// within the next 1 second throw <c>ProvisionedThroughputExceededException</c>. <a>GetRecords</a>
        /// doesn't return any data when it throws an exception. For this reason, we recommend
        /// that you wait 1 second between calls to <a>GetRecords</a>. However, it's possible
        /// that the application will get exceptions for longer than 1 second.
        /// </para>
        ///  
        /// <para>
        /// To detect whether the application is falling behind in processing, you can use the
        /// <c>MillisBehindLatest</c> response attribute. You can also monitor the stream using
        /// CloudWatch metrics and other mechanisms (see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/monitoring.html">Monitoring</a>
        /// in the <i>Amazon Kinesis Data Streams Developer Guide</i>).
        /// </para>
        ///  
        /// <para>
        /// Each Amazon Kinesis record includes a value, <c>ApproximateArrivalTimestamp</c>, that
        /// is set when a stream successfully receives and stores a record. This is commonly referred
        /// to as a server-side time stamp, whereas a client-side time stamp is set when a data
        /// producer creates or sends the record to a stream (a data producer is any data source
        /// putting data records into a stream, for example with <a>PutRecords</a>). The time
        /// stamp has millisecond precision. There are no guarantees about the time stamp accuracy,
        /// or that the time stamp is always increasing. For example, records in a shard or across
        /// a stream might have time stamps that are out of order.
        /// </para>
        ///  
        /// <para>
        /// This operation has a limit of five transactions per second per shard.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecords service method.</param>
        /// 
        /// <returns>The response from the GetRecords service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ExpiredIteratorException">
        /// The provided iterator exceeds the maximum age allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>Amazon Web Services Key
        /// Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSOptInRequiredException">
        /// The Amazon Web Services access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>Amazon Web Services Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ProvisionedThroughputExceededException">
        /// The request rate for the stream is too high, or the requested data is too large for
        /// the available throughput. Reduce the frequency or size of your requests. For more
        /// information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
        /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>, and <a href="https://docs.aws.amazon.com/general/latest/gr/api-retries.html">Error
        /// Retries and Exponential Backoff in Amazon Web Services</a> in the <i>Amazon Web Services
        /// General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/GetRecords">REST API Reference for GetRecords Operation</seealso>
        public virtual GetRecordsResponse GetRecords(GetRecordsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecordsResponseUnmarshaller.Instance;

            return Invoke<GetRecordsResponse>(request, options);
        }


        /// <summary>
        /// Gets data records from a Kinesis data stream's shard.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// Specify a shard iterator using the <c>ShardIterator</c> parameter. The shard iterator
        /// specifies the position in the shard from which you want to start reading data records
        /// sequentially. If there are no records available in the portion of the shard that the
        /// iterator points to, <a>GetRecords</a> returns an empty list. It might take multiple
        /// calls to get to a portion of the shard that contains records.
        /// </para>
        ///  
        /// <para>
        /// You can scale by provisioning multiple shards per stream while considering service
        /// limits (for more information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Amazon
        /// Kinesis Data Streams Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>).
        /// Your application should have one thread per shard, each reading continuously from
        /// its stream. To read from a stream continually, call <a>GetRecords</a> in a loop. Use
        /// <a>GetShardIterator</a> to get the shard iterator to specify in the first <a>GetRecords</a>
        /// call. <a>GetRecords</a> returns a new shard iterator in <c>NextShardIterator</c>.
        /// Specify the shard iterator returned in <c>NextShardIterator</c> in subsequent calls
        /// to <a>GetRecords</a>. If the shard has been closed, the shard iterator can't return
        /// more data and <a>GetRecords</a> returns <c>null</c> in <c>NextShardIterator</c>. You
        /// can terminate the loop when the shard is closed, or when the shard iterator reaches
        /// the record with the sequence number or other attribute that marks it as the last record
        /// to process.
        /// </para>
        ///  
        /// <para>
        /// Each data record can be up to 1 MiB in size, and each shard can read up to 2 MiB per
        /// second. You can ensure that your calls don't exceed the maximum supported size or
        /// throughput by using the <c>Limit</c> parameter to specify the maximum number of records
        /// that <a>GetRecords</a> can return. Consider your average record size when determining
        /// this limit. The maximum number of records that can be returned per call is 10,000.
        /// </para>
        ///  
        /// <para>
        /// The size of the data returned by <a>GetRecords</a> varies depending on the utilization
        /// of the shard. It is recommended that consumer applications retrieve records via the
        /// <c>GetRecords</c> command using the 5 TPS limit to remain caught up. Retrieving records
        /// less frequently can lead to consumer applications falling behind. The maximum size
        /// of data that <a>GetRecords</a> can return is 10 MiB. If a call returns this amount
        /// of data, subsequent calls made within the next 5 seconds throw <c>ProvisionedThroughputExceededException</c>.
        /// If there is insufficient provisioned throughput on the stream, subsequent calls made
        /// within the next 1 second throw <c>ProvisionedThroughputExceededException</c>. <a>GetRecords</a>
        /// doesn't return any data when it throws an exception. For this reason, we recommend
        /// that you wait 1 second between calls to <a>GetRecords</a>. However, it's possible
        /// that the application will get exceptions for longer than 1 second.
        /// </para>
        ///  
        /// <para>
        /// To detect whether the application is falling behind in processing, you can use the
        /// <c>MillisBehindLatest</c> response attribute. You can also monitor the stream using
        /// CloudWatch metrics and other mechanisms (see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/monitoring.html">Monitoring</a>
        /// in the <i>Amazon Kinesis Data Streams Developer Guide</i>).
        /// </para>
        ///  
        /// <para>
        /// Each Amazon Kinesis record includes a value, <c>ApproximateArrivalTimestamp</c>, that
        /// is set when a stream successfully receives and stores a record. This is commonly referred
        /// to as a server-side time stamp, whereas a client-side time stamp is set when a data
        /// producer creates or sends the record to a stream (a data producer is any data source
        /// putting data records into a stream, for example with <a>PutRecords</a>). The time
        /// stamp has millisecond precision. There are no guarantees about the time stamp accuracy,
        /// or that the time stamp is always increasing. For example, records in a shard or across
        /// a stream might have time stamps that are out of order.
        /// </para>
        ///  
        /// <para>
        /// This operation has a limit of five transactions per second per shard.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecords service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ExpiredIteratorException">
        /// The provided iterator exceeds the maximum age allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>Amazon Web Services Key
        /// Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSOptInRequiredException">
        /// The Amazon Web Services access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>Amazon Web Services Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ProvisionedThroughputExceededException">
        /// The request rate for the stream is too high, or the requested data is too large for
        /// the available throughput. Reduce the frequency or size of your requests. For more
        /// information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
        /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>, and <a href="https://docs.aws.amazon.com/general/latest/gr/api-retries.html">Error
        /// Retries and Exponential Backoff in Amazon Web Services</a> in the <i>Amazon Web Services
        /// General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/GetRecords">REST API Reference for GetRecords Operation</seealso>
        public virtual Task<GetRecordsResponse> GetRecordsAsync(GetRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecordsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRecordsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Returns a policy attached to the specified data stream or consumer. Request patterns
        /// can be one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Data stream pattern: <c>arn:aws.*:kinesis:.*:\d{12}:.*stream/\S+</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Consumer pattern: <c>^(arn):aws.*:kinesis:.*:\d{12}:.*stream\/[a-zA-Z0-9_.-]+\/consumer\/[a-zA-Z0-9_.-]+:[0-9]+</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Returns a policy attached to the specified data stream or consumer. Request patterns
        /// can be one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Data stream pattern: <c>arn:aws.*:kinesis:.*:\d{12}:.*stream/\S+</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Consumer pattern: <c>^(arn):aws.*:kinesis:.*:\d{12}:.*stream\/[a-zA-Z0-9_.-]+\/consumer\/[a-zA-Z0-9_.-]+:[0-9]+</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetShardIterator


        /// <summary>
        /// Gets an Amazon Kinesis shard iterator. A shard iterator expires 5 minutes after it
        /// is returned to the requester.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// A shard iterator specifies the shard position from which to start reading data records
        /// sequentially. The position is specified using the sequence number of a data record
        /// in a shard. A sequence number is the identifier associated with every record ingested
        /// in the stream, and is assigned when a record is put into the stream. Each stream has
        /// one or more shards.
        /// </para>
        ///  
        /// <para>
        /// You must specify the shard iterator type. For example, you can set the <c>ShardIteratorType</c>
        /// parameter to read exactly from the position denoted by a specific sequence number
        /// by using the <c>AT_SEQUENCE_NUMBER</c> shard iterator type. Alternatively, the parameter
        /// can read right after the sequence number by using the <c>AFTER_SEQUENCE_NUMBER</c>
        /// shard iterator type, using sequence numbers returned by earlier calls to <a>PutRecord</a>,
        /// <a>PutRecords</a>, <a>GetRecords</a>, or <a>DescribeStream</a>. In the request, you
        /// can specify the shard iterator type <c>AT_TIMESTAMP</c> to read records from an arbitrary
        /// point in time, <c>TRIM_HORIZON</c> to cause <c>ShardIterator</c> to point to the last
        /// untrimmed record in the shard in the system (the oldest data record in the shard),
        /// or <c>LATEST</c> so that you always read the most recent data in the shard. 
        /// </para>
        ///  
        /// <para>
        /// When you read repeatedly from a stream, use a <a>GetShardIterator</a> request to get
        /// the first shard iterator for use in your first <a>GetRecords</a> request and for subsequent
        /// reads use the shard iterator returned by the <a>GetRecords</a> request in <c>NextShardIterator</c>.
        /// A new shard iterator is returned by every <a>GetRecords</a> request in <c>NextShardIterator</c>,
        /// which you use in the <c>ShardIterator</c> parameter of the next <a>GetRecords</a>
        /// request. 
        /// </para>
        ///  
        /// <para>
        /// If a <a>GetShardIterator</a> request is made too often, you receive a <c>ProvisionedThroughputExceededException</c>.
        /// For more information about throughput limits, see <a>GetRecords</a>, and <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
        /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the shard is closed, <a>GetShardIterator</a> returns a valid iterator for the last
        /// sequence number of the shard. A shard can be closed as a result of using <a>SplitShard</a>
        /// or <a>MergeShards</a>.
        /// </para>
        ///  
        /// <para>
        ///  <a>GetShardIterator</a> has a limit of five transactions per second per account per
        /// open shard.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetShardIterator service method.</param>
        /// 
        /// <returns>The response from the GetShardIterator service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ProvisionedThroughputExceededException">
        /// The request rate for the stream is too high, or the requested data is too large for
        /// the available throughput. Reduce the frequency or size of your requests. For more
        /// information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
        /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>, and <a href="https://docs.aws.amazon.com/general/latest/gr/api-retries.html">Error
        /// Retries and Exponential Backoff in Amazon Web Services</a> in the <i>Amazon Web Services
        /// General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/GetShardIterator">REST API Reference for GetShardIterator Operation</seealso>
        public virtual GetShardIteratorResponse GetShardIterator(GetShardIteratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetShardIteratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetShardIteratorResponseUnmarshaller.Instance;

            return Invoke<GetShardIteratorResponse>(request, options);
        }


        /// <summary>
        /// Gets an Amazon Kinesis shard iterator. A shard iterator expires 5 minutes after it
        /// is returned to the requester.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// A shard iterator specifies the shard position from which to start reading data records
        /// sequentially. The position is specified using the sequence number of a data record
        /// in a shard. A sequence number is the identifier associated with every record ingested
        /// in the stream, and is assigned when a record is put into the stream. Each stream has
        /// one or more shards.
        /// </para>
        ///  
        /// <para>
        /// You must specify the shard iterator type. For example, you can set the <c>ShardIteratorType</c>
        /// parameter to read exactly from the position denoted by a specific sequence number
        /// by using the <c>AT_SEQUENCE_NUMBER</c> shard iterator type. Alternatively, the parameter
        /// can read right after the sequence number by using the <c>AFTER_SEQUENCE_NUMBER</c>
        /// shard iterator type, using sequence numbers returned by earlier calls to <a>PutRecord</a>,
        /// <a>PutRecords</a>, <a>GetRecords</a>, or <a>DescribeStream</a>. In the request, you
        /// can specify the shard iterator type <c>AT_TIMESTAMP</c> to read records from an arbitrary
        /// point in time, <c>TRIM_HORIZON</c> to cause <c>ShardIterator</c> to point to the last
        /// untrimmed record in the shard in the system (the oldest data record in the shard),
        /// or <c>LATEST</c> so that you always read the most recent data in the shard. 
        /// </para>
        ///  
        /// <para>
        /// When you read repeatedly from a stream, use a <a>GetShardIterator</a> request to get
        /// the first shard iterator for use in your first <a>GetRecords</a> request and for subsequent
        /// reads use the shard iterator returned by the <a>GetRecords</a> request in <c>NextShardIterator</c>.
        /// A new shard iterator is returned by every <a>GetRecords</a> request in <c>NextShardIterator</c>,
        /// which you use in the <c>ShardIterator</c> parameter of the next <a>GetRecords</a>
        /// request. 
        /// </para>
        ///  
        /// <para>
        /// If a <a>GetShardIterator</a> request is made too often, you receive a <c>ProvisionedThroughputExceededException</c>.
        /// For more information about throughput limits, see <a>GetRecords</a>, and <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
        /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the shard is closed, <a>GetShardIterator</a> returns a valid iterator for the last
        /// sequence number of the shard. A shard can be closed as a result of using <a>SplitShard</a>
        /// or <a>MergeShards</a>.
        /// </para>
        ///  
        /// <para>
        ///  <a>GetShardIterator</a> has a limit of five transactions per second per account per
        /// open shard.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetShardIterator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetShardIterator service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ProvisionedThroughputExceededException">
        /// The request rate for the stream is too high, or the requested data is too large for
        /// the available throughput. Reduce the frequency or size of your requests. For more
        /// information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
        /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>, and <a href="https://docs.aws.amazon.com/general/latest/gr/api-retries.html">Error
        /// Retries and Exponential Backoff in Amazon Web Services</a> in the <i>Amazon Web Services
        /// General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/GetShardIterator">REST API Reference for GetShardIterator Operation</seealso>
        public virtual Task<GetShardIteratorResponse> GetShardIteratorAsync(GetShardIteratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetShardIteratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetShardIteratorResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetShardIteratorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  IncreaseStreamRetentionPeriod


        /// <summary>
        /// Increases the Kinesis data stream's retention period, which is the length of time
        /// data records are accessible after they are added to the stream. The maximum value
        /// of a stream's retention period is 8760 hours (365 days).
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you choose a longer stream retention period, this operation increases the time
        /// period during which records that have not yet expired are accessible. However, it
        /// does not make previous, expired data (older than the stream's previous retention period)
        /// accessible after the operation has been called. For example, if a stream's retention
        /// period is set to 24 hours and is increased to 168 hours, any data that is older than
        /// 24 hours remains inaccessible to consumer applications.
        /// </para>
        /// </summary>
        /// <param name="streamName">The name of the stream to modify.</param>
        /// <param name="retentionPeriodHours">The new retention period of the stream, in hours. Must be more than the current retention period.</param>
        /// 
        /// <returns>The response from the IncreaseStreamRetentionPeriod service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/IncreaseStreamRetentionPeriod">REST API Reference for IncreaseStreamRetentionPeriod Operation</seealso>
        public virtual IncreaseStreamRetentionPeriodResponse IncreaseStreamRetentionPeriod(string streamName, int? retentionPeriodHours)
        {
            var request = new IncreaseStreamRetentionPeriodRequest();
            request.StreamName = streamName;
            request.RetentionPeriodHours = retentionPeriodHours;
            return IncreaseStreamRetentionPeriod(request);
        }


        /// <summary>
        /// Increases the Kinesis data stream's retention period, which is the length of time
        /// data records are accessible after they are added to the stream. The maximum value
        /// of a stream's retention period is 8760 hours (365 days).
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you choose a longer stream retention period, this operation increases the time
        /// period during which records that have not yet expired are accessible. However, it
        /// does not make previous, expired data (older than the stream's previous retention period)
        /// accessible after the operation has been called. For example, if a stream's retention
        /// period is set to 24 hours and is increased to 168 hours, any data that is older than
        /// 24 hours remains inaccessible to consumer applications.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IncreaseStreamRetentionPeriod service method.</param>
        /// 
        /// <returns>The response from the IncreaseStreamRetentionPeriod service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/IncreaseStreamRetentionPeriod">REST API Reference for IncreaseStreamRetentionPeriod Operation</seealso>
        public virtual IncreaseStreamRetentionPeriodResponse IncreaseStreamRetentionPeriod(IncreaseStreamRetentionPeriodRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IncreaseStreamRetentionPeriodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IncreaseStreamRetentionPeriodResponseUnmarshaller.Instance;

            return Invoke<IncreaseStreamRetentionPeriodResponse>(request, options);
        }


        /// <summary>
        /// Increases the Kinesis data stream's retention period, which is the length of time
        /// data records are accessible after they are added to the stream. The maximum value
        /// of a stream's retention period is 8760 hours (365 days).
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you choose a longer stream retention period, this operation increases the time
        /// period during which records that have not yet expired are accessible. However, it
        /// does not make previous, expired data (older than the stream's previous retention period)
        /// accessible after the operation has been called. For example, if a stream's retention
        /// period is set to 24 hours and is increased to 168 hours, any data that is older than
        /// 24 hours remains inaccessible to consumer applications.
        /// </para>
        /// </summary>
        /// <param name="streamName">The name of the stream to modify.</param>
        /// <param name="retentionPeriodHours">The new retention period of the stream, in hours. Must be more than the current retention period.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IncreaseStreamRetentionPeriod service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/IncreaseStreamRetentionPeriod">REST API Reference for IncreaseStreamRetentionPeriod Operation</seealso>
        public virtual Task<IncreaseStreamRetentionPeriodResponse> IncreaseStreamRetentionPeriodAsync(string streamName, int? retentionPeriodHours, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new IncreaseStreamRetentionPeriodRequest();
            request.StreamName = streamName;
            request.RetentionPeriodHours = retentionPeriodHours;
            return IncreaseStreamRetentionPeriodAsync(request, cancellationToken);
        }


        /// <summary>
        /// Increases the Kinesis data stream's retention period, which is the length of time
        /// data records are accessible after they are added to the stream. The maximum value
        /// of a stream's retention period is 8760 hours (365 days).
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you choose a longer stream retention period, this operation increases the time
        /// period during which records that have not yet expired are accessible. However, it
        /// does not make previous, expired data (older than the stream's previous retention period)
        /// accessible after the operation has been called. For example, if a stream's retention
        /// period is set to 24 hours and is increased to 168 hours, any data that is older than
        /// 24 hours remains inaccessible to consumer applications.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IncreaseStreamRetentionPeriod service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IncreaseStreamRetentionPeriod service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/IncreaseStreamRetentionPeriod">REST API Reference for IncreaseStreamRetentionPeriod Operation</seealso>
        public virtual Task<IncreaseStreamRetentionPeriodResponse> IncreaseStreamRetentionPeriodAsync(IncreaseStreamRetentionPeriodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IncreaseStreamRetentionPeriodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IncreaseStreamRetentionPeriodResponseUnmarshaller.Instance;
            
            return InvokeAsync<IncreaseStreamRetentionPeriodResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListShards


        /// <summary>
        /// Lists the shards in a stream and provides information about each shard. This operation
        /// has a limit of 1000 transactions per second per data stream.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// This action does not list expired shards. For information about expired shards, see
        /// <a href="https://docs.aws.amazon.com/streams/latest/dev/kinesis-using-sdk-java-after-resharding.html#kinesis-using-sdk-java-resharding-data-routing">Data
        /// Routing, Data Persistence, and Shard State after a Reshard</a>. 
        /// </para>
        ///  <important> 
        /// <para>
        /// This API is a new operation that is used by the Amazon Kinesis Client Library (KCL).
        /// If you have a fine-grained IAM policy that only allows specific operations, you must
        /// update your policy to allow calls to this API. For more information, see <a href="https://docs.aws.amazon.com/streams/latest/dev/controlling-access.html">Controlling
        /// Access to Amazon Kinesis Data Streams Resources Using IAM</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListShards service method.</param>
        /// 
        /// <returns>The response from the ListShards service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ExpiredNextTokenException">
        /// The pagination token passed to the operation is expired.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListShards">REST API Reference for ListShards Operation</seealso>
        public virtual ListShardsResponse ListShards(ListShardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListShardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListShardsResponseUnmarshaller.Instance;

            return Invoke<ListShardsResponse>(request, options);
        }


        /// <summary>
        /// Lists the shards in a stream and provides information about each shard. This operation
        /// has a limit of 1000 transactions per second per data stream.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// This action does not list expired shards. For information about expired shards, see
        /// <a href="https://docs.aws.amazon.com/streams/latest/dev/kinesis-using-sdk-java-after-resharding.html#kinesis-using-sdk-java-resharding-data-routing">Data
        /// Routing, Data Persistence, and Shard State after a Reshard</a>. 
        /// </para>
        ///  <important> 
        /// <para>
        /// This API is a new operation that is used by the Amazon Kinesis Client Library (KCL).
        /// If you have a fine-grained IAM policy that only allows specific operations, you must
        /// update your policy to allow calls to this API. For more information, see <a href="https://docs.aws.amazon.com/streams/latest/dev/controlling-access.html">Controlling
        /// Access to Amazon Kinesis Data Streams Resources Using IAM</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListShards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListShards service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ExpiredNextTokenException">
        /// The pagination token passed to the operation is expired.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListShards">REST API Reference for ListShards Operation</seealso>
        public virtual Task<ListShardsResponse> ListShardsAsync(ListShardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListShardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListShardsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListShardsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStreamConsumers


        /// <summary>
        /// Lists the consumers registered to receive data from a stream using enhanced fan-out,
        /// and provides information about each consumer.
        /// 
        ///  
        /// <para>
        /// This operation has a limit of 5 transactions per second per stream.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamConsumers service method.</param>
        /// 
        /// <returns>The response from the ListStreamConsumers service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.ExpiredNextTokenException">
        /// The pagination token passed to the operation is expired.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListStreamConsumers">REST API Reference for ListStreamConsumers Operation</seealso>
        public virtual ListStreamConsumersResponse ListStreamConsumers(ListStreamConsumersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamConsumersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamConsumersResponseUnmarshaller.Instance;

            return Invoke<ListStreamConsumersResponse>(request, options);
        }


        /// <summary>
        /// Lists the consumers registered to receive data from a stream using enhanced fan-out,
        /// and provides information about each consumer.
        /// 
        ///  
        /// <para>
        /// This operation has a limit of 5 transactions per second per stream.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamConsumers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreamConsumers service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.ExpiredNextTokenException">
        /// The pagination token passed to the operation is expired.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListStreamConsumers">REST API Reference for ListStreamConsumers Operation</seealso>
        public virtual Task<ListStreamConsumersResponse> ListStreamConsumersAsync(ListStreamConsumersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamConsumersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamConsumersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListStreamConsumersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStreams


        /// <summary>
        /// Lists your Kinesis data streams.
        /// 
        ///  
        /// <para>
        /// The number of streams may be too large to return from a single call to <c>ListStreams</c>.
        /// You can limit the number of returned streams using the <c>Limit</c> parameter. If
        /// you do not specify a value for the <c>Limit</c> parameter, Kinesis Data Streams uses
        /// the default limit, which is currently 100.
        /// </para>
        ///  
        /// <para>
        /// You can detect if there are more streams available to list by using the <c>HasMoreStreams</c>
        /// flag from the returned output. If there are more streams available, you can request
        /// more streams by using the name of the last stream returned by the <c>ListStreams</c>
        /// request in the <c>ExclusiveStartStreamName</c> parameter in a subsequent request to
        /// <c>ListStreams</c>. The group of stream names returned by the subsequent request is
        /// then added to the list. You can continue this process until all the stream names have
        /// been collected in the list. 
        /// </para>
        ///  
        /// <para>
        ///  <a>ListStreams</a> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.ExpiredNextTokenException">
        /// The pagination token passed to the operation is expired.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual ListStreamsResponse ListStreams()
        {
            return ListStreams(new ListStreamsRequest());
        }


        /// <summary>
        /// Lists your Kinesis data streams.
        /// 
        ///  
        /// <para>
        /// The number of streams may be too large to return from a single call to <c>ListStreams</c>.
        /// You can limit the number of returned streams using the <c>Limit</c> parameter. If
        /// you do not specify a value for the <c>Limit</c> parameter, Kinesis Data Streams uses
        /// the default limit, which is currently 100.
        /// </para>
        ///  
        /// <para>
        /// You can detect if there are more streams available to list by using the <c>HasMoreStreams</c>
        /// flag from the returned output. If there are more streams available, you can request
        /// more streams by using the name of the last stream returned by the <c>ListStreams</c>
        /// request in the <c>ExclusiveStartStreamName</c> parameter in a subsequent request to
        /// <c>ListStreams</c>. The group of stream names returned by the subsequent request is
        /// then added to the list. You can continue this process until all the stream names have
        /// been collected in the list. 
        /// </para>
        ///  
        /// <para>
        ///  <a>ListStreams</a> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreams service method.</param>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.ExpiredNextTokenException">
        /// The pagination token passed to the operation is expired.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual ListStreamsResponse ListStreams(ListStreamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return Invoke<ListStreamsResponse>(request, options);
        }


        /// <summary>
        /// Lists your Kinesis data streams.
        /// 
        ///  
        /// <para>
        /// The number of streams may be too large to return from a single call to <c>ListStreams</c>.
        /// You can limit the number of returned streams using the <c>Limit</c> parameter. If
        /// you do not specify a value for the <c>Limit</c> parameter, Kinesis Data Streams uses
        /// the default limit, which is currently 100.
        /// </para>
        ///  
        /// <para>
        /// You can detect if there are more streams available to list by using the <c>HasMoreStreams</c>
        /// flag from the returned output. If there are more streams available, you can request
        /// more streams by using the name of the last stream returned by the <c>ListStreams</c>
        /// request in the <c>ExclusiveStartStreamName</c> parameter in a subsequent request to
        /// <c>ListStreams</c>. The group of stream names returned by the subsequent request is
        /// then added to the list. You can continue this process until all the stream names have
        /// been collected in the list. 
        /// </para>
        ///  
        /// <para>
        ///  <a>ListStreams</a> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.ExpiredNextTokenException">
        /// The pagination token passed to the operation is expired.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual Task<ListStreamsResponse> ListStreamsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListStreamsAsync(new ListStreamsRequest(), cancellationToken);
        }

        /// <summary>
        /// Lists your Kinesis data streams.
        /// 
        ///  
        /// <para>
        /// The number of streams may be too large to return from a single call to <c>ListStreams</c>.
        /// You can limit the number of returned streams using the <c>Limit</c> parameter. If
        /// you do not specify a value for the <c>Limit</c> parameter, Kinesis Data Streams uses
        /// the default limit, which is currently 100.
        /// </para>
        ///  
        /// <para>
        /// You can detect if there are more streams available to list by using the <c>HasMoreStreams</c>
        /// flag from the returned output. If there are more streams available, you can request
        /// more streams by using the name of the last stream returned by the <c>ListStreams</c>
        /// request in the <c>ExclusiveStartStreamName</c> parameter in a subsequent request to
        /// <c>ListStreams</c>. The group of stream names returned by the subsequent request is
        /// then added to the list. You can continue this process until all the stream names have
        /// been collected in the list. 
        /// </para>
        ///  
        /// <para>
        ///  <a>ListStreams</a> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.ExpiredNextTokenException">
        /// The pagination token passed to the operation is expired.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual Task<ListStreamsResponse> ListStreamsAsync(ListStreamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListStreamsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForStream


        /// <summary>
        /// Lists the tags for the specified Kinesis data stream. This operation has a limit of
        /// five transactions per second per account.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForStream service method.</param>
        /// 
        /// <returns>The response from the ListTagsForStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListTagsForStream">REST API Reference for ListTagsForStream Operation</seealso>
        public virtual ListTagsForStreamResponse ListTagsForStream(ListTagsForStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForStreamResponseUnmarshaller.Instance;

            return Invoke<ListTagsForStreamResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags for the specified Kinesis data stream. This operation has a limit of
        /// five transactions per second per account.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListTagsForStream">REST API Reference for ListTagsForStream Operation</seealso>
        public virtual Task<ListTagsForStreamResponse> ListTagsForStreamAsync(ListTagsForStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MergeShards


        /// <summary>
        /// Merges two adjacent shards in a Kinesis data stream and combines them into a single
        /// shard to reduce the stream's capacity to ingest and transport data. This API is only
        /// supported for the data streams with the provisioned capacity mode. Two shards are
        /// considered adjacent if the union of the hash key ranges for the two shards form a
        /// contiguous set with no gaps. For example, if you have two shards, one with a hash
        /// key range of 276...381 and the other with a hash key range of 382...454, then you
        /// could merge these two shards into a single shard that would have a hash key range
        /// of 276...454. After the merge, the single child shard receives data for all hash key
        /// values covered by the two parent shards.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <c>MergeShards</c> is called when there is a need to reduce the overall capacity
        /// of a stream because of excess capacity that is not being used. You must specify the
        /// shard to be merged and the adjacent shard for a stream. For more information about
        /// merging shards, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-sdk-java-resharding-merge.html">Merge
        /// Two Shards</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the stream is in the <c>ACTIVE</c> state, you can call <c>MergeShards</c>. If a
        /// stream is in the <c>CREATING</c>, <c>UPDATING</c>, or <c>DELETING</c> state, <c>MergeShards</c>
        /// returns a <c>ResourceInUseException</c>. If the specified stream does not exist, <c>MergeShards</c>
        /// returns a <c>ResourceNotFoundException</c>. 
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeStreamSummary</a> to check the state of the stream, which is
        /// returned in <c>StreamStatus</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>MergeShards</c> is an asynchronous operation. Upon receiving a <c>MergeShards</c>
        /// request, Amazon Kinesis Data Streams immediately returns a response and sets the <c>StreamStatus</c>
        /// to <c>UPDATING</c>. After the operation is completed, Kinesis Data Streams sets the
        /// <c>StreamStatus</c> to <c>ACTIVE</c>. Read and write operations continue to work while
        /// the stream is in the <c>UPDATING</c> state. 
        /// </para>
        ///  
        /// <para>
        /// You use <a>DescribeStreamSummary</a> and the <a>ListShards</a> APIs to determine the
        /// shard IDs that are specified in the <c>MergeShards</c> request. 
        /// </para>
        ///  
        /// <para>
        /// If you try to operate on too many streams in parallel using <a>CreateStream</a>, <a>DeleteStream</a>,
        /// <c>MergeShards</c>, or <a>SplitShard</a>, you receive a <c>LimitExceededException</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>MergeShards</c> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergeShards service method.</param>
        /// 
        /// <returns>The response from the MergeShards service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ValidationException">
        /// Specifies that you tried to invoke this API for a data stream with the on-demand capacity
        /// mode. This API is only supported for data streams with the provisioned capacity mode.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/MergeShards">REST API Reference for MergeShards Operation</seealso>
        public virtual MergeShardsResponse MergeShards(MergeShardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MergeShardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergeShardsResponseUnmarshaller.Instance;

            return Invoke<MergeShardsResponse>(request, options);
        }


        /// <summary>
        /// Merges two adjacent shards in a Kinesis data stream and combines them into a single
        /// shard to reduce the stream's capacity to ingest and transport data. This API is only
        /// supported for the data streams with the provisioned capacity mode. Two shards are
        /// considered adjacent if the union of the hash key ranges for the two shards form a
        /// contiguous set with no gaps. For example, if you have two shards, one with a hash
        /// key range of 276...381 and the other with a hash key range of 382...454, then you
        /// could merge these two shards into a single shard that would have a hash key range
        /// of 276...454. After the merge, the single child shard receives data for all hash key
        /// values covered by the two parent shards.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <c>MergeShards</c> is called when there is a need to reduce the overall capacity
        /// of a stream because of excess capacity that is not being used. You must specify the
        /// shard to be merged and the adjacent shard for a stream. For more information about
        /// merging shards, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-sdk-java-resharding-merge.html">Merge
        /// Two Shards</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the stream is in the <c>ACTIVE</c> state, you can call <c>MergeShards</c>. If a
        /// stream is in the <c>CREATING</c>, <c>UPDATING</c>, or <c>DELETING</c> state, <c>MergeShards</c>
        /// returns a <c>ResourceInUseException</c>. If the specified stream does not exist, <c>MergeShards</c>
        /// returns a <c>ResourceNotFoundException</c>. 
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeStreamSummary</a> to check the state of the stream, which is
        /// returned in <c>StreamStatus</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>MergeShards</c> is an asynchronous operation. Upon receiving a <c>MergeShards</c>
        /// request, Amazon Kinesis Data Streams immediately returns a response and sets the <c>StreamStatus</c>
        /// to <c>UPDATING</c>. After the operation is completed, Kinesis Data Streams sets the
        /// <c>StreamStatus</c> to <c>ACTIVE</c>. Read and write operations continue to work while
        /// the stream is in the <c>UPDATING</c> state. 
        /// </para>
        ///  
        /// <para>
        /// You use <a>DescribeStreamSummary</a> and the <a>ListShards</a> APIs to determine the
        /// shard IDs that are specified in the <c>MergeShards</c> request. 
        /// </para>
        ///  
        /// <para>
        /// If you try to operate on too many streams in parallel using <a>CreateStream</a>, <a>DeleteStream</a>,
        /// <c>MergeShards</c>, or <a>SplitShard</a>, you receive a <c>LimitExceededException</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>MergeShards</c> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergeShards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MergeShards service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ValidationException">
        /// Specifies that you tried to invoke this API for a data stream with the on-demand capacity
        /// mode. This API is only supported for data streams with the provisioned capacity mode.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/MergeShards">REST API Reference for MergeShards Operation</seealso>
        public virtual Task<MergeShardsResponse> MergeShardsAsync(MergeShardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MergeShardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergeShardsResponseUnmarshaller.Instance;
            
            return InvokeAsync<MergeShardsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRecord


        /// <summary>
        /// Writes a single data record into an Amazon Kinesis data stream. Call <c>PutRecord</c>
        /// to send data into the stream for real-time ingestion and subsequent processing, one
        /// record at a time. Each shard can support writes up to 1,000 records per second, up
        /// to a maximum data write total of 1 MiB per second.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// You must specify the name of the stream that captures, stores, and transports the
        /// data; a partition key; and the data blob itself.
        /// </para>
        ///  
        /// <para>
        /// The data blob can be any type of data; for example, a segment from a log file, geographic/location
        /// data, website clickstream data, and so on.
        /// </para>
        ///  
        /// <para>
        /// The partition key is used by Kinesis Data Streams to distribute data across shards.
        /// Kinesis Data Streams segregates the data records that belong to a stream into multiple
        /// shards, using the partition key associated with each data record to determine the
        /// shard to which a given data record belongs.
        /// </para>
        ///  
        /// <para>
        /// Partition keys are Unicode strings, with a maximum length limit of 256 characters
        /// for each key. An MD5 hash function is used to map partition keys to 128-bit integer
        /// values and to map associated data records to shards using the hash key ranges of the
        /// shards. You can override hashing the partition key to determine the shard by explicitly
        /// specifying a hash value using the <c>ExplicitHashKey</c> parameter. For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/developing-producers-with-sdk.html#kinesis-using-sdk-java-add-data-to-stream">Adding
        /// Data to a Stream</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <c>PutRecord</c> returns the shard ID of where the data record was placed and the
        /// sequence number that was assigned to the data record.
        /// </para>
        ///  
        /// <para>
        /// Sequence numbers increase over time and are specific to a shard within a stream, not
        /// across all shards within a stream. To guarantee strictly increasing ordering, write
        /// serially to a shard and use the <c>SequenceNumberForOrdering</c> parameter. For more
        /// information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/developing-producers-with-sdk.html#kinesis-using-sdk-java-add-data-to-stream">Adding
        /// Data to a Stream</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// After you write a record to a stream, you cannot modify that record or its order within
        /// the stream.
        /// </para>
        ///  </important> 
        /// <para>
        /// If a <c>PutRecord</c> request cannot be processed because of insufficient provisioned
        /// throughput on the shard involved in the request, <c>PutRecord</c> throws <c>ProvisionedThroughputExceededException</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// By default, data records are accessible for 24 hours from the time that they are added
        /// to a stream. You can use <a>IncreaseStreamRetentionPeriod</a> or <a>DecreaseStreamRetentionPeriod</a>
        /// to modify this retention period.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecord service method.</param>
        /// 
        /// <returns>The response from the PutRecord service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>Amazon Web Services Key
        /// Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSOptInRequiredException">
        /// The Amazon Web Services access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>Amazon Web Services Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ProvisionedThroughputExceededException">
        /// The request rate for the stream is too high, or the requested data is too large for
        /// the available throughput. Reduce the frequency or size of your requests. For more
        /// information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
        /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>, and <a href="https://docs.aws.amazon.com/general/latest/gr/api-retries.html">Error
        /// Retries and Exponential Backoff in Amazon Web Services</a> in the <i>Amazon Web Services
        /// General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/PutRecord">REST API Reference for PutRecord Operation</seealso>
        public virtual PutRecordResponse PutRecord(PutRecordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecordResponseUnmarshaller.Instance;

            return Invoke<PutRecordResponse>(request, options);
        }


        /// <summary>
        /// Writes a single data record into an Amazon Kinesis data stream. Call <c>PutRecord</c>
        /// to send data into the stream for real-time ingestion and subsequent processing, one
        /// record at a time. Each shard can support writes up to 1,000 records per second, up
        /// to a maximum data write total of 1 MiB per second.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// You must specify the name of the stream that captures, stores, and transports the
        /// data; a partition key; and the data blob itself.
        /// </para>
        ///  
        /// <para>
        /// The data blob can be any type of data; for example, a segment from a log file, geographic/location
        /// data, website clickstream data, and so on.
        /// </para>
        ///  
        /// <para>
        /// The partition key is used by Kinesis Data Streams to distribute data across shards.
        /// Kinesis Data Streams segregates the data records that belong to a stream into multiple
        /// shards, using the partition key associated with each data record to determine the
        /// shard to which a given data record belongs.
        /// </para>
        ///  
        /// <para>
        /// Partition keys are Unicode strings, with a maximum length limit of 256 characters
        /// for each key. An MD5 hash function is used to map partition keys to 128-bit integer
        /// values and to map associated data records to shards using the hash key ranges of the
        /// shards. You can override hashing the partition key to determine the shard by explicitly
        /// specifying a hash value using the <c>ExplicitHashKey</c> parameter. For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/developing-producers-with-sdk.html#kinesis-using-sdk-java-add-data-to-stream">Adding
        /// Data to a Stream</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <c>PutRecord</c> returns the shard ID of where the data record was placed and the
        /// sequence number that was assigned to the data record.
        /// </para>
        ///  
        /// <para>
        /// Sequence numbers increase over time and are specific to a shard within a stream, not
        /// across all shards within a stream. To guarantee strictly increasing ordering, write
        /// serially to a shard and use the <c>SequenceNumberForOrdering</c> parameter. For more
        /// information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/developing-producers-with-sdk.html#kinesis-using-sdk-java-add-data-to-stream">Adding
        /// Data to a Stream</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// After you write a record to a stream, you cannot modify that record or its order within
        /// the stream.
        /// </para>
        ///  </important> 
        /// <para>
        /// If a <c>PutRecord</c> request cannot be processed because of insufficient provisioned
        /// throughput on the shard involved in the request, <c>PutRecord</c> throws <c>ProvisionedThroughputExceededException</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// By default, data records are accessible for 24 hours from the time that they are added
        /// to a stream. You can use <a>IncreaseStreamRetentionPeriod</a> or <a>DecreaseStreamRetentionPeriod</a>
        /// to modify this retention period.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRecord service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>Amazon Web Services Key
        /// Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSOptInRequiredException">
        /// The Amazon Web Services access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>Amazon Web Services Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ProvisionedThroughputExceededException">
        /// The request rate for the stream is too high, or the requested data is too large for
        /// the available throughput. Reduce the frequency or size of your requests. For more
        /// information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
        /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>, and <a href="https://docs.aws.amazon.com/general/latest/gr/api-retries.html">Error
        /// Retries and Exponential Backoff in Amazon Web Services</a> in the <i>Amazon Web Services
        /// General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/PutRecord">REST API Reference for PutRecord Operation</seealso>
        public virtual Task<PutRecordResponse> PutRecordAsync(PutRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecordResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutRecordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRecords


        /// <summary>
        /// Writes multiple data records into a Kinesis data stream in a single call (also referred
        /// to as a <c>PutRecords</c> request). Use this operation to send data into the stream
        /// for data ingestion and processing. 
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// Each <c>PutRecords</c> request can support up to 500 records. Each record in the request
        /// can be as large as 1 MiB, up to a limit of 5 MiB for the entire request, including
        /// partition keys. Each shard can support writes up to 1,000 records per second, up to
        /// a maximum data write total of 1 MiB per second.
        /// </para>
        ///  
        /// <para>
        /// You must specify the name of the stream that captures, stores, and transports the
        /// data; and an array of request <c>Records</c>, with each record in the array requiring
        /// a partition key and data blob. The record size limit applies to the total size of
        /// the partition key and data blob.
        /// </para>
        ///  
        /// <para>
        /// The data blob can be any type of data; for example, a segment from a log file, geographic/location
        /// data, website clickstream data, and so on.
        /// </para>
        ///  
        /// <para>
        /// The partition key is used by Kinesis Data Streams as input to a hash function that
        /// maps the partition key and associated data to a specific shard. An MD5 hash function
        /// is used to map partition keys to 128-bit integer values and to map associated data
        /// records to shards. As a result of this hashing mechanism, all data records with the
        /// same partition key map to the same shard within the stream. For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/developing-producers-with-sdk.html#kinesis-using-sdk-java-add-data-to-stream">Adding
        /// Data to a Stream</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Each record in the <c>Records</c> array may include an optional parameter, <c>ExplicitHashKey</c>,
        /// which overrides the partition key to shard mapping. This parameter allows a data producer
        /// to determine explicitly the shard where the record is stored. For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/developing-producers-with-sdk.html#kinesis-using-sdk-java-putrecords">Adding
        /// Multiple Records with PutRecords</a> in the <i>Amazon Kinesis Data Streams Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The <c>PutRecords</c> response includes an array of response <c>Records</c>. Each
        /// record in the response array directly correlates with a record in the request array
        /// using natural ordering, from the top to the bottom of the request and response. The
        /// response <c>Records</c> array always includes the same number of records as the request
        /// array.
        /// </para>
        ///  
        /// <para>
        /// The response <c>Records</c> array includes both successfully and unsuccessfully processed
        /// records. Kinesis Data Streams attempts to process all records in each <c>PutRecords</c>
        /// request. A single record failure does not stop the processing of subsequent records.
        /// As a result, PutRecords doesn't guarantee the ordering of records. If you need to
        /// read records in the same order they are written to the stream, use <a>PutRecord</a>
        /// instead of <c>PutRecords</c>, and write to the same shard.
        /// </para>
        ///  
        /// <para>
        /// A successfully processed record includes <c>ShardId</c> and <c>SequenceNumber</c>
        /// values. The <c>ShardId</c> parameter identifies the shard in the stream where the
        /// record is stored. The <c>SequenceNumber</c> parameter is an identifier assigned to
        /// the put record, unique to all records in the stream.
        /// </para>
        ///  
        /// <para>
        /// An unsuccessfully processed record includes <c>ErrorCode</c> and <c>ErrorMessage</c>
        /// values. <c>ErrorCode</c> reflects the type of error and can be one of the following
        /// values: <c>ProvisionedThroughputExceededException</c> or <c>InternalFailure</c>. <c>ErrorMessage</c>
        /// provides more detailed information about the <c>ProvisionedThroughputExceededException</c>
        /// exception including the account ID, stream name, and shard ID of the record that was
        /// throttled. For more information about partially successful responses, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-sdk-java-add-data-to-stream.html#kinesis-using-sdk-java-putrecords">Adding
        /// Multiple Records with PutRecords</a> in the <i>Amazon Kinesis Data Streams Developer
        /// Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// After you write a record to a stream, you cannot modify that record or its order within
        /// the stream.
        /// </para>
        ///  </important> 
        /// <para>
        /// By default, data records are accessible for 24 hours from the time that they are added
        /// to a stream. You can use <a>IncreaseStreamRetentionPeriod</a> or <a>DecreaseStreamRetentionPeriod</a>
        /// to modify this retention period.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecords service method.</param>
        /// 
        /// <returns>The response from the PutRecords service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>Amazon Web Services Key
        /// Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSOptInRequiredException">
        /// The Amazon Web Services access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>Amazon Web Services Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ProvisionedThroughputExceededException">
        /// The request rate for the stream is too high, or the requested data is too large for
        /// the available throughput. Reduce the frequency or size of your requests. For more
        /// information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
        /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>, and <a href="https://docs.aws.amazon.com/general/latest/gr/api-retries.html">Error
        /// Retries and Exponential Backoff in Amazon Web Services</a> in the <i>Amazon Web Services
        /// General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/PutRecords">REST API Reference for PutRecords Operation</seealso>
        public virtual PutRecordsResponse PutRecords(PutRecordsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecordsResponseUnmarshaller.Instance;

            return Invoke<PutRecordsResponse>(request, options);
        }


        /// <summary>
        /// Writes multiple data records into a Kinesis data stream in a single call (also referred
        /// to as a <c>PutRecords</c> request). Use this operation to send data into the stream
        /// for data ingestion and processing. 
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// Each <c>PutRecords</c> request can support up to 500 records. Each record in the request
        /// can be as large as 1 MiB, up to a limit of 5 MiB for the entire request, including
        /// partition keys. Each shard can support writes up to 1,000 records per second, up to
        /// a maximum data write total of 1 MiB per second.
        /// </para>
        ///  
        /// <para>
        /// You must specify the name of the stream that captures, stores, and transports the
        /// data; and an array of request <c>Records</c>, with each record in the array requiring
        /// a partition key and data blob. The record size limit applies to the total size of
        /// the partition key and data blob.
        /// </para>
        ///  
        /// <para>
        /// The data blob can be any type of data; for example, a segment from a log file, geographic/location
        /// data, website clickstream data, and so on.
        /// </para>
        ///  
        /// <para>
        /// The partition key is used by Kinesis Data Streams as input to a hash function that
        /// maps the partition key and associated data to a specific shard. An MD5 hash function
        /// is used to map partition keys to 128-bit integer values and to map associated data
        /// records to shards. As a result of this hashing mechanism, all data records with the
        /// same partition key map to the same shard within the stream. For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/developing-producers-with-sdk.html#kinesis-using-sdk-java-add-data-to-stream">Adding
        /// Data to a Stream</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Each record in the <c>Records</c> array may include an optional parameter, <c>ExplicitHashKey</c>,
        /// which overrides the partition key to shard mapping. This parameter allows a data producer
        /// to determine explicitly the shard where the record is stored. For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/developing-producers-with-sdk.html#kinesis-using-sdk-java-putrecords">Adding
        /// Multiple Records with PutRecords</a> in the <i>Amazon Kinesis Data Streams Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The <c>PutRecords</c> response includes an array of response <c>Records</c>. Each
        /// record in the response array directly correlates with a record in the request array
        /// using natural ordering, from the top to the bottom of the request and response. The
        /// response <c>Records</c> array always includes the same number of records as the request
        /// array.
        /// </para>
        ///  
        /// <para>
        /// The response <c>Records</c> array includes both successfully and unsuccessfully processed
        /// records. Kinesis Data Streams attempts to process all records in each <c>PutRecords</c>
        /// request. A single record failure does not stop the processing of subsequent records.
        /// As a result, PutRecords doesn't guarantee the ordering of records. If you need to
        /// read records in the same order they are written to the stream, use <a>PutRecord</a>
        /// instead of <c>PutRecords</c>, and write to the same shard.
        /// </para>
        ///  
        /// <para>
        /// A successfully processed record includes <c>ShardId</c> and <c>SequenceNumber</c>
        /// values. The <c>ShardId</c> parameter identifies the shard in the stream where the
        /// record is stored. The <c>SequenceNumber</c> parameter is an identifier assigned to
        /// the put record, unique to all records in the stream.
        /// </para>
        ///  
        /// <para>
        /// An unsuccessfully processed record includes <c>ErrorCode</c> and <c>ErrorMessage</c>
        /// values. <c>ErrorCode</c> reflects the type of error and can be one of the following
        /// values: <c>ProvisionedThroughputExceededException</c> or <c>InternalFailure</c>. <c>ErrorMessage</c>
        /// provides more detailed information about the <c>ProvisionedThroughputExceededException</c>
        /// exception including the account ID, stream name, and shard ID of the record that was
        /// throttled. For more information about partially successful responses, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-sdk-java-add-data-to-stream.html#kinesis-using-sdk-java-putrecords">Adding
        /// Multiple Records with PutRecords</a> in the <i>Amazon Kinesis Data Streams Developer
        /// Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// After you write a record to a stream, you cannot modify that record or its order within
        /// the stream.
        /// </para>
        ///  </important> 
        /// <para>
        /// By default, data records are accessible for 24 hours from the time that they are added
        /// to a stream. You can use <a>IncreaseStreamRetentionPeriod</a> or <a>DecreaseStreamRetentionPeriod</a>
        /// to modify this retention period.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRecords service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>Amazon Web Services Key
        /// Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSOptInRequiredException">
        /// The Amazon Web Services access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>Amazon Web Services Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ProvisionedThroughputExceededException">
        /// The request rate for the stream is too high, or the requested data is too large for
        /// the available throughput. Reduce the frequency or size of your requests. For more
        /// information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
        /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>, and <a href="https://docs.aws.amazon.com/general/latest/gr/api-retries.html">Error
        /// Retries and Exponential Backoff in Amazon Web Services</a> in the <i>Amazon Web Services
        /// General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/PutRecords">REST API Reference for PutRecords Operation</seealso>
        public virtual Task<PutRecordsResponse> PutRecordsAsync(PutRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecordsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutRecordsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Attaches a resource-based policy to a data stream or registered consumer. If you are
        /// using an identity other than the root user of the Amazon Web Services account that
        /// owns the resource, the calling identity must have the <c>PutResourcePolicy</c> permissions
        /// on the specified Kinesis Data Streams resource and belong to the owner's account in
        /// order to use this operation. If you don't have <c>PutResourcePolicy</c> permissions,
        /// Amazon Kinesis Data Streams returns a <c>403 Access Denied error</c>. If you receive
        /// a <c>ResourceNotFoundException</c>, check to see if you passed a valid stream or consumer
        /// resource. 
        /// 
        ///  
        /// <para>
        ///  Request patterns can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Data stream pattern: <c>arn:aws.*:kinesis:.*:\d{12}:.*stream/\S+</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Consumer pattern: <c>^(arn):aws.*:kinesis:.*:\d{12}:.*stream\/[a-zA-Z0-9_.-]+\/consumer\/[a-zA-Z0-9_.-]+:[0-9]+</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/streams/latest/dev/controlling-access.html">Controlling
        /// Access to Amazon Kinesis Data Streams Resources Using IAM</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Attaches a resource-based policy to a data stream or registered consumer. If you are
        /// using an identity other than the root user of the Amazon Web Services account that
        /// owns the resource, the calling identity must have the <c>PutResourcePolicy</c> permissions
        /// on the specified Kinesis Data Streams resource and belong to the owner's account in
        /// order to use this operation. If you don't have <c>PutResourcePolicy</c> permissions,
        /// Amazon Kinesis Data Streams returns a <c>403 Access Denied error</c>. If you receive
        /// a <c>ResourceNotFoundException</c>, check to see if you passed a valid stream or consumer
        /// resource. 
        /// 
        ///  
        /// <para>
        ///  Request patterns can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Data stream pattern: <c>arn:aws.*:kinesis:.*:\d{12}:.*stream/\S+</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Consumer pattern: <c>^(arn):aws.*:kinesis:.*:\d{12}:.*stream\/[a-zA-Z0-9_.-]+\/consumer\/[a-zA-Z0-9_.-]+:[0-9]+</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/streams/latest/dev/controlling-access.html">Controlling
        /// Access to Amazon Kinesis Data Streams Resources Using IAM</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterStreamConsumer


        /// <summary>
        /// Registers a consumer with a Kinesis data stream. When you use this operation, the
        /// consumer you register can then call <a>SubscribeToShard</a> to receive data from the
        /// stream using enhanced fan-out, at a rate of up to 2 MiB per second for every shard
        /// you subscribe to. This rate is unaffected by the total number of consumers that read
        /// from the same stream.
        /// 
        ///  
        /// <para>
        /// You can register up to 20 consumers per stream. A given consumer can only be registered
        /// with one stream at a time.
        /// </para>
        ///  
        /// <para>
        /// For an example of how to use this operation, see <a href="https://docs.aws.amazon.com/streams/latest/dev/building-enhanced-consumers-api.html">Enhanced
        /// Fan-Out Using the Kinesis Data Streams API</a>.
        /// </para>
        ///  
        /// <para>
        /// The use of this operation has a limit of five transactions per second per account.
        /// Also, only 5 consumers can be created simultaneously. In other words, you cannot have
        /// more than 5 consumers in a <c>CREATING</c> status at the same time. Registering a
        /// 6th consumer while there are 5 in a <c>CREATING</c> status results in a <c>LimitExceededException</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterStreamConsumer service method.</param>
        /// 
        /// <returns>The response from the RegisterStreamConsumer service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/RegisterStreamConsumer">REST API Reference for RegisterStreamConsumer Operation</seealso>
        public virtual RegisterStreamConsumerResponse RegisterStreamConsumer(RegisterStreamConsumerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterStreamConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterStreamConsumerResponseUnmarshaller.Instance;

            return Invoke<RegisterStreamConsumerResponse>(request, options);
        }


        /// <summary>
        /// Registers a consumer with a Kinesis data stream. When you use this operation, the
        /// consumer you register can then call <a>SubscribeToShard</a> to receive data from the
        /// stream using enhanced fan-out, at a rate of up to 2 MiB per second for every shard
        /// you subscribe to. This rate is unaffected by the total number of consumers that read
        /// from the same stream.
        /// 
        ///  
        /// <para>
        /// You can register up to 20 consumers per stream. A given consumer can only be registered
        /// with one stream at a time.
        /// </para>
        ///  
        /// <para>
        /// For an example of how to use this operation, see <a href="https://docs.aws.amazon.com/streams/latest/dev/building-enhanced-consumers-api.html">Enhanced
        /// Fan-Out Using the Kinesis Data Streams API</a>.
        /// </para>
        ///  
        /// <para>
        /// The use of this operation has a limit of five transactions per second per account.
        /// Also, only 5 consumers can be created simultaneously. In other words, you cannot have
        /// more than 5 consumers in a <c>CREATING</c> status at the same time. Registering a
        /// 6th consumer while there are 5 in a <c>CREATING</c> status results in a <c>LimitExceededException</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterStreamConsumer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterStreamConsumer service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/RegisterStreamConsumer">REST API Reference for RegisterStreamConsumer Operation</seealso>
        public virtual Task<RegisterStreamConsumerResponse> RegisterStreamConsumerAsync(RegisterStreamConsumerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterStreamConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterStreamConsumerResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterStreamConsumerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromStream


        /// <summary>
        /// Removes tags from the specified Kinesis data stream. Removed tags are deleted and
        /// cannot be recovered after this operation successfully completes.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you specify a tag that does not exist, it is ignored.
        /// </para>
        ///  
        /// <para>
        ///  <a>RemoveTagsFromStream</a> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromStream service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/RemoveTagsFromStream">REST API Reference for RemoveTagsFromStream Operation</seealso>
        public virtual RemoveTagsFromStreamResponse RemoveTagsFromStream(RemoveTagsFromStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromStreamResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromStreamResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from the specified Kinesis data stream. Removed tags are deleted and
        /// cannot be recovered after this operation successfully completes.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you specify a tag that does not exist, it is ignored.
        /// </para>
        ///  
        /// <para>
        ///  <a>RemoveTagsFromStream</a> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTagsFromStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/RemoveTagsFromStream">REST API Reference for RemoveTagsFromStream Operation</seealso>
        public virtual Task<RemoveTagsFromStreamResponse> RemoveTagsFromStreamAsync(RemoveTagsFromStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<RemoveTagsFromStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SplitShard


        /// <summary>
        /// Splits a shard into two new shards in the Kinesis data stream, to increase the stream's
        /// capacity to ingest and transport data. <c>SplitShard</c> is called when there is a
        /// need to increase the overall capacity of a stream because of an expected increase
        /// in the volume of data records being ingested. This API is only supported for the data
        /// streams with the provisioned capacity mode.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can also use <c>SplitShard</c> when a shard appears to be approaching its maximum
        /// utilization; for example, the producers sending data into the specific shard are suddenly
        /// sending more than previously anticipated. You can also call <c>SplitShard</c> to increase
        /// stream capacity, so that more Kinesis Data Streams applications can simultaneously
        /// read data from the stream for real-time processing. 
        /// </para>
        ///  
        /// <para>
        /// You must specify the shard to be split and the new hash key, which is the position
        /// in the shard where the shard gets split in two. In many cases, the new hash key might
        /// be the average of the beginning and ending hash key, but it can be any hash key value
        /// in the range being mapped into the shard. For more information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-sdk-java-resharding-split.html">Split
        /// a Shard</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeStreamSummary</a> and the <a>ListShards</a> APIs to determine
        /// the shard ID and hash key values for the <c>ShardToSplit</c> and <c>NewStartingHashKey</c>
        /// parameters that are specified in the <c>SplitShard</c> request.
        /// </para>
        ///  
        /// <para>
        ///  <c>SplitShard</c> is an asynchronous operation. Upon receiving a <c>SplitShard</c>
        /// request, Kinesis Data Streams immediately returns a response and sets the stream status
        /// to <c>UPDATING</c>. After the operation is completed, Kinesis Data Streams sets the
        /// stream status to <c>ACTIVE</c>. Read and write operations continue to work while the
        /// stream is in the <c>UPDATING</c> state. 
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeStreamSummary</a> to check the status of the stream, which
        /// is returned in <c>StreamStatus</c>. If the stream is in the <c>ACTIVE</c> state, you
        /// can call <c>SplitShard</c>. 
        /// </para>
        ///  
        /// <para>
        /// If the specified stream does not exist, <a>DescribeStreamSummary</a> returns a <c>ResourceNotFoundException</c>.
        /// If you try to create more shards than are authorized for your account, you receive
        /// a <c>LimitExceededException</c>. 
        /// </para>
        ///  
        /// <para>
        /// For the default shard limit for an Amazon Web Services account, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Kinesis
        /// Data Streams Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// To increase this limit, <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">contact
        /// Amazon Web Services Support</a>.
        /// </para>
        ///  
        /// <para>
        /// If you try to operate on too many streams simultaneously using <a>CreateStream</a>,
        /// <a>DeleteStream</a>, <a>MergeShards</a>, and/or <a>SplitShard</a>, you receive a <c>LimitExceededException</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>SplitShard</c> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SplitShard service method.</param>
        /// 
        /// <returns>The response from the SplitShard service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ValidationException">
        /// Specifies that you tried to invoke this API for a data stream with the on-demand capacity
        /// mode. This API is only supported for data streams with the provisioned capacity mode.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/SplitShard">REST API Reference for SplitShard Operation</seealso>
        public virtual SplitShardResponse SplitShard(SplitShardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SplitShardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SplitShardResponseUnmarshaller.Instance;

            return Invoke<SplitShardResponse>(request, options);
        }


        /// <summary>
        /// Splits a shard into two new shards in the Kinesis data stream, to increase the stream's
        /// capacity to ingest and transport data. <c>SplitShard</c> is called when there is a
        /// need to increase the overall capacity of a stream because of an expected increase
        /// in the volume of data records being ingested. This API is only supported for the data
        /// streams with the provisioned capacity mode.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can also use <c>SplitShard</c> when a shard appears to be approaching its maximum
        /// utilization; for example, the producers sending data into the specific shard are suddenly
        /// sending more than previously anticipated. You can also call <c>SplitShard</c> to increase
        /// stream capacity, so that more Kinesis Data Streams applications can simultaneously
        /// read data from the stream for real-time processing. 
        /// </para>
        ///  
        /// <para>
        /// You must specify the shard to be split and the new hash key, which is the position
        /// in the shard where the shard gets split in two. In many cases, the new hash key might
        /// be the average of the beginning and ending hash key, but it can be any hash key value
        /// in the range being mapped into the shard. For more information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-sdk-java-resharding-split.html">Split
        /// a Shard</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeStreamSummary</a> and the <a>ListShards</a> APIs to determine
        /// the shard ID and hash key values for the <c>ShardToSplit</c> and <c>NewStartingHashKey</c>
        /// parameters that are specified in the <c>SplitShard</c> request.
        /// </para>
        ///  
        /// <para>
        ///  <c>SplitShard</c> is an asynchronous operation. Upon receiving a <c>SplitShard</c>
        /// request, Kinesis Data Streams immediately returns a response and sets the stream status
        /// to <c>UPDATING</c>. After the operation is completed, Kinesis Data Streams sets the
        /// stream status to <c>ACTIVE</c>. Read and write operations continue to work while the
        /// stream is in the <c>UPDATING</c> state. 
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeStreamSummary</a> to check the status of the stream, which
        /// is returned in <c>StreamStatus</c>. If the stream is in the <c>ACTIVE</c> state, you
        /// can call <c>SplitShard</c>. 
        /// </para>
        ///  
        /// <para>
        /// If the specified stream does not exist, <a>DescribeStreamSummary</a> returns a <c>ResourceNotFoundException</c>.
        /// If you try to create more shards than are authorized for your account, you receive
        /// a <c>LimitExceededException</c>. 
        /// </para>
        ///  
        /// <para>
        /// For the default shard limit for an Amazon Web Services account, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Kinesis
        /// Data Streams Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// To increase this limit, <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">contact
        /// Amazon Web Services Support</a>.
        /// </para>
        ///  
        /// <para>
        /// If you try to operate on too many streams simultaneously using <a>CreateStream</a>,
        /// <a>DeleteStream</a>, <a>MergeShards</a>, and/or <a>SplitShard</a>, you receive a <c>LimitExceededException</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>SplitShard</c> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SplitShard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SplitShard service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ValidationException">
        /// Specifies that you tried to invoke this API for a data stream with the on-demand capacity
        /// mode. This API is only supported for data streams with the provisioned capacity mode.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/SplitShard">REST API Reference for SplitShard Operation</seealso>
        public virtual Task<SplitShardResponse> SplitShardAsync(SplitShardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SplitShardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SplitShardResponseUnmarshaller.Instance;
            
            return InvokeAsync<SplitShardResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartStreamEncryption


        /// <summary>
        /// Enables or updates server-side encryption using an Amazon Web Services KMS key for
        /// a specified stream. 
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// Starting encryption is an asynchronous operation. Upon receiving the request, Kinesis
        /// Data Streams returns immediately and sets the status of the stream to <c>UPDATING</c>.
        /// After the update is complete, Kinesis Data Streams sets the status of the stream back
        /// to <c>ACTIVE</c>. Updating or applying encryption normally takes a few seconds to
        /// complete, but it can take minutes. You can continue to read and write data to your
        /// stream while its status is <c>UPDATING</c>. Once the status of the stream is <c>ACTIVE</c>,
        /// encryption begins for records written to the stream. 
        /// </para>
        ///  
        /// <para>
        /// API Limits: You can successfully apply a new Amazon Web Services KMS key for server-side
        /// encryption 25 times in a rolling 24-hour period.
        /// </para>
        ///  
        /// <para>
        /// Note: It can take up to 5 seconds after the stream is in an <c>ACTIVE</c> status before
        /// all records written to the stream are encrypted. After you enable encryption, you
        /// can verify that encryption is applied by inspecting the API response from <c>PutRecord</c>
        /// or <c>PutRecords</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartStreamEncryption service method.</param>
        /// 
        /// <returns>The response from the StartStreamEncryption service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>Amazon Web Services Key
        /// Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSOptInRequiredException">
        /// The Amazon Web Services access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>Amazon Web Services Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/StartStreamEncryption">REST API Reference for StartStreamEncryption Operation</seealso>
        public virtual StartStreamEncryptionResponse StartStreamEncryption(StartStreamEncryptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartStreamEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartStreamEncryptionResponseUnmarshaller.Instance;

            return Invoke<StartStreamEncryptionResponse>(request, options);
        }


        /// <summary>
        /// Enables or updates server-side encryption using an Amazon Web Services KMS key for
        /// a specified stream. 
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// Starting encryption is an asynchronous operation. Upon receiving the request, Kinesis
        /// Data Streams returns immediately and sets the status of the stream to <c>UPDATING</c>.
        /// After the update is complete, Kinesis Data Streams sets the status of the stream back
        /// to <c>ACTIVE</c>. Updating or applying encryption normally takes a few seconds to
        /// complete, but it can take minutes. You can continue to read and write data to your
        /// stream while its status is <c>UPDATING</c>. Once the status of the stream is <c>ACTIVE</c>,
        /// encryption begins for records written to the stream. 
        /// </para>
        ///  
        /// <para>
        /// API Limits: You can successfully apply a new Amazon Web Services KMS key for server-side
        /// encryption 25 times in a rolling 24-hour period.
        /// </para>
        ///  
        /// <para>
        /// Note: It can take up to 5 seconds after the stream is in an <c>ACTIVE</c> status before
        /// all records written to the stream are encrypted. After you enable encryption, you
        /// can verify that encryption is applied by inspecting the API response from <c>PutRecord</c>
        /// or <c>PutRecords</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartStreamEncryption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartStreamEncryption service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>Amazon Web Services Key
        /// Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSOptInRequiredException">
        /// The Amazon Web Services access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>Amazon Web Services Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/StartStreamEncryption">REST API Reference for StartStreamEncryption Operation</seealso>
        public virtual Task<StartStreamEncryptionResponse> StartStreamEncryptionAsync(StartStreamEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartStreamEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartStreamEncryptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartStreamEncryptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopStreamEncryption


        /// <summary>
        /// Disables server-side encryption for a specified stream. 
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// Stopping encryption is an asynchronous operation. Upon receiving the request, Kinesis
        /// Data Streams returns immediately and sets the status of the stream to <c>UPDATING</c>.
        /// After the update is complete, Kinesis Data Streams sets the status of the stream back
        /// to <c>ACTIVE</c>. Stopping encryption normally takes a few seconds to complete, but
        /// it can take minutes. You can continue to read and write data to your stream while
        /// its status is <c>UPDATING</c>. Once the status of the stream is <c>ACTIVE</c>, records
        /// written to the stream are no longer encrypted by Kinesis Data Streams. 
        /// </para>
        ///  
        /// <para>
        /// API Limits: You can successfully disable server-side encryption 25 times in a rolling
        /// 24-hour period. 
        /// </para>
        ///  
        /// <para>
        /// Note: It can take up to 5 seconds after the stream is in an <c>ACTIVE</c> status before
        /// all records written to the stream are no longer subject to encryption. After you disabled
        /// encryption, you can verify that encryption is not applied by inspecting the API response
        /// from <c>PutRecord</c> or <c>PutRecords</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopStreamEncryption service method.</param>
        /// 
        /// <returns>The response from the StopStreamEncryption service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/StopStreamEncryption">REST API Reference for StopStreamEncryption Operation</seealso>
        public virtual StopStreamEncryptionResponse StopStreamEncryption(StopStreamEncryptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopStreamEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStreamEncryptionResponseUnmarshaller.Instance;

            return Invoke<StopStreamEncryptionResponse>(request, options);
        }


        /// <summary>
        /// Disables server-side encryption for a specified stream. 
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// Stopping encryption is an asynchronous operation. Upon receiving the request, Kinesis
        /// Data Streams returns immediately and sets the status of the stream to <c>UPDATING</c>.
        /// After the update is complete, Kinesis Data Streams sets the status of the stream back
        /// to <c>ACTIVE</c>. Stopping encryption normally takes a few seconds to complete, but
        /// it can take minutes. You can continue to read and write data to your stream while
        /// its status is <c>UPDATING</c>. Once the status of the stream is <c>ACTIVE</c>, records
        /// written to the stream are no longer encrypted by Kinesis Data Streams. 
        /// </para>
        ///  
        /// <para>
        /// API Limits: You can successfully disable server-side encryption 25 times in a rolling
        /// 24-hour period. 
        /// </para>
        ///  
        /// <para>
        /// Note: It can take up to 5 seconds after the stream is in an <c>ACTIVE</c> status before
        /// all records written to the stream are no longer subject to encryption. After you disabled
        /// encryption, you can verify that encryption is not applied by inspecting the API response
        /// from <c>PutRecord</c> or <c>PutRecords</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopStreamEncryption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopStreamEncryption service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/StopStreamEncryption">REST API Reference for StopStreamEncryption Operation</seealso>
        public virtual Task<StopStreamEncryptionResponse> StopStreamEncryptionAsync(StopStreamEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopStreamEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStreamEncryptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopStreamEncryptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateShardCount


        /// <summary>
        /// Updates the shard count of the specified stream to the specified number of shards.
        /// This API is only supported for the data streams with the provisioned capacity mode.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// Updating the shard count is an asynchronous operation. Upon receiving the request,
        /// Kinesis Data Streams returns immediately and sets the status of the stream to <c>UPDATING</c>.
        /// After the update is complete, Kinesis Data Streams sets the status of the stream back
        /// to <c>ACTIVE</c>. Depending on the size of the stream, the scaling action could take
        /// a few minutes to complete. You can continue to read and write data to your stream
        /// while its status is <c>UPDATING</c>.
        /// </para>
        ///  
        /// <para>
        /// To update the shard count, Kinesis Data Streams performs splits or merges on individual
        /// shards. This can cause short-lived shards to be created, in addition to the final
        /// shards. These short-lived shards count towards your total shard limit for your account
        /// in the Region.
        /// </para>
        ///  
        /// <para>
        /// When using this operation, we recommend that you specify a target shard count that
        /// is a multiple of 25% (25%, 50%, 75%, 100%). You can specify any target value within
        /// your shard limit. However, if you specify a target that isn't a multiple of 25%, the
        /// scaling action might take longer to complete. 
        /// </para>
        ///  
        /// <para>
        /// This operation has the following default limits. By default, you cannot do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Scale more than ten times per rolling 24-hour period per stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scale up to more than double your current shard count for a stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scale down below half your current shard count for a stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scale up to more than 10000 shards in a stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scale a stream with more than 10000 shards down unless the result is less than 10000
        /// shards
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scale up to more than the shard limit for your account
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Make over 10 TPS. TPS over 10 will trigger the LimitExceededException
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the default limits for an Amazon Web Services account, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
        /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>. To request an
        /// increase in the call rate limit, the shard limit for this API, or your overall shard
        /// limit, use the <a href="https://console.aws.amazon.com/support/v1#/case/create?issueType=service-limit-increase&amp;limitType=service-code-kinesis">limits
        /// form</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateShardCount service method.</param>
        /// 
        /// <returns>The response from the UpdateShardCount service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ValidationException">
        /// Specifies that you tried to invoke this API for a data stream with the on-demand capacity
        /// mode. This API is only supported for data streams with the provisioned capacity mode.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/UpdateShardCount">REST API Reference for UpdateShardCount Operation</seealso>
        public virtual UpdateShardCountResponse UpdateShardCount(UpdateShardCountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateShardCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateShardCountResponseUnmarshaller.Instance;

            return Invoke<UpdateShardCountResponse>(request, options);
        }


        /// <summary>
        /// Updates the shard count of the specified stream to the specified number of shards.
        /// This API is only supported for the data streams with the provisioned capacity mode.
        /// 
        ///  <note> 
        /// <para>
        /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
        /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
        /// when you invoke this API.
        /// </para>
        ///  </note> 
        /// <para>
        /// Updating the shard count is an asynchronous operation. Upon receiving the request,
        /// Kinesis Data Streams returns immediately and sets the status of the stream to <c>UPDATING</c>.
        /// After the update is complete, Kinesis Data Streams sets the status of the stream back
        /// to <c>ACTIVE</c>. Depending on the size of the stream, the scaling action could take
        /// a few minutes to complete. You can continue to read and write data to your stream
        /// while its status is <c>UPDATING</c>.
        /// </para>
        ///  
        /// <para>
        /// To update the shard count, Kinesis Data Streams performs splits or merges on individual
        /// shards. This can cause short-lived shards to be created, in addition to the final
        /// shards. These short-lived shards count towards your total shard limit for your account
        /// in the Region.
        /// </para>
        ///  
        /// <para>
        /// When using this operation, we recommend that you specify a target shard count that
        /// is a multiple of 25% (25%, 50%, 75%, 100%). You can specify any target value within
        /// your shard limit. However, if you specify a target that isn't a multiple of 25%, the
        /// scaling action might take longer to complete. 
        /// </para>
        ///  
        /// <para>
        /// This operation has the following default limits. By default, you cannot do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Scale more than ten times per rolling 24-hour period per stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scale up to more than double your current shard count for a stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scale down below half your current shard count for a stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scale up to more than 10000 shards in a stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scale a stream with more than 10000 shards down unless the result is less than 10000
        /// shards
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scale up to more than the shard limit for your account
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Make over 10 TPS. TPS over 10 will trigger the LimitExceededException
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the default limits for an Amazon Web Services account, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
        /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>. To request an
        /// increase in the call rate limit, the shard limit for this API, or your overall shard
        /// limit, use the <a href="https://console.aws.amazon.com/support/v1#/case/create?issueType=service-limit-increase&amp;limitType=service-code-kinesis">limits
        /// form</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateShardCount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateShardCount service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.AccessDeniedException">
        /// Specifies that you do not have the permissions required to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ValidationException">
        /// Specifies that you tried to invoke this API for a data stream with the on-demand capacity
        /// mode. This API is only supported for data streams with the provisioned capacity mode.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/UpdateShardCount">REST API Reference for UpdateShardCount Operation</seealso>
        public virtual Task<UpdateShardCountResponse> UpdateShardCountAsync(UpdateShardCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateShardCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateShardCountResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateShardCountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStreamMode


        /// <summary>
        /// Updates the capacity mode of the data stream. Currently, in Kinesis Data Streams,
        /// you can choose between an <b>on-demand</b> capacity mode and a <b>provisioned</b>
        /// capacity mode for your data stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamMode service method.</param>
        /// 
        /// <returns>The response from the UpdateStreamMode service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/UpdateStreamMode">REST API Reference for UpdateStreamMode Operation</seealso>
        public virtual UpdateStreamModeResponse UpdateStreamMode(UpdateStreamModeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStreamModeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStreamModeResponseUnmarshaller.Instance;

            return Invoke<UpdateStreamModeResponse>(request, options);
        }


        /// <summary>
        /// Updates the capacity mode of the data stream. Currently, in Kinesis Data Streams,
        /// you can choose between an <b>on-demand</b> capacity mode and a <b>provisioned</b>
        /// capacity mode for your data stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamMode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStreamMode service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <c>ACTIVE</c> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/UpdateStreamMode">REST API Reference for UpdateStreamMode Operation</seealso>
        public virtual Task<UpdateStreamModeResponse> UpdateStreamModeAsync(UpdateStreamModeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStreamModeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStreamModeResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateStreamModeResponse>(request, options, cancellationToken);
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