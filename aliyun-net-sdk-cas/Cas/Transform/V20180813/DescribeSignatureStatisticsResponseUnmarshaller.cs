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
using Aliyun.Acs.cas.Model.V20180813;

namespace Aliyun.Acs.cas.Transform.V20180813
{
    public class DescribeSignatureStatisticsResponseUnmarshaller
    {
        public static DescribeSignatureStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSignatureStatisticsResponse describeSignatureStatisticsResponse = new DescribeSignatureStatisticsResponse();

			describeSignatureStatisticsResponse.HttpResponse = context.HttpResponse;
			describeSignatureStatisticsResponse.RequestId = context.StringValue("DescribeSignatureStatistics.RequestId");
			describeSignatureStatisticsResponse.UnSignCount = context.IntegerValue("DescribeSignatureStatistics.UnSignCount");
			describeSignatureStatisticsResponse.SignCount = context.IntegerValue("DescribeSignatureStatistics.SignCount");
			describeSignatureStatisticsResponse.FailCount = context.IntegerValue("DescribeSignatureStatistics.FailCount");

			List<DescribeSignatureStatisticsResponse.DescribeSignatureStatistics_DayData> describeSignatureStatisticsResponse_dayDataList = new List<DescribeSignatureStatisticsResponse.DescribeSignatureStatistics_DayData>();
			for (int i = 0; i < context.Length("DescribeSignatureStatistics.DayDataList.Length"); i++) {
				DescribeSignatureStatisticsResponse.DescribeSignatureStatistics_DayData dayData = new DescribeSignatureStatisticsResponse.DescribeSignatureStatistics_DayData();
				dayData.Date = context.StringValue("DescribeSignatureStatistics.DayDataList["+ i +"].Date");
				dayData.UnSignCount = context.IntegerValue("DescribeSignatureStatistics.DayDataList["+ i +"].UnSignCount");
				dayData.SignCount = context.IntegerValue("DescribeSignatureStatistics.DayDataList["+ i +"].SignCount");
				dayData.FailCount = context.IntegerValue("DescribeSignatureStatistics.DayDataList["+ i +"].FailCount");

				describeSignatureStatisticsResponse_dayDataList.Add(dayData);
			}
			describeSignatureStatisticsResponse.DayDataList = describeSignatureStatisticsResponse_dayDataList;
        
			return describeSignatureStatisticsResponse;
        }
    }
}
