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
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeLoadBalancersResponseUnmarshaller
    {
        public static DescribeLoadBalancersResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeLoadBalancersResponse describeLoadBalancersResponse = new DescribeLoadBalancersResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeLoadBalancers.RequestId")
            };
            List<DescribeLoadBalancersResponse.LoadBalancer> loadBalancers = new List<DescribeLoadBalancersResponse.LoadBalancer>();
			for (int i = 0; i < context.Length("DescribeLoadBalancers.LoadBalancers.Length"); i++) {
                DescribeLoadBalancersResponse.LoadBalancer loadBalancer = new DescribeLoadBalancersResponse.LoadBalancer()
                {
                    LoadBalancerId = context.StringValue($"DescribeLoadBalancers.LoadBalancers[{i}].LoadBalancerId"),
                    LoadBalancerName = context.StringValue($"DescribeLoadBalancers.LoadBalancers[{i}].LoadBalancerName"),
                    LoadBalancerStatus = context.StringValue($"DescribeLoadBalancers.LoadBalancers[{i}].LoadBalancerStatus"),
                    Address = context.StringValue($"DescribeLoadBalancers.LoadBalancers[{i}].Address"),
                    AddressType = context.StringValue($"DescribeLoadBalancers.LoadBalancers[{i}].AddressType"),
                    RegionId = context.StringValue($"DescribeLoadBalancers.LoadBalancers[{i}].RegionId"),
                    RegionIdAlias = context.StringValue($"DescribeLoadBalancers.LoadBalancers[{i}].RegionIdAlias"),
                    VSwitchId = context.StringValue($"DescribeLoadBalancers.LoadBalancers[{i}].VSwitchId"),
                    VpcId = context.StringValue($"DescribeLoadBalancers.LoadBalancers[{i}].VpcId"),
                    NetworkType = context.StringValue($"DescribeLoadBalancers.LoadBalancers[{i}].NetworkType"),
                    MasterZoneId = context.StringValue($"DescribeLoadBalancers.LoadBalancers[{i}].MasterZoneId"),
                    SlaveZoneId = context.StringValue($"DescribeLoadBalancers.LoadBalancers[{i}].SlaveZoneId"),
                    InternetChargeType = context.StringValue($"DescribeLoadBalancers.LoadBalancers[{i}].InternetChargeType"),
                    CreateTime = context.StringValue($"DescribeLoadBalancers.LoadBalancers[{i}].CreateTime"),
                    CreateTimeStamp = context.LongValue($"DescribeLoadBalancers.LoadBalancers[{i}].CreateTimeStamp")
                };
                loadBalancers.Add(loadBalancer);
			}
			describeLoadBalancersResponse.LoadBalancers = loadBalancers;
        
			return describeLoadBalancersResponse;
        }
    }
}