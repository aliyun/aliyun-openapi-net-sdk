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
				loadBalancer.LoadBalancerId = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].LoadBalancerId");
				loadBalancer.LoadBalancerName = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].LoadBalancerName");
				loadBalancer.LoadBalancerStatus = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].LoadBalancerStatus");
				loadBalancer.Address = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].Address");
				loadBalancer.AddressType = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].AddressType");
				loadBalancer.RegionId = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].RegionId");
				loadBalancer.RegionIdAlias = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].RegionIdAlias");
				loadBalancer.VSwitchId = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].VSwitchId");
				loadBalancer.VpcId = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].VpcId");
				loadBalancer.NetworkType = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].NetworkType");
				loadBalancer.MasterZoneId = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].MasterZoneId");
				loadBalancer.SlaveZoneId = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].SlaveZoneId");
				loadBalancer.InternetChargeType = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].InternetChargeType");
				loadBalancer.CreateTime = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].CreateTime");
				loadBalancer.CreateTimeStamp = _ctx.LongValue("DescribeLoadBalancers.LoadBalancers["+ i +"].CreateTimeStamp");
				loadBalancer.PayType = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].PayType");
				loadBalancer.ResourceGroupId = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].ResourceGroupId");
				loadBalancer.AddressIPVersion = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].AddressIPVersion");
				loadBalancer.BusinessStatus = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].BusinessStatus");
				loadBalancer.ModificationProtectionStatus = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].ModificationProtectionStatus");
				loadBalancer.ModificationProtectionReason = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].ModificationProtectionReason");
				loadBalancer.Bandwidth = _ctx.IntegerValue("DescribeLoadBalancers.LoadBalancers["+ i +"].Bandwidth");
				loadBalancer.InternetChargeTypeAlias = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].InternetChargeTypeAlias");
				loadBalancer.LoadBalancerSpec = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].LoadBalancerSpec");
				loadBalancer.DeleteProtection = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].DeleteProtection");

				List<DescribeLoadBalancersResponse.DescribeLoadBalancers_LoadBalancer.DescribeLoadBalancers_Tag> loadBalancer_tags = new List<DescribeLoadBalancersResponse.DescribeLoadBalancers_LoadBalancer.DescribeLoadBalancers_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeLoadBalancers.LoadBalancers["+ i +"].Tags.Length"); j++) {
					DescribeLoadBalancersResponse.DescribeLoadBalancers_LoadBalancer.DescribeLoadBalancers_Tag tag = new DescribeLoadBalancersResponse.DescribeLoadBalancers_LoadBalancer.DescribeLoadBalancers_Tag();
					tag.TagKey = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("DescribeLoadBalancers.LoadBalancers["+ i +"].Tags["+ j +"].TagValue");

					loadBalancer_tags.Add(tag);
				}
				loadBalancer.Tags = loadBalancer_tags;

				describeLoadBalancersResponse_loadBalancers.Add(loadBalancer);
			}
			describeLoadBalancersResponse.LoadBalancers = describeLoadBalancersResponse_loadBalancers;
        
			return describeLoadBalancersResponse;
        }
    }
}
