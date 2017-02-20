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
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeIpRangesResponseUnmarshaller
    {
        public static DescribeIpRangesResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeIpRangesResponse describeIpRangesResponse = new DescribeIpRangesResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeIpRanges.RequestId"),
                RegionId = context.StringValue("DescribeIpRanges.RegionId"),
                ClusterId = context.StringValue("DescribeIpRanges.ClusterId"),
                TotalCount = context.IntegerValue("DescribeIpRanges.TotalCount"),
                PageNumber = context.IntegerValue("DescribeIpRanges.PageNumber"),
                PageSize = context.IntegerValue("DescribeIpRanges.PageSize")
            };
            List<DescribeIpRangesResponse.IpRange> ipRanges = new List<DescribeIpRangesResponse.IpRange>();
			for (int i = 0; i < context.Length("DescribeIpRanges.IpRanges.Length"); i++) {
                DescribeIpRangesResponse.IpRange ipRange = new DescribeIpRangesResponse.IpRange()
                {
                    IpAddress = context.StringValue($"DescribeIpRanges.IpRanges[{i}].IpAddress"),
                    NicType = context.EnumValue<DescribeIpRangesResponse.IpRange.NicTypeEnum>($"DescribeIpRanges.IpRanges[{i}].NicType")
                };
                ipRanges.Add(ipRange);
			}
			describeIpRangesResponse.IpRanges = ipRanges;
        
			return describeIpRangesResponse;
        }
    }
}