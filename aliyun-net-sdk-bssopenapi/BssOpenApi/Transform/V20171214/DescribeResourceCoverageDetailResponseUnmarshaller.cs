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
    public class DescribeResourceCoverageDetailResponseUnmarshaller
    {
        public static DescribeResourceCoverageDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeResourceCoverageDetailResponse describeResourceCoverageDetailResponse = new DescribeResourceCoverageDetailResponse();

			describeResourceCoverageDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeResourceCoverageDetailResponse.RequestId = _ctx.StringValue("DescribeResourceCoverageDetail.RequestId");
			describeResourceCoverageDetailResponse.Success = _ctx.BooleanValue("DescribeResourceCoverageDetail.Success");
			describeResourceCoverageDetailResponse.Code = _ctx.StringValue("DescribeResourceCoverageDetail.Code");
			describeResourceCoverageDetailResponse.Message = _ctx.StringValue("DescribeResourceCoverageDetail.Message");

			DescribeResourceCoverageDetailResponse.DescribeResourceCoverageDetail_Data data = new DescribeResourceCoverageDetailResponse.DescribeResourceCoverageDetail_Data();
			data.TotalCount = _ctx.IntegerValue("DescribeResourceCoverageDetail.Data.TotalCount");
			data.NextToken = _ctx.StringValue("DescribeResourceCoverageDetail.Data.NextToken");
			data.MaxResults = _ctx.IntegerValue("DescribeResourceCoverageDetail.Data.MaxResults");

			List<DescribeResourceCoverageDetailResponse.DescribeResourceCoverageDetail_Data.DescribeResourceCoverageDetail_Item> data_items = new List<DescribeResourceCoverageDetailResponse.DescribeResourceCoverageDetail_Data.DescribeResourceCoverageDetail_Item>();
			for (int i = 0; i < _ctx.Length("DescribeResourceCoverageDetail.Data.Items.Length"); i++) {
				DescribeResourceCoverageDetailResponse.DescribeResourceCoverageDetail_Data.DescribeResourceCoverageDetail_Item item = new DescribeResourceCoverageDetailResponse.DescribeResourceCoverageDetail_Data.DescribeResourceCoverageDetail_Item();
				item.UserId = _ctx.StringValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].UserId");
				item.UserName = _ctx.StringValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].UserName");
				item.ProductCode = _ctx.StringValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].ProductCode");
				item.ProductName = _ctx.StringValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].ProductName");
				item.CommodityCode = _ctx.StringValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].CommodityCode");
				item.CommodityName = _ctx.StringValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].CommodityName");
				item.InstanceId = _ctx.StringValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].InstanceId");
				item.Region = _ctx.StringValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].Region");
				item.RegionNo = _ctx.StringValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].RegionNo");
				item.Zone = _ctx.StringValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].Zone");
				item.ZoneName = _ctx.StringValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].ZoneName");
				item.InstanceSpec = _ctx.StringValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].InstanceSpec");
				item.Currency = _ctx.StringValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].Currency");
				item.CoveragePercentage = _ctx.FloatValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].CoveragePercentage");
				item.PaymentAmount = _ctx.FloatValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].PaymentAmount");
				item.DeductQuantity = _ctx.FloatValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].DeductQuantity");
				item.TotalQuantity = _ctx.FloatValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].TotalQuantity");
				item.CapacityUnit = _ctx.StringValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].CapacityUnit");
				item.StartTime = _ctx.StringValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].StartTime");
				item.EndTime = _ctx.StringValue("DescribeResourceCoverageDetail.Data.Items["+ i +"].EndTime");

				data_items.Add(item);
			}
			data.Items = data_items;
			describeResourceCoverageDetailResponse.Data = data;
        
			return describeResourceCoverageDetailResponse;
        }
    }
}
