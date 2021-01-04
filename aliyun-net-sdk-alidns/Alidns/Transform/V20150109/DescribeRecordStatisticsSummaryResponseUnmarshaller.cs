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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeRecordStatisticsSummaryResponseUnmarshaller
    {
        public static DescribeRecordStatisticsSummaryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRecordStatisticsSummaryResponse describeRecordStatisticsSummaryResponse = new DescribeRecordStatisticsSummaryResponse();

			describeRecordStatisticsSummaryResponse.HttpResponse = _ctx.HttpResponse;
			describeRecordStatisticsSummaryResponse.RequestId = _ctx.StringValue("DescribeRecordStatisticsSummary.RequestId");
			describeRecordStatisticsSummaryResponse.TotalItems = _ctx.IntegerValue("DescribeRecordStatisticsSummary.TotalItems");
			describeRecordStatisticsSummaryResponse.TotalPages = _ctx.IntegerValue("DescribeRecordStatisticsSummary.TotalPages");
			describeRecordStatisticsSummaryResponse.PageSize = _ctx.IntegerValue("DescribeRecordStatisticsSummary.PageSize");
			describeRecordStatisticsSummaryResponse.PageNumber = _ctx.IntegerValue("DescribeRecordStatisticsSummary.PageNumber");

			List<DescribeRecordStatisticsSummaryResponse.DescribeRecordStatisticsSummary_Statistic> describeRecordStatisticsSummaryResponse_statistics = new List<DescribeRecordStatisticsSummaryResponse.DescribeRecordStatisticsSummary_Statistic>();
			for (int i = 0; i < _ctx.Length("DescribeRecordStatisticsSummary.Statistics.Length"); i++) {
				DescribeRecordStatisticsSummaryResponse.DescribeRecordStatisticsSummary_Statistic statistic = new DescribeRecordStatisticsSummaryResponse.DescribeRecordStatisticsSummary_Statistic();
				statistic.SubDomain = _ctx.StringValue("DescribeRecordStatisticsSummary.Statistics["+ i +"].SubDomain");
				statistic.Count = _ctx.LongValue("DescribeRecordStatisticsSummary.Statistics["+ i +"].Count");

				describeRecordStatisticsSummaryResponse_statistics.Add(statistic);
			}
			describeRecordStatisticsSummaryResponse.Statistics = describeRecordStatisticsSummaryResponse_statistics;
        
			return describeRecordStatisticsSummaryResponse;
        }
    }
}
