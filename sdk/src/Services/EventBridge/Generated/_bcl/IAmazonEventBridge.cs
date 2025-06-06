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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.EventBridge.Model;

#pragma warning disable CS1570
namespace Amazon.EventBridge
{
    /// <summary>
    /// <para>Interface for accessing EventBridge</para>
    ///
    /// Amazon EventBridge helps you to respond to state changes in your Amazon Web Services
    /// resources. When your resources change state, they automatically send events to an
    /// event stream. You can create rules that match selected events in the stream and route
    /// them to targets to take action. You can also use rules to take action on a predetermined
    /// schedule. For example, you can configure rules to:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Automatically invoke an Lambda function to update DNS entries when an event notifies
    /// you that Amazon EC2 instance enters the running state.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Direct specific API records from CloudTrail to an Amazon Kinesis data stream for detailed
    /// analysis of potential security or availability risks.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Periodically invoke a built-in target to create a snapshot of an Amazon EBS volume.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about the features of Amazon EventBridge, see the <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide">Amazon
    /// EventBridge User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonEventBridge : IAmazonService, IDisposable
    {


        
        #region  ActivateEventSource


        /// <summary>
        /// Activates a partner event source that has been deactivated. Once activated, your matching
        /// event bus will start receiving events from the event source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateEventSource service method.</param>
        /// 
        /// <returns>The response from the ActivateEventSource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidStateException">
        /// The specified state is not a valid state for an event source.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ActivateEventSource">REST API Reference for ActivateEventSource Operation</seealso>
        ActivateEventSourceResponse ActivateEventSource(ActivateEventSourceRequest request);



        /// <summary>
        /// Activates a partner event source that has been deactivated. Once activated, your matching
        /// event bus will start receiving events from the event source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateEventSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateEventSource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidStateException">
        /// The specified state is not a valid state for an event source.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ActivateEventSource">REST API Reference for ActivateEventSource Operation</seealso>
        Task<ActivateEventSourceResponse> ActivateEventSourceAsync(ActivateEventSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelReplay


        /// <summary>
        /// Cancels the specified replay.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelReplay service method.</param>
        /// 
        /// <returns>The response from the CancelReplay service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.IllegalStatusException">
        /// An error occurred because a replay can be canceled only when the state is Running
        /// or Starting.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CancelReplay">REST API Reference for CancelReplay Operation</seealso>
        CancelReplayResponse CancelReplay(CancelReplayRequest request);



        /// <summary>
        /// Cancels the specified replay.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelReplay service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelReplay service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.IllegalStatusException">
        /// An error occurred because a replay can be canceled only when the state is Running
        /// or Starting.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CancelReplay">REST API Reference for CancelReplay Operation</seealso>
        Task<CancelReplayResponse> CancelReplayAsync(CancelReplayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateApiDestination


        /// <summary>
        /// Creates an API destination, which is an HTTP invocation endpoint configured as a target
        /// for events.
        /// 
        ///  
        /// <para>
        /// API destinations do not support private destinations, such as interface VPC endpoints.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-api-destinations.html">API
        /// destinations</a> in the <i>EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiDestination service method.</param>
        /// 
        /// <returns>The response from the CreateApiDestination service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateApiDestination">REST API Reference for CreateApiDestination Operation</seealso>
        CreateApiDestinationResponse CreateApiDestination(CreateApiDestinationRequest request);



        /// <summary>
        /// Creates an API destination, which is an HTTP invocation endpoint configured as a target
        /// for events.
        /// 
        ///  
        /// <para>
        /// API destinations do not support private destinations, such as interface VPC endpoints.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-api-destinations.html">API
        /// destinations</a> in the <i>EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApiDestination service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateApiDestination">REST API Reference for CreateApiDestination Operation</seealso>
        Task<CreateApiDestinationResponse> CreateApiDestinationAsync(CreateApiDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateArchive


        /// <summary>
        /// Creates an archive of events with the specified settings. When you create an archive,
        /// incoming events might not immediately start being sent to the archive. Allow a short
        /// period of time for changes to take effect. If you do not specify a pattern to filter
        /// events sent to the archive, all events are sent to the archive except replayed events.
        /// Replayed events are not sent to an archive.
        /// 
        ///  <important> 
        /// <para>
        /// If you have specified that EventBridge use a customer managed key for encrypting the
        /// source event bus, we strongly recommend you also specify a customer managed key for
        /// any archives for the event bus as well. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/encryption-archives.html">Encrypting
        /// archives</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateArchive service method.</param>
        /// 
        /// <returns>The response from the CreateArchive service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateArchive">REST API Reference for CreateArchive Operation</seealso>
        CreateArchiveResponse CreateArchive(CreateArchiveRequest request);



        /// <summary>
        /// Creates an archive of events with the specified settings. When you create an archive,
        /// incoming events might not immediately start being sent to the archive. Allow a short
        /// period of time for changes to take effect. If you do not specify a pattern to filter
        /// events sent to the archive, all events are sent to the archive except replayed events.
        /// Replayed events are not sent to an archive.
        /// 
        ///  <important> 
        /// <para>
        /// If you have specified that EventBridge use a customer managed key for encrypting the
        /// source event bus, we strongly recommend you also specify a customer managed key for
        /// any archives for the event bus as well. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/encryption-archives.html">Encrypting
        /// archives</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateArchive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateArchive service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateArchive">REST API Reference for CreateArchive Operation</seealso>
        Task<CreateArchiveResponse> CreateArchiveAsync(CreateArchiveRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateConnection


        /// <summary>
        /// Creates a connection. A connection defines the authorization type and credentials
        /// to use for authorization with an API destination HTTP endpoint.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-target-connection.html">Connections
        /// for endpoint targets</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.AccessDeniedException">
        /// You do not have the necessary permissions for this action.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ThrottlingException">
        /// This request cannot be completed due to throttling issues.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        CreateConnectionResponse CreateConnection(CreateConnectionRequest request);



        /// <summary>
        /// Creates a connection. A connection defines the authorization type and credentials
        /// to use for authorization with an API destination HTTP endpoint.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-target-connection.html">Connections
        /// for endpoint targets</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.AccessDeniedException">
        /// You do not have the necessary permissions for this action.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ThrottlingException">
        /// This request cannot be completed due to throttling issues.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEndpoint


        /// <summary>
        /// Creates a global endpoint. Global endpoints improve your application's availability
        /// by making it regional-fault tolerant. To do this, you define a primary and secondary
        /// Region with event buses in each Region. You also create a Amazon Route 53 health check
        /// that will tell EventBridge to route events to the secondary Region when an "unhealthy"
        /// state is encountered and events will be routed back to the primary Region when the
        /// health check reports a "healthy" state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateEndpoint service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request);



        /// <summary>
        /// Creates a global endpoint. Global endpoints improve your application's availability
        /// by making it regional-fault tolerant. To do this, you define a primary and secondary
        /// Region with event buses in each Region. You also create a Amazon Route 53 health check
        /// that will tell EventBridge to route events to the secondary Region when an "unhealthy"
        /// state is encountered and events will be routed back to the primary Region when the
        /// health check reports a "healthy" state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEndpoint service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEventBus


        /// <summary>
        /// Creates a new event bus within your account. This can be a custom event bus which
        /// you can use to receive events from your custom applications and services, or it can
        /// be a partner event bus which can be matched to a partner event source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventBus service method.</param>
        /// 
        /// <returns>The response from the CreateEventBus service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidStateException">
        /// The specified state is not a valid state for an event source.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateEventBus">REST API Reference for CreateEventBus Operation</seealso>
        CreateEventBusResponse CreateEventBus(CreateEventBusRequest request);



        /// <summary>
        /// Creates a new event bus within your account. This can be a custom event bus which
        /// you can use to receive events from your custom applications and services, or it can
        /// be a partner event bus which can be matched to a partner event source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventBus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventBus service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidStateException">
        /// The specified state is not a valid state for an event source.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreateEventBus">REST API Reference for CreateEventBus Operation</seealso>
        Task<CreateEventBusResponse> CreateEventBusAsync(CreateEventBusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePartnerEventSource


        /// <summary>
        /// Called by an SaaS partner to create a partner event source. This operation is not
        /// used by Amazon Web Services customers.
        /// 
        ///  
        /// <para>
        /// Each partner event source can be used by one Amazon Web Services account to create
        /// a matching partner event bus in that Amazon Web Services account. A SaaS partner must
        /// create one partner event source for each Amazon Web Services account that wants to
        /// receive those event types. 
        /// </para>
        ///  
        /// <para>
        /// A partner event source creates events based on resources within the SaaS partner's
        /// service or application.
        /// </para>
        ///  
        /// <para>
        /// An Amazon Web Services account that creates a partner event bus that matches the partner
        /// event source can use that event bus to receive events from the partner, and then process
        /// them using Amazon Web Services Events rules and targets.
        /// </para>
        ///  
        /// <para>
        /// Partner event source names follow this format:
        /// </para>
        ///  
        /// <para>
        ///  <c> <i>partner_name</i>/<i>event_namespace</i>/<i>event_name</i> </c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>partner_name</i> is determined during partner registration, and identifies the
        /// partner to Amazon Web Services customers. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>event_namespace</i> is determined by the partner, and is a way for the partner
        /// to categorize their events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>event_name</i> is determined by the partner, and should uniquely identify an event-generating
        /// resource within the partner system. 
        /// </para>
        ///  
        /// <para>
        /// The <i>event_name</i> must be unique across all Amazon Web Services customers. This
        /// is because the event source is a shared resource between the partner and customer
        /// accounts, and each partner event source unique in the partner account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The combination of <i>event_namespace</i> and <i>event_name</i> should help Amazon
        /// Web Services customers decide whether to create an event bus to receive these events.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartnerEventSource service method.</param>
        /// 
        /// <returns>The response from the CreatePartnerEventSource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreatePartnerEventSource">REST API Reference for CreatePartnerEventSource Operation</seealso>
        CreatePartnerEventSourceResponse CreatePartnerEventSource(CreatePartnerEventSourceRequest request);



        /// <summary>
        /// Called by an SaaS partner to create a partner event source. This operation is not
        /// used by Amazon Web Services customers.
        /// 
        ///  
        /// <para>
        /// Each partner event source can be used by one Amazon Web Services account to create
        /// a matching partner event bus in that Amazon Web Services account. A SaaS partner must
        /// create one partner event source for each Amazon Web Services account that wants to
        /// receive those event types. 
        /// </para>
        ///  
        /// <para>
        /// A partner event source creates events based on resources within the SaaS partner's
        /// service or application.
        /// </para>
        ///  
        /// <para>
        /// An Amazon Web Services account that creates a partner event bus that matches the partner
        /// event source can use that event bus to receive events from the partner, and then process
        /// them using Amazon Web Services Events rules and targets.
        /// </para>
        ///  
        /// <para>
        /// Partner event source names follow this format:
        /// </para>
        ///  
        /// <para>
        ///  <c> <i>partner_name</i>/<i>event_namespace</i>/<i>event_name</i> </c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>partner_name</i> is determined during partner registration, and identifies the
        /// partner to Amazon Web Services customers. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>event_namespace</i> is determined by the partner, and is a way for the partner
        /// to categorize their events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>event_name</i> is determined by the partner, and should uniquely identify an event-generating
        /// resource within the partner system. 
        /// </para>
        ///  
        /// <para>
        /// The <i>event_name</i> must be unique across all Amazon Web Services customers. This
        /// is because the event source is a shared resource between the partner and customer
        /// accounts, and each partner event source unique in the partner account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The combination of <i>event_namespace</i> and <i>event_name</i> should help Amazon
        /// Web Services customers decide whether to create an event bus to receive these events.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartnerEventSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePartnerEventSource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/CreatePartnerEventSource">REST API Reference for CreatePartnerEventSource Operation</seealso>
        Task<CreatePartnerEventSourceResponse> CreatePartnerEventSourceAsync(CreatePartnerEventSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeactivateEventSource


        /// <summary>
        /// You can use this operation to temporarily stop receiving events from the specified
        /// partner event source. The matching event bus is not deleted. 
        /// 
        ///  
        /// <para>
        /// When you deactivate a partner event source, the source goes into PENDING state. If
        /// it remains in PENDING state for more than two weeks, it is deleted.
        /// </para>
        ///  
        /// <para>
        /// To activate a deactivated partner event source, use <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_ActivateEventSource.html">ActivateEventSource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateEventSource service method.</param>
        /// 
        /// <returns>The response from the DeactivateEventSource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidStateException">
        /// The specified state is not a valid state for an event source.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeactivateEventSource">REST API Reference for DeactivateEventSource Operation</seealso>
        DeactivateEventSourceResponse DeactivateEventSource(DeactivateEventSourceRequest request);



        /// <summary>
        /// You can use this operation to temporarily stop receiving events from the specified
        /// partner event source. The matching event bus is not deleted. 
        /// 
        ///  
        /// <para>
        /// When you deactivate a partner event source, the source goes into PENDING state. If
        /// it remains in PENDING state for more than two weeks, it is deleted.
        /// </para>
        ///  
        /// <para>
        /// To activate a deactivated partner event source, use <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_ActivateEventSource.html">ActivateEventSource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateEventSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeactivateEventSource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidStateException">
        /// The specified state is not a valid state for an event source.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeactivateEventSource">REST API Reference for DeactivateEventSource Operation</seealso>
        Task<DeactivateEventSourceResponse> DeactivateEventSourceAsync(DeactivateEventSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeauthorizeConnection


        /// <summary>
        /// Removes all authorization parameters from the connection. This lets you remove the
        /// secret from the connection so you can reuse it without having to create a new connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeauthorizeConnection service method.</param>
        /// 
        /// <returns>The response from the DeauthorizeConnection service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeauthorizeConnection">REST API Reference for DeauthorizeConnection Operation</seealso>
        DeauthorizeConnectionResponse DeauthorizeConnection(DeauthorizeConnectionRequest request);



        /// <summary>
        /// Removes all authorization parameters from the connection. This lets you remove the
        /// secret from the connection so you can reuse it without having to create a new connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeauthorizeConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeauthorizeConnection service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeauthorizeConnection">REST API Reference for DeauthorizeConnection Operation</seealso>
        Task<DeauthorizeConnectionResponse> DeauthorizeConnectionAsync(DeauthorizeConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApiDestination


        /// <summary>
        /// Deletes the specified API destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteApiDestination service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteApiDestination">REST API Reference for DeleteApiDestination Operation</seealso>
        DeleteApiDestinationResponse DeleteApiDestination(DeleteApiDestinationRequest request);



        /// <summary>
        /// Deletes the specified API destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApiDestination service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteApiDestination">REST API Reference for DeleteApiDestination Operation</seealso>
        Task<DeleteApiDestinationResponse> DeleteApiDestinationAsync(DeleteApiDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteArchive


        /// <summary>
        /// Deletes the specified archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive service method.</param>
        /// 
        /// <returns>The response from the DeleteArchive service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteArchive">REST API Reference for DeleteArchive Operation</seealso>
        DeleteArchiveResponse DeleteArchive(DeleteArchiveRequest request);



        /// <summary>
        /// Deletes the specified archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteArchive service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteArchive">REST API Reference for DeleteArchive Operation</seealso>
        Task<DeleteArchiveResponse> DeleteArchiveAsync(DeleteArchiveRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConnection


        /// <summary>
        /// Deletes a connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request);



        /// <summary>
        /// Deletes a connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEndpoint


        /// <summary>
        /// Delete an existing global endpoint. For more information about global endpoints, see
        /// <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-global-endpoints.html">Making
        /// applications Regional-fault tolerant with global endpoints and event replication</a>
        /// in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request);



        /// <summary>
        /// Delete an existing global endpoint. For more information about global endpoints, see
        /// <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-global-endpoints.html">Making
        /// applications Regional-fault tolerant with global endpoints and event replication</a>
        /// in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEventBus


        /// <summary>
        /// Deletes the specified custom event bus or partner event bus. All rules associated
        /// with this event bus need to be deleted. You can't delete your account's default event
        /// bus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventBus service method.</param>
        /// 
        /// <returns>The response from the DeleteEventBus service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteEventBus">REST API Reference for DeleteEventBus Operation</seealso>
        DeleteEventBusResponse DeleteEventBus(DeleteEventBusRequest request);



        /// <summary>
        /// Deletes the specified custom event bus or partner event bus. All rules associated
        /// with this event bus need to be deleted. You can't delete your account's default event
        /// bus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventBus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventBus service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteEventBus">REST API Reference for DeleteEventBus Operation</seealso>
        Task<DeleteEventBusResponse> DeleteEventBusAsync(DeleteEventBusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePartnerEventSource


        /// <summary>
        /// This operation is used by SaaS partners to delete a partner event source. This operation
        /// is not used by Amazon Web Services customers.
        /// 
        ///  
        /// <para>
        /// When you delete an event source, the status of the corresponding partner event bus
        /// in the Amazon Web Services customer account becomes DELETED.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePartnerEventSource service method.</param>
        /// 
        /// <returns>The response from the DeletePartnerEventSource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeletePartnerEventSource">REST API Reference for DeletePartnerEventSource Operation</seealso>
        DeletePartnerEventSourceResponse DeletePartnerEventSource(DeletePartnerEventSourceRequest request);



        /// <summary>
        /// This operation is used by SaaS partners to delete a partner event source. This operation
        /// is not used by Amazon Web Services customers.
        /// 
        ///  
        /// <para>
        /// When you delete an event source, the status of the corresponding partner event bus
        /// in the Amazon Web Services customer account becomes DELETED.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePartnerEventSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePartnerEventSource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeletePartnerEventSource">REST API Reference for DeletePartnerEventSource Operation</seealso>
        Task<DeletePartnerEventSourceResponse> DeletePartnerEventSourceAsync(DeletePartnerEventSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRule


        /// <summary>
        /// Deletes the specified rule.
        /// 
        ///  
        /// <para>
        /// Before you can delete the rule, you must remove all targets, using <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_RemoveTargets.html">RemoveTargets</a>.
        /// </para>
        ///  
        /// <para>
        /// When you delete a rule, incoming events might continue to match to the deleted rule.
        /// Allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// If you call delete rule multiple times for the same rule, all calls will succeed.
        /// When you call delete rule for a non-existent custom eventbus, <c>ResourceNotFoundException</c>
        /// is returned.
        /// </para>
        ///  
        /// <para>
        /// Managed rules are rules created and managed by another Amazon Web Services service
        /// on your behalf. These rules are created by those other Amazon Web Services services
        /// to support functionality in those services. You can delete these rules using the <c>Force</c>
        /// option, but you should do so only if you are sure the other service is not still using
        /// that rule.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        DeleteRuleResponse DeleteRule(DeleteRuleRequest request);



        /// <summary>
        /// Deletes the specified rule.
        /// 
        ///  
        /// <para>
        /// Before you can delete the rule, you must remove all targets, using <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_RemoveTargets.html">RemoveTargets</a>.
        /// </para>
        ///  
        /// <para>
        /// When you delete a rule, incoming events might continue to match to the deleted rule.
        /// Allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// If you call delete rule multiple times for the same rule, all calls will succeed.
        /// When you call delete rule for a non-existent custom eventbus, <c>ResourceNotFoundException</c>
        /// is returned.
        /// </para>
        ///  
        /// <para>
        /// Managed rules are rules created and managed by another Amazon Web Services service
        /// on your behalf. These rules are created by those other Amazon Web Services services
        /// to support functionality in those services. You can delete these rules using the <c>Force</c>
        /// option, but you should do so only if you are sure the other service is not still using
        /// that rule.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeApiDestination


        /// <summary>
        /// Retrieves details about an API destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApiDestination service method.</param>
        /// 
        /// <returns>The response from the DescribeApiDestination service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeApiDestination">REST API Reference for DescribeApiDestination Operation</seealso>
        DescribeApiDestinationResponse DescribeApiDestination(DescribeApiDestinationRequest request);



        /// <summary>
        /// Retrieves details about an API destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApiDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApiDestination service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeApiDestination">REST API Reference for DescribeApiDestination Operation</seealso>
        Task<DescribeApiDestinationResponse> DescribeApiDestinationAsync(DescribeApiDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeArchive


        /// <summary>
        /// Retrieves details about an archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeArchive service method.</param>
        /// 
        /// <returns>The response from the DescribeArchive service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeArchive">REST API Reference for DescribeArchive Operation</seealso>
        DescribeArchiveResponse DescribeArchive(DescribeArchiveRequest request);



        /// <summary>
        /// Retrieves details about an archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeArchive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeArchive service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeArchive">REST API Reference for DescribeArchive Operation</seealso>
        Task<DescribeArchiveResponse> DescribeArchiveAsync(DescribeArchiveRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConnection


        /// <summary>
        /// Retrieves details about a connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnection service method.</param>
        /// 
        /// <returns>The response from the DescribeConnection service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeConnection">REST API Reference for DescribeConnection Operation</seealso>
        DescribeConnectionResponse DescribeConnection(DescribeConnectionRequest request);



        /// <summary>
        /// Retrieves details about a connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnection service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeConnection">REST API Reference for DescribeConnection Operation</seealso>
        Task<DescribeConnectionResponse> DescribeConnectionAsync(DescribeConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEndpoint


        /// <summary>
        /// Get the information about an existing global endpoint. For more information about
        /// global endpoints, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-global-endpoints.html">Making
        /// applications Regional-fault tolerant with global endpoints and event replication</a>
        /// in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpoint service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        DescribeEndpointResponse DescribeEndpoint(DescribeEndpointRequest request);



        /// <summary>
        /// Get the information about an existing global endpoint. For more information about
        /// global endpoints, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-global-endpoints.html">Making
        /// applications Regional-fault tolerant with global endpoints and event replication</a>
        /// in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpoint service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        Task<DescribeEndpointResponse> DescribeEndpointAsync(DescribeEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEventBus


        /// <summary>
        /// Displays details about an event bus in your account. This can include the external
        /// Amazon Web Services accounts that are permitted to write events to your default event
        /// bus, and the associated policy. For custom event buses and partner event buses, it
        /// displays the name, ARN, policy, state, and creation time.
        /// 
        ///  
        /// <para>
        ///  To enable your account to receive events from other accounts on its default event
        /// bus, use <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_PutPermission.html">PutPermission</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about partner event buses, see <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_CreateEventBus.html">CreateEventBus</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventBus service method.</param>
        /// 
        /// <returns>The response from the DescribeEventBus service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeEventBus">REST API Reference for DescribeEventBus Operation</seealso>
        DescribeEventBusResponse DescribeEventBus(DescribeEventBusRequest request);



        /// <summary>
        /// Displays details about an event bus in your account. This can include the external
        /// Amazon Web Services accounts that are permitted to write events to your default event
        /// bus, and the associated policy. For custom event buses and partner event buses, it
        /// displays the name, ARN, policy, state, and creation time.
        /// 
        ///  
        /// <para>
        ///  To enable your account to receive events from other accounts on its default event
        /// bus, use <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_PutPermission.html">PutPermission</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about partner event buses, see <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_CreateEventBus.html">CreateEventBus</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventBus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventBus service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeEventBus">REST API Reference for DescribeEventBus Operation</seealso>
        Task<DescribeEventBusResponse> DescribeEventBusAsync(DescribeEventBusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEventSource


        /// <summary>
        /// This operation lists details about a partner event source that is shared with your
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSource service method.</param>
        /// 
        /// <returns>The response from the DescribeEventSource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeEventSource">REST API Reference for DescribeEventSource Operation</seealso>
        DescribeEventSourceResponse DescribeEventSource(DescribeEventSourceRequest request);



        /// <summary>
        /// This operation lists details about a partner event source that is shared with your
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventSource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeEventSource">REST API Reference for DescribeEventSource Operation</seealso>
        Task<DescribeEventSourceResponse> DescribeEventSourceAsync(DescribeEventSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePartnerEventSource


        /// <summary>
        /// An SaaS partner can use this operation to list details about a partner event source
        /// that they have created. Amazon Web Services customers do not use this operation. Instead,
        /// Amazon Web Services customers can use <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_DescribeEventSource.html">DescribeEventSource</a>
        /// to see details about a partner event source that is shared with them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePartnerEventSource service method.</param>
        /// 
        /// <returns>The response from the DescribePartnerEventSource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribePartnerEventSource">REST API Reference for DescribePartnerEventSource Operation</seealso>
        DescribePartnerEventSourceResponse DescribePartnerEventSource(DescribePartnerEventSourceRequest request);



        /// <summary>
        /// An SaaS partner can use this operation to list details about a partner event source
        /// that they have created. Amazon Web Services customers do not use this operation. Instead,
        /// Amazon Web Services customers can use <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_DescribeEventSource.html">DescribeEventSource</a>
        /// to see details about a partner event source that is shared with them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePartnerEventSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePartnerEventSource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribePartnerEventSource">REST API Reference for DescribePartnerEventSource Operation</seealso>
        Task<DescribePartnerEventSourceResponse> DescribePartnerEventSourceAsync(DescribePartnerEventSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReplay


        /// <summary>
        /// Retrieves details about a replay. Use <c>DescribeReplay</c> to determine the progress
        /// of a running replay. A replay processes events to replay based on the time in the
        /// event, and replays them using 1 minute intervals. If you use <c>StartReplay</c> and
        /// specify an <c>EventStartTime</c> and an <c>EventEndTime</c> that covers a 20 minute
        /// time range, the events are replayed from the first minute of that 20 minute range
        /// first. Then the events from the second minute are replayed. You can use <c>DescribeReplay</c>
        /// to determine the progress of a replay. The value returned for <c>EventLastReplayedTime</c>
        /// indicates the time within the specified time range associated with the last event
        /// replayed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplay service method.</param>
        /// 
        /// <returns>The response from the DescribeReplay service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeReplay">REST API Reference for DescribeReplay Operation</seealso>
        DescribeReplayResponse DescribeReplay(DescribeReplayRequest request);



        /// <summary>
        /// Retrieves details about a replay. Use <c>DescribeReplay</c> to determine the progress
        /// of a running replay. A replay processes events to replay based on the time in the
        /// event, and replays them using 1 minute intervals. If you use <c>StartReplay</c> and
        /// specify an <c>EventStartTime</c> and an <c>EventEndTime</c> that covers a 20 minute
        /// time range, the events are replayed from the first minute of that 20 minute range
        /// first. Then the events from the second minute are replayed. You can use <c>DescribeReplay</c>
        /// to determine the progress of a replay. The value returned for <c>EventLastReplayedTime</c>
        /// indicates the time within the specified time range associated with the last event
        /// replayed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplay service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReplay service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeReplay">REST API Reference for DescribeReplay Operation</seealso>
        Task<DescribeReplayResponse> DescribeReplayAsync(DescribeReplayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRule


        /// <summary>
        /// Describes the specified rule.
        /// 
        ///  
        /// <para>
        /// DescribeRule does not list the targets of a rule. To see the targets associated with
        /// a rule, use <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_ListTargetsByRule.html">ListTargetsByRule</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRule service method.</param>
        /// 
        /// <returns>The response from the DescribeRule service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeRule">REST API Reference for DescribeRule Operation</seealso>
        DescribeRuleResponse DescribeRule(DescribeRuleRequest request);



        /// <summary>
        /// Describes the specified rule.
        /// 
        ///  
        /// <para>
        /// DescribeRule does not list the targets of a rule. To see the targets associated with
        /// a rule, use <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_ListTargetsByRule.html">ListTargetsByRule</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRule service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DescribeRule">REST API Reference for DescribeRule Operation</seealso>
        Task<DescribeRuleResponse> DescribeRuleAsync(DescribeRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableRule


        /// <summary>
        /// Disables the specified rule. A disabled rule won't match any events, and won't self-trigger
        /// if it has a schedule expression.
        /// 
        ///  
        /// <para>
        /// When you disable a rule, incoming events might continue to match to the disabled rule.
        /// Allow a short period of time for changes to take effect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableRule service method.</param>
        /// 
        /// <returns>The response from the DisableRule service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DisableRule">REST API Reference for DisableRule Operation</seealso>
        DisableRuleResponse DisableRule(DisableRuleRequest request);



        /// <summary>
        /// Disables the specified rule. A disabled rule won't match any events, and won't self-trigger
        /// if it has a schedule expression.
        /// 
        ///  
        /// <para>
        /// When you disable a rule, incoming events might continue to match to the disabled rule.
        /// Allow a short period of time for changes to take effect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableRule service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/DisableRule">REST API Reference for DisableRule Operation</seealso>
        Task<DisableRuleResponse> DisableRuleAsync(DisableRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableRule


        /// <summary>
        /// Enables the specified rule. If the rule does not exist, the operation fails.
        /// 
        ///  
        /// <para>
        /// When you enable a rule, incoming events might not immediately start matching to a
        /// newly enabled rule. Allow a short period of time for changes to take effect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableRule service method.</param>
        /// 
        /// <returns>The response from the EnableRule service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/EnableRule">REST API Reference for EnableRule Operation</seealso>
        EnableRuleResponse EnableRule(EnableRuleRequest request);



        /// <summary>
        /// Enables the specified rule. If the rule does not exist, the operation fails.
        /// 
        ///  
        /// <para>
        /// When you enable a rule, incoming events might not immediately start matching to a
        /// newly enabled rule. Allow a short period of time for changes to take effect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableRule service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/EnableRule">REST API Reference for EnableRule Operation</seealso>
        Task<EnableRuleResponse> EnableRuleAsync(EnableRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListApiDestinations


        /// <summary>
        /// Retrieves a list of API destination in the account in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApiDestinations service method.</param>
        /// 
        /// <returns>The response from the ListApiDestinations service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListApiDestinations">REST API Reference for ListApiDestinations Operation</seealso>
        ListApiDestinationsResponse ListApiDestinations(ListApiDestinationsRequest request);



        /// <summary>
        /// Retrieves a list of API destination in the account in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApiDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApiDestinations service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListApiDestinations">REST API Reference for ListApiDestinations Operation</seealso>
        Task<ListApiDestinationsResponse> ListApiDestinationsAsync(ListApiDestinationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListArchives


        /// <summary>
        /// Lists your archives. You can either list all the archives or you can provide a prefix
        /// to match to the archive names. Filter parameters are exclusive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArchives service method.</param>
        /// 
        /// <returns>The response from the ListArchives service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListArchives">REST API Reference for ListArchives Operation</seealso>
        ListArchivesResponse ListArchives(ListArchivesRequest request);



        /// <summary>
        /// Lists your archives. You can either list all the archives or you can provide a prefix
        /// to match to the archive names. Filter parameters are exclusive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArchives service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListArchives service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListArchives">REST API Reference for ListArchives Operation</seealso>
        Task<ListArchivesResponse> ListArchivesAsync(ListArchivesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListConnections


        /// <summary>
        /// Retrieves a list of connections from the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// 
        /// <returns>The response from the ListConnections service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListConnections">REST API Reference for ListConnections Operation</seealso>
        ListConnectionsResponse ListConnections(ListConnectionsRequest request);



        /// <summary>
        /// Retrieves a list of connections from the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnections service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListConnections">REST API Reference for ListConnections Operation</seealso>
        Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEndpoints


        /// <summary>
        /// List the global endpoints associated with this account. For more information about
        /// global endpoints, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-global-endpoints.html">Making
        /// applications Regional-fault tolerant with global endpoints and event replication</a>
        /// in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListEndpoints service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        ListEndpointsResponse ListEndpoints(ListEndpointsRequest request);



        /// <summary>
        /// List the global endpoints associated with this account. For more information about
        /// global endpoints, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-global-endpoints.html">Making
        /// applications Regional-fault tolerant with global endpoints and event replication</a>
        /// in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEndpoints service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        Task<ListEndpointsResponse> ListEndpointsAsync(ListEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEventBuses


        /// <summary>
        /// Lists all the event buses in your account, including the default event bus, custom
        /// event buses, and partner event buses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventBuses service method.</param>
        /// 
        /// <returns>The response from the ListEventBuses service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListEventBuses">REST API Reference for ListEventBuses Operation</seealso>
        ListEventBusesResponse ListEventBuses(ListEventBusesRequest request);



        /// <summary>
        /// Lists all the event buses in your account, including the default event bus, custom
        /// event buses, and partner event buses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventBuses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventBuses service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListEventBuses">REST API Reference for ListEventBuses Operation</seealso>
        Task<ListEventBusesResponse> ListEventBusesAsync(ListEventBusesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEventSources


        /// <summary>
        /// You can use this to see all the partner event sources that have been shared with your
        /// Amazon Web Services account. For more information about partner event sources, see
        /// <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_CreateEventBus.html">CreateEventBus</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventSources service method.</param>
        /// 
        /// <returns>The response from the ListEventSources service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListEventSources">REST API Reference for ListEventSources Operation</seealso>
        ListEventSourcesResponse ListEventSources(ListEventSourcesRequest request);



        /// <summary>
        /// You can use this to see all the partner event sources that have been shared with your
        /// Amazon Web Services account. For more information about partner event sources, see
        /// <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_CreateEventBus.html">CreateEventBus</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventSources service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListEventSources">REST API Reference for ListEventSources Operation</seealso>
        Task<ListEventSourcesResponse> ListEventSourcesAsync(ListEventSourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPartnerEventSourceAccounts


        /// <summary>
        /// An SaaS partner can use this operation to display the Amazon Web Services account
        /// ID that a particular partner event source name is associated with. This operation
        /// is not used by Amazon Web Services customers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerEventSourceAccounts service method.</param>
        /// 
        /// <returns>The response from the ListPartnerEventSourceAccounts service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListPartnerEventSourceAccounts">REST API Reference for ListPartnerEventSourceAccounts Operation</seealso>
        ListPartnerEventSourceAccountsResponse ListPartnerEventSourceAccounts(ListPartnerEventSourceAccountsRequest request);



        /// <summary>
        /// An SaaS partner can use this operation to display the Amazon Web Services account
        /// ID that a particular partner event source name is associated with. This operation
        /// is not used by Amazon Web Services customers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerEventSourceAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPartnerEventSourceAccounts service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListPartnerEventSourceAccounts">REST API Reference for ListPartnerEventSourceAccounts Operation</seealso>
        Task<ListPartnerEventSourceAccountsResponse> ListPartnerEventSourceAccountsAsync(ListPartnerEventSourceAccountsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPartnerEventSources


        /// <summary>
        /// An SaaS partner can use this operation to list all the partner event source names
        /// that they have created. This operation is not used by Amazon Web Services customers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerEventSources service method.</param>
        /// 
        /// <returns>The response from the ListPartnerEventSources service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListPartnerEventSources">REST API Reference for ListPartnerEventSources Operation</seealso>
        ListPartnerEventSourcesResponse ListPartnerEventSources(ListPartnerEventSourcesRequest request);



        /// <summary>
        /// An SaaS partner can use this operation to list all the partner event source names
        /// that they have created. This operation is not used by Amazon Web Services customers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerEventSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPartnerEventSources service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListPartnerEventSources">REST API Reference for ListPartnerEventSources Operation</seealso>
        Task<ListPartnerEventSourcesResponse> ListPartnerEventSourcesAsync(ListPartnerEventSourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListReplays


        /// <summary>
        /// Lists your replays. You can either list all the replays or you can provide a prefix
        /// to match to the replay names. Filter parameters are exclusive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReplays service method.</param>
        /// 
        /// <returns>The response from the ListReplays service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListReplays">REST API Reference for ListReplays Operation</seealso>
        ListReplaysResponse ListReplays(ListReplaysRequest request);



        /// <summary>
        /// Lists your replays. You can either list all the replays or you can provide a prefix
        /// to match to the replay names. Filter parameters are exclusive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReplays service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReplays service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListReplays">REST API Reference for ListReplays Operation</seealso>
        Task<ListReplaysResponse> ListReplaysAsync(ListReplaysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRuleNamesByTarget


        /// <summary>
        /// Lists the rules for the specified target. You can see which of the rules in Amazon
        /// EventBridge can invoke a specific target in your account.
        /// 
        ///  
        /// <para>
        /// The maximum number of results per page for requests is 100.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleNamesByTarget service method.</param>
        /// 
        /// <returns>The response from the ListRuleNamesByTarget service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListRuleNamesByTarget">REST API Reference for ListRuleNamesByTarget Operation</seealso>
        ListRuleNamesByTargetResponse ListRuleNamesByTarget(ListRuleNamesByTargetRequest request);



        /// <summary>
        /// Lists the rules for the specified target. You can see which of the rules in Amazon
        /// EventBridge can invoke a specific target in your account.
        /// 
        ///  
        /// <para>
        /// The maximum number of results per page for requests is 100.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleNamesByTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRuleNamesByTarget service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListRuleNamesByTarget">REST API Reference for ListRuleNamesByTarget Operation</seealso>
        Task<ListRuleNamesByTargetResponse> ListRuleNamesByTargetAsync(ListRuleNamesByTargetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRules


        /// <summary>
        /// Lists your Amazon EventBridge rules. You can either list all the rules or you can
        /// provide a prefix to match to the rule names.
        /// 
        ///  
        /// <para>
        /// The maximum number of results per page for requests is 100.
        /// </para>
        ///  
        /// <para>
        /// ListRules does not list the targets of a rule. To see the targets associated with
        /// a rule, use <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_ListTargetsByRule.html">ListTargetsByRule</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListRules">REST API Reference for ListRules Operation</seealso>
        ListRulesResponse ListRules(ListRulesRequest request);



        /// <summary>
        /// Lists your Amazon EventBridge rules. You can either list all the rules or you can
        /// provide a prefix to match to the rule names.
        /// 
        ///  
        /// <para>
        /// The maximum number of results per page for requests is 100.
        /// </para>
        ///  
        /// <para>
        /// ListRules does not list the targets of a rule. To see the targets associated with
        /// a rule, use <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_ListTargetsByRule.html">ListTargetsByRule</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListRules">REST API Reference for ListRules Operation</seealso>
        Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Displays the tags associated with an EventBridge resource. In EventBridge, rules and
        /// event buses can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Displays the tags associated with an EventBridge resource. In EventBridge, rules and
        /// event buses can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTargetsByRule


        /// <summary>
        /// Lists the targets assigned to the specified rule.
        /// 
        ///  
        /// <para>
        /// The maximum number of results per page for requests is 100.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsByRule service method.</param>
        /// 
        /// <returns>The response from the ListTargetsByRule service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListTargetsByRule">REST API Reference for ListTargetsByRule Operation</seealso>
        ListTargetsByRuleResponse ListTargetsByRule(ListTargetsByRuleRequest request);



        /// <summary>
        /// Lists the targets assigned to the specified rule.
        /// 
        ///  
        /// <para>
        /// The maximum number of results per page for requests is 100.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsByRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTargetsByRule service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/ListTargetsByRule">REST API Reference for ListTargetsByRule Operation</seealso>
        Task<ListTargetsByRuleResponse> ListTargetsByRuleAsync(ListTargetsByRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutEvents


        /// <summary>
        /// Sends custom events to Amazon EventBridge so that they can be matched to rules.
        /// 
        ///  
        /// <para>
        /// You can batch multiple event entries into one request for efficiency. However, the
        /// total entry size must be less than 256KB. You can calculate the entry size before
        /// you send the events. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-putevents.html#eb-putevent-size">Calculating
        /// PutEvents event entry size</a> in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </para>
        ///  
        /// <para>
        /// PutEvents accepts the data in JSON format. For the JSON number (integer) data type,
        /// the constraints are: a minimum value of -9,223,372,036,854,775,808 and a maximum value
        /// of 9,223,372,036,854,775,807.
        /// </para>
        ///  <note> 
        /// <para>
        /// PutEvents will only process nested JSON up to 1000 levels deep.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutEvents">REST API Reference for PutEvents Operation</seealso>
        PutEventsResponse PutEvents(PutEventsRequest request);



        /// <summary>
        /// Sends custom events to Amazon EventBridge so that they can be matched to rules.
        /// 
        ///  
        /// <para>
        /// You can batch multiple event entries into one request for efficiency. However, the
        /// total entry size must be less than 256KB. You can calculate the entry size before
        /// you send the events. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-putevents.html#eb-putevent-size">Calculating
        /// PutEvents event entry size</a> in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </para>
        ///  
        /// <para>
        /// PutEvents accepts the data in JSON format. For the JSON number (integer) data type,
        /// the constraints are: a minimum value of -9,223,372,036,854,775,808 and a maximum value
        /// of 9,223,372,036,854,775,807.
        /// </para>
        ///  <note> 
        /// <para>
        /// PutEvents will only process nested JSON up to 1000 levels deep.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutEvents">REST API Reference for PutEvents Operation</seealso>
        Task<PutEventsResponse> PutEventsAsync(PutEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutPartnerEvents


        /// <summary>
        /// This is used by SaaS partners to write events to a customer's partner event bus. Amazon
        /// Web Services customers do not use this operation.
        /// 
        ///  
        /// <para>
        /// For information on calculating event batch size, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-putevent-size.html">Calculating
        /// EventBridge PutEvents event entry size</a> in the <i>EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPartnerEvents service method.</param>
        /// 
        /// <returns>The response from the PutPartnerEvents service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutPartnerEvents">REST API Reference for PutPartnerEvents Operation</seealso>
        PutPartnerEventsResponse PutPartnerEvents(PutPartnerEventsRequest request);



        /// <summary>
        /// This is used by SaaS partners to write events to a customer's partner event bus. Amazon
        /// Web Services customers do not use this operation.
        /// 
        ///  
        /// <para>
        /// For information on calculating event batch size, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-putevent-size.html">Calculating
        /// EventBridge PutEvents event entry size</a> in the <i>EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPartnerEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPartnerEvents service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutPartnerEvents">REST API Reference for PutPartnerEvents Operation</seealso>
        Task<PutPartnerEventsResponse> PutPartnerEventsAsync(PutPartnerEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutPermission


        /// <summary>
        /// Running <c>PutPermission</c> permits the specified Amazon Web Services account or
        /// Amazon Web Services organization to put events to the specified <i>event bus</i>.
        /// Amazon EventBridge rules in your account are triggered by these events arriving to
        /// an event bus in your account. 
        /// 
        ///  
        /// <para>
        /// For another account to send events to your account, that external account must have
        /// an EventBridge rule with your account's event bus as a target.
        /// </para>
        ///  
        /// <para>
        /// To enable multiple Amazon Web Services accounts to put events to your event bus, run
        /// <c>PutPermission</c> once for each of these accounts. Or, if all the accounts are
        /// members of the same Amazon Web Services organization, you can run <c>PutPermission</c>
        /// once specifying <c>Principal</c> as "*" and specifying the Amazon Web Services organization
        /// ID in <c>Condition</c>, to grant permissions to all accounts in that organization.
        /// </para>
        ///  
        /// <para>
        /// If you grant permissions using an organization, then accounts in that organization
        /// must specify a <c>RoleArn</c> with proper permissions when they use <c>PutTarget</c>
        /// to add your account's event bus as a target. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-cross-account-event-delivery.html">Sending
        /// and Receiving Events Between Amazon Web Services Accounts</a> in the <i>Amazon EventBridge
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The permission policy on the event bus cannot exceed 10 KB in size.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermission service method.</param>
        /// 
        /// <returns>The response from the PutPermission service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.PolicyLengthExceededException">
        /// The event bus policy is too long. For more information, see the limits.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutPermission">REST API Reference for PutPermission Operation</seealso>
        PutPermissionResponse PutPermission(PutPermissionRequest request);



        /// <summary>
        /// Running <c>PutPermission</c> permits the specified Amazon Web Services account or
        /// Amazon Web Services organization to put events to the specified <i>event bus</i>.
        /// Amazon EventBridge rules in your account are triggered by these events arriving to
        /// an event bus in your account. 
        /// 
        ///  
        /// <para>
        /// For another account to send events to your account, that external account must have
        /// an EventBridge rule with your account's event bus as a target.
        /// </para>
        ///  
        /// <para>
        /// To enable multiple Amazon Web Services accounts to put events to your event bus, run
        /// <c>PutPermission</c> once for each of these accounts. Or, if all the accounts are
        /// members of the same Amazon Web Services organization, you can run <c>PutPermission</c>
        /// once specifying <c>Principal</c> as "*" and specifying the Amazon Web Services organization
        /// ID in <c>Condition</c>, to grant permissions to all accounts in that organization.
        /// </para>
        ///  
        /// <para>
        /// If you grant permissions using an organization, then accounts in that organization
        /// must specify a <c>RoleArn</c> with proper permissions when they use <c>PutTarget</c>
        /// to add your account's event bus as a target. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-cross-account-event-delivery.html">Sending
        /// and Receiving Events Between Amazon Web Services Accounts</a> in the <i>Amazon EventBridge
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The permission policy on the event bus cannot exceed 10 KB in size.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPermission service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.PolicyLengthExceededException">
        /// The event bus policy is too long. For more information, see the limits.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutPermission">REST API Reference for PutPermission Operation</seealso>
        Task<PutPermissionResponse> PutPermissionAsync(PutPermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutRule


        /// <summary>
        /// Creates or updates the specified rule. Rules are enabled by default, or based on value
        /// of the state. You can disable a rule using <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_DisableRule.html">DisableRule</a>.
        /// 
        ///  
        /// <para>
        /// A single rule watches for events from a single event bus. Events generated by Amazon
        /// Web Services services go to your account's default event bus. Events generated by
        /// SaaS partner services or applications go to the matching partner event bus. If you
        /// have custom applications or services, you can specify whether their events go to your
        /// default event bus or a custom event bus that you have created. For more information,
        /// see <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_CreateEventBus.html">CreateEventBus</a>.
        /// </para>
        ///  
        /// <para>
        /// If you are updating an existing rule, the rule is replaced with what you specify in
        /// this <c>PutRule</c> command. If you omit arguments in <c>PutRule</c>, the old values
        /// for those arguments are not kept. Instead, they are replaced with null values.
        /// </para>
        ///  
        /// <para>
        /// When you create or update a rule, incoming events might not immediately start matching
        /// to new or updated rules. Allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// A rule must contain at least an EventPattern or ScheduleExpression. Rules with EventPatterns
        /// are triggered when a matching event is observed. Rules with ScheduleExpressions self-trigger
        /// based on the given schedule. A rule can have both an EventPattern and a ScheduleExpression,
        /// in which case the rule triggers on matching events as well as on a schedule.
        /// </para>
        ///  
        /// <para>
        /// When you initially create a rule, you can optionally assign one or more tags to the
        /// rule. Tags can help you organize and categorize your resources. You can also use them
        /// to scope user permissions, by granting a user permission to access or change only
        /// rules with certain tag values. To use the <c>PutRule</c> operation and assign tags,
        /// you must have both the <c>events:PutRule</c> and <c>events:TagResource</c> permissions.
        /// </para>
        ///  
        /// <para>
        /// If you are updating an existing rule, any tags you specify in the <c>PutRule</c> operation
        /// are ignored. To update the tags of an existing rule, use <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_TagResource.html">TagResource</a>
        /// and <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_UntagResource.html">UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// Most services in Amazon Web Services treat : or / as the same character in Amazon
        /// Resource Names (ARNs). However, EventBridge uses an exact match in event patterns
        /// and rules. Be sure to use the correct ARN characters when creating event patterns
        /// so that they match the ARN syntax in the event you want to match.
        /// </para>
        ///  
        /// <para>
        /// In EventBridge, it is possible to create rules that lead to infinite loops, where
        /// a rule is fired repeatedly. For example, a rule might detect that ACLs have changed
        /// on an S3 bucket, and trigger software to change them to the desired state. If the
        /// rule is not written carefully, the subsequent change to the ACLs fires the rule again,
        /// creating an infinite loop.
        /// </para>
        ///  
        /// <para>
        /// To prevent this, write the rules so that the triggered actions do not re-fire the
        /// same rule. For example, your rule could fire only if ACLs are found to be in a bad
        /// state, instead of after any change. 
        /// </para>
        ///  
        /// <para>
        /// An infinite loop can quickly cause higher than expected charges. We recommend that
        /// you use budgeting, which alerts you when charges exceed your specified limit. For
        /// more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/budgets-managing-costs.html">Managing
        /// Your Costs with Budgets</a>.
        /// </para>
        ///  
        /// <para>
        /// To create a rule that filters for management events from Amazon Web Services services,
        /// see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-service-event-cloudtrail.html#eb-service-event-cloudtrail-management">Receiving
        /// read-only management events from Amazon Web Services services</a> in the <i>EventBridge
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRule service method.</param>
        /// 
        /// <returns>The response from the PutRule service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutRule">REST API Reference for PutRule Operation</seealso>
        PutRuleResponse PutRule(PutRuleRequest request);



        /// <summary>
        /// Creates or updates the specified rule. Rules are enabled by default, or based on value
        /// of the state. You can disable a rule using <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_DisableRule.html">DisableRule</a>.
        /// 
        ///  
        /// <para>
        /// A single rule watches for events from a single event bus. Events generated by Amazon
        /// Web Services services go to your account's default event bus. Events generated by
        /// SaaS partner services or applications go to the matching partner event bus. If you
        /// have custom applications or services, you can specify whether their events go to your
        /// default event bus or a custom event bus that you have created. For more information,
        /// see <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_CreateEventBus.html">CreateEventBus</a>.
        /// </para>
        ///  
        /// <para>
        /// If you are updating an existing rule, the rule is replaced with what you specify in
        /// this <c>PutRule</c> command. If you omit arguments in <c>PutRule</c>, the old values
        /// for those arguments are not kept. Instead, they are replaced with null values.
        /// </para>
        ///  
        /// <para>
        /// When you create or update a rule, incoming events might not immediately start matching
        /// to new or updated rules. Allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// A rule must contain at least an EventPattern or ScheduleExpression. Rules with EventPatterns
        /// are triggered when a matching event is observed. Rules with ScheduleExpressions self-trigger
        /// based on the given schedule. A rule can have both an EventPattern and a ScheduleExpression,
        /// in which case the rule triggers on matching events as well as on a schedule.
        /// </para>
        ///  
        /// <para>
        /// When you initially create a rule, you can optionally assign one or more tags to the
        /// rule. Tags can help you organize and categorize your resources. You can also use them
        /// to scope user permissions, by granting a user permission to access or change only
        /// rules with certain tag values. To use the <c>PutRule</c> operation and assign tags,
        /// you must have both the <c>events:PutRule</c> and <c>events:TagResource</c> permissions.
        /// </para>
        ///  
        /// <para>
        /// If you are updating an existing rule, any tags you specify in the <c>PutRule</c> operation
        /// are ignored. To update the tags of an existing rule, use <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_TagResource.html">TagResource</a>
        /// and <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_UntagResource.html">UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// Most services in Amazon Web Services treat : or / as the same character in Amazon
        /// Resource Names (ARNs). However, EventBridge uses an exact match in event patterns
        /// and rules. Be sure to use the correct ARN characters when creating event patterns
        /// so that they match the ARN syntax in the event you want to match.
        /// </para>
        ///  
        /// <para>
        /// In EventBridge, it is possible to create rules that lead to infinite loops, where
        /// a rule is fired repeatedly. For example, a rule might detect that ACLs have changed
        /// on an S3 bucket, and trigger software to change them to the desired state. If the
        /// rule is not written carefully, the subsequent change to the ACLs fires the rule again,
        /// creating an infinite loop.
        /// </para>
        ///  
        /// <para>
        /// To prevent this, write the rules so that the triggered actions do not re-fire the
        /// same rule. For example, your rule could fire only if ACLs are found to be in a bad
        /// state, instead of after any change. 
        /// </para>
        ///  
        /// <para>
        /// An infinite loop can quickly cause higher than expected charges. We recommend that
        /// you use budgeting, which alerts you when charges exceed your specified limit. For
        /// more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/budgets-managing-costs.html">Managing
        /// Your Costs with Budgets</a>.
        /// </para>
        ///  
        /// <para>
        /// To create a rule that filters for management events from Amazon Web Services services,
        /// see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-service-event-cloudtrail.html#eb-service-event-cloudtrail-management">Receiving
        /// read-only management events from Amazon Web Services services</a> in the <i>EventBridge
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRule service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutRule">REST API Reference for PutRule Operation</seealso>
        Task<PutRuleResponse> PutRuleAsync(PutRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutTargets


        /// <summary>
        /// Adds the specified targets to the specified rule, or updates the targets if they are
        /// already associated with the rule.
        /// 
        ///  
        /// <para>
        /// Targets are the resources that are invoked when a rule is triggered.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of entries per request is 10.
        /// </para>
        ///  <note> 
        /// <para>
        /// Each rule can have up to five (5) targets associated with it at one time.
        /// </para>
        ///  </note> 
        /// <para>
        /// For a list of services you can configure as targets for events, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-targets.html">EventBridge
        /// targets</a> in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </para>
        ///  
        /// <para>
        /// Creating rules with built-in targets is supported only in the Amazon Web Services
        /// Management Console. The built-in targets are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Amazon EBS CreateSnapshot API call</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Amazon EC2 RebootInstances API call</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Amazon EC2 StopInstances API call</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Amazon EC2 TerminateInstances API call</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For some target types, <c>PutTargets</c> provides target-specific parameters. If the
        /// target is a Kinesis data stream, you can optionally specify which shard the event
        /// goes to by using the <c>KinesisParameters</c> argument. To invoke a command on multiple
        /// EC2 instances with one rule, you can use the <c>RunCommandParameters</c> field.
        /// </para>
        ///  
        /// <para>
        /// To be able to make API calls against the resources that you own, Amazon EventBridge
        /// needs the appropriate permissions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Lambda and Amazon SNS resources, EventBridge relies on resource-based policies.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For EC2 instances, Kinesis Data Streams, Step Functions state machines and API Gateway
        /// APIs, EventBridge relies on IAM roles that you specify in the <c>RoleARN</c> argument
        /// in <c>PutTargets</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/auth-and-access-control-eventbridge.html">Authentication
        /// and Access Control</a> in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </para>
        ///  
        /// <para>
        /// If another Amazon Web Services account is in the same region and has granted you permission
        /// (using <c>PutPermission</c>), you can send events to that account. Set that account's
        /// event bus as a target of the rules in your account. To send the matched events to
        /// the other account, specify that account's event bus as the <c>Arn</c> value when you
        /// run <c>PutTargets</c>. If your account sends events to another account, your account
        /// is charged for each sent event. Each event sent to another account is charged as a
        /// custom event. The account receiving the event is not charged. For more information,
        /// see <a href="http://aws.amazon.com/eventbridge/pricing/">Amazon EventBridge Pricing</a>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Input</c>, <c>InputPath</c>, and <c>InputTransformer</c> are not available with
        /// <c>PutTarget</c> if the target is an event bus of a different Amazon Web Services
        /// account.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you are setting the event bus of another account as the target, and that account
        /// granted permission to your account through an organization instead of directly by
        /// the account ID, then you must specify a <c>RoleArn</c> with proper permissions in
        /// the <c>Target</c> structure. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-cross-account-event-delivery.html">Sending
        /// and Receiving Events Between Amazon Web Services Accounts</a> in the <i>Amazon EventBridge
        /// User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you have an IAM role on a cross-account event bus target, a <c>PutTargets</c> call
        /// without a role on the same target (same <c>Id</c> and <c>Arn</c>) will not remove
        /// the role.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about enabling cross-account events, see <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_PutPermission.html">PutPermission</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Input</b>, <b>InputPath</b>, and <b>InputTransformer</b> are mutually exclusive
        /// and optional parameters of a target. When a rule is triggered due to a matched event:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If none of the following arguments are specified for a target, then the entire event
        /// is passed to the target in JSON format (unless the target is Amazon EC2 Run Command
        /// or Amazon ECS task, in which case nothing from the event is passed to the target).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <b>Input</b> is specified in the form of valid JSON, then the matched event is
        /// overridden with this constant.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <b>InputPath</b> is specified in the form of JSONPath (for example, <c>$.detail</c>),
        /// then only the part of the event specified in the path is passed to the target (for
        /// example, only the detail part of the event is passed).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <b>InputTransformer</b> is specified, then one or more specified JSONPaths are
        /// extracted from the event and used as values in a template that you specify as the
        /// input to the target.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you specify <c>InputPath</c> or <c>InputTransformer</c>, you must use JSON dot
        /// notation, not bracket notation.
        /// </para>
        ///  
        /// <para>
        /// When you add targets to a rule and the associated rule triggers soon after, new or
        /// updated targets might not be immediately invoked. Allow a short period of time for
        /// changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// This action can partially fail if too many requests are made at the same time. If
        /// that happens, <c>FailedEntryCount</c> is non-zero in the response and each entry in
        /// <c>FailedEntries</c> provides the ID of the failed target and the error code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTargets service method.</param>
        /// 
        /// <returns>The response from the PutTargets service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutTargets">REST API Reference for PutTargets Operation</seealso>
        PutTargetsResponse PutTargets(PutTargetsRequest request);



        /// <summary>
        /// Adds the specified targets to the specified rule, or updates the targets if they are
        /// already associated with the rule.
        /// 
        ///  
        /// <para>
        /// Targets are the resources that are invoked when a rule is triggered.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of entries per request is 10.
        /// </para>
        ///  <note> 
        /// <para>
        /// Each rule can have up to five (5) targets associated with it at one time.
        /// </para>
        ///  </note> 
        /// <para>
        /// For a list of services you can configure as targets for events, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-targets.html">EventBridge
        /// targets</a> in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </para>
        ///  
        /// <para>
        /// Creating rules with built-in targets is supported only in the Amazon Web Services
        /// Management Console. The built-in targets are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Amazon EBS CreateSnapshot API call</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Amazon EC2 RebootInstances API call</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Amazon EC2 StopInstances API call</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Amazon EC2 TerminateInstances API call</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For some target types, <c>PutTargets</c> provides target-specific parameters. If the
        /// target is a Kinesis data stream, you can optionally specify which shard the event
        /// goes to by using the <c>KinesisParameters</c> argument. To invoke a command on multiple
        /// EC2 instances with one rule, you can use the <c>RunCommandParameters</c> field.
        /// </para>
        ///  
        /// <para>
        /// To be able to make API calls against the resources that you own, Amazon EventBridge
        /// needs the appropriate permissions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Lambda and Amazon SNS resources, EventBridge relies on resource-based policies.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For EC2 instances, Kinesis Data Streams, Step Functions state machines and API Gateway
        /// APIs, EventBridge relies on IAM roles that you specify in the <c>RoleARN</c> argument
        /// in <c>PutTargets</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/auth-and-access-control-eventbridge.html">Authentication
        /// and Access Control</a> in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </para>
        ///  
        /// <para>
        /// If another Amazon Web Services account is in the same region and has granted you permission
        /// (using <c>PutPermission</c>), you can send events to that account. Set that account's
        /// event bus as a target of the rules in your account. To send the matched events to
        /// the other account, specify that account's event bus as the <c>Arn</c> value when you
        /// run <c>PutTargets</c>. If your account sends events to another account, your account
        /// is charged for each sent event. Each event sent to another account is charged as a
        /// custom event. The account receiving the event is not charged. For more information,
        /// see <a href="http://aws.amazon.com/eventbridge/pricing/">Amazon EventBridge Pricing</a>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Input</c>, <c>InputPath</c>, and <c>InputTransformer</c> are not available with
        /// <c>PutTarget</c> if the target is an event bus of a different Amazon Web Services
        /// account.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you are setting the event bus of another account as the target, and that account
        /// granted permission to your account through an organization instead of directly by
        /// the account ID, then you must specify a <c>RoleArn</c> with proper permissions in
        /// the <c>Target</c> structure. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-cross-account-event-delivery.html">Sending
        /// and Receiving Events Between Amazon Web Services Accounts</a> in the <i>Amazon EventBridge
        /// User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you have an IAM role on a cross-account event bus target, a <c>PutTargets</c> call
        /// without a role on the same target (same <c>Id</c> and <c>Arn</c>) will not remove
        /// the role.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about enabling cross-account events, see <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_PutPermission.html">PutPermission</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Input</b>, <b>InputPath</b>, and <b>InputTransformer</b> are mutually exclusive
        /// and optional parameters of a target. When a rule is triggered due to a matched event:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If none of the following arguments are specified for a target, then the entire event
        /// is passed to the target in JSON format (unless the target is Amazon EC2 Run Command
        /// or Amazon ECS task, in which case nothing from the event is passed to the target).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <b>Input</b> is specified in the form of valid JSON, then the matched event is
        /// overridden with this constant.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <b>InputPath</b> is specified in the form of JSONPath (for example, <c>$.detail</c>),
        /// then only the part of the event specified in the path is passed to the target (for
        /// example, only the detail part of the event is passed).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <b>InputTransformer</b> is specified, then one or more specified JSONPaths are
        /// extracted from the event and used as values in a template that you specify as the
        /// input to the target.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you specify <c>InputPath</c> or <c>InputTransformer</c>, you must use JSON dot
        /// notation, not bracket notation.
        /// </para>
        ///  
        /// <para>
        /// When you add targets to a rule and the associated rule triggers soon after, new or
        /// updated targets might not be immediately invoked. Allow a short period of time for
        /// changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// This action can partially fail if too many requests are made at the same time. If
        /// that happens, <c>FailedEntryCount</c> is non-zero in the response and each entry in
        /// <c>FailedEntries</c> provides the ID of the failed target and the error code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTargets service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/PutTargets">REST API Reference for PutTargets Operation</seealso>
        Task<PutTargetsResponse> PutTargetsAsync(PutTargetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemovePermission


        /// <summary>
        /// Revokes the permission of another Amazon Web Services account to be able to put events
        /// to the specified event bus. Specify the account to revoke by the <c>StatementId</c>
        /// value that you associated with the account when you granted it permission with <c>PutPermission</c>.
        /// You can find the <c>StatementId</c> by using <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_DescribeEventBus.html">DescribeEventBus</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        RemovePermissionResponse RemovePermission(RemovePermissionRequest request);



        /// <summary>
        /// Revokes the permission of another Amazon Web Services account to be able to put events
        /// to the specified event bus. Specify the account to revoke by the <c>StatementId</c>
        /// value that you associated with the account when you granted it permission with <c>PutPermission</c>.
        /// You can find the <c>StatementId</c> by using <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_DescribeEventBus.html">DescribeEventBus</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveTargets


        /// <summary>
        /// Removes the specified targets from the specified rule. When the rule is triggered,
        /// those targets are no longer be invoked.
        /// 
        ///  <note> 
        /// <para>
        /// A successful execution of <c>RemoveTargets</c> doesn't guarantee all targets are removed
        /// from the rule, it means that the target(s) listed in the request are removed.
        /// </para>
        ///  </note> 
        /// <para>
        /// When you remove a target, when the associated rule triggers, removed targets might
        /// continue to be invoked. Allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// This action can partially fail if too many requests are made at the same time. If
        /// that happens, <c>FailedEntryCount</c> is non-zero in the response and each entry in
        /// <c>FailedEntries</c> provides the ID of the failed target and the error code.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of entries per request is 10.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTargets service method.</param>
        /// 
        /// <returns>The response from the RemoveTargets service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/RemoveTargets">REST API Reference for RemoveTargets Operation</seealso>
        RemoveTargetsResponse RemoveTargets(RemoveTargetsRequest request);



        /// <summary>
        /// Removes the specified targets from the specified rule. When the rule is triggered,
        /// those targets are no longer be invoked.
        /// 
        ///  <note> 
        /// <para>
        /// A successful execution of <c>RemoveTargets</c> doesn't guarantee all targets are removed
        /// from the rule, it means that the target(s) listed in the request are removed.
        /// </para>
        ///  </note> 
        /// <para>
        /// When you remove a target, when the associated rule triggers, removed targets might
        /// continue to be invoked. Allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// This action can partially fail if too many requests are made at the same time. If
        /// that happens, <c>FailedEntryCount</c> is non-zero in the response and each entry in
        /// <c>FailedEntries</c> provides the ID of the failed target and the error code.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of entries per request is 10.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTargets service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/RemoveTargets">REST API Reference for RemoveTargets Operation</seealso>
        Task<RemoveTargetsResponse> RemoveTargetsAsync(RemoveTargetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartReplay


        /// <summary>
        /// Starts the specified replay. Events are not necessarily replayed in the exact same
        /// order that they were added to the archive. A replay processes events to replay based
        /// on the time in the event, and replays them using 1 minute intervals. If you specify
        /// an <c>EventStartTime</c> and an <c>EventEndTime</c> that covers a 20 minute time range,
        /// the events are replayed from the first minute of that 20 minute range first. Then
        /// the events from the second minute are replayed. You can use <c>DescribeReplay</c>
        /// to determine the progress of a replay. The value returned for <c>EventLastReplayedTime</c>
        /// indicates the time within the specified time range associated with the last event
        /// replayed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplay service method.</param>
        /// 
        /// <returns>The response from the StartReplay service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/StartReplay">REST API Reference for StartReplay Operation</seealso>
        StartReplayResponse StartReplay(StartReplayRequest request);



        /// <summary>
        /// Starts the specified replay. Events are not necessarily replayed in the exact same
        /// order that they were added to the archive. A replay processes events to replay based
        /// on the time in the event, and replays them using 1 minute intervals. If you specify
        /// an <c>EventStartTime</c> and an <c>EventEndTime</c> that covers a 20 minute time range,
        /// the events are replayed from the first minute of that 20 minute range first. Then
        /// the events from the second minute are replayed. You can use <c>DescribeReplay</c>
        /// to determine the progress of a replay. The value returned for <c>EventLastReplayedTime</c>
        /// indicates the time within the specified time range associated with the last event
        /// replayed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplay service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartReplay service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceAlreadyExistsException">
        /// The resource you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/StartReplay">REST API Reference for StartReplay Operation</seealso>
        Task<StartReplayResponse> StartReplayAsync(StartReplayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified EventBridge resource.
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values. In EventBridge, rules and event buses can be tagged.
        /// 
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>TagResource</c> action with a resource that already has tags. If
        /// you specify a new tag key, this tag is appended to the list of tags associated with
        /// the resource. If you specify a tag key that is already associated with the resource,
        /// the new tag value that you specify replaces the previous value for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified EventBridge resource.
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values. In EventBridge, rules and event buses can be tagged.
        /// 
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>TagResource</c> action with a resource that already has tags. If
        /// you specify a new tag key, this tag is appended to the list of tags associated with
        /// the resource. If you specify a tag key that is already associated with the resource,
        /// the new tag value that you specify replaces the previous value for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TestEventPattern


        /// <summary>
        /// Tests whether the specified event pattern matches the provided event.
        /// 
        ///  
        /// <para>
        /// Most services in Amazon Web Services treat : or / as the same character in Amazon
        /// Resource Names (ARNs). However, EventBridge uses an exact match in event patterns
        /// and rules. Be sure to use the correct ARN characters when creating event patterns
        /// so that they match the ARN syntax in the event you want to match.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestEventPattern service method.</param>
        /// 
        /// <returns>The response from the TestEventPattern service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/TestEventPattern">REST API Reference for TestEventPattern Operation</seealso>
        TestEventPatternResponse TestEventPattern(TestEventPatternRequest request);



        /// <summary>
        /// Tests whether the specified event pattern matches the provided event.
        /// 
        ///  
        /// <para>
        /// Most services in Amazon Web Services treat : or / as the same character in Amazon
        /// Resource Names (ARNs). However, EventBridge uses an exact match in event patterns
        /// and rules. Be sure to use the correct ARN characters when creating event patterns
        /// so that they match the ARN syntax in the event you want to match.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestEventPattern service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestEventPattern service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/TestEventPattern">REST API Reference for TestEventPattern Operation</seealso>
        Task<TestEventPatternResponse> TestEventPatternAsync(TestEventPatternRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified EventBridge resource. In Amazon EventBridge,
        /// rules and event buses can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes one or more tags from the specified EventBridge resource. In Amazon EventBridge,
        /// rules and event buses can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ManagedRuleException">
        /// This rule was created by an Amazon Web Services service on behalf of your account.
        /// It is managed by that service. If you see this error in response to <c>DeleteRule</c>
        /// or <c>RemoveTargets</c>, you can use the <c>Force</c> parameter in those calls to
        /// delete the rule or remove targets from the rule. You cannot modify these managed rules
        /// by using <c>DisableRule</c>, <c>EnableRule</c>, <c>PutTargets</c>, <c>PutRule</c>,
        /// <c>TagResource</c>, or <c>UntagResource</c>.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateApiDestination


        /// <summary>
        /// Updates an API destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateApiDestination service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateApiDestination">REST API Reference for UpdateApiDestination Operation</seealso>
        UpdateApiDestinationResponse UpdateApiDestination(UpdateApiDestinationRequest request);



        /// <summary>
        /// Updates an API destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApiDestination service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateApiDestination">REST API Reference for UpdateApiDestination Operation</seealso>
        Task<UpdateApiDestinationResponse> UpdateApiDestinationAsync(UpdateApiDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateArchive


        /// <summary>
        /// Updates the specified archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateArchive service method.</param>
        /// 
        /// <returns>The response from the UpdateArchive service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateArchive">REST API Reference for UpdateArchive Operation</seealso>
        UpdateArchiveResponse UpdateArchive(UpdateArchiveRequest request);



        /// <summary>
        /// Updates the specified archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateArchive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateArchive service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateArchive">REST API Reference for UpdateArchive Operation</seealso>
        Task<UpdateArchiveResponse> UpdateArchiveAsync(UpdateArchiveRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateConnection


        /// <summary>
        /// Updates settings for a connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection service method.</param>
        /// 
        /// <returns>The response from the UpdateConnection service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.AccessDeniedException">
        /// You do not have the necessary permissions for this action.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ThrottlingException">
        /// This request cannot be completed due to throttling issues.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request);



        /// <summary>
        /// Updates settings for a connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnection service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.AccessDeniedException">
        /// You do not have the necessary permissions for this action.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.LimitExceededException">
        /// The request failed because it attempted to create resource beyond the allowed service
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ThrottlingException">
        /// This request cannot be completed due to throttling issues.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        Task<UpdateConnectionResponse> UpdateConnectionAsync(UpdateConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEndpoint


        /// <summary>
        /// Update an existing endpoint. For more information about global endpoints, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-global-endpoints.html">Making
        /// applications Regional-fault tolerant with global endpoints and event replication</a>
        /// in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpoint service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest request);



        /// <summary>
        /// Update an existing endpoint. For more information about global endpoints, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-global-endpoints.html">Making
        /// applications Regional-fault tolerant with global endpoints and event replication</a>
        /// in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEndpoint service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        Task<UpdateEndpointResponse> UpdateEndpointAsync(UpdateEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEventBus


        /// <summary>
        /// Updates the specified event bus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventBus service method.</param>
        /// 
        /// <returns>The response from the UpdateEventBus service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateEventBus">REST API Reference for UpdateEventBus Operation</seealso>
        UpdateEventBusResponse UpdateEventBus(UpdateEventBusRequest request);



        /// <summary>
        /// Updates the specified event bus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventBus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEventBus service method, as returned by EventBridge.</returns>
        /// <exception cref="Amazon.EventBridge.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule, target, archive, or replay.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.OperationDisabledException">
        /// The operation you are attempting is not available in this region.
        /// </exception>
        /// <exception cref="Amazon.EventBridge.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eventbridge-2015-10-07/UpdateEventBus">REST API Reference for UpdateEventBus Operation</seealso>
        Task<UpdateEventBusResponse> UpdateEventBusAsync(UpdateEventBusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}