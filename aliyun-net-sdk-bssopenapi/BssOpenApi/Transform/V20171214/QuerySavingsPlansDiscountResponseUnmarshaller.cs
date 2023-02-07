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
    public class QuerySavingsPlansDiscountResponseUnmarshaller
    {
        public static QuerySavingsPlansDiscountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySavingsPlansDiscountResponse querySavingsPlansDiscountResponse = new QuerySavingsPlansDiscountResponse();

			querySavingsPlansDiscountResponse.HttpResponse = _ctx.HttpResponse;
			querySavingsPlansDiscountResponse.Message = _ctx.StringValue("QuerySavingsPlansDiscount.Message");
			querySavingsPlansDiscountResponse.RequestId = _ctx.StringValue("QuerySavingsPlansDiscount.RequestId");
			querySavingsPlansDiscountResponse.Code = _ctx.StringValue("QuerySavingsPlansDiscount.Code");
			querySavingsPlansDiscountResponse.Success = _ctx.BooleanValue("QuerySavingsPlansDiscount.Success");

			QuerySavingsPlansDiscountResponse.QuerySavingsPlansDiscount_Data data = new QuerySavingsPlansDiscountResponse.QuerySavingsPlansDiscount_Data();
			data.HostId = _ctx.StringValue("QuerySavingsPlansDiscount.Data.HostId");

			List<QuerySavingsPlansDiscountResponse.QuerySavingsPlansDiscount_Data.QuerySavingsPlansDiscount_SavingsPlansDiscountResponse> data_items = new List<QuerySavingsPlansDiscountResponse.QuerySavingsPlansDiscount_Data.QuerySavingsPlansDiscount_SavingsPlansDiscountResponse>();
			for (int i = 0; i < _ctx.Length("QuerySavingsPlansDiscount.Data.Items.Length"); i++) {
				QuerySavingsPlansDiscountResponse.QuerySavingsPlansDiscount_Data.QuerySavingsPlansDiscount_SavingsPlansDiscountResponse savingsPlansDiscountResponse = new QuerySavingsPlansDiscountResponse.QuerySavingsPlansDiscount_Data.QuerySavingsPlansDiscount_SavingsPlansDiscountResponse();
				savingsPlansDiscountResponse.CommodityName = _ctx.StringValue("QuerySavingsPlansDiscount.Data.Items["+ i +"].CommodityName");
				savingsPlansDiscountResponse.ModuleName = _ctx.StringValue("QuerySavingsPlansDiscount.Data.Items["+ i +"].ModuleName");
				savingsPlansDiscountResponse.SpnType = _ctx.StringValue("QuerySavingsPlansDiscount.Data.Items["+ i +"].SpnType");
				savingsPlansDiscountResponse.PayMode = _ctx.StringValue("QuerySavingsPlansDiscount.Data.Items["+ i +"].PayMode");
				savingsPlansDiscountResponse.Cycle = _ctx.StringValue("QuerySavingsPlansDiscount.Data.Items["+ i +"].Cycle");
				savingsPlansDiscountResponse.Region = _ctx.StringValue("QuerySavingsPlansDiscount.Data.Items["+ i +"].Region");
				savingsPlansDiscountResponse.Spec = _ctx.StringValue("QuerySavingsPlansDiscount.Data.Items["+ i +"].Spec");
				savingsPlansDiscountResponse.DiscountRate = _ctx.StringValue("QuerySavingsPlansDiscount.Data.Items["+ i +"].DiscountRate");
				savingsPlansDiscountResponse.ContractDiscountRate = _ctx.StringValue("QuerySavingsPlansDiscount.Data.Items["+ i +"].ContractDiscountRate");

				data_items.Add(savingsPlansDiscountResponse);
			}
			data.Items = data_items;
			querySavingsPlansDiscountResponse.Data = data;
        
			return querySavingsPlansDiscountResponse;
        }
    }
}
