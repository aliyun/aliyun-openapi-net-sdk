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
    public class DescribeSavingsPlansCoverageDetailResponseUnmarshaller
    {
        public static DescribeSavingsPlansCoverageDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSavingsPlansCoverageDetailResponse describeSavingsPlansCoverageDetailResponse = new DescribeSavingsPlansCoverageDetailResponse();

			describeSavingsPlansCoverageDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeSavingsPlansCoverageDetailResponse.Code = _ctx.StringValue("DescribeSavingsPlansCoverageDetail.Code");
			describeSavingsPlansCoverageDetailResponse.Message = _ctx.StringValue("DescribeSavingsPlansCoverageDetail.Message");
			describeSavingsPlansCoverageDetailResponse.RequestId = _ctx.StringValue("DescribeSavingsPlansCoverageDetail.RequestId");
			describeSavingsPlansCoverageDetailResponse.Success = _ctx.BooleanValue("DescribeSavingsPlansCoverageDetail.Success");

			DescribeSavingsPlansCoverageDetailResponse.DescribeSavingsPlansCoverageDetail_Data data = new DescribeSavingsPlansCoverageDetailResponse.DescribeSavingsPlansCoverageDetail_Data();
			data.TotalCount = _ctx.IntegerValue("DescribeSavingsPlansCoverageDetail.Data.TotalCount");
			data.NextToken = _ctx.StringValue("DescribeSavingsPlansCoverageDetail.Data.NextToken");

			List<DescribeSavingsPlansCoverageDetailResponse.DescribeSavingsPlansCoverageDetail_Data.DescribeSavingsPlansCoverageDetail_Item> data_items = new List<DescribeSavingsPlansCoverageDetailResponse.DescribeSavingsPlansCoverageDetail_Data.DescribeSavingsPlansCoverageDetail_Item>();
			for (int i = 0; i < _ctx.Length("DescribeSavingsPlansCoverageDetail.Data.Items.Length"); i++) {
				DescribeSavingsPlansCoverageDetailResponse.DescribeSavingsPlansCoverageDetail_Data.DescribeSavingsPlansCoverageDetail_Item item = new DescribeSavingsPlansCoverageDetailResponse.DescribeSavingsPlansCoverageDetail_Data.DescribeSavingsPlansCoverageDetail_Item();
				item.UserId = _ctx.LongValue("DescribeSavingsPlansCoverageDetail.Data.Items["+ i +"].UserId");
				item.InstanceId = _ctx.StringValue("DescribeSavingsPlansCoverageDetail.Data.Items["+ i +"].InstanceId");
				item.Currency = _ctx.StringValue("DescribeSavingsPlansCoverageDetail.Data.Items["+ i +"].Currency");
				item.InstanceSpec = _ctx.StringValue("DescribeSavingsPlansCoverageDetail.Data.Items["+ i +"].InstanceSpec");
				item.PostpaidCost = _ctx.FloatValue("DescribeSavingsPlansCoverageDetail.Data.Items["+ i +"].PostpaidCost");
				item.CoveragePercentage = _ctx.FloatValue("DescribeSavingsPlansCoverageDetail.Data.Items["+ i +"].CoveragePercentage");
				item.Region = _ctx.StringValue("DescribeSavingsPlansCoverageDetail.Data.Items["+ i +"].Region");
				item.DeductAmount = _ctx.FloatValue("DescribeSavingsPlansCoverageDetail.Data.Items["+ i +"].DeductAmount");
				item.StartPeriod = _ctx.StringValue("DescribeSavingsPlansCoverageDetail.Data.Items["+ i +"].StartPeriod");
				item.TotalAmount = _ctx.FloatValue("DescribeSavingsPlansCoverageDetail.Data.Items["+ i +"].TotalAmount");
				item.UserName = _ctx.StringValue("DescribeSavingsPlansCoverageDetail.Data.Items["+ i +"].UserName");
				item.EndPeriod = _ctx.StringValue("DescribeSavingsPlansCoverageDetail.Data.Items["+ i +"].EndPeriod");

				data_items.Add(item);
			}
			data.Items = data_items;
			describeSavingsPlansCoverageDetailResponse.Data = data;
        
			return describeSavingsPlansCoverageDetailResponse;
        }
    }
}
