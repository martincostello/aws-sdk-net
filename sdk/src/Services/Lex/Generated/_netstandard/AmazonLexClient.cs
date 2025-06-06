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
 * Do not modify this file. This file is generated from the runtime.lex-2016-11-28.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Lex.Model;
using Amazon.Lex.Model.Internal.MarshallTransformations;
using Amazon.Lex.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Lex
{
    /// <summary>
    /// <para>Implementation for accessing Lex</para>
    ///
    /// Amazon Lex provides both build and runtime endpoints. Each endpoint provides a set
    /// of operations (API). Your conversational bot uses the runtime API to understand user
    /// utterances (user input text or voice). For example, suppose a user says "I want pizza",
    /// your bot sends this input to Amazon Lex using the runtime API. Amazon Lex recognizes
    /// that the user request is for the OrderPizza intent (one of the intents defined in
    /// the bot). Then Amazon Lex engages in user conversation on behalf of the bot to elicit
    /// required information (slot values, such as pizza size and crust type), and then performs
    /// fulfillment activity (that you configured when you created the bot). You use the build-time
    /// API to create and manage your Amazon Lex bot. For a list of build-time operations,
    /// see the build-time API, .
    /// </summary>
    public partial class AmazonLexClient : AmazonServiceClient, IAmazonLex
    {
        private static IServiceMetadata serviceMetadata = new AmazonLexMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonLexClient with the credentials loaded from the application's
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
        public AmazonLexClient()
            : base(new AmazonLexConfig()) { }

        /// <summary>
        /// Constructs AmazonLexClient with the credentials loaded from the application's
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
        public AmazonLexClient(RegionEndpoint region)
            : base(new AmazonLexConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLexClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLexClient Configuration Object</param>
        public AmazonLexClient(AmazonLexConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonLexClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLexClient(AWSCredentials credentials)
            : this(credentials, new AmazonLexConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLexClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLexClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLexConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLexClient with AWS Credentials and an
        /// AmazonLexClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLexClient Configuration Object</param>
        public AmazonLexClient(AWSCredentials credentials, AmazonLexConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLexClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLexClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLexConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLexClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLexClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLexConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLexClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLexClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLexClient Configuration Object</param>
        public AmazonLexClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLexConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLexClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLexClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLexConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLexClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLexClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLexConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLexClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLexClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLexClient Configuration Object</param>
        public AmazonLexClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLexConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLexEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLexAuthSchemeHandler());
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


        #region  DeleteSession

        internal virtual DeleteSessionResponse DeleteSession(DeleteSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSessionResponseUnmarshaller.Instance;

            return Invoke<DeleteSessionResponse>(request, options);
        }



        /// <summary>
        /// Removes session information for a specified bot, alias, and user ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSession service method, as returned by Lex.</returns>
        /// <exception cref="Amazon.Lex.Model.BadRequestException">
        /// Request validation failed, there is no usable message in the context, or the bot
        /// build failed, is still in progress, or contains unbuilt changes.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.ConflictException">
        /// Two clients are using the same AWS account, Amazon Lex bot, and user ID.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.InternalFailureException">
        /// Internal service error. Retry the call.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.LimitExceededException">
        /// Exceeded a limit.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.NotFoundException">
        /// The resource (such as the Amazon Lex bot or an alias) that is referred to is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex-2016-11-28/DeleteSession">REST API Reference for DeleteSession Operation</seealso>
        public virtual Task<DeleteSessionResponse> DeleteSessionAsync(DeleteSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSessionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSession

        internal virtual GetSessionResponse GetSession(GetSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return Invoke<GetSessionResponse>(request, options);
        }



        /// <summary>
        /// Returns session information for a specified bot, alias, and user ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by Lex.</returns>
        /// <exception cref="Amazon.Lex.Model.BadRequestException">
        /// Request validation failed, there is no usable message in the context, or the bot
        /// build failed, is still in progress, or contains unbuilt changes.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.InternalFailureException">
        /// Internal service error. Retry the call.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.LimitExceededException">
        /// Exceeded a limit.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.NotFoundException">
        /// The resource (such as the Amazon Lex bot or an alias) that is referred to is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex-2016-11-28/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual Task<GetSessionResponse> GetSessionAsync(GetSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PostContent

        internal virtual PostContentResponse PostContent(PostContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PostContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostContentResponseUnmarshaller.Instance;

            return Invoke<PostContentResponse>(request, options);
        }



        /// <summary>
        /// Sends user input (text or speech) to Amazon Lex. Clients use this API to send text
        /// and audio requests to Amazon Lex at runtime. Amazon Lex interprets the user input
        /// using the machine learning model that it built for the bot. 
        /// 
        ///  
        /// <para>
        /// The <c>PostContent</c> operation supports audio input at 8kHz and 16kHz. You can use
        /// 8kHz audio to achieve higher speech recognition accuracy in telephone audio applications.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  In response, Amazon Lex returns the next message to convey to the user. Consider
        /// the following example messages: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For a user input "I would like a pizza," Amazon Lex might return a response with
        /// a message eliciting slot data (for example, <c>PizzaSize</c>): "What size pizza would
        /// you like?". 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  After the user provides all of the pizza order information, Amazon Lex might return
        /// a response with a message to get user confirmation: "Order the pizza?". 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  After the user replies "Yes" to the confirmation prompt, Amazon Lex might return
        /// a conclusion statement: "Thank you, your cheese pizza has been ordered.". 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Not all Amazon Lex messages require a response from the user. For example, conclusion
        /// statements do not require a response. Some messages require only a yes or no response.
        /// In addition to the <c>message</c>, Amazon Lex provides additional context about the
        /// message in the response that you can use to enhance client behavior, such as displaying
        /// the appropriate client user interface. Consider the following examples: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If the message is to elicit slot data, Amazon Lex returns the following context information:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>x-amz-lex-dialog-state</c> header set to <c>ElicitSlot</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-lex-intent-name</c> header set to the intent name in the current context
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-lex-slot-to-elicit</c> header set to the slot name for which the <c>message</c>
        /// is eliciting information 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-lex-slots</c> header set to a map of slots configured for the intent with
        /// their current values 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  If the message is a confirmation prompt, the <c>x-amz-lex-dialog-state</c> header
        /// is set to <c>Confirmation</c> and the <c>x-amz-lex-slot-to-elicit</c> header is omitted.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If the message is a clarification prompt configured for the intent, indicating that
        /// the user intent is not understood, the <c>x-amz-dialog-state</c> header is set to
        /// <c>ElicitIntent</c> and the <c>x-amz-slot-to-elicit</c> header is omitted. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  In addition, Amazon Lex also returns your application-specific <c>sessionAttributes</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html">Managing
        /// Conversation Context</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PostContent service method, as returned by Lex.</returns>
        /// <exception cref="Amazon.Lex.Model.BadGatewayException">
        /// Either the Amazon Lex bot is still building, or one of the dependent services (Amazon
        /// Polly, AWS Lambda) failed with an internal service error.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.BadRequestException">
        /// Request validation failed, there is no usable message in the context, or the bot
        /// build failed, is still in progress, or contains unbuilt changes.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.ConflictException">
        /// Two clients are using the same AWS account, Amazon Lex bot, and user ID.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.DependencyFailedException">
        /// One of the dependencies, such as AWS Lambda or Amazon Polly, threw an exception.
        /// For example, 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If Amazon Lex does not have sufficient permissions to call a Lambda function.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a Lambda function takes longer than 30 seconds to execute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a fulfillment Lambda function returns a <c>Delegate</c> dialog action without removing
        /// any slot values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.InternalFailureException">
        /// Internal service error. Retry the call.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.LimitExceededException">
        /// Exceeded a limit.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.LoopDetectedException">
        /// This exception is not used.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.NotAcceptableException">
        /// The accept header in the request does not have a valid value.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.NotFoundException">
        /// The resource (such as the Amazon Lex bot or an alias) that is referred to is not found.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.RequestTimeoutException">
        /// The input speech is too long.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.UnsupportedMediaTypeException">
        /// The Content-Type header (<c>PostContent</c> API) has an invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex-2016-11-28/PostContent">REST API Reference for PostContent Operation</seealso>
        public virtual Task<PostContentResponse> PostContentAsync(PostContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PostContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostContentResponseUnmarshaller.Instance;

            return InvokeAsync<PostContentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PostText

        internal virtual PostTextResponse PostText(PostTextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PostTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostTextResponseUnmarshaller.Instance;

            return Invoke<PostTextResponse>(request, options);
        }



        /// <summary>
        /// Sends user input to Amazon Lex. Client applications can use this API to send requests
        /// to Amazon Lex at runtime. Amazon Lex then interprets the user input using the machine
        /// learning model it built for the bot. 
        /// 
        ///  
        /// <para>
        ///  In response, Amazon Lex returns the next <c>message</c> to convey to the user an
        /// optional <c>responseCard</c> to display. Consider the following example messages:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For a user input "I would like a pizza", Amazon Lex might return a response with
        /// a message eliciting slot data (for example, PizzaSize): "What size pizza would you
        /// like?" 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  After the user provides all of the pizza order information, Amazon Lex might return
        /// a response with a message to obtain user confirmation "Proceed with the pizza order?".
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  After the user replies to a confirmation prompt with a "yes", Amazon Lex might return
        /// a conclusion statement: "Thank you, your cheese pizza has been ordered.". 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Not all Amazon Lex messages require a user response. For example, a conclusion statement
        /// does not require a response. Some messages require only a "yes" or "no" user response.
        /// In addition to the <c>message</c>, Amazon Lex provides additional context about the
        /// message in the response that you might use to enhance client behavior, for example,
        /// to display the appropriate client user interface. These are the <c>slotToElicit</c>,
        /// <c>dialogState</c>, <c>intentName</c>, and <c>slots</c> fields in the response. Consider
        /// the following examples: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the message is to elicit slot data, Amazon Lex returns the following context information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>dialogState</c> set to ElicitSlot 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>intentName</c> set to the intent name in the current context 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>slotToElicit</c> set to the slot name for which the <c>message</c> is eliciting
        /// information 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>slots</c> set to a map of slots, configured for the intent, with currently known
        /// values 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  If the message is a confirmation prompt, the <c>dialogState</c> is set to ConfirmIntent
        /// and <c>SlotToElicit</c> is set to null. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the message is a clarification prompt (configured for the intent) that indicates
        /// that user intent is not understood, the <c>dialogState</c> is set to ElicitIntent
        /// and <c>slotToElicit</c> is set to null. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  In addition, Amazon Lex also returns your application-specific <c>sessionAttributes</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html">Managing
        /// Conversation Context</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostText service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PostText service method, as returned by Lex.</returns>
        /// <exception cref="Amazon.Lex.Model.BadGatewayException">
        /// Either the Amazon Lex bot is still building, or one of the dependent services (Amazon
        /// Polly, AWS Lambda) failed with an internal service error.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.BadRequestException">
        /// Request validation failed, there is no usable message in the context, or the bot
        /// build failed, is still in progress, or contains unbuilt changes.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.ConflictException">
        /// Two clients are using the same AWS account, Amazon Lex bot, and user ID.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.DependencyFailedException">
        /// One of the dependencies, such as AWS Lambda or Amazon Polly, threw an exception.
        /// For example, 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If Amazon Lex does not have sufficient permissions to call a Lambda function.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a Lambda function takes longer than 30 seconds to execute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a fulfillment Lambda function returns a <c>Delegate</c> dialog action without removing
        /// any slot values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.InternalFailureException">
        /// Internal service error. Retry the call.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.LimitExceededException">
        /// Exceeded a limit.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.LoopDetectedException">
        /// This exception is not used.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.NotFoundException">
        /// The resource (such as the Amazon Lex bot or an alias) that is referred to is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex-2016-11-28/PostText">REST API Reference for PostText Operation</seealso>
        public virtual Task<PostTextResponse> PostTextAsync(PostTextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PostTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostTextResponseUnmarshaller.Instance;

            return InvokeAsync<PostTextResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutSession

        internal virtual PutSessionResponse PutSession(PutSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSessionResponseUnmarshaller.Instance;

            return Invoke<PutSessionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new session or modifies an existing session with an Amazon Lex bot. Use
        /// this operation to enable your application to set the state of the bot.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/how-session-api.html">Managing
        /// Sessions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSession service method, as returned by Lex.</returns>
        /// <exception cref="Amazon.Lex.Model.BadGatewayException">
        /// Either the Amazon Lex bot is still building, or one of the dependent services (Amazon
        /// Polly, AWS Lambda) failed with an internal service error.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.BadRequestException">
        /// Request validation failed, there is no usable message in the context, or the bot
        /// build failed, is still in progress, or contains unbuilt changes.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.ConflictException">
        /// Two clients are using the same AWS account, Amazon Lex bot, and user ID.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.DependencyFailedException">
        /// One of the dependencies, such as AWS Lambda or Amazon Polly, threw an exception.
        /// For example, 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If Amazon Lex does not have sufficient permissions to call a Lambda function.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a Lambda function takes longer than 30 seconds to execute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a fulfillment Lambda function returns a <c>Delegate</c> dialog action without removing
        /// any slot values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.InternalFailureException">
        /// Internal service error. Retry the call.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.LimitExceededException">
        /// Exceeded a limit.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.NotAcceptableException">
        /// The accept header in the request does not have a valid value.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.NotFoundException">
        /// The resource (such as the Amazon Lex bot or an alias) that is referred to is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex-2016-11-28/PutSession">REST API Reference for PutSession Operation</seealso>
        public virtual Task<PutSessionResponse> PutSessionAsync(PutSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSessionResponseUnmarshaller.Instance;

            return InvokeAsync<PutSessionResponse>(request, options, cancellationToken);
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