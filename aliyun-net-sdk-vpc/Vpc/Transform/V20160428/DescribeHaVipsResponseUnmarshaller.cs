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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeHaVipsResponseUnmarshaller
    {
        public static DescribeHaVipsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeHaVipsResponse describeHaVipsResponse = new DescribeHaVipsResponse();

			describeHaVipsResponse.HttpResponse = _ctx.HttpResponse;
			describeHaVipsResponse.RequestId = _ctx.StringValue("DescribeHaVips.RequestId");
			describeHaVipsResponse.TotalCount = _ctx.IntegerValue("DescribeHaVips.TotalCount");
			describeHaVipsResponse.PageNumber = _ctx.IntegerValue("DescribeHaVips.PageNumber");
			describeHaVipsResponse.PageSize = _ctx.IntegerValue("DescribeHaVips.PageSize");

			List<DescribeHaVipsResponse.DescribeHaVips_HaVip> describeHaVipsResponse_haVips = new List<DescribeHaVipsResponse.DescribeHaVips_HaVip>();
			for (int i = 0; i < _ctx.Length("DescribeHaVips.HaVips.Length"); i++) {
				DescribeHaVipsResponse.DescribeHaVips_HaVip haVip = new DescribeHaVipsResponse.DescribeHaVips_HaVip();
				haVip.HaVipId = _ctx.StringValue("DescribeHaVips.HaVips["+ i +"].HaVipId");
				haVip.RegionId = _ctx.StringValue("DescribeHaVips.HaVips["+ i +"].RegionId");
				haVip.VpcId = _ctx.StringValue("DescribeHaVips.HaVips["+ i +"].VpcId");
				haVip.VSwitchId = _ctx.StringValue("DescribeHaVips.HaVips["+ i +"].VSwitchId");
				haVip.IpAddress = _ctx.StringValue("DescribeHaVips.HaVips["+ i +"].IpAddress");
				haVip.Status = _ctx.StringValue("DescribeHaVips.HaVips["+ i +"].Status");
				haVip.MasterInstanceId = _ctx.StringValue("DescribeHaVips.HaVips["+ i +"].MasterInstanceId");
				haVip.Description = _ctx.StringValue("DescribeHaVips.HaVips["+ i +"].Description");
				haVip.Name = _ctx.StringValue("DescribeHaVips.HaVips["+ i +"].Name");
				haVip.ChargeType = _ctx.StringValue("DescribeHaVips.HaVips["+ i +"].ChargeType");
				haVip.CreateTime = _ctx.StringValue("DescribeHaVips.HaVips["+ i +"].CreateTime");
				haVip.AssociatedInstanceType = _ctx.StringValue("DescribeHaVips.HaVips["+ i +"].AssociatedInstanceType");

				List<string> haVip_associatedInstances = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeHaVips.HaVips["+ i +"].AssociatedInstances.Length"); j++) {
					haVip_associatedInstances.Add(_ctx.StringValue("DescribeHaVips.HaVips["+ i +"].AssociatedInstances["+ j +"]"));
				}
				haVip.AssociatedInstances = haVip_associatedInstances;

				List<string> haVip_associatedEipAddresses = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeHaVips.HaVips["+ i +"].AssociatedEipAddresses.Length"); j++) {
					haVip_associatedEipAddresses.Add(_ctx.StringValue("DescribeHaVips.HaVips["+ i +"].AssociatedEipAddresses["+ j +"]"));
				}
				haVip.AssociatedEipAddresses = haVip_associatedEipAddresses;

				describeHaVipsResponse_haVips.Add(haVip);
			}
			describeHaVipsResponse.HaVips = describeHaVipsResponse_haVips;
        
			return describeHaVipsResponse;
        }
    }
}
