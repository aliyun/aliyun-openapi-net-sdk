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
    public class GetPatentTimeStatisticsInfoResponseUnmarshaller
    {
        public static GetPatentTimeStatisticsInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPatentTimeStatisticsInfoResponse getPatentTimeStatisticsInfoResponse = new GetPatentTimeStatisticsInfoResponse();

			getPatentTimeStatisticsInfoResponse.HttpResponse = _ctx.HttpResponse;
			getPatentTimeStatisticsInfoResponse.PageNum = _ctx.IntegerValue("GetPatentTimeStatisticsInfo.PageNum");
			getPatentTimeStatisticsInfoResponse.RequestId = _ctx.StringValue("GetPatentTimeStatisticsInfo.RequestId");
			getPatentTimeStatisticsInfoResponse.Success = _ctx.BooleanValue("GetPatentTimeStatisticsInfo.Success");
			getPatentTimeStatisticsInfoResponse.TotalItemNum = _ctx.IntegerValue("GetPatentTimeStatisticsInfo.TotalItemNum");
			getPatentTimeStatisticsInfoResponse.PageSize = _ctx.IntegerValue("GetPatentTimeStatisticsInfo.PageSize");
			getPatentTimeStatisticsInfoResponse.TotalPageNum = _ctx.IntegerValue("GetPatentTimeStatisticsInfo.TotalPageNum");

			List<GetPatentTimeStatisticsInfoResponse.GetPatentTimeStatisticsInfo_DataItem> getPatentTimeStatisticsInfoResponse_data = new List<GetPatentTimeStatisticsInfoResponse.GetPatentTimeStatisticsInfo_DataItem>();
			for (int i = 0; i < _ctx.Length("GetPatentTimeStatisticsInfo.Data.Length"); i++) {
				GetPatentTimeStatisticsInfoResponse.GetPatentTimeStatisticsInfo_DataItem dataItem = new GetPatentTimeStatisticsInfoResponse.GetPatentTimeStatisticsInfo_DataItem();
				dataItem.Type = _ctx.StringValue("GetPatentTimeStatisticsInfo.Data["+ i +"].Type");
				dataItem.HalfMonthCount = _ctx.LongValue("GetPatentTimeStatisticsInfo.Data["+ i +"].HalfMonthCount");
				dataItem.MonthCount = _ctx.LongValue("GetPatentTimeStatisticsInfo.Data["+ i +"].MonthCount");
				dataItem.TwoMonthCount = _ctx.LongValue("GetPatentTimeStatisticsInfo.Data["+ i +"].TwoMonthCount");
				dataItem.ThreeMonthCount = _ctx.LongValue("GetPatentTimeStatisticsInfo.Data["+ i +"].ThreeMonthCount");
				dataItem.ExpiredCount = _ctx.LongValue("GetPatentTimeStatisticsInfo.Data["+ i +"].ExpiredCount");

				getPatentTimeStatisticsInfoResponse_data.Add(dataItem);
			}
			getPatentTimeStatisticsInfoResponse.Data = getPatentTimeStatisticsInfoResponse_data;
        
			return getPatentTimeStatisticsInfoResponse;
        }
    }
}
