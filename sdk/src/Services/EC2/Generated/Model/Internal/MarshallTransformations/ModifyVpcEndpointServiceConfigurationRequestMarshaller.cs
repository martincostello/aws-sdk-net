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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyVpcEndpointServiceConfiguration Request Marshaller
    /// </summary>       
    public class ModifyVpcEndpointServiceConfigurationRequestMarshaller : IMarshaller<IRequest, ModifyVpcEndpointServiceConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyVpcEndpointServiceConfigurationRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyVpcEndpointServiceConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyVpcEndpointServiceConfiguration");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAcceptanceRequired())
                {
                    request.Parameters.Add("AcceptanceRequired", StringUtils.FromBool(publicRequest.AcceptanceRequired));
                }
                if(publicRequest.IsSetAddGatewayLoadBalancerArns())
                {
                    if (publicRequest.AddGatewayLoadBalancerArns.Count == 0)
                        request.Parameters.Add("AddGatewayLoadBalancerArn", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AddGatewayLoadBalancerArns)
                         {
                             request.Parameters.Add("AddGatewayLoadBalancerArn" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetAddNetworkLoadBalancerArns())
                {
                    if (publicRequest.AddNetworkLoadBalancerArns.Count == 0)
                        request.Parameters.Add("AddNetworkLoadBalancerArn", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AddNetworkLoadBalancerArns)
                         {
                             request.Parameters.Add("AddNetworkLoadBalancerArn" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetAddSupportedIpAddressTypes())
                {
                    if (publicRequest.AddSupportedIpAddressTypes.Count == 0)
                        request.Parameters.Add("AddSupportedIpAddressType", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AddSupportedIpAddressTypes)
                         {
                             request.Parameters.Add("AddSupportedIpAddressType" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetAddSupportedRegions())
                {
                    if (publicRequest.AddSupportedRegions.Count == 0)
                        request.Parameters.Add("AddSupportedRegion", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AddSupportedRegions)
                         {
                             request.Parameters.Add("AddSupportedRegion" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetPrivateDnsName())
                {
                    request.Parameters.Add("PrivateDnsName", StringUtils.FromString(publicRequest.PrivateDnsName));
                }
                if(publicRequest.IsSetRemoveGatewayLoadBalancerArns())
                {
                    if (publicRequest.RemoveGatewayLoadBalancerArns.Count == 0)
                        request.Parameters.Add("RemoveGatewayLoadBalancerArn", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.RemoveGatewayLoadBalancerArns)
                         {
                             request.Parameters.Add("RemoveGatewayLoadBalancerArn" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetRemoveNetworkLoadBalancerArns())
                {
                    if (publicRequest.RemoveNetworkLoadBalancerArns.Count == 0)
                        request.Parameters.Add("RemoveNetworkLoadBalancerArn", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.RemoveNetworkLoadBalancerArns)
                         {
                             request.Parameters.Add("RemoveNetworkLoadBalancerArn" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetRemovePrivateDnsName())
                {
                    request.Parameters.Add("RemovePrivateDnsName", StringUtils.FromBool(publicRequest.RemovePrivateDnsName));
                }
                if(publicRequest.IsSetRemoveSupportedIpAddressTypes())
                {
                    if (publicRequest.RemoveSupportedIpAddressTypes.Count == 0)
                        request.Parameters.Add("RemoveSupportedIpAddressType", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.RemoveSupportedIpAddressTypes)
                         {
                             request.Parameters.Add("RemoveSupportedIpAddressType" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetRemoveSupportedRegions())
                {
                    if (publicRequest.RemoveSupportedRegions.Count == 0)
                        request.Parameters.Add("RemoveSupportedRegion", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.RemoveSupportedRegions)
                         {
                             request.Parameters.Add("RemoveSupportedRegion" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetServiceId())
                {
                    request.Parameters.Add("ServiceId", StringUtils.FromString(publicRequest.ServiceId));
                }
            }
            return request;
        }
                    private static ModifyVpcEndpointServiceConfigurationRequestMarshaller _instance = new ModifyVpcEndpointServiceConfigurationRequestMarshaller();        

        internal static ModifyVpcEndpointServiceConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyVpcEndpointServiceConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}