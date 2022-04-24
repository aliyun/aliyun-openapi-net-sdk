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
    public class DescribeSavingsPlansUsageTotalResponseUnmarshaller
    {
        public static DescribeSavingsPlansUsageTotalResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSavingsPlansUsageTotalResponse describeSavingsPlansUsageTotalResponse = new DescribeSavingsPlansUsageTotalResponse();

			describeSavingsPlansUsageTotalResponse.HttpResponse = _ctx.HttpResponse;
			describeSavingsPlansUsageTotalResponse.Code = _ctx.StringValue("DescribeSavingsPlansUsageTotal.Code");
			describeSavingsPlansUsageTotalResponse.Message = _ctx.StringValue("DescribeSavingsPlansUsageTotal.Message");
			describeSavingsPlansUsageTotalResponse.RequestId = _ctx.StringValue("DescribeSavingsPlansUsageTotal.RequestId");
			describeSavingsPlansUsageTotalResponse.Success = _ctx.BooleanValue("DescribeSavingsPlansUsageTotal.Success");

			DescribeSavingsPlansUsageTotalResponse.DescribeSavingsPlansUsageTotal_Data data = new DescribeSavingsPlansUsageTotalResponse.DescribeSavingsPlansUsageTotal_Data();

			DescribeSavingsPlansUsageTotalResponse.DescribeSavingsPlansUsageTotal_Data.DescribeSavingsPlansUsageTotal_TotalUsage totalUsage = new DescribeSavingsPlansUsageTotalResponse.DescribeSavingsPlansUsageTotal_Data.DescribeSavingsPlansUsageTotal_TotalUsage();
			totalUsage.PostpaidCost = _ctx.FloatValue("DescribeSavingsPlansUsageTotal.Data.TotalUsage.PostpaidCost");
			totalUsage.SavedCost = _ctx.FloatValue("DescribeSavingsPlansUsageTotal.Data.TotalUsage.SavedCost");
			totalUsage.UsagePercentage = _ctx.FloatValue("DescribeSavingsPlansUsageTotal.Data.TotalUsage.UsagePercentage");
			totalUsage.PoolValue = _ctx.FloatValue("DescribeSavingsPlansUsageTotal.Data.TotalUsage.PoolValue");
			data.TotalUsage = totalUsage;

			List<DescribeSavingsPlansUsageTotalResponse.DescribeSavingsPlansUsageTotal_Data.DescribeSavingsPlansUsageTotal_Item> data_periodCoverage = new List<DescribeSavingsPlansUsageTotalResponse.DescribeSavingsPlansUsageTotal_Data.DescribeSavingsPlansUsageTotal_Item>();
			for (int i = 0; i < _ctx.Length("DescribeSavingsPlansUsageTotal.Data.PeriodCoverage.Length"); i++) {
				DescribeSavingsPlansUsageTotalResponse.DescribeSavingsPlansUsageTotal_Data.DescribeSavingsPlansUsageTotal_Item item = new DescribeSavingsPlansUsageTotalResponse.DescribeSavingsPlansUsageTotal_Data.DescribeSavingsPlansUsageTotal_Item();
				item.Percentage = _ctx.FloatValue("DescribeSavingsPlansUsageTotal.Data.PeriodCoverage["+ i +"].Percentage");
				item.Period = _ctx.StringValue("DescribeSavingsPlansUsageTotal.Data.PeriodCoverage["+ i +"].Period");

				data_periodCoverage.Add(item);
			}
			data.PeriodCoverage = data_periodCoverage;
			describeSavingsPlansUsageTotalResponse.Data = data;
        
			return describeSavingsPlansUsageTotalResponse;
        }
    }
}
