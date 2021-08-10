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
    public class DescribeSavingsPlansUsageDetailResponseUnmarshaller
    {
        public static DescribeSavingsPlansUsageDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSavingsPlansUsageDetailResponse describeSavingsPlansUsageDetailResponse = new DescribeSavingsPlansUsageDetailResponse();

			describeSavingsPlansUsageDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeSavingsPlansUsageDetailResponse.RequestId = _ctx.StringValue("DescribeSavingsPlansUsageDetail.RequestId");
			describeSavingsPlansUsageDetailResponse.Success = _ctx.BooleanValue("DescribeSavingsPlansUsageDetail.Success");
			describeSavingsPlansUsageDetailResponse.Code = _ctx.StringValue("DescribeSavingsPlansUsageDetail.Code");
			describeSavingsPlansUsageDetailResponse.Message = _ctx.StringValue("DescribeSavingsPlansUsageDetail.Message");

			DescribeSavingsPlansUsageDetailResponse.DescribeSavingsPlansUsageDetail_Data data = new DescribeSavingsPlansUsageDetailResponse.DescribeSavingsPlansUsageDetail_Data();
			data.TotalCount = _ctx.IntegerValue("DescribeSavingsPlansUsageDetail.Data.TotalCount");
			data.NextToken = _ctx.StringValue("DescribeSavingsPlansUsageDetail.Data.NextToken");

			List<DescribeSavingsPlansUsageDetailResponse.DescribeSavingsPlansUsageDetail_Data.DescribeSavingsPlansUsageDetail_Item> data_items = new List<DescribeSavingsPlansUsageDetailResponse.DescribeSavingsPlansUsageDetail_Data.DescribeSavingsPlansUsageDetail_Item>();
			for (int i = 0; i < _ctx.Length("DescribeSavingsPlansUsageDetail.Data.Items.Length"); i++) {
				DescribeSavingsPlansUsageDetailResponse.DescribeSavingsPlansUsageDetail_Data.DescribeSavingsPlansUsageDetail_Item item = new DescribeSavingsPlansUsageDetailResponse.DescribeSavingsPlansUsageDetail_Data.DescribeSavingsPlansUsageDetail_Item();
				item.UserId = _ctx.LongValue("DescribeSavingsPlansUsageDetail.Data.Items["+ i +"].UserId");
				item.UserName = _ctx.StringValue("DescribeSavingsPlansUsageDetail.Data.Items["+ i +"].UserName");
				item.InstanceId = _ctx.StringValue("DescribeSavingsPlansUsageDetail.Data.Items["+ i +"].InstanceId");
				item.StartPeriod = _ctx.StringValue("DescribeSavingsPlansUsageDetail.Data.Items["+ i +"].StartPeriod");
				item.EndPeriod = _ctx.StringValue("DescribeSavingsPlansUsageDetail.Data.Items["+ i +"].EndPeriod");
				item.Status = _ctx.StringValue("DescribeSavingsPlansUsageDetail.Data.Items["+ i +"].Status");
				item.Type = _ctx.StringValue("DescribeSavingsPlansUsageDetail.Data.Items["+ i +"].Type");
				item.UsagePercentage = _ctx.FloatValue("DescribeSavingsPlansUsageDetail.Data.Items["+ i +"].UsagePercentage");
				item.PoolValue = _ctx.FloatValue("DescribeSavingsPlansUsageDetail.Data.Items["+ i +"].PoolValue");
				item.DeductValue = _ctx.FloatValue("DescribeSavingsPlansUsageDetail.Data.Items["+ i +"].DeductValue");
				item.PostpaidCost = _ctx.FloatValue("DescribeSavingsPlansUsageDetail.Data.Items["+ i +"].PostpaidCost");
				item.SavedCost = _ctx.FloatValue("DescribeSavingsPlansUsageDetail.Data.Items["+ i +"].SavedCost");
				item.Currency = _ctx.StringValue("DescribeSavingsPlansUsageDetail.Data.Items["+ i +"].Currency");

				data_items.Add(item);
			}
			data.Items = data_items;
			describeSavingsPlansUsageDetailResponse.Data = data;
        
			return describeSavingsPlansUsageDetailResponse;
        }
    }
}
