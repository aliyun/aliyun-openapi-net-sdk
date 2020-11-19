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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeDomainsUsageByDayResponseUnmarshaller
    {
        public static DescribeDomainsUsageByDayResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainsUsageByDayResponse describeDomainsUsageByDayResponse = new DescribeDomainsUsageByDayResponse();

			describeDomainsUsageByDayResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainsUsageByDayResponse.RequestId = _ctx.StringValue("DescribeDomainsUsageByDay.RequestId");
			describeDomainsUsageByDayResponse.DomainName = _ctx.StringValue("DescribeDomainsUsageByDay.DomainName");
			describeDomainsUsageByDayResponse.DataInterval = _ctx.StringValue("DescribeDomainsUsageByDay.DataInterval");
			describeDomainsUsageByDayResponse.StartTime = _ctx.StringValue("DescribeDomainsUsageByDay.StartTime");
			describeDomainsUsageByDayResponse.EndTime = _ctx.StringValue("DescribeDomainsUsageByDay.EndTime");

			DescribeDomainsUsageByDayResponse.DescribeDomainsUsageByDay_UsageTotal usageTotal = new DescribeDomainsUsageByDayResponse.DescribeDomainsUsageByDay_UsageTotal();
			usageTotal.BytesHitRate = _ctx.StringValue("DescribeDomainsUsageByDay.UsageTotal.BytesHitRate");
			usageTotal.RequestHitRate = _ctx.StringValue("DescribeDomainsUsageByDay.UsageTotal.RequestHitRate");
			usageTotal.MaxBps = _ctx.StringValue("DescribeDomainsUsageByDay.UsageTotal.MaxBps");
			usageTotal.MaxBpsTime = _ctx.StringValue("DescribeDomainsUsageByDay.UsageTotal.MaxBpsTime");
			usageTotal.MaxSrcBps = _ctx.StringValue("DescribeDomainsUsageByDay.UsageTotal.MaxSrcBps");
			usageTotal.MaxSrcBpsTime = _ctx.StringValue("DescribeDomainsUsageByDay.UsageTotal.MaxSrcBpsTime");
			usageTotal.TotalAccess = _ctx.StringValue("DescribeDomainsUsageByDay.UsageTotal.TotalAccess");
			usageTotal.TotalTraffic = _ctx.StringValue("DescribeDomainsUsageByDay.UsageTotal.TotalTraffic");
			describeDomainsUsageByDayResponse.UsageTotal = usageTotal;

			List<DescribeDomainsUsageByDayResponse.DescribeDomainsUsageByDay_UsageByDay> describeDomainsUsageByDayResponse_usageByDays = new List<DescribeDomainsUsageByDayResponse.DescribeDomainsUsageByDay_UsageByDay>();
			for (int i = 0; i < _ctx.Length("DescribeDomainsUsageByDay.UsageByDays.Length"); i++) {
				DescribeDomainsUsageByDayResponse.DescribeDomainsUsageByDay_UsageByDay usageByDay = new DescribeDomainsUsageByDayResponse.DescribeDomainsUsageByDay_UsageByDay();
				usageByDay.TimeStamp = _ctx.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].TimeStamp");
				usageByDay.Qps = _ctx.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].Qps");
				usageByDay.BytesHitRate = _ctx.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].BytesHitRate");
				usageByDay.RequestHitRate = _ctx.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].RequestHitRate");
				usageByDay.MaxBps = _ctx.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].MaxBps");
				usageByDay.MaxBpsTime = _ctx.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].MaxBpsTime");
				usageByDay.MaxSrcBps = _ctx.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].MaxSrcBps");
				usageByDay.MaxSrcBpsTime = _ctx.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].MaxSrcBpsTime");
				usageByDay.TotalAccess = _ctx.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].TotalAccess");
				usageByDay.TotalTraffic = _ctx.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].TotalTraffic");

				describeDomainsUsageByDayResponse_usageByDays.Add(usageByDay);
			}
			describeDomainsUsageByDayResponse.UsageByDays = describeDomainsUsageByDayResponse_usageByDays;
        
			return describeDomainsUsageByDayResponse;
        }
    }
}
