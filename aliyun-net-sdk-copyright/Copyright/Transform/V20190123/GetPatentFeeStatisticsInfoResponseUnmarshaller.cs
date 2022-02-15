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
    public class GetPatentFeeStatisticsInfoResponseUnmarshaller
    {
        public static GetPatentFeeStatisticsInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPatentFeeStatisticsInfoResponse getPatentFeeStatisticsInfoResponse = new GetPatentFeeStatisticsInfoResponse();

			getPatentFeeStatisticsInfoResponse.HttpResponse = _ctx.HttpResponse;
			getPatentFeeStatisticsInfoResponse.RequestId = _ctx.StringValue("GetPatentFeeStatisticsInfo.RequestId");
			getPatentFeeStatisticsInfoResponse.Success = _ctx.BooleanValue("GetPatentFeeStatisticsInfo.Success");

			GetPatentFeeStatisticsInfoResponse.GetPatentFeeStatisticsInfo_Data data = new GetPatentFeeStatisticsInfoResponse.GetPatentFeeStatisticsInfo_Data();
			data.DiscountPrice = _ctx.FloatValue("GetPatentFeeStatisticsInfo.Data.DiscountPrice");
			data.FamingCount = _ctx.IntegerValue("GetPatentFeeStatisticsInfo.Data.FamingCount");
			data.FreeCount = _ctx.IntegerValue("GetPatentFeeStatisticsInfo.Data.FreeCount");
			data.ShiyongCount = _ctx.IntegerValue("GetPatentFeeStatisticsInfo.Data.ShiyongCount");
			data.Total = _ctx.IntegerValue("GetPatentFeeStatisticsInfo.Data.Total");
			data.TotalPrice = _ctx.FloatValue("GetPatentFeeStatisticsInfo.Data.TotalPrice");
			data.UsedCount = _ctx.IntegerValue("GetPatentFeeStatisticsInfo.Data.UsedCount");
			data.UserType = _ctx.StringValue("GetPatentFeeStatisticsInfo.Data.UserType");
			data.WaiguanCount = _ctx.IntegerValue("GetPatentFeeStatisticsInfo.Data.WaiguanCount");

			List<GetPatentFeeStatisticsInfoResponse.GetPatentFeeStatisticsInfo_Data.GetPatentFeeStatisticsInfo_AgeInfoItem> data_ageInfo = new List<GetPatentFeeStatisticsInfoResponse.GetPatentFeeStatisticsInfo_Data.GetPatentFeeStatisticsInfo_AgeInfoItem>();
			for (int i = 0; i < _ctx.Length("GetPatentFeeStatisticsInfo.Data.AgeInfo.Length"); i++) {
				GetPatentFeeStatisticsInfoResponse.GetPatentFeeStatisticsInfo_Data.GetPatentFeeStatisticsInfo_AgeInfoItem ageInfoItem = new GetPatentFeeStatisticsInfoResponse.GetPatentFeeStatisticsInfo_Data.GetPatentFeeStatisticsInfo_AgeInfoItem();
				ageInfoItem.Age = _ctx.StringValue("GetPatentFeeStatisticsInfo.Data.AgeInfo["+ i +"].Age");
				ageInfoItem.Count = _ctx.IntegerValue("GetPatentFeeStatisticsInfo.Data.AgeInfo["+ i +"].Count");
				ageInfoItem.DiscountPrice = _ctx.FloatValue("GetPatentFeeStatisticsInfo.Data.AgeInfo["+ i +"].DiscountPrice");
				ageInfoItem.SalePrice = _ctx.FloatValue("GetPatentFeeStatisticsInfo.Data.AgeInfo["+ i +"].SalePrice");
				ageInfoItem.Type = _ctx.StringValue("GetPatentFeeStatisticsInfo.Data.AgeInfo["+ i +"].Type");

				data_ageInfo.Add(ageInfoItem);
			}
			data.AgeInfo = data_ageInfo;
			getPatentFeeStatisticsInfoResponse.Data = data;
        
			return getPatentFeeStatisticsInfoResponse;
        }
    }
}
