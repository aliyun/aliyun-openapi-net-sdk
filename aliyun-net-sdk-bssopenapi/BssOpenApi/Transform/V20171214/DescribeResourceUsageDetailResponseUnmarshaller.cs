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
    public class DescribeResourceUsageDetailResponseUnmarshaller
    {
        public static DescribeResourceUsageDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeResourceUsageDetailResponse describeResourceUsageDetailResponse = new DescribeResourceUsageDetailResponse();

			describeResourceUsageDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeResourceUsageDetailResponse.Code = _ctx.StringValue("DescribeResourceUsageDetail.Code");
			describeResourceUsageDetailResponse.Message = _ctx.StringValue("DescribeResourceUsageDetail.Message");
			describeResourceUsageDetailResponse.RequestId = _ctx.StringValue("DescribeResourceUsageDetail.RequestId");
			describeResourceUsageDetailResponse.Success = _ctx.BooleanValue("DescribeResourceUsageDetail.Success");

			DescribeResourceUsageDetailResponse.DescribeResourceUsageDetail_Data data = new DescribeResourceUsageDetailResponse.DescribeResourceUsageDetail_Data();
			data.NextToken = _ctx.StringValue("DescribeResourceUsageDetail.Data.NextToken");
			data.TotalCount = _ctx.IntegerValue("DescribeResourceUsageDetail.Data.TotalCount");
			data.MaxResults = _ctx.IntegerValue("DescribeResourceUsageDetail.Data.MaxResults");

			List<DescribeResourceUsageDetailResponse.DescribeResourceUsageDetail_Data.DescribeResourceUsageDetail_Item> data_items = new List<DescribeResourceUsageDetailResponse.DescribeResourceUsageDetail_Data.DescribeResourceUsageDetail_Item>();
			for (int i = 0; i < _ctx.Length("DescribeResourceUsageDetail.Data.Items.Length"); i++) {
				DescribeResourceUsageDetailResponse.DescribeResourceUsageDetail_Data.DescribeResourceUsageDetail_Item item = new DescribeResourceUsageDetailResponse.DescribeResourceUsageDetail_Data.DescribeResourceUsageDetail_Item();
				item.Status = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].Status");
				item.UsagePercentage = _ctx.FloatValue("DescribeResourceUsageDetail.Data.Items["+ i +"].UsagePercentage");
				item.ResourceInstanceId = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].ResourceInstanceId");
				item.TotalQuantity = _ctx.FloatValue("DescribeResourceUsageDetail.Data.Items["+ i +"].TotalQuantity");
				item.ReservationCost = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].ReservationCost");
				item.RegionNo = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].RegionNo");
				item.UserId = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].UserId");
				item.StatusName = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].StatusName");
				item.CapacityUnit = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].CapacityUnit");
				item.PotentialSavedCost = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].PotentialSavedCost");
				item.Currency = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].Currency");
				item.ZoneName = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].ZoneName");
				item.InstanceSpec = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].InstanceSpec");
				item.EndTime = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].EndTime");
				item.PostpaidCost = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].PostpaidCost");
				item.ImageType = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].ImageType");
				item.StartTime = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].StartTime");
				item.Region = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].Region");
				item.DeductQuantity = _ctx.FloatValue("DescribeResourceUsageDetail.Data.Items["+ i +"].DeductQuantity");
				item.SavedCost = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].SavedCost");
				item.Zone = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].Zone");
				item.UserName = _ctx.StringValue("DescribeResourceUsageDetail.Data.Items["+ i +"].UserName");
				item.Quantity = _ctx.LongValue("DescribeResourceUsageDetail.Data.Items["+ i +"].Quantity");

				data_items.Add(item);
			}
			data.Items = data_items;
			describeResourceUsageDetailResponse.Data = data;
        
			return describeResourceUsageDetailResponse;
        }
    }
}
