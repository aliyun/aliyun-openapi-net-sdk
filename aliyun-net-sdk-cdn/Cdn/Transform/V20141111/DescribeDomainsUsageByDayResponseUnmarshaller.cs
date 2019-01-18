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
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainsUsageByDayResponseUnmarshaller
    {
        public static DescribeDomainsUsageByDayResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainsUsageByDayResponse describeDomainsUsageByDayResponse = new DescribeDomainsUsageByDayResponse();

			describeDomainsUsageByDayResponse.HttpResponse = context.HttpResponse;
			describeDomainsUsageByDayResponse.RequestId = context.StringValue("DescribeDomainsUsageByDay.RequestId");
			describeDomainsUsageByDayResponse.DomainName = context.StringValue("DescribeDomainsUsageByDay.DomainName");
			describeDomainsUsageByDayResponse.DataInterval = context.StringValue("DescribeDomainsUsageByDay.DataInterval");
			describeDomainsUsageByDayResponse.StartTime = context.StringValue("DescribeDomainsUsageByDay.StartTime");
			describeDomainsUsageByDayResponse.EndTime = context.StringValue("DescribeDomainsUsageByDay.EndTime");

			DescribeDomainsUsageByDayResponse.DescribeDomainsUsageByDay_UsageTotal usageTotal = new DescribeDomainsUsageByDayResponse.DescribeDomainsUsageByDay_UsageTotal();
			usageTotal.BytesHitRate = context.StringValue("DescribeDomainsUsageByDay.UsageTotal.BytesHitRate");
			usageTotal.RequestHitRate = context.StringValue("DescribeDomainsUsageByDay.UsageTotal.RequestHitRate");
			usageTotal.MaxBps = context.StringValue("DescribeDomainsUsageByDay.UsageTotal.MaxBps");
			usageTotal.MaxBpsTime = context.StringValue("DescribeDomainsUsageByDay.UsageTotal.MaxBpsTime");
			usageTotal.MaxSrcBps = context.StringValue("DescribeDomainsUsageByDay.UsageTotal.MaxSrcBps");
			usageTotal.MaxSrcBpsTime = context.StringValue("DescribeDomainsUsageByDay.UsageTotal.MaxSrcBpsTime");
			usageTotal.TotalAccess = context.StringValue("DescribeDomainsUsageByDay.UsageTotal.TotalAccess");
			usageTotal.TotalTraffic = context.StringValue("DescribeDomainsUsageByDay.UsageTotal.TotalTraffic");
			describeDomainsUsageByDayResponse.UsageTotal = usageTotal;

			List<DescribeDomainsUsageByDayResponse.DescribeDomainsUsageByDay_UsageByDay> describeDomainsUsageByDayResponse_usageByDays = new List<DescribeDomainsUsageByDayResponse.DescribeDomainsUsageByDay_UsageByDay>();
			for (int i = 0; i < context.Length("DescribeDomainsUsageByDay.UsageByDays.Length"); i++) {
				DescribeDomainsUsageByDayResponse.DescribeDomainsUsageByDay_UsageByDay usageByDay = new DescribeDomainsUsageByDayResponse.DescribeDomainsUsageByDay_UsageByDay();
				usageByDay.TimeStamp = context.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].TimeStamp");
				usageByDay.Qps = context.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].Qps");
				usageByDay.BytesHitRate = context.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].BytesHitRate");
				usageByDay.RequestHitRate = context.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].RequestHitRate");
				usageByDay.MaxBps = context.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].MaxBps");
				usageByDay.MaxBpsTime = context.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].MaxBpsTime");
				usageByDay.MaxSrcBps = context.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].MaxSrcBps");
				usageByDay.MaxSrcBpsTime = context.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].MaxSrcBpsTime");
				usageByDay.TotalAccess = context.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].TotalAccess");
				usageByDay.TotalTraffic = context.StringValue("DescribeDomainsUsageByDay.UsageByDays["+ i +"].TotalTraffic");

				describeDomainsUsageByDayResponse_usageByDays.Add(usageByDay);
			}
			describeDomainsUsageByDayResponse.UsageByDays = describeDomainsUsageByDayResponse_usageByDays;
        
			return describeDomainsUsageByDayResponse;
        }
    }
}