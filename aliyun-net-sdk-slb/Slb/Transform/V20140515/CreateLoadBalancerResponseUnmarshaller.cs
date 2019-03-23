/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Slb.Model.V20140515;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class CreateLoadBalancerResponseUnmarshaller
    {
        public static CreateLoadBalancerResponse Unmarshall(UnmarshallerContext context)
        {
            CreateLoadBalancerResponse createLoadBalancerResponse = new CreateLoadBalancerResponse();

            createLoadBalancerResponse.HttpResponse = context.HttpResponse;
            createLoadBalancerResponse.RequestId = context.StringValue("CreateLoadBalancer.RequestId");
            createLoadBalancerResponse.LoadBalancerId = context.StringValue("CreateLoadBalancer.LoadBalancerId");
            createLoadBalancerResponse.ResourceGroupId = context.StringValue("CreateLoadBalancer.ResourceGroupId");
            createLoadBalancerResponse.Address = context.StringValue("CreateLoadBalancer.Address");
            createLoadBalancerResponse.LoadBalancerName = context.StringValue("CreateLoadBalancer.LoadBalancerName");
            createLoadBalancerResponse.VpcId = context.StringValue("CreateLoadBalancer.VpcId");
            createLoadBalancerResponse.VSwitchId = context.StringValue("CreateLoadBalancer.VSwitchId");
            createLoadBalancerResponse.NetworkType = context.StringValue("CreateLoadBalancer.NetworkType");
            createLoadBalancerResponse.OrderId = context.LongValue("CreateLoadBalancer.OrderId");

            return createLoadBalancerResponse;
        }
    }
}