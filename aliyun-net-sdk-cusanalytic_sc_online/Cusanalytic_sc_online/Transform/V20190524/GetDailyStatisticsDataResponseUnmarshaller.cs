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
using Aliyun.Acs.cusanalytic_sc_online.Model.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524
{
    public class GetDailyStatisticsDataResponseUnmarshaller
    {
        public static GetDailyStatisticsDataResponse Unmarshall(UnmarshallerContext context)
        {
			GetDailyStatisticsDataResponse getDailyStatisticsDataResponse = new GetDailyStatisticsDataResponse();

			getDailyStatisticsDataResponse.HttpResponse = context.HttpResponse;
			getDailyStatisticsDataResponse.CursorTime = context.StringValue("GetDailyStatisticsData.CursorTime");
			getDailyStatisticsDataResponse.ErrorMsg = context.StringValue("GetDailyStatisticsData.ErrorMsg");
			getDailyStatisticsDataResponse.Success = context.BooleanValue("GetDailyStatisticsData.Success");

			List<GetDailyStatisticsDataResponse.GetDailyStatisticsData_BaseStatisticsData> getDailyStatisticsDataResponse_baseStatisticsDatas = new List<GetDailyStatisticsDataResponse.GetDailyStatisticsData_BaseStatisticsData>();
			for (int i = 0; i < context.Length("GetDailyStatisticsData.BaseStatisticsDatas.Length"); i++) {
				GetDailyStatisticsDataResponse.GetDailyStatisticsData_BaseStatisticsData baseStatisticsData = new GetDailyStatisticsDataResponse.GetDailyStatisticsData_BaseStatisticsData();
				baseStatisticsData.MaleUvCount = context.IntegerValue("GetDailyStatisticsData.BaseStatisticsDatas["+ i +"].MaleUvCount");
				baseStatisticsData.StoreId = context.LongValue("GetDailyStatisticsData.BaseStatisticsDatas["+ i +"].StoreId");
				baseStatisticsData.Day = context.StringValue("GetDailyStatisticsData.BaseStatisticsDatas["+ i +"].Day");
				baseStatisticsData.LocationId = context.LongValue("GetDailyStatisticsData.BaseStatisticsDatas["+ i +"].LocationId");
				baseStatisticsData.StayPeriod = context.IntegerValue("GetDailyStatisticsData.BaseStatisticsDatas["+ i +"].StayPeriod");
				baseStatisticsData.UvCount = context.IntegerValue("GetDailyStatisticsData.BaseStatisticsDatas["+ i +"].UvCount");
				baseStatisticsData.OnlyBodyUvCount = context.IntegerValue("GetDailyStatisticsData.BaseStatisticsDatas["+ i +"].OnlyBodyUvCount");
				baseStatisticsData.Hour = context.StringValue("GetDailyStatisticsData.BaseStatisticsDatas["+ i +"].Hour");
				baseStatisticsData.FemaleUvCount = context.IntegerValue("GetDailyStatisticsData.BaseStatisticsDatas["+ i +"].FemaleUvCount");
				baseStatisticsData.OldCount = context.IntegerValue("GetDailyStatisticsData.BaseStatisticsDatas["+ i +"].OldCount");
				baseStatisticsData.NewCount = context.IntegerValue("GetDailyStatisticsData.BaseStatisticsDatas["+ i +"].NewCount");

				getDailyStatisticsDataResponse_baseStatisticsDatas.Add(baseStatisticsData);
			}
			getDailyStatisticsDataResponse.BaseStatisticsDatas = getDailyStatisticsDataResponse_baseStatisticsDatas;
        
			return getDailyStatisticsDataResponse;
        }
    }
}
