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
using Aliyun.Acs.Ecs.Model.V20140526;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeIpRangesResponseUnmarshaller
    {
        public static DescribeIpRangesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeIpRangesResponse describeIpRangesResponse = new DescribeIpRangesResponse();

			describeIpRangesResponse.HttpResponse = context.HttpResponse;
			describeIpRangesResponse.RequestId = context.StringValue("DescribeIpRanges.RequestId");
			describeIpRangesResponse.RegionId = context.StringValue("DescribeIpRanges.RegionId");
			describeIpRangesResponse.ClusterId = context.StringValue("DescribeIpRanges.ClusterId");
			describeIpRangesResponse.TotalCount = context.IntegerValue("DescribeIpRanges.TotalCount");
			describeIpRangesResponse.PageNumber = context.IntegerValue("DescribeIpRanges.PageNumber");
			describeIpRangesResponse.PageSize = context.IntegerValue("DescribeIpRanges.PageSize");

			List<DescribeIpRangesResponse.DescribeIpRanges_IpRange> describeIpRangesResponse_ipRanges = new List<DescribeIpRangesResponse.DescribeIpRanges_IpRange>();
			for (int i = 0; i < context.Length("DescribeIpRanges.IpRanges.Length"); i++) {
				DescribeIpRangesResponse.DescribeIpRanges_IpRange ipRange = new DescribeIpRangesResponse.DescribeIpRanges_IpRange();
				ipRange.IpAddress = context.StringValue("DescribeIpRanges.IpRanges["+ i +"].IpAddress");
				ipRange.NicType = context.StringValue("DescribeIpRanges.IpRanges["+ i +"].NicType");

				describeIpRangesResponse_ipRanges.Add(ipRange);
			}
			describeIpRangesResponse.IpRanges = describeIpRangesResponse_ipRanges;
        
			return describeIpRangesResponse;
        }
    }
}