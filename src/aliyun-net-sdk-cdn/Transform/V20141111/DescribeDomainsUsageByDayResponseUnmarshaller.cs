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
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainsUsageByDayResponseUnmarshaller
    {
        public static DescribeDomainsUsageByDayResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainsUsageByDayResponse describeDomainsUsageByDayResponse = new DescribeDomainsUsageByDayResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDomainsUsageByDay.RequestId"),
                DomainName = context.StringValue("DescribeDomainsUsageByDay.DomainName"),
                DataInterval = context.StringValue("DescribeDomainsUsageByDay.DataInterval"),
                StartTime = context.StringValue("DescribeDomainsUsageByDay.StartTime"),
                EndTime = context.StringValue("DescribeDomainsUsageByDay.EndTime")
            };
            DescribeDomainsUsageByDayResponse.UsageTotal_ usageTotal = new DescribeDomainsUsageByDayResponse.UsageTotal_()
            {
                BytesHitRate = context.StringValue("DescribeDomainsUsageByDay.UsageTotal.BytesHitRate"),
                RequestHitRate = context.StringValue("DescribeDomainsUsageByDay.UsageTotal.RequestHitRate"),
                MaxBps = context.StringValue("DescribeDomainsUsageByDay.UsageTotal.MaxBps"),
                MaxBpsTime = context.StringValue("DescribeDomainsUsageByDay.UsageTotal.MaxBpsTime"),
                MaxSrcBps = context.StringValue("DescribeDomainsUsageByDay.UsageTotal.MaxSrcBps"),
                MaxSrcBpsTime = context.StringValue("DescribeDomainsUsageByDay.UsageTotal.MaxSrcBpsTime"),
                TotalAccess = context.StringValue("DescribeDomainsUsageByDay.UsageTotal.TotalAccess"),
                TotalTraffic = context.StringValue("DescribeDomainsUsageByDay.UsageTotal.TotalTraffic")
            };
            describeDomainsUsageByDayResponse.UsageTotal = usageTotal;

			List<DescribeDomainsUsageByDayResponse.UsageByDay> usageByDays = new List<DescribeDomainsUsageByDayResponse.UsageByDay>();
			for (int i = 0; i < context.Length("DescribeDomainsUsageByDay.UsageByDays.Length"); i++) {
                DescribeDomainsUsageByDayResponse.UsageByDay usageByDay = new DescribeDomainsUsageByDayResponse.UsageByDay()
                {
                    TimeStamp = context.StringValue($"DescribeDomainsUsageByDay.UsageByDays[{i}].TimeStamp"),
                    Qps = context.StringValue($"DescribeDomainsUsageByDay.UsageByDays[{i}].Qps"),
                    BytesHitRate = context.StringValue($"DescribeDomainsUsageByDay.UsageByDays[{i}].BytesHitRate"),
                    RequestHitRate = context.StringValue($"DescribeDomainsUsageByDay.UsageByDays[{i}].RequestHitRate"),
                    MaxBps = context.StringValue($"DescribeDomainsUsageByDay.UsageByDays[{i}].MaxBps"),
                    MaxBpsTime = context.StringValue($"DescribeDomainsUsageByDay.UsageByDays[{i}].MaxBpsTime"),
                    MaxSrcBps = context.StringValue($"DescribeDomainsUsageByDay.UsageByDays[{i}].MaxSrcBps"),
                    MaxSrcBpsTime = context.StringValue($"DescribeDomainsUsageByDay.UsageByDays[{i}].MaxSrcBpsTime"),
                    TotalAccess = context.StringValue($"DescribeDomainsUsageByDay.UsageByDays[{i}].TotalAccess"),
                    TotalTraffic = context.StringValue($"DescribeDomainsUsageByDay.UsageByDays[{i}].TotalTraffic")
                };
                usageByDays.Add(usageByDay);
			}
			describeDomainsUsageByDayResponse.UsageByDays = usageByDays;
        
			return describeDomainsUsageByDayResponse;
        }
    }
}