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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeInstanceStatisticsResponseUnmarshaller
    {
        public static DescribeInstanceStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceStatisticsResponse describeInstanceStatisticsResponse = new DescribeInstanceStatisticsResponse();

			describeInstanceStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceStatisticsResponse.RequestId = _ctx.StringValue("DescribeInstanceStatistics.RequestId");

			List<DescribeInstanceStatisticsResponse.DescribeInstanceStatistics_InstanceStatistic> describeInstanceStatisticsResponse_instanceStatistics = new List<DescribeInstanceStatisticsResponse.DescribeInstanceStatistics_InstanceStatistic>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceStatistics.InstanceStatistics.Length"); i++) {
				DescribeInstanceStatisticsResponse.DescribeInstanceStatistics_InstanceStatistic instanceStatistic = new DescribeInstanceStatisticsResponse.DescribeInstanceStatistics_InstanceStatistic();
				instanceStatistic.InstanceId = _ctx.StringValue("DescribeInstanceStatistics.InstanceStatistics["+ i +"].InstanceId");
				instanceStatistic.PortUsage = _ctx.IntegerValue("DescribeInstanceStatistics.InstanceStatistics["+ i +"].PortUsage");
				instanceStatistic.DomainUsage = _ctx.IntegerValue("DescribeInstanceStatistics.InstanceStatistics["+ i +"].DomainUsage");
				instanceStatistic.SiteUsage = _ctx.IntegerValue("DescribeInstanceStatistics.InstanceStatistics["+ i +"].SiteUsage");
				instanceStatistic.DefenseCountUsage = _ctx.IntegerValue("DescribeInstanceStatistics.InstanceStatistics["+ i +"].DefenseCountUsage");

				describeInstanceStatisticsResponse_instanceStatistics.Add(instanceStatistic);
			}
			describeInstanceStatisticsResponse.InstanceStatistics = describeInstanceStatisticsResponse_instanceStatistics;
        
			return describeInstanceStatisticsResponse;
        }
    }
}
