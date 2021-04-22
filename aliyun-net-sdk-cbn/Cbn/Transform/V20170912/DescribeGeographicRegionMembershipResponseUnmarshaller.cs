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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class DescribeGeographicRegionMembershipResponseUnmarshaller
    {
        public static DescribeGeographicRegionMembershipResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGeographicRegionMembershipResponse describeGeographicRegionMembershipResponse = new DescribeGeographicRegionMembershipResponse();

			describeGeographicRegionMembershipResponse.HttpResponse = _ctx.HttpResponse;
			describeGeographicRegionMembershipResponse.RequestId = _ctx.StringValue("DescribeGeographicRegionMembership.RequestId");
			describeGeographicRegionMembershipResponse.TotalCount = _ctx.IntegerValue("DescribeGeographicRegionMembership.TotalCount");
			describeGeographicRegionMembershipResponse.PageNumber = _ctx.IntegerValue("DescribeGeographicRegionMembership.PageNumber");
			describeGeographicRegionMembershipResponse.PageSize = _ctx.IntegerValue("DescribeGeographicRegionMembership.PageSize");

			List<DescribeGeographicRegionMembershipResponse.DescribeGeographicRegionMembership_RegionId> describeGeographicRegionMembershipResponse_regionIds = new List<DescribeGeographicRegionMembershipResponse.DescribeGeographicRegionMembership_RegionId>();
			for (int i = 0; i < _ctx.Length("DescribeGeographicRegionMembership.RegionIds.Length"); i++) {
				DescribeGeographicRegionMembershipResponse.DescribeGeographicRegionMembership_RegionId regionId = new DescribeGeographicRegionMembershipResponse.DescribeGeographicRegionMembership_RegionId();
				regionId.RegionId = _ctx.StringValue("DescribeGeographicRegionMembership.RegionIds["+ i +"].RegionId");

				describeGeographicRegionMembershipResponse_regionIds.Add(regionId);
			}
			describeGeographicRegionMembershipResponse.RegionIds = describeGeographicRegionMembershipResponse_regionIds;
        
			return describeGeographicRegionMembershipResponse;
        }
    }
}
