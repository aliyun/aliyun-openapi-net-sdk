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
    public class CreateLoadBalancerProResponseUnmarshaller
    {
        public static CreateLoadBalancerProResponse Unmarshall(UnmarshallerContext context)
        {
			CreateLoadBalancerProResponse createLoadBalancerProResponse = new CreateLoadBalancerProResponse();

			createLoadBalancerProResponse.HttpResponse = context.HttpResponse;
			createLoadBalancerProResponse.RequestId = context.StringValue("CreateLoadBalancerPro.RequestId");
			createLoadBalancerProResponse.LoadBalancerId = context.StringValue("CreateLoadBalancerPro.LoadBalancerId");
			createLoadBalancerProResponse.Address = context.StringValue("CreateLoadBalancerPro.Address");
			createLoadBalancerProResponse.LoadBalancerName = context.StringValue("CreateLoadBalancerPro.LoadBalancerName");
			createLoadBalancerProResponse.VpcId = context.StringValue("CreateLoadBalancerPro.VpcId");
			createLoadBalancerProResponse.VSwitchId = context.StringValue("CreateLoadBalancerPro.VSwitchId");
			createLoadBalancerProResponse.NetworkType = context.StringValue("CreateLoadBalancerPro.NetworkType");
        
			return createLoadBalancerProResponse;
        }
    }
}