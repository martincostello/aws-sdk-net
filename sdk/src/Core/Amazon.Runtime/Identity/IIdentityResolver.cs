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

using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Identity
{
    /// <summary>
    /// An identity resolver is a component that is able to resolve a customer's <see cref="BaseIdentity"/>.
    /// It might load the identity from:
    /// <list type="bullet">
    /// <item>Remote service (e.g. AWS Security Token Service)</item>
    /// <item>Local service (e.g. Instance Metadata Service)</item>
    /// <item>Local disk (e.g. configuration file)</item>
    /// <item>Local memory (e.g. environment variables)</item>
    /// </list>
    /// </summary>
    public interface IIdentityResolver
    {
        /// <summary>
        /// Loads the customer's identity for this resolver. 
        /// If the identity cannot be resolved an <c>AmazonClientException</c> will be thrown.
        /// </summary>
        BaseIdentity ResolveIdentity();

        /// <summary>
        /// Loads the customer's identity for this resolver. 
        /// If the identity cannot be resolved an <c>AmazonClientException</c> will be thrown.
        /// </summary>
        Task<BaseIdentity> ResolveIdentityAsync(CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// An identity resolver is a component that is able to resolve a customer's <see cref="BaseIdentity"/>.
    /// It might load the identity from:
    /// <list type="bullet">
    /// <item>Remote service (e.g. AWS Security Token Service)</item>
    /// <item>Local service (e.g. Instance Metadata Service)</item>
    /// <item>Local disk (e.g. configuration file)</item>
    /// <item>Local memory (e.g. environment variables)</item>
    /// </list>
    /// </summary>
    public interface IIdentityResolver<T> : IIdentityResolver where T : BaseIdentity
    {
        /// <summary>
        /// Loads the customer's identity for this resolver. 
        /// If the identity cannot be resolved an <c>AmazonClientException</c> will be thrown.
        /// </summary>
        new T ResolveIdentity();

        /// <summary>
        /// Loads the customer's identity for this resolver. 
        /// If the identity cannot be resolved an <c>AmazonClientException</c> will be thrown.
        /// </summary>
        new Task<T> ResolveIdentityAsync(CancellationToken cancellationToken = default);
    }
}
