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
    public class DescribeCostBudgetsSummaryResponseUnmarshaller
    {
        public static DescribeCostBudgetsSummaryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCostBudgetsSummaryResponse describeCostBudgetsSummaryResponse = new DescribeCostBudgetsSummaryResponse();

			describeCostBudgetsSummaryResponse.HttpResponse = _ctx.HttpResponse;
			describeCostBudgetsSummaryResponse.RequestId = _ctx.StringValue("DescribeCostBudgetsSummary.RequestId");
			describeCostBudgetsSummaryResponse.Success = _ctx.BooleanValue("DescribeCostBudgetsSummary.Success");
			describeCostBudgetsSummaryResponse.Code = _ctx.StringValue("DescribeCostBudgetsSummary.Code");
			describeCostBudgetsSummaryResponse.Message = _ctx.StringValue("DescribeCostBudgetsSummary.Message");

			DescribeCostBudgetsSummaryResponse.DescribeCostBudgetsSummary_Data data = new DescribeCostBudgetsSummaryResponse.DescribeCostBudgetsSummary_Data();
			data.NextToken = _ctx.StringValue("DescribeCostBudgetsSummary.Data.NextToken");
			data.MaxResults = _ctx.IntegerValue("DescribeCostBudgetsSummary.Data.MaxResults");
			data.TotalCount = _ctx.IntegerValue("DescribeCostBudgetsSummary.Data.TotalCount");
			data.HostId = _ctx.StringValue("DescribeCostBudgetsSummary.Data.HostId");

			List<DescribeCostBudgetsSummaryResponse.DescribeCostBudgetsSummary_Data.DescribeCostBudgetsSummary_Item> data_items = new List<DescribeCostBudgetsSummaryResponse.DescribeCostBudgetsSummary_Data.DescribeCostBudgetsSummary_Item>();
			for (int i = 0; i < _ctx.Length("DescribeCostBudgetsSummary.Data.Items.Length"); i++) {
				DescribeCostBudgetsSummaryResponse.DescribeCostBudgetsSummary_Data.DescribeCostBudgetsSummary_Item item = new DescribeCostBudgetsSummaryResponse.DescribeCostBudgetsSummary_Data.DescribeCostBudgetsSummary_Item();
				item.BudgetName = _ctx.StringValue("DescribeCostBudgetsSummary.Data.Items["+ i +"].BudgetName");
				item.BudgetStatus = _ctx.StringValue("DescribeCostBudgetsSummary.Data.Items["+ i +"].BudgetStatus");
				item.BudgetType = _ctx.StringValue("DescribeCostBudgetsSummary.Data.Items["+ i +"].BudgetType");
				item.Budget = _ctx.StringValue("DescribeCostBudgetsSummary.Data.Items["+ i +"].Budget");
				item.CalculatedValues = _ctx.StringValue("DescribeCostBudgetsSummary.Data.Items["+ i +"].CalculatedValues");
				item.ConsumePeriod = _ctx.StringValue("DescribeCostBudgetsSummary.Data.Items["+ i +"].ConsumePeriod");

				data_items.Add(item);
			}
			data.Items = data_items;
			describeCostBudgetsSummaryResponse.Data = data;
        
			return describeCostBudgetsSummaryResponse;
        }
    }
}
