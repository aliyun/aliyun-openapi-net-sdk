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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class GetPatentStatisticsDetailListResponseUnmarshaller
    {
        public static GetPatentStatisticsDetailListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPatentStatisticsDetailListResponse getPatentStatisticsDetailListResponse = new GetPatentStatisticsDetailListResponse();

			getPatentStatisticsDetailListResponse.HttpResponse = _ctx.HttpResponse;
			getPatentStatisticsDetailListResponse.PageNum = _ctx.IntegerValue("GetPatentStatisticsDetailList.PageNum");
			getPatentStatisticsDetailListResponse.PageSize = _ctx.IntegerValue("GetPatentStatisticsDetailList.PageSize");
			getPatentStatisticsDetailListResponse.RequestId = _ctx.StringValue("GetPatentStatisticsDetailList.RequestId");
			getPatentStatisticsDetailListResponse.Success = _ctx.BooleanValue("GetPatentStatisticsDetailList.Success");
			getPatentStatisticsDetailListResponse.TotalItemNum = _ctx.IntegerValue("GetPatentStatisticsDetailList.TotalItemNum");
			getPatentStatisticsDetailListResponse.TotalPageNum = _ctx.IntegerValue("GetPatentStatisticsDetailList.TotalPageNum");

			List<GetPatentStatisticsDetailListResponse.GetPatentStatisticsDetailList_DataItem> getPatentStatisticsDetailListResponse_data = new List<GetPatentStatisticsDetailListResponse.GetPatentStatisticsDetailList_DataItem>();
			for (int i = 0; i < _ctx.Length("GetPatentStatisticsDetailList.Data.Length"); i++) {
				GetPatentStatisticsDetailListResponse.GetPatentStatisticsDetailList_DataItem dataItem = new GetPatentStatisticsDetailListResponse.GetPatentStatisticsDetailList_DataItem();
				dataItem.Age = _ctx.StringValue("GetPatentStatisticsDetailList.Data["+ i +"].Age");
				dataItem.Agency = _ctx.StringValue("GetPatentStatisticsDetailList.Data["+ i +"].Agency");
				dataItem.ApplyNumber = _ctx.StringValue("GetPatentStatisticsDetailList.Data["+ i +"].ApplyNumber");
				dataItem.Discount = _ctx.StringValue("GetPatentStatisticsDetailList.Data["+ i +"].Discount");
				dataItem.DiscountPrice = _ctx.FloatValue("GetPatentStatisticsDetailList.Data["+ i +"].DiscountPrice");
				dataItem.Name = _ctx.StringValue("GetPatentStatisticsDetailList.Data["+ i +"].Name");
				dataItem.Owner = _ctx.StringValue("GetPatentStatisticsDetailList.Data["+ i +"].Owner");
				dataItem.PayEndDate = _ctx.StringValue("GetPatentStatisticsDetailList.Data["+ i +"].PayEndDate");
				dataItem.SalePrice = _ctx.FloatValue("GetPatentStatisticsDetailList.Data["+ i +"].SalePrice");
				dataItem.Type = _ctx.StringValue("GetPatentStatisticsDetailList.Data["+ i +"].Type");
				dataItem.Year = _ctx.IntegerValue("GetPatentStatisticsDetailList.Data["+ i +"].Year");
				dataItem.Status = _ctx.StringValue("GetPatentStatisticsDetailList.Data["+ i +"].Status");

				getPatentStatisticsDetailListResponse_data.Add(dataItem);
			}
			getPatentStatisticsDetailListResponse.Data = getPatentStatisticsDetailListResponse_data;
        
			return getPatentStatisticsDetailListResponse;
        }
    }
}
