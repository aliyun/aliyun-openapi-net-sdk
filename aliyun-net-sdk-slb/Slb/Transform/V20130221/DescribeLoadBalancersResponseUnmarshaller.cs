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
using Aliyun.Acs.Slb.Model.V20130221;

namespace Aliyun.Acs.Slb.Transform.V20130221
{
    public class DescribeLoadBalancersResponseUnmarshaller
    {
        public static DescribeLoadBalancersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLoadBalancersResponse describeLoadBalancersResponse = new DescribeLoadBalancersResponse();

			describeLoadBalancersResponse.HttpResponse = _ctx.HttpResponse;
			describeLoadBalancersResponse.RequestId = _ctx.StringValue("DescribeLoadBalancers.RequestId");
			describeLoadBalancersResponse.PageNumber = _ctx.IntegerValue("DescribeLoadBalancers.PageNumber");
			describeLoadBalancersResponse.PageSize = _ctx.IntegerValue("DescribeLoadBalancers.PageSize");
			describeLoadBalancersResponse.TotalCount = _ctx.IntegerValue("DescribeLoadBalancers.TotalCount");

			List<DescribeLoadBalancersResponse.DescribeLoadBalancers_LoadBalancer> describeLoadBalancersResponse_loadBalancers = new List<DescribeLoadBalancersResponse.DescribeLoadBalancers_LoadBalancer>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancers.LoadBalancers.Length"); i++) {
				DescribeLoadBalancersResponse.DescribeLoadBalancers_LoadBalancer loadBalancer = new DescribeLoadBalancersResponse.DescribeLoadBalancers_LoadBalancer();
				loadBalancer.VpcId = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].VpcId");
				loadBalancer.CreateTimeStamp = _ctx.LongValue("DescribeLoadBalancers.LoadBalancers["+ i +"].CreateTimeStamp");
				loadBalancer.CreateTime = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].CreateTime");
				loadBalancer.LoadBalancerId = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].LoadBalancerId");
				loadBalancer.PayType = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].PayType");
				loadBalancer.AddressType = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].AddressType");
				loadBalancer.NetworkType = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].NetworkType");
				loadBalancer.RegionId = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].RegionId");
				loadBalancer.VSwitchId = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].VSwitchId");
				loadBalancer.LoadBalancerStatus = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].LoadBalancerStatus");
				loadBalancer.LoadBalancerName = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].LoadBalancerName");
				loadBalancer.ResourceGroupId = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].ResourceGroupId");
				loadBalancer.InternetChargeType = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].InternetChargeType");
				loadBalancer.Address = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].Address");
				loadBalancer.SlaveZoneId = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].SlaveZoneId");
				loadBalancer.RegionIdAlias = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].RegionIdAlias");
				loadBalancer.MasterZoneId = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].MasterZoneId");

				describeLoadBalancersResponse_loadBalancers.Add(loadBalancer);
			}
			describeLoadBalancersResponse.LoadBalancers = describeLoadBalancersResponse_loadBalancers;
        
			return describeLoadBalancersResponse;
        }
    }
}
