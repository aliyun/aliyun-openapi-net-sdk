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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeHaVipsResponseUnmarshaller
    {
        public static DescribeHaVipsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeHaVipsResponse describeHaVipsResponse = new DescribeHaVipsResponse();

			describeHaVipsResponse.HttpResponse = context.HttpResponse;
			describeHaVipsResponse.RequestId = context.StringValue("DescribeHaVips.RequestId");
			describeHaVipsResponse.TotalCount = context.IntegerValue("DescribeHaVips.TotalCount");
			describeHaVipsResponse.PageNumber = context.IntegerValue("DescribeHaVips.PageNumber");
			describeHaVipsResponse.PageSize = context.IntegerValue("DescribeHaVips.PageSize");

			List<DescribeHaVipsResponse.DescribeHaVips_HaVip> describeHaVipsResponse_haVips = new List<DescribeHaVipsResponse.DescribeHaVips_HaVip>();
			for (int i = 0; i < context.Length("DescribeHaVips.HaVips.Length"); i++) {
				DescribeHaVipsResponse.DescribeHaVips_HaVip haVip = new DescribeHaVipsResponse.DescribeHaVips_HaVip();
				haVip.HaVipId = context.StringValue("DescribeHaVips.HaVips["+ i +"].HaVipId");
				haVip.RegionId = context.StringValue("DescribeHaVips.HaVips["+ i +"].RegionId");
				haVip.VpcId = context.StringValue("DescribeHaVips.HaVips["+ i +"].VpcId");
				haVip.VSwitchId = context.StringValue("DescribeHaVips.HaVips["+ i +"].VSwitchId");
				haVip.IpAddress = context.StringValue("DescribeHaVips.HaVips["+ i +"].IpAddress");
				haVip.Status = context.StringValue("DescribeHaVips.HaVips["+ i +"].Status");
				haVip.MasterInstanceId = context.StringValue("DescribeHaVips.HaVips["+ i +"].MasterInstanceId");
				haVip.Description = context.StringValue("DescribeHaVips.HaVips["+ i +"].Description");
				haVip.CreateTime = context.StringValue("DescribeHaVips.HaVips["+ i +"].CreateTime");

				List<string> haVip_associatedInstances = new List<string>();
				for (int j = 0; j < context.Length("DescribeHaVips.HaVips["+ i +"].AssociatedInstances.Length"); j++) {
					haVip_associatedInstances.Add(context.StringValue("DescribeHaVips.HaVips["+ i +"].AssociatedInstances["+ j +"]"));
				}
				haVip.AssociatedInstances = haVip_associatedInstances;

				List<string> haVip_associatedEipAddresses = new List<string>();
				for (int j = 0; j < context.Length("DescribeHaVips.HaVips["+ i +"].AssociatedEipAddresses.Length"); j++) {
					haVip_associatedEipAddresses.Add(context.StringValue("DescribeHaVips.HaVips["+ i +"].AssociatedEipAddresses["+ j +"]"));
				}
				haVip.AssociatedEipAddresses = haVip_associatedEipAddresses;

				describeHaVipsResponse_haVips.Add(haVip);
			}
			describeHaVipsResponse.HaVips = describeHaVipsResponse_haVips;
        
			return describeHaVipsResponse;
        }
    }
}
