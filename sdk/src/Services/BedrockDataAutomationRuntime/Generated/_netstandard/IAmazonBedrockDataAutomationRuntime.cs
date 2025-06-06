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
 * Do not modify this file. This file is generated from the bedrock-data-automation-runtime-2024-06-13.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BedrockDataAutomationRuntime.Model;

#pragma warning disable CS1570
namespace Amazon.BedrockDataAutomationRuntime
{
    /// <summary>
    /// <para>Interface for accessing BedrockDataAutomationRuntime</para>
    ///
    /// Amazon Bedrock Data Automation Runtime
    /// </summary>
    public partial interface IAmazonBedrockDataAutomationRuntime : IAmazonService, IDisposable
    {
                
        #region  GetDataAutomationStatus



        /// <summary>
        /// API used to get data automation status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataAutomationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataAutomationStatus service method, as returned by BedrockDataAutomationRuntime.</returns>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.AccessDeniedException">
        /// This exception will be thrown when customer does not have access to API.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.InternalServerException">
        /// This exception is for any internal un-expected service errors.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ResourceNotFoundException">
        /// This exception will be thrown when resource provided from customer not found.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ThrottlingException">
        /// This exception will be thrown when customer reached API TPS limit.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ValidationException">
        /// This exception will be thrown when customer provided invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/GetDataAutomationStatus">REST API Reference for GetDataAutomationStatus Operation</seealso>
        Task<GetDataAutomationStatusResponse> GetDataAutomationStatusAsync(GetDataAutomationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  InvokeDataAutomationAsync



        /// <summary>
        /// Async API: Invoke data automation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeDataAutomationAsync service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeDataAutomationAsync service method, as returned by BedrockDataAutomationRuntime.</returns>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.AccessDeniedException">
        /// This exception will be thrown when customer does not have access to API.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.InternalServerException">
        /// This exception is for any internal un-expected service errors.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ServiceQuotaExceededException">
        /// This exception will be thrown when service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ThrottlingException">
        /// This exception will be thrown when customer reached API TPS limit.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ValidationException">
        /// This exception will be thrown when customer provided invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/InvokeDataAutomationAsync">REST API Reference for InvokeDataAutomationAsync Operation</seealso>
        Task<InvokeDataAutomationAsyncResponse> InvokeDataAutomationAsyncAsync(InvokeDataAutomationAsyncRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// List tags for an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BedrockDataAutomationRuntime.</returns>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.AccessDeniedException">
        /// This exception will be thrown when customer does not have access to API.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.InternalServerException">
        /// This exception is for any internal un-expected service errors.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ResourceNotFoundException">
        /// This exception will be thrown when resource provided from customer not found.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ThrottlingException">
        /// This exception will be thrown when customer reached API TPS limit.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ValidationException">
        /// This exception will be thrown when customer provided invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Tag an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BedrockDataAutomationRuntime.</returns>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.AccessDeniedException">
        /// This exception will be thrown when customer does not have access to API.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.InternalServerException">
        /// This exception is for any internal un-expected service errors.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ResourceNotFoundException">
        /// This exception will be thrown when resource provided from customer not found.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ServiceQuotaExceededException">
        /// This exception will be thrown when service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ThrottlingException">
        /// This exception will be thrown when customer reached API TPS limit.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ValidationException">
        /// This exception will be thrown when customer provided invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Untag an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BedrockDataAutomationRuntime.</returns>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.AccessDeniedException">
        /// This exception will be thrown when customer does not have access to API.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.InternalServerException">
        /// This exception is for any internal un-expected service errors.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ResourceNotFoundException">
        /// This exception will be thrown when resource provided from customer not found.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ThrottlingException">
        /// This exception will be thrown when customer reached API TPS limit.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ValidationException">
        /// This exception will be thrown when customer provided invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonBedrockDataAutomationRuntimeConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonBedrockDataAutomationRuntimeConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonBedrockDataAutomationRuntimeConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonBedrockDataAutomationRuntimeConfig to create AmazonBedrockDataAutomationRuntimeClient");
            }

            return awsCredentials == null ? 
                    new AmazonBedrockDataAutomationRuntimeClient(serviceClientConfig) :
                    new AmazonBedrockDataAutomationRuntimeClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}