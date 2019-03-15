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
using Aliyun.Acs.pvtz.Model.V20180101;

namespace Aliyun.Acs.pvtz.Transform.V20180101
{
    public class DescribeStatisticSummaryResponseUnmarshaller
    {
        public static DescribeStatisticSummaryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStatisticSummaryResponse describeStatisticSummaryResponse = new DescribeStatisticSummaryResponse();

			describeStatisticSummaryResponse.HttpResponse = context.HttpResponse;
			describeStatisticSummaryResponse.RequestId = context.StringValue("DescribeStatisticSummary.RequestId");
			describeStatisticSummaryResponse.TotalCount = context.LongValue("DescribeStatisticSummary.TotalCount");

			List<DescribeStatisticSummaryResponse.DescribeStatisticSummary_ZoneRequestTop> describeStatisticSummaryResponse_zoneRequestTops = new List<DescribeStatisticSummaryResponse.DescribeStatisticSummary_ZoneRequestTop>();
			for (int i = 0; i < context.Length("DescribeStatisticSummary.ZoneRequestTops.Length"); i++) {
				DescribeStatisticSummaryResponse.DescribeStatisticSummary_ZoneRequestTop zoneRequestTop = new DescribeStatisticSummaryResponse.DescribeStatisticSummary_ZoneRequestTop();
				zoneRequestTop.ZoneName = context.StringValue("DescribeStatisticSummary.ZoneRequestTops["+ i +"].ZoneName");
				zoneRequestTop.RequestCount = context.LongValue("DescribeStatisticSummary.ZoneRequestTops["+ i +"].RequestCount");

				describeStatisticSummaryResponse_zoneRequestTops.Add(zoneRequestTop);
			}
			describeStatisticSummaryResponse.ZoneRequestTops = describeStatisticSummaryResponse_zoneRequestTops;

			List<DescribeStatisticSummaryResponse.DescribeStatisticSummary_VpcRequestTop> describeStatisticSummaryResponse_vpcRequestTops = new List<DescribeStatisticSummaryResponse.DescribeStatisticSummary_VpcRequestTop>();
			for (int i = 0; i < context.Length("DescribeStatisticSummary.VpcRequestTops.Length"); i++) {
				DescribeStatisticSummaryResponse.DescribeStatisticSummary_VpcRequestTop vpcRequestTop = new DescribeStatisticSummaryResponse.DescribeStatisticSummary_VpcRequestTop();
				vpcRequestTop.RegionId = context.StringValue("DescribeStatisticSummary.VpcRequestTops["+ i +"].RegionId");
				vpcRequestTop.VpcId = context.StringValue("DescribeStatisticSummary.VpcRequestTops["+ i +"].VpcId");
				vpcRequestTop.TunnelId = context.StringValue("DescribeStatisticSummary.VpcRequestTops["+ i +"].TunnelId");
				vpcRequestTop.RequestCount = context.LongValue("DescribeStatisticSummary.VpcRequestTops["+ i +"].RequestCount");
				vpcRequestTop.RegionName = context.StringValue("DescribeStatisticSummary.VpcRequestTops["+ i +"].RegionName");

				describeStatisticSummaryResponse_vpcRequestTops.Add(vpcRequestTop);
			}
			describeStatisticSummaryResponse.VpcRequestTops = describeStatisticSummaryResponse_vpcRequestTops;
        
			return describeStatisticSummaryResponse;
        }
    }
}
