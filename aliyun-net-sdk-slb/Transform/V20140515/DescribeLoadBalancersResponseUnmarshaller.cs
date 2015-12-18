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
    public class DescribeLoadBalancersResponseUnmarshaller
    {
        public static DescribeLoadBalancersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLoadBalancersResponse describeLoadBalancersResponse = new DescribeLoadBalancersResponse();

			describeLoadBalancersResponse.HttpResponse = context.HttpResponse;
			describeLoadBalancersResponse.RequestId = context.StringValue("DescribeLoadBalancers.RequestId");

			List<DescribeLoadBalancersResponse.LoadBalancer> loadBalancers = new List<DescribeLoadBalancersResponse.LoadBalancer>();
			for (int i = 0; i < context.Length("DescribeLoadBalancers.LoadBalancers.Length"); i++) {
				DescribeLoadBalancersResponse.LoadBalancer loadBalancer = new DescribeLoadBalancersResponse.LoadBalancer();
				loadBalancer.LoadBalancerId = context.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].LoadBalancerId");
				loadBalancer.LoadBalancerName = context.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].LoadBalancerName");
				loadBalancer.LoadBalancerStatus = context.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].LoadBalancerStatus");
				loadBalancer.Address = context.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].Address");
				loadBalancer.AddressType = context.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].AddressType");
				loadBalancer.RegionId = context.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].RegionId");
				loadBalancer.RegionIdAlias = context.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].RegionIdAlias");
				loadBalancer.VSwitchId = context.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].VSwitchId");
				loadBalancer.VpcId = context.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].VpcId");
				loadBalancer.NetworkType = context.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].NetworkType");
				loadBalancer.MasterZoneId = context.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].MasterZoneId");
				loadBalancer.SlaveZoneId = context.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].SlaveZoneId");
				loadBalancer.InternetChargeType = context.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].InternetChargeType");
				loadBalancer.CreateTime = context.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].CreateTime");
				loadBalancer.CreateTimeStamp = context.LongValue("DescribeLoadBalancers.LoadBalancers["+ i +"].CreateTimeStamp");

				loadBalancers.Add(loadBalancer);
			}
			describeLoadBalancersResponse.LoadBalancers = loadBalancers;
        
			return describeLoadBalancersResponse;
        }
    }
}