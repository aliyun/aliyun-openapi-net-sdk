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
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodDomainsUsageByDayResponseUnmarshaller
    {
        public static DescribeVodDomainsUsageByDayResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainsUsageByDayResponse describeVodDomainsUsageByDayResponse = new DescribeVodDomainsUsageByDayResponse();

			describeVodDomainsUsageByDayResponse.HttpResponse = context.HttpResponse;
			describeVodDomainsUsageByDayResponse.RequestId = context.StringValue("DescribeVodDomainsUsageByDay.RequestId");
			describeVodDomainsUsageByDayResponse.DomainName = context.StringValue("DescribeVodDomainsUsageByDay.DomainName");
			describeVodDomainsUsageByDayResponse.DataInterval = context.StringValue("DescribeVodDomainsUsageByDay.DataInterval");
			describeVodDomainsUsageByDayResponse.StartTime = context.StringValue("DescribeVodDomainsUsageByDay.StartTime");
			describeVodDomainsUsageByDayResponse.EndTime = context.StringValue("DescribeVodDomainsUsageByDay.EndTime");

			DescribeVodDomainsUsageByDayResponse.DescribeVodDomainsUsageByDay_UsageTotal usageTotal = new DescribeVodDomainsUsageByDayResponse.DescribeVodDomainsUsageByDay_UsageTotal();
			usageTotal.BytesHitRate = context.StringValue("DescribeVodDomainsUsageByDay.UsageTotal.BytesHitRate");
			usageTotal.RequestHitRate = context.StringValue("DescribeVodDomainsUsageByDay.UsageTotal.RequestHitRate");
			usageTotal.MaxBps = context.StringValue("DescribeVodDomainsUsageByDay.UsageTotal.MaxBps");
			usageTotal.MaxBpsTime = context.StringValue("DescribeVodDomainsUsageByDay.UsageTotal.MaxBpsTime");
			usageTotal.MaxSrcBps = context.StringValue("DescribeVodDomainsUsageByDay.UsageTotal.MaxSrcBps");
			usageTotal.MaxSrcBpsTime = context.StringValue("DescribeVodDomainsUsageByDay.UsageTotal.MaxSrcBpsTime");
			usageTotal.TotalAccess = context.StringValue("DescribeVodDomainsUsageByDay.UsageTotal.TotalAccess");
			usageTotal.TotalTraffic = context.StringValue("DescribeVodDomainsUsageByDay.UsageTotal.TotalTraffic");
			describeVodDomainsUsageByDayResponse.UsageTotal = usageTotal;

			List<DescribeVodDomainsUsageByDayResponse.DescribeVodDomainsUsageByDay_UsageByDay> describeVodDomainsUsageByDayResponse_usageByDays = new List<DescribeVodDomainsUsageByDayResponse.DescribeVodDomainsUsageByDay_UsageByDay>();
			for (int i = 0; i < context.Length("DescribeVodDomainsUsageByDay.UsageByDays.Length"); i++) {
				DescribeVodDomainsUsageByDayResponse.DescribeVodDomainsUsageByDay_UsageByDay usageByDay = new DescribeVodDomainsUsageByDayResponse.DescribeVodDomainsUsageByDay_UsageByDay();
				usageByDay.TimeStamp = context.StringValue("DescribeVodDomainsUsageByDay.UsageByDays["+ i +"].TimeStamp");
				usageByDay.Qps = context.StringValue("DescribeVodDomainsUsageByDay.UsageByDays["+ i +"].Qps");
				usageByDay.BytesHitRate = context.StringValue("DescribeVodDomainsUsageByDay.UsageByDays["+ i +"].BytesHitRate");
				usageByDay.RequestHitRate = context.StringValue("DescribeVodDomainsUsageByDay.UsageByDays["+ i +"].RequestHitRate");
				usageByDay.MaxBps = context.StringValue("DescribeVodDomainsUsageByDay.UsageByDays["+ i +"].MaxBps");
				usageByDay.MaxBpsTime = context.StringValue("DescribeVodDomainsUsageByDay.UsageByDays["+ i +"].MaxBpsTime");
				usageByDay.MaxSrcBps = context.StringValue("DescribeVodDomainsUsageByDay.UsageByDays["+ i +"].MaxSrcBps");
				usageByDay.MaxSrcBpsTime = context.StringValue("DescribeVodDomainsUsageByDay.UsageByDays["+ i +"].MaxSrcBpsTime");
				usageByDay.TotalAccess = context.StringValue("DescribeVodDomainsUsageByDay.UsageByDays["+ i +"].TotalAccess");
				usageByDay.TotalTraffic = context.StringValue("DescribeVodDomainsUsageByDay.UsageByDays["+ i +"].TotalTraffic");

				describeVodDomainsUsageByDayResponse_usageByDays.Add(usageByDay);
			}
			describeVodDomainsUsageByDayResponse.UsageByDays = describeVodDomainsUsageByDayResponse_usageByDays;
        
			return describeVodDomainsUsageByDayResponse;
        }
    }
}