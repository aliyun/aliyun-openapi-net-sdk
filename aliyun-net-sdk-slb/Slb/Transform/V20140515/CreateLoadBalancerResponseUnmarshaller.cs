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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Slb.Model.V20140515;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class CreateLoadBalancerResponseUnmarshaller
    {
        public static CreateLoadBalancerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateLoadBalancerResponse createLoadBalancerResponse = new CreateLoadBalancerResponse();

			createLoadBalancerResponse.HttpResponse = _ctx.HttpResponse;
			createLoadBalancerResponse.RequestId = _ctx.StringValue("CreateLoadBalancer.RequestId");
			createLoadBalancerResponse.LoadBalancerId = _ctx.StringValue("CreateLoadBalancer.LoadBalancerId");
			createLoadBalancerResponse.ResourceGroupId = _ctx.StringValue("CreateLoadBalancer.ResourceGroupId");
			createLoadBalancerResponse.Address = _ctx.StringValue("CreateLoadBalancer.Address");
			createLoadBalancerResponse.LoadBalancerName = _ctx.StringValue("CreateLoadBalancer.LoadBalancerName");
			createLoadBalancerResponse.VpcId = _ctx.StringValue("CreateLoadBalancer.VpcId");
			createLoadBalancerResponse.VSwitchId = _ctx.StringValue("CreateLoadBalancer.VSwitchId");
			createLoadBalancerResponse.NetworkType = _ctx.StringValue("CreateLoadBalancer.NetworkType");
			createLoadBalancerResponse.OrderId = _ctx.LongValue("CreateLoadBalancer.OrderId");
			createLoadBalancerResponse.AddressIPVersion = _ctx.StringValue("CreateLoadBalancer.AddressIPVersion");
        
			return createLoadBalancerResponse;
        }
    }
}
