﻿/*
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
#pragma warning disable 1574

using Amazon.Runtime.Telemetry.Tracing;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.DynamoDBv2.DocumentModel
{
    public partial interface IDocumentBatchWrite
    {
        /// <summary>
        /// Executes a server call to batch-put/delete the item specified.
        ///
        /// If more than 25 put/delete operations are specified, calls of up to 25
        /// put/delete items will be made until all items are processed.
        /// </summary>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken));
    }

    public partial class DocumentBatchWrite : IDocumentBatchWrite
    {
        /// <inheritdoc/>
        public async Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            {
                var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(DocumentBatchWrite), nameof(ExecuteAsync));
                using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
                {
                    await ExecuteHelperAsync(cancellationToken).ConfigureAwait(false);
                }
            }
        }
    }

    public partial interface IMultiTableDocumentBatchWrite
    {
        /// <summary>
        /// Executes a multi-table batch put/delete against all configured batches.
        ///
        /// If more than 25 put/delete operations are specified, calls of up to 25
        /// put/delete items will be made until all items are processed.
        /// </summary>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken));
    }

    public partial class MultiTableDocumentBatchWrite : IMultiTableDocumentBatchWrite
    {
        /// <inheritdoc/>
        public async Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            {
                var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(MultiTableDocumentBatchWrite), nameof(ExecuteAsync));
                using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
                {
                    await ExecuteHelperAsync(cancellationToken).ConfigureAwait(false);
                }
            }
        }
    }
}
