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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeVulTargetStatisticsResponseUnmarshaller
    {
        public static DescribeVulTargetStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVulTargetStatisticsResponse describeVulTargetStatisticsResponse = new DescribeVulTargetStatisticsResponse();

			describeVulTargetStatisticsResponse.HttpResponse = context.HttpResponse;
			describeVulTargetStatisticsResponse.RequestId = context.StringValue("DescribeVulTargetStatistics.RequestId");
			describeVulTargetStatisticsResponse.PageSize = context.IntegerValue("DescribeVulTargetStatistics.PageSize");
			describeVulTargetStatisticsResponse.CurrentPage = context.IntegerValue("DescribeVulTargetStatistics.CurrentPage");
			describeVulTargetStatisticsResponse.TotalCount = context.IntegerValue("DescribeVulTargetStatistics.TotalCount");

			List<DescribeVulTargetStatisticsResponse.DescribeVulTargetStatistics_TargetStat> describeVulTargetStatisticsResponse_targetStats = new List<DescribeVulTargetStatisticsResponse.DescribeVulTargetStatistics_TargetStat>();
			for (int i = 0; i < context.Length("DescribeVulTargetStatistics.TargetStats.Length"); i++) {
				DescribeVulTargetStatisticsResponse.DescribeVulTargetStatistics_TargetStat targetStat = new DescribeVulTargetStatisticsResponse.DescribeVulTargetStatistics_TargetStat();
				targetStat.VulType = context.StringValue("DescribeVulTargetStatistics.TargetStats["+ i +"].VulType");
				targetStat.UuidCount = context.StringValue("DescribeVulTargetStatistics.TargetStats["+ i +"].UuidCount");
				targetStat.TotalCount = context.StringValue("DescribeVulTargetStatistics.TargetStats["+ i +"].TotalCount");

				List<DescribeVulTargetStatisticsResponse.DescribeVulTargetStatistics_TargetStat.DescribeVulTargetStatistics_Target> targetStat_targets = new List<DescribeVulTargetStatisticsResponse.DescribeVulTargetStatistics_TargetStat.DescribeVulTargetStatistics_Target>();
				for (int j = 0; j < context.Length("DescribeVulTargetStatistics.TargetStats["+ i +"].Targets.Length"); j++) {
					DescribeVulTargetStatisticsResponse.DescribeVulTargetStatistics_TargetStat.DescribeVulTargetStatistics_Target target = new DescribeVulTargetStatisticsResponse.DescribeVulTargetStatistics_TargetStat.DescribeVulTargetStatistics_Target();
					target.Target = context.StringValue("DescribeVulTargetStatistics.TargetStats["+ i +"].Targets["+ j +"].Target");
					target.TargetType = context.StringValue("DescribeVulTargetStatistics.TargetStats["+ i +"].Targets["+ j +"].TargetType");
					target.Flag = context.StringValue("DescribeVulTargetStatistics.TargetStats["+ i +"].Targets["+ j +"].Flag");

					targetStat_targets.Add(target);
				}
				targetStat.Targets = targetStat_targets;

				describeVulTargetStatisticsResponse_targetStats.Add(targetStat);
			}
			describeVulTargetStatisticsResponse.TargetStats = describeVulTargetStatisticsResponse_targetStats;
        
			return describeVulTargetStatisticsResponse;
        }
    }
}
