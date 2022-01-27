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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class DescribeResourceUsageTotalResponseUnmarshaller
    {
        public static DescribeResourceUsageTotalResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeResourceUsageTotalResponse describeResourceUsageTotalResponse = new DescribeResourceUsageTotalResponse();

			describeResourceUsageTotalResponse.HttpResponse = _ctx.HttpResponse;
			describeResourceUsageTotalResponse.RequestId = _ctx.StringValue("DescribeResourceUsageTotal.RequestId");
			describeResourceUsageTotalResponse.Success = _ctx.BooleanValue("DescribeResourceUsageTotal.Success");
			describeResourceUsageTotalResponse.Code = _ctx.StringValue("DescribeResourceUsageTotal.Code");
			describeResourceUsageTotalResponse.Message = _ctx.StringValue("DescribeResourceUsageTotal.Message");

			DescribeResourceUsageTotalResponse.DescribeResourceUsageTotal_Data data = new DescribeResourceUsageTotalResponse.DescribeResourceUsageTotal_Data();

			DescribeResourceUsageTotalResponse.DescribeResourceUsageTotal_Data.DescribeResourceUsageTotal_TotalUsage totalUsage = new DescribeResourceUsageTotalResponse.DescribeResourceUsageTotal_Data.DescribeResourceUsageTotal_TotalUsage();
			totalUsage.UsagePercentage = _ctx.FloatValue("DescribeResourceUsageTotal.Data.TotalUsage.UsagePercentage");
			totalUsage.PostpaidCost = _ctx.FloatValue("DescribeResourceUsageTotal.Data.TotalUsage.PostpaidCost");
			totalUsage.ReservationCost = _ctx.FloatValue("DescribeResourceUsageTotal.Data.TotalUsage.ReservationCost");
			totalUsage.SavedCost = _ctx.FloatValue("DescribeResourceUsageTotal.Data.TotalUsage.SavedCost");
			totalUsage.PotentialSavedCost = _ctx.FloatValue("DescribeResourceUsageTotal.Data.TotalUsage.PotentialSavedCost");
			data.TotalUsage = totalUsage;

			List<DescribeResourceUsageTotalResponse.DescribeResourceUsageTotal_Data.DescribeResourceUsageTotal_Item> data_periodCoverage = new List<DescribeResourceUsageTotalResponse.DescribeResourceUsageTotal_Data.DescribeResourceUsageTotal_Item>();
			for (int i = 0; i < _ctx.Length("DescribeResourceUsageTotal.Data.PeriodCoverage.Length"); i++) {
				DescribeResourceUsageTotalResponse.DescribeResourceUsageTotal_Data.DescribeResourceUsageTotal_Item item = new DescribeResourceUsageTotalResponse.DescribeResourceUsageTotal_Data.DescribeResourceUsageTotal_Item();
				item.Period = _ctx.StringValue("DescribeResourceUsageTotal.Data.PeriodCoverage["+ i +"].Period");
				item.UsagePercentage = _ctx.FloatValue("DescribeResourceUsageTotal.Data.PeriodCoverage["+ i +"].UsagePercentage");

				data_periodCoverage.Add(item);
			}
			data.PeriodCoverage = data_periodCoverage;
			describeResourceUsageTotalResponse.Data = data;
        
			return describeResourceUsageTotalResponse;
        }
    }
}
