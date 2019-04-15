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
    public class DescribeVulLevelStatisticsResponseUnmarshaller
    {
        public static DescribeVulLevelStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVulLevelStatisticsResponse describeVulLevelStatisticsResponse = new DescribeVulLevelStatisticsResponse();

			describeVulLevelStatisticsResponse.HttpResponse = context.HttpResponse;
			describeVulLevelStatisticsResponse.RequestId = context.StringValue("DescribeVulLevelStatistics.RequestId");
			describeVulLevelStatisticsResponse.TotalCount = context.IntegerValue("DescribeVulLevelStatistics.TotalCount");

			List<DescribeVulLevelStatisticsResponse.DescribeVulLevelStatistics_LevelStatistic> describeVulLevelStatisticsResponse_levelStatistics = new List<DescribeVulLevelStatisticsResponse.DescribeVulLevelStatistics_LevelStatistic>();
			for (int i = 0; i < context.Length("DescribeVulLevelStatistics.LevelStatistics.Length"); i++) {
				DescribeVulLevelStatisticsResponse.DescribeVulLevelStatistics_LevelStatistic levelStatistic = new DescribeVulLevelStatisticsResponse.DescribeVulLevelStatistics_LevelStatistic();
				levelStatistic.Level = context.StringValue("DescribeVulLevelStatistics.LevelStatistics["+ i +"].Level");
				levelStatistic.CveNum = context.IntegerValue("DescribeVulLevelStatistics.LevelStatistics["+ i +"].CveNum");
				levelStatistic.EmgNum = context.IntegerValue("DescribeVulLevelStatistics.LevelStatistics["+ i +"].EmgNum");
				levelStatistic.SysNum = context.IntegerValue("DescribeVulLevelStatistics.LevelStatistics["+ i +"].SysNum");
				levelStatistic.CmsNum = context.IntegerValue("DescribeVulLevelStatistics.LevelStatistics["+ i +"].CmsNum");
				levelStatistic.CmsDealedTotalNum = context.IntegerValue("DescribeVulLevelStatistics.LevelStatistics["+ i +"].CmsDealedTotalNum");
				levelStatistic.VulDealedTotalNum = context.IntegerValue("DescribeVulLevelStatistics.LevelStatistics["+ i +"].VulDealedTotalNum");
				levelStatistic.VulAsapSum = context.IntegerValue("DescribeVulLevelStatistics.LevelStatistics["+ i +"].VulAsapSum");
				levelStatistic.VulLaterSum = context.IntegerValue("DescribeVulLevelStatistics.LevelStatistics["+ i +"].VulLaterSum");
				levelStatistic.VulNntfSum = context.IntegerValue("DescribeVulLevelStatistics.LevelStatistics["+ i +"].VulNntfSum");
				levelStatistic.VulSeriousTotal = context.IntegerValue("DescribeVulLevelStatistics.LevelStatistics["+ i +"].VulSeriousTotal");
				levelStatistic.VulHighTotal = context.IntegerValue("DescribeVulLevelStatistics.LevelStatistics["+ i +"].VulHighTotal");
				levelStatistic.VulMediumTotal = context.IntegerValue("DescribeVulLevelStatistics.LevelStatistics["+ i +"].VulMediumTotal");
				levelStatistic.VulLowTotal = context.IntegerValue("DescribeVulLevelStatistics.LevelStatistics["+ i +"].VulLowTotal");

				describeVulLevelStatisticsResponse_levelStatistics.Add(levelStatistic);
			}
			describeVulLevelStatisticsResponse.LevelStatistics = describeVulLevelStatisticsResponse_levelStatistics;
        
			return describeVulLevelStatisticsResponse;
        }
    }
}
